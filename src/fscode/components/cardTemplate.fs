module app.components.cardTemplate
open System
open System.Diagnostics
open System.Text.RegularExpressions
open Fable.Core.JS
open Feliz.DaisyUI
open Feliz.style
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common
open app.common.globalTypes
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open Browser.Types
open Browser
open Fable.Core
open FSharp.Control


module Card =

  type [<StringEnum>] ExpandState=
    |Expand
    |Collapse
    member this.Switch =
      match this with
      |Expand -> Collapse
      |Collapse -> Expand
      
  type [<StringEnum>] PinState =
    |PinAtPage // 在页面上绝对定位
    |PinAtScreen // 在屏幕上固定定位
    |PinBetweenTabs // 在tab之间固定定位.
  with
    member this.Switch =
      match this with
      |PinAtPage -> PinAtScreen
      |PinAtScreen -> PinBetweenTabs
      |PinBetweenTabs -> PinAtPage
  end
  type FieldState={
    mutable expandState:ExpandState
    mutable IsMoving :bool
    mutable BeginMoveMouseAt:float
    mutable BeginMoveElementAt:float
    mutable url:string
    mutable createTime:float
    mutable editTime:float
    mutable Id:string
  }
  with
    static member init id=
      let t= thisTime.valueOf()
      {
        expandState=Collapse
        IsMoving = false
        BeginMoveMouseAt= -1
        BeginMoveElementAt= -1
        editTime = t
        createTime = t
        url = window.location.href
        Id = id
      }
  type FieldEvent={
    MoveBegin:Event<string*pointF> // string => Id of field pointF=>position mousedown
    FieldMoveEnd:Event<string*int> // string => Id of field int=> position to insert
  }
  with 
    static member init =
      {
        MoveBegin = Event<string*pointF>()
        FieldMoveEnd=Event<string*int>()
      }
  
  type[<StringEnum>] Msg=
    |Close
    |MoveBegin
    |MoveEnd
    |Pin
    |FieldMoveBegin
    |FieldMoveEnd
  type State ={
    mutable IsMoving:bool
    mutable MoveBeginAt:MouseDomPoint
    mutable pinState:PinState
    mutable DumbList:HTMLElement list // when field move
    mutable PlaceHolder:HTMLElement
    mutable FieldIsMoving:bool
    mutable FieldBeginMoveMouseAt:float
    mutable FieldBeginMoveElementAt:float
  }
  with
    static member init =
      let placeHolder = document.createElement"div"
      placeHolder.classList.add Card_self.S
      placeHolder.classList.add Common_flex_grow_1.S
      placeHolder.style.minHeight <-"70px"
      {
      IsMoving = false
      MoveBeginAt = MouseDomPoint.set -1 -1 -1 -1
      pinState = PinAtPage
      DumbList=[] // when field move
      PlaceHolder = placeHolder
      FieldIsMoving = false 
      FieldBeginMoveMouseAt = -1 
      FieldBeginMoveElementAt = -1
    }
  type Event' = {
    Close :Event<unit>
    MoveBegin:Event<pointF>
    MoveEnd:Event<unit>
    Pin:Event<pointF>
  }
  with
    static member init = {
          Close=Event<unit>()
          MoveBegin=Event<pointF>()
          MoveEnd=Event<unit>()
          Pin=Event<pointF>()
    }
  
  type CardFieldContent = |Text of string |Image of string

    let cardField (content:CardFieldContent)=
    Div [
      classes [CardField_self]
    ] [
      Div [classes [Common_glass;Common_btn];Id CardField_dragBar
           InnerHtml <| ICON.VerticalMoveBar [] 
           ] []
      Div [classes [Common_glass];Id CardField_content] [
        match content with
        |Text s -> TextArea [classes [Common_textArea;Common_glass];Id CardField_content_text
                             TextAreaValue s ] []
        |Image s-> Img  [Src s;Id CardField_content_img
                         ] []
      ]
      Div [classes [Common_glass;];Id CardField_btns] [
        Div [classes [Common_glass;Common_btn] ;Id CardField_btns_link 
             InnerHtml <| ICON.link 
             ] []
        Div [classes [Common_glass;Common_btn] ;Id CardField_btns_expand
             InnerHtml <| ICON.expand] []
        Div [classes [Common_glass;Common_btn] ;Id CardField_btns_del
             InnerHtml <| ICON.del 
             ] []
      ]
    
    ]

  let testField() = cardField <| Text "123"
  let testField2() = cardField <| Image URL.logo
  let atom (point:pointF) =
    Div [
      classes [Common_component;Common_glass]; Id Card_carrier
      CSSPosition point.ToPx
    ] [

      Div [ classes [Common_glass;];Id Card_self ] [
        Div [ classes [Common_glass];Id Card_header ] [
          Div [classes [Common_glass;Card_header_side_btn];Id Card_header_left_btn] [
            Span [classes [Common_glass;Common_btn];Id Card_header_btn_addImg
                  InnerHtml <| ICON.newClip []
                  ] []
            Span [classes [Common_glass;Common_btn];Id Card_header_btn_addTxt
                  InnerHtml <| ICON.newText []
                  ] []
          ]
          Span [classes [Common_moveBar;Common_glass;Common_btn]
                Id Card_header_btn_move ; InnerHtml <| ICON.HorizontalMoveBar []] []
          Div [classes [Common_glass;Card_header_side_btn] ;Id Card_header_right_btn] [
                Span [classes [Common_glass;Common_btn];Id Card_header_btn_pin ; InnerHtml <| ICON.pin [] ] []
                Span [classes [Common_glass;Common_btn];Id Card_header_btn_close ; InnerHtml <| ICON.close [] ] []
          ]
        
        
        ]
        Div [Id Card_body] [

        
      ]
      ]
      
    ]
  
  
  
  type Core(env:GlobalCore,view:Brick,Id:string) as this=
    inherit ICore(view,Id)
    member val event = Event'.init with get,set
    member val state = State.init with get,set
    member val fieldState:Map<string,FieldState> =Map<string,FieldState>[] with get,set
    member val fieldEvent:Map<string,FieldEvent> =Map<string,FieldEvent>[] with get,set
    member val env = env with get,set
    member val op_view:Op_View  = Op_View(this)
    member val op_field:Op_Field = Op_Field(this)
  
  and  Op_View (env:Core) as self=
    member val env = env
    member this.Position (nowMouseAt:pointF) =
      
      let style = env.view.element.Value.style
      let oldMouse = env.state.MoveBeginAt.mousePoint
      let oldElem = env.state.MoveBeginAt.elementPoint
      let extraLeft  = if this.env.state.pinState = PinAtPage then window.scrollX else 0
      let extraTop  = if this.env.state.pinState = PinAtPage then window.scrollY else 0
      style.left <- $"{oldElem.left+nowMouseAt.left-oldMouse.left + extraLeft}px"
      style.top <- $"{oldElem.top+nowMouseAt.top-oldMouse.top +  extraTop}px"
    
    member this.AfterPinSwitch () =
      let Pin = env.view.hashmap.[Card_header_btn_pin.S].element.Value
      let carrier = this.env.view.hashmap[Card_carrier.S].element.Value
      let styP = pointF.set (getFloat(carrier.style.left))  (getFloat(carrier.style.top))  
      let cliP = pointF.set (carrier.getBoundingClientRect().left) (carrier.getBoundingClientRect().top)
      let scrollP =pointF.set window.scrollX window.scrollY
      match env.state.pinState with
      |PinAtPage ->
        Pin.style.background<-"transparent"
        let p = cliP + scrollP
        carrier.style.left <- $"{p.left}px"
        carrier.style.top <- $"{p.top}px"
        carrier.style.position <- "absolute"
      |PinAtScreen ->
        Pin.style.background<-"yellow"
        let p = styP - scrollP
        carrier.style.left <- $"{p.left}px"
        carrier.style.top <- $"{p.top}px"
        carrier.style.position <- "fixed"
        
      |PinBetweenTabs ->
        Pin.style.background<-"#7e7"
        
    member this.scrollToBottom =
      let body = this.env.view.hashmap[Card_body.S].element.Value
      body.scrollTo(0,body.scrollHeight-body.clientHeight)
      ()
    member this.positionFix (p:pointF) =
      let carrier = this.env.view.hashmap[Card_carrier.S].element.Value
      let Pin = env.view.hashmap.[Card_header_btn_pin.S].element.Value
      let styP = pointF.set (getFloat(carrier.style.left))  (getFloat(carrier.style.top))  
      let cliP = pointF.set (carrier.getBoundingClientRect().left) (carrier.getBoundingClientRect().top)
      let scrollP =pointF.set window.scrollX window.scrollY
      match this.env.state.pinState with
      |PinAtPage ->
        let newp = p + scrollP
        pointF.setElementPosition carrier newp
        carrier.style.position <- "absolute"
        
      |PinAtScreen->
        carrier.style.position <- "fixed"
      |PinBetweenTabs->
        carrier.style.position <- "fixed"
        
        
        
  and Op_Field (env:Core)  as self=
    member val lastY:float = -1 with get,set
    member val env = env
    member this.delFields (fields:Brick list) =
      let body = this.env.view.hashmap[Card_body.S]
      let delDom fields=
        fields |> List.map (fun (e:Brick)->e.element.Value.remove()) |> ignore
        fields
      let delBrick fields=
          fields |> List.map (fun (e:Brick)->
             body.children <- body.children |> List.filter (fun f->e.Id<>f.Id)
          )|>ignore
          fields
      let delHashMap fields= 
        let units = 
          fields |> List.map (fun (e:Brick)->
              this.env.view.hashmap<-this.env.view.hashmap.Remove e.Id
          )
        fields
      
      fields|>delDom|>delBrick|>delHashMap
      
    member this.addFields (fields:Brick list) =
      let body = this.env.view.hashmap[Card_body.S]
      let insertDom fields=
        fields |> List.map (fun (e:Brick)->
        body.element.Value.appendChild e.element.Value|> ignore
        e
        )
      let insertBrick fields=
        body.children@fields |> ignore
        fields
      let insertHashMap fields=
        fields |> List.iter (fun (e:Brick)->
          this.env.view.hashmap<-this.env.view.hashmap.Add(e.Id,e)
          )
        fields
      fields |> insertDom |>insertBrick |>insertHashMap |> this.eventSubscribe

    member this.addTextFields (txts:string list)=
      txts |>List.map (fun (t:string)->
        t|> Text |> cardField |> build  ) |> this.addFields
    member this.addImgFields (imgs:string list)=
      imgs |> List.map (fun (i:string)->
        i|> Image |> cardField |> build 
        )|> this.addFields
    
    member this.updateIndexOfBodyChildren =
      let body = this.env.view.hashmap[Card_body.S]
      let kids = body.element.Value.children
      let IdFromDom=[for i=0 to kids.length-1 do kids[i].id]   //body.element.Value.children|> Seq.map (fun (e:Element)-> e.id)
      body.children <-body.children |> List.sortWith (fun a b->
          let aIdx = IdFromDom|>List.findIndex (fun e->e=a.Id)
          let bIdx = IdFromDom|>List.findIndex (fun e->e=b.Id)
          aIdx - bIdx
        )
      ()  

    member this.dragEvent (fields:Brick list) =
      let div = document.createElement "div"
      div.classList.add CardField_self.S
      div.style.minHeight <- "70px"
      div.id <- "placeHolder"
      fields |> List.map (fun (field:Brick)-> 
        let movingEl = field.element.Value
        
   
        let mutable isMoving = false
        let mutable beginMouseY:float = -1.0
        let mutable beginElemY = -1.0
        let mutable oldY = -1.0
        let body = this.env.view.hashmap[Card_body.S].element.Value
        let kids() = [for i =0 to body.children.length-1 do body.children[i]]
                     |> List.filter (fun (e:Element)-> 
                       (e.id <> "placeHolder") && (e.id <> field.Id) 
          )
        
        let moveBar = field.hashmap.[CardField_dragBar.S].element.Value
        let event  = this.env.fieldEvent[field.Id]
        
        moveBar.onmousedown <- fun e->
          movingEl.insertAdjacentElement ("afterend",div)|>ignore
          movingEl.style.zIndex <- "999"
          let marginTop =  float (Regex("\d+").Matches(window.getComputedStyle(movingEl).marginTop)).[0].Value
          let top = movingEl.offsetTop - marginTop - body.scrollTop
          movingEl.style.top <- $"{movingEl.offsetTop - marginTop - body.scrollTop}px"
          movingEl.style.position <- "absolute"
          beginMouseY <-  e.clientY
          beginElemY <- top
          isMoving <- true
        let rec scroll Y2 =
          let bodyTop = body.getBoundingClientRect().top
          let bodyBottom = body.getBoundingClientRect().bottom
          if (bodyTop < Y2 && Y2 - bodyTop < 20 && body.scrollTop > 0) then
            body.scrollTo(0, body.scrollTop - 1.0)
            let job =  async{
              do! Async.Sleep 20
              if (Math.abs (Y2-oldY)<3)then
                scroll oldY
            }
            Async.StartImmediate job
            
          if (bodyBottom > Y2 && bodyBottom - Y2 < 20 && body.scrollHeight - body.scrollTop - body.clientHeight > 0) then
            body.scrollTo(0, body.scrollTop + 1.0)
            let job =  async{
              do! Async.Sleep 20
              if (Math.abs (Y2-oldY)<3)then
                scroll oldY
            }
            Async.StartImmediate job
            
            
        this.env.env.event.mouseMoving.Publish.Add (fun e->
            if isMoving && e.buttons = 1 then
              let rr = kids()
              let elTop = movingEl.getBoundingClientRect().top
              let elBottom = movingEl.getBoundingClientRect().bottom
              rr|> List.iter ( fun (k)->
                  let j:HTMLElement = k:?>HTMLElement
                  let jTop = j.getBoundingClientRect().top
                  let jBottom = j.getBoundingClientRect().bottom
                  let jMid =  (jTop+jBottom)/2.0
                  if (elTop<jMid && elBottom>jBottom) then
                    j.insertAdjacentElement("beforebegin",div)|> ignore
                  if (elBottom>jMid && elTop<jTop) then
                    j.insertAdjacentElement("afterend",div) |> ignore 
                  ()
                )
              oldY <- e.clientY
              scroll oldY
              movingEl.style.top <- $"{beginElemY+e.clientY-beginMouseY}px"
          )
        
        this.env.env.event.mouseUp.Publish.Add (fun e->
            if isMoving then
              isMoving <- false
              movingEl.style.position<-""
              movingEl.style.zIndex <- ""
              body.replaceChild(movingEl,div)|>ignore
              this.updateIndexOfBodyChildren
          
          )
        field
    ) 
            
    member this.eventSubscribe (fields:Brick list) =
      let cardBody = this.env.view.hashmap.[Card_body.S]
      fields |> List.map (fun (field:Brick)->
          let event = FieldEvent.init
          let state = FieldState.init field.Id
          this.env.fieldEvent<-this.env.fieldEvent.Add (field.Id, event)
          this.env.fieldState<-this.env.fieldState.Add (field.Id, state)
          let del = field.hashmap.[CardField_btns_del.S].element.Value
          let expand = field.hashmap.[CardField_btns_expand.S].element.Value
          let link = field.hashmap.[CardField_btns_link.S].element.Value
          link.onclick <- fun e-> window.``open``(state.url)|>ignore
          del.onclick <- fun e-> this.delFields [field]|>ignore
          
          expand.onclick <- fun e->
            match state.expandState with
            |Collapse -> field.element.Value.classList.add CardField_expanded.S
            |Expand -> field.element.Value.classList.remove CardField_expanded.S
            state.expandState<-state.expandState.Switch

          field
        )|> this.dragEvent

      

  let Init (env:GlobalCore) (p:pointF) =
    let view = build <|atom (p:pointF)
    
    let core = Core(
      env = env,
      view = view,
      event = Event'.init,
      state = State.init,
      Id = view.element.Value.id
    )
    
    console.log "hashmap"
    // console.log core.view.hashmap.[Card_header_btn_close.S]
    let close =core.view.hashmap.[Card_header_btn_close.S].element.Value
    let move = core.view.hashmap.[Card_header_btn_move.S].element.Value
    let pin = core.view.hashmap.[Card_header_btn_pin.S].element.Value
    let addTxt = core.view.hashmap.[Card_header_btn_addTxt.S].element.Value
    let addImg = core.view.hashmap[Card_header_btn_addImg.S].element.Value
    let cardBody = core.view.hashmap.[Card_body.S]
    let self = core.view.element.Value
    self.onclick <- fun e-> core.env.state.setFocus self
      
    addTxt.onclick<- fun e->
      
      let bricks = core.op_field.addTextFields [thisTime.toLocaleString()+ "\n" ]
      core.op_view.scrollToBottom
      
      
      ()
    addImg.onclick <- fun e-> env.event.screenCapBegin.Trigger(core.Id)

    close.onclick<- fun e->
      console.log "close triggered"
      core.event.Close.Trigger()
    move.onmousedown<- fun e->
      let self = core.view.element.Value
      let oldSelfP = pointF.fromElement self
      let oldMouseP = pointF.fromMouseEvent e
      Op_element.addMask  core.env.root
      // core.env.root.classList.add(Common_mask.S)
      let mutable IsMoving = true
      let onMoveHandle = Handler<MouseEvent>(         
          fun sender e2->
          if IsMoving && e2.buttons =1 then    
            let newMouseP = pointF.fromMouseEvent e2
            pointF.setElementPosition self (oldSelfP+(newMouseP-oldMouseP))
            ()
        )
      let onBtnUpHandle = Handler<MouseEvent>(
          fun sender e3 ->
            if IsMoving then
              IsMoving<-false
              core.env.event.mouseMoving.Publish.RemoveHandler onMoveHandle
              Op_element.delMask core.env.root
        )
      core.env.event.mouseMoving.Publish.AddHandler onMoveHandle
      core.env.event.mouseUp.Publish.AddHandler onBtnUpHandle
      ()
      
    pin.onclick<- fun e->
      core.state.pinState<- core.state.pinState.Switch
      core.op_view.AfterPinSwitch()
      
    core.event.Close.Publish.Add <| fun e->
      env.root.removeChild core.view.element.Value |>ignore
    core.event.MoveBegin.Publish.Add <| fun e->
      let r = view.element.Value.getBoundingClientRect()
      core.state.MoveBeginAt <- MouseDomPoint.set e.left e.top r.left r.top
      core.state.IsMoving <-true
    core.event.Pin.Publish.Add <| fun e->
      core.state.pinState <- core.state.pinState.Switch
      core.op_view.AfterPinSwitch()
      
    env.event.mouseMoving.Publish.Add <| fun e-> 
      if core.state.IsMoving then
        core.op_view.Position (pointF.set e.clientX e.clientY)
    env.event.mouseUp.Publish.Add <| fun e->
      core.state.IsMoving <-false
    env.addMember core
    core.op_view.AfterPinSwitch()
    core
  //从内存读取
  let load (guid:string) = ()
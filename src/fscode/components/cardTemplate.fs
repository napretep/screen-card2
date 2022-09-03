module app.components.cardTemplate
open System.Text.RegularExpressions
open Fable.Core.JS
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common.globalTypes
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.storageTypes
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
    |PinToPage // 在页面上绝对定位
    |AmongScreen // 在屏幕上固定定位
    |TransTab // 在tab之间固定定位.
  with
    member this.Switch =
      match this with
      |PinToPage -> AmongScreen
      |AmongScreen -> TransTab
      |TransTab -> PinToPage
    member this.getNumber =
      match this with 
      |PinToPage -> 0
      |AmongScreen -> 1
      |TransTab -> 2
    static member fromNumber (n:float)=
      match int n with
      |0 -> PinToPage
      |1 -> AmongScreen
      |2 -> TransTab
    member this.S=this.ToString()  
  end
  type FieldState={
    mutable expandState:ExpandState
    mutable IsMoving :bool
    mutable BeginMoveMouseAt:float
    mutable BeginMoveElementAt:float
    mutable url:string
    mutable webScrollTo:pointF
    mutable createTime:float
    mutable editTime:float
    mutable Id:string
    mutable content:string // 当 text时, 是textvalue, 当 是 image 时, 是dataURL
    mutable contentKind:float // 0 表示 text, 1表示image 
  }
  with
    static member init id content kind=
      let t= thisTime.valueOf()
      {
        expandState=Collapse
        BeginMoveMouseAt= -1
        BeginMoveElementAt= -1
        IsMoving = false
        webScrollTo = pointF.set window.scrollX window.scrollY
        content=content
        contentKind=kind
        editTime = t
        createTime = t
        url = window.location.href
        Id = id
      }
    member this.Save:Save.CardField =
      {
        majorKind = SaveKind.CardField
        contentKind = this.contentKind
        content = this.content
        url = this.url
        webScrollTo = this.webScrollTo.toTuple
        createTime=this.createTime
        editTime =this.editTime
        Id=this.Id
      }
    member this.clone (field:Save.CardField)=
      this.webScrollTo<-pointF.fromTuple field.webScrollTo
      this.content<-field.content
      this.contentKind<-field.contentKind
      this.editTime <-field.editTime
      this.createTime<-field.createTime
      this.url<-field.url
      this.Id <-field.Id
    
    
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
    mutable createTime:float
    mutable editTime:float
    mutable url:string
    mutable webScrollTo:pointF
    mutable position:pointF
    mutable size:size2d
    mutable show:bool
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
      DumbList=[] // when field move
      PlaceHolder = placeHolder
      FieldIsMoving = false 
      FieldBeginMoveMouseAt = -1 
      FieldBeginMoveElementAt = -1
      //save data
      url = window.location.href
      webScrollTo = pointF.set window.scrollX window.scrollY
      createTime= thisTime.valueOf()
      editTime= thisTime.valueOf()
      pinState = PinToPage
      size=size2d.zero
      position = pointF.zero
      show=true
    }
    member this.clone (card:Save.Card) =
      this.url<-card.url
      this.webScrollTo<-pointF.fromTuple card.webScrollTo
      this.createTime <-card.createTime
      this.editTime <- card.editTime
      this.pinState<- PinState.fromNumber card.pin
      this.size <- size2d.fromTuple card.size
      this.position <- pointF.fromTuple card.position
      this.show<- card.show
      ()
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
    member val op_state  = Op_State(this)
    member val op_view:Op_View  = Op_View(this)
    member val op_field:Op_Field = Op_Field(this)
  and Op_State (env:Core)  =
    member val env = env
    member this.save=
      let fieldsState = this.env.view.hashmap[Card_body.S].children
                        |> List.map (fun (b:Brick)->this.env.fieldState[b.Id].Save)|>List.toArray
      // console.log fieldsState
      let carrier = this.env.view.element.Value
      let body = this.env.view.hashmap[Card_body.S].element.Value
      let p = pointF.fromElementBounding carrier
      let r = size2d.fromElementBounding body
      let state = this.env.state
      let save:Save.Card  = 
        {
          Id=this.env.Id
          majorKind = SaveKind.Card
          createTime = state.createTime
          editTime = state.editTime
          fields = fieldsState
          pin = float state.pinState.getNumber
          position = p.toTuple
          size = r.toTuple
          url = state.url
          webScrollTo = state.webScrollTo.toTuple
          show=state.show
        }
      console.log save
      DataStorage.set save.Id save
      ()
  and  Op_View (env:Core) =
    member val env = env
    member this.init =
      let carrier = this.env.view.element.Value
      let body = this.env.view.hashmap[Card_body.S].element.Value
      let state = this.env.state
      pointF.setElementPosition carrier state.position
      console.log state.size 
      size2d.setElementStyleSize body state.size 
      this.setPinColor
      this.AfterSetPinColor state.position
      
    member this.movePosition (nowMouseAt:pointF) =
      
      let style = env.view.element.Value.style
      let oldMouse = env.state.MoveBeginAt.mousePoint
      let oldElem = env.state.MoveBeginAt.elementPoint
      let extraLeft  = if this.env.state.pinState = PinToPage then window.scrollX else 0
      let extraTop  = if this.env.state.pinState = PinToPage then window.scrollY else 0
      style.left <- $"{oldElem.left+nowMouseAt.left - oldMouse.left + extraLeft}px"
      style.top <- $"{oldElem.top+nowMouseAt.top - oldMouse.top +  extraTop}px"
    
    member this.repositionWhenPinChanged () =
      let Pin = env.view.hashmap[Card_header_btn_pin.S].element.Value
      let carrier = this.env.view.hashmap[Card_carrier.S].element.Value
      let styP = pointF.set (getFloat(carrier.style.left))  (getFloat(carrier.style.top))  
      let cliP = pointF.set (carrier.getBoundingClientRect().left) (carrier.getBoundingClientRect().top)
      let scrollP =pointF.set window.scrollX window.scrollY
      match env.state.pinState with
      |PinToPage ->
        Pin.style.background<-"transparent"
      |AmongScreen ->
        Pin.style.background<-"yellow"
      |TransTab ->
        Pin.style.background<-"#7e7"
       
        ()
    member this.scrollToBottom =
      let body = this.env.view.hashmap[Card_body.S].element.Value
      body.scrollTo(0,body.scrollHeight-body.clientHeight)
      ()
    member this.pinPositionFix (p:pointF) =
      let carrier = this.env.view.hashmap[Card_carrier.S].element.Value
      let Pin = env.view.hashmap[Card_header_btn_pin.S].element.Value
      let styP = pointF.set (getFloat(carrier.style.left))  (getFloat(carrier.style.top))  
      let cliP = pointF.set (carrier.getBoundingClientRect().left) (carrier.getBoundingClientRect().top)
      let scrollP =pointF.set window.scrollX window.scrollY
      match this.env.state.pinState with
      |PinToPage ->
        let newp = p + scrollP
        pointF.setElementPosition carrier newp
        carrier.style.position <- "absolute"
      |AmongScreen->
        carrier.style.position <- "fixed"
      |TransTab->
        carrier.style.position <- "fixed"
    member this.AfterSetPinColor (p:pointF)=
      let carrier = this.env.view.hashmap[Card_carrier.S].element.Value
      let scrollP =pointF.set window.scrollX window.scrollY
      let pinState = this.env.state.pinState
      let Id' = this.env.Id
      match pinState with
      |PinToPage -> // absolute
        let newp = p + scrollP
        
        carrier.style.position <- "absolute"
        pointF.setElementPosition carrier newp
        this.env.env.RemoveFromTransTab Id'
        DataStorage.appendUnique this.env.state.url Id'
      |AmongScreen ->
        carrier.style.position <- "fixed"
        pointF.setElementPosition carrier p
        this.env.env.RemoveFromTransTab Id'
        DataStorage.appendUnique this.env.state.url Id'
      |TransTab ->
        carrier.style.position <- "fixed"  
        pointF.setElementPosition carrier p
        
        this.env.env.AppendToTransTab Id'
        
        ()
      ()
    member this.setPinColor =
      let Pin = env.view.hashmap[Card_header_btn_pin.S].element.Value
      match env.state.pinState with
      |PinToPage ->
        Pin.style.background<-"transparent"
      |AmongScreen ->
        Pin.style.background<-"yellow"
      |TransTab ->
        Pin.style.background<-"#7e7"
    // member this.checkPin =
      
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
        body.children<-body.children@fields  
        fields
      let insertHashMap fields=
        fields |> List.iter (fun (e:Brick)->
          this.env.view.hashmap<-this.env.view.hashmap.Add(e.Id,e)
          )
        fields
      fields |> insertDom |>insertBrick |>insertHashMap |> this.eventSubscribe

    member this.makeBrickAndStateEvent (content:string) (kind:int) (id':string option)=
      let brick = build (cardField (if kind=0 then Text content else Image content))
      id' |> Option.iter (fun i ->
          brick.Id<- i
          brick.element.Value.id<- i
        )
      let state = FieldState.init brick.Id content (float kind)
      this.env.fieldEvent<-this.env.fieldEvent.Add(brick.Id,FieldEvent.init)
      this.env.fieldState<-this.env.fieldState.Add(brick.Id,state)
      brick
    member this.addTextFields (txts:string list)=
      txts |>List.map (fun (t:string)-> this.makeBrickAndStateEvent t 0 None) |> this.addFields
    member this.addImgFields (imgs:string list)=
      imgs |> List.map (fun (i:string)->this.makeBrickAndStateEvent i 1 None )|> this.addFields
    
    member this.clearFields=
      let body = this.env.view.hashmap[Card_body.S]
      let mutable hashmap = this.env.view.hashmap 
      //清空 brick, hashmap, Dom, state, event
      body.children |> List.iter (fun (kid:Brick)->hashmap<-hashmap.Remove kid.Id)
      this.env.view.hashmap <- hashmap
      for i=0 to body.children.Length-1 do
        body.children[i].element.Value.remove()
      body.children <- []
      this.env.fieldEvent<-Map<string,FieldEvent>[]
      this.env.fieldState<-Map<string,FieldState>[]
      
      ()
    member this.loadFields (fields:Save.CardField array) =
      fields |> Seq.toList|>List.map (fun (field:Save.CardField)->
        let brick = this.makeBrickAndStateEvent field.content (int field.contentKind )(Some field.Id)
        this.env.fieldState[field.Id].clone field
        brick
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
        
        let moveBar = field.hashmap[CardField_dragBar.S].element.Value
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
          let event = this.env.fieldEvent[field.Id]
          let state = this.env.fieldState[field.Id]
          let del = field.hashmap.[CardField_btns_del.S].element.Value
          let expand = field.hashmap.[CardField_btns_expand.S].element.Value
          let link = field.hashmap.[CardField_btns_link.S].element.Value
          if state.contentKind=0 then
            let content_text = field.element.Value.querySelector($"#{CardField_content_text.S}"):?>HTMLTextAreaElement
            content_text.onchange<- fun e->
                state.content<-content_text.value
          link.onclick <- fun e-> window.``open``(state.url)|>ignore
          del.onclick <- fun e-> this.delFields [field]|>ignore
          
         
          expand.onclick <- fun e->
            match state.expandState with
            |Collapse -> field.element.Value.classList.add CardField_expanded.S
            |Expand -> field.element.Value.classList.remove CardField_expanded.S
            state.expandState<-state.expandState.Switch

          field
        )|> this.dragEvent

      

  let Init (env:GlobalCore) (p:pointF) id =
    let view = build <|atom (p:pointF)
    
    let core = Core(
      env = env,
      view = view,
      event = Event'.init,
      state = State.init,
      Id = id
    )
    
    console.log "hashmap"
    // console.log core.view.hashmap.[Card_header_btn_close.S]
    let close =core.view.hashmap[Card_header_btn_close.S].element.Value
    let move = core.view.hashmap[Card_header_btn_move.S].element.Value
    let pin = core.view.hashmap[Card_header_btn_pin.S].element.Value
    let addTxt = core.view.hashmap[Card_header_btn_addTxt.S].element.Value
    let addImg = core.view.hashmap[Card_header_btn_addImg.S].element.Value
    
    let cardBody = core.view.hashmap[Card_body.S]
    let self = core.view.element.Value
    self.onclick <- fun e->
      core.env.state.setFocus self
    self.onmouseup <- fun e->
      JS.setTimeout (fun e->core.op_state.save |> ignore) 100
      
      ()
    
    
    
    addTxt.onclick<- fun e->
      
      core.op_field.addTextFields [thisTime.toLocaleString()+ "\n" ]
      core.op_view.scrollToBottom
      core.op_state.save
      
      ()
    addImg.onclick <- fun e-> env.event.screenCapBegin.Trigger(core.Id)

    close.onclick<- fun e->
      console.log "close triggered"
      core.env.RemoveFromTransTab core.Id
      core.state.show<-false
      core.op_state.save
      core.env.removeMember core|>ignore
      core.event.Close.Trigger()
      
    move.onmousedown<- fun e->
      let self = core.view.element.Value
      let oldSelfP = pointF.fromElementStyle self
      let oldMouseP = pointF.fromMouseEvent e
      core.env.root|> Op_element.addMask |> ignore  
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
              core.env.root|>Op_element.delMask|> ignore
              ()
        )
      core.env.event.mouseMoving.Publish.AddHandler onMoveHandle
      core.env.event.mouseUp.Publish.AddHandler onBtnUpHandle
      ()
      
    pin.onclick<- fun e->
      core.state.pinState <- core.state.pinState.Switch
      core.op_view.setPinColor
      core.op_view.AfterSetPinColor (pointF.fromElementBounding core.view.element.Value)
      
    core.event.Close.Publish.Add <| fun e->
      env.root.removeChild core.view.element.Value |>ignore
    core.event.MoveBegin.Publish.Add <| fun e->
      let r = view.element.Value.getBoundingClientRect()
      core.state.MoveBeginAt <- MouseDomPoint.set e.left e.top r.left r.top
      core.state.IsMoving <-true

      
    env.event.mouseMoving.Publish.Add <| fun e-> 
      if core.state.IsMoving then
        core.op_view.movePosition (pointF.set e.clientX e.clientY)
    env.event.mouseUp.Publish.Add <| fun e->
      core.state.IsMoving <-false
    env.addMember core
    core.op_view.setPinColor
    core.op_view.AfterSetPinColor (pointF.fromElementBounding core.view.element.Value)
    core
  //从内存读取
  let load (env:GlobalCore) (card:Save.Card) =
    let p = pointF.fromTuple card.position
    let pin = PinState.fromNumber card.pin
    let core =
      match env.hashMap.TryFind card.Id with
      |Some iCore ->
        iCore:?>Core 
      |_->Init env p card.Id
    console.log card
    core.state.clone card // 这个地方 很重要, 以后新增什么属性, 需要看看有没有成功克隆
    core.op_view.init
    core.op_field.clearFields
    core.op_field.loadFields card.fields
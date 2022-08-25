module app.components.assistDot
//
//
// [<RequireQualifiedAccess>]
// module AssistDot =
//     type Model = {visible:bool;height:int}
//     
//     [<RequireQualifiedAccess>]
//     type Msg = |Close|Move
//     
//     
//     let init ()= {visible=true;height=400}
//     
//     let update model msg = init()
//     let view (model: Model) (dispatch: Msg -> unit)=
//         Daisy.menu [
//             
//             prop.children[
//                 Html.li [Html.a [prop.text "📚" ]]
//                 Html.li [Html.a [prop.text "❌" ]]]
//         ]
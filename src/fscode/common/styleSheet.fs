module app.common.styleSheet
open Fable.Core

type [<StringEnum>] CssClass =
    |Common_Shadow
    |``Common-backdropBlur``
    |``Common-fixed``
    |Common_glass
    |Common_component
    |Common_btn
    |AssistDot_self
    |AssistDot_btn
    |``CardLib-1-Root``
    |``CardTemplate-btn-``
type Str =
    |String of string
    |CssClass of CssClass

let commonStyle = $"
.{Common_glass}{{
/* From https://css.glass */
backdrop-filter: blur(25px) ;
-webkit-backdrop-filter: blur(25px) saturate(200%%);
background-color: rgba(189, 211, 207, 0.3);
border: 1px solid rgba(209, 213, 219, 0.3);
margin:1px;
}}
.{Common_Shadow}{{
    box-shadow: 0px 0px 8px;
}}
.{``Common-backdropBlur``}{{
    backdrop-filter:blur(20px);
}}
.{Common_component}{{
    position:fixed;
    background-color:transparent;
    z-index : 999999
}}
.{``Common-fixed``}{{
    position:fixed;
}}

.{Common_btn}{{
    width:20px;
    height:20px;
}}

.{Common_btn}:hover{{
    background-color: rgba(248, 248, 248, 0.7);
    cursor:pointer;
}}

.{AssistDot_self}{{
    
    display:flex;
    flex-direction: column;
}}



.{``CardLib-1-Root``}{{

}}

"


module app.common.styleSheet
open Fable.Core

type [<StringEnum>] CssClass =
    |``Common-Shadow``
    |``Common-backdropBlur``
    |``Common-fixed``
    |``Common-glass``
    |``Common-component``
    |``CardLib-1-Root``
    |``CardTemplate-btn-``
type Str =
    |String of string
    |CssClass of CssClass

let commonStyle = $"
.{``Common-glass``}{{
/* From https://css.glass */
background: rgba(240, 240, 240, 0.32);
border-radius: 1px;
box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
backdrop-filter: blur(20px);
-webkit-backdrop-filter: blur(20px);
border: 1px solid rgba(240, 240, 240, 0.55);
}}
.{``Common-Shadow``}{{
    box-shadow: 0px 0px 8px;
}}
.{``Common-backdropBlur``}{{
    backdrop-filter:blur(20px);
}}
.{``Common-component``}{{
    position:fixed;
    background-color:transparent;
    z-index : 999999
}}
.{``Common-fixed``}{{
    position:fixed;
}}
.{``CardLib-1-Root``}{{

}}
"
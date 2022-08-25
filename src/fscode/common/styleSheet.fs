module app.common.styleSheet
open Fable.Core

type [<StringEnum>] CssClass =
    |``Common-Shadow``
    |``CardLib-1-Root``
    |``CardTemplate-btn-``
    |``Common-backdropBlur``
type Str =
    |String of string
    |CssClass of CssClass

let commonStyle = $"
.{``Common-Shadow``}{{
    box-shadow: 0px 0px 8px;
}}
.{``CardLib-1-Root``}{{

}}
.{``Common-backdropBlur``}{{
    backdrop-filter:blur(20px)
}}
"
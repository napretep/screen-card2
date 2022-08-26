module app.common.styleSheet
open Fable.Core

type [<StringEnum>] CssClass =
    |``Common-Shadow``
    |``Common-backdropBlur``
    |``Common-fixed``
    |``CardLib-1-Root``
    |``CardTemplate-btn-``
type Str =
    |String of string
    |CssClass of CssClass

let commonStyle = $"
.{``Common-Shadow``}{{
    box-shadow: 0px 0px 8px;
}}
.{``Common-backdropBlur``}{{
    backdrop-filter:blur(20px);
}}
.{``Common-fixed``}{{
    position:fixed;
}}
.{``CardLib-1-Root``}{{

}}
"
module app.common.styleSheet
open Elmish.React
open Fable.Core

// [<RequireQualifiedAccess>]
type [<StringEnum>] CssClass =
    |Common_Shadow
    |Common_backdropBlur
    |Common_fixed
    |Common_glass
    |Common_component
    |Common_btn
    |Common_displayNone
    |Common_moveBar
    |Common_textArea
    |AssistDot_carrier
    |AssistDot_self
    |AssistDot_btn
    |AssistDot_close
    |AssistDot_newCard
    |AssistDot_cardLib
    |CardLib_carrier
    |CardLib_self
    |CardLib_toolbar
    |CardLib_toolbar_left
    |CardLib_toolbar_right
    |CardLib_container
    |CardLib_card_item
    |CardLib_card_content
    |CardLib_card_btns
    |CardLib_searchInput
    |Card_carrier
    |Card_self
    |Card_header
    |Card_header_btn_move
    |Card_header_btn_pin
    |Card_header_btn_close
    |Card_body
    |Card_body_menu
    |CardField_self
    |CardField_dragBar
    |CardField_content
    |CardField_content_text
    |CardField_content_img
    |CardField_btns
    
    with
        member this.S = this.ToString()
    end

let makeScrollBar selector = $"""
{selector}::-webkit-scrollbar {{
backdrop-filter: blur(25px) ;
    width: 8px;
    height: 8px;
}}
{selector}::-webkit-scrollbar-thumb {{
border-radius: 10px;
  box-shadow   : inset 0 0 5px rgba(0, 0, 0, 0.2);
  background   : #53535300;
}}
{selector}::-webkit-scrollbar-track {{
  box-shadow   : inset 0 0 5px rgba(0, 0, 0, 0.2);
  border-radius: 10px;
  background   : #ededed00;
}}
"""
let hideScrollBar selector = $"""
{selector}::-webkit-scrollbar {{
    width: 0px;
    height: 0px;
}}
{selector}::-webkit-scrollbar-thumb {{
}}
{selector}::-webkit-scrollbar-track {{
}}
"""
type Str =
    |String of string
    |CssClass of CssClass

let cardStyle = $"""
.{Card_carrier}{{
    
}}
.{Card_self}{{
	
}}
.{Card_body}{{
width:300px;
height:300px;
display:flex;
flex-direction:column;
align-items:center;
resize: both;
overflow: auto;
}}

{makeScrollBar $".{Card_body}"}

.{CardField_self}{{
	height:75px;
	width:95%%;
	display: flex;
	align-items:stretch;
	margin:3px;
}}
.{CardField_btns}{{
	height:auto;
	display:flex;
	flex-direction:column;
	align-items:stretch;
	justify-content: space-between;
}}
.{CardField_content}{{
	flex:1 0 auto;
	display:flex;
	flex-direction:row;
	align-items:stretch;
	overflow: auto;
}}
.{Card_header}{{
	display:flex;
	flex-direction:row-reverse;
	justify-content:space-between;
}}
.{CardField_content_text}{{
	resize:none;
	outline:none;
	flex:1 0 auto;
	font-size: 1.25rem;
	font-family: "Microsoft JhengHei Light";
	width: 1px;
}}
.{CardField_content_img}{{
	width:100%%;
	position:absolute;
}}
{hideScrollBar $".{CardField_content}"}
{hideScrollBar $".{CardField_content} .{Common_textArea}"}

.{Card_body_menu} {{
	width: 95%%;
	margin: 3px;
	display: flex;
	justify-content: space-around;
}}
.{Card_body_menu}>span{{
	width: 49%%;
	text-align: center;
	display: flex;
	align-items: center;
	justify-content: center;
}}
.{CardField_dragBar}{{
	width: 20px;
	height:auto;
	display:flex;
	flex-direction: column;
	align-items: center;
	justify-items: center;
	justify-content:center;
}}

"""

let cardLibStyle = $"""

#{CssClass.CardLib_toolbar}{{
display:flex;
justify-content: space-between;
align-items:center;
}}
#{CssClass.CardLib_toolbar_left}{{
display:flex;
align-items:center;
min-width:30%%;
}}
#{CssClass.CardLib_toolbar_right}{{
display:flex;
align-items:center;
}}
#{CssClass.CardLib_container}{{
margin:2px;
display:flex;
justify-content: space-around;
align-content: start;
overflow-y: scroll;
scroll-behavior: smooth;
flex-wrap: wrap;
width:400px;
resize:both;
}}

{makeScrollBar $"#{CardLib_container}"}

#{CssClass.CardLib_card_item}{{
display:flex;
width:235px;
height:45px;
margin:2px;
align-items:stretch;
}}
#{CssClass.CardLib_card_content}>img{{
width:100%%;
object-fit: cover;
overflow:hidden;
}}
#{CssClass.CardLib_card_content}{{
display:flex;
overflow:hidden;
height: 100%%;
align-items:center;
}}
#{CssClass.CardLib_card_btns}{{
height:auto;
display:flex;
flex-direction: column;
align-items:stretch;
justify-content: space-between;
}}
#{CssClass.CardLib_card_btns}>span{{
flex-grow: 2;
}}
#{CssClass.CardLib_self}{{
}}
#{CssClass.CardLib_searchInput}{{
height:20px;
width:1px;
flex-grow:1;
}}

"""

let commonStyle = $"""
.{CssClass.Common_glass}{{
 backdrop-filter: blur(25px) saturate(200%%) ;
-webkit-backdrop-filter: blur(25px) saturate(200%%);
 background-color: transparent;
 box-shadow:2px 2px 1px rgb(0 ,0 ,0 ,0.14);
/*filter: drop-shadow(1px 1px 1px #00000030);*/
}}
.{CssClass.Common_Shadow}{{
    box-shadow: 0px 0px 8px;
}}
.{CssClass.Common_backdropBlur}{{
    backdrop-filter:blur(20px);
}}
.{CssClass.Common_component}{{
    position:fixed;
    background-color:#ffffff30;
    z-index : 999999;
    /*background-image: linear-gradient(180deg, #2af59820 0%%, #009efd20 100%%);
    background: linear-gradient(to bottom, #D5DEE7 0%%, #E8EBF2 50%%, #E2E7ED 100%%), linear-gradient(to bottom, rgba(0,0,0,0.02) 50%%, rgba(255,255,255,0.02) 61%%, rgba(0,0,0,0.02) 73%%), linear-gradient(33deg, rgba(255,255,255,0.20) 0%%, rgba(0,0,0,0.20) 100%%); background-blend-mode: normal,color-burn;*/
    
}}
.{CssClass.Common_fixed}{{
    position:fixed;
}}

.{CssClass.Common_btn}{{
    display:flex;
    align-items:center;
    justify-content:center;
    width:20px;
    height:20px;
}}

.{CssClass.Common_btn}:hover{{
    background-color: rgba(248, 248, 248, 0.5);
    cursor:pointer;
}}
.{CssClass.Common_btn}:active{{
    background-color: rgba(255,255,255, 0.7);
    cursor:pointer;
}}
.{CssClass.AssistDot_self}{{
    
    display:flex;
    flex-direction: column;
}}

.{CssClass.Common_displayNone}{{
    display:none;
}}

.{CssClass.Common_textArea}{{
resize:none;
outline:none;
padding:0;
background:transparent;
border:0;
}}

.{CssClass.Common_moveBar}{{
width:60px;
position: absolute;
top:0;
left:50%%;
transform:translate(-50%%,0);
display: flex;
justify-content: center;
align-items: center;
}}

"""

let CSSInjection = commonStyle+cardLibStyle+cardStyle

(*
linear-gradient(217deg, rgba(255,0,0,.1), rgba(255,0,0,0) 70.71%),      linear-gradient(127deg, rgba(0,255,0,.1), rgba(0,255,0,0) 70.71%),      linear-gradient(336deg, rgba(0,0,255,.1), rgba(0,0,255,0) 70.71%)
*)
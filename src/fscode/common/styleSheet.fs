module app.common.styleSheet
open Fable.Core

// [<RequireQualifiedAccess>]
type [<StringEnum>] CssClass =
    |Common_invisible
    |Common_mask
    |Common_baseRoot
    |Common_zindexFocus
    |Common_Shadow
    |Common_backdropBlur
    |Common_fixed
    |Common_fullscreen
    |Common_absolute
    |Common_glass
    |Common_component
    |Common_btn
    |Common_displayNone
    |Common_moveBar
    |Common_textArea
    |Common_flex_grow_1
    |Common_toolTip
    |AssistDot_carrier
    |AssistDot_self
    |AssistDot_btn
    |AssistDot_btn_close
    |AssistDot_btn_newCard
    |AssistDot_btn_cardLib
    |AssistDot_btn_moveBar
    |CardLib_carrier
    |CardLib_self
    |CardLib_toolbar
    |CardLib_toolbar_left
    |CardLib_toolbar_right
    |CardLib_toolbar_right_pin
    |CardLib_toolbar_right_close
    |CardLib_moveBar
    |CardLib_container
    |CardLib_card_item
    |CardLib_card_content
    |CardLib_card_btns
    |CardLib_searchInput
    |Card_carrier
    |Card_self
    |Card_header
    |Card_header_left_btn
    |Card_header_right_btn
    |Card_header_side_btn
    |Card_header_btn_move
    |Card_header_btn_pin
    |Card_header_btn_goHome
    |Card_header_btn_close
    |Card_header_btn_addImg
    |Card_header_btn_addTxt
    |Card_body
    |CardField_self
    |CardField_moveBar
    |CardField_content
    |CardField_content_text
    |CardField_content_img
    |CardField_btns
    |CardField_btns_link
    |CardField_btns_expand
    |CardField_expanded
    |CardField_btns_del
    |CapturingFrame_carrier
    |CapturingFrame_self
    |CapturingFrame_dragBar
    |CapturingFrame_btns
    |CapturingFrame_btns_no
    |CapturingFrame_btns_ok
    |ScreenCapCanvas
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
let addToolTip selector = $"""
{selector}:hover .{Common_toolTip}{{
	visibility: visible;
}} 
"""

type Str =
    |String of string
    |CssClass of CssClass
let btnSize = 20
let capturingFrameStyle = $"""
#{ScreenCapCanvas}{{

}}
#{CapturingFrame_dragBar}{{
	
}}
#{CapturingFrame_carrier}{{
	position:fixed;
	display:flex;
	flex-direction:column;
}}
#{CapturingFrame_self}{{
	min-height:30px;
	min-width:60px;
	border: dashed #53535340;
	resize: both;
	overflow: hidden;
}}
#{CapturingFrame_btns}{{
	display:flex;
	justify-content: center;
}}


"""

let cardStyle = $"""
#{Card_carrier}{{
    
}}
#{Card_self}{{
	
}}
#{Card_body}{{
width:300px;
height:300px;
display:flex;
flex-direction:column;
align-items:center;
resize: both;
overflow: auto;
}}
.{CardField_expanded}{{
	min-height:100%%
}}
{makeScrollBar $"#{Card_body}"}

.{CardField_self}{{
	/*height:75px;*/
	width:95%%;
	display: flex;
	align-items:stretch;
	margin:3px;
	flex-grow:0
}}
#{CardField_btns}{{
	height:auto;
	display:flex;
	flex-direction:column;
	align-items:stretch;
	justify-content: space-between;
	z-index:9;
}}
#{CardField_content}{{
	flex:1 0 auto;
	display:flex;
	flex-direction:row;
	align-items:stretch;
	overflow: auto;
}}
#{Card_header}{{
	display:flex;
	flex-direction:row;
	justify-content:space-between;
}}
#{CardField_content_text}{{
	resize:none;
	outline:none;
	flex:1 0 auto;
	font-size: 1rem;
	font-family: "Microsoft JhengHei Light";
	width: 1px;
}}
#{CardField_content_img}{{
	width:100%%;
	position:absolute;
}}
{hideScrollBar $"#{CardField_content}"}
{hideScrollBar $"#{CardField_content} .{Common_textArea}"}

.{Card_header_side_btn} {{
	margin: 3px;
	display: flex;
	flex-direction: row;
}}
.{Card_header_side_btn}>span{{
	text-align: center;
	display: flex;
	align-items: center;
	justify-content: center;
}}
#{CardField_moveBar}{{
	width: 20px;
	height:auto;
	display:flex;
	flex-direction: column;
	align-items: center;
	justify-items: center;
	justify-content:center;
	z-index:9;
}}

"""

let cardLibStyle = $"""

#{CardLib_toolbar}{{
	display:flex;
	justify-content: space-between;
	align-items:center;
}}
#{CardLib_toolbar_left}{{
	display:flex;
	align-items:center;
	min-width:30%%;
}}
#{CardLib_toolbar_right}{{
	display:flex;
	align-items:center;
}}
#{CardLib_container}{{
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

#{CardLib_card_item}{{
	display:flex;
	max-width:200px;
	height:40px;
	margin:2px;
	align-items: center;
}}
#{CardLib_card_content}>img{{
	object-fit: cover;
	overflow:hidden;
}}
#{CardLib_card_content}{{
	display:flex;
	overflow:hidden;
	height: 100%%;
	align-items:center;
}}
#{CardLib_card_btns}{{
	height:auto;
	display:flex;
	flex-direction: column;
	align-items:stretch;
	justify-content: space-between;
}}
#{CardLib_card_btns}>span{{
flex-grow: 2;
}}
#{CardLib_self}{{
}}
#{CardLib_searchInput}{{
	height:20px;
	width:1px;
	flex-grow:1;
	resize:none;
	outline:none;
	background:transparent;
	border:0;
	padding:0;
}}
"""

let commonStyle = $"""
.{Common_toolTip}{{
	visibility: hidden;
	position: absolute;
    width: max-content;
    height: min-content;
    font-size: 0.5rem;
    font-family: "Microsoft JhengHei Light";
}}
.{Common_zindexFocus}{{
	z-index:9999999;
}}
#{Common_baseRoot}{{
	position: absolute;
	z-index:9999999;
	top:0;
	left:0;
}}
.{Common_mask}{{
	background:#ffffff50;
    width: 100%%;
    height: 100%%;
    cursor: crosshair;
}}
svg{{
padding:4px;
}}
.{Common_flex_grow_1}{{
	flex-grow:1;
}}
.{Common_absolute}{{
 position:absolute;
}}
.{Common_glass}{{
 backdrop-filter: blur(25px) saturate(200%%) ;
-webkit-backdrop-filter: blur(25px) saturate(200%%);
 background-color: transparent;
 box-shadow:1px 1px 1px rgb(0 ,0 ,0 ,0.14);
/*filter: drop-shadow(1px 1px 1px #00000030);*/

}}
.{Common_Shadow}{{
    box-shadow: 0px 0px 8px;
}}
.{Common_backdropBlur}{{
    backdrop-filter:blur(20px);
}}
.{Common_component}{{
    position:fixed;
    background-color:#ffffff30;
    /*background-image: linear-gradient(180deg, #2af59820 0%%, #009efd20 100%%);
    background: linear-gradient(to bottom, #D5DEE7 0%%, #E8EBF2 50%%, #E2E7ED 100%%), linear-gradient(to bottom, rgba(0,0,0,0.02) 50%%, rgba(255,255,255,0.02) 61%%, rgba(0,0,0,0.02) 73%%), linear-gradient(33deg, rgba(255,255,255,0.20) 0%%, rgba(0,0,0,0.20) 100%%); background-blend-mode: normal,color-burn;*/
    
}}
.{Common_fixed}{{
    position:fixed;
}}

.{Common_btn}{{
    display:flex;
    align-items:center;
    justify-content:center;
    width:{btnSize}px;
    height:{btnSize}px;
}}

.{Common_btn}:hover{{
    background-image: linear-gradient(to top, #accbee40 0%%, #e7f0fd40 100%%);
    cursor:pointer;
}}
.{Common_btn}:active{{
   background-image: linear-gradient(to top, #6a85b640 0%%, #bac8e040 100%%);
   cursor:pointer;
}}

{addToolTip $".{Common_btn}"} 

.{AssistDot_self}{{
    
    display:flex;
    flex-direction: column;
}}

.{Common_displayNone}{{
    display:none;
}}
.{Common_invisible}{{
	
}}
.{Common_textArea}{{
resize:none;
outline:none;
padding:5px;
background:transparent;
border:0;
}}

.{Common_moveBar}{{
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

let CSSInjection = commonStyle+cardLibStyle+cardStyle+ capturingFrameStyle

(*
linear-gradient(217deg, rgba(255,0,0,.1), rgba(255,0,0,0) 70.71%),      linear-gradient(127deg, rgba(0,255,0,.1), rgba(0,255,0,0) 70.71%),      linear-gradient(336deg, rgba(0,0,255,.1), rgba(0,0,255,0) 70.71%)
*)
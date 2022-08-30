
type Duck =
  abstract member walk:string with get,set


type littleDuck ()=
  interface Duck with
    member val walk="walk" with get,set


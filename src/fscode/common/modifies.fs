module app.common.modifies

[<RequireQualifiedAccess>]
module Program =
    open Elmish.React
    open Browser.Types

    module Internal  =

        open Fable.React
        
        open Elmish

        let withReactSynchronousUsing' lazyView2With (appEntrance:HTMLElement) (program:Elmish.Program<_,_,_,_>) =
            let setState =
                    fun model dispatch ->
                        ReactDom.render(
                            lazyView2With (fun x y -> obj.ReferenceEquals(x,y)) (Program.view program) model dispatch,
                            appEntrance
                        )

            program
            |> Program.withSetState setState
    let withReactSynchronous' (appEntrance:HTMLElement) (program:Elmish.Program<_,_,_,_>) =
        Internal.withReactSynchronousUsing' lazyView2With appEntrance program
// ts2fable 0.7.1
module rec Chrome
open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Types
type Function = System.Action


type [<AllowNullLiteral>] Window =
    inherit Browser.Types.Window
    abstract chrome: obj with get, set
    abstract console:Console


module Chrome =
    let [<Import("accessibilityFeatures","chrome/chrome")>] accessibilityFeatures: AccessibilityFeatures.IExports = jsNative
    let [<Import("action","chrome/chrome")>] action: Action.IExports = jsNative
    let [<Import("alarms","chrome/chrome")>] alarms: Alarms.IExports = jsNative
    let [<Import("browser","chrome/chrome")>] browser: Browser.IExports = jsNative
    let [<Import("bookmarks","chrome/chrome")>] bookmarks: Bookmarks.IExports = jsNative
    let [<Import("browserAction","chrome/chrome")>] browserAction: BrowserAction.IExports = jsNative
    let [<Import("browsingData","chrome/chrome")>] browsingData: BrowsingData.IExports = jsNative
    let [<Import("commands","chrome/chrome")>] commands: Commands.IExports = jsNative
    let [<Import("contentSettings","chrome/chrome")>] contentSettings: ContentSettings.IExports = jsNative
    let [<Import("contextMenus","chrome/chrome")>] contextMenus: ContextMenus.IExports = jsNative
    let [<Import("cookies","chrome/chrome")>] cookies: Cookies.IExports = jsNative
    let [<Import("_debugger","chrome/chrome")>] _debugger: _debugger.IExports = jsNative
    let [<Import("declarativeContent","chrome/chrome")>] declarativeContent: DeclarativeContent.IExports = jsNative
    let [<Import("declarativeWebRequest","chrome/chrome")>] declarativeWebRequest: DeclarativeWebRequest.IExports = jsNative
    let [<Import("desktopCapture","chrome/chrome")>] desktopCapture: DesktopCapture.IExports = jsNative
    let [<Import("documentScan","chrome/chrome")>] documentScan: DocumentScan.IExports = jsNative
    let [<Import("downloads","chrome/chrome")>] downloads: Downloads.IExports = jsNative
    let [<Import("extension","chrome/chrome")>] extension: Extension.IExports = jsNative
    let [<Import("fileBrowserHandler","chrome/chrome")>] fileBrowserHandler: FileBrowserHandler.IExports = jsNative
    let [<Import("fileSystemProvider","chrome/chrome")>] fileSystemProvider: FileSystemProvider.IExports = jsNative
    let [<Import("fontSettings","chrome/chrome")>] fontSettings: FontSettings.IExports = jsNative
    let [<Import("gcm","chrome/chrome")>] gcm: Gcm.IExports = jsNative
    let [<Import("history","chrome/chrome")>] history: History.IExports = jsNative
    let [<Import("i18n","chrome/chrome")>] i18n: I18n.IExports = jsNative
    let [<Import("identity","chrome/chrome")>] identity: Identity.IExports = jsNative
    let [<Import("idle","chrome/chrome")>] idle: Idle.IExports = jsNative
    let [<Import("loginState","chrome/chrome")>] loginState: LoginState.IExports = jsNative
    let [<Import("management","chrome/chrome")>] management: Management.IExports = jsNative
    let [<Import("notifications","chrome/chrome")>] notifications: Notifications.IExports = jsNative
    let [<Import("omnibox","chrome/chrome")>] omnibox: Omnibox.IExports = jsNative
    let [<Import("pageAction","chrome/chrome")>] pageAction: PageAction.IExports = jsNative
    let [<Import("pageCapture","chrome/chrome")>] pageCapture: PageCapture.IExports = jsNative
    let [<Import("permissions","chrome/chrome")>] permissions: Permissions.IExports = jsNative
    let [<Import("platformKeys","chrome/chrome")>] platformKeys: PlatformKeys.IExports = jsNative
    let [<Import("power","chrome/chrome")>] power: Power.IExports = jsNative
    let [<Import("printerProvider","chrome/chrome")>] printerProvider: PrinterProvider.IExports = jsNative
    let [<Import("privacy","chrome/chrome")>] privacy: Privacy.IExports = jsNative
    let [<Import("proxy","chrome/chrome")>] proxy: Proxy.IExports = jsNative
    let [<Import("search","chrome/chrome")>] search: Search.IExports = jsNative
    let [<Import("serial","chrome/chrome")>] serial: Serial.IExports = jsNative
    let [<Import("runtime","chrome/chrome")>] runtime: Runtime.IExports = jsNative
    let [<Import("scripting","chrome/chrome")>] scripting: Scripting.IExports = jsNative
    let [<Import("scriptBadge","chrome/chrome")>] scriptBadge: ScriptBadge.IExports = jsNative
    let [<Import("sessions","chrome/chrome")>] sessions: Sessions.IExports = jsNative
    let [<Import("storage","chrome/chrome")>] storage: Storage.IExports = jsNative
    let [<Import("socket","chrome/chrome")>] socket: Socket.IExports = jsNative
    let [<Import("tabCapture","chrome/chrome")>] tabCapture: TabCapture.IExports = jsNative
    let [<Import("tabs","chrome/chrome")>] tabs: Tabs.IExports = jsNative
    let [<Import("tabGroups","chrome/chrome")>] tabGroups: TabGroups.IExports = jsNative
    let [<Import("topSites","chrome/chrome")>] topSites: TopSites.IExports = jsNative
    let [<Import("tts","chrome/chrome")>] tts: Tts.IExports = jsNative
    let [<Import("ttsEngine","chrome/chrome")>] ttsEngine: TtsEngine.IExports = jsNative
    let [<Import("vpnProvider","chrome/chrome")>] vpnProvider: VpnProvider.IExports = jsNative
    let [<Import("wallpaper","chrome/chrome")>] wallpaper: Wallpaper.IExports = jsNative
    let [<Import("webNavigation","chrome/chrome")>] webNavigation: WebNavigation.IExports = jsNative
    let [<Import("webRequest","chrome/chrome")>] webRequest: WebRequest.IExports = jsNative
    let [<Import("webstore","chrome/chrome")>] webstore: Webstore.IExports = jsNative
    let [<Import("windows","chrome/chrome")>] windows: Windows.IExports = jsNative
    let [<Import("declarativeNetRequest","chrome/chrome")>] declarativeNetRequest: DeclarativeNetRequest.IExports = jsNative

    module AccessibilityFeatures =

        type [<AllowNullLiteral>] IExports =
            abstract spokenFeedback: Chrome.Types.ChromeSetting
            abstract largeCursor: Chrome.Types.ChromeSetting
            abstract stickyKeys: Chrome.Types.ChromeSetting
            abstract highContrast: Chrome.Types.ChromeSetting
            abstract screenMagnifier: Chrome.Types.ChromeSetting
            abstract autoclick: Chrome.Types.ChromeSetting
            abstract virtualKeyboard: Chrome.Types.ChromeSetting
            abstract caretHighlight: Chrome.Types.ChromeSetting
            abstract cursorHighlight: Chrome.Types.ChromeSetting
            abstract focusHighlight: Chrome.Types.ChromeSetting
            abstract selectToSpeak: Chrome.Types.ChromeSetting
            abstract switchAccess: Chrome.Types.ChromeSetting
            abstract animationPolicy: Chrome.Types.ChromeSetting

    module Action =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Since Chrome 88.
            /// Disables the action for a tab.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the action.</param>
            abstract disable: ?tabId: float -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Disables the action for a tab.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the action.</param>
            abstract disable: ?tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 88.
            /// Enables the action for a tab. By default, actions are enabled.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the action.</param>
            abstract enable: ?tabId: float -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Enables the action for a tab. By default, actions are enabled.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the action.</param>
            abstract enable: ?tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 88.
            /// Gets the background color of the action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// (result: ColorArray) => {...}</param>
            abstract getBadgeBackgroundColor: details: TabDetails * callback: (ColorArray -> unit) -> unit
            /// Since Chrome 88.
            /// Gets the background color of the action.
            abstract getBadgeBackgroundColor: details: TabDetails -> Promise<ColorArray>
            /// <summary>Since Chrome 88.
            /// Gets the badge text of the action. If no tab is specified, the non-tab-specific badge text is returned.
            /// If displayActionCountAsBadgeText is enabled, a placeholder text will be returned unless the
            /// declarativeNetRequestFeedback permission is present or tab-specific badge text was provided.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// (result: string) => {...}</param>
            abstract getBadgeText: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 88.
            /// Gets the badge text of the action. If no tab is specified, the non-tab-specific badge text is returned.
            /// If displayActionCountAsBadgeText is enabled, a placeholder text will be returned unless the
            /// declarativeNetRequestFeedback permission is present or tab-specific badge text was provided.
            abstract getBadgeText: details: TabDetails -> Promise<string>
            /// <summary>Since Chrome 88.
            /// Gets the html document set as the popup for this action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// (result: string) => {...}</param>
            abstract getPopup: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 88.
            /// Gets the html document set as the popup for this action.
            abstract getPopup: details: TabDetails -> Promise<string>
            /// <summary>Since Chrome 88.
            /// Gets the title of the action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// (result: string) => {...}</param>
            abstract getTitle: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 88.
            /// Gets the title of the action.
            abstract getTitle: details: TabDetails -> Promise<string>
            /// Since Chrome 88.
            /// Sets the background color for the badge.
            abstract setBadgeBackgroundColor: details: BadgeBackgroundColorDetails -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Sets the background color for the badge.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// () => {...}</param>
            abstract setBadgeBackgroundColor: details: BadgeBackgroundColorDetails * ?callback: (unit -> unit) -> unit
            /// Since Chrome 88.
            /// Sets the badge text for the action. The badge is displayed on top of the icon.
            abstract setBadgeText: details: BadgeTextDetails -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Sets the badge text for the action. The badge is displayed on top of the icon.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// () => {...}</param>
            abstract setBadgeText: details: BadgeTextDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 88.
            /// Sets the icon for the action. The icon can be specified either as the path to an image file or as the pixel data from a canvas element,
            /// or as dictionary of either one of those. Either the path or the imageData property must be specified.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// () => {...}</param>
            abstract setIcon: details: TabIconDetails * ?callback: (unit -> unit) -> unit
            /// Since Chrome 88.
            /// Sets the html document to be opened as a popup when the user clicks on the action's icon.
            abstract setPopup: details: PopupDetails -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Sets the html document to be opened as a popup when the user clicks on the action's icon.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// () => {...}</param>
            abstract setPopup: details: PopupDetails * ?callback: (unit -> unit) -> unit
            /// Since Chrome 88.
            /// Sets the title of the action. This shows up in the tooltip.
            abstract setTitle: details: TitleDetails -> Promise<unit>
            /// <summary>Since Chrome 88.
            /// Sets the title of the action. This shows up in the tooltip.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// () => {...}</param>
            abstract setTitle: details: TitleDetails * ?callback: (unit -> unit) -> unit
            abstract onClicked: BrowserClickedEvent

        type [<AllowNullLiteral>] BadgeBackgroundColorDetails =
            /// An array of four integers in the range [0,255] that make up the RGBA color of the badge. For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
            abstract color: U2<string, ColorArray> with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] BadgeTextDetails =
            /// Any number of characters can be passed, but only about four can fit in the space.
            abstract text: string with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type ColorArray =
            float * float * float * float

        type [<AllowNullLiteral>] TitleDetails =
            /// The string the action should display when moused over.
            abstract title: string with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] PopupDetails =
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set
            /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
            abstract popup: string with get, set

        type [<AllowNullLiteral>] BrowserClickedEvent =
            inherit Chrome.Events.Event<(Chrome.Tabs.Tab -> unit)>

        type [<AllowNullLiteral>] TabIconDetails =
            /// Optional. Either a relative image path or a dictionary {size -> relative image path} pointing to icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.path = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract path: U2<string, TabIconDetailsPath> option with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set
            /// Optional. Either an ImageData object or a dictionary {size -> ImageData} representing icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.imageData = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract imageData: U2<ImageData, TabIconDetailsImageData> option with get, set

        type [<AllowNullLiteral>] TabDetails =
            /// Optional. The ID of the tab to query state for. If no tab is specified, the non-tab-specific state is returned.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] TabIconDetailsPath =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> string with get, set

        type [<AllowNullLiteral>] TabIconDetailsImageData =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> ImageData with get, set

    module Alarms =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Creates an alarm. Near the time(s) specified by alarmInfo, the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified), it will be cancelled and replaced by this alarm.
            /// In order to reduce the load on the user's machine, Chrome limits alarms to at most once every 1 minute but may delay them an arbitrary amount more. That is, setting delayInMinutes or periodInMinutes to less than 1 will not be honored and will cause a warning. when can be set to less than 1 minute after "now" without warning but won't actually cause the alarm to fire for at least 1 minute.
            /// To help you debug your app or extension, when you've loaded it unpacked, there's no limit to how often the alarm can fire.</summary>
            /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must be specified by either when or delayInMinutes (but not both). If periodInMinutes is set, the alarm will repeat every periodInMinutes minutes after the initial event. If neither when or delayInMinutes is set for a repeating alarm, periodInMinutes is used as the default for delayInMinutes.</param>
            abstract create: alarmInfo: AlarmCreateInfo -> unit
            /// <summary>Creates an alarm. Near the time(s) specified by alarmInfo, the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified), it will be cancelled and replaced by this alarm.
            /// In order to reduce the load on the user's machine, Chrome limits alarms to at most once every 1 minute but may delay them an arbitrary amount more. That is, setting delayInMinutes or periodInMinutes to less than 1 will not be honored and will cause a warning. when can be set to less than 1 minute after "now" without warning but won't actually cause the alarm to fire for at least 1 minute.
            /// To help you debug your app or extension, when you've loaded it unpacked, there's no limit to how often the alarm can fire.</summary>
            /// <param name="name">Optional name to identify this alarm. Defaults to the empty string.</param>
            /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must be specified by either when or delayInMinutes (but not both). If periodInMinutes is set, the alarm will repeat every periodInMinutes minutes after the initial event. If neither when or delayInMinutes is set for a repeating alarm, periodInMinutes is used as the default for delayInMinutes.</param>
            abstract create: name: string * alarmInfo: AlarmCreateInfo -> unit
            /// <summary>Gets an array of all the alarms.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of Alarm alarms) {...};</param>
            abstract getAll: callback: (ResizeArray<Alarm> -> unit) -> unit
            /// Gets an array of all the alarms.
            abstract getAll: unit -> Promise<ResizeArray<Alarm>>
            /// Clears all alarms.
            /// function(boolean wasCleared) {...};
            abstract clearAll: unit -> Promise<bool>
            /// <summary>Clears all alarms.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean wasCleared) {...};</param>
            abstract clearAll: ?callback: (bool -> unit) -> unit
            /// <summary>Clears the alarm with the given name.</summary>
            /// <param name="name">The name of the alarm to clear. Defaults to the empty string.</param>
            abstract clear: ?name: string -> Promise<bool>
            /// <summary>Clears the alarm with the given name.</summary>
            /// <param name="name">The name of the alarm to clear. Defaults to the empty string.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean wasCleared) {...};</param>
            abstract clear: ?name: string * ?callback: (bool -> unit) -> unit
            /// <summary>Clears the alarm without a name.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean wasCleared) {...};</param>
            abstract clear: callback: (bool -> unit) -> unit
            /// Clears the alarm without a name.
            abstract clear: unit -> Promise<unit>
            /// <summary>Retrieves details about the specified alarm.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Alarm alarm) {...};</param>
            abstract get: callback: (Alarm -> unit) -> unit
            /// Retrieves details about the specified alarm.
            abstract get: unit -> Promise<Alarm>
            /// <summary>Retrieves details about the specified alarm.</summary>
            /// <param name="name">The name of the alarm to get. Defaults to the empty string.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Alarm alarm) {...};</param>
            abstract get: name: string * callback: (Alarm -> unit) -> unit
            /// <summary>Retrieves details about the specified alarm.</summary>
            /// <param name="name">The name of the alarm to get. Defaults to the empty string.</param>
            abstract get: name: string -> Promise<Alarm>
            abstract onAlarm: AlarmEvent

        type [<AllowNullLiteral>] AlarmCreateInfo =
            /// Optional. Length of time in minutes after which the onAlarm event should fire.
            abstract delayInMinutes: float option with get, set
            /// Optional. If set, the onAlarm event should fire every periodInMinutes minutes after the initial event specified by when or delayInMinutes. If not set, the alarm will only fire once.
            abstract periodInMinutes: float option with get, set
            /// Optional. Time at which the alarm should fire, in milliseconds past the epoch (e.g. Date.now() + n).
            abstract ``when``: float option with get, set

        type [<AllowNullLiteral>] Alarm =
            /// Optional. If not null, the alarm is a repeating alarm and will fire again in periodInMinutes minutes.
            abstract periodInMinutes: float option with get, set
            /// Time at which this alarm was scheduled to fire, in milliseconds past the epoch (e.g. Date.now() + n). For performance reasons, the alarm may have been delayed an arbitrary amount beyond this.
            abstract scheduledTime: float with get, set
            /// Name of this alarm.
            abstract name: string with get, set

        type [<AllowNullLiteral>] AlarmEvent =
            inherit Chrome.Events.Event<(Alarm -> unit)>

    module Browser =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Opens a new tab in a browser window associated with the current application
            /// and Chrome profile. If no browser window for the Chrome profile is opened,
            /// a new one is opened prior to creating the new tab.</summary>
            /// <param name="options">Configures how the tab should be opened.</param>
            /// <param name="callback">Called when the tab was successfully
            /// created, or failed to be created. If failed, runtime.lastError will be set.</param>
            abstract openTab: options: Options * callback: (unit -> unit) -> unit
            /// <summary>Opens a new tab in a browser window associated with the current application
            /// and Chrome profile. If no browser window for the Chrome profile is opened,
            /// a new one is opened prior to creating the new tab. Since Chrome 42 only.</summary>
            /// <param name="options">Configures how the tab should be opened.</param>
            abstract openTab: options: Options -> unit

        type [<AllowNullLiteral>] Options =
            /// The URL to navigate to when the new tab is initially opened.
            abstract url: string with get, set

    module Bookmarks =

        type [<AllowNullLiteral>] IExports =
            abstract MAX_WRITE_OPERATIONS_PER_HOUR: float
            abstract MAX_SUSTAINED_WRITE_OPERATIONS_PER_MINUTE: float
            /// <summary>Searches for BookmarkTreeNodes matching the given query. Queries specified with an object produce BookmarkTreeNodes matching all specified properties.</summary>
            /// <param name="query">A string of words and quoted phrases that are matched against bookmark URLs and titles.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract search: query: string * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Searches for BookmarkTreeNodes matching the given query. Queries specified with an object produce BookmarkTreeNodes matching all specified properties.</summary>
            /// <param name="query">A string of words and quoted phrases that are matched against bookmark URLs and titles.</param>
            abstract search: query: string -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Searches for BookmarkTreeNodes matching the given query. Queries specified with an object produce BookmarkTreeNodes matching all specified properties.</summary>
            /// <param name="query">An object with one or more of the properties query, url, and title specified. Bookmarks matching all specified properties will be produced.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract search: query: BookmarkSearchQuery * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Searches for BookmarkTreeNodes matching the given query. Queries specified with an object produce BookmarkTreeNodes matching all specified properties.</summary>
            /// <param name="query">An object with one or more of the properties query, url, and title specified. Bookmarks matching all specified properties will be produced.</param>
            abstract search: query: BookmarkSearchQuery -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Retrieves the entire Bookmarks hierarchy.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract getTree: callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// Retrieves the entire Bookmarks hierarchy.
            abstract getTree: unit -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Retrieves the recently added bookmarks.</summary>
            /// <param name="numberOfItems">The maximum number of items to return.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract getRecent: numberOfItems: float * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Retrieves the recently added bookmarks.</summary>
            /// <param name="numberOfItems">The maximum number of items to return.</param>
            abstract getRecent: numberOfItems: float -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Retrieves the specified BookmarkTreeNode.</summary>
            /// <param name="id">A single string-valued id</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract get: id: string * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Retrieves the specified BookmarkTreeNode.</summary>
            /// <param name="id">A single string-valued id</param>
            abstract get: id: string -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Retrieves the specified BookmarkTreeNode.</summary>
            /// <param name="idList">An array of string-valued ids</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract get: idList: ResizeArray<string> * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Retrieves the specified BookmarkTreeNode.</summary>
            /// <param name="idList">An array of string-valued ids</param>
            abstract get: idList: ResizeArray<string> -> Promise<ResizeArray<BookmarkTreeNode>>
            /// Creates a bookmark or folder under the specified parentId. If url is NULL or missing, it will be a folder.
            abstract create: bookmark: BookmarkCreateArg -> Promise<BookmarkTreeNode>
            /// <summary>Creates a bookmark or folder under the specified parentId. If url is NULL or missing, it will be a folder.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( BookmarkTreeNode result) {...};</param>
            abstract create: bookmark: BookmarkCreateArg * ?callback: (BookmarkTreeNode -> unit) -> unit
            /// Moves the specified BookmarkTreeNode to the provided location.
            abstract move: id: string * destination: BookmarkDestinationArg -> Promise<BookmarkTreeNode>
            /// <summary>Moves the specified BookmarkTreeNode to the provided location.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( BookmarkTreeNode result) {...};</param>
            abstract move: id: string * destination: BookmarkDestinationArg * ?callback: (BookmarkTreeNode -> unit) -> unit
            /// Updates the properties of a bookmark or folder. Specify only the properties that you want to change; unspecified properties will be left unchanged. Note: Currently, only 'title' and 'url' are supported.
            abstract update: id: string * changes: BookmarkChangesArg -> Promise<BookmarkTreeNode>
            /// <summary>Updates the properties of a bookmark or folder. Specify only the properties that you want to change; unspecified properties will be left unchanged. Note: Currently, only 'title' and 'url' are supported.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( BookmarkTreeNode result) {...};</param>
            abstract update: id: string * changes: BookmarkChangesArg * ?callback: (BookmarkTreeNode -> unit) -> unit
            /// Removes a bookmark or an empty bookmark folder.
            abstract remove: id: string -> Promise<unit>
            /// <summary>Removes a bookmark or an empty bookmark folder.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract remove: id: string * ?callback: Function -> unit
            /// <summary>Retrieves the children of the specified BookmarkTreeNode id.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract getChildren: id: string * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// Retrieves the children of the specified BookmarkTreeNode id.
            abstract getChildren: id: string -> Promise<ResizeArray<BookmarkTreeNode>>
            /// <summary>Since Chrome 14.
            /// Retrieves part of the Bookmarks hierarchy, starting at the specified node.</summary>
            /// <param name="id">The ID of the root of the subtree to retrieve.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of BookmarkTreeNode results) {...};</param>
            abstract getSubTree: id: string * callback: (ResizeArray<BookmarkTreeNode> -> unit) -> unit
            /// <summary>Since Chrome 14.
            /// Retrieves part of the Bookmarks hierarchy, starting at the specified node.</summary>
            /// <param name="id">The ID of the root of the subtree to retrieve.</param>
            abstract getSubTree: id: string -> Promise<ResizeArray<BookmarkTreeNode>>
            /// Recursively removes a bookmark folder.
            abstract removeTree: id: string -> Promise<unit>
            /// <summary>Recursively removes a bookmark folder.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeTree: id: string * ?callback: Function -> unit
            abstract onRemoved: BookmarkRemovedEvent
            abstract onImportEnded: BookmarkImportEndedEvent
            abstract onImportBegan: BookmarkImportBeganEvent
            abstract onChanged: BookmarkChangedEvent
            abstract onMoved: BookmarkMovedEvent
            abstract onCreated: BookmarkCreatedEvent
            abstract onChildrenReordered: BookmarkChildrenReordered

        /// A node (either a bookmark or a folder) in the bookmark tree. Child nodes are ordered within their parent folder.
        type [<AllowNullLiteral>] BookmarkTreeNode =
            /// Optional. The 0-based position of this node within its parent folder.
            abstract index: float option with get, set
            /// Optional. When this node was created, in milliseconds since the epoch (new Date(dateAdded)).
            abstract dateAdded: float option with get, set
            /// The text displayed for the node.
            abstract title: string with get, set
            /// Optional. The URL navigated to when a user clicks the bookmark. Omitted for folders.
            abstract url: string option with get, set
            /// Optional. When the contents of this folder last changed, in milliseconds since the epoch.
            abstract dateGroupModified: float option with get, set
            /// The unique identifier for the node. IDs are unique within the current profile, and they remain valid even after the browser is restarted.
            abstract id: string with get, set
            /// Optional. The id of the parent folder. Omitted for the root node.
            abstract parentId: string option with get, set
            /// Optional. An ordered list of children of this node.
            abstract children: ResizeArray<BookmarkTreeNode> option with get, set
            /// Optional.
            /// Since Chrome 37.
            /// Indicates the reason why this node is unmodifiable. The managed value indicates that this node was configured by the system administrator or by the custodian of a supervised user. Omitted if the node can be modified by the user and the extension (default).
            abstract unmodifiable: BookmarkTreeNodeUnmodifiable option with get, set

        type [<AllowNullLiteral>] BookmarkRemoveInfo =
            abstract index: float with get, set
            abstract parentId: string with get, set
            abstract node: BookmarkTreeNode with get, set

        type [<AllowNullLiteral>] BookmarkMoveInfo =
            abstract index: float with get, set
            abstract oldIndex: float with get, set
            abstract parentId: string with get, set
            abstract oldParentId: string with get, set

        type [<AllowNullLiteral>] BookmarkChangeInfo =
            abstract url: string option with get, set
            abstract title: string with get, set

        type [<AllowNullLiteral>] BookmarkReorderInfo =
            abstract childIds: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] BookmarkRemovedEvent =
            inherit Chrome.Events.Event<(string -> BookmarkRemoveInfo -> unit)>

        type [<AllowNullLiteral>] BookmarkImportEndedEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] BookmarkMovedEvent =
            inherit Chrome.Events.Event<(string -> BookmarkMoveInfo -> unit)>

        type [<AllowNullLiteral>] BookmarkImportBeganEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] BookmarkChangedEvent =
            inherit Chrome.Events.Event<(string -> BookmarkChangeInfo -> unit)>

        type [<AllowNullLiteral>] BookmarkCreatedEvent =
            inherit Chrome.Events.Event<(string -> BookmarkTreeNode -> unit)>

        type [<AllowNullLiteral>] BookmarkChildrenReordered =
            inherit Chrome.Events.Event<(string -> BookmarkReorderInfo -> unit)>

        type [<AllowNullLiteral>] BookmarkSearchQuery =
            abstract query: string option with get, set
            abstract url: string option with get, set
            abstract title: string option with get, set

        type [<AllowNullLiteral>] BookmarkCreateArg =
            /// Optional. Defaults to the Other Bookmarks folder.
            abstract parentId: string option with get, set
            abstract index: float option with get, set
            abstract title: string option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] BookmarkDestinationArg =
            abstract parentId: string option with get, set
            abstract index: float option with get, set

        type [<AllowNullLiteral>] BookmarkChangesArg =
            abstract title: string option with get, set
            abstract url: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] BookmarkTreeNodeUnmodifiable =
            | Managed

    module BrowserAction =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Since Chrome 22.
            /// Enables the browser action for a tab. By default, browser actions are enabled.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the browser action.</param>
            abstract enable: ?tabId: float -> Promise<unit>
            /// <summary>Since Chrome 22.
            /// Enables the browser action for a tab. By default, browser actions are enabled.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the browser action.</param>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract enable: ?tabId: float * ?callback: (unit -> unit) -> unit
            /// Sets the background color for the badge.
            abstract setBadgeBackgroundColor: details: BadgeBackgroundColorDetails -> Promise<unit>
            /// <summary>Sets the background color for the badge.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setBadgeBackgroundColor: details: BadgeBackgroundColorDetails * ?callback: (unit -> unit) -> unit
            /// Sets the badge text for the browser action. The badge is displayed on top of the icon.
            abstract setBadgeText: details: BadgeTextDetails -> Promise<unit>
            /// <summary>Sets the badge text for the browser action. The badge is displayed on top of the icon.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setBadgeText: details: BadgeTextDetails * ?callback: (unit -> unit) -> unit
            /// Sets the title of the browser action. This shows up in the tooltip.
            abstract setTitle: details: TitleDetails -> Promise<unit>
            /// <summary>Sets the title of the browser action. This shows up in the tooltip.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setTitle: details: TitleDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 19.
            /// Gets the badge text of the browser action. If no tab is specified, the non-tab-specific badge text is returned.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract getBadgeText: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 19.
            /// Gets the badge text of the browser action. If no tab is specified, the non-tab-specific badge text is returned.
            abstract getBadgeText: details: TabDetails -> Promise<string>
            /// Sets the html document to be opened as a popup when the user clicks on the browser action's icon.
            abstract setPopup: details: PopupDetails -> Promise<unit>
            /// <summary>Sets the html document to be opened as a popup when the user clicks on the browser action's icon.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setPopup: details: PopupDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 22.
            /// Disables the browser action for a tab.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the browser action.</param>
            abstract disable: ?tabId: float -> Promise<unit>
            /// <summary>Since Chrome 22.
            /// Disables the browser action for a tab.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the browser action.</param>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract disable: ?tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Since Chrome 19.
            /// Gets the title of the browser action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string result) {...};</param>
            abstract getTitle: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 19.
            /// Gets the title of the browser action.
            abstract getTitle: details: TabDetails -> Promise<string>
            /// <summary>Since Chrome 19.
            /// Gets the background color of the browser action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( ColorArray result) {...};</param>
            abstract getBadgeBackgroundColor: details: TabDetails * callback: (ColorArray -> unit) -> unit
            /// Since Chrome 19.
            /// Gets the background color of the browser action.
            abstract getBadgeBackgroundColor: details: TabDetails -> Promise<ColorArray>
            /// <summary>Since Chrome 19.
            /// Gets the html document set as the popup for this browser action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string result) {...};</param>
            abstract getPopup: details: TabDetails * callback: (string -> unit) -> unit
            /// Since Chrome 19.
            /// Gets the html document set as the popup for this browser action.
            abstract getPopup: details: TabDetails -> Promise<string>
            /// <summary>Sets the icon for the browser action. The icon can be specified either as the path to an image file or as the pixel data from a canvas element, or as dictionary of either one of those. Either the path or the imageData property must be specified.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setIcon: details: TabIconDetails * ?callback: Function -> unit
            abstract onClicked: BrowserClickedEvent

        type [<AllowNullLiteral>] BadgeBackgroundColorDetails =
            /// An array of four integers in the range [0,255] that make up the RGBA color of the badge. For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
            abstract color: U2<string, ColorArray> with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] BadgeTextDetails =
            /// Any number of characters can be passed, but only about four can fit in the space.
            abstract text: string option with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type ColorArray =
            float * float * float * float

        type [<AllowNullLiteral>] TitleDetails =
            /// The string the browser action should display when moused over.
            abstract title: string with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] TabDetails =
            /// Optional. Specify the tab to get the information. If no tab is specified, the non-tab-specific information is returned.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] TabIconDetails =
            /// Optional. Either a relative image path or a dictionary {size -> relative image path} pointing to icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.path = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract path: U2<string, TabIconDetailsPath> option with get, set
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set
            /// Optional. Either an ImageData object or a dictionary {size -> ImageData} representing icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.imageData = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract imageData: U2<ImageData, TabIconDetailsImageData> option with get, set

        type [<AllowNullLiteral>] PopupDetails =
            /// Optional. Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
            abstract tabId: float option with get, set
            /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
            abstract popup: string with get, set

        type [<AllowNullLiteral>] BrowserClickedEvent =
            inherit Chrome.Events.Event<(Chrome.Tabs.Tab -> unit)>

        type [<AllowNullLiteral>] TabIconDetailsPath =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: string -> string with get, set

        type [<AllowNullLiteral>] TabIconDetailsImageData =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> ImageData with get, set

    module BrowsingData =

        type [<AllowNullLiteral>] IExports =
            /// Since Chrome 26.
            /// Reports which types of data are currently selected in the 'Clear browsing data' settings UI. Note: some of the data types included in this API are not available in the settings UI, and some UI settings control more than one data type listed here.
            abstract settings: unit -> Promise<SettingsResult>
            /// <summary>Since Chrome 26.
            /// Reports which types of data are currently selected in the 'Clear browsing data' settings UI. Note: some of the data types included in this API are not available in the settings UI, and some UI settings control more than one data type listed here.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(object result) {...};</param>
            abstract settings: callback: (SettingsResult -> unit) -> unit
            abstract removePluginData: options: RemovalOptions -> Promise<unit>
            /// <param name="callback">Called when plugins' data has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removePluginData: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Since Chrome 72.
            /// Clears websites' service workers.
            abstract removeServiceWorkers: options: RemovalOptions -> Promise<unit>
            /// <summary>Since Chrome 72.
            /// Clears websites' service workers.</summary>
            /// <param name="callback">Called when the browser's service workers have been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeServiceWorkers: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears the browser's stored form data (autofill).
            abstract removeFormData: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears the browser's stored form data (autofill).</summary>
            /// <param name="callback">Called when the browser's form data has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeFormData: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' file system data.
            abstract removeFileSystems: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' file system data.</summary>
            /// <param name="callback">Called when websites' file systems have been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeFileSystems: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// <summary>Clears various types of browsing data stored in a user's profile.</summary>
            /// <param name="dataToRemove">The set of data types to remove.</param>
            abstract remove: options: RemovalOptions * dataToRemove: DataTypeSet -> Promise<unit>
            /// <summary>Clears various types of browsing data stored in a user's profile.</summary>
            /// <param name="dataToRemove">The set of data types to remove.</param>
            /// <param name="callback">Called when deletion has completed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract remove: options: RemovalOptions * dataToRemove: DataTypeSet * ?callback: (unit -> unit) -> unit
            /// Clears the browser's stored passwords.
            abstract removePasswords: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears the browser's stored passwords.</summary>
            /// <param name="callback">Called when the browser's passwords have been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removePasswords: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            
            // abstract removeCookies: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' WebSQL data.
            abstract removeWebSQL: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' WebSQL data.</summary>
            /// <param name="callback">Called when websites' WebSQL databases have been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeWebSQL: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' appcache data.
            abstract removeAppcache: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' appcache data.</summary>
            /// <param name="callback">Called when websites' appcache data has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeAppcache: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' cache storage data.
            abstract removeCacheStorage: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' cache storage data.</summary>
            /// <param name="callback">Called when websites' appcache data has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeCacheStorage: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears the browser's list of downloaded files (not the downloaded files themselves).
            abstract removeDownloads: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears the browser's list of downloaded files (not the downloaded files themselves).</summary>
            /// <param name="callback">Called when the browser's list of downloaded files has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeDownloads: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' local storage data.
            abstract removeLocalStorage: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' local storage data.</summary>
            /// <param name="callback">Called when websites' local storage has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeLocalStorage: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears the browser's cache.
            abstract removeCache: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears the browser's cache.</summary>
            /// <param name="callback">Called when the browser's cache has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeCache: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears the browser's history.
            abstract removeHistory: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears the browser's history.</summary>
            /// <param name="callback">Called when the browser's history has cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeHistory: options: RemovalOptions * ?callback: (unit -> unit) -> unit
            /// Clears websites' IndexedDB data.
            abstract removeIndexedDB: options: RemovalOptions -> Promise<unit>
            /// <summary>Clears websites' IndexedDB data.</summary>
            /// <param name="callback">Called when websites' IndexedDB data has been cleared.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeIndexedDB: options: RemovalOptions * ?callback: (unit -> unit) -> unit

        type [<AllowNullLiteral>] OriginTypes =
            /// Optional. Extensions and packaged applications a user has installed (be _really_ careful!).
            abstract extension: bool option with get, set
            /// Optional. Websites that have been installed as hosted applications (be careful!).
            abstract protectedWeb: bool option with get, set
            /// Optional. Normal websites.
            abstract unprotectedWeb: bool option with get, set

        /// Options that determine exactly what data will be removed.
        type [<AllowNullLiteral>] RemovalOptions =
            /// Optional.
            /// Since Chrome 74.
            /// When present, data for origins in this list is excluded from deletion. Can't be used together with origins. Only supported for cookies, storage and cache. Cookies are excluded for the whole registrable domain.
            abstract excludeOrigins: ResizeArray<string> option with get, set
            /// Optional.
            /// An object whose properties specify which origin types ought to be cleared. If this object isn't specified, it defaults to clearing only "unprotected" origins. Please ensure that you _really_ want to remove application data before adding 'protectedWeb' or 'extensions'.
            abstract originTypes: OriginTypes option with get, set
            /// Optional.
            /// Since Chrome 74.
            /// When present, only data for origins in this list is deleted. Only supported for cookies, storage and cache. Cookies are cleared for the whole registrable domain.
            abstract origins: ResizeArray<string> option with get, set
            /// Optional.
            /// Remove data accumulated on or after this date, represented in milliseconds since the epoch (accessible via the {@link Date.getTime} method). If absent, defaults to 0 (which would remove all browsing data).
            abstract since: float option with get, set

        /// Since Chrome 27.
        /// A set of data types. Missing data types are interpreted as false.
        type [<AllowNullLiteral>] DataTypeSet =
            /// Optional. Websites' WebSQL data.
            abstract webSQL: bool option with get, set
            /// Optional. Websites' IndexedDB data.
            abstract indexedDB: bool option with get, set
            /// Optional. The browser's cookies.
            abstract cookies: bool option with get, set
            /// Optional. Stored passwords.
            abstract passwords: bool option with get, set
            abstract serverBoundCertificates: bool option with get, set
            /// Optional. The browser's download list.
            abstract downloads: bool option with get, set
            /// Optional. The browser's cache. Note: when removing data, this clears the entire cache: it is not limited to the range you specify.
            abstract cache: bool option with get, set
            /// Optional. Websites' appcaches.
            abstract appcache: bool option with get, set
            /// Optional. Websites' file systems.
            abstract fileSystems: bool option with get, set
            abstract pluginData: bool option with get, set
            /// Optional. Websites' local storage data.
            abstract localStorage: bool option with get, set
            /// Optional. The browser's stored form data.
            abstract formData: bool option with get, set
            /// Optional. The browser's history.
            abstract history: bool option with get, set
            /// Optional.
            /// Since Chrome 39.
            /// Service Workers.
            abstract serviceWorkers: bool option with get, set

        type [<AllowNullLiteral>] SettingsResult =
            abstract options: RemovalOptions with get, set
            /// All of the types will be present in the result, with values of true if they are both selected to be removed and permitted to be removed, otherwise false.
            abstract dataToRemove: DataTypeSet with get, set
            /// All of the types will be present in the result, with values of true if they are permitted to be removed (e.g., by enterprise policy) and false if not.
            abstract dataRemovalPermitted: DataTypeSet with get, set

    module Commands =

        type [<AllowNullLiteral>] IExports =
            /// Returns all the registered extension commands for this extension and their shortcut (if active).
            abstract getAll: unit -> Promise<ResizeArray<Command>>
            /// <summary>Returns all the registered extension commands for this extension and their shortcut (if active).</summary>
            /// <param name="callback">Called to return the registered commands.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of Command commands) {...};</param>
            abstract getAll: callback: (ResizeArray<Command> -> unit) -> unit
            abstract onCommand: CommandEvent

        type [<AllowNullLiteral>] Command =
            /// Optional. The name of the Extension Command
            abstract name: string option with get, set
            /// Optional. The Extension Command description
            abstract description: string option with get, set
            /// Optional. The shortcut active for this command, or blank if not active.
            abstract shortcut: string option with get, set

        type [<AllowNullLiteral>] CommandEvent =
            inherit Chrome.Events.Event<(string -> Chrome.Tabs.Tab -> unit)>

    module ContentSettings =

        type [<AllowNullLiteral>] IExports =
            abstract cookies: CookieContentSetting
            abstract popups: PopupsContentSetting
            abstract javascript: JavascriptContentSetting
            abstract notifications: NotificationsContentSetting
            abstract plugins: PluginsContentSetting
            abstract images: ImagesContentSetting
            abstract location: LocationContentSetting
            abstract fullscreen: FullscreenContentSetting
            abstract mouselock: MouselockContentSetting
            abstract microphone: MicrophoneContentSetting
            abstract camera: CameraContentSetting
            abstract unsandboxedPlugins: PpapiBrokerContentSetting
            abstract automaticDownloads: MultipleAutomaticDownloadsContentSetting

        type [<StringEnum>] [<RequireQualifiedAccess>] ScopeEnum =
            | Regular
            | Incognito_session_only

        type [<AllowNullLiteral>] ClearDetails =
            /// Optional.
            /// Where to clear the setting (default: regular).
            /// The scope of the ContentSetting. One of
            /// * regular: setting for regular profile (which is inherited by the incognito profile if not overridden elsewhere),
            /// * incognito_session_only: setting for incognito profile that can only be set during an incognito session and is deleted when the incognito session ends (overrides regular settings).
            abstract scope: ScopeEnum option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] DefaultContentSettingDetails =
            | Allow
            | Ask
            | Block
            | Detect_important_content
            | Session_only

        type [<AllowNullLiteral>] SetDetails =
            /// Optional. The resource identifier for the content type.
            abstract resourceIdentifier: ResourceIdentifier option with get, set
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: DefaultContentSettingDetails with get, set
            /// Optional. The pattern for the secondary URL. Defaults to matching all URLs. For details on the format of a pattern, see Content Setting Patterns.
            abstract secondaryPattern: string option with get, set
            /// Optional. Where to set the setting (default: regular).
            abstract scope: ScopeEnum option with get, set
            /// The pattern for the primary URL. For details on the format of a pattern, see Content Setting Patterns.
            abstract primaryPattern: string with get, set

        type [<AllowNullLiteral>] CookieSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: CookieSetDetailsSetting with get, set

        type [<AllowNullLiteral>] ImagesSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: ImagesSetDetailsSetting with get, set

        type [<AllowNullLiteral>] JavascriptSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: ImagesSetDetailsSetting with get, set

        type [<AllowNullLiteral>] LocationSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] PluginsSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: PluginsSetDetailsSetting with get, set

        type [<AllowNullLiteral>] PopupsSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: ImagesSetDetailsSetting with get, set

        type [<AllowNullLiteral>] NotificationsSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] FullscreenSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: string with get, set

        type [<AllowNullLiteral>] MouselockSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: string with get, set

        type [<AllowNullLiteral>] MicrophoneSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] CameraSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] PpapiBrokerSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] MultipleAutomaticDownloadsSetDetails =
            inherit SetDetails
            /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: LocationSetDetailsSetting with get, set

        type [<AllowNullLiteral>] GetDetails =
            /// Optional. The secondary URL for which the content setting should be retrieved. Defaults to the primary URL. Note that the meaning of a secondary URL depends on the content type, and not all content types use secondary URLs.
            abstract secondaryUrl: string option with get, set
            /// Optional. A more specific identifier of the type of content for which the settings should be retrieved.
            abstract resourceIdentifier: ResourceIdentifier option with get, set
            /// Optional. Whether to check the content settings for an incognito session. (default false)
            abstract incognito: bool option with get, set
            /// The primary URL for which the content setting should be retrieved. Note that the meaning of a primary URL depends on the content type.
            abstract primaryUrl: string with get, set

        type [<AllowNullLiteral>] ReturnedDetails =
            /// The content setting. See the description of the individual ContentSetting objects for the possible values.
            abstract setting: DefaultContentSettingDetails with get, set

        type [<AllowNullLiteral>] ContentSetting =
            /// <summary>Clear all content setting rules set by this extension.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract clear: details: ClearDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Applies a new content setting rule.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract set: details: SetDetails * ?callback: (unit -> unit) -> unit
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of ResourceIdentifier resourceIdentifiers) {...};
            /// Parameter resourceIdentifiers: A list of resource identifiers for this content type, or undefined if this content type does not use resource identifiers.</param>
            abstract getResourceIdentifiers: callback: (ResizeArray<ResourceIdentifier> -> unit) -> unit
            /// <summary>Gets the current content setting for a given pair of URLs.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract get: details: GetDetails * callback: (ReturnedDetails -> unit) -> unit

        type [<AllowNullLiteral>] CookieContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: CookieSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (CookieSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] PopupsContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: PopupsSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (PopupsSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] JavascriptContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: JavascriptSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (JavascriptSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] NotificationsContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: NotificationsSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (NotificationsSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] PluginsContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: PluginsSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (PluginsSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] ImagesContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: ImagesSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (ImagesSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] LocationContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: LocationSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (LocationSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] FullscreenContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: FullscreenSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (FullscreenSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] MouselockContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: MouselockSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (MouselockSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] MicrophoneContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: MicrophoneSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (MicrophoneSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] CameraContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: CameraSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (CameraSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] PpapiBrokerContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: PpapiBrokerSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (PpapiBrokerSetDetails -> unit) -> unit

        type [<AllowNullLiteral>] MultipleAutomaticDownloadsContentSetting =
            inherit ContentSetting
            /// Applies a new content setting rule.
            abstract set: details: MultipleAutomaticDownloadsSetDetails * ?callback: (unit -> unit) -> unit
            /// Gets the current content setting for a given pair of URLs.
            abstract get: details: GetDetails * callback: (MultipleAutomaticDownloadsSetDetails -> unit) -> unit

        /// The only content type using resource identifiers is contentSettings.plugins. For more information, see Resource Identifiers.
        type [<AllowNullLiteral>] ResourceIdentifier =
            /// The resource identifier for the given content type.
            abstract id: string with get, set
            /// Optional. A human readable description of the resource.
            abstract description: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] CookieSetDetailsSetting =
            | Allow
            | Block
            | Session_only

        type [<StringEnum>] [<RequireQualifiedAccess>] ImagesSetDetailsSetting =
            | Allow
            | Block

        type [<StringEnum>] [<RequireQualifiedAccess>] LocationSetDetailsSetting =
            | Allow
            | Block
            | Ask

        type [<StringEnum>] [<RequireQualifiedAccess>] PluginsSetDetailsSetting =
            | Allow
            | Block
            | Detect_important_content

    module ContextMenus =

        type [<AllowNullLiteral>] IExports =
            abstract ACTION_MENU_TOP_LEVEL_LIMIT: float
            /// <summary>Removes all context menu items added by this extension.</summary>
            /// <param name="callback">Called when removal is complete.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeAll: ?callback: (unit -> unit) -> unit
            /// <summary>Creates a new context menu item. Note that if an error occurs during creation, you may not find out until the creation callback fires (the details will be in chrome.runtime.lastError).</summary>
            /// <param name="callback">Called when the item has been created in the browser. If there were any problems creating the item, details will be available in chrome.runtime.lastError.</param>
            abstract create: createProperties: CreateProperties * ?callback: (unit -> unit) -> U2<float, string>
            /// <summary>Updates a previously created context menu item.</summary>
            /// <param name="id">The ID of the item to update.</param>
            /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
            /// <param name="callback">Called when the context menu has been updated.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract update: id: string * updateProperties: UpdateProperties * ?callback: (unit -> unit) -> unit
            /// <summary>Updates a previously created context menu item.</summary>
            /// <param name="id">The ID of the item to update.</param>
            /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
            /// <param name="callback">Called when the context menu has been updated.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract update: id: float * updateProperties: UpdateProperties * ?callback: (unit -> unit) -> unit
            /// <summary>Removes a context menu item.</summary>
            /// <param name="menuItemId">The ID of the context menu item to remove.</param>
            /// <param name="callback">Called when the context menu has been removed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract remove: menuItemId: string * ?callback: (unit -> unit) -> unit
            /// <summary>Removes a context menu item.</summary>
            /// <param name="menuItemId">The ID of the context menu item to remove.</param>
            /// <param name="callback">Called when the context menu has been removed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract remove: menuItemId: float * ?callback: (unit -> unit) -> unit
            abstract onClicked: MenuClickedEvent

        type [<AllowNullLiteral>] OnClickData =
            /// Optional.
            /// Since Chrome 35.
            /// The text for the context selection, if any.
            abstract selectionText: string option with get, set
            /// Optional.
            /// Since Chrome 35.
            /// A flag indicating the state of a checkbox or radio item after it is clicked.
            abstract ``checked``: bool option with get, set
            /// Since Chrome 35.
            /// The ID of the menu item that was clicked.
            abstract menuItemId: U2<float, string> with get, set
            /// Optional.
            /// Since Chrome 35.
            /// The ID of the frame of the element where the context menu was
            /// clicked, if it was in a frame.
            abstract frameId: float option with get, set
            /// Optional.
            /// Since Chrome 35.
            /// The URL of the frame of the element where the context menu was clicked, if it was in a frame.
            abstract frameUrl: string option with get, set
            /// Since Chrome 35.
            /// A flag indicating whether the element is editable (text input, textarea, etc.).
            abstract editable: bool with get, set
            /// Optional.
            /// Since Chrome 35.
            /// One of 'image', 'video', or 'audio' if the context menu was activated on one of these types of elements.
            abstract mediaType: OnClickDataMediaType option with get, set
            /// Optional.
            /// Since Chrome 35.
            /// A flag indicating the state of a checkbox or radio item before it was clicked.
            abstract wasChecked: bool option with get, set
            /// Since Chrome 35.
            /// The URL of the page where the menu item was clicked. This property is not set if the click occurred in a context where there is no current page, such as in a launcher context menu.
            abstract pageUrl: string with get, set
            /// Optional.
            /// Since Chrome 35.
            /// If the element is a link, the URL it points to.
            abstract linkUrl: string option with get, set
            /// Optional.
            /// Since Chrome 35.
            /// The parent ID, if any, for the item clicked.
            abstract parentMenuItemId: U2<float, string> option with get, set
            /// Optional.
            /// Since Chrome 35.
            /// Will be present for elements with a 'src' URL.
            abstract srcUrl: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] ContextType =
            | All
            | Page
            | Frame
            | Selection
            | Link
            | Editable
            | Image
            | Video
            | Audio
            | Launcher
            | Browser_action
            | Page_action
            | Action

        type [<StringEnum>] [<RequireQualifiedAccess>] ContextItemType =
            | Normal
            | Checkbox
            | Radio
            | Separator

        type [<AllowNullLiteral>] CreateProperties =
            /// Optional. Lets you restrict the item to apply only to documents whose URL matches one of the given patterns. (This applies to frames as well.) For details on the format of a pattern, see Match Patterns.
            abstract documentUrlPatterns: ResizeArray<string> option with get, set
            /// Optional. The initial state of a checkbox or radio item: true for selected and false for unselected. Only one radio item can be selected at a time in a given group of radio items.
            abstract ``checked``: bool option with get, set
            /// Optional. The text to be displayed in the item; this is required unless type is 'separator'. When the context is 'selection', you can use %s within the string to show the selected text. For example, if this parameter's value is "Translate '%s' to Pig Latin" and the user selects the word "cool", the context menu item for the selection is "Translate 'cool' to Pig Latin".
            abstract title: string option with get, set
            /// Optional. List of contexts this menu item will appear in. Defaults to ['page'] if not specified.
            abstract contexts: U2<ContextType, ResizeArray<ContextType>> option with get, set
            /// Optional.
            /// Since Chrome 20.
            /// Whether this context menu item is enabled or disabled. Defaults to true.
            abstract enabled: bool option with get, set
            /// Optional. Similar to documentUrlPatterns, but lets you filter based on the src attribute of img/audio/video tags and the href of anchor tags.
            abstract targetUrlPatterns: ResizeArray<string> option with get, set
            /// Optional.
            /// A function that will be called back when the menu item is clicked. Event pages cannot use this; instead, they should register a listener for chrome.contextMenus.onClicked.
            abstract onclick: (OnClickData -> Chrome.Tabs.Tab -> unit) option with get, set
            /// Optional. The ID of a parent menu item; this makes the item a child of a previously added item.
            abstract parentId: U2<float, string> option with get, set
            /// Optional. The type of menu item. Defaults to 'normal' if not specified.
            abstract ``type``: ContextItemType option with get, set
            /// Optional.
            /// Since Chrome 21.
            /// The unique ID to assign to this item. Mandatory for event pages. Cannot be the same as another ID for this extension.
            abstract id: string option with get, set
            /// Optional.
            /// Since Chrome 62.
            /// Whether the item is visible in the menu.
            abstract visible: bool option with get, set

        type [<AllowNullLiteral>] UpdateProperties =
            abstract documentUrlPatterns: ResizeArray<string> option with get, set
            abstract ``checked``: bool option with get, set
            abstract title: string option with get, set
            abstract contexts: ResizeArray<ContextType> option with get, set
            /// Optional. Since Chrome 20.
            abstract enabled: bool option with get, set
            abstract targetUrlPatterns: ResizeArray<string> option with get, set
            abstract onclick: Function option with get, set
            /// Optional. Note: You cannot change an item to be a child of one of its own descendants.
            abstract parentId: U2<float, string> option with get, set
            abstract ``type``: ContextItemType option with get, set
            /// Optional.
            abstract visible: bool option with get, set

        type [<AllowNullLiteral>] MenuClickedEvent =
            inherit Chrome.Events.Event<(OnClickData -> Chrome.Tabs.Tab -> unit)>

        type [<StringEnum>] [<RequireQualifiedAccess>] OnClickDataMediaType =
            | Image
            | Video
            | Audio

    module Cookies =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Lists all existing cookie stores.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of CookieStore cookieStores) {...};
            /// Parameter cookieStores: All the existing cookie stores.</param>
            abstract getAllCookieStores: callback: (ResizeArray<CookieStore> -> unit) -> unit
            /// Lists all existing cookie stores.
            abstract getAllCookieStores: unit -> Promise<ResizeArray<CookieStore>>
            /// <summary>Retrieves all cookies from a single cookie store that match the given information. The cookies returned will be sorted, with those with the longest path first. If multiple cookies have the same path length, those with the earliest creation time will be first.</summary>
            /// <param name="details">Information to filter the cookies being retrieved.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of Cookie cookies) {...};
            /// Parameter cookies: All the existing, unexpired cookies that match the given cookie info.</param>
            abstract getAll: details: GetAllDetails * callback: (ResizeArray<Cookie> -> unit) -> unit
            /// <summary>Retrieves all cookies from a single cookie store that match the given information. The cookies returned will be sorted, with those with the longest path first. If multiple cookies have the same path length, those with the earliest creation time will be first.</summary>
            /// <param name="details">Information to filter the cookies being retrieved.</param>
            abstract getAll: details: GetAllDetails -> Promise<ResizeArray<Cookie>>
            /// <summary>Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.</summary>
            /// <param name="details">Details about the cookie being set.</param>
            abstract set: details: SetDetails -> Promise<Cookie option>
            /// <summary>Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.</summary>
            /// <param name="details">Details about the cookie being set.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( Cookie cookie) {...};
            /// Optional parameter cookie: Contains details about the cookie that's been set. If setting failed for any reason, this will be "null", and "chrome.runtime.lastError" will be set.</param>
            abstract set: details: SetDetails * ?callback: (Cookie option -> unit) -> unit
            /// <summary>Deletes a cookie by name.</summary>
            /// <param name="details">Information to identify the cookie to remove.</param>
            abstract remove: details: Details -> Promise<Details>
            /// <summary>Deletes a cookie by name.</summary>
            /// <param name="details">Information to identify the cookie to remove.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract remove: details: Details * ?callback: (Details -> unit) -> unit
            /// <summary>Retrieves information about a single cookie. If more than one cookie of the same name exists for the given URL, the one with the longest path will be returned. For cookies with the same path length, the cookie with the earliest creation time will be returned.</summary>
            /// <param name="details">Details to identify the cookie being retrieved.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Cookie cookie) {...};
            /// Parameter cookie: Contains details about the cookie. This parameter is null if no such cookie was found.</param>
            abstract get: details: Details * callback: (Cookie option -> unit) -> unit
            /// <summary>Retrieves information about a single cookie. If more than one cookie of the same name exists for the given URL, the one with the longest path will be returned. For cookies with the same path length, the cookie with the earliest creation time will be returned.</summary>
            /// <param name="details">Details to identify the cookie being retrieved.</param>
            abstract get: details: Details -> Promise<Cookie option>
            abstract onChanged: CookieChangedEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] SameSiteStatus =
            | Unspecified
            | No_restriction
            | Lax
            | Strict

        /// Represents information about an HTTP cookie.
        type [<AllowNullLiteral>] Cookie =
            /// The domain of the cookie (e.g. "www.google.com", "example.com").
            abstract domain: string with get, set
            /// The name of the cookie.
            abstract name: string with get, set
            /// The ID of the cookie store containing this cookie, as provided in getAllCookieStores().
            abstract storeId: string with get, set
            /// The value of the cookie.
            abstract value: string with get, set
            /// True if the cookie is a session cookie, as opposed to a persistent cookie with an expiration date.
            abstract session: bool with get, set
            /// True if the cookie is a host-only cookie (i.e. a request's host must exactly match the domain of the cookie).
            abstract hostOnly: bool with get, set
            /// Optional. The expiration date of the cookie as the number of seconds since the UNIX epoch. Not provided for session cookies.
            abstract expirationDate: float option with get, set
            /// The path of the cookie.
            abstract path: string with get, set
            /// True if the cookie is marked as HttpOnly (i.e. the cookie is inaccessible to client-side scripts).
            abstract httpOnly: bool with get, set
            /// True if the cookie is marked as Secure (i.e. its scope is limited to secure channels, typically HTTPS).
            abstract secure: bool with get, set
            /// The cookie's same-site status (i.e. whether the cookie is sent with cross-site requests).
            abstract sameSite: SameSiteStatus with get, set

        /// Represents a cookie store in the browser. An incognito mode window, for instance, uses a separate cookie store from a non-incognito window.
        type [<AllowNullLiteral>] CookieStore =
            /// The unique identifier for the cookie store.
            abstract id: string with get, set
            /// Identifiers of all the browser tabs that share this cookie store.
            abstract tabIds: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] GetAllDetails =
            /// Optional. Restricts the retrieved cookies to those whose domains match or are subdomains of this one.
            abstract domain: string option with get, set
            /// Optional. Filters the cookies by name.
            abstract name: string option with get, set
            /// Optional. Restricts the retrieved cookies to those that would match the given URL.
            abstract url: string option with get, set
            /// Optional. The cookie store to retrieve cookies from. If omitted, the current execution context's cookie store will be used.
            abstract storeId: string option with get, set
            /// Optional. Filters out session vs. persistent cookies.
            abstract session: bool option with get, set
            /// Optional. Restricts the retrieved cookies to those whose path exactly matches this string.
            abstract path: string option with get, set
            /// Optional. Filters the cookies by their Secure property.
            abstract secure: bool option with get, set

        type [<AllowNullLiteral>] SetDetails =
            /// Optional. The domain of the cookie. If omitted, the cookie becomes a host-only cookie.
            abstract domain: string option with get, set
            /// Optional. The name of the cookie. Empty by default if omitted.
            abstract name: string option with get, set
            /// The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie. If host permissions for this URL are not specified in the manifest file, the API call will fail.
            abstract url: string with get, set
            /// Optional. The ID of the cookie store in which to set the cookie. By default, the cookie is set in the current execution context's cookie store.
            abstract storeId: string option with get, set
            /// Optional. The value of the cookie. Empty by default if omitted.
            abstract value: string option with get, set
            /// Optional. The expiration date of the cookie as the number of seconds since the UNIX epoch. If omitted, the cookie becomes a session cookie.
            abstract expirationDate: float option with get, set
            /// Optional. The path of the cookie. Defaults to the path portion of the url parameter.
            abstract path: string option with get, set
            /// Optional. Whether the cookie should be marked as HttpOnly. Defaults to false.
            abstract httpOnly: bool option with get, set
            /// Optional. Whether the cookie should be marked as Secure. Defaults to false.
            abstract secure: bool option with get, set
            /// Optional. The cookie's same-site status. Defaults to "unspecified", i.e., if omitted, the cookie is set without specifying a SameSite attribute.
            abstract sameSite: SameSiteStatus option with get, set

        type [<AllowNullLiteral>] Details =
            abstract name: string with get, set
            abstract url: string with get, set
            abstract storeId: string option with get, set

        type [<AllowNullLiteral>] CookieChangeInfo =
            /// Information about the cookie that was set or removed.
            abstract cookie: Cookie with get, set
            /// True if a cookie was removed.
            abstract removed: bool with get, set
            /// Since Chrome 12.
            /// The underlying reason behind the cookie's change.
            abstract cause: string with get, set

        type [<AllowNullLiteral>] CookieChangedEvent =
            inherit Chrome.Events.Event<(CookieChangeInfo -> unit)>

    module _debugger =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Attaches debugger to the given target.</summary>
            /// <param name="target">Debugging target to which you want to attach.</param>
            /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version. List of the protocol versions can be obtained in the documentation pages.</param>
            abstract attach: target: Debuggee * requiredVersion: string -> Promise<unit>
            /// <summary>Attaches debugger to the given target.</summary>
            /// <param name="target">Debugging target to which you want to attach.</param>
            /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version. List of the protocol versions can be obtained in the documentation pages.</param>
            /// <param name="callback">Called once the attach operation succeeds or fails. Callback receives no arguments. If the attach fails, runtime.lastError will be set to the error message.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract attach: target: Debuggee * requiredVersion: string * ?callback: (unit -> unit) -> unit
            /// <summary>Detaches debugger from the given target.</summary>
            /// <param name="target">Debugging target from which you want to detach.</param>
            abstract detach: target: Debuggee -> Promise<unit>
            /// <summary>Detaches debugger from the given target.</summary>
            /// <param name="target">Debugging target from which you want to detach.</param>
            /// <param name="callback">Called once the detach operation succeeds or fails. Callback receives no arguments. If the detach fails, runtime.lastError will be set to the error message.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract detach: target: Debuggee * ?callback: (unit -> unit) -> unit
            /// <summary>Sends given command to the debugging target.</summary>
            /// <param name="target">Debugging target to which you want to send the command.</param>
            /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
            /// <param name="commandParams">Since Chrome 22.
            /// JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
            abstract sendCommand: target: Debuggee * ``method``: string * ?commandParams: Object -> Promise<Object>
            /// <summary>Sends given command to the debugging target.</summary>
            /// <param name="target">Debugging target to which you want to send the command.</param>
            /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
            /// <param name="commandParams">Since Chrome 22.
            /// JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
            /// <param name="callback">Response body. If an error occurs while posting the message, the callback will be called with no arguments and runtime.lastError will be set to the error message.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(object result) {...};</param>
            abstract sendCommand: target: Debuggee * ``method``: string * ?commandParams: Object * ?callback: (Object -> unit) -> unit
            /// Since Chrome 28.
            /// Returns the list of available debug targets.
            abstract getTargets: unit -> Promise<ResizeArray<TargetInfo>>
            /// <summary>Since Chrome 28.
            /// Returns the list of available debug targets.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of TargetInfo result) {...};
            /// Parameter result: Array of TargetInfo objects corresponding to the available debug targets.</param>
            abstract getTargets: callback: (ResizeArray<TargetInfo> -> unit) -> unit
            abstract onDetach: DebuggerDetachedEvent
            abstract onEvent: DebuggerEventEvent

        /// Debuggee identifier. Either tabId or extensionId must be specified
        type [<AllowNullLiteral>] Debuggee =
            /// Optional. The id of the tab which you intend to debug.
            abstract tabId: float option with get, set
            /// Optional.
            /// Since Chrome 27.
            /// The id of the extension which you intend to debug. Attaching to an extension background page is only possible when 'silent-debugger-extension-api' flag is enabled on the target browser.
            abstract extensionId: string option with get, set
            /// Optional.
            /// Since Chrome 28.
            /// The opaque id of the debug target.
            abstract targetId: string option with get, set

        /// Since Chrome 28.
        /// Debug target information
        type [<AllowNullLiteral>] TargetInfo =
            /// Target type.
            abstract ``type``: string with get, set
            /// Target id.
            abstract id: string with get, set
            /// Optional.
            /// Since Chrome 30.
            /// The tab id, defined if type == 'page'.
            abstract tabId: float option with get, set
            /// Optional.
            /// Since Chrome 30.
            /// The extension id, defined if type = 'background_page'.
            abstract extensionId: string option with get, set
            /// True if debugger is already attached.
            abstract attached: bool with get, set
            /// Target page title.
            abstract title: string with get, set
            /// Target URL.
            abstract url: string with get, set
            /// Optional. Target favicon URL.
            abstract faviconUrl: string option with get, set

        type [<AllowNullLiteral>] DebuggerDetachedEvent =
            inherit Chrome.Events.Event<(Debuggee -> string -> unit)>

        type [<AllowNullLiteral>] DebuggerEventEvent =
            inherit Chrome.Events.Event<(Debuggee -> string -> Object -> unit)>

    module DeclarativeContent =

        type [<AllowNullLiteral>] IExports =
            abstract PageStateMatcherProperties: PageStateMatcherPropertiesStatic
            abstract PageStateMatcher: PageStateMatcherStatic
            abstract ShowAction: ShowActionStatic
            abstract ShowPageAction: ShowPageActionStatic
            abstract SetIcon: SetIconStatic
            abstract onPageChanged: PageChangedEvent

        type [<AllowNullLiteral>] PageStateUrlDetails =
            /// Optional. Matches if the host name of the URL contains a specified string. To test whether a host name component has a prefix 'foo', use hostContains: '.foo'. This matches 'www.foobar.com' and 'foo.com', because an implicit dot is added at the beginning of the host name. Similarly, hostContains can be used to match against component suffix ('foo.') and to exactly match against components ('.foo.'). Suffix- and exact-matching for the last components need to be done separately using hostSuffix, because no implicit dot is added at the end of the host name.
            abstract hostContains: string option with get, set
            /// Optional. Matches if the host name of the URL is equal to a specified string.
            abstract hostEquals: string option with get, set
            /// Optional. Matches if the host name of the URL starts with a specified string.
            abstract hostPrefix: string option with get, set
            /// Optional. Matches if the host name of the URL ends with a specified string.
            abstract hostSuffix: string option with get, set
            /// Optional. Matches if the path segment of the URL contains a specified string.
            abstract pathContains: string option with get, set
            /// Optional. Matches if the path segment of the URL is equal to a specified string.
            abstract pathEquals: string option with get, set
            /// Optional. Matches if the path segment of the URL starts with a specified string.
            abstract pathPrefix: string option with get, set
            /// Optional. Matches if the path segment of the URL ends with a specified string.
            abstract pathSuffix: string option with get, set
            /// Optional. Matches if the query segment of the URL contains a specified string.
            abstract queryContains: string option with get, set
            /// Optional. Matches if the query segment of the URL is equal to a specified string.
            abstract queryEquals: string option with get, set
            /// Optional. Matches if the query segment of the URL starts with a specified string.
            abstract queryPrefix: string option with get, set
            /// Optional. Matches if the query segment of the URL ends with a specified string.
            abstract querySuffix: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) contains a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlContains: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) is equal to a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlEquals: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) matches a specified regular expression. Port numbers are stripped from the URL if they match the default port number. The regular expressions use the RE2 syntax.
            abstract urlMatches: string option with get, set
            /// Optional. Matches if the URL without query segment and fragment identifier matches a specified regular expression. Port numbers are stripped from the URL if they match the default port number. The regular expressions use the RE2 syntax.
            abstract originAndPathMatches: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) starts with a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlPrefix: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) ends with a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlSuffix: string option with get, set
            /// Optional. Matches if the scheme of the URL is equal to any of the schemes specified in the array.
            abstract schemes: ResizeArray<string> option with get, set
            /// Optional. Matches if the port of the URL is contained in any of the specified port lists. For example [80, 443, [1000, 1200]] matches all requests on port 80, 443 and in the range 1000-1200.
            abstract ports: ResizeArray<U2<float, ResizeArray<float>>> option with get, set

        type [<AllowNullLiteral>] PageStateMatcherProperties =
            /// Optional. Filters URLs for various criteria. See event filtering. All criteria are case sensitive.
            abstract pageUrl: PageStateUrlDetails option with get, set
            /// Optional. Matches if all of the CSS selectors in the array match displayed elements in a frame with the same origin as the page's main frame. All selectors in this array must be compound selectors to speed up matching. Note that listing hundreds of CSS selectors or CSS selectors that match hundreds of times per page can still slow down web sites.
            abstract css: ResizeArray<string> option with get, set
            /// Optional.
            /// Since Chrome 45. Warning: this is the current Beta channel. More information available on the API documentation pages.
            /// Matches if the bookmarked state of the page is equal to the specified value. Requres the bookmarks permission.
            abstract isBookmarked: bool option with get, set

        type [<AllowNullLiteral>] PageStateMatcherPropertiesStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> PageStateMatcherProperties

        /// Matches the state of a web page by various criteria.
        type [<AllowNullLiteral>] PageStateMatcher =
            interface end

        /// Matches the state of a web page by various criteria.
        type [<AllowNullLiteral>] PageStateMatcherStatic =
            [<Emit "new $0($1...)">] abstract Create: options: PageStateMatcherProperties -> PageStateMatcher

        /// Declarative event action that enables the extension's action while the corresponding conditions are met.
        /// Manifest v3.
        type [<AllowNullLiteral>] ShowAction =
            interface end

        /// Declarative event action that enables the extension's action while the corresponding conditions are met.
        /// Manifest v3.
        type [<AllowNullLiteral>] ShowActionStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ShowAction

        /// Declarative event action that shows the extension's page action while the corresponding conditions are met.
        /// Manifest v2.
        type [<AllowNullLiteral>] ShowPageAction =
            interface end

        /// Declarative event action that shows the extension's page action while the corresponding conditions are met.
        /// Manifest v2.
        type [<AllowNullLiteral>] ShowPageActionStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> ShowPageAction

        /// Declarative event action that changes the icon of the page action while the corresponding conditions are met.
        type [<AllowNullLiteral>] SetIcon =
            interface end

        /// Declarative event action that changes the icon of the page action while the corresponding conditions are met.
        type [<AllowNullLiteral>] SetIconStatic =
            [<Emit "new $0($1...)">] abstract Create: ?options: SetIconStaticOptions -> SetIcon

        type [<AllowNullLiteral>] SetIconStaticOptions =
            abstract imageData: U2<ImageData, SetIconStaticOptionsImageData> option with get, set

        /// Provides the Declarative Event API consisting of addRules, removeRules, and getRules.
        type [<AllowNullLiteral>] PageChangedEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] SetIconStaticOptionsImageData =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: size: string -> ImageData with get, set

    module DeclarativeWebRequest =

        type [<AllowNullLiteral>] IExports =
            abstract onRequest: RequestedEvent

        type [<AllowNullLiteral>] HeaderFilter =
            abstract nameEquals: string option with get, set
            abstract valueContains: U2<string, ResizeArray<string>> option with get, set
            abstract nameSuffix: string option with get, set
            abstract valueSuffix: string option with get, set
            abstract valuePrefix: string option with get, set
            abstract nameContains: U2<string, ResizeArray<string>> option with get, set
            abstract valueEquals: string option with get, set
            abstract namePrefix: string option with get, set

        type [<AllowNullLiteral>] AddResponseHeader =
            abstract name: string with get, set
            abstract value: string with get, set

        type [<AllowNullLiteral>] RemoveResponseCookie =
            abstract filter: ResponseCookie with get, set

        type [<AllowNullLiteral>] RemoveResponseHeader =
            abstract name: string with get, set
            abstract value: string option with get, set

        type [<AllowNullLiteral>] RequestMatcher =
            abstract contentType: ResizeArray<string> option with get, set
            abstract url: Chrome.Events.UrlFilter option with get, set
            abstract excludeContentType: ResizeArray<string> option with get, set
            abstract excludeResponseHeader: ResizeArray<HeaderFilter> option with get, set
            abstract resourceType: string option with get, set
            abstract responseHeaders: ResizeArray<HeaderFilter> option with get, set

        type [<AllowNullLiteral>] IgnoreRules =
            abstract lowerPriorityThan: float with get, set

        type [<AllowNullLiteral>] RedirectToEmptyDocument =
            interface end

        type [<AllowNullLiteral>] RedirectRequest =
            abstract redirectUrl: string with get, set

        type [<AllowNullLiteral>] ResponseCookie =
            abstract domain: string option with get, set
            abstract name: string option with get, set
            abstract expires: string option with get, set
            abstract maxAge: float option with get, set
            abstract value: string option with get, set
            abstract path: string option with get, set
            abstract httpOnly: string option with get, set
            abstract secure: string option with get, set

        type [<AllowNullLiteral>] AddResponseCookie =
            abstract cookie: ResponseCookie with get, set

        type [<AllowNullLiteral>] EditResponseCookie =
            abstract filter: ResponseCookie with get, set
            abstract modification: ResponseCookie with get, set

        type [<AllowNullLiteral>] CancelRequest =
            interface end

        type [<AllowNullLiteral>] RemoveRequestHeader =
            abstract name: string with get, set

        type [<AllowNullLiteral>] EditRequestCookie =
            abstract filter: RequestCookie with get, set
            abstract modification: RequestCookie with get, set

        type [<AllowNullLiteral>] SetRequestHeader =
            abstract name: string with get, set
            abstract value: string with get, set

        type [<AllowNullLiteral>] RequestCookie =
            abstract name: string option with get, set
            abstract value: string option with get, set

        type [<AllowNullLiteral>] RedirectByRegEx =
            abstract ``to``: string with get, set
            abstract from: string with get, set

        type [<AllowNullLiteral>] RedirectToTransparentImage =
            interface end

        type [<AllowNullLiteral>] AddRequestCookie =
            abstract cookie: RequestCookie with get, set

        type [<AllowNullLiteral>] RemoveRequestCookie =
            abstract filter: RequestCookie with get, set

        type [<AllowNullLiteral>] RequestedEvent =
            inherit Chrome.Events.Event<Function>

    module DesktopCapture =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Shows desktop media picker UI with the specified set of sources.</summary>
            /// <param name="sources">Set of sources that should be shown to the user.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string streamId) {...};
            /// Parameter streamId: An opaque string that can be passed to getUserMedia() API to generate media stream that corresponds to the source selected by the user. If user didn't select any source (i.e. canceled the prompt) then the callback is called with an empty streamId. The created streamId can be used only once and expires after a few seconds when it is not used.</param>
            abstract chooseDesktopMedia: sources: ResizeArray<string> * callback: (string -> StreamOptions -> unit) -> float
            /// <summary>Shows desktop media picker UI with the specified set of sources.</summary>
            /// <param name="sources">Set of sources that should be shown to the user.</param>
            /// <param name="targetTab">Optional tab for which the stream is created. If not specified then the resulting stream can be used only by the calling extension. The stream can only be used by frames in the given tab whose security origin matches tab.url.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string streamId) {...};
            /// Parameter streamId: An opaque string that can be passed to getUserMedia() API to generate media stream that corresponds to the source selected by the user. If user didn't select any source (i.e. canceled the prompt) then the callback is called with an empty streamId. The created streamId can be used only once and expires after a few seconds when it is not used.</param>
            abstract chooseDesktopMedia: sources: ResizeArray<string> * targetTab: Chrome.Tabs.Tab * callback: (string -> StreamOptions -> unit) -> float
            /// <summary>Hides desktop media picker dialog shown by chooseDesktopMedia().</summary>
            /// <param name="desktopMediaRequestId">Id returned by chooseDesktopMedia()</param>
            abstract cancelChooseDesktopMedia: desktopMediaRequestId: float -> unit

        /// Contains properties that describe the stream.
        type [<AllowNullLiteral>] StreamOptions =
            /// True if "audio" is included in parameter sources, and the end user does not uncheck the "Share audio" checkbox. Otherwise false, and in this case, one should not ask for audio stream through getUserMedia call.
            abstract canRequestAudioTrack: bool with get, set

    module Devtools =
        let [<Import("inspectedWindow","chrome/chrome/devtools")>] inspectedWindow: InspectedWindow.IExports = jsNative
        let [<Import("network","chrome/chrome/devtools")>] network: Network.IExports = jsNative
        let [<Import("panels","chrome/chrome/devtools")>] panels: Panels.IExports = jsNative

        module InspectedWindow =

            type [<AllowNullLiteral>] IExports =
                abstract tabId: float
                /// Reloads the inspected page.
                abstract reload: reloadOptions: ReloadOptions -> unit
                /// <summary>Evaluates a JavaScript expression in the context of the main frame of the inspected page. The expression must evaluate to a JSON-compliant object, otherwise an exception is thrown. The eval function can report either a DevTools-side error or a JavaScript exception that occurs during evaluation. In either case, the result parameter of the callback is undefined. In the case of a DevTools-side error, the isException parameter is non-null and has isError set to true and code set to an error code. In the case of a JavaScript error, isException is set to true and value is set to the string value of thrown object.</summary>
                /// <param name="expression">An expression to evaluate.</param>
                /// <param name="callback">A function called when evaluation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(object result, object exceptionInfo) {...};
                /// Parameter result: The result of evaluation.
                /// Parameter exceptionInfo: An object providing details if an exception occurred while evaluating the expression.</param>
                abstract eval: expression: string * ?callback: ('T -> EvaluationExceptionInfo -> unit) -> unit
                /// <summary>Evaluates a JavaScript expression in the context of the main frame of the inspected page. The expression must evaluate to a JSON-compliant object, otherwise an exception is thrown. The eval function can report either a DevTools-side error or a JavaScript exception that occurs during evaluation. In either case, the result parameter of the callback is undefined. In the case of a DevTools-side error, the isException parameter is non-null and has isError set to true and code set to an error code. In the case of a JavaScript error, isException is set to true and value is set to the string value of thrown object.</summary>
                /// <param name="expression">An expression to evaluate.</param>
                /// <param name="options">The options parameter can contain one or more options.</param>
                /// <param name="callback">A function called when evaluation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(object result, object exceptionInfo) {...};
                /// Parameter result: The result of evaluation.
                /// Parameter exceptionInfo: An object providing details if an exception occurred while evaluating the expression.</param>
                abstract eval: expression: string * ?options: EvalOptions * ?callback: ('T -> EvaluationExceptionInfo -> unit) -> unit
                /// <summary>Retrieves the list of resources from the inspected page.</summary>
                /// <param name="callback">A function that receives the list of resources when the request completes.
                /// The callback parameter should be a function that looks like this:
                /// function(array of Resource resources) {...};</param>
                abstract getResources: callback: (ResizeArray<Resource> -> unit) -> unit
                abstract onResourceAdded: ResourceAddedEvent
                abstract onResourceContentCommitted: ResourceContentCommittedEvent

            /// A resource within the inspected page, such as a document, a script, or an image.
            type [<AllowNullLiteral>] Resource =
                /// The URL of the resource.
                abstract url: string with get, set
                /// <summary>Gets the content of the resource.</summary>
                /// <param name="callback">A function that receives resource content when the request completes.
                /// The callback parameter should be a function that looks like this:
                /// function(string content, string encoding) {...};
                /// Parameter content: Content of the resource (potentially encoded).
                /// Parameter encoding: Empty if content is not encoded, encoding name otherwise. Currently, only base64 is supported.</param>
                abstract getContent: callback: (string -> string -> unit) -> unit
                /// <summary>Sets the content of the resource.</summary>
                /// <param name="content">New content of the resource. Only resources with the text type are currently supported.</param>
                /// <param name="commit">True if the user has finished editing the resource, and the new content of the resource should be persisted; false if this is a minor change sent in progress of the user editing the resource.</param>
                /// <param name="callback">A function called upon request completion.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(object error) {...};
                /// Optional parameter error: Set to undefined if the resource content was set successfully; describes error otherwise.</param>
                abstract setContent: content: string * commit: bool * ?callback: (Object -> unit) -> unit

            type [<AllowNullLiteral>] ReloadOptions =
                /// Optional. If specified, the string will override the value of the User-Agent HTTP header that's sent while loading the resources of the inspected page. The string will also override the value of the navigator.userAgent property that's returned to any scripts that are running within the inspected page.
                abstract userAgent: string option with get, set
                /// Optional. When true, the loader will ignore the cache for all inspected page resources loaded before the load event is fired. The effect is similar to pressing Ctrl+Shift+R in the inspected window or within the Developer Tools window.
                abstract ignoreCache: bool option with get, set
                /// Optional. If specified, the script will be injected into every frame of the inspected page immediately upon load, before any of the frame's scripts. The script will not be injected after subsequent reloads—for example, if the user presses Ctrl+R.
                abstract injectedScript: string option with get, set
                /// Optional.
                /// If specified, this script evaluates into a function that accepts three string arguments: the source to preprocess, the URL of the source, and a function name if the source is an DOM event handler. The preprocessorerScript function should return a string to be compiled by Chrome in place of the input source. In the case that the source is a DOM event handler, the returned source must compile to a single JS function.
                abstract preprocessorScript: string option with get, set

            type [<AllowNullLiteral>] EvaluationExceptionInfo =
                /// Set if the error occurred on the DevTools side before the expression is evaluated.
                abstract isError: bool with get, set
                /// Set if the error occurred on the DevTools side before the expression is evaluated.
                abstract code: string with get, set
                /// Set if the error occurred on the DevTools side before the expression is evaluated.
                abstract description: string with get, set
                /// Set if the error occurred on the DevTools side before the expression is evaluated, contains the array of the values that may be substituted into the description string to provide more information about the cause of the error.
                abstract details: ResizeArray<obj option> with get, set
                /// Set if the evaluated code produces an unhandled exception.
                abstract isException: bool with get, set
                /// Set if the evaluated code produces an unhandled exception.
                abstract value: string with get, set

            type [<AllowNullLiteral>] ResourceAddedEvent =
                inherit Chrome.Events.Event<(Resource -> unit)>

            type [<AllowNullLiteral>] ResourceContentCommittedEvent =
                inherit Chrome.Events.Event<(Resource -> string -> unit)>

            type [<AllowNullLiteral>] EvalOptions =
                /// If specified, the expression is evaluated on the iframe whose URL matches the one specified. By default, the expression is evaluated in the top frame of the inspected page.
                abstract frameURL: string option with get, set
                /// Evaluate the expression in the context of the content script of the calling extension, provided that the content script is already injected into the inspected page. If not, the expression is not evaluated and the callback is invoked with the exception parameter set to an object that has the isError field set to true and the code field set to E_NOTFOUND.
                abstract useContentScriptContext: bool option with get, set
                /// Evaluate the expression in the context of a content script of an extension that matches the specified origin. If given, contextSecurityOrigin overrides the 'true' setting on userContentScriptContext.
                abstract contextSecurityOrigin: string option with get, set

        module Network =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Returns HAR log that contains all known network requests.</summary>
                /// <param name="callback">A function that receives the HAR log when the request completes.
                /// The callback parameter should be a function that looks like this:
                /// function(object harLog) {...};
                /// Parameter harLog: A HAR log. See HAR specification for details.</param>
                // abstract getHAR: callback: (HARLog -> unit) -> unit
                abstract onRequestFinished: RequestFinishedEvent
                abstract onNavigated: NavigatedEvent

            /// Represents a HAR entry for a specific finished request.
            // type [<AllowNullLiteral>] HAREntry =
            //     inherit HARFormatEntry
            //
            // /// Represents a HAR log that contains all known network requests.
            // type [<AllowNullLiteral>] HARLog =
            //     inherit HARFormatLog

            /// Represents a network request for a document resource (script, image and so on). See HAR Specification for reference.
            type [<AllowNullLiteral>] Request =
                // inherit Chrome.Devtools.Network.HAREntry
                /// <summary>Returns content of the response body.</summary>
                /// <param name="callback">A function that receives the response body when the request completes.
                /// The callback parameter should be a function that looks like this:
                /// function(string content, string encoding) {...};
                /// Parameter content: Content of the response body (potentially encoded).
                /// Parameter encoding: Empty if content is not encoded, encoding name otherwise. Currently, only base64 is supported.</param>
                abstract getContent: callback: (string -> string -> unit) -> unit

            type [<AllowNullLiteral>] RequestFinishedEvent =
                inherit Chrome.Events.Event<(Request -> unit)>

            type [<AllowNullLiteral>] NavigatedEvent =
                inherit Chrome.Events.Event<(string -> unit)>

        module Panels =

            type [<AllowNullLiteral>] IExports =
                abstract elements: ElementsPanel
                abstract sources: SourcesPanel
                /// <summary>Creates an extension panel.</summary>
                /// <param name="title">Title that is displayed next to the extension icon in the Developer Tools toolbar.</param>
                /// <param name="iconPath">Path of the panel's icon relative to the extension directory.</param>
                /// <param name="pagePath">Path of the panel's HTML page relative to the extension directory.</param>
                /// <param name="callback">A function that is called when the panel is created.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function( ExtensionPanel panel) {...};
                /// Parameter panel: An ExtensionPanel object representing the created panel.</param>
                abstract create: title: string * iconPath: string * pagePath: string * ?callback: (ExtensionPanel -> unit) -> unit
                /// <summary>Specifies the function to be called when the user clicks a resource link in the Developer Tools window. To unset the handler, either call the method with no parameters or pass null as the parameter.</summary>
                /// <param name="callback">A function that is called when the user clicks on a valid resource link in Developer Tools window. Note that if the user clicks an invalid URL or an XHR, this function is not called.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function( devtools.inspectedWindow.Resource resource) {...};
                /// Parameter resource: A devtools.inspectedWindow.Resource object for the resource that was clicked.</param>
                abstract setOpenResourceHandler: ?callback: (Chrome.Devtools.InspectedWindow.Resource -> unit) -> unit
                /// <summary>Since Chrome 38.
                /// Requests DevTools to open a URL in a Developer Tools panel.</summary>
                /// <param name="url">The URL of the resource to open.</param>
                /// <param name="lineNumber">Specifies the line number to scroll to when the resource is loaded.</param>
                /// <param name="callback">A function that is called when the resource has been successfully loaded.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract openResource: url: string * lineNumber: float * callback: (unit -> unit) -> unit
                abstract themeName: IExportsThemeName

            type [<AllowNullLiteral>] PanelShownEvent =
                inherit Chrome.Events.Event<(Window -> unit)>

            type [<AllowNullLiteral>] PanelHiddenEvent =
                inherit Chrome.Events.Event<(unit -> unit)>

            type [<AllowNullLiteral>] PanelSearchEvent =
                inherit Chrome.Events.Event<(string -> string -> unit)>

            /// Represents a panel created by extension.
            type [<AllowNullLiteral>] ExtensionPanel =
                /// <summary>Appends a button to the status bar of the panel.</summary>
                /// <param name="iconPath">Path to the icon of the button. The file should contain a 64x24-pixel image composed of two 32x24 icons. The left icon is used when the button is inactive; the right icon is displayed when the button is pressed.</param>
                /// <param name="tooltipText">Text shown as a tooltip when user hovers the mouse over the button.</param>
                /// <param name="disabled">Whether the button is disabled.</param>
                abstract createStatusBarButton: iconPath: string * tooltipText: string * disabled: bool -> Button
                /// Fired when the user switches to the panel.
                abstract onShown: PanelShownEvent with get, set
                /// Fired when the user switches away from the panel.
                abstract onHidden: PanelHiddenEvent with get, set
                /// Fired upon a search action (start of a new search, search result navigation, or search being canceled).
                abstract onSearch: PanelSearchEvent with get, set

            type [<AllowNullLiteral>] ButtonClickedEvent =
                inherit Chrome.Events.Event<(unit -> unit)>

            /// A button created by the extension.
            type [<AllowNullLiteral>] Button =
                /// <summary>Updates the attributes of the button. If some of the arguments are omitted or null, the corresponding attributes are not updated.</summary>
                /// <param name="iconPath">Path to the new icon of the button.</param>
                /// <param name="tooltipText">Text shown as a tooltip when user hovers the mouse over the button.</param>
                /// <param name="disabled">Whether the button is disabled.</param>
                abstract update: ?iconPath: string * ?tooltipText: string * ?disabled: bool -> unit
                /// Fired when the button is clicked.
                abstract onClicked: ButtonClickedEvent with get, set

            type [<AllowNullLiteral>] SelectionChangedEvent =
                inherit Chrome.Events.Event<(unit -> unit)>

            /// Represents the Elements panel.
            type [<AllowNullLiteral>] ElementsPanel =
                /// <summary>Creates a pane within panel's sidebar.</summary>
                /// <param name="title">Text that is displayed in sidebar caption.</param>
                /// <param name="callback">A callback invoked when the sidebar is created.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function( ExtensionSidebarPane result) {...};
                /// Parameter result: An ExtensionSidebarPane object for created sidebar pane.</param>
                abstract createSidebarPane: title: string * ?callback: (ExtensionSidebarPane -> unit) -> unit
                /// Fired when an object is selected in the panel.
                abstract onSelectionChanged: SelectionChangedEvent with get, set

            /// Since Chrome 41.
            /// Represents the Sources panel.
            type [<AllowNullLiteral>] SourcesPanel =
                /// <summary>Creates a pane within panel's sidebar.</summary>
                /// <param name="title">Text that is displayed in sidebar caption.</param>
                /// <param name="callback">A callback invoked when the sidebar is created.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function( ExtensionSidebarPane result) {...};
                /// Parameter result: An ExtensionSidebarPane object for created sidebar pane.</param>
                abstract createSidebarPane: title: string * ?callback: (ExtensionSidebarPane -> unit) -> unit
                /// Fired when an object is selected in the panel.
                abstract onSelectionChanged: SelectionChangedEvent with get, set

            type [<AllowNullLiteral>] ExtensionSidebarPaneShownEvent =
                inherit Chrome.Events.Event<(Chrome.Windows.Window -> unit)>

            type [<AllowNullLiteral>] ExtensionSidebarPaneHiddenEvent =
                inherit Chrome.Events.Event<(unit -> unit)>

            /// A sidebar created by the extension.
            type [<AllowNullLiteral>] ExtensionSidebarPane =
                /// <summary>Sets the height of the sidebar.</summary>
                /// <param name="height">A CSS-like size specification, such as '100px' or '12ex'.</param>
                abstract setHeight: height: string -> unit
                /// <summary>Sets an expression that is evaluated within the inspected page. The result is displayed in the sidebar pane.</summary>
                /// <param name="expression">An expression to be evaluated in context of the inspected page. JavaScript objects and DOM nodes are displayed in an expandable tree similar to the console/watch.</param>
                /// <param name="rootTitle">An optional title for the root of the expression tree.</param>
                /// <param name="callback">A callback invoked after the sidebar pane is updated with the expression evaluation results.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setExpression: expression: string * ?rootTitle: string * ?callback: (unit -> unit) -> unit
                /// <summary>Sets an expression that is evaluated within the inspected page. The result is displayed in the sidebar pane.</summary>
                /// <param name="expression">An expression to be evaluated in context of the inspected page. JavaScript objects and DOM nodes are displayed in an expandable tree similar to the console/watch.</param>
                /// <param name="callback">A callback invoked after the sidebar pane is updated with the expression evaluation results.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setExpression: expression: string * ?callback: (unit -> unit) -> unit
                /// <summary>Sets a JSON-compliant object to be displayed in the sidebar pane.</summary>
                /// <param name="jsonObject">An object to be displayed in context of the inspected page. Evaluated in the context of the caller (API client).</param>
                /// <param name="rootTitle">An optional title for the root of the expression tree.</param>
                /// <param name="callback">A callback invoked after the sidebar is updated with the object.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setObject: jsonObject: Object * ?rootTitle: string * ?callback: (unit -> unit) -> unit
                /// <summary>Sets a JSON-compliant object to be displayed in the sidebar pane.</summary>
                /// <param name="jsonObject">An object to be displayed in context of the inspected page. Evaluated in the context of the caller (API client).</param>
                /// <param name="callback">A callback invoked after the sidebar is updated with the object.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setObject: jsonObject: Object * ?callback: (unit -> unit) -> unit
                /// <summary>Sets an HTML page to be displayed in the sidebar pane.</summary>
                /// <param name="path">Relative path of an extension page to display within the sidebar.</param>
                abstract setPage: path: string -> unit
                /// Fired when the sidebar pane becomes visible as a result of user switching to the panel that hosts it.
                abstract onShown: ExtensionSidebarPaneShownEvent with get, set
                /// Fired when the sidebar pane becomes hidden as a result of the user switching away from the panel that hosts the sidebar pane.
                abstract onHidden: ExtensionSidebarPaneHiddenEvent with get, set

            type [<StringEnum>] [<RequireQualifiedAccess>] IExportsThemeName =
                | Default
                | Dark

    module DocumentScan =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Performs a document scan. On success, the PNG data will be sent to the callback.</summary>
            /// <param name="options">Object containing scan parameters.</param>
            /// <param name="callback">Called with the result and data from the scan.
            /// The callback parameter should be a function that looks like this:
            /// function(object result) {...};</param>
            abstract scan: options: DocumentScanOptions * callback: (DocumentScanCallbackArg -> unit) -> unit

        type [<AllowNullLiteral>] DocumentScanOptions =
            /// Optional. The MIME types that are accepted by the caller.
            abstract mimeTypes: ResizeArray<string> option with get, set
            /// Optional. The number of scanned images allowed (defaults to 1).
            abstract maxImages: float option with get, set

        type [<AllowNullLiteral>] DocumentScanCallbackArg =
            /// The data image URLs in a form that can be passed as the "src" value to an image tag.
            abstract dataUrls: ResizeArray<string> with get, set
            /// The MIME type of dataUrls.
            abstract mimeType: string with get, set

    module Downloads =

        type [<AllowNullLiteral>] IExports =
            /// Find DownloadItem. Set query to the empty object to get all DownloadItem. To get a specific DownloadItem, set only the id field. To page through a large number of items, set orderBy: ['-startTime'], set limit to the number of items per page, and set startedAfter to the startTime of the last item from the last page.
            abstract search: query: DownloadQuery -> Promise<ResizeArray<DownloadItem>>
            /// <summary>Find DownloadItem. Set query to the empty object to get all DownloadItem. To get a specific DownloadItem, set only the id field. To page through a large number of items, set orderBy: ['-startTime'], set limit to the number of items per page, and set startedAfter to the startTime of the last item from the last page.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of DownloadItem results) {...};</param>
            abstract search: query: DownloadQuery * callback: (ResizeArray<DownloadItem> -> unit) -> unit
            /// <summary>Pause the download. If the request was successful the download is in a paused state. Otherwise runtime.lastError contains an error message. The request will fail if the download is not active.</summary>
            /// <param name="downloadId">The id of the download to pause.</param>
            abstract pause: downloadId: float -> Promise<unit>
            /// <summary>Pause the download. If the request was successful the download is in a paused state. Otherwise runtime.lastError contains an error message. The request will fail if the download is not active.</summary>
            /// <param name="downloadId">The id of the download to pause.</param>
            /// <param name="callback">Called when the pause request is completed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract pause: downloadId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Retrieve an icon for the specified download. For new downloads, file icons are available after the onCreated event has been received. The image returned by this function while a download is in progress may be different from the image returned after the download is complete. Icon retrieval is done by querying the underlying operating system or toolkit depending on the platform. The icon that is returned will therefore depend on a number of factors including state of the download, platform, registered file types and visual theme. If a file icon cannot be determined, runtime.lastError will contain an error message.</summary>
            /// <param name="downloadId">The identifier for the download.</param>
            abstract getFileIcon: downloadId: float * ?options: GetFileIconOptions -> Promise<string>
            /// <summary>Retrieve an icon for the specified download. For new downloads, file icons are available after the onCreated event has been received. The image returned by this function while a download is in progress may be different from the image returned after the download is complete. Icon retrieval is done by querying the underlying operating system or toolkit depending on the platform. The icon that is returned will therefore depend on a number of factors including state of the download, platform, registered file types and visual theme. If a file icon cannot be determined, runtime.lastError will contain an error message.</summary>
            /// <param name="downloadId">The identifier for the download.</param>
            /// <param name="callback">A URL to an image that represents the download.
            /// The callback parameter should be a function that looks like this:
            /// function(string iconURL) {...};</param>
            abstract getFileIcon: downloadId: float * callback: (string -> unit) -> unit
            /// <summary>Retrieve an icon for the specified download. For new downloads, file icons are available after the onCreated event has been received. The image returned by this function while a download is in progress may be different from the image returned after the download is complete. Icon retrieval is done by querying the underlying operating system or toolkit depending on the platform. The icon that is returned will therefore depend on a number of factors including state of the download, platform, registered file types and visual theme. If a file icon cannot be determined, runtime.lastError will contain an error message.</summary>
            /// <param name="downloadId">The identifier for the download.</param>
            /// <param name="callback">A URL to an image that represents the download.
            /// The callback parameter should be a function that looks like this:
            /// function(string iconURL) {...};</param>
            abstract getFileIcon: downloadId: float * options: GetFileIconOptions * callback: (string -> unit) -> unit
            /// <summary>Resume a paused download. If the request was successful the download is in progress and unpaused. Otherwise runtime.lastError contains an error message. The request will fail if the download is not active.</summary>
            /// <param name="downloadId">The id of the download to resume.</param>
            abstract resume: downloadId: float -> Promise<unit>
            /// <summary>Resume a paused download. If the request was successful the download is in progress and unpaused. Otherwise runtime.lastError contains an error message. The request will fail if the download is not active.</summary>
            /// <param name="downloadId">The id of the download to resume.</param>
            /// <param name="callback">Called when the resume request is completed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract resume: downloadId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Cancel a download. When callback is run, the download is cancelled, completed, interrupted or doesn't exist anymore.</summary>
            /// <param name="downloadId">The id of the download to cancel.</param>
            abstract cancel: downloadId: float -> Promise<unit>
            /// <summary>Cancel a download. When callback is run, the download is cancelled, completed, interrupted or doesn't exist anymore.</summary>
            /// <param name="downloadId">The id of the download to cancel.</param>
            /// <param name="callback">Called when the cancel request is completed.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract cancel: downloadId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Download a URL. If the URL uses the HTTP[S] protocol, then the request will include all cookies currently set for its hostname. If both filename and saveAs are specified, then the Save As dialog will be displayed, pre-populated with the specified filename. If the download started successfully, callback will be called with the new DownloadItem's downloadId. If there was an error starting the download, then callback will be called with downloadId=undefined and runtime.lastError will contain a descriptive string. The error strings are not guaranteed to remain backwards compatible between releases. Extensions must not parse it.</summary>
            /// <param name="options">What to download and how.</param>
            abstract download: options: DownloadOptions -> Promise<float>
            /// <summary>Download a URL. If the URL uses the HTTP[S] protocol, then the request will include all cookies currently set for its hostname. If both filename and saveAs are specified, then the Save As dialog will be displayed, pre-populated with the specified filename. If the download started successfully, callback will be called with the new DownloadItem's downloadId. If there was an error starting the download, then callback will be called with downloadId=undefined and runtime.lastError will contain a descriptive string. The error strings are not guaranteed to remain backwards compatible between releases. Extensions must not parse it.</summary>
            /// <param name="options">What to download and how.</param>
            /// <param name="callback">Called with the id of the new DownloadItem.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(integer downloadId) {...};</param>
            abstract download: options: DownloadOptions * ?callback: (float -> unit) -> unit
            /// <summary>Open the downloaded file now if the DownloadItem is complete; otherwise returns an error through runtime.lastError. Requires the "downloads.open" permission in addition to the "downloads" permission. An onChanged event will fire when the item is opened for the first time.</summary>
            /// <param name="downloadId">The identifier for the downloaded file.</param>
            abstract ``open``: downloadId: float -> unit
            /// <summary>Show the downloaded file in its folder in a file manager.</summary>
            /// <param name="downloadId">The identifier for the downloaded file.</param>
            abstract show: downloadId: float -> unit
            /// Show the default Downloads folder in a file manager.
            abstract showDefaultFolder: unit -> unit
            /// Erase matching DownloadItem from history without deleting the downloaded file. An onErased event will fire for each DownloadItem that matches query, then callback will be called.
            abstract erase: query: DownloadQuery -> Promise<ResizeArray<float>>
            /// <summary>Erase matching DownloadItem from history without deleting the downloaded file. An onErased event will fire for each DownloadItem that matches query, then callback will be called.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of integer erasedIds) {...};</param>
            abstract erase: query: DownloadQuery * callback: (ResizeArray<float> -> unit) -> unit
            /// Remove the downloaded file if it exists and the DownloadItem is complete; otherwise return an error through runtime.lastError.
            abstract removeFile: downloadId: float -> Promise<unit>
            /// <summary>Remove the downloaded file if it exists and the DownloadItem is complete; otherwise return an error through runtime.lastError.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeFile: downloadId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Prompt the user to accept a dangerous download. Can only be called from a visible context (tab, window, or page/browser action popup). Does not automatically accept dangerous downloads. If the download is accepted, then an onChanged event will fire, otherwise nothing will happen. When all the data is fetched into a temporary file and either the download is not dangerous or the danger has been accepted, then the temporary file is renamed to the target filename, the |state| changes to 'complete', and onChanged fires.</summary>
            /// <param name="downloadId">The identifier for the DownloadItem.</param>
            abstract acceptDanger: downloadId: float -> Promise<unit>
            /// <summary>Prompt the user to accept a dangerous download. Can only be called from a visible context (tab, window, or page/browser action popup). Does not automatically accept dangerous downloads. If the download is accepted, then an onChanged event will fire, otherwise nothing will happen. When all the data is fetched into a temporary file and either the download is not dangerous or the danger has been accepted, then the temporary file is renamed to the target filename, the |state| changes to 'complete', and onChanged fires.</summary>
            /// <param name="downloadId">The identifier for the DownloadItem.</param>
            /// <param name="callback">Called when the danger prompt dialog closes.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract acceptDanger: downloadId: float * callback: (unit -> unit) -> unit
            /// Initiate dragging the downloaded file to another application. Call in a javascript ondragstart handler.
            abstract drag: downloadId: float -> unit
            /// Enable or disable the gray shelf at the bottom of every window associated with the current browser profile. The shelf will be disabled as long as at least one extension has disabled it. Enabling the shelf while at least one other extension has disabled it will return an error through runtime.lastError. Requires the "downloads.shelf" permission in addition to the "downloads" permission.
            abstract setShelfEnabled: enabled: bool -> unit
            abstract onChanged: DownloadChangedEvent
            abstract onCreated: DownloadCreatedEvent
            abstract onErased: DownloadErasedEvent
            abstract onDeterminingFilename: DownloadDeterminingFilenameEvent

        type [<AllowNullLiteral>] HeaderNameValuePair =
            /// Name of the HTTP header.
            abstract name: string with get, set
            /// Value of the HTTP header.
            abstract value: string with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] FilenameConflictAction =
            | Uniquify
            | Overwrite
            | Prompt

        type [<AllowNullLiteral>] DownloadOptions =
            /// Optional. Post body.
            abstract body: string option with get, set
            /// Optional. Use a file-chooser to allow the user to select a filename regardless of whether filename is set or already exists.
            abstract saveAs: bool option with get, set
            /// The URL to download.
            abstract url: string with get, set
            /// Optional. A file path relative to the Downloads directory to contain the downloaded file, possibly containing subdirectories. Absolute paths, empty paths, and paths containing back-references ".." will cause an error. onDeterminingFilename allows suggesting a filename after the file's MIME type and a tentative filename have been determined.
            abstract filename: string option with get, set
            /// Optional. Extra HTTP headers to send with the request if the URL uses the HTTP[s] protocol. Each header is represented as a dictionary containing the keys name and either value or binaryValue, restricted to those allowed by XMLHttpRequest.
            abstract headers: ResizeArray<HeaderNameValuePair> option with get, set
            /// Optional. The HTTP method to use if the URL uses the HTTP[S] protocol.
            abstract ``method``: DownloadOptionsMethod option with get, set
            /// Optional. The action to take if filename already exists.
            abstract conflictAction: FilenameConflictAction option with get, set

        type [<AllowNullLiteral>] DownloadDelta =
            /// The id of the DownloadItem that changed.
            abstract id: float with get, set
            /// Optional. The change in danger, if any.
            abstract danger: StringDelta option with get, set
            /// Optional. The change in url, if any.
            abstract url: StringDelta option with get, set
            /// Optional. The change in finalUrl, if any.
            abstract finalUrl: StringDelta option with get, set
            /// Optional. The change in totalBytes, if any.
            abstract totalBytes: DoubleDelta option with get, set
            /// Optional. The change in filename, if any.
            abstract filename: StringDelta option with get, set
            /// Optional. The change in paused, if any.
            abstract paused: BooleanDelta option with get, set
            /// Optional. The change in state, if any.
            abstract state: StringDelta option with get, set
            /// Optional. The change in mime, if any.
            abstract mime: StringDelta option with get, set
            /// Optional. The change in fileSize, if any.
            abstract fileSize: DoubleDelta option with get, set
            /// Optional. The change in startTime, if any.
            abstract startTime: StringDelta option with get, set
            /// Optional. The change in error, if any.
            abstract error: StringDelta option with get, set
            /// Optional. The change in endTime, if any.
            abstract endTime: StringDelta option with get, set
            /// Optional. The change in canResume, if any.
            abstract canResume: BooleanDelta option with get, set
            /// Optional. The change in exists, if any.
            abstract exists: BooleanDelta option with get, set

        type [<AllowNullLiteral>] BooleanDelta =
            abstract current: bool option with get, set
            abstract previous: bool option with get, set

        /// Since Chrome 34.
        type [<AllowNullLiteral>] DoubleDelta =
            abstract current: float option with get, set
            abstract previous: float option with get, set

        type [<AllowNullLiteral>] StringDelta =
            abstract current: string option with get, set
            abstract previous: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] DownloadInterruptReason =
            | [<CompiledName "FILE_FAILED">] FILE_FAILED
            | [<CompiledName "FILE_ACCESS_DENIED">] FILE_ACCESS_DENIED
            | [<CompiledName "FILE_NO_SPACE">] FILE_NO_SPACE
            | [<CompiledName "FILE_NAME_TOO_LONG">] FILE_NAME_TOO_LONG
            | [<CompiledName "FILE_TOO_LARGE">] FILE_TOO_LARGE
            | [<CompiledName "FILE_VIRUS_INFECTED">] FILE_VIRUS_INFECTED
            | [<CompiledName "FILE_TRANSIENT_ERROR">] FILE_TRANSIENT_ERROR
            | [<CompiledName "FILE_BLOCKED">] FILE_BLOCKED
            | [<CompiledName "FILE_SECURITY_CHECK_FAILED">] FILE_SECURITY_CHECK_FAILED
            | [<CompiledName "FILE_TOO_SHORT">] FILE_TOO_SHORT
            | [<CompiledName "FILE_HASH_MISMATCH">] FILE_HASH_MISMATCH
            | [<CompiledName "FILE_SAME_AS_SOURCE">] FILE_SAME_AS_SOURCE
            | [<CompiledName "NETWORK_FAILED">] NETWORK_FAILED
            | [<CompiledName "NETWORK_TIMEOUT">] NETWORK_TIMEOUT
            | [<CompiledName "NETWORK_DISCONNECTED">] NETWORK_DISCONNECTED
            | [<CompiledName "NETWORK_SERVER_DOWN">] NETWORK_SERVER_DOWN
            | [<CompiledName "NETWORK_INVALID_REQUEST">] NETWORK_INVALID_REQUEST
            | [<CompiledName "SERVER_FAILED">] SERVER_FAILED
            | [<CompiledName "SERVER_NO_RANGE">] SERVER_NO_RANGE
            | [<CompiledName "SERVER_BAD_CONTENT">] SERVER_BAD_CONTENT
            | [<CompiledName "SERVER_UNAUTHORIZED">] SERVER_UNAUTHORIZED
            | [<CompiledName "SERVER_CERT_PROBLEM">] SERVER_CERT_PROBLEM
            | [<CompiledName "SERVER_FORBIDDEN">] SERVER_FORBIDDEN
            | [<CompiledName "SERVER_UNREACHABLE">] SERVER_UNREACHABLE
            | [<CompiledName "SERVER_CONTENT_LENGTH_MISMATCH">] SERVER_CONTENT_LENGTH_MISMATCH
            | [<CompiledName "SERVER_CROSS_ORIGIN_REDIRECT">] SERVER_CROSS_ORIGIN_REDIRECT
            | [<CompiledName "USER_CANCELED">] USER_CANCELED
            | [<CompiledName "USER_SHUTDOWN">] USER_SHUTDOWN
            | [<CompiledName "CRASH">] CRASH

        type [<StringEnum>] [<RequireQualifiedAccess>] DownloadState =
            | In_progress
            | Interrupted
            | Complete

        type [<StringEnum>] [<RequireQualifiedAccess>] DangerType =
            | File
            | Url
            | Content
            | Uncommon
            | Host
            | Unwanted
            | Safe
            | Accepted

        type [<AllowNullLiteral>] DownloadItem =
            /// Number of bytes received so far from the host, without considering file compression.
            abstract bytesReceived: float with get, set
            /// Indication of whether this download is thought to be safe or known to be suspicious.
            abstract danger: DangerType with get, set
            /// The absolute URL that this download initiated from, before any redirects.
            abstract url: string with get, set
            /// The absolute URL that this download is being made from, after all redirects.
            abstract finalUrl: string with get, set
            /// Number of bytes in the whole file, without considering file compression, or -1 if unknown.
            abstract totalBytes: float with get, set
            /// Absolute local path.
            abstract filename: string with get, set
            /// True if the download has stopped reading data from the host, but kept the connection open.
            abstract paused: bool with get, set
            /// Indicates whether the download is progressing, interrupted, or complete.
            abstract state: DownloadState with get, set
            /// The file's MIME type.
            abstract mime: string with get, set
            /// Number of bytes in the whole file post-decompression, or -1 if unknown.
            abstract fileSize: float with get, set
            /// The time when the download began in ISO 8601 format. May be passed directly to the Date constructor: chrome.downloads.search({}, function(items){items.forEach(function(item){console.log(new Date(item.startTime))})})
            abstract startTime: string with get, set
            /// Optional. Why the download was interrupted. Several kinds of HTTP errors may be grouped under one of the errors beginning with SERVER_. Errors relating to the network begin with NETWORK_, errors relating to the process of writing the file to the file system begin with FILE_, and interruptions initiated by the user begin with USER_.
            abstract error: DownloadInterruptReason option with get, set
            /// Optional. The time when the download ended in ISO 8601 format. May be passed directly to the Date constructor: chrome.downloads.search({}, function(items){items.forEach(function(item){if (item.endTime) console.log(new Date(item.endTime))})})
            abstract endTime: string option with get, set
            /// An identifier that is persistent across browser sessions.
            abstract id: float with get, set
            /// False if this download is recorded in the history, true if it is not recorded.
            abstract incognito: bool with get, set
            /// Absolute URL.
            abstract referrer: string with get, set
            /// Optional. Estimated time when the download will complete in ISO 8601 format. May be passed directly to the Date constructor: chrome.downloads.search({}, function(items){items.forEach(function(item){if (item.estimatedEndTime) console.log(new Date(item.estimatedEndTime))})})
            abstract estimatedEndTime: string option with get, set
            /// True if the download is in progress and paused, or else if it is interrupted and can be resumed starting from where it was interrupted.
            abstract canResume: bool with get, set
            /// Whether the downloaded file still exists. This information may be out of date because Chrome does not automatically watch for file removal. Call search() in order to trigger the check for file existence. When the existence check completes, if the file has been deleted, then an onChanged event will fire. Note that search() does not wait for the existence check to finish before returning, so results from search() may not accurately reflect the file system. Also, search() may be called as often as necessary, but will not check for file existence any more frequently than once every 10 seconds.
            abstract exists: bool with get, set
            /// Optional. The identifier for the extension that initiated this download if this download was initiated by an extension. Does not change once it is set.
            abstract byExtensionId: string option with get, set
            /// Optional. The localized name of the extension that initiated this download if this download was initiated by an extension. May change if the extension changes its name or if the user changes their locale.
            abstract byExtensionName: string option with get, set

        type [<AllowNullLiteral>] GetFileIconOptions =
            /// Optional. * The size of the returned icon. The icon will be square with dimensions size * size pixels. The default and largest size for the icon is 32x32 pixels. The only supported sizes are 16 and 32. It is an error to specify any other size.
            abstract size: GetFileIconOptionsSize option with get, set

        type [<AllowNullLiteral>] DownloadQuery =
            /// Optional. Set elements of this array to DownloadItem properties in order to sort search results. For example, setting orderBy=['startTime'] sorts the DownloadItem by their start time in ascending order. To specify descending order, prefix with a hyphen: '-startTime'.
            abstract orderBy: ResizeArray<string> option with get, set
            /// Optional. Limits results to DownloadItem whose url matches the given regular expression.
            abstract urlRegex: string option with get, set
            /// Optional. Limits results to DownloadItem that ended before the time in ISO 8601 format.
            abstract endedBefore: string option with get, set
            /// Optional. Limits results to DownloadItem whose totalBytes is greater than the given integer.
            abstract totalBytesGreater: float option with get, set
            /// Optional. Indication of whether this download is thought to be safe or known to be suspicious.
            abstract danger: string option with get, set
            /// Optional. Number of bytes in the whole file, without considering file compression, or -1 if unknown.
            abstract totalBytes: float option with get, set
            /// Optional. True if the download has stopped reading data from the host, but kept the connection open.
            abstract paused: bool option with get, set
            /// Optional. Limits results to DownloadItem whose filename matches the given regular expression.
            abstract filenameRegex: string option with get, set
            /// Optional. This array of search terms limits results to DownloadItem whose filename or url contain all of the search terms that do not begin with a dash '-' and none of the search terms that do begin with a dash.
            abstract query: ResizeArray<string> option with get, set
            /// Optional. Limits results to DownloadItem whose totalBytes is less than the given integer.
            abstract totalBytesLess: float option with get, set
            /// Optional. The id of the DownloadItem to query.
            abstract id: float option with get, set
            /// Optional. Number of bytes received so far from the host, without considering file compression.
            abstract bytesReceived: float option with get, set
            /// Optional. Limits results to DownloadItem that ended after the time in ISO 8601 format.
            abstract endedAfter: string option with get, set
            /// Optional. Absolute local path.
            abstract filename: string option with get, set
            /// Optional. Indicates whether the download is progressing, interrupted, or complete.
            abstract state: string option with get, set
            /// Optional. Limits results to DownloadItem that started after the time in ISO 8601 format.
            abstract startedAfter: string option with get, set
            /// Optional. The file's MIME type.
            abstract mime: string option with get, set
            /// Optional. Number of bytes in the whole file post-decompression, or -1 if unknown.
            abstract fileSize: float option with get, set
            /// Optional. The time when the download began in ISO 8601 format.
            abstract startTime: string option with get, set
            /// Optional. Absolute URL.
            abstract url: string option with get, set
            /// Optional. Limits results to DownloadItem that started before the time in ISO 8601 format.
            abstract startedBefore: string option with get, set
            /// Optional. The maximum number of matching DownloadItem returned. Defaults to 1000. Set to 0 in order to return all matching DownloadItem. See search for how to page through results.
            abstract limit: float option with get, set
            /// Optional. Why a download was interrupted.
            abstract error: float option with get, set
            /// Optional. The time when the download ended in ISO 8601 format.
            abstract endTime: string option with get, set
            /// Optional. Whether the downloaded file exists;
            abstract exists: bool option with get, set

        type [<AllowNullLiteral>] DownloadFilenameSuggestion =
            /// The DownloadItem's new target DownloadItem.filename, as a path relative to the user's default Downloads directory, possibly containing subdirectories. Absolute paths, empty paths, and paths containing back-references ".." will be ignored.
            abstract filename: string with get, set
            /// Optional. The action to take if filename already exists.
            abstract conflictAction: string option with get, set

        type [<AllowNullLiteral>] DownloadChangedEvent =
            inherit Chrome.Events.Event<(DownloadDelta -> unit)>

        type [<AllowNullLiteral>] DownloadCreatedEvent =
            inherit Chrome.Events.Event<(DownloadItem -> unit)>

        type [<AllowNullLiteral>] DownloadErasedEvent =
            inherit Chrome.Events.Event<(float -> unit)>

        type [<AllowNullLiteral>] DownloadDeterminingFilenameEvent =
            inherit Chrome.Events.Event<(DownloadItem -> (DownloadFilenameSuggestion -> unit) -> unit)>

        type [<StringEnum>] [<RequireQualifiedAccess>] DownloadOptionsMethod =
            | [<CompiledName "GET">] GET
            | [<CompiledName "POST">] POST

        type [<RequireQualifiedAccess>] GetFileIconOptionsSize =
            | N16 = 16
            | N32 = 32

    module Enterprise =
        let [<Import("platformKeys","chrome/chrome/enterprise")>] platformKeys: PlatformKeys.IExports = jsNative
        let [<Import("deviceAttributes","chrome/chrome/enterprise")>] deviceAttributes: DeviceAttributes.IExports = jsNative
        let [<Import("networkingAttributes","chrome/chrome/enterprise")>] networkingAttributes: NetworkingAttributes.IExports = jsNative

        module PlatformKeys =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Returns the available Tokens. In a regular user's session the list will always contain the user's token with id "user". If a system-wide TPM token is available, the returned list will also contain the system-wide token with id "system". The system-wide token will be the same for all sessions on this device (device in the sense of e.g. a Chromebook).</summary>
                /// <param name="callback">Invoked by getTokens with the list of available Tokens.
                /// The callback parameter should be a function that looks like this:
                /// function(array of Token tokens) {...};
                /// Parameter tokens: The list of available tokens.</param>
                abstract getTokens: callback: (ResizeArray<Token> -> unit) -> unit
                /// <summary>Returns the list of all client certificates available from the given token. Can be used to check for the existence and expiration of client certificates that are usable for a certain authentication.</summary>
                /// <param name="tokenId">The id of a Token returned by getTokens.</param>
                /// <param name="callback">Called back with the list of the available certificates.
                /// The callback parameter should be a function that looks like this:
                /// function(array of ArrayBuffer certificates) {...};
                /// Parameter certificates: The list of certificates, each in DER encoding of a X.509 certificate.</param>
                abstract getCertificates: tokenId: string * callback: (ResizeArray<ArrayBuffer> -> unit) -> unit
                /// <summary>Imports certificate to the given token if the certified key is already stored in this token. After a successful certification request, this function should be used to store the obtained certificate and to make it available to the operating system and browser for authentication.</summary>
                /// <param name="tokenId">The id of a Token returned by getTokens.</param>
                /// <param name="certificate">The DER encoding of a X.509 certificate.</param>
                /// <param name="callback">Called back when this operation is finished.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract importCertificate: tokenId: string * certificate: ArrayBuffer * ?callback: (unit -> unit) -> unit
                /// <summary>Removes certificate from the given token if present. Should be used to remove obsolete certificates so that they are not considered during authentication and do not clutter the certificate choice. Should be used to free storage in the certificate store.</summary>
                /// <param name="tokenId">The id of a Token returned by getTokens.</param>
                /// <param name="certificate">The DER encoding of a X.509 certificate.</param>
                /// <param name="callback">Called back when this operation is finished.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract removeCertificate: tokenId: string * certificate: ArrayBuffer * ?callback: (unit -> unit) -> unit
                /// <summary>Challenges a hardware-backed Enterprise Machine Key and emits the response as part of a remote attestation protocol. Only useful on Chrome OS and in conjunction with the Verified Access Web API which both issues challenges and verifies responses. A successful verification by the Verified Access Web API is a strong signal of all of the following:
                /// 
                /// * The current device is a legitimate Chrome OS device.
                /// * The current device is managed by the domain specified during verification.
                /// * The current signed-in user is managed by the domain specified during verification.
                /// * The current device state complies with enterprise device policy. For example, a policy may specify that the device must not be in developer mode.
                /// * Any device identity emitted by the verification is tightly bound to the hardware of the current device.
                /// 
                /// This function is highly restricted and will fail if the current device is not managed, the current user is not managed, or if this operation has not explicitly been enabled for the caller by enterprise device policy. The Enterprise Machine Key does not reside in the "system" token and is not accessible by any other API.</summary>
                /// <param name="challenge">A challenge as emitted by the Verified Access Web API.</param>
                /// <param name="registerKey">If set, the current Enterprise Machine Key is registered with the "system" token and relinquishes the Enterprise Machine Key role. The key can then be associated with a certificate and used like any other signing key. This key is 2048-bit RSA. Subsequent calls to this function will then generate a new Enterprise Machine Key. Since Chrome 59.</param>
                /// <param name="callback">Called back with the challenge response.
                /// The callback parameter should be a function that looks like this:
                /// function(ArrayBuffer response) {...};</param>
                abstract challengeMachineKey: challenge: ArrayBuffer * registerKey: bool * callback: (ArrayBuffer -> unit) -> unit
                abstract challengeMachineKey: challenge: ArrayBuffer * callback: (ArrayBuffer -> unit) -> unit
                /// <summary>Challenges a hardware-backed Enterprise User Key and emits the response as part of a remote attestation protocol. Only useful on Chrome OS and in conjunction with the Verified Access Web API which both issues challenges and verifies responses. A successful verification by the Verified Access Web API is a strong signal of all of the following:
                /// 
                /// * The current device is a legitimate Chrome OS device.
                /// * The current device is managed by the domain specified during verification.
                /// * The current signed-in user is managed by the domain specified during verification.
                /// * The current device state complies with enterprise user policy. For example, a policy may specify that the device must not be in developer mode.
                /// * The public key emitted by the verification is tightly bound to the hardware of the current device and to the current signed-in user.
                /// 
                /// This function is highly restricted and will fail if the current device is not managed, the current user is not managed, or if this operation has not explicitly been enabled for the caller by enterprise user policy. The Enterprise User Key does not reside in the "user" token and is not accessible by any other API.</summary>
                /// <param name="challenge">A challenge as emitted by the Verified Access Web API.</param>
                /// <param name="registerKey">If set, the current Enterprise User Key is registered with the "user" token and relinquishes the Enterprise User Key role. The key can then be associated with a certificate and used like any other signing key. This key is 2048-bit RSA. Subsequent calls to this function will then generate a new Enterprise User Key.</param>
                /// <param name="callback">Called back with the challenge response.
                /// The callback parameter should be a function that looks like this:
                /// function(ArrayBuffer response) {...};</param>
                abstract challengeUserKey: challenge: ArrayBuffer * registerKey: bool * callback: (ArrayBuffer -> unit) -> unit

            type [<AllowNullLiteral>] Token =
                /// Uniquely identifies this Token.
                /// Static IDs are "user" and "system", referring to the platform's user-specific and the system-wide hardware token, respectively. Any other tokens (with other identifiers) might be returned by enterprise.platformKeys.getTokens.
                abstract id: string with get, set
                /// Implements the WebCrypto's SubtleCrypto interface. The cryptographic operations, including key generation, are hardware-backed.
                /// Only non-extractable RSASSA-PKCS1-V1_5 keys with modulusLength up to 2048 and ECDSA with namedCurve P-256 can be generated. Each key can be used for signing data at most once.
                /// Keys generated on a specific Token cannot be used with any other Tokens, nor can they be used with window.crypto.subtle. Equally, Key objects created with window.crypto.subtle cannot be used with this interface.
                // abstract subtleCrypto: SubtleCrypto with get, set
                // /// Implements the WebCrypto's SubtleCrypto interface. The cryptographic operations, including key generation, are software-backed.
                // /// Protection of the keys, and thus implementation of the non-extractable property, is done in software, so the keys are less protected than hardware-backed keys.
                // /// Only non-extractable RSASSA-PKCS1-V1_5 keys with modulusLength up to 2048 can be generated. Each key can be used for signing data at most once.
                // /// Keys generated on a specific Token cannot be used with any other Tokens, nor can they be used with window.crypto.subtle. Equally, Key objects created with window.crypto.subtle cannot be used with this interface.
                // abstract softwareBackedSubtleCrypto: SubtleCrypto with get, set

        module DeviceAttributes =

            type [<AllowNullLiteral>] IExports =
                /// <param name="callback">Called with the device identifier of the directory API when received.
                /// The callback parameter should be a function that looks like this:
                /// function(string deviceId) {...};</param>
                abstract getDirectoryDeviceId: callback: (string -> unit) -> unit
                /// <param name="callback">Called with the serial number of the device.</param>
                abstract getDeviceSerialNumber: callback: (string -> unit) -> unit
                /// <param name="callback">Called with the Asset ID of the device.</param>
                abstract getDeviceAssetId: callback: (string -> unit) -> unit
                /// <param name="callback">Called with the Annotated Location of the device.</param>
                abstract getDeviceAnnotatedLocation: callback: (string -> unit) -> unit
                /// <param name="callback">Called with the hostname of the device.</param>
                abstract getDeviceHostname: callback: (string -> unit) -> unit

        module NetworkingAttributes =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Retrieves the network details of the device's default network. If the user is not affiliated or the device is not connected to a network, runtime.lastError will be set with a failure reason.</summary>
                /// <param name="callback">Called with the device's default network's NetworkDetails.
                /// The callback parameter should be a function that looks like this:
                /// function(NetworkDetails networkAddresses) {...};</param>
                abstract getNetworkDetails: callback: (NetworkDetails -> unit) -> unit

            type [<AllowNullLiteral>] NetworkDetails =
                /// The device's MAC address.
                abstract macAddress: string with get, set
                /// Optional. The device's local IPv4 address (undefined if not configured).
                abstract ipv4: string option with get, set
                /// Optional. The device's local IPv6 address (undefined if not configured).
                abstract ipv6: string option with get, set

    module Events =

        /// Filters URLs for various criteria. See event filtering. All criteria are case sensitive.
        type [<AllowNullLiteral>] UrlFilter =
            /// Optional. Matches if the scheme of the URL is equal to any of the schemes specified in the array.
            abstract schemes: ResizeArray<string> option with get, set
            /// Optional.
            /// Since Chrome 23.
            /// Matches if the URL (without fragment identifier) matches a specified regular expression. Port numbers are stripped from the URL if they match the default port number. The regular expressions use the RE2 syntax.
            abstract urlMatches: string option with get, set
            /// Optional. Matches if the path segment of the URL contains a specified string.
            abstract pathContains: string option with get, set
            /// Optional. Matches if the host name of the URL ends with a specified string.
            abstract hostSuffix: string option with get, set
            /// Optional. Matches if the host name of the URL starts with a specified string.
            abstract hostPrefix: string option with get, set
            /// Optional. Matches if the host name of the URL contains a specified string. To test whether a host name component has a prefix 'foo', use hostContains: '.foo'. This matches 'www.foobar.com' and 'foo.com', because an implicit dot is added at the beginning of the host name. Similarly, hostContains can be used to match against component suffix ('foo.') and to exactly match against components ('.foo.'). Suffix- and exact-matching for the last components need to be done separately using hostSuffix, because no implicit dot is added at the end of the host name.
            abstract hostContains: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) contains a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlContains: string option with get, set
            /// Optional. Matches if the query segment of the URL ends with a specified string.
            abstract querySuffix: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) starts with a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlPrefix: string option with get, set
            /// Optional. Matches if the host name of the URL is equal to a specified string.
            abstract hostEquals: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) is equal to a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlEquals: string option with get, set
            /// Optional. Matches if the query segment of the URL contains a specified string.
            abstract queryContains: string option with get, set
            /// Optional. Matches if the path segment of the URL starts with a specified string.
            abstract pathPrefix: string option with get, set
            /// Optional. Matches if the path segment of the URL is equal to a specified string.
            abstract pathEquals: string option with get, set
            /// Optional. Matches if the path segment of the URL ends with a specified string.
            abstract pathSuffix: string option with get, set
            /// Optional. Matches if the query segment of the URL is equal to a specified string.
            abstract queryEquals: string option with get, set
            /// Optional. Matches if the query segment of the URL starts with a specified string.
            abstract queryPrefix: string option with get, set
            /// Optional. Matches if the URL (without fragment identifier) ends with a specified string. Port numbers are stripped from the URL if they match the default port number.
            abstract urlSuffix: string option with get, set
            /// Optional. Matches if the port of the URL is contained in any of the specified port lists. For example [80, 443, [1000, 1200]] matches all requests on port 80, 443 and in the range 1000-1200.
            abstract ports: ResizeArray<U2<float, ResizeArray<float>>> option with get, set
            /// Optional.
            /// Since Chrome 28.
            /// Matches if the URL without query segment and fragment identifier matches a specified regular expression. Port numbers are stripped from the URL if they match the default port number. The regular expressions use the RE2 syntax.
            abstract originAndPathMatches: string option with get, set

        type [<AllowNullLiteral>] BaseEvent<'T> =
            abstract addListener: callback: 'T * ?filter: WebRequest.RequestFilter -> unit
            /// <summary>Returns currently registered rules.</summary>
            /// <param name="callback">Called with registered rules.
            /// The callback parameter should be a function that looks like this:
            /// function(array of Rule rules) {...};
            /// Parameter rules: Rules that were registered, the optional parameters are filled with values.</param>
            abstract getRules: callback: (ResizeArray<Rule> -> unit) -> unit
            /// <summary>Returns currently registered rules.</summary>
            /// <param name="ruleIdentifiers">If an array is passed, only rules with identifiers contained in this array are returned.</param>
            /// <param name="callback">Called with registered rules.
            /// The callback parameter should be a function that looks like this:
            /// function(array of Rule rules) {...};
            /// Parameter rules: Rules that were registered, the optional parameters are filled with values.</param>
            abstract getRules: ruleIdentifiers: ResizeArray<string> * callback: (ResizeArray<Rule> -> unit) -> unit
            /// <param name="callback">Listener whose registration status shall be tested.</param>
            abstract hasListener: callback: 'T -> bool
            /// <summary>Unregisters currently registered rules.</summary>
            /// <param name="ruleIdentifiers">If an array is passed, only rules with identifiers contained in this array are unregistered.</param>
            /// <param name="callback">Called when rules were unregistered.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeRules: ?ruleIdentifiers: ResizeArray<string> * ?callback: (unit -> unit) -> unit
            /// <summary>Unregisters currently registered rules.</summary>
            /// <param name="callback">Called when rules were unregistered.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeRules: ?callback: (unit -> unit) -> unit
            /// <summary>Registers rules to handle events.</summary>
            /// <param name="rules">Rules to be registered. These do not replace previously registered rules.</param>
            /// <param name="callback">Called with registered rules.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of Rule rules) {...};
            /// Parameter rules: Rules that were registered, the optional parameters are filled with values.</param>
            abstract addRules: rules: ResizeArray<Rule> * ?callback: (ResizeArray<Rule> -> unit) -> unit
            /// <summary>Deregisters an event listener callback from an event.</summary>
            /// <param name="callback">Listener that shall be unregistered.
            /// The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract removeListener: callback: 'T -> unit
            abstract hasListeners: unit -> bool

        /// An object which allows the addition and removal of listeners for a Chrome event.
        type [<AllowNullLiteral>] Event<'T> =
            inherit BaseEvent<'T>
            /// <summary>Registers an event listener callback to an event.</summary>
            /// <param name="callback">Called when an event occurs. The parameters of this function depend on the type of event.
            /// The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract addListener: callback: 'T -> unit

        type [<AllowNullLiteral>] EventWithRequiredFilterInAddListener<'T> =
            inherit BaseEvent<'T>
            abstract addListener: callback: 'T * filter: WebRequest.RequestFilter -> unit

        /// Description of a declarative rule for handling events.
        type [<AllowNullLiteral>] Rule =
            /// Optional. Optional priority of this rule. Defaults to 100.
            abstract priority: float option with get, set
            /// List of conditions that can trigger the actions.
            abstract conditions: ResizeArray<obj option> with get, set
            /// Optional. Optional identifier that allows referencing this rule.
            abstract id: string option with get, set
            /// List of actions that are triggered if one of the condtions is fulfilled.
            abstract actions: ResizeArray<obj option> with get, set
            /// Optional.
            /// Since Chrome 28.
            /// Tags can be used to annotate rules and perform operations on sets of rules.
            abstract tags: ResizeArray<string> option with get, set

    module Extension =

        type [<AllowNullLiteral>] IExports =
            abstract inIncognitoContext: bool
            abstract lastError: LastError
            /// Returns the JavaScript 'window' object for the background page running inside the current extension. Returns null if the extension has no background page.
            abstract getBackgroundPage: unit -> Window option
            /// <summary>Converts a relative path within an extension install directory to a fully-qualified URL.</summary>
            /// <param name="path">A path to a resource within an extension expressed relative to its install directory.</param>
            abstract getURL: path: string -> string
            /// Sets the value of the ap CGI parameter used in the extension's update URL. This value is ignored for extensions that are hosted in the Chrome Extension Gallery.
            /// Since Chrome 9.
            abstract setUpdateUrlData: data: string -> unit
            /// Returns an array of the JavaScript 'window' objects for each of the pages running inside the current extension.
            abstract getViews: ?fetchProperties: FetchProperties -> ResizeArray<Window>
            /// Retrieves the state of the extension's access to the 'file://' scheme (as determined by the user-controlled 'Allow access to File URLs' checkbox.
            /// Since Chrome 12.
            abstract isAllowedFileSchemeAccess: unit -> Promise<bool>
            /// <summary>Retrieves the state of the extension's access to the 'file://' scheme (as determined by the user-controlled 'Allow access to File URLs' checkbox.
            /// Since Chrome 12.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean isAllowedAccess) {...};
            /// Parameter isAllowedAccess: True if the extension can access the 'file://' scheme, false otherwise.</param>
            abstract isAllowedFileSchemeAccess: callback: (bool -> unit) -> unit
            /// Retrieves the state of the extension's access to Incognito-mode (as determined by the user-controlled 'Allowed in Incognito' checkbox.
            /// Since Chrome 12.
            abstract isAllowedIncognitoAccess: unit -> Promise<bool>
            /// <summary>Retrieves the state of the extension's access to Incognito-mode (as determined by the user-controlled 'Allowed in Incognito' checkbox.
            /// Since Chrome 12.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean isAllowedAccess) {...};
            /// Parameter isAllowedAccess: True if the extension has access to Incognito mode, false otherwise.</param>
            abstract isAllowedIncognitoAccess: callback: (bool -> unit) -> unit
            /// <summary>Sends a single request to other listeners within the extension. Similar to runtime.connect, but only sends a single request with an optional response. The extension.onRequest event is fired in each page of the extension.</summary>
            /// <param name="extensionId">The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
            /// <param name="responseCallback">If you specify the responseCallback parameter, it should be a function that looks like this:
            /// function(any response) {...};
            /// Parameter response: The JSON response object sent by the handler of the request. If an error occurs while connecting to the extension, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendRequest: extensionId: string * request: 'Request * ?responseCallback: ('Response -> unit) -> unit
            /// <summary>Sends a single request to other listeners within the extension. Similar to runtime.connect, but only sends a single request with an optional response. The extension.onRequest event is fired in each page of the extension.</summary>
            /// <param name="responseCallback">If you specify the responseCallback parameter, it should be a function that looks like this:
            /// function(any response) {...};
            /// Parameter response: The JSON response object sent by the handler of the request. If an error occurs while connecting to the extension, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendRequest: request: 'Request * ?responseCallback: ('Response -> unit) -> unit
            /// Returns an array of the JavaScript 'window' objects for each of the tabs running inside the current extension. If windowId is specified, returns only the 'window' objects of tabs attached to the specified window.
            abstract getExtensionTabs: ?windowId: float -> ResizeArray<Window>
            abstract onRequest: OnRequestEvent
            abstract onRequestExternal: OnRequestEvent

        type [<AllowNullLiteral>] FetchProperties =
            /// Optional.
            /// Chrome 54+
            /// Find a view according to a tab id. If this field is omitted, returns all views.
            abstract tabId: float option with get, set
            /// Optional. The window to restrict the search to. If omitted, returns all views.
            abstract windowId: float option with get, set
            /// Optional. The type of view to get. If omitted, returns all views (including background pages and tabs). Valid values: 'tab', 'notification', 'popup'.
            abstract ``type``: string option with get, set

        type [<AllowNullLiteral>] LastError =
            /// Description of the error that has taken place.
            abstract message: string with get, set

        type [<AllowNullLiteral>] OnRequestEvent =
            inherit Chrome.Events.Event<U2<(obj option -> Runtime.MessageSender -> (obj option -> unit) -> unit), (Runtime.MessageSender -> (obj option -> unit) -> unit)>>

    module FileBrowserHandler =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Prompts user to select file path under which file should be saved. When the file is selected, file access permission required to use the file (read, write and create) are granted to the caller. The file will not actually get created during the function call, so function caller must ensure its existence before using it. The function has to be invoked with a user gesture.
            /// Since Chrome 21.</summary>
            /// <param name="selectionParams">Parameters that will be used while selecting the file.</param>
            /// <param name="callback">Function called upon completion.
            /// The callback parameter should be a function that looks like this:
            /// function(object result) {...};
            /// Parameter result: Result of the method.</param>
            abstract selectFile: selectionParams: SelectionParams * callback: (SelectionResult -> unit) -> unit
            abstract onExecute: FileBrowserHandlerExecuteEvent

        type [<AllowNullLiteral>] SelectionParams =
            /// Optional.
            /// List of file extensions that the selected file can have. The list is also used to specify what files to be shown in the select file dialog. Files with the listed extensions are only shown in the dialog. Extensions should not include the leading '.'. Example: ['jpg', 'png']
            /// Since Chrome 23.
            abstract allowedFileExtensions: ResizeArray<string> option with get, set
            /// Suggested name for the file.
            abstract suggestedName: string with get, set

        type [<AllowNullLiteral>] SelectionResult =
            /// Optional. Selected file entry. It will be null if a file hasn't been selected.
            abstract entry: Object option with get, set
            /// Whether the file has been selected.
            abstract success: bool with get, set

        /// Event details payload for fileBrowserHandler.onExecute event.
        type [<AllowNullLiteral>] FileHandlerExecuteEventDetails =
            /// Optional. The ID of the tab that raised this event. Tab IDs are unique within a browser session.
            abstract tab_id: float option with get, set
            /// Array of Entry instances representing files that are targets of this action (selected in ChromeOS file browser).
            abstract entries: ResizeArray<obj option> with get, set

        type [<AllowNullLiteral>] FileBrowserHandlerExecuteEvent =
            inherit Chrome.Events.Event<(string -> FileHandlerExecuteEventDetails -> unit)>

    module FileSystemProvider =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Mounts a file system with the given fileSystemId and displayName. displayName will be shown in the left panel of Files.app. displayName can contain any characters including '/', but cannot be an empty string. displayName must be descriptive but doesn't have to be unique. The fileSystemId must not be an empty string.
            /// Depending on the type of the file system being mounted, the source option must be set appropriately.
            /// In case of an error, runtime.lastError will be set with a corresponding error code.</summary>
            /// <param name="callback">A generic result callback to indicate success or failure.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract mount: options: MountOptions * ?callback: (unit -> unit) -> unit
            /// <summary>Unmounts a file system with the given fileSystemId. It must be called after onUnmountRequested is invoked. Also, the providing extension can decide to perform unmounting if not requested (eg. in case of lost connection, or a file error).
            /// In case of an error, runtime.lastError will be set with a corresponding error code.</summary>
            /// <param name="callback">A generic result callback to indicate success or failure.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract unmount: options: UnmountOptions * ?callback: (unit -> unit) -> unit
            /// <summary>Returns all file systems mounted by the extension.</summary>
            /// <param name="callback">Callback to receive the result of getAll function.
            /// The callback parameter should be a function that looks like this:
            /// function(array of FileSystemInfo fileSystems) {...};</param>
            abstract getAll: callback: (ResizeArray<FileSystemInfo> -> unit) -> unit
            /// <summary>Returns information about a file system with the passed fileSystemId.</summary>
            /// <param name="callback">Callback to receive the result of get function.
            /// The callback parameter should be a function that looks like this:
            /// function(FileSystemInfo fileSystem) {...};</param>
            abstract get: fileSystemId: string * callback: (FileSystemInfo -> unit) -> unit
            /// <summary>Notifies about changes in the watched directory at observedPath in recursive mode. If the file system is mounted with supportsNofityTag, then tag must be provided, and all changes since the last notification always reported, even if the system was shutdown. The last tag can be obtained with getAll.
            /// To use, the file_system_provider.notify manifest option must be set to true.
            /// Value of tag can be any string which is unique per call, so it's possible to identify the last registered notification. Eg. if the providing extension starts after a reboot, and the last registered notification's tag is equal to "123", then it should call notify for all changes which happened since the change tagged as "123". It cannot be an empty string.
            /// Not all providers are able to provide a tag, but if the file system has a changelog, then the tag can be eg. a change number, or a revision number.
            /// Note that if a parent directory is removed, then all descendant entries are also removed, and if they are watched, then the API must be notified about the fact. Also, if a directory is renamed, then all descendant entries are in fact removed, as there is no entry under their original paths anymore.
            /// In case of an error, runtime.lastError will be set will a corresponding error code.</summary>
            /// <param name="callback">A generic result callback to indicate success or failure.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract notify: options: NotificationOptions * callback: (unit -> unit) -> unit
            abstract onUnmountRequested: RequestedEvent
            abstract onGetMetadataRequested: MetadataRequestedEvent
            abstract onReadDirectoryRequested: DirectoryPathRequestedEvent
            abstract onOpenFileRequested: OpenFileRequestedEvent
            abstract onCloseFileRequested: OpenedFileRequestedEvent
            abstract onReadFileRequested: OpenedFileOffsetRequestedEvent
            abstract onCreateDirectoryRequested: DirectoryPathRecursiveRequestedEvent
            abstract onDeleteEntryRequested: EntryPathRecursiveRequestedEvent
            abstract onCreateFileRequested: FilePathRequestedEvent
            abstract onCopyEntryRequested: SourceTargetPathRequestedEvent
            abstract onMoveEntryRequested: SourceTargetPathRequestedEvent
            abstract onTruncateRequested: FilePathLengthRequestedEvent
            abstract onWriteFileRequested: OpenedFileIoRequestedEvent
            abstract onAbortRequested: OperationRequestedEvent
            abstract onConfigureRequested: RequestedEvent
            abstract onMountRequested: OptionlessRequestedEvent
            abstract onAddWatcherRequested: EntryPathRecursiveRequestedEvent
            abstract onRemoveWatcherRequested: EntryPathRecursiveRequestedEvent

        type [<AllowNullLiteral>] OpenedFileInfo =
            /// A request ID to be be used by consecutive read/write and close requests.
            abstract openRequestId: float with get, set
            /// The path of the opened file.
            abstract filePath: string with get, set
            /// Whether the file was opened for reading or writing.
            abstract mode: string with get, set

        type [<AllowNullLiteral>] FileWatchersInfo =
            /// The path of the entry being observed.
            abstract entryPath: string with get, set
            /// Whether watching should include all child entries recursively. It can be true for directories only.
            abstract recursive: bool with get, set
            /// Optional. Tag used by the last notification for the watcher.
            abstract lastTag: string option with get, set

        type [<AllowNullLiteral>] EntryMetadata =
            /// True if it is a directory.
            abstract isDirectory: bool with get, set
            /// Name of this entry (not full path name). Must not contain '/'. For root it must be empty.
            abstract name: string with get, set
            /// File size in bytes.
            abstract size: float with get, set
            /// The last modified time of this entry.
            abstract modificationTime: DateTime with get, set
            /// Optional. Mime type for the entry.
            abstract mimeType: string option with get, set
            /// Optional. Thumbnail image as a data URI in either PNG, JPEG or WEBP format, at most 32 KB in size. Optional, but can be provided only when explicitly requested by the onGetMetadataRequested event.
            abstract thumbnail: string option with get, set

        type [<AllowNullLiteral>] FileSystemInfo =
            /// The identifier of the file system.
            abstract fileSystemId: string with get, set
            /// A human-readable name for the file system.
            abstract displayName: string with get, set
            /// Whether the file system supports operations which may change contents of the file system (such as creating, deleting or writing to files).
            abstract writable: bool with get, set
            /// The maximum number of files that can be opened at once. If 0, then not limited.
            abstract openedFilesLimit: float with get, set
            /// List of currently opened files.
            abstract openedFiles: ResizeArray<OpenedFileInfo> with get, set
            /// Optional.
            /// Whether the file system supports the tag field for observing directories.
            abstract supportsNotifyTag: bool option with get, set
            /// List of watchers.
            abstract watchers: ResizeArray<FileWatchersInfo> with get, set

        type [<AllowNullLiteral>] GetActionsRequestedOptions =
            /// The identifier of the file system related to this operation.
            abstract fileSystemId: string with get, set
            /// The unique identifier of this request.
            abstract requestId: float with get, set
            /// The path of the entry to return the list of actions for.
            abstract entryPath: string with get, set

        type [<AllowNullLiteral>] Action =
            /// The identifier of the action. Any string or CommonActionId for common actions.
            abstract id: string with get, set
            /// Optional. The title of the action. It may be ignored for common actions.
            abstract title: string option with get, set

        type [<AllowNullLiteral>] ExecuteActionRequestedOptions =
            /// The identifier of the file system related to this operation.
            abstract fileSystemId: string with get, set
            /// The unique identifier of this request.
            abstract requestId: float with get, set
            /// The path of the entry to be used for the action.
            abstract entryPath: string with get, set
            /// The identifier of the action to be executed.
            abstract actionId: string with get, set

        type [<AllowNullLiteral>] MountOptions =
            /// The string indentifier of the file system. Must be unique per each extension.
            abstract fileSystemId: string with get, set
            /// A human-readable name for the file system.
            abstract displayName: string with get, set
            /// Optional. Whether the file system supports operations which may change contents of the file system (such as creating, deleting or writing to files).
            abstract writable: bool option with get, set
            /// Optional.
            /// The maximum number of files that can be opened at once. If not specified, or 0, then not limited.
            abstract openedFilesLimit: float option with get, set
            /// Optional.
            /// Whether the file system supports the tag field for observed directories.
            abstract supportsNotifyTag: bool option with get, set

        type [<AllowNullLiteral>] UnmountOptions =
            /// The identifier of the file system to be unmounted.
            abstract fileSystemId: string with get, set

        type [<AllowNullLiteral>] NotificationChange =
            /// The path of the changed entry.
            abstract entryPath: string with get, set
            /// The type of the change which happened to the entry.
            abstract changeType: string with get, set

        type [<AllowNullLiteral>] NotificationOptions =
            /// The identifier of the file system related to this change.
            abstract fileSystemId: string with get, set
            /// The path of the observed entry.
            abstract observedPath: string with get, set
            /// Mode of the observed entry.
            abstract recursive: bool with get, set
            /// The type of the change which happened to the observed entry. If it is DELETED, then the observed entry will be automatically removed from the list of observed entries.
            abstract changeType: string with get, set
            /// Optional. List of changes to entries within the observed directory (including the entry itself)
            abstract changes: ResizeArray<NotificationChange> option with get, set
            /// Optional. Tag for the notification. Required if the file system was mounted with the supportsNotifyTag option. Note, that this flag is necessary to provide notifications about changes which changed even when the system was shutdown.
            abstract tag: string option with get, set

        type [<AllowNullLiteral>] RequestedEventOptions =
            /// The identifier of the file system related to this operation.
            abstract fileSystemId: string with get, set
            /// The unique identifier of this request.
            abstract requestId: float with get, set

        type [<AllowNullLiteral>] EntryPathRequestedEventOptions =
            inherit RequestedEventOptions
            /// The path of the entry to which this operation is related to.
            abstract entryPath: string with get, set

        type [<AllowNullLiteral>] MetadataRequestedEventOptions =
            inherit EntryPathRequestedEventOptions
            /// Set to true if the thumbnail is requested.
            abstract thumbnail: bool with get, set

        type [<AllowNullLiteral>] DirectoryPathRequestedEventOptions =
            inherit RequestedEventOptions
            /// The path of the directory which is to be operated on.
            abstract directoryPath: string with get, set

        type [<AllowNullLiteral>] FilePathRequestedEventOptions =
            inherit RequestedEventOptions
            /// The path of the entry for the operation
            abstract filePath: string with get, set

        type [<AllowNullLiteral>] OpenFileRequestedEventOptions =
            inherit FilePathRequestedEventOptions
            /// Whether the file will be used for reading or writing.
            abstract mode: string with get, set

        type [<AllowNullLiteral>] OpenedFileRequestedEventOptions =
            inherit RequestedEventOptions
            /// A request ID used to open the file.
            abstract openRequestId: float with get, set

        type [<AllowNullLiteral>] OpenedFileOffsetRequestedEventOptions =
            inherit OpenedFileRequestedEventOptions
            /// Position in the file (in bytes) to start reading from.
            abstract offset: float with get, set
            /// Number of bytes to be returned.
            abstract length: float with get, set

        type [<AllowNullLiteral>] DirectoryPathRecursiveRequestedEventOptions =
            inherit DirectoryPathRequestedEventOptions
            /// Whether the operation is recursive (for directories only).
            abstract recursive: bool with get, set

        type [<AllowNullLiteral>] EntryPathRecursiveRequestedEventOptions =
            inherit EntryPathRequestedEventOptions
            /// Whether the operation is recursive (for directories only).
            abstract recursive: bool with get, set

        type [<AllowNullLiteral>] SourceTargetPathRequestedEventOptions =
            inherit RequestedEventOptions
            /// The source path for the operation.
            abstract sourcePath: string with get, set
            /// The destination path for the operation.
            abstract targetPath: string with get, set

        type [<AllowNullLiteral>] FilePathLengthRequestedEventOptions =
            inherit FilePathRequestedEventOptions
            /// Number of bytes to be retained after the operation completes.
            abstract length: float with get, set

        type [<AllowNullLiteral>] OpenedFileIoRequestedEventOptions =
            inherit OpenedFileRequestedEventOptions
            /// Position in the file (in bytes) to start operating from.
            abstract offset: float with get, set
            /// Buffer of bytes to be operated on the file.
            abstract data: ArrayBuffer with get, set

        type [<AllowNullLiteral>] OperationRequestedEventOptions =
            inherit RequestedEventOptions
            /// An ID of the request to which this operation is related.
            abstract operationRequestId: float with get, set

        type [<AllowNullLiteral>] RequestedEvent =
            inherit Chrome.Events.Event<(RequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] MetadataRequestedEvent =
            inherit Chrome.Events.Event<(MetadataRequestedEventOptions -> (EntryMetadata -> unit) -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] DirectoryPathRequestedEvent =
            inherit Chrome.Events.Event<(DirectoryPathRequestedEventOptions -> (ResizeArray<EntryMetadata> -> bool -> unit) -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OpenFileRequestedEvent =
            inherit Chrome.Events.Event<(OpenFileRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OpenedFileRequestedEvent =
            inherit Chrome.Events.Event<(OpenedFileRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OpenedFileOffsetRequestedEvent =
            inherit Chrome.Events.Event<(OpenedFileOffsetRequestedEventOptions -> (ArrayBuffer -> bool -> unit) -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] DirectoryPathRecursiveRequestedEvent =
            inherit Chrome.Events.Event<(DirectoryPathRecursiveRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] EntryPathRecursiveRequestedEvent =
            inherit Chrome.Events.Event<(EntryPathRecursiveRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] FilePathRequestedEvent =
            inherit Chrome.Events.Event<(FilePathRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] SourceTargetPathRequestedEvent =
            inherit Chrome.Events.Event<(SourceTargetPathRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] FilePathLengthRequestedEvent =
            inherit Chrome.Events.Event<(FilePathLengthRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OpenedFileIoRequestedEvent =
            inherit Chrome.Events.Event<(OpenedFileIoRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OperationRequestedEvent =
            inherit Chrome.Events.Event<(OperationRequestedEventOptions -> Function -> (string -> unit) -> unit)>

        type [<AllowNullLiteral>] OptionlessRequestedEvent =
            inherit Chrome.Events.Event<(Function -> (string -> unit) -> unit)>

    module FontSettings =

        type [<AllowNullLiteral>] IExports =
            /// Sets the default font size.
            abstract setDefaultFontSize: details: DefaultFontSizeDetails -> Promise<unit>
            /// <summary>Sets the default font size.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setDefaultFontSize: details: DefaultFontSizeDetails * ?callback: Function -> unit
            /// Gets the font for a given script and generic font family.
            abstract getFont: details: FontDetails -> Promise<FontDetailsResult>
            /// <summary>Gets the font for a given script and generic font family.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract getFont: details: FontDetails * ?callback: (FontDetailsResult -> unit) -> unit
            /// <summary>Gets the default font size.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract getDefaultFontSize: ?details: Object -> Promise<FontSizeDetails>
            /// <summary>Gets the default font size.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract getDefaultFontSize: ?details: Object * ?callback: (FontSizeDetails -> unit) -> unit
            /// <summary>Gets the minimum font size.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract getMinimumFontSize: ?details: obj -> Promise<FontSizeDetails>
            /// <summary>Gets the minimum font size.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract getMinimumFontSize: ?details: obj * ?callback: (FontSizeDetails -> unit) -> unit
            /// Sets the minimum font size.
            abstract setMinimumFontSize: details: SetFontSizeDetails -> Promise<unit>
            /// <summary>Sets the minimum font size.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setMinimumFontSize: details: SetFontSizeDetails * ?callback: Function -> unit
            /// <summary>Gets the default size for fixed width fonts.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract getDefaultFixedFontSize: ?details: Object -> Promise<FontSizeDetails>
            /// <summary>Gets the default size for fixed width fonts.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract getDefaultFixedFontSize: ?details: Object * ?callback: (FontSizeDetails -> unit) -> unit
            /// <summary>Clears the default font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract clearDefaultFontSize: ?details: Object -> Promise<unit>
            /// <summary>Clears the default font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract clearDefaultFontSize: ?details: Object * ?callback: Function -> unit
            /// Sets the default size for fixed width fonts.
            abstract setDefaultFixedFontSize: details: SetFontSizeDetails -> Promise<unit>
            /// <summary>Sets the default size for fixed width fonts.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setDefaultFixedFontSize: details: SetFontSizeDetails * ?callback: Function -> unit
            /// Clears the font set by this extension, if any.
            abstract clearFont: details: FontDetails -> Promise<unit>
            /// <summary>Clears the font set by this extension, if any.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract clearFont: details: FontDetails * ?callback: Function -> unit
            /// Sets the font for a given script and generic font family.
            abstract setFont: details: SetFontDetails -> Promise<unit>
            /// <summary>Sets the font for a given script and generic font family.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(object details) {...};</param>
            abstract setFont: details: SetFontDetails * ?callback: Function -> unit
            /// <summary>Clears the minimum font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract clearMinimumFontSize: ?details: Object -> Promise<unit>
            /// <summary>Clears the minimum font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract clearMinimumFontSize: ?details: Object * ?callback: Function -> unit
            /// Gets a list of fonts on the system.
            abstract getFontList: unit -> Promise<ResizeArray<FontName>>
            /// <summary>Gets a list of fonts on the system.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of FontName results) {...};</param>
            abstract getFontList: ?callback: (ResizeArray<FontName> -> unit) -> unit
            /// <summary>Clears the default fixed font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            abstract clearDefaultFixedFontSize: details: Object -> Promise<unit>
            /// <summary>Clears the default fixed font size set by this extension, if any.</summary>
            /// <param name="details">This parameter is currently unused.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract clearDefaultFixedFontSize: details: Object * ?callback: Function -> unit
            abstract onDefaultFixedFontSizeChanged: DefaultFixedFontSizeChangedEvent
            abstract onDefaultFontSizeChanged: DefaultFontSizeChangedEvent
            abstract onMinimumFontSizeChanged: MinimumFontSizeChangedEvent
            abstract onFontChanged: FontChangedEvent

        /// Represents a font name.
        type [<AllowNullLiteral>] FontName =
            /// The display name of the font.
            abstract displayName: string with get, set
            /// The font ID.
            abstract fontId: string with get, set

        type [<AllowNullLiteral>] DefaultFontSizeDetails =
            /// The font size in pixels.
            abstract pixelSize: float with get, set

        type [<AllowNullLiteral>] FontDetails =
            /// The generic font family for the font.
            abstract genericFamily: FontDetailsGenericFamily with get, set
            /// Optional. The script for the font. If omitted, the global script font setting is affected.
            abstract script: string option with get, set

        type [<AllowNullLiteral>] FullFontDetails =
            /// The generic font family for which the font setting has changed.
            abstract genericFamily: string with get, set
            /// The level of control this extension has over the setting.
            abstract levelOfControl: string with get, set
            /// Optional. The script code for which the font setting has changed.
            abstract script: string option with get, set
            /// The font ID. See the description in getFont.
            abstract fontId: string with get, set

        type [<AllowNullLiteral>] FontDetailsResult =
            /// The level of control this extension has over the setting.
            abstract levelOfControl: string with get, set
            /// The font ID. Rather than the literal font ID preference value, this may be the ID of the font that the system resolves the preference value to. So, fontId can differ from the font passed to setFont, if, for example, the font is not available on the system. The empty string signifies fallback to the global script font setting.
            abstract fontId: string with get, set

        type [<AllowNullLiteral>] FontSizeDetails =
            /// The font size in pixels.
            abstract pixelSize: float with get, set
            /// The level of control this extension has over the setting.
            abstract levelOfControl: string with get, set

        type [<AllowNullLiteral>] SetFontSizeDetails =
            /// The font size in pixels.
            abstract pixelSize: float with get, set

        type [<AllowNullLiteral>] SetFontDetails =
            inherit FontDetails
            /// The font ID. The empty string means to fallback to the global script font setting.
            abstract fontId: string with get, set

        type [<AllowNullLiteral>] DefaultFixedFontSizeChangedEvent =
            inherit Chrome.Events.Event<(FontSizeDetails -> unit)>

        type [<AllowNullLiteral>] DefaultFontSizeChangedEvent =
            inherit Chrome.Events.Event<(FontSizeDetails -> unit)>

        type [<AllowNullLiteral>] MinimumFontSizeChangedEvent =
            inherit Chrome.Events.Event<(FontSizeDetails -> unit)>

        type [<AllowNullLiteral>] FontChangedEvent =
            inherit Chrome.Events.Event<(FullFontDetails -> unit)>

        type [<StringEnum>] [<RequireQualifiedAccess>] FontDetailsGenericFamily =
            | Cursive
            | Fantasy
            | Fixed
            | Sansserif
            | Serif
            | Standard

    module Gcm =

        type [<AllowNullLiteral>] IExports =
            abstract MAX_MESSAGE_SIZE: float
            /// <summary>Registers the application with GCM. The registration ID will be returned by the callback. If register is called again with the same list of senderIds, the same registration ID will be returned.</summary>
            /// <param name="senderIds">A list of server IDs that are allowed to send messages to the application. It should contain at least one and no more than 100 sender IDs.</param>
            /// <param name="callback">Function called when registration completes. It should check runtime.lastError for error when registrationId is empty.
            /// The callback parameter should be a function that looks like this:
            /// function(string registrationId) {...};
            /// Parameter registrationId: A registration ID assigned to the application by the GCM.</param>
            abstract register: senderIds: ResizeArray<string> * callback: (string -> unit) -> unit
            /// <summary>Unregisters the application from GCM.</summary>
            /// <param name="callback">A function called after the unregistration completes. Unregistration was successful if runtime.lastError is not set.
            /// The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract unregister: callback: (unit -> unit) -> unit
            /// <summary>Sends a message according to its contents.</summary>
            /// <param name="message">A message to send to the other party via GCM.</param>
            /// <param name="callback">A function called after the message is successfully queued for sending. runtime.lastError should be checked, to ensure a message was sent without problems.
            /// The callback parameter should be a function that looks like this:
            /// function(string messageId) {...};
            /// Parameter messageId: The ID of the message that the callback was issued for.</param>
            abstract send: message: OutgoingMessage * callback: (string -> unit) -> unit
            abstract onMessage: MessageReceptionEvent
            abstract onMessagesDeleted: MessageDeletionEvent
            abstract onSendError: GcmErrorEvent

        type [<AllowNullLiteral>] OutgoingMessage =
            /// The ID of the server to send the message to as assigned by Google API Console.
            abstract destinationId: string with get, set
            /// The ID of the message. It must be unique for each message in scope of the applications. See the Cloud Messaging documentation for advice for picking and handling an ID.
            abstract messageId: string with get, set
            /// Optional. Time-to-live of the message in seconds. If it is not possible to send the message within that time, an onSendError event will be raised. A time-to-live of 0 indicates that the message should be sent immediately or fail if it's not possible. The maximum and a default value of time-to-live is 86400 seconds (1 day).
            abstract timeToLive: float option with get, set
            /// Message data to send to the server. Case-insensitive goog. and google, as well as case-sensitive collapse_key are disallowed as key prefixes. Sum of all key/value pairs should not exceed gcm.MAX_MESSAGE_SIZE.
            abstract data: Object with get, set

        type [<AllowNullLiteral>] IncomingMessage =
            /// The message data.
            abstract data: Object with get, set
            /// Optional.
            /// The sender who issued the message.
            abstract from: string option with get, set
            /// Optional.
            /// The collapse key of a message. See Collapsible Messages section of Cloud Messaging documentation for details.
            abstract collapseKey: string option with get, set

        type [<AllowNullLiteral>] GcmError =
            /// The error message describing the problem.
            abstract errorMessage: string with get, set
            /// Optional. The ID of the message with this error, if error is related to a specific message.
            abstract messageId: string option with get, set
            /// Additional details related to the error, when available.
            abstract detail: Object with get, set

        type [<AllowNullLiteral>] MessageReceptionEvent =
            inherit Chrome.Events.Event<(IncomingMessage -> unit)>

        type [<AllowNullLiteral>] MessageDeletionEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] GcmErrorEvent =
            inherit Chrome.Events.Event<(GcmError -> unit)>

    module History =

        type [<AllowNullLiteral>] IExports =
            /// Searches the history for the last visit time of each page matching the query.
            abstract search: query: HistoryQuery -> Promise<ResizeArray<HistoryItem>>
            /// <summary>Searches the history for the last visit time of each page matching the query.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of HistoryItem results) {...};</param>
            abstract search: query: HistoryQuery * ?callback: (ResizeArray<HistoryItem> -> unit) -> unit
            /// Adds a URL to the history at the current time with a transition type of "link".
            abstract addUrl: details: Url -> Promise<unit>
            /// <summary>Adds a URL to the history at the current time with a transition type of "link".</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract addUrl: details: Url * ?callback: (unit -> unit) -> unit
            /// Removes all items within the specified date range from the history. Pages will not be removed from the history unless all visits fall within the range.
            abstract deleteRange: range: Range -> Promise<unit>
            /// <summary>Removes all items within the specified date range from the history. Pages will not be removed from the history unless all visits fall within the range.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract deleteRange: range: Range * ?callback: (unit -> unit) -> unit
            /// Deletes all items from the history.
            abstract deleteAll: unit -> Promise<unit>
            /// <summary>Deletes all items from the history.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract deleteAll: callback: (unit -> unit) -> unit
            /// Retrieves information about visits to a URL.
            abstract getVisits: details: Url -> Promise<ResizeArray<VisitItem>>
            /// <summary>Retrieves information about visits to a URL.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of VisitItem results) {...};</param>
            abstract getVisits: details: Url * callback: (ResizeArray<VisitItem> -> unit) -> unit
            /// Removes all occurrences of the given URL from the history.
            abstract deleteUrl: details: Url -> Promise<unit>
            /// <summary>Removes all occurrences of the given URL from the history.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract deleteUrl: details: Url * ?callback: (unit -> unit) -> unit
            abstract onVisited: HistoryVisitedEvent
            abstract onVisitRemoved: HistoryVisitRemovedEvent

        /// An object encapsulating one visit to a URL.
        type [<AllowNullLiteral>] VisitItem =
            /// The transition type for this visit from its referrer.
            abstract transition: string with get, set
            /// Optional. When this visit occurred, represented in milliseconds since the epoch.
            abstract visitTime: float option with get, set
            /// The unique identifier for this visit.
            abstract visitId: string with get, set
            /// The visit ID of the referrer.
            abstract referringVisitId: string with get, set
            /// The unique identifier for the item.
            abstract id: string with get, set

        /// An object encapsulating one result of a history query.
        type [<AllowNullLiteral>] HistoryItem =
            /// Optional. The number of times the user has navigated to this page by typing in the address.
            abstract typedCount: float option with get, set
            /// Optional. The title of the page when it was last loaded.
            abstract title: string option with get, set
            /// Optional. The URL navigated to by a user.
            abstract url: string option with get, set
            /// Optional. When this page was last loaded, represented in milliseconds since the epoch.
            abstract lastVisitTime: float option with get, set
            /// Optional. The number of times the user has navigated to this page.
            abstract visitCount: float option with get, set
            /// The unique identifier for the item.
            abstract id: string with get, set

        type [<AllowNullLiteral>] HistoryQuery =
            /// A free-text query to the history service. Leave empty to retrieve all pages.
            abstract text: string with get, set
            /// Optional. The maximum number of results to retrieve. Defaults to 100.
            abstract maxResults: float option with get, set
            /// Optional. Limit results to those visited after this date, represented in milliseconds since the epoch.
            abstract startTime: float option with get, set
            /// Optional. Limit results to those visited before this date, represented in milliseconds since the epoch.
            abstract endTime: float option with get, set

        type [<AllowNullLiteral>] Url =
            /// The URL for the operation. It must be in the format as returned from a call to history.search.
            abstract url: string with get, set

        type [<AllowNullLiteral>] Range =
            /// Items added to history before this date, represented in milliseconds since the epoch.
            abstract endTime: float with get, set
            /// Items added to history after this date, represented in milliseconds since the epoch.
            abstract startTime: float with get, set

        type [<AllowNullLiteral>] RemovedResult =
            /// True if all history was removed. If true, then urls will be empty.
            abstract allHistory: bool with get, set
            /// Optional.
            abstract urls: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] HistoryVisitedEvent =
            inherit Chrome.Events.Event<(HistoryItem -> unit)>

        type [<AllowNullLiteral>] HistoryVisitRemovedEvent =
            inherit Chrome.Events.Event<(RemovedResult -> unit)>

    module I18n =

        type [<AllowNullLiteral>] IExports =
            /// Gets the accept-languages of the browser. This is different from the locale used by the browser; to get the locale, use i18n.getUILanguage.
            abstract getAcceptLanguages: unit -> Promise<ResizeArray<string>>
            /// <summary>Gets the accept-languages of the browser. This is different from the locale used by the browser; to get the locale, use i18n.getUILanguage.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of string languages) {...};
            /// Parameter languages: Array of the accept languages of the browser, such as en-US,en,zh-CN</param>
            abstract getAcceptLanguages: callback: (ResizeArray<string> -> unit) -> unit
            /// <summary>Gets the localized string for the specified message. If the message is missing, this method returns an empty string (''). If the format of the getMessage() call is wrong — for example, messageName is not a string or the substitutions array has more than 9 elements — this method returns undefined.</summary>
            /// <param name="messageName">The name of the message, as specified in the messages.json file.</param>
            /// <param name="substitutions">Optional. Up to 9 substitution strings, if the message requires any.</param>
            abstract getMessage: messageName: string * ?substitutions: U2<string, ResizeArray<string>> -> string
            /// Gets the browser UI language of the browser. This is different from i18n.getAcceptLanguages which returns the preferred user languages.
            abstract getUILanguage: unit -> string
            /// <summary>Detects the language of the provided text using CLD.</summary>
            /// <param name="text">User input string to be translated.</param>
            abstract detectLanguage: text: string -> Promise<LanguageDetectionResult>
            /// <summary>Detects the language of the provided text using CLD.</summary>
            /// <param name="text">User input string to be translated.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this: function(object result) {...};</param>
            abstract detectLanguage: text: string * callback: (LanguageDetectionResult -> unit) -> unit

        /// Holds detected ISO language code and its percentage in the input string
        type [<AllowNullLiteral>] DetectedLanguage =
            /// An ISO language code such as 'en' or 'fr'.
            /// For a complete list of languages supported by this method, see  [kLanguageInfoTable]{@link https://src.chromium.org/viewvc/chrome/trunk/src/third_party/cld/languages/internal/languages.cc}.
            /// For an unknown language, 'und' will be returned, which means that [percentage] of the text is unknown to CLD
            abstract language: string with get, set
            /// The percentage of the detected language
            abstract percentage: float with get, set

        /// Holds detected language reliability and array of DetectedLanguage
        type [<AllowNullLiteral>] LanguageDetectionResult =
            /// CLD detected language reliability
            abstract isReliable: bool with get, set
            /// Array of detectedLanguage
            abstract languages: ResizeArray<DetectedLanguage> with get, set

    module Identity =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Resets the state of the Identity API:
            /// 
            ///   * Removes all OAuth2 access tokens from the token cache
            ///   * Removes user's account preferences
            ///   * De-authorizes the user from all auth flows</summary>
            /// <param name="callback">Called when the state has been cleared.
            /// The parameter should be a function that looks like this:
            /// () => {...};</param>
            abstract clearAllCachedAuthTokens: callback: (unit -> unit) -> unit
            /// Retrieves a list of AccountInfo objects describing the accounts present on the profile.
            /// getAccounts is only supported on dev channel.
            /// Dev channel only.
            abstract getAccounts: callback: (ResizeArray<AccountInfo> -> unit) -> unit
            /// <summary>Gets an OAuth2 access token using the client ID and scopes specified in the oauth2 section of manifest.json.
            /// The Identity API caches access tokens in memory, so it's ok to call getAuthToken non-interactively any time a token is required. The token cache automatically handles expiration.
            /// For a good user experience it is important interactive token requests are initiated by UI in your app explaining what the authorization is for. Failing to do this will cause your users to get authorization requests, or Chrome sign in screens if they are not signed in, with with no context. In particular, do not use getAuthToken interactively when your app is first launched.</summary>
            /// <param name="details">Token options.</param>
            /// <param name="callback">Called with an OAuth2 access token as specified by the manifest, or undefined if there was an error.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(string token) {...};</param>
            abstract getAuthToken: details: TokenDetails * ?callback: (string -> unit) -> unit
            /// Retrieves email address and obfuscated gaia id of the user signed into a profile.
            /// This API is different from identity.getAccounts in two ways. The information returned is available offline, and it only applies to the primary account for the profile.
            abstract getProfileUserInfo: callback: (UserInfo -> unit) -> unit
            abstract getProfileUserInfo: details: ProfileDetails * callback: (UserInfo -> unit) -> unit
            /// <summary>Removes an OAuth2 access token from the Identity API's token cache.
            /// If an access token is discovered to be invalid, it should be passed to removeCachedAuthToken to remove it from the cache. The app may then retrieve a fresh token with getAuthToken.</summary>
            /// <param name="details">Token information.</param>
            /// <param name="callback">Called when the token has been removed from the cache.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract removeCachedAuthToken: details: TokenInformation * ?callback: (unit -> unit) -> unit
            /// <summary>Starts an auth flow at the specified URL.
            /// This method enables auth flows with non-Google identity providers by launching a web view and navigating it to the first URL in the provider's auth flow. When the provider redirects to a URL matching the pattern https://<app-id>.chromiumapp.org/*, the window will close, and the final redirect URL will be passed to the callback function.
            /// For a good user experience it is important interactive auth flows are initiated by UI in your app explaining what the authorization is for. Failing to do this will cause your users to get authorization requests with no context. In particular, do not launch an interactive auth flow when your app is first launched.</summary>
            /// <param name="details">WebAuth flow options.</param>
            /// <param name="callback">Called with the URL redirected back to your application.
            /// The callback parameter should be a function that looks like this:
            /// function(string responseUrl) {...};</param>
            abstract launchWebAuthFlow: details: WebAuthFlowOptions * callback: (string -> unit) -> unit
            /// <summary>Generates a redirect URL to be used in launchWebAuthFlow.
            /// The generated URLs match the pattern https://<app-id>.chromiumapp.org/*.</summary>
            /// <param name="path">Optional. The path appended to the end of the generated URL.</param>
            abstract getRedirectURL: ?path: string -> string
            abstract onSignInChanged: SignInChangeEvent

        type [<AllowNullLiteral>] AccountInfo =
            /// A unique identifier for the account. This ID will not change for the lifetime of the account.
            abstract id: string with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] AccountStatus =
            | [<CompiledName "SYNC">] SYNC
            | [<CompiledName "ANY">] ANY

        type [<AllowNullLiteral>] ProfileDetails =
            /// Optional.
            /// A status of the primary account signed into a profile whose ProfileUserInfo should be returned. Defaults to SYNC account status.
            abstract accountStatus: AccountStatus option with get, set

        type [<AllowNullLiteral>] TokenDetails =
            /// Optional.
            /// Fetching a token may require the user to sign-in to Chrome, or approve the application's requested scopes. If the interactive flag is true, getAuthToken will prompt the user as necessary. When the flag is false or omitted, getAuthToken will return failure any time a prompt would be required.
            abstract interactive: bool option with get, set
            /// Optional.
            /// The account ID whose token should be returned. If not specified, the primary account for the profile will be used.
            /// account is only supported when the "enable-new-profile-management" flag is set.
            abstract account: AccountInfo option with get, set
            /// Optional.
            /// A list of OAuth2 scopes to request.
            /// When the scopes field is present, it overrides the list of scopes specified in manifest.json.
            abstract scopes: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] UserInfo =
            /// An email address for the user account signed into the current profile. Empty if the user is not signed in or the identity.email manifest permission is not specified.
            abstract email: string with get, set
            /// A unique identifier for the account. This ID will not change for the lifetime of the account. Empty if the user is not signed in or (in M41+) the identity.email manifest permission is not specified.
            abstract id: string with get, set

        type [<AllowNullLiteral>] TokenInformation =
            /// The specific token that should be removed from the cache.
            abstract token: string with get, set

        type [<AllowNullLiteral>] WebAuthFlowOptions =
            /// The URL that initiates the auth flow.
            abstract url: string with get, set
            /// Optional.
            /// Whether to launch auth flow in interactive mode.
            /// Since some auth flows may immediately redirect to a result URL, launchWebAuthFlow hides its web view until the first navigation either redirects to the final URL, or finishes loading a page meant to be displayed.
            /// If the interactive flag is true, the window will be displayed when a page load completes. If the flag is false or omitted, launchWebAuthFlow will return with an error if the initial navigation does not complete the flow.
            abstract interactive: bool option with get, set

        type [<AllowNullLiteral>] SignInChangeEvent =
            inherit Chrome.Events.Event<(AccountInfo -> bool -> unit)>

    module Idle =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Returns "locked" if the system is locked, "idle" if the user has not generated any input for a specified number of seconds, or "active" otherwise.</summary>
            /// <param name="detectionIntervalInSeconds">The system is considered idle if detectionIntervalInSeconds seconds have elapsed since the last user input detected.
            /// Since Chrome 25.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( IdleState newState) {...};</param>
            abstract queryState: detectionIntervalInSeconds: float * callback: (IdleState -> unit) -> unit
            /// <summary>Sets the interval, in seconds, used to determine when the system is in an idle state for onStateChanged events. The default interval is 60 seconds.</summary>
            /// <param name="intervalInSeconds">Threshold, in seconds, used to determine when the system is in an idle state.</param>
            abstract setDetectionInterval: intervalInSeconds: float -> unit
            /// <summary>Gets the time, in seconds, it takes until the screen is locked automatically while idle. Returns a zero duration if the screen is never locked automatically. Currently supported on Chrome OS only.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(integer delay) {...};
            /// Parameter delay: Time, in seconds, until the screen is locked automatically while idle. This is zero if the screen never locks automatically.</param>
            abstract getAutoLockDelay: callback: (float -> unit) -> unit
            abstract onStateChanged: IdleStateChangedEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] IdleState =
            | Active
            | Idle
            | Locked

        type [<AllowNullLiteral>] IdleStateChangedEvent =
            inherit Chrome.Events.Event<(IdleState -> unit)>

    module Input =
        let [<Import("ime","chrome/chrome/input")>] ime: Ime.IExports = jsNative

        module Ime =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Adds the provided menu items to the language menu when this IME is active.</summary>
                /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setMenuItems: parameters: ImeParameters * ?callback: (unit -> unit) -> unit
                /// <summary>Commits the provided text to the current input.</summary>
                /// <param name="callback">Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.runtime.lastError is set.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract commitText: parameters: CommitTextParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Sets the current candidate list. This fails if this extension doesn't own the active IME</summary>
                /// <param name="callback">Called when the operation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract setCandidates: parameters: CandidatesParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Set the current composition. If this extension does not own the active IME, this fails.</summary>
                /// <param name="callback">Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.runtime.lastError is set.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract setComposition: parameters: CompositionParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Updates the state of the MenuItems specified</summary>
                /// <param name="callback">Called when the operation completes
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract updateMenuItems: parameters: MenuItemParameters * ?callback: (unit -> unit) -> unit
                /// <summary>Shows/Hides an assistive window with the given properties.</summary>
                /// <param name="callback">Called when the operation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract setAssistiveWindowProperties: parameters: SetAssistiveWindowPropertiesParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Highlights/Unhighlights a button in an assistive window.</summary>
                /// <param name="callback">Called when the operation completes. On failure, chrome.runtime.lastError is set.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract setAssistiveWindowButtonHighlighted: parameters: SetAssistiveWindowButtonHighlightedParameters * ?callback: (unit -> unit) -> unit
                /// <summary>Sets the properties of the candidate window. This fails if the extension doesn't own the active IME</summary>
                /// <param name="callback">Called when the operation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract setCandidateWindowProperties: parameters: CandidateWindowParameter * ?callback: (bool -> unit) -> unit
                /// <summary>Clear the current composition. If this extension does not own the active IME, this fails.</summary>
                /// <param name="callback">Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.runtime.lastError is set.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract clearComposition: parameters: ClearCompositionParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Set the position of the cursor in the candidate window. This is a no-op if this extension does not own the active IME.</summary>
                /// <param name="callback">Called when the operation completes
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function(boolean success) {...};</param>
                abstract setCursorPosition: parameters: CursorPositionParameters * ?callback: (bool -> unit) -> unit
                /// <summary>Sends the key events. This function is expected to be used by virtual keyboards. When key(s) on a virtual keyboard is pressed by a user, this function is used to propagate that event to the system.</summary>
                /// <param name="callback">Called when the operation completes.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract sendKeyEvents: parameters: SendKeyEventParameters * ?callback: (unit -> unit) -> unit
                /// Hides the input view window, which is popped up automatically by system. If the input view window is already hidden, this function will do nothing.
                abstract hideInputView: unit -> unit
                /// Deletes the text around the caret.
                abstract deleteSurroundingText: parameters: DeleteSurroundingTextParameters * ?callback: (unit -> unit) -> unit
                /// <summary>Indicates that the key event received by onKeyEvent is handled. This should only be called if the onKeyEvent listener is asynchronous.</summary>
                /// <param name="requestId">Request id of the event that was handled. This should come from keyEvent.requestId</param>
                /// <param name="response">True if the keystroke was handled, false if not</param>
                abstract keyEventHandled: requestId: string * response: bool -> unit
                abstract onBlur: BlurEvent
                abstract onAssistiveWindowButtonClicked: AssistiveWindowButtonClickedEvent
                abstract onCandidateClicked: CandidateClickedEvent
                abstract onKeyEvent: KeyEventEvent
                abstract onDeactivated: DeactivatedEvent
                abstract onInputContextUpdate: InputContextUpdateEvent
                abstract onActivate: ActivateEvent
                abstract onFocus: FocusEvent
                abstract onMenuItemActivated: MenuItemActivatedEvent
                abstract onSurroundingTextChanged: SurroundingTextChangedEvent
                abstract onReset: InputResetEvent

            type [<AllowNullLiteral>] SetAssistiveWindowPropertiesParameters =
                abstract contextID: float with get, set
                abstract properties: Chrome.Input.Ime.AssistiveWindowProperties with get, set

            type [<AllowNullLiteral>] SetAssistiveWindowButtonHighlightedParameters =
                abstract contextID: float with get, set
                abstract buttonID: Chrome.Input.Ime.AssistiveWindowButton with get, set
                abstract windowType: Chrome.Input.Ime.AssistiveWindowType with get, set
                abstract announceString: string option with get, set
                abstract highlighted: bool with get, set

            /// See http://www.w3.org/TR/DOM-Level-3-Events/#events-KeyboardEvent
            type [<AllowNullLiteral>] KeyboardEvent =
                /// Optional.
                /// Whether or not the SHIFT key is pressed.
                abstract shiftKey: bool option with get, set
                /// Optional.
                /// Whether or not the ALT key is pressed.
                abstract altKey: bool option with get, set
                /// Optional.
                /// Whether or not the ALTGR key is pressed.
                abstract altgrKey: bool option with get, set
                /// Optional.
                /// The ID of the request.
                abstract requestId: string option with get, set
                /// Value of the key being pressed
                abstract key: string with get, set
                /// Optional.
                /// Whether or not the CTRL key is pressed.
                abstract ctrlKey: bool option with get, set
                /// One of keyup or keydown.
                abstract ``type``: string with get, set
                /// Optional.
                /// The extension ID of the sender of this keyevent.
                abstract extensionId: string option with get, set
                /// Optional.
                /// Value of the physical key being pressed. The value is not affected by current keyboard layout or modifier state.
                abstract code: string with get, set
                /// Optional.
                /// The deprecated HTML keyCode, which is system- and implementation-dependent numerical code signifying the unmodified identifier associated with the key pressed.
                abstract keyCode: float option with get, set
                /// Optional.
                /// Whether or not the CAPS_LOCK is enabled.
                abstract capsLock: bool option with get, set

            /// Describes an input Context
            type [<AllowNullLiteral>] InputContext =
                /// This is used to specify targets of text field operations. This ID becomes invalid as soon as onBlur is called.
                abstract contextID: float with get, set
                /// Type of value this text field edits, (Text, Number, URL, etc)
                abstract ``type``: string with get, set
                /// Whether the text field wants auto-correct.
                abstract autoCorrect: bool with get, set
                /// Whether the text field wants auto-complete.
                abstract autoComplete: bool with get, set
                /// Whether the text field wants spell-check.
                abstract spellCheck: bool with get, set

            /// A menu item used by an input method to interact with the user from the language menu.
            type [<AllowNullLiteral>] MenuItem =
                /// String that will be passed to callbacks referencing this MenuItem.
                abstract id: string with get, set
                /// Optional. Text displayed in the menu for this item.
                abstract label: string option with get, set
                /// Optional. The type of menu item.
                abstract style: string option with get, set
                /// Optional. Indicates this item is visible.
                abstract visible: bool option with get, set
                /// Indicates this item should be drawn with a check.
                abstract ``checked``: bool option with get, set
                /// Indicates this item is enabled.
                abstract enabled: bool option with get, set

            type [<AllowNullLiteral>] ImeParameters =
                /// MenuItems to use.
                abstract items: ResizeArray<MenuItem> with get, set
                /// ID of the engine to use
                abstract engineID: string with get, set

            type [<AllowNullLiteral>] CommitTextParameters =
                /// The text to commit
                abstract text: string with get, set
                /// ID of the context where the text will be committed
                abstract contextID: float with get, set

            type [<AllowNullLiteral>] CandidateUsage =
                /// The title string of details description.
                abstract title: string with get, set
                /// The body string of detail description.
                abstract body: string with get, set

            type [<AllowNullLiteral>] CandidateTemplate =
                /// The candidate
                abstract candidate: string with get, set
                /// The candidate's id
                abstract id: float with get, set
                /// Optional.
                /// The id to add these candidates under
                abstract parentId: float option with get, set
                /// Optional.
                /// Short string displayed to next to the candidate, often the shortcut key or index
                abstract label: string option with get, set
                /// Optional.
                /// Additional text describing the candidate
                abstract annotation: string option with get, set
                /// Optional.
                /// The usage or detail description of word.
                abstract usage: CandidateUsage option with get, set

            type [<AllowNullLiteral>] CandidatesParameters =
                /// ID of the context that owns the candidate window.
                abstract contextID: float with get, set
                /// List of candidates to show in the candidate window
                abstract candidates: ResizeArray<CandidateTemplate> with get, set

            type [<AllowNullLiteral>] CompositionParameterSegment =
                /// Index of the character to start this segment at
                abstract start: float with get, set
                /// Index of the character to end this segment after.
                abstract ``end``: float with get, set
                /// The type of the underline to modify this segment.
                abstract style: string with get, set

            type [<AllowNullLiteral>] CompositionParameters =
                /// ID of the context where the composition text will be set
                abstract contextID: float with get, set
                /// Text to set
                abstract text: string with get, set
                /// Optional. List of segments and their associated types.
                abstract segments: ResizeArray<CompositionParameterSegment> option with get, set
                /// Position in the text of the cursor.
                abstract cursor: float with get, set
                /// Optional. Position in the text that the selection starts at.
                abstract selectionStart: float option with get, set
                /// Optional. Position in the text that the selection ends at.
                abstract selectionEnd: float option with get, set

            type [<AllowNullLiteral>] MenuItemParameters =
                abstract items: ResizeArray<Object> with get, set
                abstract engineId: string with get, set

            type AssistiveWindowType =
                string

            type [<StringEnum>] [<RequireQualifiedAccess>] AssistiveWindowButton =
                | Undo
                | AddToDictionary

            /// Properties of an assistive window.
            type [<AllowNullLiteral>] AssistiveWindowProperties =
                abstract ``type``: AssistiveWindowType with get, set
                abstract visible: bool with get, set
                abstract announceString: string option with get, set

            type [<AllowNullLiteral>] CandidateWindowParameterProperties =
                /// Optional.
                /// True to show the cursor, false to hide it.
                abstract cursorVisible: bool option with get, set
                /// Optional.
                /// True if the candidate window should be rendered vertical, false to make it horizontal.
                abstract vertical: bool option with get, set
                /// Optional.
                /// The number of candidates to display per page.
                abstract pageSize: float option with get, set
                /// Optional.
                /// True to display the auxiliary text, false to hide it.
                abstract auxiliaryTextVisible: bool option with get, set
                /// Optional.
                /// Text that is shown at the bottom of the candidate window.
                abstract auxiliaryText: string option with get, set
                /// Optional.
                /// True to show the Candidate window, false to hide it.
                abstract visible: bool option with get, set
                /// Optional.
                /// Where to display the candidate window.
                abstract windowPosition: string option with get, set

            type [<AllowNullLiteral>] CandidateWindowParameter =
                /// ID of the engine to set properties on.
                abstract engineID: string with get, set
                abstract properties: CandidateWindowParameterProperties with get, set

            type [<AllowNullLiteral>] ClearCompositionParameters =
                /// ID of the context where the composition will be cleared
                abstract contextID: float with get, set

            type [<AllowNullLiteral>] CursorPositionParameters =
                /// ID of the candidate to select.
                abstract candidateID: float with get, set
                /// ID of the context that owns the candidate window.
                abstract contextID: float with get, set

            type [<AllowNullLiteral>] SendKeyEventParameters =
                /// ID of the context where the key events will be sent, or zero to send key events to non-input field.
                abstract contextID: float with get, set
                /// Data on the key event.
                abstract keyData: ResizeArray<KeyboardEvent> with get, set

            type [<AllowNullLiteral>] DeleteSurroundingTextParameters =
                /// ID of the engine receiving the event.
                abstract engineID: string with get, set
                /// ID of the context where the surrounding text will be deleted.
                abstract contextID: float with get, set
                /// The offset from the caret position where deletion will start. This value can be negative.
                abstract offset: float with get, set
                /// The number of characters to be deleted
                abstract length: float with get, set

            type [<AllowNullLiteral>] SurroundingTextInfo =
                /// The text around cursor.
                abstract text: string with get, set
                /// The ending position of the selection. This value indicates caret position if there is no selection.
                abstract focus: float with get, set
                /// The beginning position of the selection. This value indicates caret position if is no selection.
                abstract anchor: float with get, set

            type [<AllowNullLiteral>] AssistiveWindowButtonClickedDetails =
                /// The ID of the button clicked.
                abstract buttonID: AssistiveWindowButton with get, set
                /// The type of the assistive window.
                abstract windowType: AssistiveWindowType with get, set

            type [<AllowNullLiteral>] BlurEvent =
                inherit Chrome.Events.Event<(float -> unit)>

            type [<AllowNullLiteral>] AssistiveWindowButtonClickedEvent =
                inherit Chrome.Events.Event<(AssistiveWindowButtonClickedDetails -> unit)>

            type [<AllowNullLiteral>] CandidateClickedEvent =
                inherit Chrome.Events.Event<(string -> float -> string -> unit)>

            type [<AllowNullLiteral>] KeyEventEvent =
                inherit Chrome.Events.Event<(string -> KeyboardEvent -> unit)>

            type [<AllowNullLiteral>] DeactivatedEvent =
                inherit Chrome.Events.Event<(string -> unit)>

            type [<AllowNullLiteral>] InputContextUpdateEvent =
                inherit Chrome.Events.Event<(InputContext -> unit)>

            type [<AllowNullLiteral>] ActivateEvent =
                inherit Chrome.Events.Event<(string -> string -> unit)>

            type [<AllowNullLiteral>] FocusEvent =
                inherit Chrome.Events.Event<(InputContext -> unit)>

            type [<AllowNullLiteral>] MenuItemActivatedEvent =
                inherit Chrome.Events.Event<(string -> string -> unit)>

            type [<AllowNullLiteral>] SurroundingTextChangedEvent =
                inherit Chrome.Events.Event<(string -> SurroundingTextInfo -> unit)>

            type [<AllowNullLiteral>] InputResetEvent =
                inherit Chrome.Events.Event<(string -> unit)>

    module LoginState =

        type [<AllowNullLiteral>] IExports =
            /// Gets the type of the profile the extension is in.
            abstract getProfileType: callback: (ProfileType -> unit) -> unit
            /// Gets the current session state.
            abstract getSessionState: callback: (SessionState -> unit) -> unit
            abstract onSessionStateChanged: SessionStateChangedEvent

        type [<AllowNullLiteral>] SessionStateChangedEvent =
            inherit Chrome.Events.Event<(SessionState -> unit)>

        type [<StringEnum>] [<RequireQualifiedAccess>] ProfileType =
            | [<CompiledName "SIGNIN_PROFILE">] SIGNIN_PROFILE
            | [<CompiledName "USER_PROFILE">] USER_PROFILE

        type [<StringEnum>] [<RequireQualifiedAccess>] SessionState =
            | [<CompiledName "UNKNOWN">] UNKNOWN
            | [<CompiledName "IN_OOBE_SCREEN">] IN_OOBE_SCREEN
            | [<CompiledName "IN_LOGIN_SCREEN">] IN_LOGIN_SCREEN
            | [<CompiledName "IN_SESSION">] IN_SESSION
            | [<CompiledName "IN_LOCK_SCREEN">] IN_LOCK_SCREEN

    module Management =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Enables or disables an app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            /// <param name="enabled">Whether this item should be enabled or disabled.</param>
            abstract setEnabled: id: string * enabled: bool -> Promise<unit>
            /// <summary>Enables or disables an app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            /// <param name="enabled">Whether this item should be enabled or disabled.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setEnabled: id: string * enabled: bool * ?callback: (unit -> unit) -> unit
            /// <summary>Returns a list of permission warnings for the given extension id.</summary>
            /// <param name="id">The ID of an already installed extension.</param>
            abstract getPermissionWarningsById: id: string -> Promise<ResizeArray<string>>
            /// <summary>Returns a list of permission warnings for the given extension id.</summary>
            /// <param name="id">The ID of an already installed extension.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of string permissionWarnings) {...};</param>
            abstract getPermissionWarningsById: id: string * ?callback: (ResizeArray<string> -> unit) -> unit
            /// <summary>Returns information about the installed extension, app, or theme that has the given ID.</summary>
            /// <param name="id">The ID from an item of management.ExtensionInfo.</param>
            abstract get: id: string -> Promise<ExtensionInfo>
            /// <summary>Returns information about the installed extension, app, or theme that has the given ID.</summary>
            /// <param name="id">The ID from an item of management.ExtensionInfo.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( ExtensionInfo result) {...};</param>
            abstract get: id: string * ?callback: (ExtensionInfo -> unit) -> unit
            /// Returns a list of information about installed extensions and apps.
            abstract getAll: unit -> Promise<ResizeArray<ExtensionInfo>>
            /// <summary>Returns a list of information about installed extensions and apps.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of ExtensionInfo result) {...};</param>
            abstract getAll: ?callback: (ResizeArray<ExtensionInfo> -> unit) -> unit
            /// <summary>Returns a list of permission warnings for the given extension manifest string. Note: This function can be used without requesting the 'management' permission in the manifest.</summary>
            /// <param name="manifestStr">Extension manifest JSON string.</param>
            abstract getPermissionWarningsByManifest: manifestStr: string -> Promise<ResizeArray<string>>
            /// <summary>Returns a list of permission warnings for the given extension manifest string. Note: This function can be used without requesting the 'management' permission in the manifest.</summary>
            /// <param name="manifestStr">Extension manifest JSON string.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(array of string permissionWarnings) {...};</param>
            abstract getPermissionWarningsByManifest: manifestStr: string * ?callback: (ResizeArray<string> -> unit) -> unit
            /// <summary>Launches an application.</summary>
            /// <param name="id">The extension id of the application.</param>
            abstract launchApp: id: string -> Promise<unit>
            /// <summary>Launches an application.</summary>
            /// <param name="id">The extension id of the application.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract launchApp: id: string * ?callback: (unit -> unit) -> unit
            /// <summary>Uninstalls a currently installed app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            abstract uninstall: id: string * ?options: UninstallOptions -> Promise<unit>
            /// <summary>Uninstalls a currently installed app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract uninstall: id: string * ?options: UninstallOptions * ?callback: (unit -> unit) -> unit
            /// <summary>Uninstalls a currently installed app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            abstract uninstall: id: string -> Promise<unit>
            /// <summary>Uninstalls a currently installed app or extension.</summary>
            /// <param name="id">This should be the id from an item of management.ExtensionInfo.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract uninstall: id: string * ?callback: (unit -> unit) -> unit
            /// Returns information about the calling extension, app, or theme. Note: This function can be used without requesting the 'management' permission in the manifest.
            abstract getSelf: unit -> Promise<ExtensionInfo>
            /// <summary>Returns information about the calling extension, app, or theme. Note: This function can be used without requesting the 'management' permission in the manifest.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( ExtensionInfo result) {...};</param>
            abstract getSelf: ?callback: (ExtensionInfo -> unit) -> unit
            /// Uninstalls the calling extension.
            /// Note: This function can be used without requesting the 'management' permission in the manifest.
            abstract uninstallSelf: ?options: UninstallOptions -> Promise<unit>
            /// <summary>Uninstalls the calling extension.
            /// Note: This function can be used without requesting the 'management' permission in the manifest.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract uninstallSelf: ?options: UninstallOptions * ?callback: (unit -> unit) -> unit
            /// Uninstalls the calling extension.
            /// Note: This function can be used without requesting the 'management' permission in the manifest.
            abstract uninstallSelf: unit -> Promise<unit>
            /// <summary>Uninstalls the calling extension.
            /// Note: This function can be used without requesting the 'management' permission in the manifest.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract uninstallSelf: ?callback: (unit -> unit) -> unit
            /// Display options to create shortcuts for an app. On Mac, only packaged app shortcuts can be created.
            abstract createAppShortcut: id: string -> Promise<unit>
            /// <summary>Display options to create shortcuts for an app. On Mac, only packaged app shortcuts can be created.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract createAppShortcut: id: string * ?callback: (unit -> unit) -> unit
            /// <summary>Set the launch type of an app.</summary>
            /// <param name="id">This should be the id from an app item of management.ExtensionInfo.</param>
            /// <param name="launchType">The target launch type. Always check and make sure this launch type is in ExtensionInfo.availableLaunchTypes, because the available launch types vary on different platforms and configurations.</param>
            abstract setLaunchType: id: string * launchType: string -> Promise<unit>
            /// <summary>Set the launch type of an app.</summary>
            /// <param name="id">This should be the id from an app item of management.ExtensionInfo.</param>
            /// <param name="launchType">The target launch type. Always check and make sure this launch type is in ExtensionInfo.availableLaunchTypes, because the available launch types vary on different platforms and configurations.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setLaunchType: id: string * launchType: string * ?callback: (unit -> unit) -> unit
            /// <summary>Generate an app for a URL. Returns the generated bookmark app.</summary>
            /// <param name="url">The URL of a web page. The scheme of the URL can only be "http" or "https".</param>
            /// <param name="title">The title of the generated app.</param>
            abstract generateAppForLink: url: string * title: string -> Promise<ExtensionInfo>
            /// <summary>Generate an app for a URL. Returns the generated bookmark app.</summary>
            /// <param name="url">The URL of a web page. The scheme of the URL can only be "http" or "https".</param>
            /// <param name="title">The title of the generated app.</param>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function( ExtensionInfo result) {...};</param>
            abstract generateAppForLink: url: string * title: string * ?callback: (ExtensionInfo -> unit) -> unit
            abstract onDisabled: ManagementDisabledEvent
            abstract onUninstalled: ManagementUninstalledEvent
            abstract onInstalled: ManagementInstalledEvent
            abstract onEnabled: ManagementEnabledEvent

        /// Information about an installed extension, app, or theme.
        type [<AllowNullLiteral>] ExtensionInfo =
            /// Optional.
            /// A reason the item is disabled.
            abstract disabledReason: string option with get, set
            /// Optional. The launch url (only present for apps).
            abstract appLaunchUrl: string option with get, set
            /// The description of this extension, app, or theme.
            abstract description: string with get, set
            /// Returns a list of API based permissions.
            abstract permissions: ResizeArray<string> with get, set
            /// Optional.
            /// A list of icon information. Note that this just reflects what was declared in the manifest, and the actual image at that url may be larger or smaller than what was declared, so you might consider using explicit width and height attributes on img tags referencing these images. See the manifest documentation on icons for more details.
            abstract icons: ResizeArray<IconInfo> option with get, set
            /// Returns a list of host based permissions.
            abstract hostPermissions: ResizeArray<string> with get, set
            /// Whether it is currently enabled or disabled.
            abstract enabled: bool with get, set
            /// Optional.
            /// The URL of the homepage of this extension, app, or theme.
            abstract homepageUrl: string option with get, set
            /// Whether this extension can be disabled or uninstalled by the user.
            abstract mayDisable: bool with get, set
            /// How the extension was installed.
            abstract installType: string with get, set
            /// The version of this extension, app, or theme.
            abstract version: string with get, set
            /// The extension's unique identifier.
            abstract id: string with get, set
            /// Whether the extension, app, or theme declares that it supports offline.
            abstract offlineEnabled: bool with get, set
            /// Optional.
            /// The update URL of this extension, app, or theme.
            abstract updateUrl: string option with get, set
            /// The type of this extension, app, or theme.
            abstract ``type``: string with get, set
            /// The url for the item's options page, if it has one.
            abstract optionsUrl: string with get, set
            /// The name of this extension, app, or theme.
            abstract name: string with get, set
            /// A short version of the name of this extension, app, or theme.
            abstract shortName: string with get, set
            /// True if this is an app.
            abstract isApp: bool with get, set
            /// Optional.
            /// The app launch type (only present for apps).
            abstract launchType: string option with get, set
            /// Optional.
            /// The currently available launch types (only present for apps).
            abstract availableLaunchTypes: ResizeArray<string> option with get, set

        /// Information about an icon belonging to an extension, app, or theme.
        type [<AllowNullLiteral>] IconInfo =
            /// The URL for this icon image. To display a grayscale version of the icon (to indicate that an extension is disabled, for example), append ?grayscale=true to the URL.
            abstract url: string with get, set
            /// A number representing the width and height of the icon. Likely values include (but are not limited to) 128, 48, 24, and 16.
            abstract size: float with get, set

        type [<AllowNullLiteral>] UninstallOptions =
            /// Optional.
            /// Whether or not a confirm-uninstall dialog should prompt the user. Defaults to false for self uninstalls. If an extension uninstalls another extension, this parameter is ignored and the dialog is always shown.
            abstract showConfirmDialog: bool option with get, set

        type [<AllowNullLiteral>] ManagementDisabledEvent =
            inherit Chrome.Events.Event<(ExtensionInfo -> unit)>

        type [<AllowNullLiteral>] ManagementUninstalledEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] ManagementInstalledEvent =
            inherit Chrome.Events.Event<(ExtensionInfo -> unit)>

        type [<AllowNullLiteral>] ManagementEnabledEvent =
            inherit Chrome.Events.Event<(ExtensionInfo -> unit)>

    module Networking =
        let [<Import("config","chrome/chrome/networking")>] config: Config.IExports = jsNative

        module Config =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Allows an extension to define network filters for the networks it can handle. A call to this function will remove all filters previously installed by the extension before setting the new list.</summary>
                /// <param name="networks">Network filters to set. Every NetworkInfo must either have the SSID or HexSSID set. Other fields will be ignored.</param>
                /// <param name="callback">Called back when this operation is finished.
                /// The callback parameter should be a function that looks like this:
                /// function() {...};</param>
                abstract setNetworkFilter: networks: ResizeArray<NetworkInfo> * callback: (unit -> unit) -> unit
                /// <summary>Called by the extension to notify the network config API that it finished a captive portal authentication attempt and hand over the result of the attempt. This function must only be called with the GUID of the latest onCaptivePortalDetected event.</summary>
                /// <param name="GUID">Unique network identifier obtained from onCaptivePortalDetected.</param>
                /// <param name="result">The result of the authentication attempt.
                /// unhandled: The extension does not handle this network or captive portal (e.g. server end-point not found or not compatible).
                /// succeeded: The extension handled this network and authenticated successfully.
                /// rejected: The extension handled this network, tried to authenticate, however was rejected by the server.
                /// failed: The extension handled this network, tried to authenticate, however failed due to an unspecified error.</param>
                /// <param name="callback">Called back when this operation is finished.
                /// If you specify the callback parameter, it should be a function that looks like this:
                /// function() {...};</param>
                abstract finishAuthentication: GUID: string * result: string * ?callback: (unit -> unit) -> unit
                abstract onCaptivePortalDetected: CaptivePorttalDetectedEvent

            type [<AllowNullLiteral>] NetworkInfo =
                /// Currently only WiFi supported.
                abstract Type: string with get, set
                /// Optional. A unique identifier of the network.
                abstract GUID: string option with get, set
                /// Optional. A hex-encoded byte sequence.
                abstract HexSSID: string option with get, set
                /// Optional. The decoded SSID of the network (default encoding is UTF-8). To filter for non-UTF-8 SSIDs, use HexSSID instead.
                abstract SSID: string option with get, set
                /// Optional. The basic service set identification (BSSID) uniquely identifying the basic service set. BSSID is represented as a human readable, hex-encoded string with bytes separated by colons, e.g. 45:67:89:ab:cd:ef.
                abstract BSSID: string option with get, set
                /// Optional. Identifier indicating the security type of the network. Valid values are None, WEP-PSK, WPA-PSK and WPA-EAP.
                abstract Security: string option with get, set

            type [<AllowNullLiteral>] CaptivePorttalDetectedEvent =
                inherit Chrome.Events.Event<(NetworkInfo -> unit)>

    module Notifications =

        type [<AllowNullLiteral>] IExports =
            abstract onClosed: NotificationClosedEvent
            abstract onClicked: NotificationClickedEvent
            abstract onButtonClicked: NotificationButtonClickedEvent
            abstract onPermissionLevelChanged: NotificationPermissionLevelChangedEvent
            abstract onShowSettings: NotificationShowSettingsEvent
            /// <summary>Creates and displays a notification.</summary>
            /// <param name="notificationId">Identifier of the notification. If not set or empty, an ID will automatically be generated. If it matches an existing notification, this method first clears that notification before proceeding with the create operation.
            /// The notificationId parameter is required before Chrome 42.</param>
            /// <param name="options">Contents of the notification.</param>
            /// <param name="callback">Returns the notification id (either supplied or generated) that represents the created notification.
            /// The callback is required before Chrome 42.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(string notificationId) {...};</param>
            abstract create: notificationId: string * options: NotificationOptions<obj> * ?callback: (string -> unit) -> unit
            /// <summary>Creates and displays a notification.</summary>
            /// <param name="options">Contents of the notification.</param>
            /// <param name="callback">Returns the notification id (either supplied or generated) that represents the created notification.
            /// The callback is required before Chrome 42.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(string notificationId) {...};</param>
            abstract create: options: NotificationOptions<obj> * ?callback: (string -> unit) -> unit
            /// <summary>Updates an existing notification.</summary>
            /// <param name="notificationId">The id of the notification to be updated. This is returned by notifications.create method.</param>
            /// <param name="options">Contents of the notification to update to.</param>
            /// <param name="callback">Called to indicate whether a matching notification existed.
            /// The callback is required before Chrome 42.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean wasUpdated) {...};</param>
            abstract update: notificationId: string * options: NotificationOptions * ?callback: (bool -> unit) -> unit
            /// <summary>Clears the specified notification.</summary>
            /// <param name="notificationId">The id of the notification to be cleared. This is returned by notifications.create method.</param>
            /// <param name="callback">Called to indicate whether a matching notification existed.
            /// The callback is required before Chrome 42.
            /// If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean wasCleared) {...};</param>
            abstract clear: notificationId: string * ?callback: (bool -> unit) -> unit
            /// <summary>Retrieves all the notifications.</summary>
            /// <param name="callback">Returns the set of notification_ids currently in the system.
            /// The callback parameter should be a function that looks like this:
            /// function(object notifications) {...};</param>
            abstract getAll: callback: (Object -> unit) -> unit
            /// <summary>Retrieves whether the user has enabled notifications from this app or extension.</summary>
            /// <param name="callback">Returns the current permission level.
            /// The callback parameter should be a function that looks like this:
            /// function( PermissionLevel level) {...};</param>
            abstract getPermissionLevel: callback: (string -> unit) -> unit

        type [<StringEnum>] [<RequireQualifiedAccess>] TemplateType =
            | Basic
            | Image
            | List
            | Progress

        type [<AllowNullLiteral>] ButtonOptions =
            abstract title: string with get, set
            abstract iconUrl: string option with get, set

        type [<AllowNullLiteral>] ItemOptions =
            /// Title of one item of a list notification.
            abstract title: string with get, set
            /// Additional details about this item.
            abstract message: string with get, set

        type NotificationOptions =
            NotificationOptions<obj>

        type [<AllowNullLiteral>] NotificationOptions<'T> =
            interface end

        type [<AllowNullLiteral>] NotificationClosedEvent =
            inherit Chrome.Events.Event<(string -> bool -> unit)>

        type [<AllowNullLiteral>] NotificationClickedEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] NotificationButtonClickedEvent =
            inherit Chrome.Events.Event<(string -> float -> unit)>

        type [<AllowNullLiteral>] NotificationPermissionLevelChangedEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] NotificationShowSettingsEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

    module Omnibox =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Sets the description and styling for the default suggestion. The default suggestion is the text that is displayed in the first suggestion row underneath the URL bar.</summary>
            /// <param name="suggestion">A partial SuggestResult object, without the 'content' parameter.</param>
            abstract setDefaultSuggestion: suggestion: Suggestion -> unit
            abstract onInputEntered: OmniboxInputEnteredEvent
            abstract onInputChanged: OmniboxInputChangedEvent
            abstract onInputStarted: OmniboxInputStartedEvent
            abstract onInputCancelled: OmniboxInputCancelledEvent
            abstract onDeleteSuggestion: OmniboxSuggestionDeletedEvent

        /// A suggest result.
        type [<AllowNullLiteral>] SuggestResult =
            /// The text that is put into the URL bar, and that is sent to the extension when the user chooses this entry.
            abstract content: string with get, set
            /// The text that is displayed in the URL dropdown. Can contain XML-style markup for styling. The supported tags are 'url' (for a literal URL), 'match' (for highlighting text that matched what the user's query), and 'dim' (for dim helper text). The styles can be nested, eg. dimmed match. You must escape the five predefined entities to display them as text: stackoverflow.com/a/1091953/89484
            abstract description: string with get, set
            /// Whether the suggest result can be deleted by the user.
            abstract deletable: bool option with get, set

        type [<AllowNullLiteral>] Suggestion =
            /// The text that is displayed in the URL dropdown. Can contain XML-style markup for styling. The supported tags are 'url' (for a literal URL), 'match' (for highlighting text that matched what the user's query), and 'dim' (for dim helper text). The styles can be nested, eg. dimmed match.
            abstract description: string with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] OnInputEnteredDisposition =
            | CurrentTab
            | NewForegroundTab
            | NewBackgroundTab

        type [<AllowNullLiteral>] OmniboxInputEnteredEvent =
            inherit Chrome.Events.Event<(string -> OnInputEnteredDisposition -> unit)>

        type [<AllowNullLiteral>] OmniboxInputChangedEvent =
            inherit Chrome.Events.Event<(string -> (ResizeArray<SuggestResult> -> unit) -> unit)>

        type [<AllowNullLiteral>] OmniboxInputStartedEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] OmniboxInputCancelledEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] OmniboxSuggestionDeletedEvent =
            inherit Chrome.Events.Event<(string -> unit)>

    module PageAction =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Shows the page action. The page action is shown whenever the tab is selected.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract hide: tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Shows the page action. The page action is shown whenever the tab is selected.</summary>
            /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract show: tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Sets the title of the page action. This is displayed in a tooltip over the page action.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setTitle: details: TitleDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Sets the html document to be opened as a popup when the user clicks on the page action's icon.</summary>
            /// <param name="callback">Supported since Chrome 67</param>
            abstract setPopup: details: PopupDetails * ?callback: (unit -> unit) -> unit
            /// <summary>Gets the title of the page action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string result) {...};</param>
            abstract getTitle: details: GetDetails * callback: (string -> unit) -> unit
            /// <summary>Gets the html document set as the popup for this page action.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(string result) {...};</param>
            abstract getPopup: details: GetDetails * callback: (string -> unit) -> unit
            /// <summary>Sets the icon for the page action. The icon can be specified either as the path to an image file or as the pixel data from a canvas element, or as dictionary of either one of those. Either the path or the imageData property must be specified.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function() {...};</param>
            abstract setIcon: details: IconDetails * ?callback: (unit -> unit) -> unit
            abstract onClicked: PageActionClickedEvent

        type [<AllowNullLiteral>] PageActionClickedEvent =
            inherit Chrome.Events.Event<(Chrome.Tabs.Tab -> unit)>

        type [<AllowNullLiteral>] TitleDetails =
            /// The id of the tab for which you want to modify the page action.
            abstract tabId: float with get, set
            /// The tooltip string.
            abstract title: string with get, set

        type [<AllowNullLiteral>] GetDetails =
            /// Specify the tab to get the title from.
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] PopupDetails =
            /// The id of the tab for which you want to modify the page action.
            abstract tabId: float with get, set
            /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
            abstract popup: string with get, set

        type [<AllowNullLiteral>] IconDetails =
            /// The id of the tab for which you want to modify the page action.
            abstract tabId: float with get, set
            /// Optional.
            abstract iconIndex: float option with get, set
            /// Optional.
            /// Either an ImageData object or a dictionary {size -> ImageData} representing icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.imageData = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract imageData: U2<ImageData, IconDetailsImageData> option with get, set
            /// Optional.
            /// Either a relative image path or a dictionary {size -> relative image path} pointing to icon to be set. If the icon is specified as a dictionary, the actual image to be used is chosen depending on screen's pixel density. If the number of image pixels that fit into one screen space unit equals scale, then image with size scale * 19 will be selected. Initially only scales 1 and 2 will be supported. At least one image must be specified. Note that 'details.path = foo' is equivalent to 'details.imageData = {'19': foo}'
            abstract path: U2<string, IconDetailsPath> option with get, set

        type [<AllowNullLiteral>] IconDetailsImageData =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> ImageData with get, set

        type [<AllowNullLiteral>] IconDetailsPath =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: string -> string with get, set

    module PageCapture =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Saves the content of the tab with given id as MHTML.</summary>
            /// <param name="callback">Called when the MHTML has been generated.
            /// The callback parameter should be a function that looks like this:
            /// function(binary mhtmlData) {...};
            /// Parameter mhtmlData: The MHTML data as a Blob.</param>
            abstract saveAsMHTML: details: SaveDetails * callback: (Blob -> unit) -> unit

        type [<AllowNullLiteral>] SaveDetails =
            /// The id of the tab to save as MHTML.
            abstract tabId: float with get, set

    module Permissions =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Checks if the extension has the specified permissions.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};
            /// Parameter result: True if the extension has the specified permissions.</param>
            abstract contains: permissions: Permissions * callback: (bool -> unit) -> unit
            /// <summary>Gets the extension's current set of permissions.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Permissions permissions) {...};
            /// Parameter permissions: The extension's active permissions.</param>
            abstract getAll: callback: (Permissions -> unit) -> unit
            /// <summary>Requests access to the specified permissions. These permissions must be defined in the optional_permissions field of the manifest. If there are any problems requesting the permissions, runtime.lastError will be set.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean granted) {...};
            /// Parameter granted: True if the user granted the specified permissions.</param>
            abstract request: permissions: Permissions * ?callback: (bool -> unit) -> unit
            /// <summary>Removes access to the specified permissions. If there are any problems removing the permissions, runtime.lastError will be set.</summary>
            /// <param name="callback">If you specify the callback parameter, it should be a function that looks like this:
            /// function(boolean removed) {...};
            /// Parameter removed: True if the permissions were removed.</param>
            abstract remove: permissions: Permissions * ?callback: (bool -> unit) -> unit
            abstract onRemoved: PermissionsRemovedEvent
            abstract onAdded: PermissionsAddedEvent

        type [<AllowNullLiteral>] Permissions =
            /// Optional.
            /// List of named permissions (does not include hosts or origins). Anything listed here must appear in the optional_permissions list in the manifest.
            abstract permissions: ResizeArray<string> option with get, set
            /// Optional.
            /// List of origin permissions. Anything listed here must be a subset of a host that appears in the optional_permissions list in the manifest. For example, if http://*.example.com/ or http://* appears in optional_permissions, you can request an origin of http://help.example.com/. Any path is ignored.
            abstract origins: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] PermissionsRemovedEvent =
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Permissions permissions) {...};
            /// Parameter permissions: The permissions that have been removed.</param>
            abstract addListener: callback: (Permissions -> unit) -> unit

        type [<AllowNullLiteral>] PermissionsAddedEvent =
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function( Permissions permissions) {...};
            /// Parameter permissions: The newly acquired permissions.</param>
            abstract addListener: callback: (Permissions -> unit) -> unit

    module PlatformKeys =

        type [<AllowNullLiteral>] IExports =
            /// <summary>This function filters from a list of client certificates the ones that are known to the platform, match request and for which the extension has permission to access the certificate and its private key. If interactive is true, the user is presented a dialog where they can select from matching certificates and grant the extension access to the certificate. The selected/filtered client certificates will be passed to callback.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(array of Match matches) {...};
            /// Parameter matches: The list of certificates that match the request, that the extension has permission for and, if interactive is true, that were selected by the user.</param>
            abstract selectClientCertificates: details: ClientCertificateSelectDetails * callback: (ResizeArray<Match> -> unit) -> unit
            /// <summary>Passes the key pair of certificate for usage with platformKeys.subtleCrypto to callback.</summary>
            /// <param name="certificate">The certificate of a Match returned by selectClientCertificates.</param>
            /// <param name="parameters">Determines signature/hash algorithm parameters additionally to the parameters fixed by the key itself. The same parameters are   accepted as by WebCrypto's importKey function, e.g. RsaHashedImportParams for a RSASSA-PKCS1-v1_5 key. For RSASSA-PKCS1-v1_5 keys, additionally the parameters { 'hash': { 'name': 'none' } } are supported. The sign function will then apply PKCS#1 v1.5 padding and but not hash the given data.</param>
            /// <param name="callback">The public and private CryptoKey of a certificate which can only be used with platformKeys.subtleCrypto.
            /// The callback parameter should be a function that looks like this:
            /// function(object publicKey, object privateKey) {...};
            /// Optional parameter privateKey: Might be null if this extension does not have access to it.</param>
            // abstract getKeyPair: certificate: ArrayBuffer * parameters: Object * callback: (CryptoKey -> CryptoKey option -> unit) -> unit
            // /// <summary>Passes the key pair of publicKeySpkiDer for usage with platformKeys.subtleCrypto to callback.</summary>
            // /// <param name="publicKeySpkiDer">A DER-encoded X.509 SubjectPublicKeyInfo, obtained e.g. by calling WebCrypto's exportKey function with format="spki".</param>
            // /// <param name="parameters">Provides signature and hash algorithm parameters, in addition to those fixed by the key itself. The same parameters are accepted as by WebCrypto's importKey function, e.g. RsaHashedImportParams for a RSASSA-PKCS1-v1_5 key. For RSASSA-PKCS1-v1_5 keys, we need to also pass a "hash" parameter { "hash": { "name": string } }. The "hash" parameter represents the name of the hashing algorithm to be used in the digest operation before a sign. It is possible to pass "none" as the hash name, in which case the sign function will apply PKCS#1 v1.5 padding and but not hash the given data.
            // /// Currently, this function only supports the "RSASSA-PKCS1-v1_5" algorithm with one of the hashing algorithms "none", "SHA-1", "SHA-256", "SHA-384", and "SHA-512".</param>
            // /// <param name="callback">The public and private CryptoKey of a certificate which can only be used with platformKeys.subtleCrypto.
            // /// The callback parameter should be a function that looks like this:
            // /// function(object publicKey, object privateKey) {...};
            // /// Optional parameter privateKey: Might be null if this extension does not have access to it.</param>
            // abstract getKeyPairBySpki: publicKeySpkiDer: ArrayBuffer * parameters: Object * callback: (CryptoKey -> CryptoKey option -> unit) -> unit
            // /// An implementation of WebCrypto's  SubtleCrypto that allows crypto operations on keys of client certificates that are available to this extension.
            // abstract subtleCrypto: unit -> SubtleCrypto
            /// <summary>Checks whether details.serverCertificateChain can be trusted for details.hostname according to the trust settings of the platform. Note: The actual behavior of the trust verification is not fully specified and might change in the future. The API implementation verifies certificate expiration, validates the certification path and checks trust by a known CA. The implementation is supposed to respect the EKU serverAuth and to support subject alternative names.</summary>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(object result) {...};</param>
            abstract verifyTLSServerCertificate: details: ServerCertificateVerificationDetails * callback: (ServerCertificateVerificationResult -> unit) -> unit

        type [<AllowNullLiteral>] Match =
            /// The DER encoding of a X.509 certificate.
            abstract certificate: ArrayBuffer with get, set
            /// The  KeyAlgorithm of the certified key. This contains algorithm parameters that are inherent to the key of the certificate (e.g. the key length). Other parameters like the hash function used by the sign function are not included.
            // abstract keyAlgorithm: KeyAlgorithm with get, set

        type [<AllowNullLiteral>] ClientCertificateSelectRequestDetails =
            /// This field is a list of the types of certificates requested, sorted in order of the server's preference. Only certificates of a type contained in this list will be retrieved. If certificateTypes is the empty list, however, certificates of any type will be returned.
            abstract certificateTypes: ResizeArray<string> with get, set
            /// List of distinguished names of certificate authorities allowed by the server. Each entry must be a DER-encoded X.509 DistinguishedName.
            abstract certificateAuthorities: ResizeArray<ArrayBuffer> with get, set

        type [<AllowNullLiteral>] ClientCertificateSelectDetails =
            /// Only certificates that match this request will be returned.
            abstract request: ClientCertificateSelectRequestDetails with get, set
            /// Optional.
            /// If given, the selectClientCertificates operates on this list. Otherwise, obtains the list of all certificates from the platform's certificate stores that are available to this extensions. Entries that the extension doesn't have permission for or which doesn't match the request, are removed.
            abstract clientCerts: ResizeArray<ArrayBuffer> option with get, set
            /// If true, the filtered list is presented to the user to manually select a certificate and thereby granting the extension access to the certificate(s) and key(s). Only the selected certificate(s) will be returned. If is false, the list is reduced to all certificates that the extension has been granted access to (automatically or manually).
            abstract interactive: bool with get, set

        type [<AllowNullLiteral>] ServerCertificateVerificationDetails =
            /// Each chain entry must be the DER encoding of a X.509 certificate, the first entry must be the server certificate and each entry must certify the entry preceding it.
            abstract serverCertificateChain: ResizeArray<ArrayBuffer> with get, set
            /// The hostname of the server to verify the certificate for, e.g. the server that presented the serverCertificateChain.
            abstract hostname: string with get, set

        type [<AllowNullLiteral>] ServerCertificateVerificationResult =
            /// The result of the trust verification: true if trust for the given verification details could be established and false if trust is rejected for any reason.
            abstract trusted: bool with get, set
            /// If the trust verification failed, this array contains the errors reported by the underlying network layer. Otherwise, this array is empty.
            /// Note: This list is meant for debugging only and may not contain all relevant errors. The errors returned may change in future revisions of this API, and are not guaranteed to be forwards or backwards compatible.
            abstract debug_errors: ResizeArray<string> with get, set

    module Power =

        type [<AllowNullLiteral>] IExports =
            /// Requests that power management be temporarily disabled. |level| describes the degree to which power management should be disabled. If a request previously made by the same app is still active, it will be replaced by the new request.
            abstract requestKeepAwake: level: string -> unit
            /// Releases a request previously made via requestKeepAwake().
            abstract releaseKeepAwake: unit -> unit

    module PrinterProvider =

        type [<AllowNullLiteral>] IExports =
            abstract onGetPrintersRequested: PrinterRequestedEvent
            abstract onGetUsbPrinterInfoRequested: PrinterInfoRequestedEvent
            abstract onGetCapabilityRequested: CapabilityRequestedEvent
            abstract onPrintRequested: PrintRequestedEvent

        type [<AllowNullLiteral>] PrinterInfo =
            /// Unique printer ID.
            abstract id: string with get, set
            /// Printer's human readable name.
            abstract name: string with get, set
            /// Optional. Printer's human readable description.
            abstract description: string option with get, set

        type [<AllowNullLiteral>] PrinterCapabilities =
            /// Device capabilities in CDD format.
            abstract capabilities: obj option with get, set

        type [<AllowNullLiteral>] PrintJob =
            /// ID of the printer which should handle the job.
            abstract printerId: string with get, set
            /// The print job title.
            abstract title: string with get, set
            /// Print ticket in  CJT format.
            abstract ticket: Object with get, set
            /// The document content type. Supported formats are "application/pdf" and "image/pwg-raster".
            abstract contentType: string with get, set
            /// Blob containing the document data to print. Format must match |contentType|.
            abstract document: Blob with get, set

        type [<AllowNullLiteral>] PrinterRequestedEvent =
            inherit Chrome.Events.Event<((ResizeArray<PrinterInfo> -> unit) -> unit)>

        type [<AllowNullLiteral>] PrinterInfoRequestedEvent =
            inherit Chrome.Events.Event<(obj option -> (PrinterInfo -> unit) -> unit)>

        type [<AllowNullLiteral>] CapabilityRequestedEvent =
            inherit Chrome.Events.Event<(string -> (PrinterCapabilities -> unit) -> unit)>

        type [<AllowNullLiteral>] PrintRequestedEvent =
            inherit Chrome.Events.Event<(PrintJob -> (string -> unit) -> unit)>

    module Privacy =

        type [<AllowNullLiteral>] IExports =
            abstract services: Services
            abstract network: Network
            abstract websites: Websites

        type [<AllowNullLiteral>] Services =
            /// since Chrome 20.
            abstract spellingServiceEnabled: Chrome.Types.ChromeSetting with get, set
            abstract searchSuggestEnabled: Chrome.Types.ChromeSetting with get, set
            abstract instantEnabled: Chrome.Types.ChromeSetting with get, set
            abstract alternateErrorPagesEnabled: Chrome.Types.ChromeSetting with get, set
            abstract safeBrowsingEnabled: Chrome.Types.ChromeSetting with get, set
            abstract autofillEnabled: Chrome.Types.ChromeSetting with get, set
            abstract translationServiceEnabled: Chrome.Types.ChromeSetting with get, set
            abstract passwordSavingEnabled: Chrome.Types.ChromeSetting with get, set
            abstract hotwordSearchEnabled: Chrome.Types.ChromeSetting with get, set
            abstract safeBrowsingExtendedReportingEnabled: Chrome.Types.ChromeSetting with get, set
            abstract autofillAddressEnabled: Chrome.Types.ChromeSetting with get, set
            abstract autofillCreditCardEnabled: Chrome.Types.ChromeSetting with get, set

        type [<AllowNullLiteral>] Network =
            abstract networkPredictionEnabled: Chrome.Types.ChromeSetting with get, set
            abstract webRTCMultipleRoutesEnabled: Chrome.Types.ChromeSetting with get, set
            abstract webRTCNonProxiedUdpEnabled: Chrome.Types.ChromeSetting with get, set
            abstract webRTCIPHandlingPolicy: Chrome.Types.ChromeSetting with get, set

        type [<AllowNullLiteral>] Websites =
            abstract thirdPartyCookiesAllowed: Chrome.Types.ChromeSetting with get, set
            abstract referrersEnabled: Chrome.Types.ChromeSetting with get, set
            abstract hyperlinkAuditingEnabled: Chrome.Types.ChromeSetting with get, set
            abstract protectedContentEnabled: Chrome.Types.ChromeSetting with get, set
            abstract doNotTrackEnabled: Chrome.Types.ChromeSetting with get, set

    module Proxy =

        type [<AllowNullLiteral>] IExports =
            abstract settings: Chrome.Types.ChromeSetting
            abstract onProxyError: ProxyErrorEvent

        /// An object holding proxy auto-config information. Exactly one of the fields should be non-empty.
        type [<AllowNullLiteral>] PacScript =
            /// Optional. URL of the PAC file to be used.
            abstract url: string option with get, set
            /// Optional. If true, an invalid PAC script will prevent the network stack from falling back to direct connections. Defaults to false.
            abstract mandatory: bool option with get, set
            /// Optional. A PAC script.
            abstract data: string option with get, set

        /// An object encapsulating a complete proxy configuration.
        type [<AllowNullLiteral>] ProxyConfig =
            /// Optional. The proxy rules describing this configuration. Use this for 'fixed_servers' mode.
            abstract rules: ProxyRules option with get, set
            /// Optional. The proxy auto-config (PAC) script for this configuration. Use this for 'pac_script' mode.
            abstract pacScript: PacScript option with get, set
            /// 'direct' = Never use a proxy
            /// 'auto_detect' = Auto detect proxy settings
            /// 'pac_script' = Use specified PAC script
            /// 'fixed_servers' = Manually specify proxy servers
            /// 'system' = Use system proxy settings
            abstract mode: string with get, set

        /// An object encapsulating a single proxy server's specification.
        type [<AllowNullLiteral>] ProxyServer =
            /// The URI of the proxy server. This must be an ASCII hostname (in Punycode format). IDNA is not supported, yet.
            abstract host: string with get, set
            /// Optional. The scheme (protocol) of the proxy server itself. Defaults to 'http'.
            abstract scheme: string option with get, set
            /// Optional. The port of the proxy server. Defaults to a port that depends on the scheme.
            abstract port: float option with get, set

        /// An object encapsulating the set of proxy rules for all protocols. Use either 'singleProxy' or (a subset of) 'proxyForHttp', 'proxyForHttps', 'proxyForFtp' and 'fallbackProxy'.
        type [<AllowNullLiteral>] ProxyRules =
            /// Optional. The proxy server to be used for FTP requests.
            abstract proxyForFtp: ProxyServer option with get, set
            /// Optional. The proxy server to be used for HTTP requests.
            abstract proxyForHttp: ProxyServer option with get, set
            /// Optional. The proxy server to be used for everthing else or if any of the specific proxyFor... is not specified.
            abstract fallbackProxy: ProxyServer option with get, set
            /// Optional. The proxy server to be used for all per-URL requests (that is http, https, and ftp).
            abstract singleProxy: ProxyServer option with get, set
            /// Optional. The proxy server to be used for HTTPS requests.
            abstract proxyForHttps: ProxyServer option with get, set
            /// Optional. List of servers to connect to without a proxy server.
            abstract bypassList: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ErrorDetails =
            /// Additional details about the error such as a JavaScript runtime error.
            abstract details: string with get, set
            /// The error description.
            abstract error: string with get, set
            /// If true, the error was fatal and the network transaction was aborted. Otherwise, a direct connection is used instead.
            abstract fatal: bool with get, set

        type [<AllowNullLiteral>] ProxyErrorEvent =
            inherit Chrome.Events.Event<(ErrorDetails -> unit)>

    module Search =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Used to query the default search provider. In case of an error, runtime.lastError will be set.</summary>
            /// <param name="options">search configuration options.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function() => {...}</param>
            abstract query: options: QueryInfo * callback: (unit -> unit) -> unit

        type [<StringEnum>] [<RequireQualifiedAccess>] Disposition =
            | [<CompiledName "CURRENT_TAB">] CURRENT_TAB
            | [<CompiledName "NEW_TAB">] NEW_TAB
            | [<CompiledName "NEW_WINDOW">] NEW_WINDOW

        type [<AllowNullLiteral>] QueryInfo =
            /// Location where search results should be displayed. CURRENT_TAB is the default.
            abstract disposition: Disposition option with get, set
            /// Location where search results should be displayed. tabIdcannot be used with disposition.
            abstract tabId: float option with get, set
            /// String to query with the default search provider.
            abstract text: string option with get, set

    module Serial =
        let [<Import("onReceive","chrome/chrome/serial")>] onReceive: OnReceive.IExports = jsNative
        let [<Import("onReceiveError","chrome/chrome/serial")>] onReceiveError: OnReceiveError.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract DataBits: IExportsDataBits
            abstract ParityBit: IExportsParityBit
            abstract StopBits: IExportsStopBits
            /// <param name="callback">Called with the list of DeviceInfo objects.
            /// The callback parameter should be a function that looks like this:
            /// function(array of object ports) {...};</param>
            abstract getDevices: callback: (ResizeArray<DeviceInfo> -> unit) -> unit
            /// <param name="path">The system path of the serial port to open.</param>
            /// <param name="options">Port configuration options.</param>
            /// <param name="callback">Called when the connection has been opened.
            /// The callback parameter should be a function that looks like this:
            /// function( ConnectionInfo connectionInfo) {...};</param>
            abstract connect: path: string * options: ConnectionOptions * callback: (ConnectionInfo -> unit) -> unit
            /// <param name="connectionId">The id of the opened connection.</param>
            /// <param name="options">Port configuration options.</param>
            /// <param name="callback">Called when the configuation has completed.
            /// The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract update: connectionId: float * options: ConnectionOptions * callback: (bool -> unit) -> unit
            /// <param name="connectionId">The id of the opened connection.</param>
            /// <param name="callback">Called when the connection has been closed.
            /// The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract disconnect: connectionId: float * callback: (bool -> unit) -> unit
            /// <param name="connectionId">The id of the opened connection.</param>
            /// <param name="paused">Flag to indicate whether to pause or unpause.</param>
            /// <param name="callback">Called when the connection has been successfully paused or unpaused.
            /// The callback parameter should be a function that looks like this:
            /// function() {...};</param>
            abstract setPaused: connectionId: float * paused: bool * callback: (unit -> unit) -> unit
            /// <param name="callback">Called with connection state information when available.
            /// The callback parameter should be a function that looks like this:
            /// function( ConnectionInfo connectionInfo) {...};</param>
            abstract getInfo: callback: (ResizeArray<ConnectionInfo> -> unit) -> unit
            /// <param name="callback">Called with the list of connections when available.
            /// The callback parameter should be a function that looks like this:
            /// function(array of ConnectionInfo connectionInfos) {...};</param>
            abstract getConnections: callback: (ResizeArray<ConnectionInfo> -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="data">The data to send.</param>
            /// <param name="callback">Called when the operation has completed.
            /// The callback parameter should be a function that looks like this:
            /// function(object sendInfo) {...};</param>
            abstract send: connectionId: float * data: ArrayBuffer * callback: (obj -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract flush: connectionId: float * callback: (bool -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="callback">Called when the control signals are available.
            /// The callback parameter should be a function that looks like this:
            /// function(object signals) {...};</param>
            abstract getControlSignals: connectionId: float * callback: (obj -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="signals">The set of signal changes to send to the device:
            /// boolean:    (optional) dtr - DTR (Data Terminal Ready).
            /// boolean:    (optional) rts - RTS (Request To Send).</param>
            /// <param name="callback">Called once the control signals have been set.
            /// The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract setControlSignals: connectionId: float * signals: obj * callback: (bool -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract setBreak: connectionId: float * callback: (bool -> unit) -> unit
            /// <param name="connectionId">The id of the connection.</param>
            /// <param name="callback">The callback parameter should be a function that looks like this:
            /// function(boolean result) {...};</param>
            abstract clearBreak: connectionId: float * callback: (bool -> unit) -> unit

        type [<AllowNullLiteral>] DeviceInfo =
            /// The device's system path. This should be passed as the path argument to chrome.serial.connect in order to connect to this device.
            abstract path: string with get, set
            /// Optional. A PCI or USB vendor ID if one can be determined for the underlying device.
            abstract vendorId: float option with get, set
            /// Optional. A USB product ID if one can be determined for the underlying device.
            abstract productId: float option with get, set
            /// Optional. A human-readable display name for the underlying device if one can be queried from the host driver.
            abstract displayName: float option with get, set

        type [<AllowNullLiteral>] ConnectionInfo =
            /// The id of the serial port connection.
            abstract connectionId: float option with get, set
            /// Flag indicating whether the connection is blocked from firing onReceive events.
            abstract paused: bool with get, set
            /// See ConnectionOptions.persistent
            abstract persistent: bool with get, set
            /// See ConnectionOptions.name
            abstract name: string with get, set
            /// See ConnectionOptions.bufferSize
            abstract bufferSize: float with get, set
            /// See ConnectionOptions.receiveTimeout
            abstract receiveTimeout: float option with get, set
            /// See ConnectionOptions.sendTimeout
            abstract sendTimeout: float option with get, set
            /// Optional. See ConnectionOptions.bitrate.
            /// This field may be omitted or inaccurate if a non-standard bitrate is in use, or if an error occurred while querying the underlying device.
            abstract bitrate: float option with get, set
            /// Optional. See ConnectionOptions.dataBits. This field may be omitted if an error occurred while querying the underlying device.
            abstract dataBits: obj option with get, set
            /// Optional. See ConnectionOptions.parityBit. This field may be omitted if an error occurred while querying the underlying device.
            abstract parityBit: obj option with get, set
            /// Optional. See ConnectionOptions.stopBits. This field may be omitted if an error occurred while querying the underlying device.
            abstract stopBits: obj option with get, set
            /// Optional. Flag indicating whether or not to enable RTS/CTS hardware flow control. Defaults to false.
            abstract ctsFlowControl: bool option with get, set

        type [<AllowNullLiteral>] ConnectionOptions =
            /// Optional. Flag indicating whether or not the connection should be left open when the application is suspended (see Manage App Lifecycle: https://developer.chrome.com/apps/app_lifecycle).
            /// The default value is "false." When the application is loaded, any serial connections previously opened with persistent=true can be fetched with getConnections.
            abstract persistent: bool option with get, set
            /// Optional. An application-defined string to associate with the connection.
            abstract name: string option with get, set
            /// Optional. The size of the buffer used to receive data. The default value is 4096.
            abstract bufferSize: float option with get, set
            /// Optional. The requested bitrate of the connection to be opened.
            /// For compatibility with the widest range of hardware, this number should match one of commonly-available bitrates,
            /// such as 110, 300, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200.
            /// There is no guarantee, of course, that the device connected to the serial port will support the requested bitrate, even if the port itself supports that bitrate.
            /// 9600 will be passed by default.
            abstract bitrate: float option with get, set
            /// Optional. "eight" will be passed by default.
            abstract dataBits: obj option with get, set
            /// Optional. "no" will be passed by default.
            abstract parityBit: obj option with get, set
            /// Optional. "one" will be passed by default.
            abstract stopBits: obj option with get, set
            /// Optional. Flag indicating whether or not to enable RTS/CTS hardware flow control. Defaults to false.
            abstract ctsFlowControl: bool option with get, set
            /// Optional. The maximum amount of time (in milliseconds) to wait for new data before raising an onReceiveError event with a "timeout" error.
            /// If zero, receive timeout errors will not be raised for the connection.
            /// Defaults to 0.
            abstract receiveTimeout: float option with get, set
            /// Optional. The maximum amount of time (in milliseconds) to wait for a send operation to complete before calling the callback with a "timeout" error.
            /// If zero, send timeout errors will not be triggered.
            /// Defaults to 0.
            abstract sendTimeout: float option with get, set

        module OnReceive =

            type [<AllowNullLiteral>] IExports =
                /// <param name="callback">The callback parameter should be a function that looks like this:
                /// function(OnReceiveInfo info) {...};</param>
                abstract addListener: callback: (OnReceiveInfo -> unit) -> unit

            type [<AllowNullLiteral>] OnReceiveInfo =
                /// The connection identifier.
                abstract connectionId: float with get, set
                /// The data received.
                abstract data: ArrayBuffer with get, set

        module OnReceiveError =

            type [<AllowNullLiteral>] IExports =
                abstract OnReceiveErrorEnum: IExportsOnReceiveErrorEnum
                /// <param name="callback">The callback parameter should be a function that looks like this:
                /// function(OnReceiveErrorInfo info) {...};</param>
                abstract addListener: callback: (OnReceiveErrorInfo -> unit) -> unit

            type [<AllowNullLiteral>] OnReceiveErrorInfo =
                /// The connection identifier.
                abstract connectionId: float with get, set
                /// The data received.
                abstract error: ArrayBuffer with get, set

            type [<AllowNullLiteral>] IExportsOnReceiveErrorEnum =
                abstract disconnected: string with get, set
                abstract timeout: string with get, set
                abstract device_lost: string with get, set
                abstract ``break``: string with get, set
                abstract frame_error: string with get, set
                abstract overrun: string with get, set
                abstract buffer_overflow: string with get, set
                abstract parity_error: string with get, set
                abstract system_error: string with get, set

        type [<AllowNullLiteral>] IExportsDataBits =
            abstract SEVEN: string with get, set
            abstract EIGHT: string with get, set

        type [<AllowNullLiteral>] IExportsParityBit =
            abstract NO: string with get, set
            abstract ODD: string with get, set
            abstract EVEN: string with get, set

        type [<AllowNullLiteral>] IExportsStopBits =
            abstract ONE: string with get, set
            abstract TWO: string with get, set

    module Runtime =

        type [<AllowNullLiteral>] IExports =
            abstract lastError: LastError option
            abstract id: string
            /// Attempts to connect to connect listeners within an extension/app (such as the background page), or other extensions/apps. This is useful for content scripts connecting to their extension processes, inter-app/extension communication, and web messaging. Note that this does not connect to any listeners in a content script. Extensions may connect to content scripts embedded in tabs via tabs.connect.
            abstract connect: ?connectInfo: ConnectInfo -> Port
            /// <summary>Attempts to connect to connect listeners within an extension/app (such as the background page), or other extensions/apps. This is useful for content scripts connecting to their extension processes, inter-app/extension communication, and web messaging. Note that this does not connect to any listeners in a content script. Extensions may connect to content scripts embedded in tabs via tabs.connect.</summary>
            /// <param name="extensionId">Optional.
            /// The ID of the extension or app to connect to. If omitted, a connection will be attempted with your own extension. Required if sending messages from a web page for web messaging.</param>
            abstract connect: extensionId: string * ?connectInfo: ConnectInfo -> Port
            /// <summary>Connects to a native application in the host machine.</summary>
            /// <param name="application">The name of the registered application to connect to.</param>
            abstract connectNative: application: string -> Port
            /// Retrieves the JavaScript 'window' object for the background page running inside the current extension/app. If the background page is an event page, the system will ensure it is loaded before calling the callback. If there is no background page, an error is set.
            abstract getBackgroundPage: callback: (Window -> unit) -> unit
            /// Returns details about the app or extension from the manifest. The object returned is a serialization of the full manifest file.
            abstract getManifest: unit -> Manifest
            /// Returns a DirectoryEntry for the package directory.
            // abstract getPackageDirectoryEntry: callback: (DirectoryEntry -> unit) -> unit
            /// <summary>Returns information about the current platform.</summary>
            /// <param name="callback">Called with results</param>
            abstract getPlatformInfo: callback: (PlatformInfo -> unit) -> unit
            /// Returns information about the current platform.
            abstract getPlatformInfo: unit -> Promise<PlatformInfo>
            /// <summary>Converts a relative path within an app/extension install directory to a fully-qualified URL.</summary>
            /// <param name="path">A path to a resource within an app/extension expressed relative to its install directory.</param>
            abstract getURL: path: string -> string
            /// Reloads the app or extension.
            abstract reload: unit -> unit
            /// <summary>Requests an update check for this app/extension.</summary>
            /// <param name="callback">Parameter status: Result of the update check. One of: "throttled", "no_update", or "update_available"
            /// Optional parameter details: If an update is available, this contains more information about the available update.</param>
            abstract requestUpdateCheck: callback: (RequestUpdateCheckStatus -> UpdateCheckDetails -> unit) -> unit
            /// Restart the ChromeOS device when the app runs in kiosk mode. Otherwise, it's no-op.
            abstract restart: unit -> unit
            /// Restart the ChromeOS device when the app runs in kiosk mode after the
            /// given seconds. If called again before the time ends, the reboot will
            /// be delayed. If called with a value of -1, the reboot will be
            /// cancelled. It's a no-op in non-kiosk mode. It's only allowed to be
            /// called repeatedly by the first extension to invoke this API.
            abstract restartAfterDelay: seconds: float * ?callback: (unit -> unit) -> unit
            /// Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.
            abstract sendMessage: message: 'M * responseCallback: ('R -> unit) -> unit
            /// Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.
            abstract sendMessage: message: 'M * options: MessageOptions * responseCallback: ('R -> unit) -> unit
            /// <summary>Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.</summary>
            /// <param name="extensionId">The ID of the extension/app to send the message to. If omitted, the message will be sent to your own extension/app. Required if sending messages from a web page for web messaging.
            /// Parameter response: The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendMessage: extensionId: string * message: 'M * responseCallback: ('R -> unit) -> unit
            /// <summary>Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.</summary>
            /// <param name="extensionId">The ID of the extension/app to send the message to. If omitted, the message will be sent to your own extension/app. Required if sending messages from a web page for web messaging.
            /// Parameter response: The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendMessage: extensionId: string * message: 'Message * options: MessageOptions * responseCallback: ('Response -> unit) -> unit
            /// Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.
            abstract sendMessage: message: 'M -> Promise<'R>
            /// Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.
            abstract sendMessage: message: 'M * options: MessageOptions -> Promise<'R>
            /// <summary>Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.</summary>
            /// <param name="extensionId">The ID of the extension/app to send the message to. If omitted, the message will be sent to your own extension/app. Required if sending messages from a web page for web messaging.</param>
            abstract sendMessage: extensionId: string * message: 'M -> Promise<'R>
            /// <summary>Sends a single message to event listeners within your extension/app or a different extension/app. Similar to runtime.connect but only sends a single message, with an optional response. If sending to your extension, the runtime.onMessage event will be fired in each page, or runtime.onMessageExternal, if a different extension. Note that extensions cannot send messages to content scripts using this method. To send messages to content scripts, use tabs.sendMessage.</summary>
            /// <param name="extensionId">The ID of the extension/app to send the message to. If omitted, the message will be sent to your own extension/app. Required if sending messages from a web page for web messaging.</param>
            abstract sendMessage: extensionId: string * message: 'Message * options: MessageOptions -> Promise<'Response>
            /// <summary>Send a single message to a native application.</summary>
            /// <param name="application">The of the native messaging host.</param>
            /// <param name="message">The message that will be passed to the native messaging host.
            /// Parameter response: The response message sent by the native messaging host. If an error occurs while connecting to the native messaging host, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendNativeMessage: application: string * message: Object * responseCallback: (obj option -> unit) -> unit
            /// <summary>Send a single message to a native application.</summary>
            /// <param name="application">The of the native messaging host.</param>
            /// <param name="message">The message that will be passed to the native messaging host.</param>
            abstract sendNativeMessage: application: string * message: Object -> Promise<obj option>
            /// <summary>Sets the URL to be visited upon uninstallation. This may be used to clean up server-side data, do analytics, and implement surveys. Maximum 255 characters.</summary>
            /// <param name="url">Since Chrome 34.
            /// URL to be opened after the extension is uninstalled. This URL must have an http: or https: scheme. Set an empty string to not open a new tab upon uninstallation.</param>
            /// <param name="callback">Called when the uninstall URL is set. If the given URL is invalid, runtime.lastError will be set.</param>
            abstract setUninstallURL: url: string * ?callback: (unit -> unit) -> unit
            /// Open your Extension's options page, if possible.
            /// The precise behavior may depend on your manifest's options_ui or options_page key, or what Chrome happens to support at the time. For example, the page may be opened in a new tab, within chrome://extensions, within an App, or it may just focus an open options page. It will never cause the caller page to reload.
            /// If your Extension does not declare an options page, or Chrome failed to create one for some other reason, the callback will set lastError.
            abstract openOptionsPage: ?callback: (unit -> unit) -> unit
            abstract onConnect: ExtensionConnectEvent
            abstract onConnectExternal: ExtensionConnectEvent
            abstract onSuspend: RuntimeEvent
            abstract onStartup: RuntimeEvent
            abstract onInstalled: RuntimeInstalledEvent
            abstract onSuspendCanceled: RuntimeEvent
            abstract onMessage: ExtensionMessageEvent
            abstract onMessageExternal: ExtensionMessageEvent
            abstract onRestartRequired: RuntimeRestartRequiredEvent
            abstract onUpdateAvailable: RuntimeUpdateAvailableEvent
            abstract onBrowserUpdateAvailable: RuntimeEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] PlatformOs =
            | Mac
            | Win
            | Android
            | Cros
            | Linux
            | Openbsd

        type [<StringEnum>] [<RequireQualifiedAccess>] PlatformArch =
            | Arm
            | Arm64
            | [<CompiledName "x86-32">] X8632
            | [<CompiledName "x86-64">] X8664
            | Mips
            | Mips64

        type [<StringEnum>] [<RequireQualifiedAccess>] PlatformNaclArch =
            | Arm
            | [<CompiledName "x86-32">] X8632
            | [<CompiledName "x86-64">] X8664
            | Mips
            | Mips64

        type [<StringEnum>] [<RequireQualifiedAccess>] OnInstalledReason =
            | [<CompiledName "install">] INSTALL
            | [<CompiledName "update">] UPDATE
            | [<CompiledName "chrome_update">] CHROME_UPDATE
            | [<CompiledName "shared_module_update">] SHARED_MODULE_UPDATE

        type [<AllowNullLiteral>] LastError =
            /// Optional. Details about the error which occurred.
            abstract message: string option with get, set

        type [<AllowNullLiteral>] ConnectInfo =
            abstract name: string option with get, set
            abstract includeTlsChannelId: bool option with get, set

        type [<AllowNullLiteral>] InstalledDetails =
            /// The reason that this event is being dispatched.
            abstract reason: OnInstalledReason with get, set
            /// Optional.
            /// Indicates the previous version of the extension, which has just been updated. This is present only if 'reason' is 'update'.
            abstract previousVersion: string option with get, set
            /// Optional.
            /// Indicates the ID of the imported shared module extension which updated. This is present only if 'reason' is 'shared_module_update'.
            abstract id: string option with get, set

        type [<AllowNullLiteral>] MessageOptions =
            /// Whether the TLS channel ID will be passed into onMessageExternal for processes that are listening for the connection event.
            abstract includeTlsChannelId: bool option with get, set

        /// An object containing information about the script context that sent a message or request.
        type [<AllowNullLiteral>] MessageSender =
            /// The ID of the extension or app that opened the connection, if any.
            abstract id: string option with get, set
            /// The tabs.Tab which opened the connection, if any. This property will only be present when the connection was opened from a tab (including content scripts), and only if the receiver is an extension, not an app.
            abstract tab: Chrome.Tabs.Tab option with get, set
            /// The name of the native application that opened the connection, if any.
            abstract nativeApplication: string option with get, set
            /// The frame that opened the connection. 0 for top-level frames, positive for child frames. This will only be set when tab is set.
            abstract frameId: float option with get, set
            /// The URL of the page or frame that opened the connection. If the sender is in an iframe, it will be iframe's URL not the URL of the page which hosts it.
            abstract url: string option with get, set
            /// The TLS channel ID of the page or frame that opened the connection, if requested by the extension or app, and if available.
            abstract tlsChannelId: string option with get, set
            /// The origin of the page or frame that opened the connection. It can vary from the url property (e.g., about:blank) or can be opaque (e.g., sandboxed iframes). This is useful for identifying if the origin can be trusted if we can't immediately tell from the URL.
            abstract origin: string option with get, set

        /// An object containing information about the current platform.
        type [<AllowNullLiteral>] PlatformInfo =
            /// The operating system chrome is running on.
            abstract os: PlatformOs with get, set
            /// The machine's processor architecture.
            abstract arch: PlatformArch with get, set
            /// The native client architecture. This may be different from arch on some platforms.
            abstract nacl_arch: PlatformNaclArch with get, set

        /// An object which allows two way communication with other pages.
        type [<AllowNullLiteral>] Port =
            abstract postMessage: (obj option -> unit) with get, set
            abstract disconnect: (unit -> unit) with get, set
            /// Optional.
            /// This property will only be present on ports passed to onConnect/onConnectExternal listeners.
            abstract sender: MessageSender option with get, set
            /// An object which allows the addition and removal of listeners for a Chrome event.
            abstract onDisconnect: PortDisconnectEvent with get, set
            /// An object which allows the addition and removal of listeners for a Chrome event.
            abstract onMessage: PortMessageEvent with get, set
            abstract name: string with get, set

        type [<AllowNullLiteral>] UpdateAvailableDetails =
            /// The version number of the available update.
            abstract version: string with get, set

        type [<AllowNullLiteral>] UpdateCheckDetails =
            /// The version of the available update.
            abstract version: string with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] RequestUpdateCheckStatus =
            | Throttled
            | No_update
            | Update_available

        type [<AllowNullLiteral>] PortDisconnectEvent =
            inherit Chrome.Events.Event<(Port -> unit)>

        type [<AllowNullLiteral>] PortMessageEvent =
            inherit Chrome.Events.Event<(obj option -> Port -> unit)>

        type [<AllowNullLiteral>] ExtensionMessageEvent =
            inherit Chrome.Events.Event<Action<obj option ,  MessageSender option ,  (obj -> unit) option>>
                        
        type [<AllowNullLiteral>] ExtensionConnectEvent =
            inherit Chrome.Events.Event<(Port -> unit)>

        type [<AllowNullLiteral>] RuntimeInstalledEvent =
            inherit Chrome.Events.Event<(InstalledDetails -> unit)>

        type [<AllowNullLiteral>] RuntimeEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] RuntimeRestartRequiredEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] RuntimeUpdateAvailableEvent =
            inherit Chrome.Events.Event<(UpdateAvailableDetails -> unit)>

        type [<AllowNullLiteral>] ManifestIcons =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: size: float -> string with get, set

        type [<AllowNullLiteral>] ManifestAction =
            abstract default_icon: ManifestIcons option with get, set
            abstract default_title: string option with get, set
            abstract default_popup: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] ManifestPermissions =
            | ActiveTab
            | Alarms
            | Background
            | Bookmarks
            | BrowsingData
            | CertificateProvider
            | ClipboardRead
            | ClipboardWrite
            | ContentSettings
            | ContextMenus
            | Cookies
            | Debugger
            | DeclarativeContent
            | DeclarativeNetRequest
            | DeclarativeNetRequestFeedback
            | DeclarativeWebRequest
            | DesktopCapture
            | DocumentScan
            | Downloads
            | [<CompiledName "enterprise.deviceAttributes">] Enterprise_deviceAttributes
            | [<CompiledName "enterprise.hardwarePlatform">] Enterprise_hardwarePlatform
            | [<CompiledName "enterprise.networkingAttributes">] Enterprise_networkingAttributes
            | [<CompiledName "enterprise.platformKeys">] Enterprise_platformKeys
            | Experimental
            | FileBrowserHandler
            | FileSystemProvider
            | FontSettings
            | Gcm
            | Geolocation
            | History
            | Identity
            | Idle
            | LoginState
            | Management
            | NativeMessaging
            | Notifications
            | PageCapture
            | PlatformKeys
            | Power
            | PrinterProvider
            | Printing
            | PrintingMetrics
            | Privacy
            | Processes
            | Proxy
            | Scripting
            | Search
            | Sessions
            | SignedInDevices
            | Storage
            | [<CompiledName "system.cpu">] System_cpu
            | [<CompiledName "system.display">] System_display
            | [<CompiledName "system.memory">] System_memory
            | [<CompiledName "system.storage">] System_storage
            | TabCapture
            | TabGroups
            | Tabs
            | TopSites
            | Tts
            | TtsEngine
            | UnlimitedStorage
            | VpnProvider
            | Wallpaper
            | WebNavigation
            | WebRequest
            | WebRequestBlocking

        type [<AllowNullLiteral>] SearchProvider =
            abstract name: string option with get, set
            abstract keyword: string option with get, set
            abstract favicon_url: string option with get, set
            abstract search_url: string with get, set
            abstract encoding: string option with get, set
            abstract suggest_url: string option with get, set
            abstract instant_url: string option with get, set
            abstract image_url: string option with get, set
            abstract search_url_post_params: string option with get, set
            abstract suggest_url_post_params: string option with get, set
            abstract instant_url_post_params: string option with get, set
            abstract image_url_post_params: string option with get, set
            abstract alternate_urls: ResizeArray<string> option with get, set
            abstract prepopulated_id: float option with get, set
            abstract is_default: bool option with get, set

        type [<AllowNullLiteral>] ManifestBase =
            abstract manifest_version: float with get, set
            abstract name: string with get, set
            abstract version: string with get, set
            abstract default_locale: string option with get, set
            abstract description: string option with get, set
            abstract icons: ManifestIcons option with get, set
            abstract author: string option with get, set
            abstract background_page: string option with get, set
            abstract chrome_settings_overrides: ManifestBaseChrome_settings_overrides option with get, set
            abstract chrome_ui_overrides: ManifestBaseChrome_ui_overrides option with get, set
            abstract chrome_url_overrides: ManifestBaseChrome_url_overrides option with get, set
            abstract commands: ManifestBaseCommands option with get, set
            abstract content_capabilities: ManifestBaseContent_capabilities option with get, set
            abstract content_scripts: ResizeArray<ManifestBaseContent_scripts> option with get, set
            abstract converted_from_user_script: bool option with get, set
            abstract current_locale: string option with get, set
            abstract devtools_page: string option with get, set
            abstract event_rules: ResizeArray<ManifestBaseEvent_rules> option with get, set
            abstract externally_connectable: ManifestBaseExternally_connectable option with get, set
            abstract file_browser_handlers: ResizeArray<ManifestBaseFile_browser_handlers> option with get, set
            abstract file_system_provider_capabilities: ManifestBaseFile_system_provider_capabilities option with get, set
            abstract homepage_url: string option with get, set
            abstract import: ResizeArray<ManifestBaseImport> option with get, set
            abstract export: ManifestBaseExport option with get, set
            abstract incognito: string option with get, set
            abstract input_components: ResizeArray<ManifestBaseInput_components> option with get, set
            abstract key: string option with get, set
            abstract minimum_chrome_version: string option with get, set
            abstract nacl_modules: ResizeArray<ManifestBaseNacl_modules> option with get, set
            abstract oauth2: ManifestBaseOauth2 option with get, set
            abstract offline_enabled: bool option with get, set
            abstract omnibox: ManifestBaseOmnibox option with get, set
            abstract options_page: string option with get, set
            abstract options_ui: ManifestBaseOptions_ui option with get, set
            abstract platforms: ResizeArray<ManifestBasePlatforms> option with get, set
            abstract plugins: ResizeArray<ManifestBasePlugins> option with get, set
            abstract requirements: ManifestBaseRequirements option with get, set
            abstract sandbox: ManifestBaseSandbox option with get, set
            abstract short_name: string option with get, set
            abstract spellcheck: ManifestBaseSpellcheck option with get, set
            abstract storage: ManifestBaseStorage option with get, set
            abstract tts_engine: ManifestBaseTts_engine option with get, set
            abstract update_url: string option with get, set
            abstract version_name: string option with get, set
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] ManifestV2 =
            inherit ManifestBase
            abstract manifest_version: obj with get, set
            abstract browser_action: ManifestAction option with get, set
            abstract page_action: ManifestAction option with get, set
            abstract background: ManifestV2Background option with get, set
            abstract content_security_policy: string option with get, set
            abstract optional_permissions: ResizeArray<string> option with get, set
            abstract permissions: ResizeArray<string> option with get, set
            abstract web_accessible_resources: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestV3 =
            inherit ManifestBase
            abstract manifest_version: obj with get, set
            abstract action: ManifestAction option with get, set
            abstract background: ManifestV3Background option with get, set
            abstract content_security_policy: ManifestV3Content_security_policy option with get, set
            abstract host_permissions: ResizeArray<string> option with get, set
            abstract optional_permissions: ResizeArray<ManifestPermissions> option with get, set
            abstract permissions: ResizeArray<ManifestPermissions> option with get, set
            abstract web_accessible_resources: ResizeArray<ManifestV3Web_accessible_resources> option with get, set

        type Manifest =
            U2<ManifestV2, ManifestV3>

        type [<AllowNullLiteral>] ManifestBaseChrome_settings_overrides =
            abstract homepage: string option with get, set
            abstract search_provider: SearchProvider option with get, set
            abstract startup_pages: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseChrome_ui_overridesBookmarks_ui =
            abstract remove_bookmark_shortcut: bool option with get, set
            abstract remove_button: bool option with get, set

        type [<AllowNullLiteral>] ManifestBaseChrome_ui_overrides =
            abstract bookmarks_ui: ManifestBaseChrome_ui_overridesBookmarks_ui option with get, set

        type [<AllowNullLiteral>] ManifestBaseChrome_url_overrides =
            abstract bookmarks: string option with get, set
            abstract history: string option with get, set
            abstract newtab: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseCommandsItemSuggested_key =
            abstract ``default``: string option with get, set
            abstract windows: string option with get, set
            abstract mac: string option with get, set
            abstract chromeos: string option with get, set
            abstract linux: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseCommandsItem =
            abstract suggested_key: ManifestBaseCommandsItemSuggested_key option with get, set
            abstract description: string option with get, set
            abstract ``global``: bool option with get, set

        type [<AllowNullLiteral>] ManifestBaseCommands =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> ManifestBaseCommandsItem with get, set

        type [<AllowNullLiteral>] ManifestBaseContent_capabilities =
            abstract matches: ResizeArray<string> option with get, set
            abstract permissions: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseContent_scripts =
            abstract matches: ResizeArray<string> option with get, set
            abstract exclude_matches: ResizeArray<string> option with get, set
            abstract css: ResizeArray<string> option with get, set
            abstract js: ResizeArray<string> option with get, set
            abstract run_at: string option with get, set
            abstract all_frames: bool option with get, set
            abstract match_about_blank: bool option with get, set
            abstract include_globs: ResizeArray<string> option with get, set
            abstract exclude_globs: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseEvent_rulesActions =
            abstract ``type``: string with get, set

        type [<AllowNullLiteral>] ManifestBaseEvent_rules =
            abstract ``event``: string option with get, set
            abstract actions: ResizeArray<ManifestBaseEvent_rulesActions> option with get, set
            abstract conditions: ResizeArray<Chrome.DeclarativeContent.PageStateMatcherProperties> option with get, set

        type [<AllowNullLiteral>] ManifestBaseExternally_connectable =
            abstract ids: ResizeArray<string> option with get, set
            abstract matches: ResizeArray<string> option with get, set
            abstract accepts_tls_channel_id: bool option with get, set

        type [<AllowNullLiteral>] ManifestBaseFile_browser_handlers =
            abstract id: string option with get, set
            abstract default_title: string option with get, set
            abstract file_filters: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseFile_system_provider_capabilities =
            abstract configurable: bool option with get, set
            abstract watchable: bool option with get, set
            abstract multiple_mounts: bool option with get, set
            abstract source: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseImport =
            abstract id: string with get, set
            abstract minimum_version: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseExport =
            abstract whitelist: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseInput_components =
            abstract name: string option with get, set
            abstract ``type``: string option with get, set
            abstract id: string option with get, set
            abstract description: string option with get, set
            abstract language: U2<ResizeArray<string>, string> option with get, set
            abstract layouts: ResizeArray<string> option with get, set
            abstract indicator: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseNacl_modules =
            abstract path: string with get, set
            abstract mime_type: string with get, set

        type [<AllowNullLiteral>] ManifestBaseOauth2 =
            abstract client_id: string with get, set
            abstract scopes: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseOmnibox =
            abstract keyword: string with get, set

        type [<AllowNullLiteral>] ManifestBaseOptions_ui =
            abstract page: string option with get, set
            abstract chrome_style: bool option with get, set
            abstract open_in_tab: bool option with get, set

        type [<AllowNullLiteral>] ManifestBasePlatforms =
            abstract nacl_arch: string option with get, set
            abstract sub_package_path: string with get, set

        type [<AllowNullLiteral>] ManifestBasePlugins =
            abstract path: string with get, set

        type [<AllowNullLiteral>] ManifestBaseRequirements3D =
            abstract features: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseRequirementsPlugins =
            abstract npapi: bool option with get, set

        type [<AllowNullLiteral>] ManifestBaseRequirements =
            abstract ``3D``: ManifestBaseRequirements3D option with get, set
            abstract plugins: ManifestBaseRequirementsPlugins option with get, set

        type [<AllowNullLiteral>] ManifestBaseSandbox =
            abstract pages: ResizeArray<string> with get, set
            abstract content_security_policy: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseSpellcheck =
            abstract dictionary_language: string option with get, set
            abstract dictionary_locale: string option with get, set
            abstract dictionary_format: string option with get, set
            abstract dictionary_path: string option with get, set

        type [<AllowNullLiteral>] ManifestBaseStorage =
            abstract managed_schema: string with get, set

        type [<AllowNullLiteral>] ManifestBaseTts_engineVoices =
            abstract voice_name: string with get, set
            abstract lang: string option with get, set
            abstract gender: string option with get, set
            abstract event_types: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] ManifestBaseTts_engine =
            abstract voices: ResizeArray<ManifestBaseTts_engineVoices> with get, set

        type [<AllowNullLiteral>] ManifestV2Background =
            abstract scripts: ResizeArray<string> option with get, set
            abstract page: string option with get, set
            abstract persistent: bool option with get, set

        type [<AllowNullLiteral>] ManifestV3Background =
            abstract service_worker: string with get, set
            abstract ``type``: string option with get, set

        type [<AllowNullLiteral>] ManifestV3Content_security_policy =
            abstract extension_pages: string option with get, set
            abstract sandbox: string option with get, set

        type [<AllowNullLiteral>] ManifestV3Web_accessible_resources =
            abstract resources: ResizeArray<string> with get, set
            abstract matches: ResizeArray<string> with get, set

    module Scripting =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Injects a script into a target context. The script will be run at document_end.</summary>
            /// <param name="injection">The details of the script which to inject.</param>
            // abstract executeScript: injection: ScriptInjection<'Args, 'Result> -> Promise<ResizeArray<InjectionResult<Awaited<'Result>>>>
            /// <summary>Injects a script into a target context. The script will be run at document_end.</summary>
            /// <param name="injection">The details of the script which to inject.</param>
            /// <param name="callback">Invoked upon completion of the injection. The resulting array contains the result of execution for each frame where the injection succeeded.</param>
            // abstract executeScript: injection: ScriptInjection<'Args, 'Result> * ?callback: (ResizeArray<InjectionResult<Awaited<'Result>>> -> unit) -> unit
            /// <summary>Inserts a CSS stylesheet into a target context. If multiple frames are specified, unsuccessful injections are ignored.</summary>
            /// <param name="injection">The details of the styles to insert.</param>
            abstract insertCSS: injection: CSSInjection -> Promise<unit>
            /// <summary>Inserts a CSS stylesheet into a target context. If multiple frames are specified, unsuccessful injections are ignored.</summary>
            /// <param name="injection">The details of the styles to insert.</param>
            /// <param name="callback">Invoked upon completion of the injection.</param>
            abstract insertCSS: injection: CSSInjection * ?callback: (unit -> unit) -> unit

        type [<StringEnum>] [<RequireQualifiedAccess>] StyleOrigin =
            | [<CompiledName "AUTHOR">] AUTHOR
            | [<CompiledName "USER">] USER

        type [<StringEnum>] [<RequireQualifiedAccess>] ExecutionWorld =
            | [<CompiledName "ISOLATED">] ISOLATED
            | [<CompiledName "MAIN">] MAIN

        type [<AllowNullLiteral>] InjectionResult<'T> =
            abstract frameId: float with get, set
            abstract result: 'T with get, set

        type [<AllowNullLiteral>] InjectionTarget =
            abstract allFrames: bool option with get, set
            abstract frameIds: ResizeArray<float> option with get, set
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] CSSInjection =
            abstract css: string option with get, set
            abstract files: ResizeArray<string> option with get, set
            abstract origin: StyleOrigin option with get, set
            abstract target: InjectionTarget with get, set

        type [<AllowNullLiteral>] ScriptInjection<'Args, 'Result> =
            interface end

        // type Awaited<'T> =
        //     obj

    module ScriptBadge =

        type [<AllowNullLiteral>] IExports =
            abstract getPopup: details: GetPopupDetails * callback: Function -> unit
            abstract getAttention: details: AttentionDetails -> unit
            abstract setPopup: details: SetPopupDetails -> unit
            abstract onClicked: ScriptBadgeClickedEvent

        type [<AllowNullLiteral>] GetPopupDetails =
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] AttentionDetails =
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] SetPopupDetails =
            abstract tabId: float with get, set
            abstract popup: string with get, set

        type [<AllowNullLiteral>] ScriptBadgeClickedEvent =
            inherit Chrome.Events.Event<(Chrome.Tabs.Tab -> unit)>

    module Sessions =

        type [<AllowNullLiteral>] IExports =
            abstract MAX_SESSION_RESULTS: float
            /// <summary>Gets the list of recently closed tabs and/or windows.</summary>
            /// <param name="callback">Parameter sessions: The list of closed entries in reverse order that they were closed (the most recently closed tab or window will be at index 0). The entries may contain either tabs or windows.</param>
            abstract getRecentlyClosed: filter: Filter * callback: (ResizeArray<Session> -> unit) -> unit
            /// <summary>Gets the list of recently closed tabs and/or windows.</summary>
            /// <param name="callback">Parameter sessions: The list of closed entries in reverse order that they were closed (the most recently closed tab or window will be at index 0). The entries may contain either tabs or windows.</param>
            abstract getRecentlyClosed: callback: (ResizeArray<Session> -> unit) -> unit
            /// <summary>Retrieves all devices with synced sessions.</summary>
            /// <param name="callback">Parameter devices: The list of sessions.Device objects for each synced session, sorted in order from device with most recently modified session to device with least recently modified session. tabs.Tab objects are sorted by recency in the windows.Window of the sessions.Session objects.</param>
            abstract getDevices: filter: Filter * callback: (ResizeArray<Device> -> unit) -> unit
            /// <summary>Retrieves all devices with synced sessions.</summary>
            /// <param name="callback">Parameter devices: The list of sessions.Device objects for each synced session, sorted in order from device with most recently modified session to device with least recently modified session. tabs.Tab objects are sorted by recency in the windows.Window of the sessions.Session objects.</param>
            abstract getDevices: callback: (ResizeArray<Device> -> unit) -> unit
            /// <summary>Reopens a windows.Window or tabs.Tab, with an optional callback to run when the entry has been restored.</summary>
            /// <param name="sessionId">Optional.
            /// The windows.Window.sessionId, or tabs.Tab.sessionId to restore. If this parameter is not specified, the most recently closed session is restored.</param>
            /// <param name="callback">Optional.
            /// Parameter restoredSession: A sessions.Session containing the restored windows.Window or tabs.Tab object.</param>
            abstract restore: ?sessionId: string * ?callback: (Session -> unit) -> unit
            abstract onChanged: SessionChangedEvent

        type [<AllowNullLiteral>] Filter =
            /// Optional.
            /// The maximum number of entries to be fetched in the requested list. Omit this parameter to fetch the maximum number of entries (sessions.MAX_SESSION_RESULTS).
            abstract maxResults: float option with get, set

        type [<AllowNullLiteral>] Session =
            /// The time when the window or tab was closed or modified, represented in milliseconds since the epoch.
            abstract lastModified: float with get, set
            /// Optional.
            /// The tabs.Tab, if this entry describes a tab. Either this or sessions.Session.window will be set.
            abstract tab: Tabs.Tab option with get, set
            /// Optional.
            /// The windows.Window, if this entry describes a window. Either this or sessions.Session.tab will be set.
            abstract window: Windows.Window option with get, set

        type [<AllowNullLiteral>] Device =
            /// The name of the foreign device.
            abstract deviceName: string with get, set
            /// A list of open window sessions for the foreign device, sorted from most recently to least recently modified session.
            abstract sessions: ResizeArray<Session> with get, set

        type [<AllowNullLiteral>] SessionChangedEvent =
            inherit Chrome.Events.Event<(unit -> unit)>

    module Storage =

        type [<AllowNullLiteral>] IExports =
            abstract local: LocalStorageArea
            abstract sync: SyncStorageArea
            abstract managed: StorageArea
            abstract session: SessionStorageArea
            abstract onChanged: StorageChangedEvent

        type [<AllowNullLiteral>] StorageArea =
            /// <summary>Gets the amount of space (in bytes) being used by one or more items.</summary>
            /// <param name="callback">Callback with the amount of space being used by storage, or on failure (in which case runtime.lastError will be set).
            /// Parameter bytesInUse: Amount of space being used in storage, in bytes.</param>
            abstract getBytesInUse: callback: (float -> unit) -> unit
            /// <summary>Gets the amount of space (in bytes) being used by one or more items.</summary>
            /// <param name="keys">Optional. A single key or list of keys to get the total usage for. An empty list will return 0. Pass in null to get the total usage of all of storage.</param>
            abstract getBytesInUse: ?keys: U2<string, ResizeArray<string>> -> Promise<float>
            /// <summary>Gets the amount of space (in bytes) being used by one or more items.</summary>
            /// <param name="keys">Optional. A single key or list of keys to get the total usage for. An empty list will return 0. Pass in null to get the total usage of all of storage.</param>
            /// <param name="callback">Callback with the amount of space being used by storage, or on failure (in which case runtime.lastError will be set).
            /// Parameter bytesInUse: Amount of space being used in storage, in bytes.</param>
            abstract getBytesInUse: keys: U2<string, ResizeArray<string>> option * callback: (float -> unit) -> unit
            /// Removes all items from storage.
            abstract clear: unit -> Promise<unit>
            /// <summary>Removes all items from storage.</summary>
            /// <param name="callback">Optional.
            /// Callback on success, or on failure (in which case runtime.lastError will be set).</param>
            abstract clear: ?callback: (unit -> unit) -> unit
            /// <summary>Sets multiple items.</summary>
            /// <param name="items">An object which gives each key/value pair to update storage with. Any other key/value pairs in storage will not be affected.
            /// Primitive values such as numbers will serialize as expected. Values with a typeof "object" and "function" will typically serialize to {}, with the exception of Array (serializes as expected), Date, and Regex (serialize using their String representation).</param>
            abstract set: items: obj -> Promise<unit>
            /// <summary>Sets multiple items.</summary>
            /// <param name="items">An object which gives each key/value pair to update storage with. Any other key/value pairs in storage will not be affected.
            /// Primitive values such as numbers will serialize as expected. Values with a typeof "object" and "function" will typically serialize to {}, with the exception of Array (serializes as expected), Date, and Regex (serialize using their String representation).</param>
            /// <param name="callback">Optional.
            /// Callback on success, or on failure (in which case runtime.lastError will be set).</param>
            abstract set: items: StorageAreaSetItems_ * ?callback: (unit -> unit) -> unit
            /// <summary>Removes one or more items from storage.</summary>
            /// <param name="keys">A single key or a list of keys for items to remove.</param>
            abstract remove: keys: U2<string, ResizeArray<string>> -> Promise<unit>
            /// <summary>Removes one or more items from storage.</summary>
            /// <param name="keys">A single key or a list of keys for items to remove.</param>
            /// <param name="callback">Optional.
            /// Callback on success, or on failure (in which case runtime.lastError will be set).</param>
            abstract remove: keys: U2<string, ResizeArray<string>> * ?callback: (unit -> unit) -> unit
            /// <summary>Gets the entire contents of storage.</summary>
            /// <param name="callback">Callback with storage items, or on failure (in which case runtime.lastError will be set).
            /// Parameter items: Object with items in their key-value mappings.</param>
            abstract get: callback: (StorageAreaGet -> unit) -> unit
            /// <summary>Gets one or more items from storage.</summary>
            /// <param name="keys">A single key to get, list of keys to get, or a dictionary specifying default values.
            /// An empty list or object will return an empty result object. Pass in null to get the entire contents of storage.</param>
            abstract get: ?keys: ResizeArray<string> -> Promise<StorageAreaGet>
            /// <summary>Gets one or more items from storage.</summary>
            /// <param name="keys">A single key to get, list of keys to get, or a dictionary specifying default values.
            /// An empty list or object will return an empty result object. Pass in null to get the entire contents of storage.</param>
            /// <param name="callback">Callback with storage items, or on failure (in which case runtime.lastError will be set).
            /// Parameter items: Object with items in their key-value mappings.</param>
            abstract get: keys: ResizeArray<string> option * callback: (StorageAreaGet -> unit) -> unit

        type [<AllowNullLiteral>] StorageAreaSetItems =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] StorageAreaSetItems_ =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] StorageChange =
            /// Optional. The new value of the item, if there is a new value.
            abstract newValue: obj option with get, set
            /// Optional. The old value of the item, if there was an old value.
            abstract oldValue: obj option with get, set

        type [<AllowNullLiteral>] LocalStorageArea =
            inherit StorageArea
            /// The maximum amount (in bytes) of data that can be stored in local storage, as measured by the JSON stringification of every value plus every key's length. This value will be ignored if the extension has the unlimitedStorage permission. Updates that would cause this limit to be exceeded fail immediately and set runtime.lastError.
            abstract QUOTA_BYTES: float with get, set

        type [<AllowNullLiteral>] SyncStorageArea =
            inherit StorageArea
            abstract MAX_SUSTAINED_WRITE_OPERATIONS_PER_MINUTE: float with get, set
            /// The maximum total amount (in bytes) of data that can be stored in sync storage, as measured by the JSON stringification of every value plus every key's length. Updates that would cause this limit to be exceeded fail immediately and set runtime.lastError.
            abstract QUOTA_BYTES: float with get, set
            /// The maximum size (in bytes) of each individual item in sync storage, as measured by the JSON stringification of its value plus its key length. Updates containing items larger than this limit will fail immediately and set runtime.lastError.
            abstract QUOTA_BYTES_PER_ITEM: float with get, set
            /// The maximum number of items that can be stored in sync storage. Updates that would cause this limit to be exceeded will fail immediately and set runtime.lastError.
            abstract MAX_ITEMS: float with get, set
            /// The maximum number of set, remove, or clear operations that can be performed each hour. This is 1 every 2 seconds, a lower ceiling than the short term higher writes-per-minute limit.
            /// Updates that would cause this limit to be exceeded fail immediately and set runtime.lastError.
            abstract MAX_WRITE_OPERATIONS_PER_HOUR: float with get, set
            /// The maximum number of set, remove, or clear operations that can be performed each minute. This is 2 per second, providing higher throughput than writes-per-hour over a shorter period of time.
            /// Updates that would cause this limit to be exceeded fail immediately and set runtime.lastError.
            abstract MAX_WRITE_OPERATIONS_PER_MINUTE: float with get, set

        type [<AllowNullLiteral>] SessionStorageArea =
            inherit StorageArea
            /// The maximum amount (in bytes) of data that can be stored in memory, as measured by estimating the dynamically allocated memory usage of every value and key. Updates that would cause this limit to be exceeded fail immediately and set runtime.lastError.
            abstract QUOTA_BYTES: float with get, set

        type AreaName =
            obj

        type [<AllowNullLiteral>] StorageChangedEvent =
            inherit Chrome.Events.Event<(StorageChangedEventChromeEventsEvent -> AreaName -> unit)>

        type [<AllowNullLiteral>] StorageAreaGet =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] StorageChangedEventChromeEventsEvent =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> StorageChange with get, set

    module Socket =

        type [<AllowNullLiteral>] IExports =
            abstract create: ``type``: string * ?options: Object * ?callback: (CreateInfo -> unit) -> unit
            abstract destroy: socketId: float -> unit
            abstract connect: socketId: float * hostname: string * port: float * callback: (float -> unit) -> unit
            abstract bind: socketId: float * address: string * port: float * callback: (float -> unit) -> unit
            abstract disconnect: socketId: float -> unit
            abstract read: socketId: float * ?bufferSize: float * ?callback: (ReadInfo -> unit) -> unit
            abstract write: socketId: float * data: ArrayBuffer * ?callback: (WriteInfo -> unit) -> unit
            abstract recvFrom: socketId: float * ?bufferSize: float * ?callback: (RecvFromInfo -> unit) -> unit
            abstract sendTo: socketId: float * data: ArrayBuffer * address: string * port: float * ?callback: (WriteInfo -> unit) -> unit
            abstract listen: socketId: float * address: string * port: float * ?backlog: float * ?callback: (float -> unit) -> unit
            abstract accept: socketId: float * ?callback: (AcceptInfo -> unit) -> unit
            abstract setKeepAlive: socketId: float * enable: bool * ?delay: float * ?callback: (bool -> unit) -> unit
            abstract setNoDelay: socketId: float * noDelay: bool * ?callback: (bool -> unit) -> unit
            abstract getInfo: socketId: float * callback: (SocketInfo -> unit) -> unit
            abstract getNetworkList: callback: (ResizeArray<NetworkInterface> -> unit) -> unit

        type [<AllowNullLiteral>] CreateInfo =
            abstract socketId: float with get, set

        type [<AllowNullLiteral>] AcceptInfo =
            abstract resultCode: float with get, set
            abstract socketId: float option with get, set

        type [<AllowNullLiteral>] ReadInfo =
            abstract resultCode: float with get, set
            abstract data: ArrayBuffer with get, set

        type [<AllowNullLiteral>] WriteInfo =
            abstract bytesWritten: float with get, set

        type [<AllowNullLiteral>] RecvFromInfo =
            abstract resultCode: float with get, set
            abstract data: ArrayBuffer with get, set
            abstract port: float with get, set
            abstract address: string with get, set

        type [<AllowNullLiteral>] SocketInfo =
            abstract socketType: string with get, set
            abstract localPort: float option with get, set
            abstract peerAddress: string option with get, set
            abstract peerPort: float option with get, set
            abstract localAddress: string option with get, set
            abstract connected: bool with get, set

        type [<AllowNullLiteral>] NetworkInterface =
            abstract name: string with get, set
            abstract address: string with get, set

    module System =
        let [<Import("cpu","chrome/chrome/system")>] cpu: Cpu.IExports = jsNative
        let [<Import("memory","chrome/chrome/system")>] memory: Memory.IExports = jsNative
        let [<Import("storage","chrome/chrome/system")>] storage: Storage.IExports = jsNative
        let [<Import("display","chrome/chrome/system")>] display: Display.IExports = jsNative

        module Cpu =

            type [<AllowNullLiteral>] IExports =
                /// Queries basic CPU information of the system.
                abstract getInfo: callback: (CpuInfo -> unit) -> unit
                /// Queries basic CPU information of the system.
                abstract getInfo: unit -> Promise<CpuInfo>

            type [<AllowNullLiteral>] ProcessorUsage =
                /// The cumulative time used by userspace programs on this processor.
                abstract user: float with get, set
                /// The cumulative time used by kernel programs on this processor.
                abstract kernel: float with get, set
                /// The cumulative time spent idle by this processor.
                abstract idle: float with get, set
                /// The total cumulative time for this processor. This value is equal to user + kernel + idle.
                abstract total: float with get, set

            type [<AllowNullLiteral>] ProcessorInfo =
                /// Cumulative usage info for this logical processor.
                abstract usage: ProcessorUsage with get, set

            type [<AllowNullLiteral>] CpuInfo =
                /// The number of logical processors.
                abstract numOfProcessors: float with get, set
                /// The architecture name of the processors.
                abstract archName: string with get, set
                /// The model name of the processors.
                abstract modelName: string with get, set
                /// A set of feature codes indicating some of the processor's capabilities.
                /// The currently supported codes are "mmx", "sse", "sse2", "sse3", "ssse3", "sse4_1", "sse4_2", and "avx".
                abstract features: ResizeArray<string> with get, set
                /// Information about each logical processor.
                abstract processors: ResizeArray<ProcessorInfo> with get, set

        module Memory =

            type [<AllowNullLiteral>] IExports =
                /// Get physical memory information.
                abstract getInfo: callback: (MemoryInfo -> unit) -> unit
                /// Get physical memory information.
                abstract getInfo: unit -> Promise<MemoryInfo>

            type [<AllowNullLiteral>] MemoryInfo =
                /// The total amount of physical memory capacity, in bytes.
                abstract capacity: float with get, set
                /// The amount of available capacity, in bytes.
                abstract availableCapacity: float with get, set

        module Storage =

            type [<AllowNullLiteral>] IExports =
                /// Get the storage information from the system. The argument passed to the callback is an array of StorageUnitInfo objects.
                abstract getInfo: callback: (ResizeArray<StorageUnitInfo> -> unit) -> unit
                /// Get the storage information from the system. The argument passed to the callback is an array of StorageUnitInfo objects.
                abstract getInfo: unit -> Promise<ResizeArray<StorageUnitInfo>>
                /// <summary>Ejects a removable storage device.</summary>
                /// <param name="callback">Parameter result: success: The ejection command is successful -- the application can prompt the user to remove the device; in_use: The device is in use by another application. The ejection did not succeed; the user should not remove the device until the other application is done with the device; no_such_device: There is no such device known. failure: The ejection command failed.</param>
                abstract ejectDevice: id: string * callback: (string -> unit) -> unit
                /// Ejects a removable storage device.
                abstract ejectDevice: id: string -> Promise<string>
                /// Get the available capacity of a specified |id| storage device. The |id| is the transient device ID from StorageUnitInfo.
                abstract getAvailableCapacity: id: string * callback: (StorageCapacityInfo -> unit) -> unit
                /// Get the available capacity of a specified |id| storage device. The |id| is the transient device ID from StorageUnitInfo.
                abstract getAvailableCapacity: id: string -> Promise<StorageCapacityInfo>
                abstract onAttached: SystemStorageAttachedEvent
                abstract onDetached: SystemStorageDetachedEvent

            type [<AllowNullLiteral>] StorageUnitInfo =
                /// The transient ID that uniquely identifies the storage device. This ID will be persistent within the same run of a single application. It will not be a persistent identifier between different runs of an application, or between different applications.
                abstract id: string with get, set
                /// The name of the storage unit.
                abstract name: string with get, set
                /// The media type of the storage unit.
                /// fixed: The storage has fixed media, e.g. hard disk or SSD.
                /// removable: The storage is removable, e.g. USB flash drive.
                /// unknown: The storage type is unknown.
                abstract ``type``: string with get, set
                /// The total amount of the storage space, in bytes.
                abstract capacity: float with get, set

            type [<AllowNullLiteral>] StorageCapacityInfo =
                /// A copied |id| of getAvailableCapacity function parameter |id|.
                abstract id: string with get, set
                /// The available capacity of the storage device, in bytes.
                abstract availableCapacity: float with get, set

            type [<AllowNullLiteral>] SystemStorageAttachedEvent =
                inherit Chrome.Events.Event<(StorageUnitInfo -> unit)>

            type [<AllowNullLiteral>] SystemStorageDetachedEvent =
                inherit Chrome.Events.Event<(string -> unit)>

        module Display =

            type [<AllowNullLiteral>] IExports =
                abstract DisplayPosition: IExportsDisplayPosition
                abstract MirrorMode: IExportsMirrorMode
                /// <summary>Requests the information for all attached display devices.</summary>
                /// <param name="callback">The callback to invoke with the results.</param>
                abstract getInfo: callback: (ResizeArray<DisplayInfo> -> unit) -> unit
                /// Requests the information for all attached display devices.
                abstract getInfo: unit -> Promise<ResizeArray<DisplayInfo>>
                /// <summary>Requests the information for all attached display devices.</summary>
                /// <param name="flags">Options affecting how the information is returned.</param>
                /// <param name="callback">The callback to invoke with the results.</param>
                abstract getInfo: flags: DisplayInfoFlags * callback: (ResizeArray<DisplayInfo> -> unit) -> unit
                /// <summary>Requests the information for all attached display devices.</summary>
                /// <param name="flags">Options affecting how the information is returned.</param>
                abstract getInfo: flags: DisplayInfoFlags -> Promise<ResizeArray<DisplayInfo>>
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="callback">The callback to invoke with the results.</param>
                abstract getDisplayLayout: callback: (ResizeArray<DisplayLayout> -> unit) -> unit
                /// requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.
                abstract getDisplayLayout: unit -> Promise<ResizeArray<DisplayLayout>>
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="id">The display's unique identifier.</param>
                /// <param name="info">The information about display properties that should be changed. A property will be changed only if a new value for it is specified in |info|.</param>
                abstract setDisplayProperties: id: string * info: DisplayPropertiesInfo -> Promise<unit>
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="id">The display's unique identifier.</param>
                /// <param name="info">The information about display properties that should be changed. A property will be changed only if a new value for it is specified in |info|.</param>
                /// <param name="callback">Empty function called when the function finishes. To find out whether the function succeeded, runtime.lastError should be queried.</param>
                abstract setDisplayProperties: id: string * info: DisplayPropertiesInfo * ?callback: (unit -> unit) -> unit
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="layouts">The layout information, required for all displays except the primary display.</param>
                abstract setDisplayLayout: layouts: ResizeArray<DisplayLayout> -> Promise<unit>
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="layouts">The layout information, required for all displays except the primary display.</param>
                /// <param name="callback">Empty function called when the function finishes. To find out whether the function succeeded, runtime.lastError should be queried.</param>
                abstract setDisplayLayout: layouts: ResizeArray<DisplayLayout> * ?callback: (unit -> unit) -> unit
                /// <summary>requires(CrOS Kiosk apps | WebUI) This is only available to Chrome OS Kiosk apps and Web UI.</summary>
                /// <param name="enabled">True if unified desktop should be enabled.</param>
                abstract enableUnifiedDesktop: enabled: bool -> unit
                /// <summary>Starts overscan calibration for a display.
                /// This will show an overlay on the screen indicating the current overscan insets.
                /// If overscan calibration for display **id** is in progress this will reset calibration.</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract overscanCalibrationStart: id: string -> unit
                /// <summary>Adjusts the current overscan insets for a display.
                /// Typically this should etiher move the display along an axis (e.g. left+right have the same value)
                /// or scale it along an axis (e.g. top+bottom have opposite values).
                /// Each Adjust call is cumulative with previous calls since Start.</summary>
                /// <param name="id">The display's unique identifier.</param>
                /// <param name="delta">The amount to change the overscan insets.</param>
                abstract overscanCalibrationAdjust: id: string * delta: Insets -> unit
                /// <summary>Resets the overscan insets for a display to the last saved value (i.e before Start was called).</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract overscanCalibrationReset: id: string -> unit
                /// <summary>Complete overscan adjustments for a display by saving the current values and hiding the overlay.</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract overscanCalibrationComplete: id: string -> unit
                /// <summary>Displays the native touch calibration UX for the display with **id** as display id.
                /// This will show an overlay on the screen with required instructions on how to proceed.
                /// The callback will be invoked in case of successful calibraion only.
                /// If the calibration fails, this will throw an error.</summary>
                /// <param name="id">The display's unique identifier.</param>
                /// <param name="callback">Optional callback to inform the caller that the touch calibration has ended. The argument of the callback informs if the calibration was a success or not.</param>
                abstract showNativeTouchCalibration: id: string * callback: (bool -> unit) -> unit
                /// <summary>Displays the native touch calibration UX for the display with **id** as display id.
                /// This will show an overlay on the screen with required instructions on how to proceed.
                /// The callback will be invoked in case of successful calibraion only.
                /// If the calibration fails, this will throw an error.</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract showNativeTouchCalibration: id: string -> Promise<bool>
                /// <summary>Starts custom touch calibration for a display.
                /// This should be called when using a custom UX for collecting calibration data.
                /// If another touch calibration is already in progress this will throw an error.</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract startCustomTouchCalibration: id: string -> unit
                /// <summary>Sets the touch calibration pairs for a display.
                /// These **pairs** would be used to calibrate the touch screen for display with **id** called in startCustomTouchCalibration().
                /// Always call **startCustomTouchCalibration** before calling this method.
                /// If another touch calibration is already in progress this will throw an error.</summary>
                /// <param name="pairs">The pairs of point used to calibrate the display.</param>
                /// <param name="bounds">Bounds of the display when the touch calibration was performed. |bounds.left| and |bounds.top| values are ignored.</param>
                abstract completeCustomTouchCalibration: pairs: TouchCalibrationPairs * bounds: Bounds -> unit
                /// <summary>Resets the touch calibration for the display and brings it back to its default state by clearing any touch calibration data associated with the display.</summary>
                /// <param name="id">The display's unique identifier.</param>
                abstract clearTouchCalibration: id: string -> unit
                /// requires(CrOS Kiosk app) Chrome OS Kiosk apps only
                abstract setMirrorMode: info: U2<MirrorModeInfo, MirrorModeInfoMixed> * callback: (unit -> unit) -> unit
                /// requires(CrOS Kiosk app) Chrome OS Kiosk apps only
                abstract setMirrorMode: info: U2<MirrorModeInfo, MirrorModeInfoMixed> -> Promise<unit>
                abstract onDisplayChanged: Chrome.Events.Event<(unit -> unit)>

            type [<AllowNullLiteral>] Bounds =
                /// The x-coordinate of the upper-left corner.
                abstract left: float with get, set
                /// The y-coordinate of the upper-left corner.
                abstract top: float with get, set
                /// The width of the display in pixels.
                abstract width: float with get, set
                /// The height of the display in pixels.
                abstract height: float with get, set

            type [<AllowNullLiteral>] Insets =
                /// The x-axis distance from the left bound.
                abstract left: float with get, set
                /// The y-axis distance from the top bound.
                abstract top: float with get, set
                /// The x-axis distance from the right bound.
                abstract right: float with get, set
                /// The y-axis distance from the bottom bound.
                abstract bottom: float with get, set

            type [<AllowNullLiteral>] Point =
                /// The x-coordinate of the point.
                abstract x: float with get, set
                /// The y-coordinate of the point.
                abstract y: float with get, set

            type [<AllowNullLiteral>] TouchCalibrationPair =
                /// The coordinates of the display point.
                abstract displayPoint: Point with get, set
                /// The coordinates of the touch point corresponding to the display point.
                abstract touchPoint: Point with get, set

            type [<AllowNullLiteral>] DisplayMode =
                /// The display mode width in device independent (user visible) pixels.
                abstract width: float with get, set
                /// The display mode height in device independent (user visible) pixels.
                abstract height: float with get, set
                /// The display mode width in native pixels.
                abstract widthInNativePixels: float with get, set
                /// The display mode height in native pixels.
                abstract heightInNativePixels: float with get, set
                abstract uiScale: float with get, set
                /// The display mode device scale factor.
                abstract deviceScaleFactor: float with get, set
                /// The display mode refresh rate in hertz.
                abstract refreshRate: float with get, set
                /// True if the mode is the display's native mode.
                abstract isNative: bool with get, set
                /// True if the display mode is currently selected.
                abstract isSelected: bool with get, set

            type [<AllowNullLiteral>] DisplayLayout =
                /// The unique identifier of the display.
                abstract id: string with get, set
                /// The unique identifier of the parent display. Empty if this is the root.
                abstract parentId: string with get, set
                /// The layout position of this display relative to the parent.
                /// This will be ignored for the root.
                abstract position: obj with get, set
                /// The offset of the display along the connected edge. 0 indicates that the topmost or leftmost corners are aligned.
                abstract offset: float with get, set

            /// The pairs of point used to calibrate the display.
            type [<AllowNullLiteral>] TouchCalibrationPairs =
                /// First pair of touch and display point required for touch calibration.
                abstract pair1: TouchCalibrationPair with get, set
                /// Second pair of touch and display point required for touch calibration.
                abstract pair2: TouchCalibrationPair with get, set
                /// Third pair of touch and display point required for touch calibration.
                abstract pair3: TouchCalibrationPair with get, set
                /// Fourth pair of touch and display point required for touch calibration.
                abstract pair4: TouchCalibrationPair with get, set

            /// Representation of info data to be used in chrome.system.display.setDisplayProperties()
            type [<AllowNullLiteral>] DisplayPropertiesInfo =
                /// requires(CrOS) Chrome OS only.
                abstract isUnified: bool option with get, set
                /// requires(CrOS) Chrome OS only.
                abstract mirroringSourceId: string option with get, set
                /// If set to true, makes the display primary.
                /// No-op if set to false.
                abstract isPrimary: bool option with get, set
                /// If set, sets the display's overscan insets to the provided values.
                /// Note that overscan values may not be negative or larger than a half of the screen's size.
                /// Overscan cannot be changed on the internal monitor. It's applied after isPrimary parameter.
                abstract overscan: Insets option with get, set
                /// If set, updates the display's rotation.
                /// Legal values are [0, 90, 180, 270].
                /// The rotation is set clockwise, relative to the display's vertical position.
                /// It's applied after overscan parameter.
                abstract rotation: DisplayPropertiesInfoRotation option with get, set
                /// If set, updates the display's logical bounds origin along x-axis.
                /// Applied together with boundsOriginY, if boundsOriginY is set.
                /// Note that, when updating the display origin, some constraints will be applied,
                /// so the final bounds origin may be different than the one set.
                /// The final bounds can be retrieved using getInfo. The bounds origin is applied
                /// after rotation. The bounds origin cannot be changed on the primary display.
                /// Note that is also invalid to set bounds origin values if isPrimary is also set
                /// (as isPrimary parameter is applied first).
                abstract boundsOriginX: float option with get, set
                /// If set, updates the display's logical bounds origin along y-axis.
                abstract boundsOriginY: float option with get, set
                /// If set, updates the display mode to the mode matching this value.
                abstract displayMode: DisplayMode option with get, set
                abstract displayZoomFactor: float option with get, set

            /// Options affecting how the information is returned.
            type [<AllowNullLiteral>] DisplayInfoFlags =
                /// If set to true, only a single DisplayUnitInfo will be returned by getInfo when in unified desktop mode.
                abstract singleUnified: bool option with get, set

            /// Information about display properties.
            type [<AllowNullLiteral>] DisplayInfo =
                /// The unique identifier of the display.
                abstract id: string with get, set
                /// The user-friendly name (e.g. 'HP LCD monitor').
                abstract name: string with get, set
                /// requires(CrOS Kiosk app) Only available in Chrome OS Kiosk apps
                abstract edid: DisplayInfoEdid option with get, set
                /// requires(CrOS) Only working properly on Chrome OS.
                /// Identifier of the display that is being mirrored on the display unit.
                /// If mirroring is not in progress, set to an empty string
                /// Currently exposed only on ChromeOS.
                /// Will be empty string on other platforms.
                abstract mirroringSourceId: string with get, set
                /// requires(CrOS) Only available on Chrome OS.
                /// Identifiers of the displays to which the source display is being mirrored.
                /// Empty if no displays are being mirrored. This will be set to the same value
                /// for all displays.
                /// ❗ This must not include *mirroringSourceId*. ❗
                abstract mirroringDestinationIds: ResizeArray<string> with get, set
                /// True if this is the primary display.
                abstract isPrimary: bool with get, set
                /// True if this is an internal display.
                abstract isInternal: bool with get, set
                /// True if this display is enabled.
                abstract isEnabled: bool with get, set
                /// The number of pixels per inch along the x-axis.
                abstract dpiX: float with get, set
                /// The number of pixels per inch along the y-axis.
                abstract dpiY: float with get, set
                /// The display's clockwise rotation in degrees relative to the vertical position. Currently exposed only on ChromeOS. Will be set to 0 on other platforms.
                abstract rotation: float with get, set
                /// The display's logical bounds.
                abstract bounds: Bounds with get, set
                /// The display's insets within its screen's bounds. Currently exposed only on ChromeOS. Will be set to empty insets on other platforms.
                abstract overscan: Insets with get, set
                /// The usable work area of the display within the display bounds. The work area excludes areas of the display reserved for OS, for example taskbar and launcher.
                abstract workArea: Bounds with get, set
                /// requires(CrOS) Only available on Chrome OS.
                /// The list of available display modes.
                /// The current mode will have isSelected=true.
                /// Only available on Chrome OS.
                /// Will be set to an empty array on other platforms.
                abstract modes: ResizeArray<DisplayMode> with get, set
                /// True if this display has a touch input device associated with it.
                abstract hasTouchSupport: bool with get, set
                /// A list of zoom factor values that can be set for the display.
                abstract availableDisplayZoomFactors: ResizeArray<float> with get, set
                /// The ratio between the display's current and default zoom.
                /// For example, value 1 is equivalent to 100% zoom, and value 1.5 is equivalent to 150% zoom.
                abstract displayZoomFactor: float with get, set

            type [<AllowNullLiteral>] MirrorModeInfo =
                /// The mirror mode that should be set.
                /// **off**
                /// Use the default mode (extended or unified desktop).
                /// **normal**
                /// The default source display will be mirrored to all other displays.
                /// **mixed**
                /// The specified source display will be mirrored to the provided destination displays. All other connected displays will be extended.
                abstract mode: MirrorModeInfoMode option with get, set

            type [<AllowNullLiteral>] MirrorModeInfoMixed =
                inherit MirrorModeInfo
                /// The mirror mode that should be set.
                /// **off**
                /// Use the default mode (extended or unified desktop).
                /// **normal**
                /// The default source display will be mirrored to all other displays.
                /// **mixed**
                /// The specified source display will be mirrored to the provided destination displays. All other connected displays will be extended.
                abstract mode: string with get, set
                abstract mirroringSourceId: string option with get, set
                /// The ids of the mirroring destination displays.
                abstract mirroringDestinationIds: ResizeArray<string> option with get, set

            type [<AllowNullLiteral>] IExportsDisplayPosition =
                abstract TOP: string with get, set
                abstract RIGHT: string with get, set
                abstract BOTTOM: string with get, set
                abstract LEFT: string with get, set

            type [<AllowNullLiteral>] IExportsMirrorMode =
                abstract OFF: string with get, set
                abstract NORMAL: string with get, set
                abstract MIXED: string with get, set

            type [<RequireQualifiedAccess>] DisplayPropertiesInfoRotation =
                | N0 = 0
                | N90 = 90
                | N180 = 180
                | N270 = 270

            type [<AllowNullLiteral>] DisplayInfoEdid =
                /// 3 character manufacturer code.
                abstract manufacturerId: string with get, set
                /// 2 byte manufacturer-assigned code.
                abstract productId: string with get, set
                /// Year of manufacturer.
                abstract yearOfManufacture: string option with get, set

            type [<StringEnum>] [<RequireQualifiedAccess>] MirrorModeInfoMode =
                | Off
                | Normal
                | Mixed

    module TabCapture =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Captures the visible area of the currently active tab. Capture can only be started on the currently active tab after the extension has been invoked. Capture is maintained across page navigations within the tab, and stops when the tab is closed, or the media stream is closed by the extension.</summary>
            /// <param name="options">Configures the returned media stream.</param>
            /// <param name="callback">Callback with either the tab capture stream or null.</param>
            // abstract capture: options: CaptureOptions * callback: (MediaStream option -> unit) -> unit
            /// <summary>Returns a list of tabs that have requested capture or are being captured, i.e. status != stopped and status != error. This allows extensions to inform the user that there is an existing tab capture that would prevent a new tab capture from succeeding (or to prevent redundant requests for the same tab).</summary>
            /// <param name="callback">Callback invoked with CaptureInfo[] for captured tabs.</param>
            abstract getCapturedTabs: callback: (ResizeArray<CaptureInfo> -> unit) -> unit
            /// <summary>Creates a stream ID to capture the target tab. Similar to chrome.tabCapture.capture() method, but returns a media stream ID, instead of a media stream, to the consumer tab.</summary>
            /// <param name="options">Options for the media stream id to retrieve.</param>
            /// <param name="callback">Callback to invoke with the result. If successful, the result is an opaque string that can be passed to the getUserMedia() API to generate a media stream that corresponds to the target tab. The created streamId can only be used once and expires after a few seconds if it is not used.</param>
            abstract getMediaStreamId: options: GetMediaStreamOptions * callback: (string -> unit) -> unit
            abstract onStatusChanged: CaptureStatusChangedEvent

        type [<AllowNullLiteral>] CaptureInfo =
            /// The id of the tab whose status changed.
            abstract tabId: float with get, set
            /// The new capture status of the tab.
            /// One of: "pending", "active", "stopped", or "error"
            abstract status: string with get, set
            /// Whether an element in the tab being captured is in fullscreen mode.
            abstract fullscreen: bool with get, set

        type [<AllowNullLiteral>] MediaStreamConstraint =
            abstract mandatory: obj with get, set
            abstract optional: obj option with get, set

        type [<AllowNullLiteral>] CaptureOptions =
            /// Optional.
            abstract audio: bool option with get, set
            /// Optional.
            abstract video: bool option with get, set
            /// Optional.
            abstract audioConstraints: MediaStreamConstraint option with get, set
            /// Optional.
            abstract videoConstraints: MediaStreamConstraint option with get, set

        type [<AllowNullLiteral>] GetMediaStreamOptions =
            /// Optional tab id of the tab which will later invoke getUserMedia() to consume the stream. If not specified then the resulting stream can be used only by the calling extension. The stream can only be used by frames in the given tab whose security origin matches the consumber tab's origin. The tab's origin must be a secure origin, e.g. HTTPS.
            abstract consumerTabId: float option with get, set
            /// Optional tab id of the tab which will be captured. If not specified then the current active tab will be selected. Only tabs for which the extension has been granted the activeTab permission can be used as the target tab.
            abstract targetTabId: float option with get, set

        type [<AllowNullLiteral>] CaptureStatusChangedEvent =
            inherit Chrome.Events.Event<(CaptureInfo -> unit)>

    module Tabs =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            abstract executeScript: details: InjectDetails -> Promise<ResizeArray<obj option>>
            /// <summary>Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            /// <param name="callback">Optional. Called after all the JavaScript has been executed.
            /// Parameter result: The result of the script in every injected frame.</param>
            abstract executeScript: details: InjectDetails * ?callback: (ResizeArray<obj option> -> unit) -> unit
            /// <summary>Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="tabId">Optional. The ID of the tab in which to run the script; defaults to the active tab of the current window.</param>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            abstract executeScript: tabId: float * details: InjectDetails -> Promise<ResizeArray<obj option>>
            /// <summary>Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="tabId">Optional. The ID of the tab in which to run the script; defaults to the active tab of the current window.</param>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            /// <param name="callback">Optional. Called after all the JavaScript has been executed.
            /// Parameter result: The result of the script in every injected frame.</param>
            abstract executeScript: tabId: float * details: InjectDetails * ?callback: (ResizeArray<obj option> -> unit) -> unit
            /// Retrieves details about the specified tab.
            abstract get: tabId: float * callback: (Tab -> unit) -> unit
            /// Retrieves details about the specified tab.
            abstract get: tabId: float -> Promise<Tab>
            /// Gets details about all tabs in the specified window.
            abstract getAllInWindow: callback: (Tab -> unit) -> unit
            /// Gets details about all tabs in the specified window.
            abstract getAllInWindow: unit -> Promise<Tab>
            /// <summary>Gets details about all tabs in the specified window.</summary>
            /// <param name="windowId">Optional. Defaults to the current window.</param>
            abstract getAllInWindow: windowId: float * callback: (Tab -> unit) -> unit
            /// <summary>Gets details about all tabs in the specified window.</summary>
            /// <param name="windowId">Optional. Defaults to the current window.</param>
            abstract getAllInWindow: windowId: float -> Promise<Tab>
            /// Gets the tab that this script call is being made from. May be undefined if called from a non-tab context (for example: a background page or popup view).
            abstract getCurrent: callback: (Tab -> unit) -> unit
            /// Gets the tab that this script call is being made from. May be undefined if called from a non-tab context (for example: a background page or popup view).
            abstract getCurrent: unit -> Promise<Tab option>
            /// Gets the tab that is selected in the specified window.
            abstract getSelected: callback: (Tab -> unit) -> unit
            /// Gets the tab that is selected in the specified window.
            abstract getSelected: unit -> Promise<Tab>
            /// <summary>Gets the tab that is selected in the specified window.</summary>
            /// <param name="windowId">Optional. Defaults to the current window.</param>
            abstract getSelected: windowId: float * callback: (Tab -> unit) -> unit
            /// <summary>Gets the tab that is selected in the specified window.</summary>
            /// <param name="windowId">Optional. Defaults to the current window.</param>
            abstract getSelected: windowId: float -> Promise<Tab>
            /// Creates a new tab.
            abstract create: createProperties: CreateProperties -> Promise<Tab>
            /// <summary>Creates a new tab.</summary>
            /// <param name="callback">Optional.
            /// Parameter tab: Details about the created tab. Will contain the ID of the new tab.</param>
            abstract create: createProperties: CreateProperties * ?callback: (Tab -> unit) -> unit
            /// <summary>Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.</summary>
            /// <param name="tabId">The tab to move.</param>
            abstract move: tabId: float * moveProperties: MoveProperties -> Promise<Tab>
            /// <summary>Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.</summary>
            /// <param name="tabId">The tab to move.</param>
            /// <param name="callback">Optional.
            /// Parameter tab: Details about the moved tab.</param>
            abstract move: tabId: float * moveProperties: MoveProperties * ?callback: (Tab -> unit) -> unit
            /// <summary>Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.</summary>
            /// <param name="tabIds">The tabs to move.</param>
            abstract move: tabIds: ResizeArray<float> * moveProperties: MoveProperties -> Promise<ResizeArray<Tab>>
            /// <summary>Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.</summary>
            /// <param name="tabIds">The tabs to move.</param>
            /// <param name="callback">Optional.
            /// Parameter tabs: Details about the moved tabs.</param>
            abstract move: tabIds: ResizeArray<float> * moveProperties: MoveProperties * ?callback: (ResizeArray<Tab> -> unit) -> unit
            /// Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.
            abstract update: updateProperties: UpdateProperties -> Promise<Tab>
            /// <summary>Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.</summary>
            /// <param name="callback">Optional.
            /// Optional parameter tab: Details about the updated tab. The tabs.Tab object doesn't contain url, title and favIconUrl if the "tabs" permission has not been requested.</param>
            abstract update: updateProperties: UpdateProperties * ?callback: (Tab -> unit) -> unit
            /// <summary>Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.</summary>
            /// <param name="tabId">Defaults to the selected tab of the current window.</param>
            abstract update: tabId: float * updateProperties: UpdateProperties -> Promise<Tab>
            /// <summary>Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.</summary>
            /// <param name="tabId">Defaults to the selected tab of the current window.</param>
            /// <param name="callback">Optional.
            /// Optional parameter tab: Details about the updated tab. The tabs.Tab object doesn't contain url, title and favIconUrl if the "tabs" permission has not been requested.</param>
            abstract update: tabId: float * updateProperties: UpdateProperties * ?callback: (Tab -> unit) -> unit
            /// <summary>Closes a tab.</summary>
            /// <param name="tabId">The tab to close.</param>
            abstract remove: tabId: float -> Promise<unit>
            /// <summary>Closes a tab.</summary>
            /// <param name="tabId">The tab to close.</param>
            abstract remove: tabId: float * ?callback: Function -> unit
            /// <summary>Closes several tabs.</summary>
            /// <param name="tabIds">The list of tabs to close.</param>
            abstract remove: tabIds: ResizeArray<float> -> Promise<unit>
            /// <summary>Closes several tabs.</summary>
            /// <param name="tabIds">The list of tabs to close.</param>
            abstract remove: tabIds: ResizeArray<float> * ?callback: Function -> unit
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="callback">Parameter dataUrl: A data URL which encodes an image of the visible area of the captured tab. May be assigned to the 'src' property of an HTML Image element for display.</param>
            abstract captureVisibleTab: callback: (string -> unit) -> unit
            /// Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.
            abstract captureVisibleTab: unit -> Promise<string>
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="windowId">Optional. The target window. Defaults to the current window.</param>
            /// <param name="callback">Parameter dataUrl: A data URL which encodes an image of the visible area of the captured tab. May be assigned to the 'src' property of an HTML Image element for display.</param>
            abstract captureVisibleTab: windowId: float * callback: (string -> unit) -> unit
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="windowId">Optional. The target window. Defaults to the current window.</param>
            abstract captureVisibleTab: windowId: float -> Promise<string>
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="options">Optional. Details about the format and quality of an image.</param>
            abstract captureVisibleTab: options: CaptureVisibleTabOptions -> Promise<string>
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="options">Optional. Details about the format and quality of an image.</param>
            /// <param name="callback">Parameter dataUrl: A data URL which encodes an image of the visible area of the captured tab. May be assigned to the 'src' property of an HTML Image element for display.</param>
            abstract captureVisibleTab: options: CaptureVisibleTabOptions * callback: (string -> unit) -> unit
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="windowId">Optional. The target window. Defaults to the current window.</param>
            /// <param name="options">Optional. Details about the format and quality of an image.</param>
            abstract captureVisibleTab: windowId: float * options: CaptureVisibleTabOptions -> Promise<string>
            /// <summary>Captures the visible area of the currently active tab in the specified window. You must have <all_urls> permission to use this method.</summary>
            /// <param name="windowId">Optional. The target window. Defaults to the current window.</param>
            /// <param name="options">Optional. Details about the format and quality of an image.</param>
            /// <param name="callback">Parameter dataUrl: A data URL which encodes an image of the visible area of the captured tab. May be assigned to the 'src' property of an HTML Image element for display.</param>
            abstract captureVisibleTab: windowId: float * options: CaptureVisibleTabOptions * callback: (string -> unit) -> unit
            /// <summary>Reload a tab.</summary>
            /// <param name="tabId">The ID of the tab to reload; defaults to the selected tab of the current window.</param>
            abstract reload: tabId: float * ?reloadProperties: ReloadProperties -> Promise<unit>
            /// <summary>Reload a tab.</summary>
            /// <param name="tabId">The ID of the tab to reload; defaults to the selected tab of the current window.</param>
            abstract reload: tabId: float * ?reloadProperties: ReloadProperties * ?callback: (unit -> unit) -> unit
            /// Reload the selected tab of the current window.
            abstract reload: reloadProperties: ReloadProperties -> Promise<unit>
            /// Reload the selected tab of the current window.
            abstract reload: reloadProperties: ReloadProperties * ?callback: (unit -> unit) -> unit
            /// Reload the selected tab of the current window.
            abstract reload: unit -> Promise<unit>
            /// Reload the selected tab of the current window.
            abstract reload: ?callback: (unit -> unit) -> unit
            /// <summary>Duplicates a tab.</summary>
            /// <param name="tabId">The ID of the tab which is to be duplicated.</param>
            /// <param name="callback">Optional.
            /// Optional parameter tab: Details about the duplicated tab. The tabs.Tab object doesn't contain url, title and favIconUrl if the "tabs" permission has not been requested.</param>
            abstract duplicate: tabId: float * ?callback: (Tab -> unit) -> unit
            /// Sends a single message to the content script(s) in the specified tab, with an optional callback to run when a response is sent back. The runtime.onMessage event is fired in each content script running in the specified tab for the current extension.
            abstract sendMessage: tabId: float * message: 'M * ?responseCallback: ('R -> unit) -> unit
            /// <summary>Sends a single message to the content script(s) in the specified tab, with an optional callback to run when a response is sent back. The runtime.onMessage event is fired in each content script running in the specified tab for the current extension.</summary>
            /// <param name="responseCallback">Optional.
            /// Parameter response: The JSON response object sent by the handler of the message. If an error occurs while connecting to the specified tab, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendMessage: tabId: float * message: 'M * options: MessageSendOptions * ?responseCallback: ('R -> unit) -> unit
            /// <summary>Sends a single request to the content script(s) in the specified tab, with an optional callback to run when a response is sent back. The extension.onRequest event is fired in each content script running in the specified tab for the current extension.</summary>
            /// <param name="responseCallback">Optional.
            /// Parameter response: The JSON response object sent by the handler of the request. If an error occurs while connecting to the specified tab, the callback will be called with no arguments and runtime.lastError will be set to the error message.</param>
            abstract sendRequest: tabId: float * request: 'Request * ?responseCallback: ('Response -> unit) -> unit
            /// Connects to the content script(s) in the specified tab. The runtime.onConnect event is fired in each content script running in the specified tab for the current extension.
            abstract connect: tabId: float * ?connectInfo: ConnectInfo -> Runtime.Port
            /// <summary>Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            abstract insertCSS: details: InjectDetails -> Promise<unit>
            /// <summary>Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            /// <param name="callback">Optional. Called when all the CSS has been inserted.</param>
            abstract insertCSS: details: InjectDetails * ?callback: Function -> unit
            /// <summary>Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="tabId">Optional. The ID of the tab in which to insert the CSS; defaults to the active tab of the current window.</param>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            abstract insertCSS: tabId: float * details: InjectDetails -> Promise<unit>
            /// <summary>Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.</summary>
            /// <param name="tabId">Optional. The ID of the tab in which to insert the CSS; defaults to the active tab of the current window.</param>
            /// <param name="details">Details of the script or CSS to inject. Either the code or the file property must be set, but both may not be set at the same time.</param>
            /// <param name="callback">Optional. Called when all the CSS has been inserted.</param>
            abstract insertCSS: tabId: float * details: InjectDetails * ?callback: Function -> unit
            /// Highlights the given tabs.
            abstract highlight: highlightInfo: HighlightInfo -> Promise<Chrome.Windows.Window>
            /// <summary>Highlights the given tabs.</summary>
            /// <param name="callback">Optional.
            /// Parameter window: Contains details about the window whose tabs were highlighted.</param>
            abstract highlight: highlightInfo: HighlightInfo * ?callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets all tabs that have the specified properties, or all tabs if no properties are specified.
            abstract query: queryInfo: QueryInfo * callback: (ResizeArray<Tab> -> unit) -> unit
            /// Gets all tabs that have the specified properties, or all tabs if no properties are specified.
            abstract query: queryInfo: QueryInfo -> Promise<ResizeArray<Tab>>
            /// <summary>Detects the primary language of the content in a tab.</summary>
            /// <param name="callback">Parameter language: An ISO language code such as en or fr. For a complete list of languages supported by this method, see kLanguageInfoTable. The 2nd to 4th columns will be checked and the first non-NULL value will be returned except for Simplified Chinese for which zh-CN will be returned. For an unknown language, und will be returned.</param>
            abstract detectLanguage: callback: (string -> unit) -> unit
            /// Detects the primary language of the content in a tab.
            abstract detectLanguage: unit -> Promise<string>
            /// <summary>Detects the primary language of the content in a tab.</summary>
            /// <param name="tabId">Optional. Defaults to the active tab of the current window.</param>
            /// <param name="callback">Parameter language: An ISO language code such as en or fr. For a complete list of languages supported by this method, see kLanguageInfoTable. The 2nd to 4th columns will be checked and the first non-NULL value will be returned except for Simplified Chinese for which zh-CN will be returned. For an unknown language, und will be returned.</param>
            abstract detectLanguage: tabId: float * callback: (string -> unit) -> unit
            /// <summary>Detects the primary language of the content in a tab.</summary>
            /// <param name="tabId">Optional. Defaults to the active tab of the current window.</param>
            abstract detectLanguage: tabId: float -> Promise<string>
            /// <summary>Zooms a specified tab.</summary>
            /// <param name="zoomFactor">The new zoom factor. Use a value of 0 here to set the tab to its current default zoom factor. Values greater than zero specify a (possibly non-default) zoom factor for the tab.</param>
            abstract setZoom: zoomFactor: float -> Promise<unit>
            /// <summary>Zooms a specified tab.</summary>
            /// <param name="zoomFactor">The new zoom factor. Use a value of 0 here to set the tab to its current default zoom factor. Values greater than zero specify a (possibly non-default) zoom factor for the tab.</param>
            /// <param name="callback">Optional. Called after the zoom factor has been changed.</param>
            abstract setZoom: zoomFactor: float * ?callback: (unit -> unit) -> unit
            /// <summary>Zooms a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to zoom; defaults to the active tab of the current window.</param>
            /// <param name="zoomFactor">The new zoom factor. Use a value of 0 here to set the tab to its current default zoom factor. Values greater than zero specify a (possibly non-default) zoom factor for the tab.</param>
            abstract setZoom: tabId: float * zoomFactor: float -> Promise<unit>
            /// <summary>Zooms a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to zoom; defaults to the active tab of the current window.</param>
            /// <param name="zoomFactor">The new zoom factor. Use a value of 0 here to set the tab to its current default zoom factor. Values greater than zero specify a (possibly non-default) zoom factor for the tab.</param>
            /// <param name="callback">Optional. Called after the zoom factor has been changed.</param>
            abstract setZoom: tabId: float * zoomFactor: float * ?callback: (unit -> unit) -> unit
            /// <summary>Gets the current zoom factor of a specified tab.</summary>
            /// <param name="callback">Called with the tab's current zoom factor after it has been fetched.
            /// Parameter zoomFactor: The tab's current zoom factor.</param>
            abstract getZoom: callback: (float -> unit) -> unit
            /// Gets the current zoom factor of a specified tab.
            abstract getZoom: unit -> Promise<float>
            /// <summary>Gets the current zoom factor of a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to get the current zoom factor from; defaults to the active tab of the current window.</param>
            /// <param name="callback">Called with the tab's current zoom factor after it has been fetched.
            /// Parameter zoomFactor: The tab's current zoom factor.</param>
            abstract getZoom: tabId: float * callback: (float -> unit) -> unit
            /// <summary>Gets the current zoom factor of a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to get the current zoom factor from; defaults to the active tab of the current window.</param>
            abstract getZoom: tabId: float -> Promise<float>
            /// <summary>Sets the zoom settings for a specified tab, which define how zoom changes are handled. These settings are reset to defaults upon navigating the tab.</summary>
            /// <param name="zoomSettings">Defines how zoom changes are handled and at what scope.</param>
            abstract setZoomSettings: zoomSettings: ZoomSettings -> Promise<unit>
            /// <summary>Sets the zoom settings for a specified tab, which define how zoom changes are handled. These settings are reset to defaults upon navigating the tab.</summary>
            /// <param name="zoomSettings">Defines how zoom changes are handled and at what scope.</param>
            /// <param name="callback">Optional. Called after the zoom settings have been changed.</param>
            abstract setZoomSettings: zoomSettings: ZoomSettings * ?callback: (unit -> unit) -> unit
            /// <summary>Sets the zoom settings for a specified tab, which define how zoom changes are handled. These settings are reset to defaults upon navigating the tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to change the zoom settings for; defaults to the active tab of the current window.</param>
            /// <param name="zoomSettings">Defines how zoom changes are handled and at what scope.</param>
            abstract setZoomSettings: tabId: float * zoomSettings: ZoomSettings -> Promise<unit>
            /// <summary>Sets the zoom settings for a specified tab, which define how zoom changes are handled. These settings are reset to defaults upon navigating the tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to change the zoom settings for; defaults to the active tab of the current window.</param>
            /// <param name="zoomSettings">Defines how zoom changes are handled and at what scope.</param>
            /// <param name="callback">Optional. Called after the zoom settings have been changed.</param>
            abstract setZoomSettings: tabId: float * zoomSettings: ZoomSettings * ?callback: (unit -> unit) -> unit
            /// <summary>Gets the current zoom settings of a specified tab.</summary>
            /// <param name="callback">Called with the tab's current zoom settings.
            /// Paramater zoomSettings: The tab's current zoom settings.</param>
            abstract getZoomSettings: callback: (ZoomSettings -> unit) -> unit
            /// Gets the current zoom settings of a specified tab.
            abstract getZoomSettings: unit -> Promise<ZoomSettings>
            /// <summary>Gets the current zoom settings of a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to get the current zoom settings from; defaults to the active tab of the current window.</param>
            /// <param name="callback">Called with the tab's current zoom settings.
            /// Paramater zoomSettings: The tab's current zoom settings.</param>
            abstract getZoomSettings: tabId: float * callback: (ZoomSettings -> unit) -> unit
            /// <summary>Gets the current zoom settings of a specified tab.</summary>
            /// <param name="tabId">Optional. The ID of the tab to get the current zoom settings from; defaults to the active tab of the current window.</param>
            abstract getZoomSettings: tabId: float -> Promise<ZoomSettings>
            /// <summary>Discards a tab from memory. Discarded tabs are still visible on the tab strip and are reloaded when activated.</summary>
            /// <param name="tabId">Optional. The ID of the tab to be discarded. If specified, the tab will be discarded unless it's active or already discarded. If omitted, the browser will discard the least important tab. This can fail if no discardable tabs exist.</param>
            abstract discard: ?tabId: float -> Promise<Tab>
            /// <summary>Discards a tab from memory. Discarded tabs are still visible on the tab strip and are reloaded when activated.</summary>
            /// <param name="tabId">Optional. The ID of the tab to be discarded. If specified, the tab will be discarded unless it's active or already discarded. If omitted, the browser will discard the least important tab. This can fail if no discardable tabs exist.</param>
            /// <param name="callback">Called after the operation is completed.</param>
            abstract discard: ?tabId: float * ?callback: (Tab -> unit) -> unit
            /// Go foward to the next page, if one is available.
            abstract goForward: unit -> Promise<unit>
            /// <summary>Go foward to the next page, if one is available.</summary>
            /// <param name="callback">Optional. Called after the operation is completed.</param>
            abstract goForward: ?callback: (unit -> unit) -> unit
            /// <summary>Go foward to the next page, if one is available.</summary>
            /// <param name="tabId">Optional. The ID of the tab to navigate forward; defaults to the selected tab of the current window.</param>
            abstract goForward: tabId: float -> Promise<unit>
            /// <summary>Go foward to the next page, if one is available.</summary>
            /// <param name="tabId">Optional. The ID of the tab to navigate forward; defaults to the selected tab of the current window.</param>
            /// <param name="callback">Optional. Called after the operation is completed.</param>
            abstract goForward: tabId: float * ?callback: (unit -> unit) -> unit
            /// Go back to the previous page, if one is available.
            abstract goBack: unit -> Promise<unit>
            /// <summary>Go back to the previous page, if one is available.</summary>
            /// <param name="callback">Optional. Called after the operation is completed.</param>
            abstract goBack: ?callback: (unit -> unit) -> unit
            /// <summary>Go back to the previous page, if one is available.</summary>
            /// <param name="tabId">Optional. The ID of the tab to navigate back; defaults to the selected tab of the current window.</param>
            abstract goBack: tabId: float -> Promise<unit>
            /// <summary>Go back to the previous page, if one is available.</summary>
            /// <param name="tabId">Optional. The ID of the tab to navigate back; defaults to the selected tab of the current window.</param>
            /// <param name="callback">Optional. Called after the operation is completed.</param>
            abstract goBack: tabId: float * ?callback: (unit -> unit) -> unit
            /// <summary>Adds one or more tabs to a specified group, or if no group is specified, adds the given tabs to a newly created group.</summary>
            /// <param name="options">Configurations object</param>
            abstract group: options: GroupOptions -> Promise<float>
            /// <summary>Adds one or more tabs to a specified group, or if no group is specified, adds the given tabs to a newly created group.</summary>
            /// <param name="options">Configurations object</param>
            /// <param name="callback">Optional.</param>
            abstract group: options: GroupOptions * ?callback: (float -> unit) -> unit
            /// <summary>Removes one or more tabs from their respective groups. If any groups become empty, they are deleted</summary>
            /// <param name="tabIds">The tabs to ungroup.</param>
            abstract ungroup: tabIds: U2<float, ResizeArray<float>> -> Promise<unit>
            /// <summary>Removes one or more tabs from their respective groups. If any groups become empty, they are deleted</summary>
            /// <param name="tabIds">The tabs to ungroup.</param>
            /// <param name="callback">Optional. Called after the operation is completed.</param>
            abstract ungroup: tabIds: U2<float, ResizeArray<float>> * ?callback: (unit -> unit) -> unit
            abstract onHighlighted: TabHighlightedEvent
            abstract onRemoved: TabRemovedEvent
            abstract onUpdated: TabUpdatedEvent
            abstract onAttached: TabAttachedEvent
            abstract onMoved: TabMovedEvent
            abstract onDetached: TabDetachedEvent
            abstract onCreated: TabCreatedEvent
            abstract onActivated: TabActivatedEvent
            abstract onReplaced: TabReplacedEvent
            abstract onSelectionChanged: TabSelectedEvent
            abstract onActiveChanged: TabSelectedEvent
            abstract onHighlightChanged: TabHighlightedEvent
            abstract onZoomChange: TabZoomChangeEvent
            abstract TAB_ID_NONE: obj

        /// Tab muted state and the reason for the last state change.
        type [<AllowNullLiteral>] MutedInfo =
            /// Whether the tab is prevented from playing sound (but hasn't necessarily recently produced sound). Equivalent to whether the muted audio indicator is showing.
            abstract muted: bool with get, set
            /// Optional.
            /// The reason the tab was muted or unmuted. Not set if the tab's mute state has never been changed.
            /// "user": A user input action has set/overridden the muted state.
            /// "capture": Tab capture started, forcing a muted state change.
            /// "extension": An extension, identified by the extensionId field, set the muted state.
            abstract reason: string option with get, set
            /// Optional.
            /// The ID of the extension that changed the muted state. Not set if an extension was not the reason the muted state last changed.
            abstract extensionId: string option with get, set

        type [<AllowNullLiteral>] Tab =
            /// Optional.
            /// Either loading or complete.
            abstract status: string option with get, set
            /// The zero-based index of the tab within its window.
            abstract index: float with get, set
            /// Optional.
            /// The ID of the tab that opened this tab, if any. This property is only present if the opener tab still exists.
            abstract openerTabId: float option with get, set
            /// Optional.
            /// The title of the tab. This property is only present if the extension's manifest includes the "tabs" permission.
            abstract title: string option with get, set
            /// Optional.
            /// The URL the tab is displaying. This property is only present if the extension's manifest includes the "tabs" permission.
            abstract url: string option with get, set
            /// The URL the tab is navigating to, before it has committed.
            /// This property is only present if the extension's manifest includes the "tabs" permission and there is a pending navigation.
            abstract pendingUrl: string option with get, set
            /// Whether the tab is pinned.
            abstract pinned: bool with get, set
            /// Whether the tab is highlighted.
            abstract highlighted: bool with get, set
            /// The ID of the window the tab is contained within.
            abstract windowId: float with get, set
            /// Whether the tab is active in its window. (Does not necessarily mean the window is focused.)
            abstract active: bool with get, set
            /// Optional.
            /// The URL of the tab's favicon. This property is only present if the extension's manifest includes the "tabs" permission. It may also be an empty string if the tab is loading.
            abstract favIconUrl: string option with get, set
            /// Optional.
            /// The ID of the tab. Tab IDs are unique within a browser session. Under some circumstances a Tab may not be assigned an ID, for example when querying foreign tabs using the sessions API, in which case a session ID may be present. Tab ID can also be set to chrome.tabs.TAB_ID_NONE for apps and devtools windows.
            abstract id: float option with get, set
            /// Whether the tab is in an incognito window.
            abstract incognito: bool with get, set
            /// Whether the tab is selected.
            abstract selected: bool with get, set
            /// Optional.
            /// Whether the tab has produced sound over the past couple of seconds (but it might not be heard if also muted). Equivalent to whether the speaker audio indicator is showing.
            abstract audible: bool option with get, set
            /// Whether the tab is discarded. A discarded tab is one whose content has been unloaded from memory, but is still visible in the tab strip. Its content gets reloaded the next time it's activated.
            abstract discarded: bool with get, set
            /// Whether the tab can be discarded automatically by the browser when resources are low.
            abstract autoDiscardable: bool with get, set
            /// Optional.
            /// Current tab muted state and the reason for the last state change.
            abstract mutedInfo: MutedInfo option with get, set
            /// Optional. The width of the tab in pixels.
            abstract width: float option with get, set
            /// Optional. The height of the tab in pixels.
            abstract height: float option with get, set
            /// Optional. The session ID used to uniquely identify a Tab obtained from the sessions API.
            abstract sessionId: string option with get, set
            /// The ID of the group that the tab belongs to.
            abstract groupId: float with get, set

        /// Defines how zoom changes in a tab are handled and at what scope.
        type [<AllowNullLiteral>] ZoomSettings =
            /// Optional.
            /// Defines how zoom changes are handled, i.e. which entity is responsible for the actual scaling of the page; defaults to "automatic".
            /// "automatic": Zoom changes are handled automatically by the browser.
            /// "manual": Overrides the automatic handling of zoom changes. The onZoomChange event will still be dispatched, and it is the responsibility of the extension to listen for this event and manually scale the page. This mode does not support per-origin zooming, and will thus ignore the scope zoom setting and assume per-tab.
            /// "disabled": Disables all zooming in the tab. The tab will revert to the default zoom level, and all attempted zoom changes will be ignored.
            abstract mode: string option with get, set
            /// Optional.
            /// Defines whether zoom changes will persist for the page's origin, or only take effect in this tab; defaults to per-origin when in automatic mode, and per-tab otherwise.
            /// "per-origin": Zoom changes will persist in the zoomed page's origin, i.e. all other tabs navigated to that same origin will be zoomed as well. Moreover, per-origin zoom changes are saved with the origin, meaning that when navigating to other pages in the same origin, they will all be zoomed to the same zoom factor. The per-origin scope is only available in the automatic mode.
            /// "per-tab": Zoom changes only take effect in this tab, and zoom changes in other tabs will not affect the zooming of this tab. Also, per-tab zoom changes are reset on navigation; navigating a tab will always load pages with their per-origin zoom factors.
            abstract scope: string option with get, set
            /// Optional.
            /// Used to return the default zoom level for the current tab in calls to tabs.getZoomSettings.
            abstract defaultZoomFactor: float option with get, set

        type [<AllowNullLiteral>] InjectDetails =
            /// Optional.
            /// If allFrames is true, implies that the JavaScript or CSS should be injected into all frames of current page. By default, it's false and is only injected into the top frame.
            abstract allFrames: bool option with get, set
            /// Optional. JavaScript or CSS code to inject.
            /// Warning: Be careful using the code parameter. Incorrect use of it may open your extension to cross site scripting attacks.
            abstract code: string option with get, set
            /// Optional. The soonest that the JavaScript or CSS will be injected into the tab.
            /// One of: "document_start", "document_end", or "document_idle"
            abstract runAt: string option with get, set
            /// Optional. JavaScript or CSS file to inject.
            abstract file: string option with get, set
            /// Optional.
            /// The frame where the script or CSS should be injected. Defaults to 0 (the top-level frame).
            abstract frameId: float option with get, set
            /// Optional.
            /// If matchAboutBlank is true, then the code is also injected in about:blank and about:srcdoc frames if your extension has access to its parent document. Code cannot be inserted in top-level about:-frames. By default it is false.
            abstract matchAboutBlank: bool option with get, set
            /// Optional. The origin of the CSS to inject. This may only be specified for CSS, not JavaScript. Defaults to "author".
            /// One of: "author", or "user"
            abstract cssOrigin: string option with get, set

        type [<AllowNullLiteral>] CreateProperties =
            /// Optional. The position the tab should take in the window. The provided value will be clamped to between zero and the number of tabs in the window.
            abstract index: float option with get, set
            /// Optional.
            /// The ID of the tab that opened this tab. If specified, the opener tab must be in the same window as the newly created tab.
            abstract openerTabId: float option with get, set
            /// Optional.
            /// The URL to navigate the tab to initially. Fully-qualified URLs must include a scheme (i.e. 'http://www.google.com', not 'www.google.com'). Relative URLs will be relative to the current page within the extension. Defaults to the New Tab Page.
            abstract url: string option with get, set
            /// Optional. Whether the tab should be pinned. Defaults to false
            abstract pinned: bool option with get, set
            /// Optional. The window to create the new tab in. Defaults to the current window.
            abstract windowId: float option with get, set
            /// Optional.
            /// Whether the tab should become the active tab in the window. Does not affect whether the window is focused (see windows.update). Defaults to true.
            abstract active: bool option with get, set
            /// Optional. Whether the tab should become the selected tab in the window. Defaults to true
            abstract selected: bool option with get, set

        type [<AllowNullLiteral>] MoveProperties =
            /// The position to move the window to. -1 will place the tab at the end of the window.
            abstract index: float with get, set
            /// Optional. Defaults to the window the tab is currently in.
            abstract windowId: float option with get, set

        type [<AllowNullLiteral>] UpdateProperties =
            /// Optional. Whether the tab should be pinned.
            abstract pinned: bool option with get, set
            /// Optional. The ID of the tab that opened this tab. If specified, the opener tab must be in the same window as this tab.
            abstract openerTabId: float option with get, set
            /// Optional. A URL to navigate the tab to.
            abstract url: string option with get, set
            /// Optional. Adds or removes the tab from the current selection.
            abstract highlighted: bool option with get, set
            /// Optional. Whether the tab should be active. Does not affect whether the window is focused (see windows.update).
            abstract active: bool option with get, set
            /// Optional. Whether the tab should be selected.
            abstract selected: bool option with get, set
            /// Optional. Whether the tab should be muted.
            abstract muted: bool option with get, set
            /// Optional. Whether the tab should be discarded automatically by the browser when resources are low.
            abstract autoDiscardable: bool option with get, set

        type [<AllowNullLiteral>] CaptureVisibleTabOptions =
            /// Optional.
            /// When format is "jpeg", controls the quality of the resulting image. This value is ignored for PNG images. As quality is decreased, the resulting image will have more visual artifacts, and the number of bytes needed to store it will decrease.
            abstract quality: float option with get, set
            /// Optional. The format of an image.
            /// One of: "jpeg", or "png"
            abstract format: string option with get, set

        type [<AllowNullLiteral>] ReloadProperties =
            /// Optional. Whether using any local cache. Default is false.
            abstract bypassCache: bool option with get, set

        type [<AllowNullLiteral>] ConnectInfo =
            /// Optional. Will be passed into onConnect for content scripts that are listening for the connection event.
            abstract name: string option with get, set
            /// Open a port to a specific frame identified by frameId instead of all frames in the tab.
            abstract frameId: float option with get, set

        type [<AllowNullLiteral>] MessageSendOptions =
            /// Optional. Send a message to a specific frame identified by frameId instead of all frames in the tab.
            abstract frameId: float option with get, set

        type [<AllowNullLiteral>] GroupOptions =
            /// Optional. Configurations for creating a group. Cannot be used if groupId is already specified.
            abstract createProperties: GroupOptionsCreateProperties option with get, set
            /// Optional. The ID of the group to add the tabs to. If not specified, a new group will be created.
            abstract groupId: float option with get, set
            /// TOptional. he tab ID or list of tab IDs to add to the specified group.
            abstract tabIds: U2<float, ResizeArray<float>> option with get, set

        type [<AllowNullLiteral>] HighlightInfo =
            /// One or more tab indices to highlight.
            abstract tabs: U2<float, ResizeArray<float>> with get, set
            /// Optional. The window that contains the tabs.
            abstract windowId: float option with get, set

        type [<AllowNullLiteral>] QueryInfo =
            /// Optional. Whether the tabs have completed loading.
            /// One of: "loading", or "complete"
            abstract status: QueryInfoStatus option with get, set
            /// Optional. Whether the tabs are in the last focused window.
            abstract lastFocusedWindow: bool option with get, set
            /// Optional. The ID of the parent window, or windows.WINDOW_ID_CURRENT for the current window.
            abstract windowId: float option with get, set
            /// Optional. The type of window the tabs are in.
            /// One of: "normal", "popup", "panel", "app", or "devtools"
            abstract windowType: QueryInfoWindowType option with get, set
            /// Optional. Whether the tabs are active in their windows.
            abstract active: bool option with get, set
            /// Optional. The position of the tabs within their windows.
            abstract index: float option with get, set
            /// Optional. Match page titles against a pattern.
            abstract title: string option with get, set
            /// Optional. Match tabs against one or more URL patterns. Note that fragment identifiers are not matched.
            abstract url: U2<string, ResizeArray<string>> option with get, set
            /// Optional. Whether the tabs are in the current window.
            abstract currentWindow: bool option with get, set
            /// Optional. Whether the tabs are highlighted.
            abstract highlighted: bool option with get, set
            /// Optional.
            /// Whether the tabs are discarded. A discarded tab is one whose content has been unloaded from memory, but is still visible in the tab strip. Its content gets reloaded the next time it's activated.
            abstract discarded: bool option with get, set
            /// Optional.
            /// Whether the tabs can be discarded automatically by the browser when resources are low.
            abstract autoDiscardable: bool option with get, set
            /// Optional. Whether the tabs are pinned.
            abstract pinned: bool option with get, set
            /// Optional. Whether the tabs are audible.
            abstract audible: bool option with get, set
            /// Optional. Whether the tabs are muted.
            abstract muted: bool option with get, set
            /// Optional. The ID of the group that the tabs are in, or chrome.tabGroups.TAB_GROUP_ID_NONE for ungrouped tabs.
            abstract groupId: float option with get, set

        type [<AllowNullLiteral>] TabHighlightInfo =
            abstract windowId: float with get, set
            abstract tabIds: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] TabRemoveInfo =
            /// The window whose tab is closed.
            abstract windowId: float with get, set
            /// True when the tab is being closed because its window is being closed.
            abstract isWindowClosing: bool with get, set

        type [<AllowNullLiteral>] TabAttachInfo =
            abstract newPosition: float with get, set
            abstract newWindowId: float with get, set
        type [<StringEnum>] TabChangeInfoStatus= |Complete|Other
        type [<AllowNullLiteral>] TabChangeInfo =
            /// Optional. The status of the tab. Can be either loading or complete.
            abstract status: TabChangeInfoStatus option with get, set
            /// The tab's new pinned state.
            abstract pinned: bool option with get, set
            /// Optional. The tab's URL if it has changed.
            abstract url: string option with get, set
            /// The tab's new audible state.
            abstract audible: bool option with get, set
            /// The tab's new discarded state.
            abstract discarded: bool option with get, set
            /// The tab's new auto-discardable
            abstract autoDiscardable: bool option with get, set
            /// The tab's new group.
            abstract groupId: float option with get, set
            /// The tab's new muted state and the reason for the change.
            abstract mutedInfo: MutedInfo option with get, set
            /// The tab's new favicon URL.
            abstract favIconUrl: string option with get, set
            /// The tab's new title.
            abstract title: string option with get, set

        type [<AllowNullLiteral>] TabMoveInfo =
            abstract toIndex: float with get, set
            abstract windowId: float with get, set
            abstract fromIndex: float with get, set

        type [<AllowNullLiteral>] TabDetachInfo =
            abstract oldWindowId: float with get, set
            abstract oldPosition: float with get, set

        type [<AllowNullLiteral>] TabActiveInfo =
            /// The ID of the tab that has become active.
            abstract tabId: float with get, set
            /// The ID of the window the active tab changed inside of.
            abstract windowId: float with get, set

        type [<AllowNullLiteral>] TabWindowInfo =
            /// The ID of the window of where the tab is located.
            abstract windowId: float with get, set

        type [<AllowNullLiteral>] ZoomChangeInfo =
            abstract tabId: float with get, set
            abstract oldZoomFactor: float with get, set
            abstract newZoomFactor: float with get, set
            abstract zoomSettings: ZoomSettings with get, set

        type [<AllowNullLiteral>] TabHighlightedEvent =
            inherit Chrome.Events.Event<(TabHighlightInfo -> unit)>

        type [<AllowNullLiteral>] TabRemovedEvent =
            inherit Chrome.Events.Event<(float -> TabRemoveInfo -> unit)>

        type [<AllowNullLiteral>] TabUpdatedEvent =
            inherit Chrome.Events.Event<Action<float , TabChangeInfo , Tab >>

        type [<AllowNullLiteral>] TabAttachedEvent =
            inherit Chrome.Events.Event<(float -> TabAttachInfo -> unit)>

        type [<AllowNullLiteral>] TabMovedEvent =
            inherit Chrome.Events.Event<(float -> TabMoveInfo -> unit)>

        type [<AllowNullLiteral>] TabDetachedEvent =
            inherit Chrome.Events.Event<(float -> TabDetachInfo -> unit)>

        type [<AllowNullLiteral>] TabCreatedEvent =
            inherit Chrome.Events.Event<(Tab -> unit)>

        type [<AllowNullLiteral>] TabActivatedEvent =
            inherit Chrome.Events.Event<Action<TabActiveInfo>>

        type [<AllowNullLiteral>] TabReplacedEvent =
            inherit Chrome.Events.Event<(float -> float -> unit)>

        type [<AllowNullLiteral>] TabSelectedEvent =
            inherit Chrome.Events.Event<Action<float ,TabWindowInfo>>

        type [<AllowNullLiteral>] TabZoomChangeEvent =
            inherit Chrome.Events.Event<(ZoomChangeInfo -> unit)>

        type [<AllowNullLiteral>] GroupOptionsCreateProperties =
            /// Optional. The window of the new group. Defaults to the current window.
            abstract windowId: float option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] QueryInfoStatus =
            | Loading
            | Complete

        type [<StringEnum>] [<RequireQualifiedAccess>] QueryInfoWindowType =
            | Normal
            | Popup
            | Panel
            | App
            | Devtools

    module TabGroups =

        type [<AllowNullLiteral>] IExports =
            abstract TAB_GROUP_ID_NONE: obj
            /// <summary>Retrieves details about the specified group.</summary>
            /// <param name="groupId">The ID of the tab group.</param>
            /// <param name="callback">Called with the retrieved tab group.</param>
            abstract get: groupId: float * callback: (TabGroup -> unit) -> unit
            /// <summary>Retrieves details about the specified group.</summary>
            /// <param name="groupId">The ID of the tab group.</param>
            abstract get: groupId: float -> Promise<TabGroup>
            /// <summary>Moves the group and all its tabs within its window, or to a new window.</summary>
            /// <param name="groupId">The ID of the group to move.</param>
            /// <param name="moveProperties">Information on how to move the group.</param>
            abstract move: groupId: float * moveProperties: MoveProperties -> Promise<TabGroup>
            /// <summary>Moves the group and all its tabs within its window, or to a new window.</summary>
            /// <param name="groupId">The ID of the group to move.</param>
            /// <param name="moveProperties">Information on how to move the group.</param>
            /// <param name="callback">Optional.</param>
            abstract move: groupId: float * moveProperties: MoveProperties * ?callback: (TabGroup -> unit) -> unit
            /// <summary>Gets all groups that have the specified properties, or all groups if no properties are specified.</summary>
            /// <param name="queryInfo">Object with search parameters.</param>
            /// <param name="callback">Called with retrieved tab groups.</param>
            abstract query: queryInfo: QueryInfo * callback: (ResizeArray<TabGroup> -> unit) -> unit
            /// <summary>Gets all groups that have the specified properties, or all groups if no properties are specified.</summary>
            /// <param name="queryInfo">Object with search parameters.</param>
            abstract query: queryInfo: QueryInfo -> Promise<ResizeArray<TabGroup>>
            /// <summary>Modifies the properties of a group. Properties that are not specified in updateProperties are not modified.</summary>
            /// <param name="groupId">The ID of the group to modify.</param>
            /// <param name="updateProperties">Information on how to update the group.</param>
            abstract update: groupId: float * updateProperties: UpdateProperties -> Promise<TabGroup>
            /// <summary>Modifies the properties of a group. Properties that are not specified in updateProperties are not modified.</summary>
            /// <param name="groupId">The ID of the group to modify.</param>
            /// <param name="updateProperties">Information on how to update the group.</param>
            /// <param name="callback">Optional.</param>
            abstract update: groupId: float * updateProperties: UpdateProperties * ?callback: (TabGroup -> unit) -> unit
            abstract onCreated: TabGroupCreatedEvent
            abstract onMoved: TabGroupMovedEvent
            abstract onRemoved: TabGroupRemovedEvent
            abstract onUpdated: TabGroupUpdated

        type [<StringEnum>] [<RequireQualifiedAccess>] ColorEnum =
            | Grey
            | Blue
            | Red
            | Yellow
            | Green
            | Pink
            | Purple
            | Cyan
            | Orange

        type [<AllowNullLiteral>] TabGroup =
            /// Whether the group is collapsed. A collapsed group is one whose tabs are hidden.
            abstract collapsed: bool with get, set
            /// The group's color.
            abstract color: ColorEnum with get, set
            /// The ID of the group. Group IDs are unique within a browser session.
            abstract id: float with get, set
            /// Optional. The title of the group.
            abstract title: string option with get, set
            /// The ID of the window that contains the group.
            abstract windowId: float with get, set

        type [<AllowNullLiteral>] MoveProperties =
            /// The position to move the group to. Use -1 to place the group at the end of the window.
            abstract index: float with get, set
            /// Optional. The window to move the group to. Defaults to the window the group is currently in. Note that groups can only be moved to and from windows with chrome.windows.WindowType type "normal".
            abstract windowId: float option with get, set

        type [<AllowNullLiteral>] QueryInfo =
            /// Optional. Whether the groups are collapsed.
            abstract collapsed: bool option with get, set
            /// Optional. The color of the groups.
            abstract color: ColorEnum option with get, set
            /// Optional. Match group titles against a pattern.
            abstract title: string option with get, set
            /// Optional. The ID of the window that contains the group.
            abstract windowId: float option with get, set

        type [<AllowNullLiteral>] UpdateProperties =
            /// Optional. Whether the group should be collapsed.
            abstract collapsed: bool option with get, set
            /// Optional. The color of the group.
            abstract color: ColorEnum option with get, set
            /// Optional. The title of the group.
            abstract title: string option with get, set

        type [<AllowNullLiteral>] TabGroupCreatedEvent =
            inherit Chrome.Events.Event<(TabGroup -> unit)>

        type [<AllowNullLiteral>] TabGroupMovedEvent =
            inherit Chrome.Events.Event<(TabGroup -> unit)>

        type [<AllowNullLiteral>] TabGroupRemovedEvent =
            inherit Chrome.Events.Event<(TabGroup -> unit)>

        type [<AllowNullLiteral>] TabGroupUpdated =
            inherit Chrome.Events.Event<(TabGroup -> unit)>

    module TopSites =

        type [<AllowNullLiteral>] IExports =
            /// Gets a list of top sites.
            abstract get: callback: (ResizeArray<MostVisitedURL> -> unit) -> unit

        /// An object encapsulating a most visited URL, such as the URLs on the new tab page.
        type [<AllowNullLiteral>] MostVisitedURL =
            /// The most visited URL.
            abstract url: string with get, set
            /// The title of the page
            abstract title: string with get, set

    module Tts =

        type [<AllowNullLiteral>] IExports =
            /// Checks whether the engine is currently speaking. On Mac OS X, the result is true whenever the system speech engine is speaking, even if the speech wasn't initiated by Chrome.
            abstract isSpeaking: ?callback: (bool -> unit) -> unit
            /// Stops any current speech and flushes the queue of any pending utterances. In addition, if speech was paused, it will now be un-paused for the next call to speak.
            abstract stop: unit -> unit
            /// Gets an array of all available voices.
            abstract getVoices: ?callback: (ResizeArray<TtsVoice> -> unit) -> unit
            /// <summary>Speaks text using a text-to-speech engine.</summary>
            /// <param name="utterance">The text to speak, either plain text or a complete, well-formed SSML document. Speech engines that do not support SSML will strip away the tags and speak the text. The maximum length of the text is 32,768 characters.</param>
            /// <param name="callback">Optional. Called right away, before speech finishes. Check chrome.runtime.lastError to make sure there were no errors. Use options.onEvent to get more detailed feedback.</param>
            abstract speak: utterance: string * ?callback: Function -> unit
            /// <summary>Speaks text using a text-to-speech engine.</summary>
            /// <param name="utterance">The text to speak, either plain text or a complete, well-formed SSML document. Speech engines that do not support SSML will strip away the tags and speak the text. The maximum length of the text is 32,768 characters.</param>
            /// <param name="options">Optional. The speech options.</param>
            /// <param name="callback">Optional. Called right away, before speech finishes. Check chrome.runtime.lastError to make sure there were no errors. Use options.onEvent to get more detailed feedback.</param>
            abstract speak: utterance: string * options: SpeakOptions * ?callback: Function -> unit
            /// Pauses speech synthesis, potentially in the middle of an utterance. A call to resume or stop will un-pause speech.
            abstract pause: unit -> unit
            /// If speech was paused, resumes speaking where it left off.
            abstract resume: unit -> unit

        /// An event from the TTS engine to communicate the status of an utterance.
        type [<AllowNullLiteral>] TtsEvent =
            /// Optional. The index of the current character in the utterance.
            abstract charIndex: float option with get, set
            /// Optional. The error description, if the event type is 'error'.
            abstract errorMessage: string option with get, set
            /// The type can be 'start' as soon as speech has started, 'word' when a word boundary is reached, 'sentence' when a sentence boundary is reached, 'marker' when an SSML mark element is reached, 'end' when the end of the utterance is reached, 'interrupted' when the utterance is stopped or interrupted before reaching the end, 'cancelled' when it's removed from the queue before ever being synthesized, or 'error' when any other error occurs. When pausing speech, a 'pause' event is fired if a particular utterance is paused in the middle, and 'resume' if an utterance resumes speech. Note that pause and resume events may not fire if speech is paused in-between utterances.
            /// One of: "start", "end", "word", "sentence", "marker", "interrupted", "cancelled", "error", "pause", or "resume"
            abstract ``type``: string with get, set

        /// A description of a voice available for speech synthesis.
        type [<AllowNullLiteral>] TtsVoice =
            /// Optional. The language that this voice supports, in the form language-region. Examples: 'en', 'en-US', 'en-GB', 'zh-CN'.
            abstract lang: string option with get, set
            /// Optional. This voice's gender.
            /// One of: "male", or "female"
            abstract gender: string option with get, set
            /// Optional. The name of the voice.
            abstract voiceName: string option with get, set
            /// Optional. The ID of the extension providing this voice.
            abstract extensionId: string option with get, set
            /// Optional. All of the callback event types that this voice is capable of sending.
            abstract eventTypes: ResizeArray<string> option with get, set
            /// Optional. If true, the synthesis engine is a remote network resource. It may be higher latency and may incur bandwidth costs.
            abstract remote: bool option with get, set

        type [<AllowNullLiteral>] SpeakOptions =
            /// Optional. Speaking volume between 0 and 1 inclusive, with 0 being lowest and 1 being highest, with a default of 1.0.
            abstract volume: float option with get, set
            /// Optional.
            /// If true, enqueues this utterance if TTS is already in progress. If false (the default), interrupts any current speech and flushes the speech queue before speaking this new utterance.
            abstract enqueue: bool option with get, set
            /// Optional.
            /// Speaking rate relative to the default rate for this voice. 1.0 is the default rate, normally around 180 to 220 words per minute. 2.0 is twice as fast, and 0.5 is half as fast. Values below 0.1 or above 10.0 are strictly disallowed, but many voices will constrain the minimum and maximum rates further—for example a particular voice may not actually speak faster than 3 times normal even if you specify a value larger than 3.0.
            abstract rate: float option with get, set
            /// Optional. This function is called with events that occur in the process of speaking the utterance.
            abstract onEvent: (TtsEvent -> unit) option with get, set
            /// Optional.
            /// Speaking pitch between 0 and 2 inclusive, with 0 being lowest and 2 being highest. 1.0 corresponds to a voice's default pitch.
            abstract pitch: float option with get, set
            /// Optional. The language to be used for synthesis, in the form language-region. Examples: 'en', 'en-US', 'en-GB', 'zh-CN'.
            abstract lang: string option with get, set
            /// Optional. The name of the voice to use for synthesis. If empty, uses any available voice.
            abstract voiceName: string option with get, set
            /// Optional. The extension ID of the speech engine to use, if known.
            abstract extensionId: string option with get, set
            /// Optional. Gender of voice for synthesized speech.
            /// One of: "male", or "female"
            abstract gender: string option with get, set
            /// Optional. The TTS event types the voice must support.
            abstract requiredEventTypes: ResizeArray<string> option with get, set
            /// Optional. The TTS event types that you are interested in listening to. If missing, all event types may be sent.
            abstract desiredEventTypes: ResizeArray<string> option with get, set

    module TtsEngine =

        type [<AllowNullLiteral>] IExports =
            abstract onSpeak: TtsEngineSpeakEvent
            abstract onStop: Chrome.Events.Event<(unit -> unit)>
            abstract onPause: Chrome.Events.Event<(unit -> unit)>
            abstract onResume: Chrome.Events.Event<(unit -> unit)>

        type [<AllowNullLiteral>] SpeakOptions =
            /// Optional. The language to be used for synthesis, in the form language-region. Examples: 'en', 'en-US', 'en-GB', 'zh-CN'.
            abstract lang: string option with get, set
            /// Optional. The name of the voice to use for synthesis.
            abstract voiceName: string option with get, set
            /// Optional. Gender of voice for synthesized speech.
            /// One of: "male", or "female"
            abstract gender: string option with get, set
            /// Optional. Speaking volume between 0 and 1 inclusive, with 0 being lowest and 1 being highest, with a default of 1.0.
            abstract volume: float option with get, set
            /// Optional.
            /// Speaking rate relative to the default rate for this voice. 1.0 is the default rate, normally around 180 to 220 words per minute. 2.0 is twice as fast, and 0.5 is half as fast. This value is guaranteed to be between 0.1 and 10.0, inclusive. When a voice does not support this full range of rates, don't return an error. Instead, clip the rate to the range the voice supports.
            abstract rate: float option with get, set
            /// Optional. Speaking pitch between 0 and 2 inclusive, with 0 being lowest and 2 being highest. 1.0 corresponds to this voice's default pitch.
            abstract pitch: float option with get, set

        type [<AllowNullLiteral>] TtsEngineSpeakEvent =
            inherit Chrome.Events.Event<(string -> SpeakOptions -> (Chrome.Tts.TtsEvent -> unit) -> unit)>

    module Types =

        type [<StringEnum>] [<RequireQualifiedAccess>] settingsScope =
            | Regular
            | Regular_only
            | Incognito_persistent
            | Incognito_session_only

        type [<AllowNullLiteral>] ChromeSettingClearDetails =
            /// Optional.
            /// The scope of the ChromeSetting. One of
            /// • regular: setting for the regular profile (which is inherited by the incognito profile if not overridden elsewhere),
            /// • regular_only: setting for the regular profile only (not inherited by the incognito profile),
            /// • incognito_persistent: setting for the incognito profile that survives browser restarts (overrides regular preferences),
            /// • incognito_session_only: setting for the incognito profile that can only be set during an incognito session and is deleted when the incognito session ends (overrides regular and incognito_persistent preferences).
            abstract scope: settingsScope option with get, set

        type [<AllowNullLiteral>] ChromeSettingSetDetails =
            inherit ChromeSettingClearDetails
            /// The value of the setting.
            /// Note that every setting has a specific value type, which is described together with the setting. An extension should not set a value of a different type.
            abstract value: obj option with get, set
            /// Optional.
            /// The scope of the ChromeSetting. One of
            /// • regular: setting for the regular profile (which is inherited by the incognito profile if not overridden elsewhere),
            /// • regular_only: setting for the regular profile only (not inherited by the incognito profile),
            /// • incognito_persistent: setting for the incognito profile that survives browser restarts (overrides regular preferences),
            /// • incognito_session_only: setting for the incognito profile that can only be set during an incognito session and is deleted when the incognito session ends (overrides regular and incognito_persistent preferences).
            abstract scope: settingsScope option with get, set

        type [<AllowNullLiteral>] ChromeSettingGetDetails =
            /// Optional. Whether to return the value that applies to the incognito session (default false).
            abstract incognito: bool option with get, set

        type [<AllowNullLiteral>] DetailsCallback =
            [<Emit "$0($1...)">] abstract Invoke: details: ChromeSettingGetResultDetails -> unit

        type [<AllowNullLiteral>] ChromeSettingGetResultDetails =
            /// One of
            /// • not_controllable: cannot be controlled by any extension
            /// • controlled_by_other_extensions: controlled by extensions with higher precedence
            /// • controllable_by_this_extension: can be controlled by this extension
            /// • controlled_by_this_extension: controlled by this extension
            abstract levelOfControl: ChromeSettingGetResultDetailsLevelOfControl with get, set
            /// The value of the setting.
            abstract value: obj option with get, set
            /// Optional.
            /// Whether the effective value is specific to the incognito session.
            /// This property will only be present if the incognito property in the details parameter of get() was true.
            abstract incognitoSpecific: bool option with get, set

        type [<AllowNullLiteral>] ChromeSettingChangedEvent =
            inherit Chrome.Events.Event<DetailsCallback>

        /// An interface that allows access to a Chrome browser setting. See accessibilityFeatures for an example.
        type [<AllowNullLiteral>] ChromeSetting =
            /// <summary>Sets the value of a setting.</summary>
            /// <param name="details">Which setting to change.</param>
            /// <param name="callback">Optional. Called at the completion of the set operation.</param>
            abstract set: details: ChromeSettingSetDetails * ?callback: Function -> unit
            /// <summary>Gets the value of a setting.</summary>
            /// <param name="details">Which setting to consider.</param>
            abstract get: details: ChromeSettingGetDetails * ?callback: DetailsCallback -> unit
            /// <summary>Clears the setting, restoring any default value.</summary>
            /// <param name="details">Which setting to clear.</param>
            /// <param name="callback">Optional. Called at the completion of the clear operation.</param>
            abstract clear: details: ChromeSettingClearDetails * ?callback: Function -> unit
            /// Fired after the setting changes.
            abstract onChange: ChromeSettingChangedEvent with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] ChromeSettingGetResultDetailsLevelOfControl =
            | Not_controllable
            | Controlled_by_other_extensions
            | Controllable_by_this_extension
            | Controlled_by_this_extension

    module VpnProvider =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Creates a new VPN configuration that persists across multiple login sessions of the user.</summary>
            /// <param name="name">The name of the VPN configuration.</param>
            /// <param name="callback">Called when the configuration is created or if there is an error.
            /// Parameter id: A unique ID for the created configuration, empty string on failure.</param>
            abstract createConfig: name: string * callback: (string -> unit) -> unit
            /// <summary>Destroys a VPN configuration created by the extension.</summary>
            /// <param name="id">ID of the VPN configuration to destroy.</param>
            /// <param name="callback">Optional. Called when the configuration is destroyed or if there is an error.</param>
            abstract destroyConfig: id: string * ?callback: Function -> unit
            /// <summary>Sets the parameters for the VPN session. This should be called immediately after "connected" is received from the platform. This will succeed only when the VPN session is owned by the extension.</summary>
            /// <param name="parameters">The parameters for the VPN session.</param>
            /// <param name="callback">Called when the parameters are set or if there is an error.</param>
            abstract setParameters: parameters: VpnSessionParameters * callback: Function -> unit
            /// <summary>Sends an IP packet through the tunnel created for the VPN session. This will succeed only when the VPN session is owned by the extension.</summary>
            /// <param name="data">The IP packet to be sent to the platform.</param>
            /// <param name="callback">Optional. Called when the packet is sent or if there is an error.</param>
            abstract sendPacket: data: ArrayBuffer * ?callback: Function -> unit
            /// <summary>Notifies the VPN session state to the platform. This will succeed only when the VPN session is owned by the extension.</summary>
            /// <param name="state">The VPN session state of the VPN client.
            /// connected: VPN connection was successful.
            /// failure: VPN connection failed.</param>
            /// <param name="callback">Optional. Called when the notification is complete or if there is an error.</param>
            abstract notifyConnectionStateChanged: state: string * ?callback: Function -> unit
            abstract onPlatformMessage: VpnPlatformMessageEvent
            abstract onPacketReceived: VpnPacketReceptionEvent
            abstract onConfigRemoved: VpnConfigRemovalEvent
            abstract onConfigCreated: VpnConfigCreationEvent
            abstract onUIEvent: VpnUiEvent

        type [<AllowNullLiteral>] VpnSessionParameters =
            /// IP address for the VPN interface in CIDR notation. IPv4 is currently the only supported mode.
            abstract address: string with get, set
            /// Optional. Broadcast address for the VPN interface. (default: deduced from IP address and mask)
            abstract broadcastAddress: string option with get, set
            /// Optional. MTU setting for the VPN interface. (default: 1500 bytes)
            abstract mtu: string option with get, set
            /// Exclude network traffic to the list of IP blocks in CIDR notation from the tunnel. This can be used to bypass traffic to and from the VPN server. When many rules match a destination, the rule with the longest matching prefix wins. Entries that correspond to the same CIDR block are treated as duplicates. Such duplicates in the collated (exclusionList + inclusionList) list are eliminated and the exact duplicate entry that will be eliminated is undefined.
            abstract exclusionList: ResizeArray<string> with get, set
            /// Include network traffic to the list of IP blocks in CIDR notation to the tunnel. This parameter can be used to set up a split tunnel. By default no traffic is directed to the tunnel. Adding the entry "0.0.0.0/0" to this list gets all the user traffic redirected to the tunnel. When many rules match a destination, the rule with the longest matching prefix wins. Entries that correspond to the same CIDR block are treated as duplicates. Such duplicates in the collated (exclusionList + inclusionList) list are eliminated and the exact duplicate entry that will be eliminated is undefined.
            abstract inclusionList: ResizeArray<string> with get, set
            /// Optional. A list of search domains. (default: no search domain)
            abstract domainSearch: ResizeArray<string> option with get, set
            /// A list of IPs for the DNS servers.
            abstract dnsServer: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] VpnPlatformMessageEvent =
            inherit Chrome.Events.Event<(string -> string -> string -> unit)>

        type [<AllowNullLiteral>] VpnPacketReceptionEvent =
            inherit Chrome.Events.Event<(ArrayBuffer -> unit)>

        type [<AllowNullLiteral>] VpnConfigRemovalEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] VpnConfigCreationEvent =
            inherit Chrome.Events.Event<(string -> string -> Object -> unit)>

        type [<AllowNullLiteral>] VpnUiEvent =
            inherit Chrome.Events.Event<(string -> string -> unit)>

    module Wallpaper =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Sets wallpaper to the image at url or wallpaperData with the specified layout</summary>
            /// <param name="callback">Optional parameter thumbnail: The jpeg encoded wallpaper thumbnail. It is generated by resizing the wallpaper to 128x60.</param>
            abstract setWallpaper: details: WallpaperDetails * callback: (ArrayBuffer -> unit) -> unit

        type [<AllowNullLiteral>] WallpaperDetails =
            /// Optional. The jpeg or png encoded wallpaper image.
            abstract data: ArrayBuffer option with get, set
            /// Optional. The URL of the wallpaper to be set.
            abstract url: string option with get, set
            /// The supported wallpaper layouts.
            /// One of: "STRETCH", "CENTER", or "CENTER_CROPPED"
            abstract layout: WallpaperDetailsLayout with get, set
            /// The file name of the saved wallpaper.
            abstract filename: string with get, set
            /// Optional. True if a 128x60 thumbnail should be generated.
            abstract thumbnail: bool option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] WallpaperDetailsLayout =
            | [<CompiledName "STRETCH">] STRETCH
            | [<CompiledName "CENTER">] CENTER
            | [<CompiledName "CENTER_CROPPED">] CENTER_CROPPED

    module WebNavigation =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Retrieves information about the given frame. A frame refers to an <iframe> or a <frame> of a web page and is identified by a tab ID and a frame ID.</summary>
            /// <param name="details">Information about the frame to retrieve information about.</param>
            /// <param name="callback">Optional parameter details: Information about the requested frame, null if the specified frame ID and/or tab ID are invalid.</param>
            abstract getFrame: details: GetFrameDetails * callback: (GetFrameResultDetails option -> unit) -> unit
            /// <summary>Retrieves information about the given frame. A frame refers to an <iframe> or a <frame> of a web page and is identified by a tab ID and a frame ID.</summary>
            /// <param name="details">Information about the frame to retrieve information about.</param>
            abstract getFrame: details: GetFrameDetails -> Promise<GetFrameResultDetails option>
            /// <summary>Retrieves information about all frames of a given tab.</summary>
            /// <param name="details">Information about the tab to retrieve all frames from.</param>
            /// <param name="callback">Optional parameter details: A list of frames in the given tab, null if the specified tab ID is invalid.</param>
            abstract getAllFrames: details: GetAllFrameDetails * callback: (ResizeArray<GetAllFrameResultDetails> option -> unit) -> unit
            /// <summary>Retrieves information about all frames of a given tab.</summary>
            /// <param name="details">Information about the tab to retrieve all frames from.</param>
            abstract getAllFrames: details: GetAllFrameDetails -> Promise<ResizeArray<GetAllFrameResultDetails> option>
            abstract onReferenceFragmentUpdated: WebNavigationTransitionalEvent
            abstract onCompleted: WebNavigationFramedEvent
            abstract onHistoryStateUpdated: WebNavigationTransitionalEvent
            abstract onCreatedNavigationTarget: WebNavigationSourceEvent
            abstract onTabReplaced: WebNavigationReplacementEvent
            abstract onBeforeNavigate: WebNavigationParentedEvent
            abstract onCommitted: WebNavigationTransitionalEvent
            abstract onDOMContentLoaded: WebNavigationFramedEvent
            abstract onErrorOccurred: WebNavigationFramedErrorEvent

        type [<AllowNullLiteral>] GetFrameDetails =
            /// The ID of the process runs the renderer for this tab.
            abstract processId: float option with get, set
            /// The ID of the tab in which the frame is.
            abstract tabId: float with get, set
            /// The ID of the frame in the given tab.
            abstract frameId: float with get, set

        type [<AllowNullLiteral>] GetFrameResultDetails =
            /// The URL currently associated with this frame, if the frame identified by the frameId existed at one point in the given tab. The fact that an URL is associated with a given frameId does not imply that the corresponding frame still exists.
            abstract url: string with get, set
            /// True if the last navigation in this frame was interrupted by an error, i.e. the onErrorOccurred event fired.
            abstract errorOccurred: bool with get, set
            /// ID of frame that wraps the frame. Set to -1 of no parent frame exists.
            abstract parentFrameId: float with get, set

        type [<AllowNullLiteral>] GetAllFrameDetails =
            /// The ID of the tab.
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] GetAllFrameResultDetails =
            inherit GetFrameResultDetails
            /// The ID of the process runs the renderer for this tab.
            abstract processId: float with get, set
            /// The ID of the frame. 0 indicates that this is the main frame; a positive value indicates the ID of a subframe.
            abstract frameId: float with get, set

        type [<AllowNullLiteral>] WebNavigationCallbackDetails =
            /// The ID of the tab in which the navigation is about to occur.
            abstract tabId: float with get, set
            /// The time when the browser was about to start the navigation, in milliseconds since the epoch.
            abstract timeStamp: float with get, set

        type [<AllowNullLiteral>] WebNavigationUrlCallbackDetails =
            inherit WebNavigationCallbackDetails
            abstract url: string with get, set

        type [<AllowNullLiteral>] WebNavigationReplacementCallbackDetails =
            inherit WebNavigationCallbackDetails
            /// The ID of the tab that was replaced.
            abstract replacedTabId: float with get, set

        type [<AllowNullLiteral>] WebNavigationFramedCallbackDetails =
            inherit WebNavigationUrlCallbackDetails
            /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique for a given tab and process.
            abstract frameId: float with get, set
            /// The ID of the process runs the renderer for this tab.
            abstract processId: float with get, set

        type [<AllowNullLiteral>] WebNavigationFramedErrorCallbackDetails =
            inherit WebNavigationFramedCallbackDetails
            /// The error description.
            abstract error: string with get, set

        type [<AllowNullLiteral>] WebNavigationSourceCallbackDetails =
            inherit WebNavigationUrlCallbackDetails
            /// The ID of the tab in which the navigation is triggered.
            abstract sourceTabId: float with get, set
            /// The ID of the process runs the renderer for the source tab.
            abstract sourceProcessId: float with get, set
            /// The ID of the frame with sourceTabId in which the navigation is triggered. 0 indicates the main frame.
            abstract sourceFrameId: float with get, set

        type [<AllowNullLiteral>] WebNavigationParentedCallbackDetails =
            inherit WebNavigationFramedCallbackDetails
            /// ID of frame that wraps the frame. Set to -1 of no parent frame exists.
            abstract parentFrameId: float with get, set

        type [<AllowNullLiteral>] WebNavigationTransitionCallbackDetails =
            inherit WebNavigationFramedCallbackDetails
            /// Cause of the navigation.
            /// One of: "link", "typed", "auto_bookmark", "auto_subframe", "manual_subframe", "generated", "start_page", "form_submit", "reload", "keyword", or "keyword_generated"
            abstract transitionType: string with get, set
            /// A list of transition qualifiers.
            /// Each element one of: "client_redirect", "server_redirect", "forward_back", or "from_address_bar"
            abstract transitionQualifiers: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] WebNavigationEventFilter =
            /// Conditions that the URL being navigated to must satisfy. The 'schemes' and 'ports' fields of UrlFilter are ignored for this event.
            abstract url: ResizeArray<Chrome.Events.UrlFilter> with get, set

        type [<AllowNullLiteral>] WebNavigationEvent<'T> =
            inherit Chrome.Events.Event<('T -> unit)>
            /// Registers an event listener callback to an event.
            abstract addListener: callback: ('T -> unit) * ?filters: WebNavigationEventFilter -> unit

        type [<AllowNullLiteral>] WebNavigationFramedEvent =
            inherit WebNavigationEvent<WebNavigationFramedCallbackDetails>

        type [<AllowNullLiteral>] WebNavigationFramedErrorEvent =
            inherit WebNavigationEvent<WebNavigationFramedErrorCallbackDetails>

        type [<AllowNullLiteral>] WebNavigationSourceEvent =
            inherit WebNavigationEvent<WebNavigationSourceCallbackDetails>

        type [<AllowNullLiteral>] WebNavigationParentedEvent =
            inherit WebNavigationEvent<WebNavigationParentedCallbackDetails>

        type [<AllowNullLiteral>] WebNavigationTransitionalEvent =
            inherit WebNavigationEvent<WebNavigationTransitionCallbackDetails>

        type [<AllowNullLiteral>] WebNavigationReplacementEvent =
            inherit WebNavigationEvent<WebNavigationReplacementCallbackDetails>

    module WebRequest =

        type [<AllowNullLiteral>] IExports =
            abstract MAX_HANDLER_BEHAVIOR_CHANGED_CALLS_PER_10_MINUTES: float
            /// Needs to be called when the behavior of the webRequest handlers has changed to prevent incorrect handling due to caching. This function call is expensive. Don't call it often.
            abstract handlerBehaviorChanged: ?callback: Function -> unit
            abstract onBeforeRequest: WebRequestBodyEvent
            abstract onBeforeSendHeaders: WebRequestHeadersSynchronousEvent
            abstract onSendHeaders: WebRequestHeadersEvent
            abstract onHeadersReceived: WebResponseHeadersEvent
            abstract onAuthRequired: WebAuthenticationChallengeEvent
            abstract onResponseStarted: WebResponseCacheEvent
            abstract onBeforeRedirect: WebRedirectionResponseEvent
            abstract onCompleted: WebResponseCacheEvent
            abstract onErrorOccurred: WebResponseErrorEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] ResourceType =
            | Main_frame
            | Sub_frame
            | Stylesheet
            | Script
            | Image
            | Font
            | Object
            | Xmlhttprequest
            | Ping
            | Csp_report
            | Media
            | Websocket
            | Other

        type [<AllowNullLiteral>] AuthCredentials =
            abstract username: string with get, set
            abstract password: string with get, set

        /// An HTTP Header, represented as an object containing a key and either a value or a binaryValue.
        type [<AllowNullLiteral>] HttpHeader =
            abstract name: string with get, set
            abstract value: string option with get, set
            abstract binaryValue: ArrayBuffer option with get, set

        /// Returns value for event handlers that have the 'blocking' extraInfoSpec applied. Allows the event handler to modify network requests.
        type [<AllowNullLiteral>] BlockingResponse =
            /// Optional. If true, the request is cancelled. Used in onBeforeRequest, this prevents the request from being sent.
            abstract cancel: bool option with get, set
            /// Optional.
            /// Only used as a response to the onBeforeRequest and onHeadersReceived events. If set, the original request is prevented from being sent/completed and is instead redirected to the given URL. Redirections to non-HTTP schemes such as data: are allowed. Redirects initiated by a redirect action use the original request method for the redirect, with one exception: If the redirect is initiated at the onHeadersReceived stage, then the redirect will be issued using the GET method.
            abstract redirectUrl: string option with get, set
            /// Optional.
            /// Only used as a response to the onHeadersReceived event. If set, the server is assumed to have responded with these response headers instead. Only return responseHeaders if you really want to modify the headers in order to limit the number of conflicts (only one extension may modify responseHeaders for each request).
            abstract responseHeaders: ResizeArray<HttpHeader> option with get, set
            /// Optional. Only used as a response to the onAuthRequired event. If set, the request is made using the supplied credentials.
            abstract authCredentials: AuthCredentials option with get, set
            /// Optional.
            /// Only used as a response to the onBeforeSendHeaders event. If set, the request is made with these request headers instead.
            abstract requestHeaders: ResizeArray<HttpHeader> option with get, set

        /// An object describing filters to apply to webRequest events.
        type [<AllowNullLiteral>] RequestFilter =
            /// Optional.
            abstract tabId: float option with get, set
            /// A list of request types. Requests that cannot match any of the types will be filtered out.
            abstract types: ResizeArray<ResourceType> option with get, set
            /// A list of URLs or URL patterns. Requests that cannot match any of the URLs will be filtered out.
            abstract urls: ResizeArray<string> with get, set
            /// Optional.
            abstract windowId: float option with get, set

        /// Contains data uploaded in a URL request.
        type [<AllowNullLiteral>] UploadData =
            /// Optional. An ArrayBuffer with a copy of the data.
            abstract bytes: ArrayBuffer option with get, set
            /// Optional. A string with the file's path and name.
            abstract file: string option with get, set

        type [<AllowNullLiteral>] WebRequestBody =
            /// Optional. Errors when obtaining request body data.
            abstract error: string option with get, set
            /// Optional.
            /// If the request method is POST and the body is a sequence of key-value pairs encoded in UTF8, encoded as either multipart/form-data, or application/x-www-form-urlencoded, this dictionary is present and for each key contains the list of all values for that key. If the data is of another media type, or if it is malformed, the dictionary is not present. An example value of this dictionary is {'key': ['value1', 'value2']}.
            abstract formData: WebRequestBodyFormData option with get, set
            /// Optional.
            /// If the request method is PUT or POST, and the body is not already parsed in formData, then the unparsed request body elements are contained in this array.
            abstract raw: ResizeArray<UploadData> option with get, set

        type [<AllowNullLiteral>] WebAuthChallenger =
            abstract host: string with get, set
            abstract port: float with get, set

        type [<AllowNullLiteral>] ResourceRequest =
            abstract url: string with get, set
            /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
            abstract requestId: string with get, set
            /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens. If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame. Frame IDs are unique within a tab.
            abstract frameId: float with get, set
            /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
            abstract parentFrameId: float with get, set
            /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
            abstract tabId: float with get, set
            /// How the requested resource will be used.
            abstract ``type``: ResourceType with get, set
            /// The time when this signal is triggered, in milliseconds since the epoch.
            abstract timeStamp: float with get, set
            /// The origin where the request was initiated. This does not change through redirects. If this is an opaque origin, the string 'null' will be used.
            abstract initiator: string option with get, set

        type [<AllowNullLiteral>] WebRequestDetails =
            inherit ResourceRequest
            /// Standard HTTP method.
            abstract ``method``: string with get, set

        type [<AllowNullLiteral>] WebRequestHeadersDetails =
            inherit WebRequestDetails
            /// Optional. The HTTP request headers that are going to be sent out with this request.
            abstract requestHeaders: ResizeArray<HttpHeader> option with get, set

        type [<AllowNullLiteral>] WebRequestBodyDetails =
            inherit WebRequestDetails
            /// Contains the HTTP request body data. Only provided if extraInfoSpec contains 'requestBody'.
            abstract requestBody: WebRequestBody option with get, set

        type [<AllowNullLiteral>] WebRequestFullDetails =
            inherit WebRequestHeadersDetails
            inherit WebRequestBodyDetails

        type [<AllowNullLiteral>] WebResponseDetails =
            inherit ResourceRequest
            /// HTTP status line of the response or the 'HTTP/0.9 200 OK' string for HTTP/0.9 responses (i.e., responses that lack a status line).
            abstract statusLine: string with get, set
            /// Standard HTTP status code returned by the server.
            abstract statusCode: float with get, set

        type [<AllowNullLiteral>] WebResponseHeadersDetails =
            inherit WebResponseDetails
            /// Optional. The HTTP response headers that have been received with this response.
            abstract responseHeaders: ResizeArray<HttpHeader> option with get, set
            abstract ``method``: string with get, set

        type [<AllowNullLiteral>] WebResponseCacheDetails =
            inherit WebResponseHeadersDetails
            /// Optional.
            /// The server IP address that the request was actually sent to. Note that it may be a literal IPv6 address.
            abstract ip: string option with get, set
            /// Indicates if this response was fetched from disk cache.
            abstract fromCache: bool with get, set

        type [<AllowNullLiteral>] WebRedirectionResponseDetails =
            inherit WebResponseCacheDetails
            /// The new URL.
            abstract redirectUrl: string with get, set

        type [<AllowNullLiteral>] WebAuthenticationChallengeDetails =
            inherit WebResponseHeadersDetails
            /// The authentication scheme, e.g. Basic or Digest.
            abstract scheme: string with get, set
            /// The authentication realm provided by the server, if there is one.
            abstract realm: string option with get, set
            /// The server requesting authentication.
            abstract challenger: WebAuthChallenger with get, set
            /// True for Proxy-Authenticate, false for WWW-Authenticate.
            abstract isProxy: bool with get, set

        type [<AllowNullLiteral>] WebResponseErrorDetails =
            inherit WebResponseCacheDetails
            /// The error description. This string is not guaranteed to remain backwards compatible between releases. You must not parse and act based upon its content.
            abstract error: string with get, set

        type [<AllowNullLiteral>] WebRequestBodyEvent =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<(WebRequestBodyDetails -> U2<BlockingResponse, unit>)>
            abstract addListener: callback: (WebRequestBodyDetails -> U2<BlockingResponse, unit>) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] WebRequestHeadersSynchronousEvent =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<(WebRequestHeadersDetails -> U2<BlockingResponse, unit>)>
            abstract addListener: callback: (WebRequestHeadersDetails -> U2<BlockingResponse, unit>) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] WebRequestHeadersEvent =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<(WebRequestHeadersDetails -> unit)>
            abstract addListener: callback: (WebRequestHeadersDetails -> unit) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] _WebResponseHeadersEvent<'T> =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<('T -> unit)>
            abstract addListener: callback: ('T -> unit) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] WebResponseHeadersEvent =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<(WebResponseHeadersDetails -> U2<BlockingResponse, unit>)>
            abstract addListener: callback: (WebResponseHeadersDetails -> U2<BlockingResponse, unit>) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] WebResponseCacheEvent =
            inherit _WebResponseHeadersEvent<WebResponseCacheDetails>

        type [<AllowNullLiteral>] WebRedirectionResponseEvent =
            inherit _WebResponseHeadersEvent<WebRedirectionResponseDetails>

        type [<AllowNullLiteral>] WebAuthenticationChallengeEvent =
            inherit Chrome.Events.EventWithRequiredFilterInAddListener<(WebAuthenticationChallengeDetails -> (BlockingResponse -> unit) -> unit)>
            abstract addListener: callback: (WebAuthenticationChallengeDetails -> (BlockingResponse -> unit) -> unit) * filter: RequestFilter * ?opt_extraInfoSpec: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] WebResponseErrorEvent =
            inherit _WebResponseHeadersEvent<WebResponseErrorDetails>

        type [<AllowNullLiteral>] WebRequestBodyFormData =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> ResizeArray<string> with get, set

    module Webstore =

        type [<AllowNullLiteral>] IExports =
            /// <param name="url">Optional. If you have more than one <link> tag on your page with the chrome-webstore-item relation, you can choose which item you'd like to install by passing in its URL here. If it is omitted, then the first (or only) link will be used. An exception will be thrown if the passed in URL does not exist on the page.</param>
            /// <param name="successCallback">Optional. This function is invoked when inline installation successfully completes (after the dialog is shown and the user agrees to add the item to Chrome). You may wish to use this to hide the user interface element that prompted the user to install the app or extension.</param>
            /// <param name="failureCallback">Optional. This function is invoked when inline installation does not successfully complete. Possible reasons for this include the user canceling the dialog, the linked item not being found in the store, or the install being initiated from a non-verified site.
            /// Parameter error: The failure detail. You may wish to inspect or log this for debugging purposes, but you should not rely on specific strings being passed back.
            /// Optional parameter errorCode: The error code from the stable set of possible errors.
            /// * Enum of the possible install results, including error codes sent back in the event that an inline installation has failed.
            /// * * "otherError": An uncommon, unrecognized, or unexpected error. In some cases, the readable error string can provide more information.
            /// * * "aborted": The operation was aborted as the requestor is no longer alive.
            /// * * "installInProgress": An installation of the same extension is in progress.
            /// * * "notPermitted": The installation is not permitted.
            /// * * "invalidId": Invalid Chrome Web Store item ID.
            /// * * "webstoreRequestError": Failed to retrieve extension metadata from the Web Store.
            /// * * "invalidWebstoreResponse": The extension metadata retrieved from the Web Store was invalid.
            /// * * "invalidManifest": An error occurred while parsing the extension manifest retrieved from the Web Store.
            /// * * "iconError": Failed to retrieve the extension's icon from the Web Store, or the icon was invalid.
            /// * * "userCanceled": The user canceled the operation.
            /// * * "blacklisted": The extension is blacklisted.
            /// * * "missingDependencies": Unsatisfied dependencies, such as shared modules.
            /// * * "requirementViolations": Unsatisfied requirements, such as webgl.
            /// * * "blockedByPolicy": The extension is blocked by management policies.
            /// * * "launchFeatureDisabled": The launch feature is not available.
            /// * * "launchUnsupportedExtensionType": The launch feature is not supported for the extension type.
            /// * * "launchInProgress": A launch of the same extension is in progress.</param>
            abstract install: url: string * ?successCallback: Function * ?failureCallback: (string -> string -> unit) -> unit
            /// <param name="successCallback">Optional. This function is invoked when inline installation successfully completes (after the dialog is shown and the user agrees to add the item to Chrome). You may wish to use this to hide the user interface element that prompted the user to install the app or extension.</param>
            /// <param name="failureCallback">Optional. This function is invoked when inline installation does not successfully complete. Possible reasons for this include the user canceling the dialog, the linked item not being found in the store, or the install being initiated from a non-verified site.
            /// Parameter error: The failure detail. You may wish to inspect or log this for debugging purposes, but you should not rely on specific strings being passed back.
            /// Optional parameter errorCode: The error code from the stable set of possible errors.
            /// * Enum of the possible install results, including error codes sent back in the event that an inline installation has failed.
            /// * * "otherError": An uncommon, unrecognized, or unexpected error. In some cases, the readable error string can provide more information.
            /// * * "aborted": The operation was aborted as the requestor is no longer alive.
            /// * * "installInProgress": An installation of the same extension is in progress.
            /// * * "notPermitted": The installation is not permitted.
            /// * * "invalidId": Invalid Chrome Web Store item ID.
            /// * * "webstoreRequestError": Failed to retrieve extension metadata from the Web Store.
            /// * * "invalidWebstoreResponse": The extension metadata retrieved from the Web Store was invalid.
            /// * * "invalidManifest": An error occurred while parsing the extension manifest retrieved from the Web Store.
            /// * * "iconError": Failed to retrieve the extension's icon from the Web Store, or the icon was invalid.
            /// * * "userCanceled": The user canceled the operation.
            /// * * "blacklisted": The extension is blacklisted.
            /// * * "missingDependencies": Unsatisfied dependencies, such as shared modules.
            /// * * "requirementViolations": Unsatisfied requirements, such as webgl.
            /// * * "blockedByPolicy": The extension is blocked by management policies.
            /// * * "launchFeatureDisabled": The launch feature is not available.
            /// * * "launchUnsupportedExtensionType": The launch feature is not supported for the extension type.
            /// * * "launchInProgress": A launch of the same extension is in progress.</param>
            abstract install: successCallback: Function * ?failureCallback: (string -> string -> unit) -> unit
            /// <param name="failureCallback">Optional. This function is invoked when inline installation does not successfully complete. Possible reasons for this include the user canceling the dialog, the linked item not being found in the store, or the install being initiated from a non-verified site.
            /// Parameter error: The failure detail. You may wish to inspect or log this for debugging purposes, but you should not rely on specific strings being passed back.
            /// Optional parameter errorCode: The error code from the stable set of possible errors.
            /// * Enum of the possible install results, including error codes sent back in the event that an inline installation has failed.
            /// * * "otherError": An uncommon, unrecognized, or unexpected error. In some cases, the readable error string can provide more information.
            /// * * "aborted": The operation was aborted as the requestor is no longer alive.
            /// * * "installInProgress": An installation of the same extension is in progress.
            /// * * "notPermitted": The installation is not permitted.
            /// * * "invalidId": Invalid Chrome Web Store item ID.
            /// * * "webstoreRequestError": Failed to retrieve extension metadata from the Web Store.
            /// * * "invalidWebstoreResponse": The extension metadata retrieved from the Web Store was invalid.
            /// * * "invalidManifest": An error occurred while parsing the extension manifest retrieved from the Web Store.
            /// * * "iconError": Failed to retrieve the extension's icon from the Web Store, or the icon was invalid.
            /// * * "userCanceled": The user canceled the operation.
            /// * * "blacklisted": The extension is blacklisted.
            /// * * "missingDependencies": Unsatisfied dependencies, such as shared modules.
            /// * * "requirementViolations": Unsatisfied requirements, such as webgl.
            /// * * "blockedByPolicy": The extension is blocked by management policies.
            /// * * "launchFeatureDisabled": The launch feature is not available.
            /// * * "launchUnsupportedExtensionType": The launch feature is not supported for the extension type.
            /// * * "launchInProgress": A launch of the same extension is in progress.</param>
            abstract install: ?failureCallback: (string -> string -> unit) -> unit
            abstract onInstallStageChanged: InstallationStageEvent
            abstract onDownloadProgress: DownloadProgressEvent

        type [<AllowNullLiteral>] InstallationStageEvent =
            inherit Chrome.Events.Event<(string -> unit)>

        type [<AllowNullLiteral>] DownloadProgressEvent =
            inherit Chrome.Events.Event<(float -> unit)>

    module Windows =

        type [<AllowNullLiteral>] IExports =
            abstract WINDOW_ID_CURRENT: obj
            abstract WINDOW_ID_NONE: obj
            /// Gets details about a window.
            abstract get: windowId: float * callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets details about a window.
            abstract get: windowId: float -> Promise<Chrome.Windows.Window>
            /// Gets details about a window.
            abstract get: windowId: float * queryOptions: QueryOptions * callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets details about a window.
            abstract get: windowId: float * queryOptions: QueryOptions -> Promise<Chrome.Windows.Window>
            /// Gets the current window.
            abstract getCurrent: callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets the current window.
            abstract getCurrent: unit -> Promise<Chrome.Windows.Window>
            /// Gets the current window.
            abstract getCurrent: queryOptions: QueryOptions * callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets the current window.
            abstract getCurrent: queryOptions: QueryOptions -> Promise<Chrome.Windows.Window>
            /// Creates (opens) a new browser with any optional sizing, position or default URL provided.
            abstract create: unit -> Promise<Chrome.Windows.Window>
            /// <summary>Creates (opens) a new browser with any optional sizing, position or default URL provided.</summary>
            /// <param name="callback">Optional parameter window: Contains details about the created window.</param>
            abstract create: ?callback: (Chrome.Windows.Window -> unit) -> unit
            /// Creates (opens) a new browser with any optional sizing, position or default URL provided.
            abstract create: createData: CreateData -> Promise<Chrome.Windows.Window>
            /// <summary>Creates (opens) a new browser with any optional sizing, position or default URL provided.</summary>
            /// <param name="callback">Optional parameter window: Contains details about the created window.</param>
            abstract create: createData: CreateData * ?callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets all windows.
            abstract getAll: callback: (ResizeArray<Chrome.Windows.Window> -> unit) -> unit
            /// Gets all windows.
            abstract getAll: unit -> Promise<ResizeArray<Chrome.Windows.Window>>
            /// Gets all windows.
            abstract getAll: queryOptions: QueryOptions * callback: (ResizeArray<Chrome.Windows.Window> -> unit) -> unit
            /// Gets all windows.
            abstract getAll: queryOptions: QueryOptions -> Promise<ResizeArray<Chrome.Windows.Window>>
            /// Updates the properties of a window. Specify only the properties that you want to change; unspecified properties will be left unchanged.
            abstract update: windowId: float * updateInfo: UpdateInfo -> Promise<Chrome.Windows.Window>
            /// Updates the properties of a window. Specify only the properties that you want to change; unspecified properties will be left unchanged.
            abstract update: windowId: float * updateInfo: UpdateInfo * ?callback: (Chrome.Windows.Window -> unit) -> unit
            /// Removes (closes) a window, and all the tabs inside it
            abstract remove: windowId: float -> Promise<unit>
            /// Removes (closes) a window, and all the tabs inside it.
            abstract remove: windowId: float * ?callback: Function -> unit
            /// Gets the window that was most recently focused — typically the window 'on top'.
            abstract getLastFocused: callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets the window that was most recently focused — typically the window 'on top'.
            abstract getLastFocused: unit -> Promise<Chrome.Windows.Window>
            /// Gets the window that was most recently focused — typically the window 'on top'.
            abstract getLastFocused: queryOptions: QueryOptions * callback: (Chrome.Windows.Window -> unit) -> unit
            /// Gets the window that was most recently focused — typically the window 'on top'.
            abstract getLastFocused: queryOptions: QueryOptions -> Promise<Chrome.Windows.Window>
            abstract onRemoved: WindowIdEvent
            abstract onCreated: WindowReferenceEvent
            abstract onFocusChanged: WindowIdEvent
            abstract onBoundsChanged: WindowReferenceEvent

        type [<AllowNullLiteral>] Window =
            /// Optional. Array of tabs.Tab objects representing the current tabs in the window.
            abstract tabs: ResizeArray<Chrome.Tabs.Tab> option with get, set
            /// Optional. The offset of the window from the top edge of the screen in pixels. Under some circumstances a Window may not be assigned top property, for example when querying closed windows from the sessions API.
            abstract top: float option with get, set
            /// Optional. The height of the window, including the frame, in pixels. Under some circumstances a Window may not be assigned height property, for example when querying closed windows from the sessions API.
            abstract height: float option with get, set
            /// Optional. The width of the window, including the frame, in pixels. Under some circumstances a Window may not be assigned width property, for example when querying closed windows from the sessions API.
            abstract width: float option with get, set
            /// The state of this browser window.
            abstract state: windowStateEnum option with get, set
            /// Whether the window is currently the focused window.
            abstract focused: bool with get, set
            /// Whether the window is set to be always on top.
            abstract alwaysOnTop: bool with get, set
            /// Whether the window is incognito.
            abstract incognito: bool with get, set
            /// The type of browser window this is.
            abstract ``type``: windowTypeEnum option with get, set
            /// Optional. The ID of the window. Window IDs are unique within a browser session. Under some circumstances a Window may not be assigned an ID, for example when querying windows using the sessions API, in which case a session ID may be present.
            abstract id: float option with get, set
            /// Optional. The offset of the window from the left edge of the screen in pixels. Under some circumstances a Window may not be assigned left property, for example when querying closed windows from the sessions API.
            abstract left: float option with get, set
            /// Optional. The session ID used to uniquely identify a Window obtained from the sessions API.
            abstract sessionId: string option with get, set

        type [<AllowNullLiteral>] QueryOptions =
            /// Optional.
            /// If true, the windows.Window object will have a tabs property that contains a list of the tabs.Tab objects.
            /// The Tab objects only contain the url, pendingUrl, title and favIconUrl properties if the extension's manifest file includes the "tabs" permission.
            abstract populate: bool option with get, set
            /// If set, the Window returned is filtered based on its type. If unset, the default filter is set to ['normal', 'popup'].
            abstract windowTypes: ResizeArray<windowTypeEnum> option with get, set

        type [<AllowNullLiteral>] CreateData =
            /// Optional. The id of the tab for which you want to adopt to the new window.
            abstract tabId: float option with get, set
            /// Optional.
            /// A URL or array of URLs to open as tabs in the window. Fully-qualified URLs must include a scheme (i.e. 'http://www.google.com', not 'www.google.com'). Relative URLs will be relative to the current page within the extension. Defaults to the New Tab Page.
            abstract url: U2<string, ResizeArray<string>> option with get, set
            /// Optional.
            /// The number of pixels to position the new window from the top edge of the screen. If not specified, the new window is offset naturally from the last focused window. This value is ignored for panels.
            abstract top: float option with get, set
            /// Optional.
            /// The height in pixels of the new window, including the frame. If not specified defaults to a natural height.
            abstract height: float option with get, set
            /// Optional.
            /// The width in pixels of the new window, including the frame. If not specified defaults to a natural width.
            abstract width: float option with get, set
            /// Optional. If true, opens an active window. If false, opens an inactive window.
            abstract focused: bool option with get, set
            /// Optional. Whether the new window should be an incognito window.
            abstract incognito: bool option with get, set
            /// Optional. Specifies what type of browser window to create.
            abstract ``type``: createTypeEnum option with get, set
            /// Optional.
            /// The number of pixels to position the new window from the left edge of the screen. If not specified, the new window is offset naturally from the last focused window. This value is ignored for panels.
            abstract left: float option with get, set
            /// Optional. The initial state of the window. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined with 'left', 'top', 'width' or 'height'.
            abstract state: windowStateEnum option with get, set
            /// If true, the newly-created window's 'window.opener' is set to the caller and is in the same [unit of related browsing contexts](https://www.w3.org/TR/html51/browsers.html#unit-of-related-browsing-contexts) as the caller.
            abstract setSelfAsOpener: bool option with get, set

        type [<AllowNullLiteral>] UpdateInfo =
            /// Optional. The offset from the top edge of the screen to move the window to in pixels. This value is ignored for panels.
            abstract top: float option with get, set
            /// Optional. If true, causes the window to be displayed in a manner that draws the user's attention to the window, without changing the focused window. The effect lasts until the user changes focus to the window. This option has no effect if the window already has focus. Set to false to cancel a previous draw attention request.
            abstract drawAttention: bool option with get, set
            /// Optional. The height to resize the window to in pixels. This value is ignored for panels.
            abstract height: float option with get, set
            /// Optional. The width to resize the window to in pixels. This value is ignored for panels.
            abstract width: float option with get, set
            /// Optional. The new state of the window. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined with 'left', 'top', 'width' or 'height'.
            abstract state: windowStateEnum option with get, set
            /// Optional. If true, brings the window to the front. If false, brings the next window in the z-order to the front.
            abstract focused: bool option with get, set
            /// Optional. The offset from the left edge of the screen to move the window to in pixels. This value is ignored for panels.
            abstract left: float option with get, set

        type [<AllowNullLiteral>] WindowEventFilter =
            /// Conditions that the window's type being created must satisfy. By default it will satisfy ['app', 'normal', 'panel', 'popup'], with 'app' and 'panel' window types limited to the extension's own windows.
            abstract windowTypes: ResizeArray<windowTypeEnum> with get, set

        type [<AllowNullLiteral>] WindowIdEvent =
            inherit Chrome.Events.Event<(float -> unit)>
            /// Registers an event listener callback to an event.
            abstract addListener: callback: (float -> unit) * ?filters: WindowEventFilter -> unit

        type [<AllowNullLiteral>] WindowReferenceEvent =
            inherit Chrome.Events.Event<(Window -> unit)>
            /// Registers an event listener callback to an event.
            abstract addListener: callback: (Window -> unit) * ?filters: WindowEventFilter -> unit

        type [<StringEnum>] [<RequireQualifiedAccess>] createTypeEnum =
            | Normal
            | Popup
            | Panel

        type [<StringEnum>] [<RequireQualifiedAccess>] windowStateEnum =
            | Normal
            | Minimized
            | Maximized
            | Fullscreen
            | [<CompiledName "locked-fullscreen">] LockedFullscreen

        type [<StringEnum>] [<RequireQualifiedAccess>] windowTypeEnum =
            | Normal
            | Popup
            | Panel
            | App
            | Devtools

    module DeclarativeNetRequest =

        type [<AllowNullLiteral>] IExports =
            abstract DYNAMIC_RULESET_ID: string
            abstract GETMATCHEDRULES_QUOTA_INTERVAL: float
            abstract GUARANTEED_MINIMUM_STATIC_RULES: float
            abstract MAX_GETMATCHEDRULES_CALLS_PER_INTERVAL: float
            abstract MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES: float
            abstract MAX_NUMBER_OF_REGEX_RULES: float
            abstract MAX_NUMBER_OF_STATIC_RULESETS: float
            abstract SESSION_RULESET_ID: string
            /// Returns the number of static rules an extension can enable before the global static rule limit is reached.
            abstract getAvailableStaticRuleCount: callback: (float -> unit) -> unit
            /// Returns the number of static rules an extension can enable before the global static rule limit is reached.
            abstract getAvailableStaticRuleCount: unit -> Promise<float>
            /// <summary>Returns the current set of dynamic rules for the extension.</summary>
            /// <param name="callback">Called with the set of dynamic rules.
            /// An error might be raised in case of transient internal errors.</param>
            abstract getDynamicRules: callback: (ResizeArray<Rule> -> unit) -> unit
            /// Returns the current set of dynamic rules for the extension.
            abstract getDynamicRules: unit -> Promise<ResizeArray<Rule>>
            /// <summary>Returns the ids for the current set of enabled static rulesets.</summary>
            /// <param name="callback">Called with a list of ids, where each id corresponds to an enabled static Ruleset.</param>
            abstract getEnabledRulesets: callback: (ResizeArray<string> -> unit) -> unit
            /// Returns the ids for the current set of enabled static rulesets.
            abstract getEnabledRulesets: unit -> Promise<ResizeArray<string>>
            /// <summary>Returns all rules matched for the extension.
            /// Callers can optionally filter the list of matched rules by specifying a filter.
            /// This method is only available to extensions with the declarativeNetRequestFeedback permission or having the activeTab permission granted for the tabId specified in filter.
            /// Note: Rules not associated with an active document that were matched more than five minutes ago will not be returned.</summary>
            /// <param name="filter">An object to filter the list of matched rules.</param>
            /// <param name="callback">Called once the list of matched rules has been fetched.
            /// In case of an error, runtime.lastError will be set and no rules will be returned.
            /// This can happen for multiple reasons, such as insufficient permissions, or exceeding the quota.</param>
            abstract getMatchedRules: filter: MatchedRulesFilter option * callback: (RulesMatchedDetails -> unit) -> unit
            /// <summary>Returns all rules matched for the extension.
            /// Callers can optionally filter the list of matched rules by specifying a filter.
            /// This method is only available to extensions with the declarativeNetRequestFeedback permission or having the activeTab permission granted for the tabId specified in filter.
            /// Note: Rules not associated with an active document that were matched more than five minutes ago will not be returned.</summary>
            /// <param name="filter">An object to filter the list of matched rules.</param>
            abstract getMatchedRules: filter: MatchedRulesFilter option -> Promise<RulesMatchedDetails>
            abstract getMatchedRules: callback: (RulesMatchedDetails -> unit) -> unit
            abstract getMatchedRules: unit -> Promise<RulesMatchedDetails>
            /// <summary>Returns the current set of session scoped rules for the extension.</summary>
            /// <param name="callback">Called with the set of session scoped rules.</param>
            abstract getSessionRules: callback: (ResizeArray<Rule> -> unit) -> unit
            /// Returns the current set of session scoped rules for the extension.
            abstract getSessionRules: unit -> Promise<ResizeArray<Rule>>
            /// <summary>Checks if the given regular expression will be supported as a regexFilter rule condition.</summary>
            /// <param name="regexOptions">The regular expression to check.</param>
            /// <param name="callback">Called with details consisting of whether the regular expression is supported and the
            /// reason if not.</param>
            abstract isRegexSupported: regexOptions: RegexOptions * callback: (IsRegexSupportedResult -> unit) -> unit
            /// <summary>Checks if the given regular expression will be supported as a regexFilter rule condition.</summary>
            /// <param name="regexOptions">The regular expression to check.</param>
            abstract isRegexSupported: regexOptions: RegexOptions -> Promise<IsRegexSupportedResult>
            /// Configures if the action count for tabs should be displayed as the extension action's badge text and provides a way for that action count to be incremented.
            abstract setExtensionActionOptions: options: ExtensionActionOptions * callback: Function -> unit
            /// Configures if the action count for tabs should be displayed as the extension action's badge text and provides a way for that action count to be incremented.
            abstract setExtensionActionOptions: options: ExtensionActionOptions -> Promise<unit>
            /// <summary>Modifies the current set of dynamic rules for the extension.
            /// The rules with IDs listed in options.removeRuleIds are first removed, and then the rules given in options.addRules are added.
            /// 
            /// Notes:
            /// This update happens as a single atomic operation: either all specified rules are added and removed, or an error is returned.
            /// These rules are persisted across browser sessions and across extension updates.
            /// Static rules specified as part of the extension package can not be removed using this function.
            /// MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES is the maximum number of combined dynamic and session rules an extension can add.</summary>
            /// <param name="callback">Called once the update is complete or has failed.
            /// In case of an error, runtime.lastError will be set and no change will be made to the rule set.
            /// This can happen for multiple reasons, such as invalid rule format, duplicate rule ID, rule count limit exceeded, internal errors, and others.</param>
            abstract updateDynamicRules: options: UpdateRuleOptions * callback: Function -> unit
            /// Modifies the current set of dynamic rules for the extension.
            /// The rules with IDs listed in options.removeRuleIds are first removed, and then the rules given in options.addRules are added.
            /// 
            /// Notes:
            /// This update happens as a single atomic operation: either all specified rules are added and removed, or an error is returned.
            /// These rules are persisted across browser sessions and across extension updates.
            /// Static rules specified as part of the extension package can not be removed using this function.
            /// MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES is the maximum number of combined dynamic and session rules an extension can add.
            abstract updateDynamicRules: options: UpdateRuleOptions -> Promise<unit>
            /// <summary>Updates the set of enabled static rulesets for the extension.
            /// The rulesets with IDs listed in options.disableRulesetIds are first removed, and then the rulesets listed in options.enableRulesetIds are added.
            /// 
            /// Note that the set of enabled static rulesets is persisted across sessions but not across extension updates, i.e. the rule_resources manifest key will determine the set of enabled static rulesets on each extension update.</summary>
            /// <param name="callback">Called once the update is complete.
            /// In case of an error, runtime.lastError will be set and no change will be made to set of enabled rulesets.
            /// This can happen for multiple reasons, such as invalid ruleset IDs, rule count limit exceeded, or internal errors.</param>
            abstract updateEnabledRulesets: options: UpdateRulesetOptions * callback: Function -> unit
            /// Updates the set of enabled static rulesets for the extension.
            /// The rulesets with IDs listed in options.disableRulesetIds are first removed, and then the rulesets listed in options.enableRulesetIds are added.
            /// 
            /// Note that the set of enabled static rulesets is persisted across sessions but not across extension updates, i.e. the rule_resources manifest key will determine the set of enabled static rulesets on each extension update.
            abstract updateEnabledRulesets: options: UpdateRulesetOptions -> Promise<unit>
            /// <summary>Modifies the current set of session scoped rules for the extension.
            /// The rules with IDs listed in options.removeRuleIds are first removed, and then the rules given in options.addRules are added.
            /// 
            /// Notes:
            /// This update happens as a single atomic operation: either all specified rules are added and removed, or an error is returned.
            /// These rules are not persisted across sessions and are backed in memory.
            /// MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES is the maximum number of combined dynamic and session rules an extension can add.</summary>
            /// <param name="callback">Called once the update is complete or has failed.
            /// In case of an error, runtime.lastError will be set and no change will be made to the rule set.
            /// This can happen for multiple reasons, such as invalid rule format, duplicate rule ID, rule count limit exceeded, and others.</param>
            abstract updateSessionRules: options: UpdateRuleOptions * callback: Function -> unit
            /// Modifies the current set of session scoped rules for the extension.
            /// The rules with IDs listed in options.removeRuleIds are first removed, and then the rules given in options.addRules are added.
            /// 
            /// Notes:
            /// This update happens as a single atomic operation: either all specified rules are added and removed, or an error is returned.
            /// These rules are not persisted across sessions and are backed in memory.
            /// MAX_NUMBER_OF_DYNAMIC_AND_SESSION_RULES is the maximum number of combined dynamic and session rules an extension can add.
            abstract updateSessionRules: options: UpdateRuleOptions -> Promise<unit>
            abstract onRuleMatchedDebug: RuleMatchedDebugEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] RequestMethod =
            | [<CompiledName "connect">] CONNECT
            | [<CompiledName "delete">] DELETE
            | [<CompiledName "get">] GET
            | [<CompiledName "head">] HEAD
            | [<CompiledName "options">] OPTIONS
            | [<CompiledName "patch">] PATCH
            | [<CompiledName "post">] POST
            | [<CompiledName "put">] PUT

        type [<StringEnum>] [<RequireQualifiedAccess>] ResourceType =
            | [<CompiledName "main_frame">] MAIN_FRAME
            | [<CompiledName "sub_frame">] SUB_FRAME
            | [<CompiledName "stylesheet">] STYLESHEET
            | [<CompiledName "script">] SCRIPT
            | [<CompiledName "image">] IMAGE
            | [<CompiledName "font">] FONT
            | [<CompiledName "object">] OBJECT
            | [<CompiledName "xmlhttprequest">] XMLHTTPREQUEST
            | [<CompiledName "ping">] PING
            | [<CompiledName "csp_report">] CSP_REPORT
            | [<CompiledName "media">] MEDIA
            | [<CompiledName "websocket">] WEBSOCKET
            | [<CompiledName "other">] OTHER

        type [<StringEnum>] [<RequireQualifiedAccess>] RuleActionType =
            | [<CompiledName "block">] BLOCK
            | [<CompiledName "redirect">] REDIRECT
            | [<CompiledName "allow">] ALLOW
            | [<CompiledName "upgradeScheme">] UPGRADE_SCHEME
            | [<CompiledName "modifyHeaders">] MODIFY_HEADERS
            | [<CompiledName "allowAllRequests">] ALLOW_ALL_REQUESTS

        type [<StringEnum>] [<RequireQualifiedAccess>] UnsupportedRegexReason =
            | [<CompiledName "syntaxError">] SYNTAX_ERROR
            | [<CompiledName "memoryLimitExceeded">] MEMORY_LIMIT_EXCEEDED

        type [<StringEnum>] [<RequireQualifiedAccess>] DomainType =
            | [<CompiledName "firstParty">] FIRST_PARTY
            | [<CompiledName "thirdParty">] THIRD_PARTY

        type [<StringEnum>] [<RequireQualifiedAccess>] HeaderOperation =
            | [<CompiledName "append">] APPEND
            | [<CompiledName "set">] SET
            | [<CompiledName "remove">] REMOVE

        type [<AllowNullLiteral>] RequestDetails =
            /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
            /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
            /// Frame IDs are unique within a tab.
            abstract frameId: float with get, set
            /// The origin where the request was initiated.
            /// This does not change through redirects.
            /// If this is an opaque origin, the string 'null' will be used.
            abstract initiator: string option with get, set
            /// Standard HTTP method.
            abstract ``method``: string with get, set
            /// ID of frame that wraps the frame which sent the request.
            /// Set to -1 if no parent frame exists.
            abstract partentFrameId: float with get, set
            /// The ID of the request.
            /// Request IDs are unique within a browser session.
            abstract requestId: string with get, set
            /// The ID of the tab in which the request takes place.
            /// Set to -1 if the request isn't related to a tab.
            abstract tabId: float with get, set
            /// The resource type of the request.
            abstract ``type``: ResourceType with get, set
            /// The URL of the request.
            abstract url: string with get, set

        type [<AllowNullLiteral>] Rule =
            /// The action to take if this rule is matched.
            abstract action: RuleAction with get, set
            /// The condition under which this rule is triggered.
            abstract condition: RuleCondition with get, set
            /// An id which uniquely identifies a rule.
            /// Mandatory and should be >= 1.
            abstract id: float with get, set
            /// Rule priority.
            /// Defaults to 1.
            /// When specified, should be >= 1.
            abstract priority: float option with get, set

        type [<AllowNullLiteral>] RuleAction =
            /// Describes how the redirect should be performed.
            /// Only valid for redirect rules.
            abstract redirect: Redirect option with get, set
            /// The request headers to modify for the request.
            /// Only valid if RuleActionType is "modifyHeaders".
            abstract requestHeaders: ResizeArray<ModifyHeaderInfo> option with get, set
            /// The response headers to modify for the request.
            /// Only valid if RuleActionType is "modifyHeaders".
            abstract responseHeaders: ResizeArray<ModifyHeaderInfo> option with get, set
            /// The type of action to perform.
            abstract ``type``: RuleActionType with get, set

        type [<AllowNullLiteral>] RuleCondition =
            interface end

        type [<AllowNullLiteral>] MatchedRule =
            /// A matching rule's ID.
            abstract ruleId: float with get, set
            /// ID of the Ruleset this rule belongs to.
            /// For a rule originating from the set of dynamic rules, this will be equal to DYNAMIC_RULESET_ID.
            abstract rulesetId: string with get, set

        type [<AllowNullLiteral>] MatchedRuleInfo =
            abstract rule: MatchedRule with get, set
            /// The tabId of the tab from which the request originated if the tab is still active. Else -1.
            abstract tabId: float with get, set
            /// The time the rule was matched.
            /// Timestamps will correspond to the Javascript convention for times, i.e. number of milliseconds since the epoch.
            abstract timeStamp: float with get, set

        type [<AllowNullLiteral>] MatchedRulesFilter =
            /// If specified, only matches rules after the given timestamp.
            abstract minTimeStamp: float option with get, set
            /// If specified, only matches rules for the given tab.
            /// Matches rules not associated with any active tab if set to -1.
            abstract tabId: float option with get, set

        type [<AllowNullLiteral>] ModifyHeaderInfo =
            /// The name of the header to be modified.
            abstract header: string with get, set
            /// The operation to be performed on a header.
            abstract operation: HeaderOperation with get, set
            /// The new value for the header.
            /// Must be specified for append and set operations.
            abstract value: string option with get, set

        type [<AllowNullLiteral>] QueryKeyValue =
            abstract key: string with get, set
            abstract value: string with get, set

        type [<AllowNullLiteral>] QueryTransform =
            /// The list of query key-value pairs to be added or replaced.
            abstract addOrReplaceParams: ResizeArray<QueryKeyValue> option with get, set
            /// The list of query keys to be removed.
            abstract removeParams: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] URLTransform =
            /// The new fragment for the request.
            /// Should be either empty, in which case the existing fragment is cleared; or should begin with '#'.
            abstract fragment: string option with get, set
            /// The new host for the request.
            abstract host: string option with get, set
            /// The new password for the request.
            abstract password: string option with get, set
            /// The new path for the request.
            /// If empty, the existing path is cleared.
            abstract path: string option with get, set
            /// The new port for the request.
            /// If empty, the existing port is cleared.
            abstract port: string option with get, set
            /// The new query for the request.
            /// Should be either empty, in which case the existing query is cleared; or should begin with '?'.
            abstract query: string option with get, set
            /// Add, remove or replace query key-value pairs.
            abstract queryTransform: QueryTransform option with get, set
            /// The new scheme for the request.
            /// Allowed values are "http", "https", "ftp" and "chrome-extension".
            abstract scheme: string option with get, set
            /// The new username for the request.
            abstract username: string option with get, set

        type [<AllowNullLiteral>] RegexOptions =
            /// Whether the regex specified is case sensitive.
            /// Default is true.
            abstract isCaseSensitive: bool option with get, set
            /// The regular expresson to check.
            abstract regex: string with get, set
            /// Whether the regex specified requires capturing.
            /// Capturing is only required for redirect rules which specify a regexSubstition action.
            /// The default is false.
            abstract requireCapturing: bool option with get, set

        type [<AllowNullLiteral>] IsRegexSupportedResult =
            abstract isSupported: bool with get, set
            /// Specifies the reason why the regular expression is not supported.
            /// Only provided if isSupported is false.
            abstract reason: UnsupportedRegexReason option with get, set

        type [<AllowNullLiteral>] TabActionCountUpdate =
            /// The amount to increment the tab's action count by.
            /// Negative values will decrement the count
            abstract increment: float with get, set
            /// The tab for which to update the action count.
            abstract tabId: float with get, set

        type [<AllowNullLiteral>] ExtensionActionOptions =
            /// Whether to automatically display the action count for a page as the extension's badge text.
            /// This preference is persisted across sessions.
            abstract displayActionCountAsBadgeText: bool option with get, set
            /// Details of how the tab's action count should be adjusted.
            abstract tabUpdate: TabActionCountUpdate option with get, set

        type [<AllowNullLiteral>] Redirect =
            /// Path relative to the extension directory.
            /// Should start with '/'.
            abstract extensionPath: string option with get, set
            /// Substitution pattern for rules which specify a regexFilter.
            /// The first match of regexFilter within the url will be replaced with this pattern.
            /// Within regexSubstitution, backslash-escaped digits (\1 to \9) can be used to insert the corresponding capture groups.
            /// \0 refers to the entire matching text.
            abstract regexSubstitution: string option with get, set
            /// Url transformations to perform.
            abstract transform: URLTransform option with get, set
            /// The redirect url.
            /// Redirects to JavaScript urls are not allowed.
            abstract url: string option with get, set

        type [<AllowNullLiteral>] UpdateRuleOptions =
            /// Rules to add.
            abstract addRules: ResizeArray<Rule> option with get, set
            /// IDs of the rules to remove.
            /// Any invalid IDs will be ignored.
            abstract removeRuleIds: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] UpdateRulesetOptions =
            /// The set of ids corresponding to a static Ruleset that should be disabled.
            abstract disableRulesetIds: ResizeArray<string> option with get, set
            /// The set of ids corresponding to a static Ruleset that should be enabled.
            abstract enableRulesetIds: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] MatchedRuleInfoDebug =
            /// Details about the request for which the rule was matched.
            abstract request: RequestDetails with get, set
            abstract rule: MatchedRule with get, set

        type [<AllowNullLiteral>] Ruleset =
            /// Whether the ruleset is enabled by default.
            abstract enabled: bool with get, set
            /// A non-empty string uniquely identifying the ruleset.
            /// IDs beginning with '_' are reserved for internal use.
            abstract id: string with get, set
            /// The path of the JSON ruleset relative to the extension directory.
            abstract path: string with get, set

        type [<AllowNullLiteral>] RulesMatchedDetails =
            /// Rules matching the given filter.
            abstract rulesMatchedInfo: ResizeArray<MatchedRuleInfo> with get, set

        /// The rule that has been matched along with information about the associated request.
        type [<AllowNullLiteral>] RuleMatchedDebugEvent =
            inherit Chrome.Events.Event<(MatchedRuleInfoDebug -> unit)>


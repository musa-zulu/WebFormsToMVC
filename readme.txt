							Understanding Web Forms
							------------------------
. Built on ASP.NET offers features such as 
 - HTTP Modules and Handlers
 - Security and user roles
 - Session
 - Caching
 - and much more
. The web forms framework itself also provides some interesting fetures such as 
 - Markup Generation
 - Illusion of state
 - Code Separation
 - Reusable Components

Tightly coupled components 
--------------------------
 - Client and server side code are directly tied together (Home.aspx[Client Side Code] ---- Home.aspx.cs[Server Side Code])

Notes
-----
 - Web forms has not aged well interms of supporting morden concerpts like unit testing and dependancy injection
 - Not flexible to handle ajax request and other web service type behaviour 


------------------------------------------------------------------------------------------------------------------------------------
							The MVC Pattern
						       -----------------

. MVC is powerful extensible and embraces modern web design patterns.
. MVC pattern is naturally split into three loosely coupled layers that really corresponds well with how the web works
 - The View is what the user sees and interacts with.
 - The Model is the data that the user is trying to utilise and access usually from some source of database.
 - The applications controller successfully manages the requests and responses between the two.
 - You can easily inject additional layers 
   - Service Layers or Repository Layers can be added between the Controller and Model
   - Front end frameworks on to the view such as (Angular, Knockout or even alternate view engines)
 - MVC does not offer high level abstractions over http request (it's entire pipeline is built around directly mapping request to methods on the controller)
 - [Remote] -------- Http requests (No view state) --------> [Controller Methods]
 - [Remote] <------- Http responses (No view state) -------- [Controller Methods] 

The MVC Request life cycle
 . Routing/Handler (Match URL to route, which has an associated HttpHandler) 
---->>Controller Initialization(HttpHandler builds the right controller based on the route data)
 --->> Action Method Execution (Generates the response data and chooses an appropriate format) --->> Action result Execution (WWrite the data to the response stream in the chosen format)
 --->> View Engine (If the format is HTML parse and render the view)

Handling requests with with controllers
 . MVC handles http requests by mapping them to methods on the controller (mysite/Person/Index)
 . These methods are called action methods because they represent an action by the user
 . A single controller can handle many requests and respond to each one with different types of data
 . Action methods are selected by the mvc framework itself to execute for a request
 . The is an internal component in mvc called Action invoker that uses a variarity of criteria

 - -----------------------------------------------------------------------------------------------------------------------------------
 							Summarizing Modules and Handlers
	ASP.NET	Platform			       ----------------------------------
 - Session 
 - Handlers & Modules 
 - Routing
 - And much more

 - HttpHandler component is responsible for generating a response for a request
 - There is only one handler per request
 - HttpModules Hook into application events to provide supporting features
 - HttpHandlers Selected and executed by ASP.NET to generate a response for a request.

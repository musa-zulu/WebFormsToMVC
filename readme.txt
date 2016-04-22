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
 

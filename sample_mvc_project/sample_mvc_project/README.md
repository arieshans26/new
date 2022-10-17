# Views and Controllers Management

## Views
    These are the components that display the app's user interface (UI). Generally, this UI displays the model data.

## Controllers
    These are responsible for handling Http request from the client.
    They also retrieve model data and call view templates that return a response.


**_Note:_** In creating a MVC framework in visual studio (windows/mac). Select the MVC Template upon creating the project.
_Refer to the previous discussion about setting up a MVC project._

## How to implement controllers?
    1. After creating MVC project using MVC template, you already have pre-made folders of Models, Views and Controllers.
    2. Select the Controllers foldere and right-click on it. Then select Add -> ASP.net -> Controller Class -> Change name to name.cs.
    3. After that, you have successfully made a controller. Try running it.
    4. Once you have created that controller, you can now modify it. (See ProfileController.cs)
        4.1 Every public method in a controller is callable as an HTTP endpoint. In the sample above, both methods return a string.
        4.2 An HTTP endpoint: Is a targetable URL in the web application, such as protocol://TCP:{PORT}/ControllerName.
        4.3 When passing value through controllers, use '=' to assign value to the variable, use '&' to go to indicate next variable and use '%20' to represent space.


**_Note:_**
    You can see and change the default landing page of your app. Just go to Program.cs and look at the App.MapControllerRoute section.
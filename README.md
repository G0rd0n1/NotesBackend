# Notes Backend API

### This API Controller allows users to perform CRUD (Create, Read, Update, Delete) operations on a Notes entity. 

## The controller is built using Microsoft's ASP.NET Core framework and utilizes Entity Framework Core to interact with a database.
Routes:
* GET api/Notes/GetAllNotes: Returns all Notes in the database.
* POST api/Notes/AddNotes: Adds a new Note to the database.
* PATCH api/Notes/UpdateNotes/{id}: Updates an existing Note with the specified id.
* DELETE api/Notes/DeleteNote/{id}: Deletes an existing Note with the specified id.
## Controller Class:
* NotesController: Inherits from the ControllerBase class provided by ASP.NET Core.
* NotesDbContext: An instance of NotesDbContext is created in the constructor of the NotesController class. NotesDbContext is a class that extends DbContext, and provides access to the database.
## Methods:
* GetAllNotes: This method returns a list of all Notes in the database. It is decorated with the [HttpGet] attribute and has the route "GetAllNotes". It returns an IEnumerable<Notes>.
* AddNotes: This method adds a new Note to the database. It is decorated with the [HttpPost] attribute and has the route "AddNotes". It takes a Notes object as input and returns the same object after it has been added to the database.
* UpdateNotes: This method updates an existing Note in the database. It is decorated with the [HttpPatch] attribute and has the route "UpdateNotes/{id}". It takes a Notes object as input and returns the same object after it has been updated in the database.
* DeleteNote: This method deletes an existing Note from the database. It is decorated with the [HttpDelete] attribute and has the route "DeleteNote/{id}". It takes an integer id as input and returns a boolean value indicating whether the deletion was successful or not.
## HTTP Status Codes:
* GET: Returns a 200 OK status code if successful. Returns a 404 Not Found status code if no Notes are found in the database.
* POST: Returns a 201 Created status code if successful.
* PATCH: Returns a 204 No Content status code if successful.
* DELETE: Returns a 200 OK status code if successful. Returns a 404 Not Found status code if the specified Note does not exist in the database.

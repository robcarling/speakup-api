##Speakup API

**Get All Comments**
----
  Returns json data of all comments.

* **URL**

  /api/comments/

* **Method:**

  `GET`
  
*  **URL Params**

    None

*  **Data Params**

    None

* **Success Response:**

  * **Code:** 200
    **Content:** `{ id : 1, name : "Michael Jordan", commentBody : "This is the comment from this user" }`
 
* **Sample Request:**

  `curl -X GET "https://localhost:5001/api/comments" -H "accept: application/json" -k`


**Add a Comment**
----
  Add a comment.

* **URL**

  /api/comments/

* **Method:**

  `POST`
  
* **URL Params**

  None

* **Data Params**

  * `name:` Name of the commenter
  * `commentBody:` The comment itself

* **Success Response:**

  * **Code:** 200
    **Content:** `{ id : 1, name : "Michael Jordan", commentBody : "This is the comment from this user" ... }`
 
* **Sample Request:**

  ```
  {
    "name": "Rob",
    "commentBody": "This is a new comment."
  }
  ```


## To-Dos

* Additional Validation
* Add Swagger Documentation
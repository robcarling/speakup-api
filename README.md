#Speakup API

**Get All Comments**
----
  Returns json data of all comments.

* **URL**

  /comments/

* **Method:**

  `GET`
  
*  **URL Params**

  None

* **Data Params**

  None

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ id : 1, name : "Michael Jordan", commentBody : "This is the comment from this user" }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ error : "User doesn't exist" }`

  OR

  * **Code:** 401 UNAUTHORIZED <br />
    **Content:** `{ error : "You are unauthorized to make this request." }`

* **Sample Call:**

  ```javascript
    $.ajax({
      url: "/comments",
      dataType: "json",
      type : "GET",
      success : function(r) {
        console.log(r);
      }
    });
  ```

**Add a Comment**
----
  Add 

* **URL**

  /comments/

* **Method:**

  `POST`
  
*  **URL Params**

  None

* **Data Params**

  Name, Comment Body

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ id : 1, name : "Michael Jordan", commentBody : "This is the comment from this user" ... }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ error : "User doesn't exist" }`

  OR

  * **Code:** 401 UNAUTHORIZED <br />
    **Content:** `{ error : "You are unauthorized to make this request." }`

* **Sample Call:**

  ```javascript
    $.ajax({
      url: "/comments",
      dataType: "json",
      type : "POST",
      success : function(r) {
        console.log(r);
      }
    });
  ```


## To-Dos

Add Swagger Documentation
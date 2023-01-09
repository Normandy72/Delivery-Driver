### Driver.cs

##### Debud.Log(message);
* Output some info into console.
##### Time.deltaTime
* Using `Time.deltaTime` Unity can tell us how long each frame took to execute.
* When we multiply something by `Time.deltaTime` it makes our game "frame rate independent".
* Ie. The game behaves the same on fast and slow computers.

***
### Collision.cs
##### OnCollisionEnter2D Method
* Collision action.

##### OnTriggerEnter2D method
* Actions when interacting with a trigger.
***
### FollowCamera.cs
##### Creating a reference
If we want to access / change / call anything other than this game object's transform, we need to create a reference.

Ie. we need to tell Unity what the "thing" is that we are referring to.

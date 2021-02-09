# scripts
have a few default functions:
1. awake (gets called before start, good for initialization)
2. start (called when scene loads)
3. update (called on every frame)

### example: Player
derives from MonoBehavior (this is a game object component), defines behavior of Player object (when you have a game object that has a lot of functionality that is specific to it, common to put it in a script with the same name)

##### how do our custom functions get called on events?
a script component with: (ie. "Player Input")
- Behavior: Invoke Unity Events
- Events:
  - choose action map (Player), then action (Interact) to raise an event. we can add our onInteract() function as a listener to this event

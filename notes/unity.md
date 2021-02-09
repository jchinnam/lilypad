# unity
from someone new to unity

### hierarchy
shows everything in current open scene (only one open at a time)
- everything is a game object (most generic type)
- game objects:
	- camera: renders game window
	- background placeholder: background screen
	- canvas: renders UI objects on it
	- lilypad: leaf placeholder
	- player: invisible, but useful for placing controls/any persisted functionality

### project
assets: all the files (code, pictures, sounds): prefabs, scenes, scripts, sprites

##### input manager
1. action maps: different contexts you may want to change control scheme between (i.e. Player for gameplay or Menu for in a pause menu)
2. actions: list of defined actions within action map, which you can map bindings to (i.e. Interact can be both mouse left click and touch)
3. properties: binding definitions

### other views
- scene: in scene editing (moving objects, etc)
- game: renders playable game, for testing etc. note: changes made while game is in play mode will not be saved
- inspector: information about game object selected, shows components on object

# prototype
chain-reaction gameplay example [here](https://www.crazygames.com/game/chain-reaction)

### scope
- flip lilypads (click)
- lilypads ripple others (pulse)
- add to a global score
- not in scope: lilypad movement, menus

### detecting a click + collision
in `Player.cs`:
```csharp
public float selectionRadius = .1f; // a click radius

public void OnInteract()
    {
        // on click, convert mouse position to location vector
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Mouse.current.position.ReadValue());

        // a circle with center = mousePos, radius = selectionRadius
        // store all colliders that the circle contains (a collision)
        Collider2D [] hitColliders = Physics2D.OverlapCircleAll(mousePos, selectionRadius);

        // loop through each collision
        int i = 0
        foreach(Collider2D col in hitColliders) {
          ++i;
        }
    }
```

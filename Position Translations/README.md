# Position Translations
Examples that translate an object's position between two points.

## Concept
Each cube has a minimum and maximum position. At each frame, the cubes
use an attached script to execute a position transform of a customizable
step amount. When each cube reaches its max or min positions, the direction
flips and they move backwards to their original position and repeat the
process.

### Up/Down Cube
The left-most cube translates up and down using the ```transform.position```
property.

### Left/Right Cube
The middle cube translates left and right using also the ```transform.position```
property.

### Diagonal Cube
This cube moves in both X and Y direction to form a diagonal path. In order
to get this to function cleanly, ```Vector3.MoveTowards``` was used to
calculate the new vector to set the ```transform.position``` to, rather
than calculating the new X and Y values individually.

**Note:** ```Vector3.MoveTowards``` can calculate the Z dimension too!
# CPSC565Assignment2

This Project is a Harry Potter simulator that simulates a game between two teams playing the game Quidditch. The goal of the game is to catch the golden snitch. The golden snitch moves around randomly and it is up to each player to try to catch it. Catching is a simple collision with the object. The Golden snitch then teleports to a new spot and the score is incremented.

Certain settings can be modified under the main camera object. Here you can change the number of players on either side, the starting score, and the respawn rate of knocked out players.

Players are knocked out if they collide with another player. Players from opposite teams have a 100% chance of one player getting knocked out while players on similar teams have a 5% chance.Knocked out players are removed from the game and then another player cannot join untill a spawn rate is ellapsed.

The camera can be controled using the mouse to cahnge the views angle and wasd to move around. If z is held the camera stops moving with the movement of the mouse.

Each player is spawned with unique values for each of their attributes. This is based on a Box-Muller transformation. These attributes are weight, Exhaustion, Agro, and velocity. No player can surpass their velocity. Weight is used to determine acceleration and exhaustion levels. Exhaustion is used up as a player moves. Finally agro determines is used to help determine who gest knocked out in a collision and players use it to decide if they shoud chase opponents.

Scripts:

avoids: This script is used to help players avoid the ground and walls as well as chase or run from enemy players.

camera: This script allows the camera to be movable by the user.

collision: this script contains how each player reacts when collided with and destroys the weaker player when a collision happens

globals: this contains the score, the number of players, and spawn rate and uses singletons to allow global access to these variables without them being destroyed

gSpawner: responsible for spawning green team. Also uses the Box-Muller transformation[6] to create each players attributes. Also respawns knocked out players

sSpawner: responsible for spawning red team. Also uses the Box-Muller transformation[6] to create each players attributes.Also respawns knocked out players

PlayerBehavior: Contains all the player attributes and cotrols the movement of the players in relation to the snitch

score: contains the GUI

snitchBehavior: contains the behavoir for the Snitch


References:

[1] Press Start(2018,sept 25) Spawning Objects in Unity. Youtube, https://www.youtube.com/watch?v=E7gmylDS1C4&ab_channel=PressStart

[2]Imphenzia (2020,Jul 24) Learn Unity - The Most Basic Tutorial , Youtube , https://www.youtube.com/watch?v=pwZpJzpE2lQ&t=1861s&ab_channel=Imphenzia

[3]Press Start(2019,Jul 15) Unity - Enemy Follows Player , Youtube , https://www.youtube.com/watch?v=4Wh22ynlLyk&ab_channel=PressStart

[4]Brackeys ( 2017, Feb 26) How to make a Video Game in Unity - COLLISION (E05) , Youtube , https://www.youtube.com/watch?v=gAB64vfbrhI&ab_channel=Brackeys

[5]Reso Coder (2017, Mar 24) Singletons in Unity - Simple Tutorial for Beginners - https://www.youtube.com/watch?v=CPKAgyp8cno&ab_channel=ResoCoder

[6]Box-Muller transformation. (n.d.). Retrieved February 27, 2021, from https://mathworld.wolfram.com/Box-MullerTransformation.html

[7]Technologies, U. (n.d.). Welcome to the Unity Scripting Reference! Retrieved February 27, 2021, from https://docs.unity3d.com/ScriptReference/

[8]I want my rigidbody velocity to decrease. (n.d.). Retrieved February 27, 2021, from https://answers.unity.com/questions/53863/i-want-my-rigidbody-velocity-to-decrease.html

[9]Make transparent 3d object with collision detection. (n.d.). Retrieved February 27, 2021, from https://answers.unity.com/questions/391634/make-transparent-3d-object-with-collision-detectio.html

[10]WindexGlow (n.d.). Fly cam (SIMPLE Cam script). Retrieved February 27, 2021, from https://forum.unity.com/threads/fly-cam-simple-cam-script.67042/

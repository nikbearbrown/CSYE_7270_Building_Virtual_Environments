# Game Development Final Exam - Version 2
## Total: 100 points

---

### Question 1 (5 pts)
What happens when a Rigidbody object in Unity collides with a Static Body?

- [ ] The Rigidbody passes through the Static Body as if it wasn't there
- [ ] The Rigidbody responds to the collision but the Static Body remains fixed
- [ ] Both bodies will move based on their relative masses
- [ ] The collision will cause the game to freeze momentarily
- [ ] The Rigidbody will stop completely regardless of impact force

---

### Question 2 (5 pts)
In Unity's event execution order, which statement is TRUE?

- [ ] FixedUpdate runs at a consistent time interval, while Update runs once per frame
- [ ] Update always executes before FixedUpdate in a single frame
- [ ] LateUpdate is called before any Update functions
- [ ] Awake is called after Start when a scene loads
- [ ] OnEnable is only called when manually triggered by code

---

### Question 3 (5 pts)
When using OnTriggerEnter in Unity, which conditions must be true?

- [ ] Neither object can have a Rigidbody
- [ ] All colliding objects must have isTrigger enabled
- [ ] At least one collider must have isTrigger enabled and at least one object must have a Rigidbody
- [ ] Only static objects can trigger this event
- [ ] This function will only work in 2D games, not 3D

---

### Question 4 (5 pts)
What is the main purpose of normals in 3D rendering?

- [ ] To count the number of vertices in a 3D model
- [ ] To define the direction a surface is facing for lighting calculations
- [ ] To determine the physical properties of objects in collision detection
- [ ] To compress 3D models for better performance
- [ ] To identify which polygons should be rendered first

---

### Question 5 (5 pts)
In material shaders, what does the Albedo parameter primarily control?

- [ ] The roughness or smoothness of a surface
- [ ] How metallic a surface appears
- [ ] The base color and texture of the material
- [ ] The transparency or opacity of the material
- [ ] How much light the material emits

---

### Question 6 (5 pts)
In Unreal Engine, what is the main difference between BeginPlay and Tick events?

- [ ] BeginPlay only works with C++ code while Tick only works with Blueprints
- [ ] BeginPlay requires manual activation while Tick runs automatically
- [ ] BeginPlay executes once when the actor is created or the game starts, while Tick runs every frame
- [ ] BeginPlay is for gameplay logic while Tick is only for visual effects
- [ ] BeginPlay is a deprecated event that should no longer be used

---

### Question 7 (5 pts)
What is the primary purpose of the CompareTag() method in Unity compared to direct string comparison (gameObject.tag == "Player")?

- [ ] It allows comparison of multiple tags simultaneously
- [ ] It is more memory-efficient and avoids garbage collection overhead
- [ ] It automatically checks parent objects if the current object doesn't have the tag
- [ ] It works on disabled GameObjects while direct comparison doesn't
- [ ] It can compare partial tag matches while direct comparison requires exact matches

---

### Question 8 (5 pts)
Which statement about static variables in C# is TRUE?

- [ ] They are initialized every time an object of the class is created
- [ ] They exist independently for each instance of a class
- [ ] They belong to the class itself and are shared among all instances
- [ ] They can only hold primitive data types (int, float, bool)
- [ ] They must be explicitly destroyed when no longer needed

---

### Question 9 (5 pts)
What is "casting" in the context of Unreal Engine Blueprints?

- [ ] Converting a 3D model to a 2D sprite
- [ ] Converting a variable from one data type to another
- [ ] Creating a shadow projection from a light source
- [ ] Converting a generic object reference to a specific class type to access its functions
- [ ] Sending data from one Blueprint to another

---

### Question 10 (5 pts)
What is a Level Blueprint in Unreal Engine primarily used for?

- [ ] Defining player character attributes and abilities
- [ ] Creating reusable actor classes for multiple levels
- [ ] Handling level-specific events, triggers, and sequences
- [ ] Defining the basic physics properties of a level
- [ ] Setting up networking for multiplayer games

---

### Question 11 (5 pts)
What is the primary purpose of a particle emitter?

- [ ] To control the physical collisions of particles
- [ ] To define how and where particles are spawned
- [ ] To determine the color gradient of particles
- [ ] To optimize particle rendering for better performance
- [ ] To convert 3D particles into 2D sprites

---

### Question 12 (5 pts)
Which technique would be MOST effective for optimizing a particle effect that simulates rain across a large game area?

- [ ] Increasing the particle count but reducing their size
- [ ] Using high-resolution textures for each raindrop
- [ ] Using LOD (Level of Detail) to reduce particle count at a distance
- [ ] Calculating physically accurate trajectories for each raindrop
- [ ] Rendering the rain as a post-processing screen effect rather than particles

---

### Question 13 (5 pts)
In animation systems, what is the purpose of a blend tree?

- [ ] To create new animation assets from existing ones
- [ ] To smoothly transition between animations based on parameters like movement speed
- [ ] To reduce the file size of animation data
- [ ] To synchronize animations with audio
- [ ] To preview animations before exporting them to the game engine

---

### Question 14 (5 pts)
What does animation retargeting allow developers to do?

- [ ] Automatically generate animations based on physics simulations
- [ ] Apply animations created for one character skeleton to different character skeletons
- [ ] Convert 2D animations to 3D or vice versa
- [ ] Change the frame rate of animations without affecting their speed
- [ ] Encrypt animations to prevent them from being copied

---

### Question 15 (5 pts)
Which of these is NOT a type of animation commonly used in games?

- [ ] Skeletal animation
- [ ] Keyframe animation
- [ ] Physics-based animation
- [ ] Procedural animation
- [ ] Stateless animation

---

### Question 16 (5 pts)
In game audio design, what is an audio mixer primarily used for?

- [ ] Converting digital audio to analog signals
- [ ] Organizing, combining, and adjusting different audio channels and effects
- [ ] Creating 3D models of sound waves for visualization
- [ ] Simulating acoustic environments like caves or concert halls only
- [ ] Compressing audio files to reduce game size

---

### Question 17 (5 pts)
What is an example of procedural audio in games?

- [ ] Playing a pre-recorded explosion sound when a bomb detonates
- [ ] Having different character voice actors for different NPCs
- [ ] Dynamically generating engine sounds based on a vehicle's RPM and load
- [ ] Fading music between different areas of the game world
- [ ] Converting stereo audio to surround sound

---

### Question 18 (5 pts)
Which of the following is a common bottleneck for game performance?

- [ ] Having too many save file slots
- [ ] Using too many different programming languages in one project
- [ ] Having too many draw calls for rendering
- [ ] Using too many different audio file formats
- [ ] Having too many different control schemes

---

### Question 19 (5 pts)
What is the primary purpose of occlusion culling in game optimization?

- [ ] To prevent rendering objects that are behind other objects and not visible to the camera
- [ ] To reduce the polygon count of all objects in the scene
- [ ] To compress texture files for faster loading
- [ ] To limit the number of light sources that can affect an object
- [ ] To prevent audio from playing when the source is not visible

---

### Question 20 (5 pts)
In the context of game AI, what is a behavior tree?

- [ ] A visual representation of a character's skill progression
- [ ] A hierarchical organization of tasks with priority that enables complex decision-making
- [ ] A map of all possible locations an AI character can patrol
- [ ] A system that automatically generates dialogue for NPCs
- [ ] A method for AI characters to learn from player behavior

---

### Question 21 (5 pts)
Which is NOT typically a state in a finite state machine for enemy AI?

- [ ] Patrol
- [ ] Attack
- [ ] Retreat
- [ ] Compile
- [ ] Idle

---

### Question 22 (5 pts)
What advantage does GOAP (Goal-Oriented Action Planning) have over simpler AI systems?

- [ ] It requires less processing power
- [ ] It allows AI to form plans to achieve goals rather than following fixed patterns
- [ ] It only works with specific character types like non-humanoid enemies
- [ ] It requires no programming, only designer input
- [ ] It automatically generates all possible enemy behaviors

---

### Question 23 (5 pts)
In C# memory management, what is the primary difference between the stack and the heap?

- [ ] The stack is used only for global variables, while the heap is for local variables
- [ ] The stack stores temporary data during function calls, while the heap stores objects with longer lifetimes
- [ ] The stack is managed by the programmer, while the heap is managed automatically
- [ ] The stack is slower but more memory-efficient, while the heap is faster but uses more memory
- [ ] The stack is used only in Unity, while the heap is used only in other engines

---

### Question 24 (5 pts)
What is object pooling in game development?

- [ ] A technique for automatically combining multiple 3D models to save memory
- [ ] A design pattern for sharing variables between different scripts
- [ ] A technique for reusing object instances instead of destroying and recreating them
- [ ] A method for organizing objects in the Unity hierarchy
- [ ] A system for backing up important game objects in case of crashes

---

### Question 25 (5 pts)
Which of the following is considered a best practice for efficient C# code in Unity?

- [ ] Using GameObject.Find() frequently to locate objects
- [ ] Performing complex calculations in Update() for real-time results
- [ ] Using GetComponent<>() in Start/Awake rather than in Update
- [ ] Creating new GameObjects whenever needed rather than reusing them
- [ ] Making all variables public for easier access from other scripts

---

## Answer Key

### Question 1
**Correct Answer**: The Rigidbody responds to the collision but the Static Body remains fixed
- **Explanation**: In game physics, Rigidbody objects are affected by physics forces including collisions, while Static Bodies are immovable objects that don't respond to physics forces. When they collide, the Rigidbody will react (bounce, slide, etc.) based on the collision properties, but the Static Body will remain in place.

### Question 2
**Correct Answer**: FixedUpdate runs at a consistent time interval, while Update runs once per frame
- **Explanation**: In Unity, FixedUpdate is called at fixed time steps determined by the physics system (typically multiple times per frame or skipped frames depending on performance), making it ideal for physics calculations. Update is called exactly once per rendered frame, which may vary in time between calls based on performance.

### Question 3
**Correct Answer**: At least one collider must have isTrigger enabled and at least one object must have a Rigidbody
- **Explanation**: For OnTriggerEnter to be called in Unity, there must be at least one collider with isTrigger enabled, and at least one of the colliding objects must have a Rigidbody component. This allows objects to pass through each other while still detecting the intersection.

### Question 4
**Correct Answer**: To define the direction a surface is facing for lighting calculations
- **Explanation**: Normal vectors indicate which way a surface is facing in 3D space. They are essential for lighting calculations because they determine how light reflects off surfaces, creating proper shading, highlights, and shadows in the rendered image.

### Question 5
**Correct Answer**: The base color and texture of the material
- **Explanation**: Albedo (or Base Color) defines the basic color of a material before any lighting is applied. It represents the percentage of light of each wavelength that the surface reflects. It does not affect specular reflections, roughness, metallic properties, or emissive qualities.

### Question 6
**Correct Answer**: BeginPlay executes once when the actor is created or the game starts, while Tick runs every frame
- **Explanation**: In Unreal Engine, BeginPlay is an event that triggers once when the game starts or when the actor (object) is spawned in the game. Tick is called every frame during gameplay, similar to Update() in Unity, making it useful for continuous updates.

### Question 7
**Correct Answer**: It is more memory-efficient and avoids garbage collection overhead
- **Explanation**: CompareTag() is optimized to avoid string allocations and garbage collection that can occur with direct string comparison (tag == "string"). This makes it more efficient, especially in frequently called methods like Update() where string allocations can add up and cause performance issues.

### Question 8
**Correct Answer**: They belong to the class itself and are shared among all instances
- **Explanation**: Static variables in C# belong to the class itself rather than to specific instances. This means all instances of the class share the same static variable, and changes made to it from any instance will be visible to all other instances.

### Question 9
**Correct Answer**: Converting a generic object reference to a specific class type to access its functions
- **Explanation**: In Unreal Engine, casting allows you to convert a generic object reference (like Actor) into a more specific class type (like Character). This enables access to properties and methods unique to that specific class that aren't available through the generic reference.

### Question 10
**Correct Answer**: Handling level-specific events, triggers, and sequences
- **Explanation**: Level Blueprints in Unreal Engine are specific to a single level and typically handle level-wide events, environmental triggers, cinematic sequences, and other functionality that is unique to that particular level rather than being reusable across multiple levels.

### Question 11
**Correct Answer**: To define how and where particles are spawned
- **Explanation**: A particle emitter is the component of a particle system that controls the creation of particles. It defines parameters such as the spawn rate, initial position, shape of the emission area, initial velocity, and other properties that determine how particles begin their lifecycle.

### Question 12
**Correct Answer**: Using LOD (Level of Detail) to reduce particle count at a distance
- **Explanation**: For a large-scale effect like rain, using LOD systems to reduce the number of particles rendered at a distance is an effective optimization. This maintains visual fidelity near the player while reducing computational load for distant areas where individual raindrops aren't as noticeable.

### Question 13
**Correct Answer**: To smoothly transition between animations based on parameters like movement speed
- **Explanation**: Blend trees in animation systems allow for smooth transitions or interpolations between multiple animations based on one or more parameters (such as movement speed, direction, or character state). This creates more natural-looking animation transitions than simple switches between animations.

### Question 14
**Correct Answer**: Apply animations created for one character skeleton to different character skeletons
- **Explanation**: Animation retargeting allows animations created for one character's skeleton to be applied to different characters, even if they have different proportions or structures. This saves significant development time as animations don't need to be recreated for each character model.

### Question 15
**Correct Answer**: Stateless animation
- **Explanation**: Common animation types in games include skeletal animation (using a bone hierarchy), keyframe animation (defining specific poses at specific times), physics-based animation (using physics simulation), and procedural animation (generated through code). "Stateless animation" is not a standard animation technique in game development.

### Question 16
**Correct Answer**: Organizing, combining, and adjusting different audio channels and effects
- **Explanation**: An audio mixer in game development is a system for managing multiple audio sources, organizing them into groups or channels, applying effects, controlling volume levels, and creating a cohesive overall sound mix for the game.

### Question 17
**Correct Answer**: Dynamically generating engine sounds based on a vehicle's RPM and load
- **Explanation**: Procedural audio is sound that is generated algorithmically in real-time rather than playing pre-recorded samples. Dynamically creating engine sounds based on a vehicle's RPM, load, and other factors is a common example, allowing for more realistic and responsive audio that adapts to gameplay conditions.

### Question 18
**Correct Answer**: Having too many draw calls for rendering
- **Explanation**: Draw calls, which are instructions to the GPU to render objects, can be a significant performance bottleneck. Each draw call has overhead, so having too many (often due to many separate objects or materials) can dramatically reduce frame rate, especially on lower-end hardware.

### Question 19
**Correct Answer**: To prevent rendering objects that are behind other objects and not visible to the camera
- **Explanation**: Occlusion culling is an optimization technique that prevents the rendering of objects that are completely hidden behind other objects from the camera's perspective. This reduces the rendering workload by skipping objects that wouldn't be visible to the player anyway.

### Question 20
**Correct Answer**: A hierarchical organization of tasks with priority that enables complex decision-making
- **Explanation**: Behavior trees are an AI architecture that organizes behaviors in a hierarchical tree structure with nodes representing tasks, conditions, and selectors. This allows for complex decision-making with prioritization, fallbacks, and sequences of actions.

### Question 21
**Correct Answer**: Compile
- **Explanation**: Common states in enemy AI finite state machines include Patrol (following a predetermined path), Attack (engaging the player), Retreat (moving away when threatened), and Idle (standing still, often while waiting or observing). "Compile" is a programming term related to code translation, not an AI state.

### Question 22
**Correct Answer**: It allows AI to form plans to achieve goals rather than following fixed patterns
- **Explanation**: Goal-Oriented Action Planning (GOAP) is an advanced AI technique where characters determine a sequence of actions to satisfy their goals based on current world states. This creates more adaptive AI that can find different solutions to problems rather than following predetermined patterns like simpler systems.

### Question 23
**Correct Answer**: The stack stores temporary data during function calls, while the heap stores objects with longer lifetimes
- **Explanation**: In C#, the stack is used for storing value types and method calls with a short, predictable lifetime, while the heap is used for reference types (classes, arrays, strings) that may have variable or longer lifetimes. Stack allocation/deallocation is faster but more limited in size and lifespan.

### Question 24
**Correct Answer**: A technique for reusing object instances instead of destroying and recreating them
- **Explanation**: Object pooling is an optimization pattern where objects that would normally be frequently created and destroyed (like projectiles, enemies, or particles) are instead reused. When an object is no longer needed, it's returned to a "pool" rather than destroyed, and when a new object is needed, one is taken from the pool rather than instantiated.

### Question 25
**Correct Answer**: Using GetComponent<>() in Start/Awake rather than in Update
- **Explanation**: GetComponent<>() is a relatively expensive operation, so calling it in frequently executed methods like Update() can cause performance issues. A best practice is to cache component references by calling GetComponent<>() in Start() or Awake() (which run only once) and storing the result in a variable for later use.

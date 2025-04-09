# Game Development Final Exam
## Total: 100 points

---

### Question 1 (5 pts)
Which of the following statements about Kinematic Bodies is true?

- [ ] They are affected by gravity and respond to all physics forces
- [ ] They respond to collision forces but not to gravity
- [ ] They ignore external forces and must be moved manually through code
- [ ] They can only be used for trigger collisions, not physical collisions
- [ ] They can only be applied to static objects that don't move

---

### Question 2 (5 pts)
In Unity, which events are executed in the correct order?

- [ ] Awake, Start, Update, LateUpdate
- [ ] Start, Awake, Update, FixedUpdate 
- [ ] Update, FixedUpdate, Start, Awake
- [ ] FixedUpdate, Update, LateUpdate, Awake

---

### Question 3 (5 pts)
For OnCollisionEnter to be triggered in Unity, which conditions must be true?

- [ ] Both objects must have Rigidbodies
- [ ] Both objects must have a Collider component and at least one must have a Rigidbody
- [ ] Both objects must have isTrigger enabled
- [ ] Only one object needs a Collider, but both need Rigidbodies

---

### Question 4 (5 pts)
What is a UV map used for in game development?

- [ ] To track the velocity (U) and viscosity (V) of fluid simulations
- [ ] To define how 2D textures wrap around 3D models
- [ ] To map user inputs (U) to visual feedback (V)
- [ ] To control the ultraviolet lighting effects in a scene
- [ ] To define user viewpoints in a multiplayer game

---

### Question 5 (5 pts)
What is the purpose of the specular property in a material?

- [ ] It defines the base color of a material without any lighting effects
- [ ] It controls how transparent or opaque a material appears
- [ ] It controls direct reflection of light sources from a surface
- [ ] It makes materials appear to emit light
- [ ] It determines how metallic a surface appears

---

### Question 6 (5 pts)
Which statement about static variables in C# is FALSE?

- [ ] Static variables belong to the class itself rather than any specific instance
- [ ] Static variables are shared among all instances of the class
- [ ] Static variables can be accessed without creating an object of the class
- [ ] Static variables are automatically deleted when an object is destroyed
- [ ] Static variables persist throughout the application's lifetime

---

### Question 7 (5 pts)
What does casting an object to ThirdPersonCharacter in Unreal Engine primarily allow?

- [ ] It prevents the character from taking damage
- [ ] It changes the character's appearance to a third-person view
- [ ] It allows the animation blueprint to access properties specific to that character type
- [ ] It converts a 2D sprite into a 3D character model
- [ ] It forces the game camera to follow the character in third-person mode

---

### Question 8 (5 pts)
Which of the following best describes the difference between Event BeginPlay and Event Tick in Unreal Engine?

- [ ] BeginPlay runs on the client, while Tick runs on the server
- [ ] BeginPlay only works with Blueprints, while Tick only works with C++
- [ ] BeginPlay runs once when the game starts or when the actor is spawned, while Tick runs every frame
- [ ] BeginPlay handles physics, while Tick handles rendering
- [ ] BeginPlay runs in the editor, while Tick only runs in packaged games

---

### Question 9 (5 pts)
What is the main difference between Level Blueprints and Class Blueprints in Unreal Engine?

- [ ] Level Blueprints use visual scripting, while Class Blueprints use only C++ code
- [ ] Level Blueprints are specific to a single level and handle level-wide events, while Class Blueprints are reusable and can be placed in multiple levels
- [ ] Level Blueprints can only handle UI elements, while Class Blueprints handle gameplay
- [ ] Level Blueprints execute during loading screens, while Class Blueprints execute during gameplay

---

### Question 10 (5 pts)
What is the purpose of normal vectors in 3D rendering?

- [ ] They define the direction a surface is facing and determine how light interacts with it
- [ ] They control the speed at which textures load
- [ ] They define the standard (normal) resolution for texture maps
- [ ] They represent the average polygon count in a 3D model
- [ ] They normalize the frame rate during complex rendering operations

---

### Question 11 (5 pts)
What is the primary benefit of using particle pooling in game development?

- [ ] It makes particles more colorful and vibrant
- [ ] It allows particles to interact with physics objects more realistically
- [ ] It reuses particle instances instead of creating and destroying them, improving performance
- [ ] It automatically adjusts particle effects based on the device's graphics capabilities
- [ ] It ensures particles are synchronized with the game's audio

---

### Question 12 (5 pts)
Which of these is NOT a common component of a particle system?

- [ ] Emitter
- [ ] Lifetime
- [ ] Velocity/Direction
- [ ] Pathfinding
- [ ] Collision

---

### Question 13 (5 pts)
What is animation retargeting used for?

- [ ] Converting 2D animations to 3D animations
- [ ] Applying animations created for one character skeleton to different character skeletons
- [ ] Reducing the file size of animation data
- [ ] Creating looping animations from non-looping ones
- [ ] Synchronizing animations with sound effects

---

### Question 14 (5 pts)
What is the purpose of a blend tree in animation systems?

- [ ] To combine multiple texture maps into a single material
- [ ] To merge multiple 3D models into one optimized mesh
- [ ] To smoothly transition between different animations based on parameters
- [ ] To blend different audio tracks based on game events
- [ ] To optimize colors and lighting in a 3D scene

---

### Question 15 (5 pts)
Which of the following is an example of procedural audio in games?

- [ ] Playing pre-recorded music tracks
- [ ] Voice acting for character dialogue
- [ ] Dynamically generating footstep sounds based on the surface material
- [ ] Adjusting the volume of sound effects based on distance
- [ ] Converting stereo sound to mono for mobile devices

---

### Question 16 (5 pts)
What is an audio mixer used for in game development?

- [ ] Recording voice actors in a studio setting
- [ ] Converting digital audio to analog signals
- [ ] Organizing, combining, and adjusting different audio channels and effects
- [ ] Compressing audio files to reduce their size
- [ ] Creating 3D spatial audio for VR games only

---

### Question 17 (5 pts)
Which of the following is NOT a common performance bottleneck in games?

- [ ] Too many draw calls
- [ ] High polygon count in visible models
- [ ] Excessive physics calculations
- [ ] Too many different language localizations
- [ ] Inefficient script execution

---

### Question 18 (5 pts)
What is the primary purpose of LOD (Level of Detail) systems?

- [ ] To reduce model complexity for distant objects, improving performance
- [ ] To add extra details to objects close to the camera
- [ ] To automatically generate collision meshes from visual meshes
- [ ] To control the difficulty level of gameplay based on player skill
- [ ] To manage the loading of different game levels

---

### Question 19 (5 pts)
In game AI, what is a Finite State Machine?

- [ ] A computer with limited memory for running AI algorithms
- [ ] A system where AI behavior is defined by states with transitions between them
- [ ] A mathematical formula for calculating optimal pathfinding
- [ ] A hardware component required for running complex AI
- [ ] A limit placed on how smart an AI can appear to players

---

### Question 20 (5 pts)
Which of the following is NOT a typical state in enemy AI behavior?

- [ ] Patrol
- [ ] Chase
- [ ] Attack
- [ ] Compile
- [ ] Retreat

---

### Question 21 (5 pts)
What does the new operator do in C#?

- [ ] Creates a new script file
- [ ] Allocates memory on the heap for an object
- [ ] Resets a variable to its default value
- [ ] Connects to a new network server
- [ ] Adds a new component to a GameObject

---

### Question 22 (5 pts)
Which of the following is a best practice for C# programming in Unity?

- [ ] Using FindObjectOfType() frequently for maximum flexibility
- [ ] Making all variables public for easy access from other scripts
- [ ] Using [SerializeField] for inspector-visible private variables
- [ ] Performing heavy calculations in Update() for real-time responsiveness
- [ ] Creating new objects frequently rather than reusing them

---

### Question 23 (5 pts)
Why would you use animation layers in a character animation system?

- [ ] To reduce the file size of animations
- [ ] To combine animations (e.g., upper body aiming while legs are walking)
- [ ] To apply the same animation to multiple characters simultaneously 
- [ ] To make animations run faster on low-end devices
- [ ] To convert from one animation format to another

---

### Question 24 (5 pts)
In memory management, what is stored on the heap in C#?

- [ ] Only temporary variables
- [ ] Only GameObject references
- [ ] Value types like int, float, and bool
- [ ] Reference types like classes, arrays, and strings
- [ ] Only variables declared within Update()

---

### Question 25 (5 pts)
What is behavior trees' primary advantage over simpler AI systems like finite state machines?

- [ ] They require less memory to implement
- [ ] They always result in faster game performance
- [ ] They handle hierarchical decision-making and can reuse common behaviors
- [ ] They only work with specific game engines
- [ ] They can only be programmed in low-level languages

---

## Answer Key

### Question 1
**Correct Answer**: They ignore external forces and must be moved manually through code
- **Explanation**: Kinematic Bodies are physics bodies that don't respond to forces like gravity or collisions. They must be positioned programmatically and are useful for platforms, doors, or other objects that need to move in predetermined ways without being affected by the physics system.

### Question 2
**Correct Answer**: Awake, Start, Update, LateUpdate
- **Explanation**: In Unity's execution order, Awake() is called when the script instance is being loaded, Start() is called before the first frame update but after Awake, Update() is called once per frame, and LateUpdate() is called after all Update functions have been called.

### Question 3
**Correct Answer**: Both objects must have a Collider component and at least one must have a Rigidbody
- **Explanation**: For OnCollisionEnter to be triggered in Unity, both objects must have Collider components, and at least one must have a Rigidbody. Additionally, neither can have isTrigger enabled, as that would trigger OnTriggerEnter instead.

### Question 4
**Correct Answer**: To define how 2D textures wrap around 3D models
- **Explanation**: UV mapping is the process of projecting a 2D image onto a 3D model's surface. The letters "U" and "V" represent the axes of the 2D texture, similar to how X, Y, and Z represent the axes in 3D space.

### Question 5
**Correct Answer**: It controls direct reflection of light sources from a surface
- **Explanation**: The specular property in a material determines how strongly a surface reflects light directly from light sources, creating highlights. Higher specular values create more intense highlights, making surfaces appear shinier.

### Question 6
**Correct Answer**: Static variables are automatically deleted when an object is destroyed
- **Explanation**: This statement is FALSE. Static variables belong to the class itself, not to instances of the class. They persist throughout the application's lifetime and are not deleted when an object is destroyed. They remain in memory until the application ends.

### Question 7
**Correct Answer**: It allows the animation blueprint to access properties specific to that character type
- **Explanation**: Casting in Unreal Engine converts a generic object reference to a specific class type, enabling access to properties and functions specific to that class. In this case, casting to ThirdPersonCharacter allows the animation blueprint to access character-specific variables like movement state, sprint status, or jump state.

### Question 8
**Correct Answer**: BeginPlay runs once when the game starts or when the actor is spawned, while Tick runs every frame
- **Explanation**: BeginPlay is an event that executes once when an actor is created or when the game starts. Tick is called every frame, similar to Update() in Unity, making it useful for continuous updates like movement, rotations, or checking conditions.

### Question 9
**Correct Answer**: Level Blueprints are specific to a single level and handle level-wide events, while Class Blueprints are reusable and can be placed in multiple levels
- **Explanation**: Level Blueprints are unique to a specific level and typically handle level-specific events, triggers, or cinematics. Class Blueprints define reusable actors (objects) that can be placed in any level, like characters, items, or interactive elements.

### Question 10
**Correct Answer**: They define the direction a surface is facing and determine how light interacts with it
- **Explanation**: Normal vectors indicate the direction a surface is facing in 3D space. They are essential for lighting calculations as they determine how light reflects off surfaces, creating proper shading, highlights, and shadows.

### Question 11
**Correct Answer**: It reuses particle instances instead of creating and destroying them, improving performance
- **Explanation**: Particle pooling is an optimization technique where particle instances are reused rather than continuously created and destroyed. This reduces memory allocation/deallocation operations, which can be costly in terms of performance, especially in systems with many particles.

### Question 12
**Correct Answer**: Pathfinding
- **Explanation**: Standard components of a particle system include emitters, lifetime parameters, size/scale controls, color properties, velocity/direction settings, and collision behavior. Pathfinding is not a particle system component but rather an AI navigation feature.

### Question 13
**Correct Answer**: Applying animations created for one character skeleton to different character skeletons
- **Explanation**: Animation retargeting allows animations designed for one character's skeleton to be applied to a different character, even if they have different proportions or structures. This preserves the essence of the animation while adapting it to fit the new character's unique skeleton.

### Question 14
**Correct Answer**: To smoothly transition between different animations based on parameters
- **Explanation**: Blend trees are animation tools that allow smooth transitions or blending between multiple animations based on one or more parameters (like movement speed or direction). They create more natural animation transitions than simple state machines alone.

### Question 15
**Correct Answer**: Dynamically generating footstep sounds based on the surface material
- **Explanation**: Procedural audio refers to sound that is generated algorithmically in real-time rather than playing pre-recorded samples. Generating different footstep sounds based on the surface a character is walking on (concrete, grass, metal, etc.) is a common example of procedural audio in games.

### Question 16
**Correct Answer**: Organizing, combining, and adjusting different audio channels and effects
- **Explanation**: An audio mixer is a system for managing multiple audio sources, grouping them into channels, applying effects, controlling volume levels, and creating an overall sound mix. It allows for centralized control of a game's audio landscape.

### Question 17
**Correct Answer**: Too many different language localizations
- **Explanation**: Common performance bottlenecks include excess draw calls, high polygon counts, large texture sizes, complex physics calculations, and inefficient scripts. Having multiple language localizations typically does not impact performance as these are usually text resources loaded as needed.

### Question 18
**Correct Answer**: To reduce model complexity for distant objects, improving performance
- **Explanation**: Level of Detail (LOD) systems decrease the complexity (polygon count, texture resolution, etc.) of objects as they move farther from the camera. Since distant objects appear smaller on screen, this reduction in detail is often imperceptible to players but significantly improves performance.

### Question 19
**Correct Answer**: A system where AI behavior is defined by states with transitions between them
- **Explanation**: A Finite State Machine (FSM) is an AI architecture where behavior is organized into discrete states (like patrol, chase, attack) with defined transitions between them. It's one of the most common and straightforward approaches to game AI.

### Question 20
**Correct Answer**: Compile
- **Explanation**: Typical states in enemy AI include patrol (following a set path), chase (pursuing the player), attack (engaging in combat), retreat (moving away when threatened), and searching (looking for a player previously detected). "Compile" is a programming term and not an AI behavior state.

### Question 21
**Correct Answer**: Allocates memory on the heap for an object
- **Explanation**: In C#, the new operator allocates memory on the heap for a new instance of an object. This is used when creating reference type objects like classes, arrays, or complex data structures.

### Question 22
**Correct Answer**: Using [SerializeField] for inspector-visible private variables
- **Explanation**: A best practice in Unity C# programming is to keep variables private for encapsulation but use the [SerializeField] attribute to make them visible in the Inspector. This maintains good code organization while allowing for easy adjustment of values in the Unity editor.

### Question 23
**Correct Answer**: To combine animations (e.g., upper body aiming while legs are walking)
- **Explanation**: Animation layers allow different parts of a character to be animated independently. A common use is having the lower body follow a walking animation while the upper body performs a separate action like aiming a weapon or reacting to being hit.

### Question 24
**Correct Answer**: Reference types like classes, arrays, and strings
- **Explanation**: In C#, reference types (classes, arrays, strings) are stored on the heap, while value types (int, float, bool, struct) are stored on the stack. Understanding this distinction is important for memory management and performance optimization.

### Question 25
**Correct Answer**: They handle hierarchical decision-making and can reuse common behaviors
- **Explanation**: Behavior trees excel at organizing AI logic in a hierarchical manner, allowing for complex decision-making. They also promote reusability, as common behaviors can be defined once and used in multiple contexts, making them more scalable and maintainable than simple finite state machines.

# Game Development Cheat Sheet

## Game Physics

### Physics Bodies
- **Rigidbody**: Responds to physics forces (gravity, collisions, etc.)
- **Kinematic Body**: Ignores external forces; must be moved manually
- **Static Body**: Cannot move; used for immovable scenery

### Collision Detection
- **Unity Requirements for OnCollisionEnter**:
  - At least one object must have a Rigidbody
  - Both objects must have a Collider component
  - Neither can have isTrigger enabled
- **Unity Requirements for OnTriggerEnter**:
  - At least one object must have a Rigidbody
  - Both must have Colliders
  - At least one must have isTrigger enabled
- **CompareTag()**: More efficient than direct string comparison (tag == "PickUp")

## Unity Basics

### MonoBehaviour Events
- **Start()**: Called once when the script is enabled, before any Update
- **Update()**: Called every frame
- **FixedUpdate()**: Called at a fixed time interval; use for physics calculations
- **LateUpdate()**: Called after all Updates; use for camera follow
- **Awake()**: Called when the script instance is being loaded
- **OnEnable()**: Called when the object becomes enabled and active
- **OnDisable()**: Called when the object becomes disabled or inactive

### Important Components
- **Transform**: Position, rotation, scale of GameObjects
- **Rigidbody**: Makes objects respond to the physics system
- **Collider**: Defines the shape for collision detection
- **Camera**: Renders the scene from its perspective
- **Renderer**: Makes objects visible (MeshRenderer, SpriteRenderer)
- **Animator**: Controls animations using animation controllers

## Unreal Engine Basics

### Blueprint Types
- **Level Blueprint**: Specific to one level; manages level-wide events
- **Class Blueprint**: Reusable objects that can be placed in multiple levels
- **Animation Blueprint**: Controls character animations

### Key Events
- **BeginPlay**: Runs once when the game starts or when the actor is spawned
- **Tick**: Runs every frame (like Update in Unity)
- **OnComponentBeginOverlap**: Called when this component begins overlapping another
- **OnComponentEndOverlap**: Called when this component stops overlapping another

### Casting
- Used to access specific properties and functions of a particular class
- Allows animation blueprints to interact with character-specific variables

## Shaders & Materials

### Key Material Properties
- **Albedo/Base Color**: The base color of the material without lighting
- **Metallic**: How metallic a surface is (reflective, conducts light)
- **Roughness**: How smooth or rough a surface is (affects reflection sharpness)
- **Normal**: Affects how light bounces off surfaces
- **Specular**: Controls direct reflection of light sources
- **Emission**: Makes materials appear to emit light

### Normals in 3D Rendering
- Vectors that define the direction a surface is facing
- Determine how light interacts with surfaces
- Critical for proper shading and lighting calculations

### UV Mapping
- Defines how 2D textures wrap around 3D models
- U and V coordinates correspond to X and Y in 2D texture space

## Particle Effects

### Particle System Components
- **Emitter**: Controls where and how particles are spawned
- **Lifetime**: How long particles exist
- **Size/Scale**: Controls particle dimensions
- **Color**: Can change over particle lifetime
- **Velocity/Direction**: Controls how particles move
- **Collision**: How particles interact with the environment

### Optimization Techniques
- **Particle Pooling**: Reuse particle instances instead of creating/destroying
- **LOD System**: Reduce detail for distant effects
- **Limit Overdraw**: Avoid having many transparent particles overlap
- **Use Flipbooks**: Animate textures rather than using many particles

## Animation

### Animation Types
- **Keyframe Animation**: Manually created poses at specific frames
- **Skeletal Animation**: Uses a hierarchical bone structure to control a mesh
- **Physics-Based Animation**: Simulates real-world physics for movement
- **Procedural Animation**: Generated through code rather than pre-created

### Animation Blending
- **Blend Trees**: Smoothly transition between animations based on parameters
- **Animation Layers**: Combine animations (e.g., upper body aiming while legs walking)
- **Additive Animations**: Add motion on top of base animations

### Animation Retargeting
- Allows animations created for one skeleton to be applied to different characters
- Preserves the essence of the animation while adjusting for differences in skeleton structure

## Audio

### Audio Components
- **Audio Source**: Emits sound from a location
- **Audio Listener**: Receives sounds (typically attached to the player camera)
- **Audio Mixer**: Organizes and adjusts audio channels and effects
- **Audio Effects**: Modify sounds (reverb, echo, distortion, etc.)

### Procedural Audio
- Dynamically generated sound based on in-game parameters
- Examples: Footsteps changing based on surface, adaptive music systems

## Profiling & Optimization

### Common Performance Bottlenecks
- **Draw Calls**: Too many separate objects being rendered
- **Polygon Count**: Too many triangles in view
- **Texture Size**: Overly high-resolution textures
- **Physics Calculations**: Too many rigidbodies or complex colliders
- **Script Performance**: Inefficient code execution

### Optimization Techniques
- **LOD (Level of Detail)**: Reduce model complexity at distance
- **Batching**: Combine draw calls to reduce rendering overhead
- **Object Pooling**: Reuse objects instead of instantiating/destroying them
- **Occlusion Culling**: Don't render objects that can't be seen
- **Texture Atlasing**: Combine multiple textures into one to reduce draw calls

## Game AI

### AI Architecture Types
- **Finite State Machines**: Simple states with transitions between them
- **Behavior Trees**: Hierarchical structure of tasks with priority
- **Utility AI**: Decision-making based on scoring potential actions
- **GOAP (Goal-Oriented Action Planning)**: AI that forms plans to achieve goals

### Common Enemy States
- **Patrol**: Moving along predetermined paths
- **Alert**: Aware of potential player presence
- **Chase**: Actively pursuing the player
- **Attack**: Engaging the player
- **Retreat**: Moving away from the player to safety
- **Searching**: Looking for a player that was previously detected

## C# Programming

### Memory Management
- **Stack**: Value types (int, float, bool, struct)
- **Heap**: Reference types (classes, arrays, strings)
- **new Operator**: Allocates memory on the heap
- **Garbage Collection**: Automatically frees memory that's no longer needed

### Static Variables/Methods
- Belong to the class itself, not any specific instance
- Shared among all instances of the class
- Can be accessed without creating an object of the class
- Use for data that should be consistent across all instances

### C# Best Practices in Unity
- Use [SerializeField] for inspector-visible private variables
- Prefer GetComponent<>() in Start/Awake rather than Update
- Use object pooling for frequently instantiated/destroyed objects
- Avoid FindObjectOfType() and GameObject.Find() in performance-critical code
- 
# Game Development Glossary

### A

**Additive Animation**: A technique where one animation is layered on top of another, adding motion to a base animation without replacing it.

**AI (Artificial Intelligence)**: Programming that enables non-player characters to make decisions and exhibit intelligent behavior.

**Albedo**: The base color of a material without any lighting or shading applied.

**Animation Blueprint (Unreal Engine)**: A specialized blueprint that controls character animations in Unreal Engine.

**Animation Controller**: A state machine that manages animation transitions and blending in Unity.

**Animation Layers**: A system that allows different parts of a character to be animated independently (e.g., upper body aiming while legs are walking).

**Animation Retargeting**: The process of applying animations created for one character skeleton to a different character skeleton.

**Audio Effects**: Modifications applied to audio to change its characteristics (e.g., reverb, echo, distortion).

**Audio Listener**: A component that receives sounds in a game, typically attached to the player's camera.

**Audio Mixer**: A system for organizing, combining, and adjusting different audio channels and effects.

**Audio Source**: A component that emits sound from a specific location in the game world.

**Awake()**: A Unity MonoBehaviour event called when a script instance is being loaded.

### B

**Batching**: The process of combining multiple draw calls into one to reduce rendering overhead.

**BeginPlay**: An Unreal Engine event that runs once when the game starts or when an actor is spawned.

**Behavior Trees**: A hierarchical AI structure organized as tasks with priority that enables complex decision-making.

**Blend Trees**: A system that smoothly transitions between different animations based on parameters like movement speed.

**Blueprint (Unreal Engine)**: A visual scripting system in Unreal Engine that allows for creating game logic without writing code.

### C

**Camera**: A component that renders the scene from its perspective.

**Casting (Blueprint)**: A process in Unreal Engine that converts a generic object reference to a specific class to access its unique properties and functions.

**Class Blueprint**: A reusable blueprint in Unreal Engine that can be placed in multiple levels.

**Collider**: A component that defines the shape used for collision detection.

**Collision Detection**: The process of determining when game objects intersect or touch each other.

**CompareTag()**: A Unity method for checking an object's tag that is more efficient than direct string comparison.

### D

**Draw Calls**: Individual commands sent to the GPU to render objects; too many can cause performance issues.

### E

**Emission**: A material property that makes objects appear to emit light without actually illuminating their surroundings.

**Emitter**: A component in a particle system that controls where and how particles are spawned.

### F

**Finite State Machine (FSM)**: An AI architecture consisting of distinct states with defined transitions between them.

**FixedUpdate()**: A Unity MonoBehaviour event called at a fixed time interval, used for physics calculations.

**Flipbooks**: A technique that animates textures by cycling through frames rather than using many individual particles.

### G

**Garbage Collection**: An automatic memory management process that frees memory that's no longer being used.

**GOAP (Goal-Oriented Action Planning)**: An AI architecture where the AI forms plans to achieve specific goals.

### H

**Heap**: The memory region where reference types (classes, arrays, strings) are stored.

### K

**Keyframe Animation**: Animation created by defining specific poses at specific frames.

**Kinematic Body**: A physics body that ignores external forces and must be moved manually through code.

### L

**LateUpdate()**: A Unity MonoBehaviour event called after all Update functions, often used for camera follow behavior.

**Level Blueprint**: A blueprint in Unreal Engine specific to a single level that manages level-wide events.

**Level of Detail (LOD)**: A technique that reduces model complexity for distant objects to improve performance.

### M

**Metallic**: A material property that determines how metallic a surface appears (affecting reflection and light conduction).

**MonoBehaviour**: The base class for scripts in Unity that allows them to be attached to GameObjects.

### N

**new Operator**: A C# keyword that allocates memory on the heap for a new object.

**Normal Maps**: Textures that simulate surface details without adding actual geometry.

**Normals**: Vectors that define the direction a surface is facing, critical for calculating lighting and shading.

### O

**Object Pooling**: A technique that reuses objects instead of destroying and recreating them to improve performance.

**Occlusion Culling**: A rendering optimization that skips drawing objects that are hidden behind other objects.

**OnCollisionEnter**: A Unity event called when a collider enters another collider.

**OnComponentBeginOverlap**: An Unreal Engine event called when a component begins overlapping another component.

**OnComponentEndOverlap**: An Unreal Engine event called when a component stops overlapping another component.

**OnDisable()**: A Unity MonoBehaviour event called when an object becomes disabled or inactive.

**OnEnable()**: A Unity MonoBehaviour event called when an object becomes enabled and active.

**OnTriggerEnter**: A Unity event called when a collider configured as a trigger is entered by another collider.

**Overdraw**: When multiple transparent objects are rendered on top of each other, causing performance issues.

### P

**Particle Effects**: Visual effects created using many small sprites or meshes to simulate phenomena like fire, smoke, or magic.

**Particle Pooling**: Reusing particle instances instead of creating and destroying them to improve performance.

**Particle System**: A component that manages the creation, movement, and appearance of particles.

**Physics-Based Animation**: Animation that uses physics simulations to create realistic movement.

**Procedural Animation**: Animation generated through code rather than pre-created by animators.

**Procedural Audio**: Sound that is dynamically generated based on in-game parameters rather than pre-recorded.

### R

**Renderer**: A component that makes objects visible (e.g., MeshRenderer, SpriteRenderer).

**Rigidbody**: A component that makes objects respond to Unity's physics system (gravity, collisions, etc.).

**Roughness**: A material property that determines how smooth or rough a surface appears, affecting reflection sharpness.

### S

**[SerializeField]**: A C# attribute in Unity that makes private variables visible in the Inspector without making them public.

**Skeletal Animation**: Animation that uses a hierarchical bone structure to control a mesh.

**Specular**: A material property that controls the direct reflection of light sources.

**Stack**: The memory region where value types (int, float, bool, struct) are stored.

**Start()**: A Unity MonoBehaviour event called once when a script is enabled, before any Update calls.

**Static Body**: A physics object that cannot move and is used for immovable scenery.

**Static Variables/Methods**: Variables or methods that belong to the class itself rather than instances of the class.

### T

**Texture Atlasing**: Combining multiple textures into one larger texture to reduce draw calls.

**Tick**: An Unreal Engine event that runs every frame, similar to Update in Unity.

**Transform**: A component that defines an object's position, rotation, and scale in the game world.

**Trigger**: A collider configuration that detects intersections without creating physical collision responses.

### U

**Update()**: A Unity MonoBehaviour event called every frame.

**Utility AI**: A decision-making system that scores potential actions to determine the optimal behavior.

**UV Mapping**: The process of defining how 2D textures are applied to 3D models, where U and V coordinates correspond to X and Y in texture space.

# Game Development Final Exam - Version 4
## Total: 100 points

---

### Question 1 (5 pts)
When using a Rigidbody in Unity, which setting would make it ignore gravity but still respond to forces and collisions?

- [ ] IsKinematic = true  
- [ ] UseGravity = false  
- [ ] IsStatic = true  
- [ ] Constraints = FreezeAll  
- [ ] CollisionDetection = Continuous  

---

### Question 2 (5 pts)
Which Unity event would be most appropriate for camera movement that follows player input?

- [ ] Awake  
- [ ] FixedUpdate  
- [ ] Update  
- [ ] LateUpdate  
- [ ] OnEnable  

---

### Question 3 (5 pts)
In Unity, to optimize comparison of a GameObject's tag, you should use:

- [ ] if(gameObject.CompareTag("Enemy"))  
- [ ] if(gameObject.tag.Equals("Enemy"))  
- [ ] if(gameObject.tag == "Enemy")  
- [ ] if(gameObject.HasTag("Enemy"))  
- [ ] if(string.Compare(gameObject.tag, "Enemy") == 0)  

---

### Question 4 (5 pts)
Which lighting information is typically stored in a normal map?

- [ ] Color intensity  
- [ ] Surface direction for light interaction  
- [ ] Reflectivity values  
- [ ] Shadow projection data  
- [ ] Light source positions  

---

### Question 5 (5 pts)
What property would you adjust to make a surface appear more mirror-like in PBR shaders?

- [ ] Metallic  
- [ ] Emission  
- [ ] Roughness/Smoothness  
- [ ] Normal strength  
- [ ] Albedo intensity  

---

### Question 6 (5 pts)
In Unreal Engine, what type of asset would you create to define a reusable enemy character with its own behavior?

- [ ] Level Blueprint  
- [ ] Animation Blueprint  
- [ ] Character Blueprint  
- [ ] Material Blueprint  
- [ ] Widget Blueprint  

---

### Question 7 (5 pts)
What is true about static methods in C#?

- [ ] They can access non-static fields directly  
- [ ] They can be overridden in derived classes  
- [ ] They can use the "this" keyword  
- [ ] They can be called without instantiating the class  
- [ ] They are always thread-safe  

---

### Question 8 (5 pts)
In Unreal Engine, what is the main purpose of event dispatchers?

- [ ] To create a delay between function calls  
- [ ] To send notifications that other objects can respond to  
- [ ] To debug errors in Blueprint graphs  
- [ ] To call C++ functions from Blueprints  
- [ ] To load levels in the background  

---

### Question 9 (5 pts)
When an animation plays in Unreal Engine's Animation Blueprint, what event is typically used to trigger effects like footstep sounds?

- [ ] Event Graph  
- [ ] Anim Montage  
- [ ] Animation Notifies  
- [ ] Timeline Markers  
- [ ] State Transitions  

---

### Question 10 (5 pts)
What technique in Unreal allows different character skeletons to use the same animations?

- [ ] Animation Layers  
- [ ] Animation Blending  
- [ ] Animation Streaming  
- [ ] Animation Retargeting  
- [ ] Motion Warping  

---

### Question 11 (5 pts)
Which Unity Particle System module controls how long particles exist?

- [ ] Emission  
- [ ] Shape  
- [ ] Lifetime  
- [ ] Renderer  
- [ ] Velocity  

---

### Question 12 (5 pts)
Which technique is most effective for optimizing particle systems in a large open-world game?

- [ ] Using higher resolution particle textures  
- [ ] Implementing a particle LOD system  
- [ ] Rendering all particles in world space  
- [ ] Avoiding particle collisions entirely  
- [ ] Using more sub-emitters for detailed effects  

---

### Question 13 (5 pts)
What is the main purpose of animation layers in a character animation system?

- [ ] To reduce the file size of animation clips  
- [ ] To animate different parts of a character independently  
- [ ] To simplify the animation state machine  
- [ ] To improve animation performance  
- [ ] To convert animations between different formats  

---

### Question 14 (5 pts)
Which technique allows for realistic character interaction with uneven terrain?

- [ ] Root motion  
- [ ] IK (Inverse Kinematics)  
- [ ] Motion capture  
- [ ] Animation retargeting  
- [ ] Blend shapes  

---

### Question 15 (5 pts)
What does a blend space in Unreal Engine primarily do?

- [ ] Combines textures for more realistic materials  
- [ ] Blends between animations based on input parameters  
- [ ] Creates transition areas between different game levels  
- [ ] Mixes audio samples for dynamic sound effects  
- [ ] Merges multiple meshes for LOD optimization  

---

### Question 16 (5 pts)
In game audio design, which technique creates more realistic spatial audio?

- [ ] Higher bitrate audio files  
- [ ] Audio compression  
- [ ] HRTF (Head-Related Transfer Function)  
- [ ] High-pass filtering  
- [ ] Audio normalization  

---

### Question 17 (5 pts)
What is the primary benefit of implementing an audio occlusion system?

- [ ] Reduced memory usage for audio files  
- [ ] More realistic sound propagation through environments  
- [ ] Faster audio file loading times  
- [ ] Support for more audio channels  
- [ ] Automatic audio mixing  

---

### Question 18 (5 pts)
Which rendering technique is most appropriate for optimizing a game with many transparent objects?

- [ ] Forward rendering  
- [ ] Deferred rendering  
- [ ] Order-independent transparency  
- [ ] Sphere tracing  
- [ ] Ray marching  

---

### Question 19 (5 pts)
In a behavior tree AI system, what is the purpose of a selector node?

- [ ] Executes all child nodes in sequence  
- [ ] Tries each child until one succeeds, then returns success  
- [ ] Randomly selects one child node to execute  
- [ ] Prevents child nodes from executing more than once  
- [ ] Pauses execution for a specified time period  

---

### Question 20 (5 pts)
Which of these would NOT be a valid state in a game character's AI system?

- [ ] Attacking  
- [ ] Patrolling  
- [ ] Fleeing  
- [ ] Debugging  
- [ ] Investigating  

---

### Question 21 (5 pts)
What memory management issue in C# can cause performance hitches in games?

- [ ] Stack overflow  
- [ ] Memory leaks  
- [ ] Garbage collection pauses  
- [ ] Heap fragmentation  
- [ ] Buffer overruns  

---

### Question 22 (5 pts)
What is the main advantage of using a scriptable object in Unity over a MonoBehaviour?

- [ ] Scriptable objects run faster than MonoBehaviours  
- [ ] Scriptable objects don't require memory allocation  
- [ ] Scriptable objects can exist as assets without being attached to GameObjects  
- [ ] Scriptable objects support multi-threading  
- [ ] Scriptable objects can be used in the editor only  

---

### Question 23 (5 pts)
In navmesh-based pathfinding, what does the "agent radius" parameter primarily control?

- [ ] How fast the agent moves along the path  
- [ ] The maximum jump height of the agent  
- [ ] How close the agent can get to obstacles  
- [ ] The maximum path length that can be calculated  
- [ ] The field of view for obstacle detection  

---

### Question 24 (5 pts)
Which data structure is typically most efficient for storing and retrieving game objects by ID?

- [ ] Array  
- [ ] Linked List  
- [ ] Dictionary/Hash Table  
- [ ] Stack  
- [ ] Queue  

---

### Question 25 (5 pts)
Which technique would NOT help optimize a mobile game's performance?

- [ ] Using texture atlases  
- [ ] Implementing object pooling  
- [ ] Using higher precision floating-point calculations  
- [ ] Batching static meshes  
- [ ] Implementing occlusion culling  

---

# Answer Key

### Question 1
**Correct Answer**: UseGravity = false  
> **Explanation**: Setting UseGravity to false makes a Rigidbody ignore gravity while still allowing it to respond to other forces and collisions. IsKinematic would make it ignore all physics forces, not just gravity.

### Question 2
**Correct Answer**: LateUpdate  
> **Explanation**: LateUpdate is called after all Update functions have been called, making it ideal for camera movement that follows a character. This ensures the camera moves after the character's position has been updated in the current frame.

### Question 3
**Correct Answer**: if(gameObject.CompareTag("Enemy"))  
> **Explanation**: CompareTag() is optimized to avoid string allocations and garbage collection that can occur with direct string comparison. It's more efficient, especially in frequently called methods.

### Question 4
**Correct Answer**: Surface direction for light interaction  
> **Explanation**: Normal maps store information about the direction a surface is facing (normal vectors), which is used to calculate how light interacts with the surface, creating the appearance of detailed bumps and dents without adding geometry.

### Question 5
**Correct Answer**: Roughness/Smoothness  
> **Explanation**: Roughness (or inversely, Smoothness in some engines) controls how sharply or diffusely light reflects off a surface. Lower roughness/higher smoothness creates more mirror-like reflections.

### Question 6
**Correct Answer**: Character Blueprint  
> **Explanation**: In Unreal Engine, a Character Blueprint is a specialized Class Blueprint designed for creating characters with movement, input handling, and other character-specific behaviors that can be reused throughout the game.

### Question 7
**Correct Answer**: They can be called without instantiating the class  
> **Explanation**: Static methods belong to the class itself rather than any instance, allowing them to be called directly using the class name without creating an object instance first.

### Question 8
**Correct Answer**: To send notifications that other objects can respond to  
> **Explanation**: Event Dispatchers in Unreal Engine act as a messaging system that allows one Blueprint to broadcast an event that other Blueprints can "bind" to and respond to, enabling loose coupling between different parts of the game.

### Question 9
**Correct Answer**: Animation Notifies  
> **Explanation**: Animation Notifies (or Animation Events in Unity) are markers placed at specific points in an animation timeline that trigger callbacks, commonly used for effects synchronized with animations like footstep sounds.

### Question 10
**Correct Answer**: Animation Retargeting  
> **Explanation**: Animation Retargeting is a technique that allows animations created for one skeleton to be applied to a different skeleton, enabling the reuse of animations across different character models with different proportions.

### Question 11
**Correct Answer**: Lifetime  
> **Explanation**: The Lifetime module in a Unity Particle System controls how long particles exist before they are destroyed. It typically includes settings for minimum and maximum lifetime and a curve to control lifetime distribution.

### Question 12
**Correct Answer**: Implementing a particle LOD system  
> **Explanation**: A particle Level of Detail (LOD) system reduces the complexity of particle effects based on distance or performance metrics, maintaining visual quality for nearby effects while optimizing resources for distant ones.

### Question 13
**Correct Answer**: To animate different parts of a character independently  
> **Explanation**: Animation layers allow different parts of a character to play separate animations simultaneously. For example, the lower body could play a walking animation while the upper body aims a weapon.

### Question 14
**Correct Answer**: IK (Inverse Kinematics)  
> **Explanation**: Inverse Kinematics calculates joint rotations based on desired end positions, allowing character feet to properly align with uneven terrain or hands to grasp objects accurately regardless of their position.

### Question 15
**Correct Answer**: Blends between animations based on input parameters  
> **Explanation**: Blend spaces (or blend trees in Unity) interpolate between multiple animations based on one or more input parameters, such as movement speed and direction, creating smooth transitions for actions like turning while walking.

### Question 16
**Correct Answer**: HRTF (Head-Related Transfer Function)  
> **Explanation**: HRTF technology simulates how sounds are altered by a person's head and ears, creating more convincing 3D spatial audio by replicating the subtle cues humans use to locate sound sources in space.

### Question 17
**Correct Answer**: More realistic sound propagation through environments  
> **Explanation**: Audio occlusion systems simulate how sound waves interact with the game environment, reducing volume or filtering frequencies when objects block the path between sound source and listener, creating more realistic audio experiences.

### Question 18
**Correct Answer**: Order-independent transparency  
> **Explanation**: Order-independent transparency (OIT) techniques solve the problem of correctly rendering multiple transparent objects without having to sort them perfectly, which is particularly important for complex scenes with many overlapping transparent elements.

### Question 19
**Correct Answer**: Tries each child until one succeeds, then returns success  
> **Explanation**: A selector node (or fallback node) in a behavior tree attempts to execute its child nodes in order until one succeeds. If a child succeeds, the selector succeeds and stops execution. If all children fail, the selector fails.

### Question 20
**Correct Answer**: Debugging  
> **Explanation**: Debugging is a development process, not a valid AI state for a game character. States like Attacking, Patrolling, Fleeing, and Investigating are common behaviors in AI systems.

### Question 21
**Correct Answer**: Garbage collection pauses  
> **Explanation**: In C#, the garbage collector periodically reclaims memory from objects that are no longer in use. This process can cause momentary pauses in gameplay, especially if many temporary objects are created and discarded rapidly.

### Question 22
**Correct Answer**: Scriptable objects can exist as assets without being attached to GameObjects  
> **Explanation**: Scriptable Objects in Unity store data as assets in the project, independent of any GameObject in a scene. This makes them ideal for configuration data, game rules, or any data that should persist between scene loads.

### Question 23
**Correct Answer**: How close the agent can get to obstacles  
> **Explanation**: The agent radius parameter in navmesh pathfinding defines the minimum distance an agent must maintain from obstacles. It effectively determines the width of corridors the agent can pass through.

### Question 24
**Correct Answer**: Dictionary/Hash Table  
> **Explanation**: Dictionaries (or hash tables) provide O(1) average-case time complexity for lookups by key, making them ideal for retrieving game objects by ID compared to linear searches through arrays or lists.

### Question 25
**Correct Answer**: Using higher precision floating-point calculations  
> **Explanation**: Higher precision calculations (like using double instead of float) require more processing power and memory, which can negatively impact mobile performance. The other options all help optimize performance through various rendering and memory management techniques.

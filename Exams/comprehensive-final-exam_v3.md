# Game Development Final Exam - Version 3
## Total: 100 points

---

### Question 1 (5 pts)
What type of Unity object would best be used for a platform that moves but is unaffected by gravity?

- [ ] Rigidbody  
- [ ] Static Body  
- [ ] Kinematic Body  
- [ ] Dynamic Collider  
- [ ] Animation Controller  

---

### Question 2 (5 pts)
Which Unity MonoBehaviour event should you use for physics-based movement?

- [ ] Awake  
- [ ] Start  
- [ ] Update  
- [ ] FixedUpdate  
- [ ] LateUpdate  

---

### Question 3 (5 pts)
Which of the following would prevent `OnTriggerEnter()` from being called?

- [ ] The collider's `isTrigger` is enabled  
- [ ] One object has a Rigidbody  
- [ ] Both objects have colliders  
- [ ] Neither object has `isTrigger` enabled  
- [ ] One object is marked as static  

---

### Question 4 (5 pts)
What are normal maps primarily used for?

- [ ] Enhancing physics accuracy of mesh collisions  
- [ ] Defining light bounce direction from surfaces  
- [ ] Compressing 3D geometry into textures  
- [ ] Creating object outlines for shaders  
- [ ] Simulating transparency in materials  

---

### Question 5 (5 pts)
Which material property in Unity or Unreal controls how *rough* or *smooth* a surface appears?

- [ ] Albedo  
- [ ] Emission  
- [ ] Metallic  
- [ ] Roughness  
- [ ] Normal  

---

### Question 6 (5 pts)
What does the `Tick` event allow in Unreal Engine?

- [ ] Runs once at the start of the game  
- [ ] Manages audio mixing  
- [ ] Triggers only when a component overlaps  
- [ ] Executes every frame for ongoing updates  
- [ ] Only runs during editor preview  

---

### Question 7 (5 pts)
Why is using `CompareTag("Player")` preferred over `gameObject.tag == "Player"` in Unity?

- [ ] It's faster and avoids memory allocation  
- [ ] It works on inactive objects  
- [ ] It compares tag hierarchies  
- [ ] It automatically logs mismatches  
- [ ] It is more readable in large codebases  

---

### Question 8 (5 pts)
What’s true about static methods in C#?

- [ ] They must be private  
- [ ] They are tied to specific object instances  
- [ ] They cannot access non-static class members  
- [ ] They are automatically garbage collected  
- [ ] They can only be used in Unity scripts  

---

### Question 9 (5 pts)
In Unreal Engine Blueprints, casting is used to:

- [ ] Save an actor to disk  
- [ ] Change an object's scale dynamically  
- [ ] Access specific variables/functions of a known class  
- [ ] Instantiate new actors in the scene  
- [ ] Translate Blueprints to C++ code  

---

### Question 10 (5 pts)
Which use-case best fits a Class Blueprint in Unreal?

- [ ] Managing a specific level's cinematic events  
- [ ] Creating a reusable enemy character template  
- [ ] Adjusting light settings based on player distance  
- [ ] Storing UI menu logic  
- [ ] Debugging post-process effects  

---

### Question 11 (5 pts)
Which is NOT a standard property of a Unity Particle System?

- [ ] Lifetime  
- [ ] Emitter  
- [ ] Pathfinding  
- [ ] Velocity  
- [ ] Color over time  

---

### Question 12 (5 pts)
Which of the following techniques helps reduce overdraw in particle systems?

- [ ] Flipbook animations  
- [ ] Post-processing effects  
- [ ] Using multiple emitters  
- [ ] High-resolution sprites  
- [ ] Limiting transparency stacking  

---

### Question 13 (5 pts)
Which is an example of using animation *layers* effectively?

- [ ] Switching between attack and idle animations  
- [ ] Aiming with the upper body while running with the legs  
- [ ] Changing the character’s costume in real-time  
- [ ] Looping a breathing animation  
- [ ] Retargeting a walk animation to a new skeleton  

---

### Question 14 (5 pts)
Which of the following is TRUE about procedural animation?

- [ ] It only works with skeletal rigs  
- [ ] It’s created in Blender and exported as a file  
- [ ] It responds to runtime data and parameters  
- [ ] It replaces all keyframed animation  
- [ ] It has fewer performance costs than static animation  

---

### Question 15 (5 pts)
Which of the following best describes the role of Additive Animation?

- [ ] Removes blending artifacts  
- [ ] Optimizes animation file size  
- [ ] Allows animations to be played only on root bones  
- [ ] Adds motion on top of a base animation  
- [ ] Converts rotation data into root motion  

---

### Question 16 (5 pts)
Which audio technique makes footsteps sound different on grass vs. concrete?

- [ ] Audio pooling  
- [ ] Procedural audio  
- [ ] Audio listener scaling  
- [ ] Positional attenuation  
- [ ] Audio snapshot blending  

---

### Question 17 (5 pts)
Which is NOT typically part of an audio mixer?

- [ ] Volume controls  
- [ ] Effect routing  
- [ ] Sound occlusion modeling  
- [ ] Group channels  
- [ ] Real-time adjustments  

---

### Question 18 (5 pts)
Which of the following is NOT a good use for LOD (Level of Detail) systems?

- [ ] Reducing model complexity for distant enemies  
- [ ] Lowering texture resolution for faraway terrain  
- [ ] Disabling scripts for off-screen UI
- [ ] Simplifying particle effects for far-off explosions  
- [ ] Improving frame rate on mid-range hardware  

---

### Question 19 (5 pts)
Which of the following AI types scores different actions and chooses the best?

- [ ] Finite State Machine  
- [ ] Behavior Tree  
- [ ] Utility AI  
- [ ] Retargeting AI  
- [ ] Reactive AI  

---

### Question 20 (5 pts)
Which of these is an INVALID state for a finite state machine in enemy AI?

- [ ] Search  
- [ ] Defend  
- [ ] Chase  
- [ ] Reload  
- [ ] Compile  

---

### Question 21 (5 pts)
What does the `new` keyword in C# do?

- [ ] Creates a variable reference to an existing object  
- [ ] Allocates a new object in heap memory  
- [ ] Marks a variable as uninitialized  
- [ ] Destroys the current object and replaces it  
- [ ] Copies an object’s internal state  

---

### Question 22 (5 pts)
Which technique is most efficient for reusing bullets in a Unity shooting game?

- [ ] Constantly instantiating new bullets  
- [ ] Using static variables for bullet tracking  
- [ ] Object pooling  
- [ ] Parenting bullets to the player  
- [ ] Using `Destroy()` inside Update()  

---

### Question 23 (5 pts)
What makes behavior trees more scalable than FSMs in game AI?

- [ ] They don’t require states  
- [ ] They automatically learn from gameplay  
- [ ] They use a priority-based hierarchy and reusable nodes  
- [ ] They’re easier to implement in C++  
- [ ] They only require visual scripting  

---

### Question 24 (5 pts)
What is stored on the *stack* in C#?

- [ ] Class objects  
- [ ] Arrays and strings  
- [ ] Value types like `int`, `float`, and `bool`  
- [ ] All variables declared in MonoBehaviours  
- [ ] References to Unity GameObjects  

---

### Question 25 (5 pts)
Which of the following is a Unity C# **best practice**?

- [ ] Accessing GameObject.Find() in Update  
- [ ] Caching component references in Start or Awake  
- [ ] Using many public variables for faster testing  
- [ ] Modifying transforms directly in FixedUpdate  
- [ ] Declaring all functions as static for speed  


# Answer Key

### Question 1
**Correct Answer**: Kinematic Body  
> **Explanation**: Kinematic Bodies are not affected by physics forces such as gravity or collisions and must be moved manually via code, making them ideal for moving platforms or elevators.

### Question 2
**Correct Answer**: FixedUpdate  
> **Explanation**: FixedUpdate is called at a consistent rate and is designed for physics-related logic. It ensures consistent force application and collision detection regardless of frame rate.

### Question 3
**Correct Answer**: Neither object has `isTrigger` enabled  
> **Explanation**: `OnTriggerEnter()` requires at least one collider to have `isTrigger` enabled, and one of the objects must have a Rigidbody. If neither has `isTrigger` enabled, the event won't fire.

### Question 4
**Correct Answer**: Defining light bounce direction from surfaces  
> **Explanation**: Normals determine how light reflects off a surface, which is key to shading and lighting in 3D graphics.

### Question 5
**Correct Answer**: Roughness  
> **Explanation**: Roughness controls how light is scattered on a surface. A high roughness value gives a matte look, while a low value results in a glossy surface.

### Question 6
**Correct Answer**: Executes every frame for ongoing updates  
> **Explanation**: The Tick event in Unreal Engine runs every frame, enabling per-frame logic such as movement and animations.

### Question 7
**Correct Answer**: It's faster and avoids memory allocation  
> **Explanation**: CompareTag avoids string comparison overhead, reducing memory allocations and avoiding garbage collection spikes.

### Question 8
**Correct Answer**: They cannot access non-static class members  
> **Explanation**: Static methods can only interact with other static members because they do not operate on an instance of the class.

### Question 9
**Correct Answer**: Access specific variables/functions of a known class  
> **Explanation**: Casting in Unreal Blueprints lets you access properties or methods specific to a particular class type.

### Question 10
**Correct Answer**: Creating a reusable enemy character template  
> **Explanation**: Class Blueprints are reusable actors that can be instantiated in different levels, ideal for enemy or item templates.

### Question 11
**Correct Answer**: Pathfinding  
> **Explanation**: Pathfinding is part of AI systems, not particle systems. Particle systems usually include emitters, velocity, color, and lifetime.

### Question 12
**Correct Answer**: Limiting transparency stacking  
> **Explanation**: Excessive overlapping of transparent particles leads to overdraw. Limiting stacked transparency improves performance.

### Question 13
**Correct Answer**: Aiming with the upper body while running with the legs  
> **Explanation**: Animation layers allow different parts of a character to play separate animations simultaneously.

### Question 14
**Correct Answer**: It responds to runtime data and parameters  
> **Explanation**: Procedural animation is dynamically generated through code, enabling it to adapt to real-time gameplay conditions.

### Question 15
**Correct Answer**: Adds motion on top of a base animation  
> **Explanation**: Additive animation lets you stack animations, like adding breathing movement on top of an idle pose.

### Question 16
**Correct Answer**: Procedural audio  
> **Explanation**: Procedural audio dynamically changes based on in-game variables, such as surface type for footsteps.

### Question 17
**Correct Answer**: Sound occlusion modeling  
> **Explanation**: While important for spatial audio, sound occlusion is not typically managed through an audio mixer.

### Question 18
**Correct Answer**: Disabling scripts for off-screen UI  
> **Explanation**: LOD systems reduce model or texture complexity based on distance, not script execution.

### Question 19
**Correct Answer**: Utility AI  
> **Explanation**: Utility AI scores and selects the best action based on current conditions, offering more flexibility than FSMs.

### Question 20
**Correct Answer**: Compile  
> **Explanation**: "Compile" is a programming concept and not a logical state in an AI FSM, unlike Search, Chase, or Idle.

### Question 21
**Correct Answer**: Allocates a new object in heap memory  
> **Explanation**: The `new` keyword in C# creates a new object instance and allocates memory on the heap for it.

### Question 22
**Correct Answer**: Object pooling  
> **Explanation**: Object pooling avoids the performance overhead of frequent instantiation and destruction by reusing objects.

### Question 23
**Correct Answer**: They use a priority-based hierarchy and reusable nodes  
> **Explanation**: Behavior trees support modular, hierarchical logic which promotes reusability and scalability over FSMs.

### Question 24
**Correct Answer**: Value types like `int`, `float`, and `bool`  
> **Explanation**: Stack memory in C# stores value types and handles function calls efficiently, unlike heap memory which stores reference types.

### Question 25
**Correct Answer**: Caching component references in Start or Awake  
> **Explanation**: It's more efficient to use `GetComponent<>()` once in `Start()` or `Awake()` and reuse the result instead of calling it repeatedly in `Update()`.

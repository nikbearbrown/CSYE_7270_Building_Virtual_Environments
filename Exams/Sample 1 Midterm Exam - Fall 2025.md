# CSYE 7270 Midterm Exam — 20 Questions

**Instructions:**
- Each question has **5 options**.
- **Multiple correct answers** (1–3 correct, no more than 3 unless specified).
- Select all that apply.

---

## Questions

### 1. Which sections are standard components of a Game Design Document (GDD)?

- [ ] A. Core gameplay mechanics
- [ ] B. Character bios
- [ ] C. Shader code breakdowns
- [ ] D. Level progression overview
- [ ] E. Enemy AI descriptions

---

### 2. In Unity, which elements does the Transform component directly control?

- [ ] A. Position
- [ ] B. Rotation
- [ ] C. Mass
- [ ] D. Scale
- [ ] E. Roughness

---

### 3. What conditions must be met for Unity's OnTriggerEnter to activate?

- [ ] A. Both objects have colliders
- [ ] B. At least one collider has "Is Trigger" enabled
- [ ] C. At least one Rigidbody is present
- [ ] D. Physics materials must match
- [ ] E. The object must be tagged "Trigger"

---

### 4. Which Unreal Engine window lists all actors currently placed in the level?

- [ ] A. World Outliner
- [ ] B. Content Browser
- [ ] C. Sequencer
- [ ] D. Blueprint Editor
- [ ] E. Output Log

---

### 5. Which statements correctly describe Material Instance usage?

- [ ] A. Allows parameter overrides without modifying the base material
- [ ] B. Reduces shader compile time
- [ ] C. Can switch textures at runtime
- [ ] D. Requires coding in C++
- [ ] E. Cannot use scalar parameters

---

### 6. In Unreal Blueprints, which events fire only once per actor?

- [ ] A. BeginPlay
- [ ] B. Tick
- [ ] C. OnComponentBeginOverlap
- [ ] D. Construct
- [ ] E. EndPlay

---

### 7. Which are valid PBR material properties?

- [ ] A. Metallic
- [ ] B. Specular
- [ ] C. Roughness
- [ ] D. Emission
- [ ] E. Volume Density

---

### 8. Which Unity methods are appropriate for applying physics forces?

- [ ] A. Update()
- [ ] B. FixedUpdate()
- [ ] C. LateUpdate()
- [ ] D. Awake()
- [ ] E. OnCollisionStay()

---

### 9. Which statements describe the purpose of a Unity Prefab?

- [ ] A. A reusable GameObject template
- [ ] B. Stores hierarchy and components
- [ ] C. Cannot be instantiated at runtime
- [ ] D. Helps maintain consistent object setups
- [ ] E. Must contain a Rigidbody

---

### 10. What are common components of particle systems across engines?

- [ ] A. Emitter shape
- [ ] B. Lifetime
- [ ] C. Audio attenuation
- [ ] D. Particle velocity
- [ ] E. Collision settings

---

### 11. What does animation retargeting achieve?

- [ ] A. Reuses animations for characters with different skeletons
- [ ] B. Converts 2D sprites into 3D motion
- [ ] C. Allows quick iteration on character rigs
- [ ] D. Ensures consistent poses between models
- [ ] E. Removes need for skeleton hierarchies

---

### 12. Which features are typically controlled inside a Unity Animator Controller?

- [ ] A. State machines
- [ ] B. Blend Trees
- [ ] C. Audio filters
- [ ] D. Trigger parameters
- [ ] E. Physics constraints

---

### 13. Which Blueprint nodes are commonly used for interactive prompts in Unreal?

- [ ] A. Create Widget
- [ ] B. Add to Viewport
- [ ] C. Apply Force
- [ ] D. Bind Event to OnClicked
- [ ] E. Line Trace by Channel

---

### 14. Which shader concepts are used to create toon/cel shading?

- [ ] A. Step function thresholds
- [ ] B. Hard shadow bands
- [ ] C. Metallic set to 1.0
- [ ] D. Smooth gradient ramps
- [ ] E. High roughness values

---

### 15. Which characteristics define skeletal animation systems?

- [ ] A. Bone hierarchies
- [ ] B. Keyframe interpolation
- [ ] C. Sprite sheet frames
- [ ] D. IK constraints
- [ ] E. Audio time-stretching

---

### 16. Which optimization techniques reduce draw calls?

- [ ] A. Mesh merging
- [ ] B. Texture atlasing
- [ ] C. Using many small materials
- [ ] D. Disabling shadows entirely
- [ ] E. Instancing identical meshes

---

### 17. Which describe the benefits of object pooling?

- [ ] A. Fewer Instantiate/Destroy calls
- [ ] B. Lower GC pressure
- [ ] C. Faster shader compilation
- [ ] D. Reduced memory fragmentation
- [ ] E. More stable framerate

---

### 18. Which Unreal features assist with large open-world streaming?

- [ ] A. World Partition
- [ ] B. Level Streaming Volumes
- [ ] C. Sublevels
- [ ] D. Animation Montages
- [ ] E. Post-Process Volumes

---

### 19. Which tools support AI-assisted texture generation?

- [ ] A. Stable Diffusion
- [ ] B. DALL·E
- [ ] C. Midjourney
- [ ] D. Unreal Niagara
- [ ] E. Unity Shader Graph

---

### 20. Which techniques contribute to high-quality particle effects?

- [ ] A. Using flipbooks for animations
- [ ] B. GPU particle simulation
- [ ] C. Excessive overdraw for transparency
- [ ] D. Velocity-based color changes
- [ ] E. Collider detail at maximum by default

---

---

# Answer Key with Explanations

## Question 1: **A, B, D**
GDDs typically include core gameplay mechanics, character bios, and level progression. Shader code breakdowns belong in technical documentation, not design docs. Enemy AI descriptions may appear but are less standard than the others.

## Question 2: **A, B, D**
Transform controls Position, Rotation, and Scale. Mass is part of Rigidbody, and Roughness is a material property.

## Question 3: **A, B, C**
OnTriggerEnter requires both objects to have colliders, at least one marked as trigger, and at least one Rigidbody. Physics materials and specific tags are not required.

## Question 4: **A**
The World Outliner displays all actors in the current level. Content Browser shows assets, Sequencer is for cinematics, Blueprint Editor is for scripting, and Output Log shows debug messages.

## Question 5: **A, B, C**
Material Instances allow parameter overrides, reduce compile times (no recompilation needed), and can switch textures at runtime. They don't require C++ and can use scalar parameters.

## Question 6: **A, D, E**
BeginPlay fires once when the actor starts, Construct fires during construction, and EndPlay fires once when destroyed. Tick fires every frame, and OnComponentBeginOverlap can fire multiple times.

## Question 7: **A, B, C, D**
Metallic, Specular, Roughness, and Emission are all standard PBR properties. Volume Density is used for volumetric materials, not standard PBR surfaces.

## Question 8: **B, E**
FixedUpdate() is the correct method for physics operations due to its fixed timestep. OnCollisionStay() can also apply forces during collision. Update() has variable timing, making it unsuitable for physics.

## Question 9: **A, B, D**
Prefabs are reusable templates that store hierarchy and components, helping maintain consistency. They CAN be instantiated at runtime and don't require a Rigidbody.

## Question 10: **A, B, D, E**
Emitter shape, lifetime, velocity, and collision settings are core particle system components. Audio attenuation is an audio system feature, not particles.

## Question 11: **A, C, D**
Retargeting reuses animations across different skeletons, enables quick iteration, and maintains consistent poses. It doesn't convert 2D to 3D or remove the need for skeletons.

## Question 12: **A, B, D**
Animator Controllers manage state machines, blend trees, and parameters (including triggers). Audio filters and physics constraints are handled elsewhere.

## Question 13: **A, B, D**
Create Widget and Add to Viewport display UI prompts, and Bind Event to OnClicked handles interaction. Apply Force is for physics, and Line Trace is for raycasting.

## Question 14: **A, B**
Toon shading uses step functions to create hard thresholds and distinct shadow bands. Metallic values, smooth gradients, and roughness don't create the characteristic cel-shaded look.

## Question 15: **A, B, D**
Skeletal animation uses bone hierarchies, keyframe interpolation, and IK constraints. Sprite sheets are for 2D animation, and audio time-stretching is unrelated.

## Question 16: **A, B, E**
Mesh merging, texture atlasing, and instancing all reduce draw calls. Many small materials INCREASE draw calls. Disabling shadows affects rendering but not draw call count directly.

## Question 17: **A, B, D, E**
Object pooling reduces Instantiate/Destroy calls, lowers garbage collection pressure, reduces memory fragmentation, and stabilizes framerate. It doesn't affect shader compilation.

## Question 18: **A, B, C**
World Partition, Level Streaming Volumes, and Sublevels handle open-world streaming. Animation Montages are for animation, and Post-Process Volumes affect visual effects.

## Question 19: **A, B, C**
Stable Diffusion, DALL·E, and Midjourney are AI image generation tools. Niagara is Unreal's particle system, and Shader Graph is Unity's visual shader editor.

## Question 20: **A, B, D**
Flipbooks, GPU simulation, and velocity-based color changes improve particle quality. Excessive overdraw hurts performance, and maximum collider detail is wasteful.

---

*End of Exam*

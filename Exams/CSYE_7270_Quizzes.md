## Quiz 1 `cheat-sheet.md`

# Quiz 1 Cheat Sheet — Topics from Assignments 1–4

*(GDD, Unity Roll-a-Ball, Unreal Blueprints, Shaders/PBR)*

---

## 1) Game Design Document (GDD) Essentials

* **Must-have sections:** Title, Concept (one-liner, genre, platform), Game Flow (core loop, progression), Elements/Assets, Main Character(s), Story, Gameplay (goal, mechanics, abilities/power-ups, levels/challenges, losing/restart, player skills), Graphics/Styling (visual examples), Music/SFX, Technical Description.
* **Good GDD traits:** Clear player goal, concrete mechanics (verbs), readable difficulty curve, visuals (moodboard/UI sketch), scope realism.
* **Assessment cues:** Cite inspirations; distinguish what’s **original** vs **borrowed**; state engine/version, input scheme, save/checkpoint plan.

---

## 2) Unity (Roll-a-Ball Core)

### MonoBehaviour Order & Usage

* **Awake → Start → Update → LateUpdate** (frame); **FixedUpdate** runs at fixed intervals for physics.
* Use **FixedUpdate** for physics forces; **LateUpdate** for camera follow.

### Physics & Collisions

* **OnCollisionEnter** triggers when: both objects have **Colliders** and **at least one has a Rigidbody**; neither collider is a trigger.
* **OnTriggerEnter** triggers when: **at least one collider isTrigger** and **at least one object has a Rigidbody**.
* **CompareTag("TagName")** is preferred over `tag == "TagName"` (faster, no GC).

### Common Components

* **Transform:** position/rotation/scale.
* **Rigidbody:** physics simulation (gravity, forces).

  * Key toggles: **useGravity**, **isKinematic** (ignores forces, move via code).
* **Collider:** collision shape (Box/Sphere/Capsule/Mesh).

### C# Practices (Unity)

* Cache components in **Awake/Start** (`GetComponent<T>()` once).
* Use **[SerializeField]** to expose private fields in Inspector.
* Prefer object pooling over frequent `Instantiate/Destroy`.

---

## 3) Unreal Engine Blueprints (Assignment: Light Toggle, Prompt, Animation BP)

### Blueprint Types

* **Level Blueprint:** per-level logic/events/cinematics.
* **Class Blueprint:** reusable actor templates (lights, doors, enemies).
* **Animation Blueprint:** character anim graph/state machine.

### Key Events & Communication

* **BeginPlay:** runs once when spawned/game starts.
* **Tick:** runs **every frame** (continuous logic).
* **OnComponentBeginOverlap/EndOverlap:** enter/exit trigger volumes.
* **Casting:** convert a generic reference to a specific class to access its variables/functions.
* **Interfaces / Event Dispatchers:** decoupled Blueprint-to-Blueprint messaging.

### UI Prompt Pattern

* Create **Widget Blueprint**; show/hide on key press or proximity.

### Animation BP Basics

* Use **Blend Space** (e.g., Idle/Walk/Run by Speed).
* Build a **State Machine** (Idle ↔ Move; Jump start → In Air → Land).
* Drive variables from Character movement (Velocity, IsFalling).

---

## 4) Shaders & Materials (PBR) — Unity/Unreal

### PBR Maps & Properties

* **Albedo/Base Color:** base texture/color (no lighting baked in).
* **Metallic:** metal vs dielectric behavior.
* **Roughness/Smoothness:** micro-surface; glossy ↔ matte reflections.
* **Normal Map:** perturbs surface normals for lighting detail (no extra geometry).
* **AO (Ambient Occlusion):** crevice darkening; multiplies indirect light.
* **Emission:** self-lit appearance (does not cast light by default).

### Geometry & Texturing

* **Normals:** vectors indicating surface facing; drive lighting/shading.
* **UV Mapping:** how 2D textures wrap to 3D surfaces; U/V are texture axes.

### Shader Literacy (Deconstruction Goals)

* Be able to explain: **node/data flow** (UVs → sampling → math → lighting), **Fresnel/rim**, **normal blending**, **parameter sweeps**, and **performance** (texture lookups, instruction count, mips).

---

## 5) Licensing, Citations, Professionalism (All Assignments)

* **Cite** any external **code, shaders, assets, prompts/tools** used; include **license** and **attribution** (e.g., `LICENSE`, `CREDITS.md`).
* In write-ups/video, **explain what you wrote** vs **what you followed from tutorials**.
* Keep project naming, folders, and README consistent with syllabus.

---

## Mini-Quiz Bank (from relevant questions)

### Unity

* **Order of execution:** *Awake, Start, Update, LateUpdate*; **FixedUpdate** for physics.
* **OnCollisionEnter** needs: both **Colliders**, **≥1 Rigidbody**, **no triggers**.
* **OnTriggerEnter** needs: **≥1 isTrigger**, **≥1 Rigidbody**.
* **Why CompareTag?** Faster, avoids GC vs string compare.
* **Kinematic body:** ignores external forces; moved via code.

### Unreal Blueprints

* **BeginPlay vs Tick:** once at start/spawn vs every frame.
* **Level vs Class Blueprint:** level-specific vs reusable actors.
* **Casting purpose:** access specific class variables/functions.
* **OnComponentBeginOverlap:** proximity logic (e.g., light toggle).
* **Animation BP:** use Blend Spaces + State Machine (≥3 animations).

### Shaders/PBR

* **Albedo vs Specular/Metallic:** color vs reflectance model.
* **Roughness effect:** controls highlight sharpness (glossy ↔ matte).
* **Normal maps:** lighting detail without geometry.
* **UV mapping:** wraps textures to meshes.

### GDD

* **Gameplay section should include:** goal, core mechanics (verbs), abilities/power-ups, levels/challenges, losing/restart, player skill definition.
* **Graphics/Styling:** provide **visual examples** (moodboard/UI).

---

## Quick Checks (do you know…)

* The **exact conditions** for Unity collision vs trigger events?
* How to **toggle a light** via Blueprint overlap or **line trace**?
* How to build a **“Press E to Interact”** prompt (Widget + input)?
* The **difference** between **Level** and **Class** Blueprints?
* What each **PBR map** contributes to the final look?
* How to outline a **core loop** and **progression** in a GDD?

---

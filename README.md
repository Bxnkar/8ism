<div align="center">

# 8ism
### *An AR Application For Specially Abled Children*

[![Domain](https://img.shields.io/badge/Domain-AR_+_AI-darkslateblue?style=for-the-badge)](https://github.com/Bxnkar)
[![Platform](https://img.shields.io/badge/Platform-Android_AR-orange?style=for-the-badge)](https://github.com/Bxnkar)
[![Unity](https://img.shields.io/badge/Engine-Unity_2022.3-black?style=for-the-badge&logo=unity)](https://unity.com)

</div>

---

> *"If being special is your power,*
> *what are you without it - Socrates"*

---

## What Is 8ism?

**8ism** is an **AI-powered Augmented Reality companion** built for **Android**, designed to support **autistic children** in learning and practicing daily life skills through gentle, non-intrusive interaction.

Rather than functioning as a loud assistant or instructor, 8ism manifests as a **calm, predictable, and emotionally aware entity** — existing gently between reality and imagination.

> It does not command. It does not rush. It waits.

### Core Focus Areas

- **Daily Life Routines** — Guided habit-building through AR demonstrations
- **Social Interaction** — Safe, low-pressure practice in recognising and responding to social cues
- **Emotional Recognition** — Emotion-aware AI that adapts to the child's state without judgment

---

## Design Philosophy — The Gentle Mystery Doctrine

Inspired by the **Lord of the Mysteries** aesthetic, 8ism follows a **Benevolent Entity Design Model**:

| Principle | Implementation |
|---|---|
| Low stimulation over excitement | Minimal UI, calm animations, soft color palette |
| Observation over instruction | Entity waits; never interrupts or demands |
| Rituals over task lists | Routines feel ceremonial, not transactional |
| Emotions as signals, not errors | No failure states; every response is valid |
| Silence is respected | No auto-prompting or timeout penalties |

Every interaction is optional. Every silence is honoured.

---

## AR Demonstration System

8ism features a **3D humanoid character** (Civilian model) that performs animated daily routines in Augmented Reality, triggered by simple UI buttons:

| Button | Animation |
|---|---|
| Bottle Opening | Opens Bottle |
| Hand Fan |Using Hand Held Fan|
| Iron Clothes | Ironing Clothes |

Animations are built using Unity's **Humanoid Muscle system**, ensuring compatibility with any rigged character. Props are parented to the hand bone and appear or disappear automatically on button press.

### Technical Stack

| Layer | Technology |
|---|---|
| Engine | Unity 2022.3 LTS |
| AR Framework | Mobile AR Template (XR Interaction Toolkit) |
| Animation | Unity Animator + Humanoid Muscle Curves |
| AI Layer | Emotion-aware response system |
| Platform | Android (Portrait, 1920×1080) |
| Version Control | Unity VCS |

---

## Project Structure

```
Assets/
├── ARAnimations/
│   ├── Animations/          # BrushTeeth, CombHair, TurnOnButton .anim files
│   ├── Scripts/
│   │   ├── Editor/          # AnimationGenerator.cs (procedural anim builder)
│   │   └── ButtonAnimationController.cs
│   └── Civilian3Controller  # Animator Controller state machine
├── MobileARTemplateAssets/  # XR, AR camera, affordance themes
├── Genie/                   # AI companion logic
├── Models/                  # Civilian 3 humanoid FBX (Mixamo rig)
└── Scenes/                  # Main AR scene
```

---

## Scene Overview

The main scene consists of:

- **AR Camera** — Tracks real-world surfaces via the device camera
- **Civilian** — Humanoid character performing animations in AR space
- **Canvas UI** — Three trigger buttons (Brush, Comb, TurnOn) at the bottom of screen
- **AnimationManager** — Runtime controller wiring buttons to the Animator
- **Directional Light** — Scene lighting for model visibility

---

## Future Evolutions — Unsealed Paths

- **Multi-language entities** — Support for regional languages to broaden accessibility
- **Therapist-guided ritual modes** — Supervised session configuration for clinical use
- **VR Safe-Realm environments** — Expanded immersion via standalone VR headsets
- **Ethical AI-driven progress analytics** — Non-intrusive tracking of learning milestones
- **Emotion detection via camera** — Real-time facial expression recognition to adapt entity behaviour

---

## Developers — The Observers

<table>
<tr>
<td align="center">
<b>Om Bankar</b><br/>
AR Development · System Design<br/>
<a href="https://github.com/Bxnkar">@Bxnkar</a>
</td>
<td align="center">
<b>Piyush Bambori</b><br/>
AI & ML · Backend · System Architecture<br/>
<a href="https://github.com/PiyuuBambori">@Piyush</a>
</td>
</tr>
</table>

---

## Strengthen the Seal

If this project resonates with you, leave a ⭐ on GitHub — it helps the entity endure.

---

<div align="center">

**"The Only True Wisdom is in Knowing That You Know Nothing - Socrates."**

*8ism - Om Bankar, Piyush Bambori · Android AR · AI Companion*

</div>

# Lethal Elements THETA (θ)

> Fork of [LethalElementsBeta](https://thunderstore.io/c/lethal-company/p/v0xx/LethalElementsBeta) by [v0xx](https://github.com/v0xx-dev) updated for the latest game versions (`v73` and above), with some additional fixes and small changes.

---

A weather enhancement mod for Lethal Company that introduces new environmental challenges to test your survival skills.

<!-- <img src="https://placeholder-image.com/lethal-elements-logo.png" alt="Lethal Elements Logo" width="400"> -->

---

> Currently featuring: HEATWAVE, SOLAR FLARE, SNOWFALL, BLIZZARD, TOXIC SMOG

> More extreme weather conditions coming soon!

---

### Current forecast: Heatwave

<img src="https://i.imgur.com/q9iCEnc.gif" alt="Heatwave Effect" width="200">

Brace yourself for scorching temperatures that will push your endurance to the limit!

- **Heat Exhaustion**: Extended exposure decreases your stamina and slows its regeneration.
- **Visual Distortion**: Experience realistic heat haze effects that blur your vision.
- **Cooldown**: The strength of the heatwave changes over time depending on sunlight intensity

---

### Next on: Solar Flare

<img src="https://i.imgur.com/JbCFujq.gif" alt="Solar Flare Effect" width="200">

Beware the unpredictable and disruptive effects of solar radiation!
Solar flares come in four intensities: **Weak**, **Mild**, **Average**, and **Strong**. Each level changes the severity of the following effects:

- Radio Interference: Distorts walkie-talkie communication quality, making team coordination challenging.
- Radar Map Distortion: Causes visual noise and inaccuracies on your radar map screen.
- Teleporter Malfunction: Reduces the precision of ship teleporters, potentially leading to dangerous misplacements.
- Battery Drain: Accelerates the discharge rate of electronic devices.
- Signal Scrambling: Randomly switches letters in messages transmitted with the signal translator, increasing the risk of miscommunication.
- Door Malfunction: (Strong and Average only) Steel doors in facilities become unresponsive to manual controls, randomly opening and closing throughout the day.
- Visual Effects:

  - Daytime: Observe intense solar activity on the sun's surface.
  - Nighttime: Witness breathtaking **auroras** painting the sky in vibrant colors.

<img src="https://i.imgur.com/gK85ndi.gif" alt="Aurora" width="400">

**Countermeasures**:

- Activate *radar boosters* to mitigate some of the interference effects.

<img src="https://i.imgur.com/uq2Y2qK.gif" alt="Solar Flare Effect" width="300">

---

### Cold front approaching: Snowfall  

<img src="https://i.imgur.com/g4tOdmU.gif" alt="Snowfall Effect" width="300">  

Bundle up and prepare for a wintry landscape that evolves as the storm continues. Can you navigate the icy challenges?  

- **Dynamic Snow Accumulation**: Snow piles up over time, altering the terrain and slowing everyone down based on its thickness.  
- **Trailblazing**: Every step leaves a trail in the snow, allowing faster movement in established paths. Create trenches for strategic mobility!  
- **Shoveling Strategy**: Use shovels to clear critical areas or dig yourself out of trouble.  
- **Freezing Hazard**: Stay too long in deep snow, and you'll risk freezing solid-find warmth or shelter to survive.  
- **Frozen Waters**: Open water bodies freeze over, creating both opportunities and obstacles.  

<img src="https://i.imgur.com/hd6HWUV.png" alt="Fluffy snow!" width="500">

---

### Brace yourself for: Blizzard  

<img src="https://i.imgur.com/gpfNkwj.png" alt="Blizzard Effect" width="500">  

The ultimate test of endurance-survive the unforgiving fury of a full-blown blizzard!  

- **All Snowfall Effects Included**: Blizzard intensifies the challenges of snow accumulation, trails, freezing, and frozen water.  
- **Frigid Winds**: Howling winds constantly change direction, pushing players off course and chilling them to the bone.  
- **Frostbite Threat**: Exposure to the wind slowly drains your health with frostbite damage-find cover to recover!  
- **Chilling Ice Wave**: Periodically, the blizzard unleashes a devastating wave of cold, inflicting instant frostbite and sweeping away anyone caught in its path.  

Stay alert and adapt to the unpredictable weather to outlast the storm!  

<img src="https://i.imgur.com/ZVLBQbM.png" alt="Icy wave" width="500">

---

### Health hazard: Toxic Smog

<img src="https://i.imgur.com/4njKFQq.gif" alt="Poisoned environment" width="500">  

Prepare for the insidious threat of the Toxic Fog!

- **Visibility Impaired**: The fog drastically reduces visibility, making navigation treacherous.

- **Toxic Fume Clouds**: Deadly clouds of toxic fumes spawn both indoors and outdoors.

- **Poisoning**: Breathing the fumes causes severe poisoning, steadily draining health.

- **Visual Distortion**: Prolonged exposure to the fumes leads to disorienting visual distortions, impairing your ability to aim and react.

Evade the deadly clouds and manage your exposure to survive the choking grip of the Toxic Fog!

---

### Current issues

- Snow doesn't have game's posterization filter applied to it (unfixable)
- Scanner pulse doesn't interact with the snow visually for the same reason (unfixable)
- All particles are rendered on the GPU so collision detection is approximated, sometimes they can go through walls if they are very thin (unfixable, unless the pipeline is changed which will result in decrease of performance)
- If you have very low fps trails left by other player might not have the same depth as for others (possibly fixable, but requires lots of additional work)
- Monsters will be slowed down only in the vicinity of the host player (fixable, but very performance costly)

<!-- ### Installation

1. Download and install the mod using r2modman or Thunderstore Mod Manager.
2. Ensure you have BepInEx installed.
3. Launch Lethal Company and prepare for new weather challenges!

***Mods that can increase render distance like [ViewExtension](https://thunderstore.io/c/lethal-company/p/sfDesat/ViewExtension/) or [CullFactory](https://thunderstore.io/c/lethal-company/p/fumiko/CullFactory/) (requires configuration) are HIGHLY recommended! Choose a view distance of 750 and above for the best experience.*** -->

### Planned Features

- ???

Stay tuned for updates!

### Credits

- **Fork Maintainer:** [pacoito](https://github.com/pacoito123)
- **Original Developer**: [v0xx](https://github.com/v0xx-dev)

**Special Thanks**:

- [mrov](https://github.com/AndreyMrovol) for creating [WeatherRegistry](https://thunderstore.io/c/lethal-company/p/mrov/WeatherRegistry).
- [PureFPSZac](https://github.com/PureFPSZac) and [s1ckboy](https://github.com/s1ckboii) for the initial Blizzard weather concept.
- The Lethal Company modding community for inspiration and support!

### License

This mod is licensed under the [Attribution-NonCommercial 4.0 International](https://creativecommons.org/licenses/by-nc/4.0) License (`CC BY-NC 4.0`).

### Source code

- **Fork:** <https://github.com/pacoito/LC_LethalElementsTheta>
- **Original:** <https://github.com/v0xx-dev/VoxxWeatherPlugin>

### Contact

For bug reports, suggestions, or general feedback:

- **Discord:** `pacoito`, or `_v0xx_` if he returns *(we miss you!)*

<!-- Enjoy the new weather challenges, and may your scavenging missions be both profitable and survivable! -->

``` statblock
monster: Moltrax the Smeltery Tyrant
name: Moltrax the Smeltery Tyrant
size: Large
type: Elemental
subtype: Fire
alignment: Chaotic Evil
ac: 17 (molten armor)
hp: 180
speed: 30 ft., swim 20 ft. (lava only)
stats:
  - 20
  - 14
  - 18
  - 10
  - 12
  - 13
saves:
  - strength: 8
  - constitution: 7
  - dexterity: 5
skillsaves:
  - intimidation: 5
  - perception: 4
damage_vulnerabilities: cold
damage_resistances: bludgeoning, piercing, and slashing from nonmagical attacks
damage_immunities: fire, poison
condition_immunities: poisoned, grappled, restrained, prone
senses: darkvision 60 ft., passive Perception 14
languages: Ignan; understands Dwarvish but can’t speak
cr: 9
proficiency_bonus: 3
traits:
  - name: Molten Body
    desc: A creature that hits Moltrax with a melee attack while within 5 feet takes 5 (1d10) fire damage.
  - name: Furnace Core
    desc: If Moltrax would take fire damage, it instead regains hit points equal to half the fire damage.
  - name: Heat Shimmer Aura
    desc: Creatures that start their turn within 10 feet of Moltrax take 3 (1d6) fire damage (no save). A creature that takes this damage has disadvantage on the next Dexterity (Stealth) check made before the start of its next turn (the heat distorts and glows).
  - name: Lava Glide
    desc: While in its lair, Moltrax can use 10 feet of movement to submerge into a lava pit and emerge from another lava pit within 60 feet. This movement does not provoke opportunity attacks.
  - name: Legendary Resistance (2/Day)
    desc: If Moltrax fails a saving throw, it can choose to succeed instead.
  - name: Phase Ignition
    desc: The first time Moltrax is reduced to 90 hit points or fewer, the smeltery floor fractures in sparks. Moltrax immediately uses Ignition Surge (no action) and regains one spent Legendary Action. Additionally, Molten Slam and Lava Whip each deal an extra 3 (1d6) fire damage for the rest of the encounter.
actions:
  - name: Multiattack
    desc: Moltrax makes two attacks in any combination of Molten Slam and Lava Whip.
  - name: Molten Slam
    desc: "Melee Weapon Attack: +8 to hit, reach 5 ft., one target. Hit: 15 (2d8 + 6) bludgeoning damage plus 7 (2d6) fire damage."
  - name: Lava Whip
    desc: "Melee Weapon Attack: +8 to hit, reach 60 ft., one target. Hit: 11 (2d6 + 4) fire damage, and the target must succeed on a DC 15 Strength saving throw or be pulled up to 15 feet toward Moltrax. A target pulled into a space within 5 feet of Moltrax immediately takes Molten Body damage."
  - name: Eruption (Recharge 5–6)
    desc: Moltrax slams its fists down, causing molten cracks to explode in a 20-foot radius centered on itself (creatures currently in the air and at least 10 ft. up are unaffected). Each creature in the area must make a DC 15 Dexterity saving throw, taking 21 (6d6) fire damage on a failed save, or half as much on a success. Spaces that failed saves become searing slag until the start of Moltrax's next turn; a creature that enters or starts its turn in searing slag takes 5 (1d10) fire damage.
bonus_actions:
  - name: Ignition Surge (Recharge 4–6)
    desc: Moltrax superheats. Until the start of its next turn, its melee attacks deal an extra 3 (1d6) fire damage, and it has advantage on the next attack roll it makes before the end of its turn.
reactions:
  - name: Scalding Backlash
    desc: When hit by a melee attack from a creature within 5 feet, Moltrax vents superheated steam. The attacker must succeed on a DC 15 Constitution saving throw or take 7 (2d6) fire damage and have disadvantage on its next attack roll before the end of its next turn.
legendary_actions:
  - name: Lava Tendril
    cost: 1
    desc: Moltrax makes a Lava Whip attack.
  - name: Smoldering Stride
    cost: 1
    desc: Moltrax moves up to half its speed without provoking opportunity attacks. Squares it moves through ignite until the start of its next turn; a creature that enters or starts its turn in an ignited square takes 5 (1d10) fire damage.
  - name: Magma Burst
    cost: 2
    desc: Moltrax causes magma to spurt from a crack in the ground at a point it can see within 30 feet. Each creature within 10 feet of that point must succeed on a DC 15 Dexterity saving throw or take 10 (3d6) fire damage and have its speed reduced by 10 feet until the end of its next turn.
  - name: Furnace Roar
    cost: 3
    desc: Moltrax unleashes a blast of furnace heat and rage. Each creature of its choice within 30 feet must succeed on a DC 15 Wisdom saving throw or become frightened of Moltrax until the end of that creature’s next turn. Moltrax gains 10 temporary hit points.
source: Homebrew
layout: Basic 5e Layout
lair_actions:
  - name: Molten Vent
    init: 20
    desc: A fissure opens at a point on the ground Moltrax can see within 60 feet, belching gouts of flame. Each creature within a 5-foot radius of that point must make a DC 15 Dexterity saving throw or take 10 (3d6) fire damage. The square remains superheated (5 fire damage on entry/start) until initiative count 20 on the next round.
  - name: Slagfall
    init: 20
    desc: Superheated slag loosens from ceiling ducts and drops in a 10-foot-square area that Moltrax can see within 60 feet. Each creature in the area makes a DC 15 Dexterity saving throw, taking 14 (4d6) bludgeoning plus 7 (2d6) fire damage on a failure, half on success. The area becomes difficult terrain.
  - name: Heat Pulse
    init: 20
    desc: A pressure wave of furnace heat rolls through the chamber. Creatures that aren’t immune to fire within 60 feet of Moltrax must succeed on a DC 15 Constitution saving throw or suffer disadvantage on the next saving throw they make before initiative count 20 next round. Creatures that fail also take 5 (1d10) fire damage.
regional_effects: []



```
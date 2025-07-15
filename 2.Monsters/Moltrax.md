``` statblock
monster: Moltrax, the Smeltery Tyrant
name: Moltrax, the Smeltery Tyrant
size: Large
type: Elemental
subtype: Fire
alignment: Chaotic Evil
ac: 16 (molten armor)
hp: 105 (14d10 + 28)
speed: 30 ft.
stats: [18, 14, 16, 10, 12, 13]  # STR, DEX, CON, INT, WIS, CHA
saves:
  - strength: +7
  - constitution: +6
  - dexterity: +5
skillsaves:
  - intimidation: +5
  - perception: +4
damage_vulnerabilities: cold
damage_resistances: bludgeoning, piercing, and slashing from nonmagical attacks
damage_immunities: fire, poison
condition_immunities: poisoned, grappled, restrained, prone
senses: darkvision 60 ft., passive Perception 14
languages: Ignan, understands Dwarvish but can’t speak
cr: 7
proficiency_bonus: +3
spells:
  - 2/day each [[Heat Metal]], [[Misty Step (fiery burst)]]
  - 1/day [[Fireball]]
traits:
  - name: Molten Body
    desc: "A creature that hits Moltrax with a melee attack while within 5 feet takes 5 (1d10) fire damage."
  - name: Furnace Core
    desc: "If Moltrax would take fire damage, it instead regains hit points equal to half the fire damage."
actions:
  - name: Multiattack
    desc: "Moltrax makes two melee attacks: one with Molten Slam and one with Lava Whip."
  - name: Molten Slam
    desc: "+7 to hit, reach 5 ft., one target. Hit: 13 (2d8 + 4) bludgeoning damage plus 7 (2d6) fire damage."
  - name: Lava Whip
    desc: "+7 to hit, reach 15 ft., one target. Hit: 9 (1d10 + 4) fire damage, and the target must succeed on a DC 14 Strength saving throw or be pulled 10 ft. toward Moltrax."
  - name: Eruption (Recharge 5–6)
    desc: "Moltrax causes molten cracks to burst from the floor in a 15-ft. radius. Each creature in the area must make a DC 14 Dexterity saving throw, taking 17 (5d6) fire damage on a failed save, or half on a success."
bonus_actions:
  - name: Ignition Surge
    desc: "Until the start of its next turn, Moltrax’s melee attacks deal an extra 1d6 fire damage."
reactions:
  - name: Scalding Backlash
    desc: "When hit by a melee attack, Moltrax can emit a blast of steam. The attacker must succeed on a DC 13 Constitution saving throw or take 5 (1d10) fire damage."
legendary_actions: []

```
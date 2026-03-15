```statblock
monster: Star Spawn Hulk
name: Star Spawn Hulk
size: Large
type: Aberration
subtype: None
alignment: Typically Chaotic Evil
ac: 16
hp: 136
speed: 30 ft.
stats: [20, 8, 21, 7, 12, 9]
saves:
  - dex: +3
  - con: +5
  - wis: +5
skillsaves:
  - perception: +5
damage_vulnerabilities: None
damage_resistances: Bludgeoning, Piercing, and Slashing from Nonmagical Attacks
damage_immunities: None
condition_immunities: Charmed; Frightened
senses: Darkvision 60 ft., passive Perception 15
languages: Deep Speech
cr: 10
proficiency_bonus: +4

traits:
  - name: Psychic Mirror
    desc: "If the hulk takes psychic damage, each creature within 10 feet of the hulk takes that damage instead; the hulk takes none of the damage. In addition, the hulk's thoughts and location can't be discerned by magic."

actions:
  - name: Multiattack
    desc: "The hulk makes two Slam attacks. If both attacks hit the same target, the target also takes 9 (2d8) psychic damage and must succeed on a DC 17 Constitution saving throw or be stunned until the end of the target's next turn."
  - name: Slam
    desc: "Melee Weapon Attack: +9 to hit, reach 10 ft., one target. Hit: 14 (2d8 + 5) bludgeoning damage."
  - name: Reaping Arms (Recharge 5–6)
    desc: "The hulk makes a separate Slam attack against each creature within 10 feet of it. Each creature that is hit must also succeed on a DC 17 Dexterity saving throw or be knocked prone."

```
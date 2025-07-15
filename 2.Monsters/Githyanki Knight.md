```statblock
monster: Githyanki Knight
name: Githyanki Knight
size: Medium
type: Humanoid
subtype: Gith
alignment: Lawful Evil
ac: 18 (plate)
hp: 91
speed: 30 ft.
stats: [16, 14, 15, 14, 14, 15]  # STR, DEX, CON, INT, WIS, CHA
saves:
  - constitution: +5
  - intelligence: +5
  - wisdom: +5
skillsaves: []
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 12
languages: Common, Gith
cr: 8
proficiency_bonus: +3
spells:
  - cantrips [[Mage Hand]]
  - 3rd level (2/day) [[Nondetection]], [[Tongues]]
  - 5th level (1/day) [[Plane Shift]], [[Telekinesis]]
traits:
  - name: Innate Spellcasting (Psionics)
    desc: "The githyanki’s innate spellcasting ability is Intelligence (spell save DC 13, +5 to hit with spell attacks). It can innately cast the following spells, requiring no components."
actions:
  - name: Multiattack
    desc: "The githyanki makes two silver greatsword attacks."
  - name: Silver Greatsword
    desc: "+9 to hit, reach 5 ft., one target. Hit: 13 (2d6 + 6) slashing damage plus 10 (3d6) psychic damage. On a critical hit against a creature in an astral body, the githyanki severs the silvery cord instead of dealing damage."
bonus_actions:
  - name: Misty Step (2/day)
    desc: "The githyanki casts Misty Step, requiring no components."
reactions: []
legendary_actions: []

```

```statblock
monster: Marid
name: Marid
size: Large
type: Elemental
subtype: Genie
alignment: Chaotic Neutral
ac: 17
hp: 230
speed: 30 ft., Fly 60 ft., Swim 90 ft.
stats: [22, 12, 26, 18, 17, 18]
saves:
  - dexterity: +5
  - charisma: +8
skillsaves: []
damage_vulnerabilities: None
damage_resistances: Acid, Cold, Lightning
damage_immunities: None
condition_immunities: []
senses: Blindsight 30 ft., Darkvision 120 ft., passive Perception 13
languages: Primordial (Aquan)
cr: 11
proficiency_bonus: +4
spells:
  - at will: [[Create or Destroy Water]], [[Detect Evil and Good]], [[Detect Magic]], [[Purify Food and Drink]]
  - 1/day each: [[Control Water]], [[Gaseous Form]], [[Invisibility]], [[Plane Shift]], [[Tongues]]
traits:
  - name: Amphibious
    desc: "The marid can breathe air and water."
  - name: Elemental Restoration
    desc: "If the marid dies outside the Elemental Plane of Water, its body dissolves into brine, and it gains a new body in 1d4 days, reviving with all its Hit Points somewhere on the Plane of Water."
  - name: Wishes
    desc: "The marid has a 30% chance of knowing the Wish spell. If it knows it, the marid can cast it only on behalf of a non-genie creature who communicates a wish in a way the marid can understand. Casting the spell causes no stress to the marid. After three uses, it cannot cast it again for 365 days."
actions:
  - name: Multiattack
    desc: "The marid makes three Aquatic Lash attacks."
  - name: Aquatic Lash
    desc: "Melee Attack: +10 to hit, reach 15 ft. Hit: 15 (2d8 + 6) Slashing damage plus 9 (2d8) Cold damage."
  - name: Water Jet
    desc: "Dexterity Save DC 18, 60 ft. long, 10 ft. wide line. Failure: 31 (9d6) Cold damage and Huge or smaller creatures are pushed 20 ft and prone. Success: Half damage."
bonus_actions:
  - name: Misty Veil (Recharge 5–6)
    desc: "The marid casts [[Fog Cloud]] using the same spellcasting ability as Spellcasting."
legendary_actions: []
```

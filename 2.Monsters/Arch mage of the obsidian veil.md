```statblock
monster: Archmage of the Obsidian Veil
name: Archmage of the Obsidian Veil
size: Medium
type: Humanoid
subtype: Human
alignment: Neutral Evil
ac: 17 
hp: 165
speed: 30 ft.
stats: [10, 14, 16, 20, 16, 18]
saves:
  - int: +9
  - wis: +7
  - cha: +8
skillsaves:
  - arcana: +9
  - history: +9
  - insight: +7
  - perception: +7
damage_vulnerabilities: None
damage_resistances: Psychic; Bludgeoning, Piercing, and Slashing from Nonmagical Attacks
damage_immunities: None
condition_immunities: None
senses: passive Perception 17
languages: Common, Elvish, Draconic
cr: 10
proficiency_bonus: +4
spells:
  - cantrips (at will): [[Fire Bolt]] 3d10, [[Ray of Frost]] 3d8, [[Minor Illusion]]
  - 1st level (4 slots): [[Shield]], [[Magic Missile]], [[Mage Armor]], [[Detect Magic]]
  - 2nd level (3 slots): [[Mirror Image]], [[Misty Step]], [[Hold Person]]
  - 3rd level (3 slots): [[Counterspell]], [[Fireball]], [[Dispel Magic]]
  - 4th level (3 slots): [[Greater Invisibility]], [[Ice Storm]]
  - 5th level (2 slots): [[Wall of Force]], [[Cone of Cold]]
  - 6th level (1 slot): [[Disintegrate]]
traits:
  - name: Spellcasting
    desc: "The Archmage is a 12th-level spellcaster. Its spellcasting ability is Intelligence (spell save DC 17, +9 to hit with spell attacks)."
  - name: Legendary Resistance (3/Day)
    desc: "If the Archmage fails a saving throw, it can choose to succeed instead."
  - name: Arcane Ward
    desc: "When the Archmage casts an abjuration spell of 1st level or higher, it gains 10 temporary hit points. These temporary hit points refresh when it casts another abjuration spell."
  - name: Arcane Mastery
    desc: "The Archmage can maintain concentration on up to two spells simultaneously, but only one can require an action to cast each turn."
actions:
  - name: Arcane Blast
    desc: "Ranged Spell Attack: +9 to hit, range 120 ft., one target. Hit: 18 (4d8) force damage."
  - name: Disintegrate (6th level; Recharge 5–6)
    desc: "A thin green ray springs from the Archmage’s finger. The target must make a DC 17 Dexterity saving throw, taking 75 (10d6 + 40) force damage on a failed save, or half as much on a success. If this damage reduces a creature to 0 hit points, it is disintegrated."
  - name: Cone of Cold (5th level)
    desc: "A blast of freezing air erupts in a 60-foot cone. Each creature in that area must make a DC 17 Constitution saving throw, taking 45 (8d8) cold damage on a failed save, or half as much on a success."
bonus_actions:
  - name: Misty Step (2nd level)
    desc: "The Archmage teleports up to 30 ft. to an unoccupied space it can see."
  - name: Greater Invisibility (4th level)
    desc: "The Archmage turns invisible until concentration ends (up to 1 minute). Anything the Archmage is wearing or carrying is invisible as long as it remains in its possession."
reactions:
  - name: Shield
    desc: "The Archmage adds +5 to its AC against one attack that would hit it. This effect lasts until the start of its next turn."
  - name: Counterspell
    desc: "The Archmage interrupts a creature casting a spell within 60 ft. If the spell is 3rd level or lower, it fails automatically; otherwise, make an Intelligence check (DC 10 + spell’s level)."
legendary_actions:
  - name: Cantrip
    desc: "The Archmage casts a cantrip."
  - name: Arcane Step (Costs 2 Actions)
    desc: "The Archmage teleports up to 30 ft. to an unoccupied space it can see."
  - name: Unleash Power (Costs 3 Actions)
    desc: "The Archmage immediately casts a spell of 3rd level or lower without expending a spell slot."

```
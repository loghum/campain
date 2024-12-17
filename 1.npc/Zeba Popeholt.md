---
name: Zeba Popeholt
location: Thundercore
role: Shool student
building: "[[Ironheart’s Academy of Blades and Spells]]"
level: "3"
hp: "27"
ac: "16"
modifier: "2"
---
Name: Zeba Popeholt
Description: Middle-aged, Male, Dwarf, Short frizzy hair, Average height, Muscular build, Two different color eyes
Voice: Deep, Normal volume, Slow, Speaks in a very formal manner
Mannerism: They are always looking for a way to make money
PlotHook: Is being framed for a crime they didn't commit

Conquest Paladin
```statblock

monster: Zeba Popeholt
name: Zeba Popeholt
size: Medium
type: Humanoid
subtype: None
alignment: Lawful Evil
ac: 16
hp: 27
speed: 30 ft.
stats: [16, 10, 14, 10, 10, 16]
saves:
  - strength: +5
  - dexterity: +0
  - constitution: +4
  - intelligence: +0
  - wisdom: +2
  - charisma: +5
skillsaves:
  - None
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: Passive Perception 10
languages: Common, Celestial
cr: 1
spells:
  - 1st level (3 slots) [[Bless]], [[Command]], [[Wrathful Smite]]
traits:
  - name: Aura of Conquest
    desc: Creatures within 10 feet of the Paladin that are frightened have their speed reduced to 0
  - name: Divine Smite
    desc: When the Paladin hits a creature with a melee weapon attack, they can expend a spell slot to deal radiant damage in addition to the weapon's damage. The extra damage is 2d8 for a 1st-level spell slot, plus 1d8 for each spell level higher than 1st, up to a maximum of 5d8
  - name: Spellcasting
    desc: The Paladin is a 3rd-level spellcaster. Their spellcasting ability is Charisma (spell save DC 13, +5 to hit with spell attacks)
actions:
  - name: Longsword
    desc: Melee Weapon Attack +5 to hit, reach 5 ft., one target. Hit 1d8+3 slashing damage or 1d10+3 if used with two hands
  - name: Commanding Strike
    desc: The Paladin utters a command, forcing one creature of their choice within 30 feet that can hear them to make a DC 13 Wisdom saving throw or become frightened for 1 minute. The target can repeat the saving throw at the end of each of its turns, ending the effect on a success. (Recharge 5-6)
legendary_actions:
  - name: None
    desc: None
bonus_actions:
  - name: None
    desc: None
reactions:
  - name: None
    desc: None

```

{
  "name": "Conquest Paladin",
  "source": "Homebrew",
  "size": "Medium",
  "type": "Humanoid",
  "alignment": "Lawful Evil",
  "ac": 16,
  "hp": 27,
  "hit_dice": "3d10+6",
  "speed": "30 ft.",
  "stats": [16, 10, 14, 10, 10, 16],
  "saves": {
    "strength": 5,
    "dexterity": 0,
    "constitution": 4,
    "intelligence": 0,
    "wisdom": 2,
    "charisma": 5
  },
  "damage_vulnerabilities": "None",
  "damage_resistances": "None",
  "damage_immunities": "None",
  "condition_immunities": [],
  "senses": "Passive Perception 10",
  "languages": "Common, Celestial",
  "cr": "1",
  "proficiency_bonus": 2,
  "bestiary": true,
  "traits": [
    {
      "name": "Aura of Conquest",
      "desc": "Creatures within 10 feet of the Paladin that are frightened have their speed reduced to 0."
    },
    {
      "name": "Divine Smite",
      "desc": "When the Paladin hits a creature with a melee weapon attack, they can expend a spell slot to deal radiant damage in addition to the weapon's damage. The extra damage is 2d8 for a 1st-level spell slot, plus 1d8 for each spell level higher than 1st, up to a maximum of 5d8."
    },
    {
      "name": "Spellcasting",
      "desc": "The Paladin is a 3rd-level spellcaster. Their spellcasting ability is Charisma (spell save DC 13, +5 to hit with spell attacks). They have the following spells prepared: \n\n1st level (3 slots): Bless, Command, Wrathful Smite"
    }
  ],
  "actions": [
    {
      "name": "Longsword",
      "desc": "Melee Weapon Attack: +5 to hit, reach 5 ft., one target. Hit: 1d8+3 slashing damage or 1d10+3 if used with two hands.",
      "attack_bonus": 5,
      "damage_dice": "1d8",
      "damage_bonus": 3
    },
    {
      "name": "Commanding Strike",
      "desc": "The Paladin utters a command, forcing one creature of their choice within 30 feet that can hear them to make a DC 13 Wisdom saving throw or become frightened for 1 minute. The target can repeat the saving throw at the end of each of its turns, ending the effect on a success. (Recharge 5-6)"
    }
  ],
  "reactions": [],
  "legendary_actions": []
}

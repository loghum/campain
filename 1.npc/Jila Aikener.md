---
name: Jila Aikener
location: Thundercore
role: Shool student
building: "[[Ironheart’s Academy of Blades and Spells]]"
---

Name: Jila Aikener
Description: Young, Female, Human, Long hair, Tall, Stout build, They have a birthmark on their face
Voice: Medium pitch, Booming, Normal speed, Speaks in a sing-song voice
Mannerism: They are always getting into trouble
PlotHook: Is in a feud with their neighbor

{
  "name": "Archfey Warlock",
  "source": "Homebrew",
  "size": "Medium",
  "type": "Humanoid",
  "alignment": "Chaotic Neutral",
  "ac": 14,
  "hp": 22,
  "hit_dice": "3d8+3",
  "speed": "30 ft.",
  "stats": [8, 14, 12, 10, 10, 16],
  "saves": {
    "strength": -1,
    "dexterity": 2,
    "constitution": 3,
    "intelligence": 0,
    "wisdom": 0,
    "charisma": 5
  },
  "damage_vulnerabilities": "None",
  "damage_resistances": "None",
  "damage_immunities": "None",
  "condition_immunities": [],
  "senses": "Passive Perception 10",
  "languages": "Common, Elvish",
  "cr": "1",
  "proficiency_bonus": 2,
  "bestiary": true,
  "traits": [
    {
      "name": "Fey Presence",
      "desc": "As an action, the Warlock can cause each creature in a 10-foot cube originating from them to make a DC 13 Wisdom saving throw. On a failed save, the creature is either charmed or frightened (Warlock's choice) until the end of the Warlock's next turn. (1/Short Rest)"
    },
    {
      "name": "Spellcasting",
      "desc": "The Warlock is a 3rd-level spellcaster. Their spellcasting ability is Charisma (spell save DC 13, +5 to hit with spell attacks). They have the following spells prepared: \n\nCantrips: Eldritch Blast, Minor Illusion \n1st level (2 slots): Charm Person, Faerie Fire \n2nd level (2 slots): Misty Step, Hold Person"
    },
    {
      "name": "Eldritch Invocations",
      "desc": "The Warlock has the following Eldritch Invocations: \n\nAgonizing Blast: Add Charisma modifier to the damage of Eldritch Blast. \nEldritch Spear: Increase the range of Eldritch Blast to 300 feet."
    }
  ],
  "actions": [
    {
      "name": "Eldritch Blast",
      "desc": "Ranged Spell Attack: +5 to hit, range 300 ft., one target. Hit: 1d10+3 force damage.",
      "attack_bonus": 5,
      "damage_dice": "1d10",
      "damage_bonus": 3
    }
  ],
  "reactions": [],
  "legendary_actions": []
}

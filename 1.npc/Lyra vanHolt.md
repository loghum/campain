---
name: Lyra vanHolt
level: "5"
hp: "100"
ac: "20"
modifier: "4"
---

```statblock

monster: Lyria Vanholt
name: Lyria Vanholt
size: Medium
type: Humanoid
subtype: Human
alignment: Neutral
ac: 13 (16 with mage armor)
hp: 45
speed: 30 ft.
stats: [8, 14, 14, 18, 12, 14]
saves:
  - intelligence: +6
  - wisdom: +3
skillsaves:
  - arcana: +6
  - history: +6
  - investigation: +6
  - persuasion: +4
damage_vulnerabilities: None
damage_resistances: Psychic (via Mind Ward trait)
damage_immunities: None
condition_immunities: None
senses: Passive Perception 11
languages: Common, Elvish, Draconic, Infernal
cr: 0
spells:
  - cantrips [[Mage Hand]], [[Minor Illusion]], [[Prestidigitation]], [[Ray of Frost]]
  - 1st level (4 slots) [[Mage Armor]], [[Shield]], [[Magic Missile]]
  - 2nd level (3 slots) [[Mirror Image]], [[Misty Step]]
  - 3rd level (2 slots) [[Counterspell]], [[Fireball]]
traits:
  - name: Arcane Scholar
    desc: Lyria has advantage on Intelligence (Arcana) and Intelligence (History) checks related to ancient artifacts, magical glyphs, and curses.
  - name: Mind Ward (1/Day)
    desc: When Lyria takes psychic damage, she can reduce the damage by 10.
  - name: Tactical Mind
    desc: Lyria can use the Help action as a bonus action to assist an ally within 30 feet in making an attack roll or ability check.
actions:
  - name: Dagger
    desc: Melee or Ranged Weapon Attack +4 to hit, range 20/60. 1d6+2
  - name: Spellcasting
    desc: Lyria is a 5th-level spellcaster. Her spellcasting ability is Intelligence (spell save DC 14, +6 to hit with spell attacks).
bonus_actions:
  - name: Tactical Mind
    desc: Lyria can use the Help action as a bonus action to assist an ally within 30 feet.
reactions:
  - name: Counterspell
    desc: When a creature casts a spell that Lyria can see within 60 feet, she can use her reaction to attempt to interrupt it.
  - name: Shield (1st-level spell)
    desc: When she is hit by an attack, Lyria can use her reaction to increase her AC by 5 until the start of her next turn.
legendary_actions:
  - name: None
    desc: None
```

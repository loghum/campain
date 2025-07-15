```statblock
monster: Arcane Adept
name: Arcane Adept
size: Medium
type: Humanoid
subtype: Any (e.g., Human or Elf)
alignment: Neutral Evil
ac: 15 (Mage Armor)
hp: 45 (6d8 + 18)
speed: 30 ft.
stats: [10, 14, 12, 16, 12, 14]
saves:
  - intelligence: +6
  - wisdom: +3
skillsaves:
  - arcana: +6
  - deception: +4
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: Passive Perception 11
languages: Common, plus one other
cr: 4
proficiency_bonus: +2
spells:
  - cantrips: [[Fire Bolt]], [[Mage Hand]], [[Minor Illusion]]
  - 1st level (4 slots): [[Mage Armor]], [[Shield]], [[Magic Missile]], [[Disguise Self]]
  - 2nd level (3 slots): [[Mirror Image]], [[Misty Step]], [[Hold Person]]
  - 3rd level (2 slots): [[Counterspell]], [[Fireball]]
traits:
  - name: Spellcasting
    desc: "The Arcane Adept is a 6th-level spellcaster. Intelligence is their spellcasting ability (spell save DC 14, +6 to hit with spell attacks). They have the following spells prepared: [spells as above]."
actions:
  - name: Quarterstaff
    desc: "+4 to hit, reach 5 ft., one target. Hit: 5 (1d6 + 2) bludgeoning damage."
bonus_actions:
  - name: Misty Step
    desc: "Teleport up to 30 feet to an unoccupied space that you can see."
reactions:
  - name: Shield
    desc: "Cast Shield in response to being hit by an attack or targeted by Magic Missile."

```
```statblock
monster: Vaelis
name: Vaelis
size: Medium
type: Humanoid
subtype: Warlock
alignment: Lawful Evil
ac: 16 
hp: 95
speed: 30 ft.
stats: [10, 14, 18, 14, 12, 18]
saves:
  - wis: +5
  - cha: +7
  - con: +7
skillsaves:
  - arcana: +6
  - deception: +7
  - religion: +6
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 11
languages: None
cr: 7
proficiency_bonus: +3
spells:
  - cantrips (at will): [[Eldritch Blast]] 1d10, [[Minor Illusion]]
  - 1/day spells:
  - 3/day: [[Darkness]], [[Counterspell]], [[Fear]]
  - 2/day: [[Blight]], [[Hunger of Hadar]]
  - 1/day: [[Shadow of Moil]]
traits:
  - name: Spellcasting
    desc: "Vaelis is a high-level warlock. Its spellcasting ability is Charisma (spell save DC 15, +7 to hit with spell attacks)."
  - name: Dark Bargain
    desc: "When Vaelis is reduced to 0 hit points, he instead drops to 1 hit point. He can use this trait once per long rest."
  - name: Arcane of the Veil
    desc: "Vaelis can maintain concentration on one additional spell beyond normal limits only if one is a warlock spell he cast."
actions:
  - name: Eldritch Blast
    desc: "Ranged Spell Attack: +7 to hit, range 120 ft., one or two targets. Hit: 9 (1d10 + 4) force damage per beam."
  - name: Life Leech Dagger
    desc: "Melee Weapon Attack: +6 to hit, reach 5 ft., one target. Hit: 6 (1d4 + 4) piercing damage plus 7 (2d6) necrotic damage."
bonus_actions:
  - name: Shadow Step
    desc: "Vaelis teleports up to 30 ft. to an unoccupied space he can see that is in dim light or darkness."
reactions:
  - name: Fade Into Shadow
    desc: "When Vaelis is hit by an attack, he can impose disadvantage on the attack roll and teleport up to 15 ft. to an unoccupied space he can see in dim light or darkness."
legendary_actions: []

```
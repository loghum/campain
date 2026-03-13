```statblock
monster: Skeleton Necromancer
name: Skeleton Necromancer
size: Medium
type: Undead
subtype: Skeleton
alignment: Lawful Evil
ac: 14
hp: 75
speed: 30 ft.
stats: [8, 14, 16, 16, 14, 10]
saves:
  - wis: +5
  - con: +6
skillsaves: []
damage_vulnerabilities: Bludgeoning
damage_resistances: None
damage_immunities: Poison
condition_immunities: Poisoned, Exhaustion
senses: darkvision 60 ft., passive Perception 12
languages: Common, Abyssal
cr: 3
proficiency_bonus: +2
spells:
  - cantrips (at will): [[Chill Touch]] 2d8, [[Toll the Dead]] 2d12, [[Mage Hand]]
  - 1st level (4 slots): [[False Life]], [[Ray of Sickness]], [[Shield]]
  - 2nd level (3 slots): [[Blindness/Deafness]], [[Web]]
  - 3rd level (2 slots): [[Lightning Bolt]] 8d6, [[Vampiric Touch]]
traits:
  - name: Undead Fortitude
    desc: "If damage reduces the skeleton to 0 hit points, it must make a Constitution saving throw with a DC of 5 + the damage taken, unless the damage is radiant or from a critical hit. On a success, the skeleton drops to 1 hit point instead."
  - name: Spellcasting
    desc: "The skeleton is a 5th-level spellcaster. Its spellcasting ability is Intelligence (spell save DC 14, +6 to hit with spell attacks). It requires no material components."
  - name: Grave Sustenance
    desc: "When a creature within 30 feet of the skeleton drops to 0 hit points, the skeleton regains 10 hit points."
actions:
  - name: Necrotic Ray
    desc: "Ranged Spell Attack: +6 to hit, range 60 ft., one target. Hit: 14 (4d6) necrotic damage."
bonus_actions:
  - name: Reassemble Skeleton (Recharge 5–6)
    desc: "The necromancer targets one destroyed skeleton it can see within 30 feet. The skeleton reforms with 20 hit points and acts on the necromancer’s next initiative count. This ability fails if the skeleton was destroyed by radiant damage or a critical hit. The necromancer can have no more than two reassembled skeletons at one time. `encounter: Skeleton Reassembled `"


```
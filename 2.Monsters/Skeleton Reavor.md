```statblock
monster: Skeleton Reaver
name: Skeleton Reaver
size: Medium
type: Undead
subtype: Skeleton
alignment: Lawful Evil
ac: 16
hp: 68
speed: 30 ft.
stats: [16, 14, 18, 8, 10, 6]
saves:
  - con: +7
skillsaves: []
damage_vulnerabilities: Bludgeoning
damage_resistances: None
damage_immunities: Poison
condition_immunities: Poisoned, Exhaustion
senses: darkvision 60 ft., passive Perception 10
languages: Common
cr: 2
proficiency_bonus: +2
traits:
  - name: Improved Undead Fortitude
    desc: "If damage reduces the skeleton to 0 hit points, it makes a Constitution saving throw (DC 5 + damage taken). On a success, it drops to 1 hit point instead. Radiant damage or a critical hit bypasses this trait."
  - name: Relentless Bones
    desc: "Once per turn, when the skeleton hits with a melee weapon attack, it deals an extra 4 (1d8) necrotic damage."
actions:
  - name: Multiattack
    desc: "The skeleton makes two melee attacks."
  - name: Bone Greatsword
    desc: "Melee Weapon Attack: +6 to hit, reach 5 ft., one target. Hit: 10 (2d6 + 3) slashing damage plus 4 (1d8) necrotic damage."
  - name: Cleave Through Flesh (Recharge 5–6)
    desc: "The skeleton makes one Bone Greatsword attack against each creature of its choice within 5 feet."
reactions:
  - name: Grasping Bones
    desc: "When a creature the skeleton can see moves out of its reach, the skeleton makes one Bone Greatsword attack against that creature. On a hit, the creature’s speed becomes 0 until the end of the current turn. This movement interruption works even if the creature takes the Disengage action."


```
```statblock
monster: Skeleton Marksman
name: Skeleton Marksman
size: Medium
type: Undead
subtype: Skeleton
alignment: Lawful Evil
ac: 15
hp: 55
speed: 30 ft.
stats: [10, 18, 12, 8, 14, 6]
saves: []
skillsaves: []
damage_vulnerabilities: Bludgeoning
damage_resistances: None
damage_immunities: Poison
condition_immunities: Poisoned, Exhaustion
senses: darkvision 60 ft., passive Perception 12
languages: Common
cr: 2
proficiency_bonus: +2
traits:
  - name: Undead Fortitude
    desc: "If damage reduces the skeleton to 0 hit points, it must make a Constitution saving throw with a DC of 5 + the damage taken, unless the damage is radiant or from a critical hit. On a success, the skeleton drops to 1 hit point instead."
  - name: Deadeye Frame
    desc: "Attacking at long range doesn’t impose disadvantage on the skeleton’s ranged weapon attacks."
  - name: Bone Sniper
    desc: "Once per turn, the skeleton deals an extra 7 (2d6) damage when it hits with a ranged weapon attack."
actions:
  - name: Multiattack
    desc: "The skeleton makes two ranged weapon attacks."
  - name: Heavy Bone Longbow
    desc: "Ranged Weapon Attack: +7 to hit, range 150/600 ft., one target. Hit: 9 (1d8 + 4) piercing damage."
  - name: Pinning Shot (Recharge 5–6)
    desc: "Ranged Weapon Attack: +7 to hit. On a hit, the target takes normal damage and must succeed on a DC 14 Strength saving throw or have its speed reduced to 0 until the end of its next turn."


```
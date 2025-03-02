```statblock
monster: Skeletal Knight
name: Skeletal Knight
size: Medium
type: Undead
subtype: None
alignment: Lawful Evil
ac: 17 (plate)
hp: 60
speed: 30 ft.
stats: [20, 10, 16, 13, 14, 10]
saves:
  - constitution: +6
  - wisdom: +5
skillsaves: None
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: Poison
condition_immunities: Exhaustion, Poisoned
senses: Darkvision 60 ft., passive Perception 12
languages: Understands the languages it knew in life but can't speak
cr: 7
spells: None
traits:
  - name: Undead Fortitude
    desc: "If damage reduces the skeletal knight to 0 hit points, it must make a Constitution saving throw with a DC of 5 + the damage taken, unless the damage is bludgeoning or from a critical hit. On a success, the skeletal knight drops to 1 hit point instead."
  - name: Unusual Nature
    desc: "The skeletal knight doesn't require air, food, drink, or sleep."
actions:
  - name: Multiattack
    desc: "The skeletal knight makes two Enervating Blade or Throwing Axe attacks in any combination."
  - name: Enervating Blade
    desc: "Melee Weapon Attack: +8 to hit, reach 5 ft., one target. Hit: 15 (2d6 + 5) necrotic damage, and if the target is a creature, it can't regain hit points until the start of the skeletal knight's next turn."
  - name: Throwing Axe
    desc: "Melee or Ranged Weapon Attack: +8 to hit, reach 5 ft. or range 20/60 ft., one target. Hit: 14 (2d8 + 5) slashing damage."
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


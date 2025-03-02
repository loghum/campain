```statblock
monster: Fire Spider Queen
name: Fire Spider Queen
size: Large
type: Beast
subtype: None
alignment: Unaligned
ac: 14 (natural armor)
hp: 44
speed: 30 ft., Climb 30 ft.
stats: [14, 16, 12, 2, 11, 4]
saves: None
skillsaves:
  - stealth: +7
damage_vulnerabilities: None
damage_resistances: Fire
damage_immunities: None
condition_immunities: None
senses: Blindsight 10 ft., Darkvision 60 ft., passive Perception 10
languages: None
cr: 2
spells: None
traits:
  - name: Burning Aura
    desc: "Any creature that starts its turn within 5 feet of the spider takes 5 (2d4) fire damage."
  - name: Spider Climb
    desc: "The spider can climb difficult surfaces, including upside down on ceilings, without needing to make an ability check."
  - name: Web Sense
    desc: "While in contact with a web, the spider knows the exact location of any other creature in contact with the same web."
  - name: Web Walker
    desc: "The spider ignores movement restrictions caused by webbing."
actions:
  - name: Bite
    desc: "Melee Weapon Attack: +5 to hit, reach 5 ft., one creature. Hit: 7 (1d8 + 3) piercing damage, and the target must make a DC 11 Constitution saving throw, taking 9 (2d8) poison damage on a failed save, or half as much damage on a successful one. If the poison damage reduces the target to 0 hit points, the target is stable but poisoned for 1 hour, even after regaining hit points, and is paralyzed while poisoned in this way."
  - name: Fiery Web
    desc: "Ranged Weapon Attack (Recharge 5–6): +5 to hit, range 30/60 ft., one creature. Hit: The target is restrained by webbing and takes 2 (1d4) fire damage at the start of each of its turns. As an action, the restrained target can make a DC 12 Strength check, bursting the webbing on a success. The webbing can also be attacked and destroyed (AC 10; hp 5; vulnerability to cold damage; immunity to fire, poison, and psychic damage)."
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
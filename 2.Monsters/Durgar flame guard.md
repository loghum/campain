```statblock
monster: Durgar Flameguard
name: Durgar Flameguard
size: Medium
type: Undead
subtype: Dwarf
alignment: Lawful Neutral
ac: 18 (charred dwarven plate)
hp: 120
speed: 25 ft.
stats: [19, 10, 18, 9, 12, 11]  # STR, DEX, CON, INT, WIS, CHA
saves:
  - constitution: +7
  - wisdom: +4
skillsaves:
  - athletics: +7
  - perception: +4
damage_vulnerabilities: None
damage_resistances: fire, necrotic, bludgeoning/piercing/slashing from nonmagical attacks
damage_immunities: poison
condition_immunities: poisoned, exhaustion, charmed
senses: darkvision 60 ft., passive Perception 14
languages: Dwarvish, Ignan
cr: 6
proficiency_bonus: +3
spells: []
traits:
  - name: Endless Duel
    desc: "When reduced to 0 hit points, the Dûrgar can make a DC 15 Constitution saving throw. On a success, it instead drops to 10 hit points and regains its turn. This feature recharges after a long rest."
  - name: Fire-Forged Flesh
    desc: "The Dûrgar has resistance to fire and necrotic damage. Its body radiates heat; any creature that grapples it or hits it with a melee attack while within 5 feet takes 3 (1d6) fire damage."
actions:
  - name: Multiattack
    desc: "Dûrgar makes two Flamebound Greataxe attacks."
  - name: Flamebound Greataxe
    desc: "+7 to hit, reach 5 ft., one target. Hit: 12 (1d12 + 6) slashing damage plus 7 (2d6) fire damage. On a critical hit, the target must succeed on a DC 14 Constitution saving throw or ignite, taking 5 (1d10) fire damage at the end of each of its turns until it or another creature uses an action to extinguish the flames."
  - name: Fire Echo (Recharge 5–6)
    desc: "The Dûrgar slams his axe into the ground, releasing a fiery shockwave in a 10-foot radius. Each creature other than the Dûrgar must make a DC 14 Dexterity saving throw, taking 18 (4d8) fire damage on a failed save, or half as much on a success. Creatures that fail are also knocked prone."
bonus_actions: []
reactions: []
legendary_actions: []

```
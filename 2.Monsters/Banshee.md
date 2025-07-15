```statblock
monster: Banshee
name: Banshee
size: Medium
type: Undead
subtype: —
alignment: Chaotic Evil
ac: 12 (natural armor)
hp: 58
speed: 0 ft., fly 40 ft. (hover)
stats: [6, 14, 10, 12, 11, 17] # STR, DEX, CON, INT, WIS, CHA
saves:
  - wisdom: +2
  - charisma: +5
skillsaves:
  - perception: +0
damage_vulnerabilities: —
damage_resistances: acid, fire, lightning, thunder; bludgeoning, piercing, and slashing from nonmagical weapons
damage_immunities: cold, necrotic, poison
condition_immunities: charmed, exhaustion, frightened, grappled, paralyzed, petrified, poisoned, prone, restrained
senses: darkvision 60 ft., passive Perception 10
languages: Common, Elvish
cr: 4
proficiency_bonus: +2
traits:
  - name: Detect Life
    desc: "The banshee can magically sense the presence of creatures up to 5 miles away that aren’t undead or constructs."
  - name: Incorporeal Movement
    desc: "The banshee can move through other creatures and objects as if they were difficult terrain. It takes 5 (1d10) force damage if it ends its turn inside an object."
actions:
  - name: Corrupting Touch (Melee Spell Attack)
    desc: "+4 to hit, reach 5 ft., one target. Hit: 12 (3d6 + 2) necrotic damage."
  - name: Horrifying Visage
    desc: "Each non-undead creature within 60 ft. that can see the banshee must succeed on a DC 13 Wisdom saving throw or be frightened for 1 minute. A frightened target can repeat the save at the end of each of its turns, with disadvantage if the banshee is in line of sight. On a success or the effect ending, the target is immune to this feature for the next 24 hours."
  - name: Wail (1/Day)
    desc: "The banshee releases a mournful wail, provided it isn’t in sunlight. All other creatures within 30 ft. that can hear it must make a DC 13 Constitution save. On a failure, a creature drops to 0 hit points. On a success, it takes 10 (3d6) psychic damage."
bonus_actions: []
reactions: []
legendary_actions: []

```
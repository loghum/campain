```statblock
monster: Meazel
name: Meazel
size: Medium
type: Humanoid
subtype: Meazel
alignment: Neutral Evil
ac: 13 (natural armor)
hp: 35
speed: 30 ft.
stats: [8, 17, 9, 14, 13, 10] # STR, DEX, CON, INT, WIS, CHA
saves: []
skillsaves:
  - perception: +3
  - stealth: +5
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: Darkvision 120 ft., passive Perception 13
languages: Common
cr: 1
proficiency_bonus: +2
traits:
  - name: Shadow Stealth
    desc: "While in dim light or darkness, the meazel can take the Hide action as a bonus action."
actions:
  - name: Garrote (Melee Weapon Attack)
    desc: "+5 to hit, reach 5 ft., one target. Hit: 6 (1d6 + 3) bludgeoning damage, and the target is grappled (escape DC 13). Until the grapple ends, the target takes 10 (2d6 + 3) bludgeoning damage at the start of each of the meazel’s turns. The meazel can’t make weapon attacks while grappling in this way."
  - name: Shortsword (Melee Weapon Attack)
    desc: "+5 to hit, reach 5 ft., one target. Hit: 6 (1d6 + 3) piercing damage plus 3 (1d6) necrotic damage."
  - name: Shadow Teleport (Recharge 5–6)
    desc: "The meazel and any creature it is grappling teleport to an unoccupied space within 500 ft. that the meazel has seen before, provided both origin and destination are in dim light or darkness. Any creature teleported this way is cursed by shadow for 1 hour: undead and creatures native to the Shadowfell within 300 ft. can sense the cursed target, preventing it from hiding from them."
bonus_actions: []
reactions: []
legendary_actions: []

```
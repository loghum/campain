```statblock
monster: Ancient Swamp Hag Spirit
name: Ancient Swamp Hag Spirit
size: Medium
type: Fey
subtype: Undead
alignment: Chaotic Neutral
ac: 14 (natural armor)
hp: 84
speed: 30 ft., swim 20 ft.
stats:
  - 14
  - 12
  - 14
  - 12
  - 16
  - 16
saves:
  - constitution: 5
  - wisdom: 6
  - charisma: 6
skillsaves:
  - stealth: 4
  - perception: 6
damage_vulnerabilities: []
damage_resistances: bludgeoning, piercing, and slashing from nonmagical attacks
damage_immunities: poison
condition_immunities: poisoned, charmed
senses: darkvision 60 ft., passive Perception 16
languages: Common, Sylvan
cr: 5
proficiency_bonus: 3
traits:
  - name: Swamp Step
    desc: The hag can move through swampy terrain without penalty and leave a 10-ft radius of difficult terrain until the start of her next turn.
actions:
  - name: Engulfing Vines (Recharge 4–6)  
    desc: "The swamp itself rises at the hag’s command, lashing out with roots and thorned vines. Each creature in a 15-foot-radius centered on a point within 30 ft. must make a DC 16 Dexterity saving throw.\n\nFailed save: 13 (2d8 + 4) bludgeoning damage and restrained.\n\nSuccessful save: Half damage, not restrained.\n\nRestrained creatures can use an action to make a DC 14 Strength (Athletics) or Dexterity (Acrobatics) check to free themselves. At the start of the hag’s turn, restrained creatures take 7 (2d6) poison damage."
  - name: Curse of the Mire (Recharge 5–6)
    desc: "The hag targets up to 2 creatures within 30 ft. Each must make a DC 16 Constitution save or be poisoned for 1 minute. Poisoned targets take 5 (1d10) poison damage at the start of their turn. They can repeat the save at the end of each of their turns."
  - name: 2x Poisoned Tendrils
    desc: "Melee Weapon Attack: +7 to hit, reach 10 ft., one target. Hit: 10 (2d6 + 3) bludgeoning plus 5 (1d10) poison damage."
bonus_actions:
  - name: Summon Swamp Minions
    desc: "The hag summons 1–2 Small swamp minions (poisonous plants or swamp oozes) in unoccupied spaces within 30 ft. `encounter: 1:Poisonous Swamp Plant`"
reactions: []
legendary_actions: []
source: Homebrew
layout: Basic 5e Layout
lair_actions: []
regional_effects: []


```
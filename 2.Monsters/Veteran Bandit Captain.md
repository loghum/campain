```statblock
monster: Veteran Bandit Captain
name: Veteran Bandit Captain
size: Medium
type: Humanoid
subtype: Human
alignment: Chaotic Evil
ac: 17 (studded leather, shield)
hp: 84
speed: 30 ft.
stats: [16, 14, 14, 12, 13, 12]  # STR, DEX, CON, INT, WIS, CHA
saves:
  - dexterity: +4
  - constitution: +4
skillsaves:
  - athletics: +5
  - intimidation: +4
  - perception: +3
  - stealth: +4
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 13
languages: Common
cr: 4
proficiency_bonus: +2
spells: []
traits:
  - name: Pack Tactics
    desc: "The bandit captain has advantage on attack rolls against a creature if at least one of the captain's allies is within 5 feet of the creature and the ally isn't incapacitated."
  - name: Leadership (Recharges after a Short or Long Rest)
    desc: "For 1 minute, the bandit captain can utter a special command or warning. When a creature that can hear the captain within 30 feet makes an attack roll or saving throw, the creature can add a d4 to its roll."
actions:
  - name: Multiattack
    desc: "The bandit captain makes three attacks: two with its scimitar and one with its dagger."
  - name: Scimitar
    desc: "+6 to hit, reach 5 ft., one target. Hit: 8 (1d6 + 5) slashing damage."
  - name: Dagger
    desc: "+6 to hit, reach 5 ft. or range 20/60 ft., one target. Hit: 7 (1d4 + 5) piercing damage."
bonus_actions:
  - name: Parry
    desc: "The bandit captain adds +2 to its AC against one melee attack that would hit it."
reactions: []
legendary_actions: []


```
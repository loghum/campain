```statblock
monster: Hobgoblin Devastator
name: Hobgoblin Devastator
size: Medium
type: Humanoid
subtype: Goblinoid
alignment: Lawful Evil
ac: 13 (Studded Leather)
hp: 45
speed: 30 ft.
stats: [13, 12, 14, 16, 13, 11] # STR, DEX, CON, INT, WIS, CHA
saves: []
skillsaves:
  - arcana: +5
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: Darkvision 60 ft., passive Perception 11
languages: Common, Goblin
cr: 4
proficiency_bonus: +2
traits:
  - name: Arcane Advantage
    desc: "Once per turn, the hobgoblin can deal an extra 7 (2d6) damage to a creature it hits with a damaging spell attack if that target is within 5 feet of an ally who isn’t incapacitated."
  - name: Army Arcane
    desc: "When the hobgoblin casts a damaging or saving‑throw spell, it can choose itself and any number of allies to be immune to the spell's damage and automatically succeed on its saving throw."
spells:
  - cantrips:
      - [[Acid Splash]]
      - [[Fire Bolt]]
      - [[Ray of Frost]]
      - [[Shocking Grasp]]
  - level_1 (4 slots):
      - [[Fog Cloud]]
      - [[Magic Missile]]
      - [[Thunderwave]]
  - level_2 (3 slots):
      - [[Gust of Wind]]
      - [[Melf’s Acid Arrow]]
      - [[Scorching Ray]]
  - level_3 (3 slots):
      - [[Fireball]]
      - [[Fly]]
      - [[Lightning Bolt]]
  - level_4 (1 slot):
      - [[Ice Storm]]
actions:
  - name: Multiattack
    desc: "The hobgoblin makes two attacks: one with its quarterstaff and one with its devastating spell attack."
  - name: Quarterstaff
    desc: "+3 to hit, reach 5 ft., one target. Hit: 4 (1d6 + 1) bludgeoning damage, or 5 (1d8 + 1) if used with two hands."
  - name: Spellcasting
    desc: "Spell save DC 13, +5 to hit with spell attacks. See spell list above."
bonus_actions: []
reactions: []
legendary_actions: []

```
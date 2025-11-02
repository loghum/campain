```statblock
monster: Cambion
name: Cambion
size: Medium
type: Fiend
subtype: None
alignment: Any Evil Alignment
ac: 19
hp: 82 
speed: 30 ft., fly 60 ft.
stats: [18, 18, 16, 14, 12, 16]
saves:
  - str: +7
  - con: +6
  - int: +5
  - cha: +6
skillsaves:
  - deception: +6
  - intimidation: +6
  - perception: +4
  - stealth: +7
damage_vulnerabilities: None
damage_resistances: Cold, Fire, Lightning, Poison; Bludgeoning, Piercing, and Slashing from nonmagical attacks
damage_immunities: None
condition_immunities: None
senses: Darkvision 60 ft., passive Perception 14
languages: Abyssal, Common, Infernal
cr: 5
proficiency_bonus: +3
spells:
  - innate spellcasting (Charisma, save DC 14):
    - 3/day each: [[Alter Self]], [[Command]], [[Detect Magic]]
    - 1/day: [[Plane Shift]] (self only)
traits:
  - name: Fiendish Blessing
    desc: "The cambion's AC includes its Charisma bonus."
actions:
  - name: Multiattack
    desc: "The cambion makes two melee attacks or uses its Fire Ray twice."
  - name: Spear
    desc: "Melee or Ranged Weapon Attack: +7 to hit, reach 5 ft. or range 20/60 ft., one target. Hit: 7 (1d6 + 4) piercing damage, or 8 (1d8 + 4) piercing damage if used with two hands to make a melee attack, plus 3 (1d6) fire damage."
  - name: Fire Ray
    desc: "Ranged Spell Attack: +7 to hit, range 120 ft., one target. Hit: 10 (3d6) fire damage."
  - name: Fiendish Charm
    desc: "One humanoid the cambion can see within 30 feet must succeed on a DC 14 Wisdom saving throw or be magically charmed for 1 day. The charmed target obeys the cambion's spoken commands. If the target suffers any harm or receives a suicidal command, it can repeat the saving throw, ending the effect on a success. If the saving throw succeeds or the effect ends, the creature is immune to this ability for 24 hours."
bonus_actions: []
reactions: []
legendary_actions: []
```
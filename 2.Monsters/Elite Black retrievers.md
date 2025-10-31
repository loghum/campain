```statblock
monster: Elite Black retrievers
name: Elite Black retrievers
size: Medium
type: Humanoid
subtype: Human
alignment: Lawful Neutral
ac: 19
hp: 180 
speed: 30 ft.
stats: [16, 18, 20, 14, 16, 18]
saves:
  - dex: +9
  - con: +10
  - wis: +8
  - cha: +9
skillsaves:
  - intimidation: +9
  - stealth: +9
  - perception: +8
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 18
languages: Common, Elvish
cr: 10
proficiency_bonus: +4
spells:
  - cantrips (at will): [[Fire Bolt]] 3d10, [[Minor Illusion]], [[Prestidigitation]]
  - 1st level (4 slots): [[Command]], [[Shield]], [[Magic Missile]], [[Detect Magic]]
  - 2nd level (3 slots): [[Hold Person]], [[Mirror Image]], [[Misty Step]]
  - 3rd level (3 slots): [[Counterspell]], [[Dispel Magic]], [[Fear]]
  - 4th level (3 slots): [[Greater Invisibility]], [[Phantasmal Killer]]
  - 5th level (2 slots): [[Dominate Person]], [[Wall of Force]]
traits:
  - name: Spellcasting
    desc: "The zwarte buiter is a 10th-level spellcaster. Its spellcasting ability is Charisma (spell save DC 19, +11 to hit with spell attacks)."
  - name: Tactical Discipline
    desc: "The zwarte buiter has advantage on saving throws against being frightened or charmed, and can communicate silently with another zwarte buiter within 60 ft. as a bonus action."
  - name: Unyielding Grip
    desc: "When the zwarte buiter grapples a creature, that creature has disadvantage on checks and saving throws made to escape the grapple."
actions:
  - name: Multiattack
    desc: "The zwarte buiter makes two shortsword attacks, or one shortsword attack and casts a spell."
  - name: Shortsword
    desc: "+9 to hit, reach 5 ft., one target. Hit: 10 (1d6 + 7) piercing damage."
  - name: Command
    desc: "The zwarte buiter targets one creature within 60 ft. The target must succeed on a DC 17 Wisdom saving throw or follow a one-word command on its next turn."
  - name: Hold Person
    desc: "The zwarte buiter targets one humanoid it can see within 60 ft. The target must succeed on a DC 17 Wisdom saving throw or be paralyzed for up to 1 minute. The target can repeat the save at the end of each of its turns."
  - name: Fear
    desc: "Each creature in a 30-foot cone must succeed on a DC 17 Wisdom saving throw or be frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success."
bonus_actions:
  - name: Coordinated Step
    desc: "If another zwarte buiter is within 30 ft., both can move up to 10 ft. without provoking opportunity attacks."
reactions:
  - name: Parry
    desc: "The zwarte buiter adds +4 to its AC against one melee attack that would hit it."
  - name: Uncanny Dodge
    desc: "The zwarte buiter halves the damage it takes from an attack it can see."
legendary_actions:
  - name: Cast a Cantrip
    desc: "The zwarte buiter casts a cantrip."
  - name: Shadow Step (Costs 2 Actions)
    desc: "The zwarte buiter magically teleports up to 30 ft. to an unoccupied space it can see."
  - name: Command Ally (Costs 2 Actions)
    desc: "The zwarte buiter orders an allied creature within 30 ft. to make one weapon attack as a reaction."


```
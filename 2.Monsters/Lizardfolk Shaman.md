```statblock
monster: Lizardfolk Shaman
name: Lizardfolk Shaman
size: Medium
type: Humanoid
subtype: Lizardfolk
alignment: Neutral
ac: 14
hp: 71
speed: 30 ft., swim 30 ft.
stats: [11, 12, 14, 10, 17, 10]
saves: []
skillsaves:
  - medicine: +5
  - nature: +3
  - perception: +5
  - survival: +5
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 15
languages: Draconic
cr: 4
proficiency_bonus: +2
spells:
  - cantrips [[Guidance]], [[Thorn Whip]], [[Sacred Flame]]
  - 1st level (4 slots) [[Cure Wounds]], [[Entangle]], [[Fog Cloud]], [[Command]]
  - 2nd level (3 slots) [[Flame Blade]], [[Hold Person]], [[Lesser Restoration]]
  - 3rd level (3 slots) [[Call Lightning]], [[Dispel Magic]], [[Bestow Curse]]
traits:
  - name: Hold Breath
    desc: "The lizardfolk can hold its breath for up to 15 minutes."
  - name: Spellcasting
    desc: "The lizardfolk is a 7th-level spellcaster. Its spellcasting ability is Wisdom (spell save DC 13, +5 to hit with spell attacks)."
  - name: Pack Tactics
    desc: "The lizardfolk has advantage on an attack roll against a creature if at least one of its allies is within 5 feet of the creature."
actions:
  - name: Quarterstaff
    desc: "+3 to hit, reach 5 ft., one target. Hit: 5 (1d8 + 1) bludgeoning damage."
  - name: Bite
    desc: "+3 to hit, reach 5 ft., one target. Hit: 6 (1d8 + 2) piercing damage."
bonus_actions:
  - name: Channel the Wild (1/Short Rest)
    desc: "The shaman casts Entangle or Fog Cloud without expending a spell slot."
reactions: []
legendary_actions: []


```
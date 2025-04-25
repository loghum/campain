```statblock
monster: Shadow Druid  
name: Shadow Druid  
size: Medium  
type: Humanoid  
subtype: Human  
alignment: Neutral Evil  
ac: 13 (Hide Armor)  
hp: 45  
speed: 30 ft.  
stats: [10, 12, 14, 11, 16, 13]  
saves:  
  - wisdom: +5  
  - constitution: +4  
skillsaves:  
  - nature: +4  
  - stealth: +4  
  - perception: +5  
damage_vulnerabilities: Radiant  
damage_resistances: Necrotic  
damage_immunities: None  
condition_immunities: None  
senses: Darkvision 60 ft., passive Perception 15  
languages: Common, Druidic, Sylvan  
cr: 2  
proficiency_bonus: +2  
spells:  
  - cantrips [[Druidcraft]], [[Chill Touch]], [[Thorn Whip]]  
  - 1st level (4 slots) [[Entangle]], [[Cure Wounds]]  
  - 2nd level (2 slots) [[Hold Person]], [[Darkness]]  
traits:  
  - name: Druidic Corruption  
    desc: "The Shadow Druid's spells deal necrotic damage instead of their normal type, when applicable."  
actions:  
  - name: Corrupted Staff  
    desc: "+4 to hit, reach 5 ft., one target. Hit: 6 (1d8 + 2) bludgeoning damage plus 4 (1d8) necrotic damage."  
bonus_actions:  
  - name: Shadowmeld (1/day)  
    desc: "The druid becomes heavily obscured in dim light or darkness until the start of their next turn."  
```
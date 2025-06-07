---
name: Steps-on-Clouds
location: Thundercore
role: Shool student
building: "[[Ironheart’s Academy of Blades and Spells]]"
level: "4"
hp: "34"
ac: "18"
modifier: "10"
---
```statblock
monster: Steps-on-Clouds
name: Steps-on-Clouds + 1d8
size: Medium
type: Humanoid
subtype: None
alignment: Neutral
ac: 18
hp: 34
speed: 50 ft.
stats: [10, 20, 14, 9, 16, 11]
saves:
  - strength: +2
  - dexterity: +7
  - constitution: +2
  - intelligence: -1
  - wisdom: +4
  - charisma: +0
skillsaves:
  - None
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: Passive Perception 12
languages: Common, Elvish
cr: 1
spells:
  - 1st level (1/day): 
      - [[Gift of Alacrity]]
  - 2st level (1/day): 
      - [[Misty Step]]
traits:
  - name: Ki save
    desc: "8 + prof + wisdom: 13"
  - name: Martial Arts
    desc: "Use Dexterity instead of Strength for unarmed strikes and monk weapons. Unarmed strikes deal 1d4 damage. Can make an unarmed strike as a bonus action after using the Attack action with an unarmed or monk weapon."
  - name: Ki (4 points)
    desc: "Spend ki to use Flurry of Blows, Patient Defense, or Step of the Wind. Regains all ki on a short or long rest."
  - name: Unarmored Movement
    desc: "+10 ft. movement when not wearing armor or using a shield."
  - name: Deflect Missiles
    desc: "Use reaction to reduce damage from a ranged weapon attack by 1d10 + 7. Can catch and throw it if reduced to 0."
  - name: Slow Fall
    desc: "Reduce falling damage by 20 as a reaction."
  - name: Open Hand Technique
    desc: "When you hit a creature with Flurry of Blows, you can knock it prone, push it 15 ft., or prevent it from taking reactions (DC 13)."
  - name: Mobile (Feat)
    desc: "+10 ft. speed, no difficult terrain when dashing, and no opportunity attacks from targets you’ve attacked (hit or miss)."
  - name: Fey Touched (Feat)
    desc: "+1 Wisdom, learn Misty Step and Gift of Alacrity. Misty Step can be cast once per long rest without a spell slot."
  - name: Feline Agility
    desc: Your reflexes and agility allow you to move with a burst of speed. When you move on your turn in combat, you can double your speed until the end of the turn. Once you use this trait, you can’t use it again until you move 0 feet on one of your turns."
actions:
  - name: Unarmed Strike
    desc: "Melee Weapon Attack: +7 to hit, reach 5 ft., one target. Hit: 1d6+5 slashing."
  - name: Dart
    desc: "Ranged Weapon Attack: +7 to hit, range 20/60 ft., one target. Hit: 1d4+5 piercing damage."
legendary_actions:
  - name: None
    desc: None
bonus_actions:
  - name: Martial Arts
    desc: "After making an attack with a monk weapon or unarmed strike, make one unarmed strike."
  - name: Flurry of Blows (1 ki)
    desc: "Make two unarmed strikes after taking the Attack action."
  - name: Step of the Wind (1 ki)
    desc: "Take the Dash or Disengage action as a bonus action. Jump distance is doubled."
  - name: Patient Defense (1 ki)
    desc: "Take the Dodge action as a bonus action."
  - name: Misty Step (1/day)
    desc: "Teleport 30 feet to an unoccupied space you can see."
reactions:
  - name: Deflect Missiles
    desc: "When hit by a ranged weapon attack, reduce the damage by 1d10 + 7. If reduced to 0, catch the missile and make a monk weapon attack with it."


```
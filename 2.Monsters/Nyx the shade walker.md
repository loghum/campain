 ```statblock
 monster: Nyx the Shadewalker
name: Nyx the Shadewalker
size: Medium
type: Humanoid
subtype: Tiefling
alignment: Chaotic Evil
ac: 15 (Studded Leather + Dexterity)
hp: 84
speed: 30 ft.
stats: [12, 18, 14, 16, 12, 14]
saves:
  - dexterity: +7
  - intelligence: +6
  - charisma: +5
skillsaves:
  - stealth: +9
  - deception: +6
  - arcana: +6
  - sleight of hand: +7
  - perception: +4
damage_vulnerabilities: Radiant
damage_resistances: Fire, Necrotic
damage_immunities: None
condition_immunities: Charmed (while in magical darkness)
senses: Darkvision 120 ft., passive Perception 14
languages: Common, Infernal, Thieves’ Cant
cr: 5
proficiency_bonus: +3
spells:
  - cantrips [[Mage Hand]], [[Minor Illusion]], [[Prestidigitation]], [[Thaumaturgy]]
  - 1st level (4 slots) [[Disguise Self]], [[Shield]], [[Charm Person]],[[Silent Image]]
  - 2nd level (3 slots) [[Mirror Image]], [[Misty Step]],[[Invisibility]]
  - 3rd level (2 slots) [[Counterspell]], [[Fear]]
  - Racial spell(1/day) [[Darkness]]
traits:
  - name: Cunning Action
    desc: "Nyx can take a bonus action on each of his turns to Dash, Disengage, or Hide."
  - name: Sneak Attack (1/Turn)
    desc: "Nyx deals an extra 14 (4d6) damage when he hits with a finesse or ranged weapon if he has advantage on the attack roll or an ally is within 5 feet of the target."
  - name: Devil’s Sight
    desc: "Nyx can see normally in darkness, both magical and nonmagical, to a distance of 120 feet."
  - name: Shadowstep Trickery
    desc: "While in magical darkness, Nyx has advantage on Dexterity (Stealth) checks and cannot be targeted by opportunity attacks."
actions:
  - name: Shadow Dagger (Melee or Ranged Weapon Attack)
    desc: "+7 to hit, reach 5 ft. or range 20/60 ft., one target. Hit: 7 (1d4 + 4) piercing damage plus 10 (3d6) necrotic damage if the target is surprised or if Nyx has advantage on the attack."
  - name: Soulflare Bolt (Ranged Spell Attack)
    desc: "+6 to hit, range 60 ft., one creature. Hit: 13 (3d8) necrotic damage. If the target is under a magical condition (charmed, frightened, restrained), it must succeed on a DC 14 Charisma saving throw or be stunned until the start of Nyx's next turn."
bonus_actions:
  - name: Cunning Action
    desc: "Nyx can take a bonus action to Dash, Disengage, or Hide."
  - name: Shadow Step
    desc: "Nyx vanishes in a swirl of shadows. He can teleport up to 30 feet to an unoccupied space he can see."
reactions:
  - name: Dark Reversal
    desc: "When Nyx is affected by a spell he can see, he can use his reaction to impose disadvantage on the caster's spell attack roll or force a reroll of the save if it targets him."
legendary_actions:
  - name: Shadow Veil
    desc: "Nyx vanishes in a swirl of shadows. He can teleport up to 30 feet to an unoccupied space he can see."
  - name: Disorienting Mirage
    desc: "Nyx creates a flickering illusion of himself. One creature that can see Nyx must succeed on a DC 13 Intelligence saving throw or have disadvantage on its next attack roll against him."
  - name: Soul Pulse
    desc: "Nyx channels energy from a nearby soul-linked gem. One creature within 30 feet must succeed on a DC 13 Charisma saving throw or be restrained in shadowy chains until the end of its next turn."

```
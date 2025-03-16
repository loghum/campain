```statblock
monster: Shadow Guardian
name: Shadow Guardian
size: Medium
type: Undead
subtype: None
alignment: Neutral Evil
ac: 16 (natural armor)
hp: 120
speed: 0 ft. (immobile)
stats: [14, 18, 16, 12, 14, 18]
saves:
  - dexterity: +6
  - wisdom: +4
  - charisma: +6
skillsaves: None
damage_vulnerabilities: None
damage_resistances: Necrotic; Bludgeoning, Piercing, and Slashing from non-magical attacks
damage_immunities: Psychic
condition_immunities: Charmed, Frightened, Paralyzed, Poisoned
senses: Darkvision 60 ft., passive Perception 14
languages: Understands Common but cannot speak
cr: 6
proficiency_bonus: +3
spells: None
traits:
  - name: Immovable Shadow
    desc: "The Shadow Guardian is fixed in place, unable to move or take actions other than those related to its Reactions."
  - name: Magical Resistance
    desc: "The Shadow Guardian has advantage on saving throws against spells and other magical effects."
  - name: Aura of Dread
    desc: "Any creature that starts its turn within 10 feet of the Shadow Guardian must succeed on a DC 14 Wisdom saving throw or be [[Conditions#Frightened]] until the start of its next turn."
legendary_actions:
  - name: Dark Tendril
    desc: "The Shadow Guardian lashes out with a shadowy tendril at a creature within 10 feet. The target must make a DC 14 Dexterity saving throw or take 10 (3d6) necrotic damage."
  - name: Reckless Fear
    desc: "The Shadow Guardian can target a creature it can see within 30 feet. The creature must succeed on a DC 14 Wisdom saving throw or be [[Conditions#Frightened]] for 1 minute. The target can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success."
bonus_actions:
  - name: None
    desc: None
reactions:
  - name: Shadow Strike
    desc: "When a creature within 5 feet of the Shadow Guardian makes a melee attack against it, the Shadow Guardian can use its reaction to make a melee attack against the creature. On a hit, the target takes 10 (2d6 + 4) necrotic damage, and the target must succeed on a DC 14 Constitution saving throw or have its movement speed reduced by 10 feet until the start of its next turn."
  - name: Shadow Lash
    desc: "When a creature within 30 feet of the Shadow Guardian makes a ranged attack, the Shadow Guardian can use its reaction to lash out with a shadowy tendril. The attack has a +6 to hit, and on a hit, the target takes 8 (2d4 + 3) necrotic damage."
  - name: Phantasmal Shield
    desc: "When a creature casts a spell that targets the Shadow Guardian, the Guardian can use its reaction to warp the magic. The target creature must make a DC 14 Intelligence saving throw or have the spell redirected back at them, with disadvantage on the saving throw. The Shadow Guardian is unaffected by magic damage or effects that require physical presence."

```


{
  "name": "test",
  "source": "5e SRD",
  "size": "Gargantuan",
  "type": "monstrosity",
  "subtype": "titan",
  "alignment": "chaotic evil",
  "ac": 18,
  "hp": 472,
  "hit_dice": "27d20 + 188",
  "speed": {
    "walk": "20 ft.",
    "swim": "60 ft."
  },
  "stats": [30, 11, 25, 22, 18, 20],
  "saves": {
    "strength": 17,
    "dexterity": 7,
    "constitution": 14,
    "intelligence": 13,
    "wisdom": 11
  },
  "damage_vulnerabilities": "",
  "damage_resistances": "",
  "damage_immunities": "lightning; bludgeoning, piercing, and slashing from nonmagical weapons",
  "condition_immunities": ["frightened", "paralyzed"],
  "senses": "truesight 120 ft., passive Perception 14",
  "languages": "understands Abyssal, Celestial, Infernal, and Primordial but can't speak, telepathy 120 ft.",
  "cr": "23",
  "bestiary": true,
  "traits": [
    {
      "name": "Amphibious",
      "desc": "The kraken can breathe air and water.",
      "attack_bonus": 0
    },
    {
      "name": "Freedom of Movement",
      "desc": "The kraken ignores difficult terrain, and magical effects can't reduce its speed or cause it to be restrained. It can spend 5 feet of movement to escape from nonmagical restraints or being grappled.",
      "attack_bonus": 0
    },
    {
      "name": "Siege Monster",
      "desc": "The kraken deals double damage to objects and structures.",
      "attack_bonus": 0
    }
  ],
  "actions": [
    {
      "name": "Multiattack",
      "desc": "The kraken makes three tentacle attacks, each of which it can replace with one use of Fling.",
      "attack_bonus": 0
    },
    {
      "name": "Bite",
      "desc": "Melee Weapon Attack: +7 to hit, reach 5 ft., one target. Hit: 23 (3d8 + 10) piercing damage. If the target is a Large or smaller creature grappled by the kraken, that creature is swallowed, and the grapple ends. While swallowed, the creature is blinded and restrained, it has total cover against attacks and other effects outside the kraken, and it takes 42 (12d6) acid damage at the start of each of the kraken's turns. If the kraken takes 50 damage or more on a single turn from a creature inside it, the kraken must succeed on a DC 25 Constitution saving throw at the end of that turn or regurgitate all swallowed creatures, which fall prone in a space within 10 feet of the kraken. If the kraken dies, a swallowed creature is no longer restrained by it and can escape from the corpse using 15 feet of movement, exiting prone.",
      "attack_bonus": 7,
      "damage_dice": "3d8",
      "damage_bonus": 10
    },
    {
      "name": "Tentacle",
      "desc": "Melee Weapon Attack: +7 to hit, reach 30 ft., one target. Hit: 20 (3d6 + 10) bludgeoning damage, and the target is grappled (escape DC 18). Until this grapple ends, the target is restrained. The kraken has ten tentacles, each of which can grapple one target.",
      "attack_bonus": 7,
      "damage_dice": "3d6",
      "damage_bonus": 10
    },
    {
      "name": "Fling",
      "desc": "One Large or smaller object held or creature grappled by the kraken is thrown up to 60 feet in a random direction and knocked prone. If a thrown target strikes a solid surface, the target takes 3 (1d6) bludgeoning damage for every 10 feet it was thrown. If the target is thrown at another creature, that creature must succeed on a DC 18 Dexterity saving throw or take the same damage and be knocked prone.",
      "attack_bonus": 0
    },
    {
      "name": "Lightning Storm",
      "desc": "The kraken magically creates three bolts of lightning, each of which can strike a target the kraken can see within 120 feet of it. A target must make a DC 23 Dexterity saving throw, taking 22 (4d10) lightning damage on a failed save, or half as much damage on a successful one.",
      "attack_bonus": 0,
      "damage_dice": "4d10"
    }
  ],
  "spells": [
    "The archmage is an 18th-level spellcaster. Its spellcasting ability is Intelligence (spell save DC 17, +9 to hit with spell attacks). The archmage can cast disguise self and invisibility at will and has the following wizard spells prepared:",
    "Cantrips (at will): fire bolt, light, mage hand, prestidigitation, shocking grasp",
    "1st level (4 slots): detect magic, identify, mage armor*, magic missile",
    "2nd level (3 slots): detect thoughts, mirror image, misty step",
    "3rd level (3 slots): counterspell, fly, lightning bolt",
    "4th level (3 slots): banishment, fire shield, stoneskin*",
    "5th level (3 slots): cone of cold, scrying, wall of force",
    "6th level (1 slot): globe of invulnerability",
    "7th level (1 slot): teleport",
    "8th level (1 slot): mind blank*",
    "9th level (1 slot): time stop",
    "* The archmage casts these spells on itself before combat."
  ],
  "legendary_actions": [
    {
      "name": "Tentacle Attack or Fling",
      "desc": "The kraken makes one tentacle attack or uses its Fling.",
      "attack_bonus": 0
    },
    {
      "name": "Lightning Storm (Costs 2 Actions)",
      "desc": "The kraken uses Lightning Storm.",
      "attack_bonus": 0
    },
    {
      "name": "Ink Cloud (Costs 3 Actions)",
      "desc": "While underwater, the kraken expels an ink cloud in a 60-foot radius. The cloud spreads around corners, and that area is heavily obscured to creatures other than the kraken. Each creature other than the kraken that ends its turn there must succeed on a DC 23 Constitution saving throw, taking 16 (3d10) poison damage on a failed save, or half as much damage on a successful one. A strong current disperses the cloud, which otherwise disappears at the end of the kraken's next turn.",
      "attack_bonus": 0
    }
  ]
}

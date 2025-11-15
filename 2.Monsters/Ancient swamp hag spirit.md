```statblock
monster: Ancient Swamp Hag Spirit
name: Ancient Swamp Hag Spirit
size: Medium
type: Fey
subtype: Undead
alignment: Chaotic Neutral
ac: 15 (natural armor)
hp: 115
speed: 30 ft., swim 20 ft.
stats:
  - 14
  - 12
  - 16
  - 12
  - 16
  - 16
saves:
  - constitution: 6
  - wisdom: 7
  - charisma: 7
skillsaves:
  - stealth: 4
  - perception: 6
damage_vulnerabilities: []
damage_resistances: bludgeoning, piercing, and slashing from nonmagical attacks
damage_immunities: poison
condition_immunities: poisoned, charmed
senses: darkvision 60 ft., passive Perception 16
languages: Common, Sylvan
cr: 7
proficiency_bonus: 3
traits:
  - name: Swamp Step
    desc: The hag can move through swampy terrain without penalty and leaves a 15-ft radius of difficult terrain until the start of her next turn.
  - name: Rotting Aura
    desc: Creatures that start their turn within 10 ft. of the hag must succeed on a DC 15 Constitution saving throw or take 5 (1d10) necrotic damage. Creatures that are poisoned take 10 (2d10) necrotic damage instead.
  - name: Legendary Resistance (3/Day)
    desc: If the hag fails a saving throw, she can choose to succeed instead.
actions:
  - name: Engulfing Vines (Recharge 4–6)
    desc: "The swamp rises at the hag’s command. Each creature in a 20-foot-radius centered on a point within 40 ft. must make a DC 16 Dexterity saving throw.\nFailed save: 13 (2d8 + 4) bludgeoning damage and restrained.\nSuccessful save: Half damage, not restrained.\nRestrained creatures take 9 (2d8) poison damage at the start of the hag’s turn.\nA restrained creature can use an action to make a DC 15 Strength (Athletics) or Dexterity (Acrobatics) check to free itself."
  - name: Curse of the Mire (Recharge 5–6)
    desc: "The hag targets up to 3 creatures within 40 ft. Each must make a DC 16 Constitution saving throw or be poisoned for 1 minute. A poisoned target takes 7 (2d6) poison damage at the start of its turn. It may repeat the saving throw at the end of each of its turns."
  - name: Multiattack
    desc: "The hag makes two Poisoned Tendril attacks."
  - name: Poisoned Tendrils
    desc: "Melee Weapon Attack: +7 to hit, reach 10 ft., one target. Hit: 12 (2d6 + 5) bludgeoning damage plus 7 (2d6) poison damage."
bonus_actions:
  - name: Summon Swamp Minions
    desc: "The hag summons 2–3 `encounter: Poisonous Swamp Plant` in unoccupied spaces within 30 ft. The minions gain 3 temporary hit points."
reactions:
  - name: Bog Shield
    desc: "When the hag is hit by an attack, she conjures muck and reeds to shield herself, reducing the damage by 2d10 + 5."
legendary_actions:
  - name: Tendril Lash
    desc: "The hag makes one Poisoned Tendril attack."
  - name: Suffocating Bog Mist 
    desc: "The hag targets a point she can see within 60 ft. A choking cloud of swamp gas fills a 10-ft-radius sphere centered on that point. Creatures in the area must succeed on a DC 15 Constitution saving throw or begin choking, becoming unable to speak or cast spells with verbal components until the end of their next turn."
  - name: Swamp Shift
    desc: "The hag magically slips through the mire, teleporting up to 20 ft. to an unoccupied space she can see. This movement does not provoke opportunity attacks."
source: Homebrew
layout: Basic 5e Layout
lair_actions: []
regional_effects: []



```
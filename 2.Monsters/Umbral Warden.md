```statblock
monster: Umbral Warden
name: Umbral Warden
size: Huge
type: Aberration
subtype: Undead
alignment: None
ac: 17
hp: 190
speed: 40 ft., fly 40 ft.
stats: [18, 16, 20, 16, 16, 18]
saves: []
skillsaves: []
damage_vulnerabilities: None
damage_resistances: None
damage_immunities: None
condition_immunities: None
senses: passive Perception 13
languages: None
cr: 11
proficiency_bonus: +4
spells: []
traits:
  - name: Legendary Resistance (3/Day)
    desc: "If the Umbral Warden fails a saving throw, it can choose to succeed instead."
  - name: Living Darkness
    desc: "The Umbral Warden is always considered to be in dim light or darkness beyond 15 feet of it."
  - name: Aura of Dread
    desc: "Each enemy within 20 feet of the Umbral Warden must succeed on a DC 15 Wisdom saving throw or be frightened until the end of its next turn."
  - name: Shadow Regeneration
    desc: "The Umbral Warden regains 15 hit points at the start of its turn while in darkness."
actions:
  - name: Multiattack
    desc: "The Umbral Warden makes two Umbral Tendril attacks."
  - name: Umbral Tendril
    desc: "Melee or Ranged Spell Attack: +8 to hit, reach 30 ft., one target. Hit: 15 (2d10 + 4) necrotic damage. The target must succeed on a DC 15 Strength saving throw or be restrained."
  - name: Devour Light (Recharge 5–6)
    desc: "The Umbral Warden releases a 20-foot-radius burst of consuming darkness. Each creature in that area must make a DC 16 Constitution saving throw, taking 22 (6d6) necrotic damage on a failed save, or half as much on a success. Creatures that fail the save are also blinded until the end of their next turn."
bonus_actions:
  - name: Split Shadow
    desc: "The Umbral Warden creates 1–2 shadow minions in unoccupied spaces it can see within 30 feet."
reactions: []
legendary_actions:
  - name: Shadow Step
    desc: "The Umbral Warden teleports up to 30 feet to an unoccupied space it can see in dim light or darkness."
  - name: Tendril Attack
    desc: "The Umbral Warden makes one Umbral Tendril attack."

```
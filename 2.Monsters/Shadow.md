```statblock
monster: Shadow
name: Shadow
size: Medium
type: Undead
subtype: None
alignment: Chaotic Evil
ac: 12
hp: 16
speed: 40 ft.
stats: [6, 14, 13, 6, 10, 8]
saves: []
skillsaves:
  - stealth: +4
damage_vulnerabilities: Radiant
damage_resistances: Acid, Cold, Fire, Lightning, Thunder; Bludgeoning, Piercing, and Slashing from nonmagical attacks
damage_immunities: Necrotic, Poison
condition_immunities: Exhaustion, Frightened, Grappled, Paralyzed, Petrified, Poisoned, Prone, Restrained
senses: Darkvision 60 ft., passive Perception 10
languages: None
cr: 1/2
proficiency_bonus: +2
spells: []
traits:
  - name: Amorphous
    desc: "The shadow can move through a space as narrow as 1 inch wide without squeezing."
  - name: Shadow Stealth
    desc: "While in dim light or darkness, the shadow can take the Hide action as a bonus action. Its stealth bonus is also improved to +6."
  - name: Sunlight Weakness
    desc: "While in sunlight, the shadow has disadvantage on attack rolls, ability checks, and saving throws."
actions:
  - name: Strength Drain
    desc: "Melee Weapon Attack: +4 to hit, reach 5 ft., one creature. Hit: 9 (2d6 + 2) necrotic damage. The target's Strength score is reduced by 1d4. The target dies if this reduces its Strength to 0. Otherwise, the reduction lasts until the target finishes a short or long rest. If a non-evil humanoid dies from this attack, a new shadow rises from the corpse 1d4 hours later."
bonus_actions: []
reactions: []
legendary_actions: []

```
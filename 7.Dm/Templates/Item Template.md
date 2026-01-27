---
export: true
owner: None
name: Name of item
type: <% tp.system.prompt("Item type (LA=Light Armor, MA=Medium Armor, HA=Heavy Armor, S=Shield, M=Melee, R=Ranged, A=Ammunition, RD=Rod, ST=Staff, WD=Wand, RG=Ring, P=Potion, SC=Scroll, W=Wondrous, G=Gear, $=Money)") %>
magic: <% tp.system.prompt("Magic item (1=true, 0=false)") %>
detail: "Weapon (maul or warhammer, uncommon, attunement by a Barbarian)"
value: 1
weight: 1
text:
  - "alinia 1"
  - "alinia 2"
dmg1: 1h handded attack: example spear 1h = 1d6
dmg2: 2h handded attack: example spear 2h = 1d8
dmgType: <% tp.system.prompt("Damage type (B=Bludgeoning, P=Piercing, S=Slashing, A=Acid, C=Cold, F=Fire, FC=Force, L=Lightning, N=Necrotic, PS=Poison, R=Radiant, T=Thunder, leave blank if none)") %>
property: <% tp.system.prompt("Weapon properties (choose multiple, comma-separated): A = Ammunition, F = Finesse, H = Heavy, L = Light, LD = Loading, R = Reach, S = Special, T = Thrown, 2H = Two-handed, V = Versatile, M = Martial weapon; leave blank if none)") %>
---


- `detail (ABC)` – Item rarity and attunement requirements (only visible on iOS and macOS)  
- `text (ABC)` – Item description  
  - Multiple `<text>` elements can be included.  
  - Each `<text>` element represents a **paragraph**.  
  - If `auto_indent` is set in `<compendium>`, paragraphs after the first will **automatically indent**.  
- `ac (##)` – Armor Class (if applicable)  
- `strength (##)` – Strength score required to wear armor  
- `stealth (1 | 0)` – `1` if the armor imposes disadvantage on Stealth checks  
- `range (##/##)` – Weapon range (`[short range]/[long range]`)  
- `modifier (ABC [+/-]##)` – Modifiers  
  - Takes an attribute named `"category"`, which can be one of:  
    - **bonus**  
    - **ability score**  
    - **ability modifier**  
    - **saving throw**  
    - **skill**  
  - Example values:  
    - `"weapon attack +1"`  
    - `"strength -1"`  
    - `"ac +5"`  
- `roll (D20)` – Dice roll formulas  
  - Ability modifiers can be inputted using **STR, DEX, CON, INT, WIS, CHA**.  

"modifier_bonus":
  - "weapon attacks +1"
  - "weapon damage +1"
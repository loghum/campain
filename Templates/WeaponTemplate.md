---
owner: "Owner of the item"
name: "Testing sword +1"
type: M
magic: 1
detail: "Uncommon (requires attunement)"
value: 1500
weight: 13
text:
  - "text1"
  - "text2"
dmg1: "2d6"
dmgType: B
property: F,2H
"modifier_bonus":
  - "weapon attacks +1"
  - "weapon damage +1"
---

- `name (ABC)` – Item name  
- `type (LA | MA | HA | S | M | R | A | RD | ST | WD | RG | P | SC | W | G | $)` – Item category  
  - **LA** = Light armor  
  - **MA** = Medium armor  
  - **HA** = Heavy armor  
  - **S** = Shield  
  - **M** = Melee weapon  
  - **R** = Ranged weapon  
  - **A** = Ammunition  
  - **RD** = Rod  
  - **ST** = Staff  
  - **WD** = Wand  
  - **RG** = Ring  
  - **P** = Potion  
  - **SC** = Scroll  
  - **W** = Wondrous item  
  - **G** = Adventuring gear  
  - **$** = Money  
- `magic (1 | 0)` – Set to `1` if the item is magical (may be omitted if not magical)  
- `detail (ABC)` – Item rarity and attunement requirements (only visible on iOS and macOS)  
- `value (##)` – Gold value of the item  
- `weight (##)` – Item weight  
- `text (ABC)` – Item description  
  - Multiple `<text>` elements can be included.  
  - Each `<text>` element represents a **paragraph**.  
  - If `auto_indent` is set in `<compendium>`, paragraphs after the first will **automatically indent**.  
- `ac (##)` – Armor Class (if applicable)  
- `strength (##)` – Strength score required to wear armor  
- `stealth (1 | 0)` – `1` if the armor imposes disadvantage on Stealth checks  
- `dmg1 (D20)` – One-handed weapon damage  
- `dmg2 (D20)` – Two-handed weapon damage  
- `dmgType (B | P | S | A | C | F | FC | L | N | PS | R | T)` – Damage type  
  - **B** = Bludgeoning  
  - **P** = Piercing  
  - **S** = Slashing  
  - **A** = Acid  
  - **C** = Cold  
  - **F** = Fire  
  - **FC** = Force  
  - **L** = Lightning  
  - **N** = Necrotic  
  - **PS** = Poison  
  - **R** = Radiant  
  - **T** = Thunder  
- `property (A, F, H, L, LD, R, S, T, 2H, V, M)` – Weapon properties (multiple values allowed)  
  - **A** = Ammunition  
  - **F** = Finesse  
  - **H** = Heavy  
  - **L** = Light  
  - **LD** = Loading  
  - **R** = Reach  
  - **S** = Special  
  - **T** = Thrown  
  - **2H** = Two-handed  
  - **V** = Versatile  
  - **M** = Martial weapon  
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
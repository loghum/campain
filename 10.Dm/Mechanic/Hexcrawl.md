| Type terrein              | Hexschaal (6 miles) |
| ------------------------- | ------------------- |
| Vlak / Grasland           | 4 hexes/day         |
| Bos / Heuvels             | 3 hexes/day         |
| Bergen / moeilijk terrein | 2 hexes/day         |
| Moeras / Rivieren         | 1 hex/day           |

| d20 Roll | Weather / Conditions | Effect                                                                                                                                                     |
| -------- | -------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1–8      | Helder / Zon         | Geen straf, normale snelheid, zicht +2 voor verkennen.                                                                                                     |
| 9–12     | Wolken / Bewolkt     | Geen impact op snelheid, perceptie checks -1.                                                                                                              |
| 13–15    | Regen / Motregen     | Reizen 1 hex minder / dag, Stealth en Survival checks -1. Kleine kans (1 op 6) op uitglijden of materiaal beschadigd.                                      |
| 16       | Storm / Onweer       | Reizen 2 hexes minder / dag, voordeel voor schuilen checks, kans op blikseminslag (1d6 damage op 1 karakter als roll = 1).                                 |
| 17       | Sneeuw / IJzel       | Reizen 2 hexes minder / dag, Survival + Perception -1, kans op uitglijden (1d4 minor schade of vermoeiing).                                                |
| 18–20    | Mist / Dichte nevel  | Zicht beperkt tot 1 hex, voordeel voor schuilen, nadeel voor navigatie (-1 op Survival / Nature). Kans op verdwalen (1 op 4) en extra hex reizen verloren. |

| d20 Roll | Encounter Type                           |
|----------|-----------------------------------------|
| 1–7      | Niets / rustige reis                     |
| 8–10      | Wilde dieren                             |
| 11–13    | Lizardfolk / Roaming Bandits             |
| 14–15    | Magische / Bovennatuurlijke gebeurtenis |
| 16–17    | Veldslag / Mini-boss                     |
| 18–20    | Random NPC / Handelaar / Reiziger       |


### **Stap 4: Exacte Vijanden (rol 1d6)**

#### **1d6 Wilde Dieren**

| 1d6 | Encounter                                                                                              |
| --- | ------------------------------------------------------------------------------------------------------ |
| 1   | Wolven Alpha Pack `encounter: 3: Wolf, 2: Dire Wolf` |
| 2   | Bears – 2 bruine beren, knockdown attack (Str DC 14) `encounter: 3: Brown Bear`                                                  |
| 3   | Boars + Wolves – 2 everzwijnen + 2 wolven, charge + gore attacks  `encounter: 2: Boar, 1 Dire Wolf`                                           |
| 4   | Spinnen – 3–4 Giant Spiders, web attacks mogelijk, movement beperkt `encounter: 4: Giant Spider`                                          |
| 5   | Snakes – 3–4 Giant Poisonous Snakes, Con save DC 14 of poison  `encounter: 4: Giant Poisonous Snake`                                               |
| 6   | Giant Eagles – 2 Eagles, flyby attacks + opportunity attacks  `encounter: 3: Giant Eagle`                                         |

```encounter
name: Encounter name
creatures:
  - Brown Bear
  - Giant Poisonous Snake
  - Giant Eagle
  - 
  - Hobgoblin
  - Hobgoblina
  - 
```

|1d10|Encounter|
|---|---|
|1|**Lizardfolk Patrol** – 3–4 Warriors + 1 Shaman, patrouillerend in territorium|
|2|**Lizardfolk + Wild Animal** – 2–3 Warriors + 1 Giant Crocodile of 2 Swamp Wolves|
|3|**Lizardfolk Ambush / Rival Tribe** – 3–4 Warriors van een andere Lizardfolk groep|
|4|**Bandit Squad** – 3–4 bandieten (2 melee, 1–2 crossbows), op doorreis|
|5|**Goblins Ambush** – 4–5 goblins incl. 1–2 archers, vallen of terrain advantage|
|6|**Lizardfolk vs Bandits** – 2 Lizardfolk Warriors + 2 Bandits, conflict tussen de groepen|
|7|**Lizardfolk Scouts + Traps** – 2–3 Warriors, verborgen in terrein met natuurlijke vallen|
|8|**Bandit Leader Encounter** – 1 Bandit Leader (AC 16, 45 HP) + 1–2 minions|
|9|**Lizardfolk + Environmental Hazard** – 1 Shaman + 2 Warriors + natuurlijke obstakels (valstrikken, moeilijk terrein)|
|10|**Elite Lizardfolk Force** – 1 Shaman + 3 Warriors, zeer tactisch, verdedigend territorium|

rol d6. 1-3 [[Scalebite Clan]] 4-6[[Sunfang Tribe]]
#### **1d6 Mini-boss / Veldslag**

| 1d6 | Encounter                                                                              |
| --- | -------------------------------------------------------------------------------------- |
| 1   | Veteran Bandit Captain – 1 captain (AC 17, 85 HP, multiattack) + 3 elite minions       |
| 2   | Ogre / Troll – 1 Ogre/Troll (AC 15–16, 100+ HP), regeneratie 5 HP/turn + 2 minions     |
| 3   | Bear Alpha + Wolves – 1 bear alpha (AC 15, 85 HP) + 3 wolves, charge + terrain hazards |
| 4   | Hill Giant Scout – 1 Hill Giant (AC 16, 105 HP) + 1–2 minions                          |
| 5   | Lizardfolk Ambush – 1 Shaman + 2–3 Warrior minions, traps & tactical attacks           |
| 6   | Mixed Surprise Ambush – 1 Ogre + 2 Goblins + 1 Lizardfolk + environmental hazard       |




| Rust Type               | Duur    | Locatie / Veiligheid                               | Herstel HP                        | Herstel Hit Dice                                 | Spells                     |
| ----------------------- | ------- | -------------------------------------------------- | --------------------------------- | ------------------------------------------------ | -------------------------- |
| **Short Rest**          | 10 min  | Overal (hex, bos, vlakte)                          | Gebruik **1 hit dice**            | Niets                                            | Niks                       |
| **Onveilige Long Rest** | 6–8 uur | Onbeschermd terrein (bos, vlakte, heuvels, moeras) | Gebruik hit dice zoals short rest | **Halve hit dice terug** (afronden naar beneden) | Pc's lvl. 2lvl en 3lvl = 5 |
| **Veilige Long Rest**   | 6–8 uur | Dorpen, versterkte ruïnes, beschermd kamp          | Volledige HP                      | **Alle hit dice terug**                          | Alle spell slots           |

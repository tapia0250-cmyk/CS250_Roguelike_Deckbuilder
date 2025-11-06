# CS250_Roguelike_Deckbuilder (Sigmo Game)

This will be a turn-based, roguelike deck builder game in which the player fights monsters using battle cards, each with its own ability. The cards’ power will increase after every monster’s defeat. Over the course of the game, the player will gain increasingly stronger cards, eventually fighting and defeating the final boss at the end.

Our goal is to create a fun, challenging game that combines action, battles, abilities, and adventure, all while pushing the boundaries of creativity.

## **Guide: Sigmo Game**

The game begins by showing the **Sigmo logo** against a dark background, followed by the **main menu**.

**Main Menu:**
The background will feature a **dynamic medieval castle** set in a dark forest, with fog drifting across one side of the screen to give the scene more depth and atmosphere.

**Main Menu Options:**

* Start Game
* Options
* Exit
* Credits

Once the player presses **Start Game**, the game transitions to a **dark loading screen**. After loading is complete, **Scenario 1** appears.

---

### **Scenario 1: Castle Entrance**

After the loading screen, the character appears at the **castle gate**, saying:

> “May the Gods be with me.”

**Controls:**

* Move: **A, W, S, D**
* Attack: **Shift**
* Use potions: **1, 2, 3**
* Pause: **Esc**



**Scenario 1: Castle Map — Top-Down Camera**
The player moves through the map, **interacting with objects** and **fighting goblins**.

---

### **Scenario 2: Dark Forest (Boss Battle)**

When the player finds the portal leading to the boss, they are **teleported** to a dark forest where the **final battle** takes place. The boss fights the player **to the death**.

---

## **Game Structure**

### **Character**

* **Style:** A dark medieval knight whose main weapon is a **sword**.
* **Movement:**

  * W: Forward
  * S: Backward
  * A: Left
  * D: Right
* **Attack:** Shift
* **Block:** M
* **Dodge:** Quickly move or jump sideways using **E**

**Combat Mechanics:**

* The character has **two sword attack animations**.
* Enemies react when hit.
* When hit by a goblin, the player loses **10% of health**.
* When hit by the boss, the player loses **35% of health**.

**Potion Cards:**
The player can use **cards** to activate potion effects:

* **Health Potion:** Restores 25% of health.
* **Power Potion:** Enables a **special attack** that deals 35% damage to enemies.
* **Light Potion:** Allows the player to **revive after death** without losing progress.

> *Note:* The **Light Potion** is only obtained by completing in-game challenges, such as defeating **100 goblins** and finding **3 hidden relics** located in Scenario 1.

---

## **Enemies**

* **Goblins:**
  Small monsters that attack when they see the player.
  Each attack deals **10% damage**.
  They have only one attack animation.

* **Boss:**
  The main enemy of the first dungeon — a **giant ogre** with **three attack patterns** and a **special power**.

  * Normal attacks deal **25% damage**.
  * Special power deals **40% damage** and can be used every **2 minutes**.

**Defense Mechanics:**
The player can **block** using the **M key**:

* Reduces goblin damage by **5%**.
* Reduces boss damage by **20%**.
  The character can also **dodge attacks** with agility.

---

## **Sound & Atmosphere**

* **Music:** Background music shifts from **slow strings** to **heavy percussion** as battles intensify.

---

## **Visual Language**

| Element           | Description                                              |
| ----------------- | -------------------------------------------------------- |
| **Color Palette** | Deep blacks, stone grays, blood reds, muted blues        |
| **Lighting**      | Torches, moonlight, glowing potions, ambient mist        |
| **Texture**       | Wet stone, decayed wood, rusted iron, torn banners       |
| **Mood**          | Haunting, lonely, yet heroic — gothic tragedy            |
| **Camera Flow**   | Scene 1: Top-down → Scene 2: Over-the-shoulder cinematic |
| **Audio**         | Echoes, dripping water, fire crackles, distant growls    |

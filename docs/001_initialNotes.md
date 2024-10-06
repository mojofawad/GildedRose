# Initial Notes

## Specifications

### From the README.md
#### Knowns
- What we know about Items
  - What are properties that define an item?
    - Items have a "sell-in" date
    - Items have a quality rating
      - Quality can increase or decrease, depending on the item
        - Quality can never increase above 50
  - What are the behaviors of an item?
    - In most cases, items have an expiration date.
      - Referred to as "SellIn", however SellIn is also used for AgedBrie which doesn't expire
    - In most cases, quality degrades as sell-in lowers
    - Sell-in lowers at the end of each day
- There are multiple types of items:
  - Items that degrade in quality
    - To be named: **Degrading Item**
  - Items that increase in quality
    - To be named: ???
      - Appreciating?
      - Aging?
      - Improving?
  - Items that increase in quality up until they expire
    - To be named:
      - Limited Time Offering?
  - Items that never change in quality: **Legendary Item**
  - _To Be Implemented_: Items that decrease in quality twice as fast: **Conjured Item**
- What is being worked towards?
  - **Conjured** items need to be added to the system

#### Opinions
- Refactoring the code would make the system easier to work for future changes, such as adding the **Conjured** item type.

### From the Code
#### Given Items
- Degrading Items
  - +5 Dexterity Vest
  - Elixir of the Mongoose
- Appreciating Items
  - Aged Brie
    - Aged Brie increases twice as fast after the SellIn date
- Limited Time Offering Items 
  - Backstage Passes
- Legendary Items
  - Sulfuras
- Conjured Items
  - Conjured Mana Cake

### Item Definitions
#### All Items
- No item quality will decrease below 0
#### Appreciating Items
- Increases in quality
  - Increases inverse of Degraded Items rate of change
    - After "SellIn", appreciating items increase at twice the rate
  - Quality can **NEVER** increase above 50
#### Conjured Items
- 
#### Degrading Items
- Degrades in quality (-1) before expiration
- Degrades twice as fast (-2) after expiry
#### Legendary Items
- Doesn't have a SellIn (never has to be sold)
- Quality never decreases
#### Limited Time Items
- Prior to expiry (SellIn >= 0), quality increases
  - Quality's rate of change is dependent on days left till Expiry 
- After expiry (SellIn < 0), quality = 0




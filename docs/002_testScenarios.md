# Pre-refactoring Test Cases

## Test Case
- Method
  - Scenario
    - Expected

## Appreciating Items
- UpdateQuality 
  - SellIn >= 0 && Quality < 50 
    - Quality = Quality + 1
  - SellIn < 0 && Quality < 49
    - Quality = Quality + 2
  - SellIn < 0 && Quality = 49
    - Quality = 50
  - Quality = 50
    - Quality = 50
  
## Conjured Items
- _to be added once code is refactored_

## Degrading Items
- UpdateQuality
  - SellIn >= 0 && Quality > 0
    - SellIn = SellIn - 1
    - Quality = Quality - 1
  - SellIn < 0 && Quality > 1
    - SellIn = SellIn - 1
    - Quality = Quality - 2
  - SellIn < 0 && Quality = 1
    - Quality = 0
  - Quality = 0
    - Quality = 0

## Legendary Items
- UpdateQuality
  - Quality is anything
    - Quality = Quality

## Limited Time Items
- Update Quality
  - SellIn > 10
    - Quality = Quality + 1
  - SellIn <= 10 && SellIn > 5
    - Quality = Quality + 2
  - SellIn <= 5 && SellIn >= 0
    - Quality = Quality + 3
  - SellIn < 0
    - Quality = 0
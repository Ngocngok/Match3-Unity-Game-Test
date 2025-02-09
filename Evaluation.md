# Evaluation
## Advantage
1. Enforce data encapsulation and single responsibility principle.
2. Separate board state from visual, resulting in less bugs due to animations and effect.

## Drawback
1. Spawn and despawn item logic appear in different scripts (Board and BoardController), hard to keep track of current state of the board.

# Suggestion
1. Limit the use of linq in matching logic.
2. Should not use multiple prefabs to represent views of items.

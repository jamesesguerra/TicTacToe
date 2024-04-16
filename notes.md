## v1
- problems i had: changing the data type of the player choice to a `Symbol` enum, to a `string`, to an `int` was frustrating for a small file i can imagine it being more frustrating for a system with more classes that are coupled
  - i think that i should be thinking of in terms of a higher abstraction and make some sort of `Choice` type
  - i also think the problem is that even though `Player.SelectSquare()` isn't exposing a property / field, it's still exposing the data type of the `playerChoice` variable inside `SelectSquare`
  - ideally, i should hide the data type of the player's choice so that if i wanna change it in the future, i just have to change how it's implemented from one place (the `SelectSquare` method)
- the `GameDriver` class could have more focused methods
- having the `Board` class store a `HasWinner` property just to know if the game ended with a winner doesn't sit right with me; i think that logic should belong to one of its other methods
- the while-loop inside the `GameDriver.Run` method to repeatedly ask the players for their choices could be a bit more expressive about its condition
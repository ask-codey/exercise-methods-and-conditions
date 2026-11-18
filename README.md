# Exercise: Methods and Conditions

Exercise code for the lesson **Exercise: Methods and Conditions** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

Three small businesses need your help. Each one is a class of methods in the `MethodsExercise` project:

- `BackyardBasketball.cs`: winning percentages, points scored, shots needed, and keeping score
- `ClairesCookies.cs`: cookie orders, prices and sales tax
- `ElliotsYardCare.cs`: a lawn business's costs, profits, times and prices

Every method returns `0` (or `""`) for now. The comment above each method says what it should return, with examples. Replace the `return` line with your own code.

## Keeping score: ref and out

The last two methods in `BackyardBasketball.cs` practice *Passing Values to a Method: by Value and by Reference*.

- `AddBasket(ref int teamScore, bool isThree)` returns nothing. It adds 3 points to the caller's `teamScore` for a three-pointer (`isThree` is `true`), or 2 points for a two-pointer. For example, with `int score = 10;`, `AddBasket(ref score, true);` leaves `score` at `13`.
- `TryReadScore(string text, out int score)` checks a score the scorekeeper typed. When `text` is a whole number from 0 to 200 (0 and 200 included), it returns `true` and hands the number back through `score`: `TryReadScore("42", out int score)` returns `true` with `score` at `42`. For anything else (`"forty"`, `"-5"`, `"250"`), it returns `false` and hands back `0`.

For now, `AddBasket` does nothing and `TryReadScore` returns `false` with a score of `0`.

## Run it

```bash
dotnet run --project MethodsExercise
```

In Visual Studio, open `MethodsExercise.slnx` and press **Ctrl+F5**. `Program.cs` calls a few of your methods, so you can try them out.

## Check your work

```bash
dotnet test
```

In Visual Studio, use **Test > Run All Tests**.

At first almost every test fails: that is expected. Each method you finish turns its tests green. A failing test's message says which values it used and what it expected.

## Tips

- Work out an example by hand before you write the code.
- Use `decimal` for money, and give every value a meaningful name.
- A method you've written can call another one. If two methods need the same calculation, write it once.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.

namespace MethodsExercise;

public static class BackyardBasketball
{
    /*
     * Teams in the backyard basketball league want to know their
     * winning percentage.
     *
     * Each team knows how many games it has won and how many it
     * has lost. Return the percentage of games won, as a whole
     * number (drop anything after the decimal point).
     *
     * CalculateWinningPercentage(7, 3) -> 70
     * CalculateWinningPercentage(5, 5) -> 50
     * CalculateWinningPercentage(5, 10) -> 33
     */
    public static int CalculateWinningPercentage(int gamesWon, int gamesLost)
    {
        return 0;
    }

    /*
     * Work out how many points a player scored in a game.
     *
     * shotPercentage = the percentage of shots the player made
     * shotsTaken     = the number of shots the player took
     * isThree        = true if every shot was a three-pointer,
     *                  false if every shot was worth two points
     *
     * Return the points as a whole number (drop anything after
     * the decimal point).
     *
     * CalculatePointsScored(70, 10, false) -> 14
     * CalculatePointsScored(70, 10, true) -> 21
     * CalculatePointsScored(67, 15, false) -> 20
     */
    public static int CalculatePointsScored(int shotPercentage, int shotsTaken, bool isThree)
    {
        return 0;
    }

    /*
     * Work out the fewest shots a player must take to score the
     * points they want.
     *
     * shotPercentage = the percentage of shots the player expects to make
     * desiredScore   = the number of points the player wants to score
     * isThree        = true if the player shoots three-pointers,
     *                  false for two-pointers
     *
     * First work out how many baskets are needed (part of a basket
     * counts as a whole one), then how many shots it takes to make
     * that many baskets (again, round up).
     *
     * CalculateShotsRequired(50, 10, false) -> 10
     * CalculateShotsRequired(50, 10, true) -> 8
     * CalculateShotsRequired(75, 15, true) -> 7
     * CalculateShotsRequired(80, 18, true) -> 8
     * CalculateShotsRequired(67, 24, false) -> 18
     */
    public static int CalculateShotsRequired(int shotPercentage, int desiredScore, bool isThree)
    {
        return 0;
    }

    /*
     * Keeping score: the scorekeeper's tablet adds each basket to
     * the team's score as it happens.
     *
     * teamScore = the team's score so far, passed with ref, so this
     *             method changes the caller's own variable
     * isThree   = true for a three-pointer (3 points), false for a
     *             two-pointer (2 points)
     *
     * The method returns nothing: it adds the basket's points to
     * teamScore.
     *
     * int score = 10;
     * AddBasket(ref score, true);   // score is now 13
     * AddBasket(ref score, false);  // score is now 15
     */
    public static void AddBasket(ref int teamScore, bool isThree)
    {
        // Add 3 points for a three-pointer or 2 for a two-pointer to teamScore.
    }

    /*
     * The scorekeeper types a final score as text. Check it before
     * it's used.
     *
     * A score is good when the text is a whole number from 0 to 200,
     * 0 and 200 included. Then return true and hand the number back
     * through score.
     *
     * Anything else (text that isn't a whole number, a number below
     * 0, a number above 200): return false and hand back 0 through
     * score.
     *
     * TryReadScore("42", out int score)    -> true, score is 42
     * TryReadScore("200", out int score)   -> true, score is 200
     * TryReadScore("forty", out int score) -> false, score is 0
     * TryReadScore("-5", out int score)    -> false, score is 0
     * TryReadScore("250", out int score)   -> false, score is 0
     */
    public static bool TryReadScore(string text, out int score)
    {
        // An out parameter must be set before the method ends.
        score = 0;
        return false;
    }
}

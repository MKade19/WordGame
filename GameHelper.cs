namespace GameNamespace;

static class GameHelper {
    /// <summary>
    /// Returns true if <paramref name="firstPlayerWord"/> and <paramref name="secondPlayerWord"/> both match <paramref name="startWord"/>
    /// <param name="firstPlayerWord">Word that the first player has entered.</param>
    /// <param name="secondPlayerWord">Word that the second player has entered.</param>
    /// <param name="startWord">Main word of the game.</param>
    /// </summary>
    public static bool CompairingWords(string? startWord, string? firstPlayerWord, string? secondPlayerWord) {
        bool firstPlayerResult = DoesWordMatch(firstPlayerWord, startWord);
        bool secondPlayerResult = DoesWordMatch(secondPlayerWord, startWord);

        if (firstPlayerResult && !secondPlayerResult) {
            Console.WriteLine("First player has won!");
            return false;
        }

        if (!firstPlayerResult && secondPlayerResult) {
            Console.WriteLine("Second player has won!");
            return false;
        }

        Console.WriteLine("Draw! Enter next words.");
        return true;
    }

/// <summary>
/// Returns true if <paramref name="playerWord"/> matches <paramref name="startWord"/>
/// </summary>
/// <param name="playerWord">Word that the player has entered.</param>
/// <param name="startWord">Main word of the game.</param>
    static bool DoesWordMatch(string? playerWord, string? startWord) {
        int oldWordLength = playerWord.Length;

        for (int i = 0; i < playerWord.Length; i++) {
            int index = startWord.IndexOf(playerWord[i]);

            if (index == -1) {
                return false;
            }

            startWord = startWord.Remove(index, 1);
            playerWord = playerWord.Remove(i, 1);
            i--;
        }

        return oldWordLength != 0;
    }
}
namespace com.apavlidi.Game
{
    public class Game
    {
        private int counter;
        private int[] rolls = new int[23];
        private const int FRAMES = 10;

        public void Roll(int pins)
        {
            rolls[counter++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int currentRole = 0;

            for (int i = 0; i < FRAMES; i++)
            {
                if (IsAStrike(currentRole))
                {
                    score += 10 + getNextFrameTwoRolls(currentRole);
                    currentRole++;
                }
                else if (IsASpare(currentRole))
                {
                    score += 10 + getNextFrameRoll(currentRole);
                    currentRole += 2;
                }
                else
                {
                    score += rolls[currentRole] += rolls[currentRole + 1];
                    currentRole += 2;
                }
            }

            return score;
        }

        private int getNextFrameRoll(int currentRole)
        {
            return rolls[currentRole + 2];
        }

        private int getNextFrameTwoRolls(int currentRole)
        {
            return rolls[currentRole + 1] + rolls[currentRole + 2];
        }

        private bool IsASpare(int currentRole)
        {
            return rolls[currentRole] + rolls[currentRole + 1] == 10;
        }

        private bool IsAStrike(int currentRole)
        {
            return rolls[currentRole] == 10;
        }
    }
}
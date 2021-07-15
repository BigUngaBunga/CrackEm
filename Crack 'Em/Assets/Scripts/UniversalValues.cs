using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public static class UniversalValues
    {
        private static string highestLevel = "HighestLevel";
        public static int HighestLevel { get { return PlayerPrefs.GetInt(highestLevel); } }

        public static int ModifiedHighestLevel => HighestLevel + 1;

        public static void ResetHighestLevel() => PlayerPrefs.SetInt(highestLevel, 0);
        public static void IncrementHighestLevel() => PlayerPrefs.SetInt(highestLevel, HighestLevel + 1);
        public static void DecrementHighestLevel()
        {
            if (HighestLevel < 0)
                PlayerPrefs.SetInt(highestLevel, 0);
            else
                PlayerPrefs.SetInt(highestLevel, HighestLevel - 1);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class ResetPlayerPrefs : MonoBehaviour
    {
        public void ResetHighestLevel()
        {
            UniversalValues.ResetHighestLevel();
            PrintValue();
        }

        public void IcreaseHighestLevel()
        {
            UniversalValues.IncrementHighestLevel();
            PrintValue();
        }

        public void DecreaseHighestLevel()
        {
            UniversalValues.DecrementHighestLevel();
            PrintValue();
        }

        private void PrintValue()
        {
            Debug.Log("Value is now: " + UniversalValues.HighestLevel);
        }
    }
}


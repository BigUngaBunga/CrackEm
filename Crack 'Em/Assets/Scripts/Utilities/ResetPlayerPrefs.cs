using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class ResetPlayerPrefs : MonoBehaviour
    {
        public void ResetHighestLevel()
        {
            PlayerPrefs.SetInt("HighestLevel", 0);
        }
    }
}


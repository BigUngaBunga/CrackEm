using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrackEm
{
    public class PlayButton : MonoBehaviour
    {
        public void PlayNewestLevel()
        {
            SceneManager.LoadScene(UniversalValues.ModifiedHighestLevel);
            Debug.Log("Loaded scene " + UniversalValues.ModifiedHighestLevel);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class RefreshLevelButtons : MonoBehaviour
    {
        [SerializeReference] GameObject LevelButtonParent;

        public void RefreshButtons()
        {
            LevelButton[] buttons = LevelButtonParent.GetComponentsInChildren<LevelButton>();
            foreach (LevelButton button in buttons)
                button.CheckIfActive();
        }
    }
}



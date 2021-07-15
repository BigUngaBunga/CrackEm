using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] GameObject canvas;

        public void OpenMenu()
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
        }

        public void CloseMenu()
        {
            Time.timeScale = 1;
            canvas.SetActive(false);
        }

        public void ToggleMenu()
        {
            if (canvas.activeSelf)
                CloseMenu();
            else
                OpenMenu();
        }
    }
}



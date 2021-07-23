using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class GameFloor : MonoBehaviour
    {
        [SerializeField] private bool isSafetyNetActive;
        [SerializeField] private float safetyNetDuration;
        private BoxCollider2D boxCollider;
        private SpriteRenderer spriteRenderer;

        private void Start()
        {
            boxCollider = GetComponent<BoxCollider2D>();
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        public void ActivateSafetyNet()
        {
            Debug.Log("Activated Net");
            HandleSafetyNet(true);
            Invoke(nameof(DeactivateSafetyNet), safetyNetDuration);
        }

        private void DeactivateSafetyNet() => HandleSafetyNet(false);

        private void HandleSafetyNet(bool isActive)
        {
            isSafetyNetActive = isActive;
            spriteRenderer.enabled = isActive;
            boxCollider.isTrigger = !isActive;
        }
    }
}



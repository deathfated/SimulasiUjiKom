using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Gameplay
{
    public class InputRaycast : MonoBehaviour
    {
        private Camera cam;

        private void Awake()
        {
            cam = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastObject(Input.mousePosition);
            }
        }

        private void RaycastObject(Vector2 screenPos)
        {
            Vector2 worldPosition = cam.ScreenToWorldPoint(screenPos);
            var hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if(hit.collider != null)
            {
                IRaycastable raycastableObj = hit.collider.GetComponent<IRaycastable>();
                raycastableObj?.OnRaycasted();
            }
        }
    }
}
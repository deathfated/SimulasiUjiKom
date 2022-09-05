using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Gameplay
{
    public class InputRaycast : MonoBehaviour
    {
        public Camera cam;

        private void Start()
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100))
            {
                Transform objectHit = hit.transform;

                //do
            }
        }
    }
}
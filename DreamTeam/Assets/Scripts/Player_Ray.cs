using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Player_Ray : MonoBehaviour
    {

        public bool Flashlight = false;

        void Update()
        {

            Debug.DrawRay(transform.position, transform.forward * 3f, Color.black);
            RaycastHit hit;
            Ray Ray_ = new Ray(transform.position, transform.forward);

            int Flashlight_ = 1 << 9;

            if (Physics.Raycast(Ray_, out hit, 3f, Flashlight_))
            {
                Flashlight = true;
                if (Input.GetKeyDown(KeyCode.E))
                {

                    Destroy(hit.collider.gameObject);
                }
            }
            else
            {
                Flashlight = false;
            }

        }
    }

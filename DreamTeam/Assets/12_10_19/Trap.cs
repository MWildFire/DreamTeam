using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Trap : MonoBehaviour
    {
        public GameObject Platform1;
        public bool Ok1 = true;
        public float z1 = 9.5f;
        public bool Close1 = false;
        private Vector3 move;
        public bool ravno8 = false;
        public PlayerController Player;

        void Start()
        {
            z1 = Platform1.transform.position.z;
            move = Platform1.transform.position;
        }


        void Update()
        {
            if (Ok1 == true)
            {


                if (ravno8)
                {
                    Platform1.SetActive(true);
                }
                else if(ravno8 == false)
                {
                    Platform1.SetActive(false);
                }
                if (z1 >= 8.5f && Close1 == false)
                {
                    z1 -= 0.05f;
                }
                else if (z1 <= 8.5f && Close1 == false)
                {
                    Close1 = true;
                }
                if (Close1 == true && z1 <= 9.5f)
                {
                    z1 += 0.05f;
                }
                else if (Close1 == true && z1 >= 9.5f)
                {
                    Close1 = false;
                    StartCoroutine("CD1");
                    Ok1 = false;
                }

            }
            if(Player.Player.transform.position.y < 5)
            {
                ravno8 = false;
            }
            move.z = z1;
            Platform1.transform.position = move;
        }
        IEnumerator CD1()
        {
            yield return new WaitForSeconds(5.0f);

            Ok1 = true;
        }
    }
}
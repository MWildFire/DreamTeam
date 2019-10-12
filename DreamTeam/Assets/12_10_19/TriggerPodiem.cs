using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class TriggerPodiem : MonoBehaviour
    {

        public Trap TrapTrigger;
        private bool _inZone = false;
        private Vector3 Movement;
        public float move_y = 0;
        public GameObject Lift;
        public float KogdaPodnato = 0;
        public float KogdaOpuscheno = 0;

        void Start()
        {
            Movement = Lift.transform.position;
            move_y = Movement.y;
        }


        void Update()
        {
            if (_inZone == true && move_y < KogdaPodnato)
            {
                move_y += 0.05f;
            }
            else if (_inZone == false && move_y > KogdaOpuscheno)
            {
                move_y -= 0.05f;
            }
            else if (_inZone == false && move_y <= KogdaOpuscheno)
            {
                move_y = KogdaOpuscheno;
            }
            Movement.y = move_y;
            Lift.transform.position = Movement;

            if(move_y >= 8)
            {
                TrapTrigger.ravno8 = true;
            }
        }

        void OnTriggerEnter(Collider Other)
        {
            if (Other.tag == "Player")
            {
                _inZone = true;
            }
        }

        void OnTriggerExit(Collider Other)
        {
            if (Other.tag == "Player")
            {
                _inZone = false;
            }
        }


    }
}
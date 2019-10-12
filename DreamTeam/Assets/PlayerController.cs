using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 156;
        private float speed1 = 156;
        public Rigidbody rb;
        public GameObject Player;
        public GameObject Camera;
        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();

        }

        // Update is called once per frame
        void Update()
        {
            float moveHor = Input.GetAxis("Horizontal");
            float moveVer = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(moveHor, 0, moveVer);
            rb.AddForce(move);


        }
    }
}
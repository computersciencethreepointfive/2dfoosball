
using UnityEngine;
using System.Collections;


namespace fbmovementtest
{
    public class EasyMove : MonoBehaviour
    {
        public float Speed = 0f;
        private float movex = 0f;
        private float movey = 0f;
        //use for initialization
        void start()
        {
        }
        //Update is called once per frame
        void FixedUpdate()
        {
            movex = input.GetAxis("Horizontal");
            movey = input.GetAxis("Vertical");
            rigidbody2D.velocity = new Vector2(movex * Speed, movey * Speed);
        }
    }
}

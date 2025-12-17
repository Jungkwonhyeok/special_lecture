using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P1NGMU
{
    public class Background : MonoBehaviour
    {
        public float mapSpeed;
        public float mapSizeZ;
        private Vector3 startPos;

        void Start()
        {
            startPos = this.transform.position;
        }

        void Update()
        {
            float newPostion = Mathf.Repeat(this.transform.position.z + Time.deltaTime + mapSpeed, mapSizeZ);
            transform.position = new Vector3(startPos.x, startPos.y, newPostion);
        }
    }
}

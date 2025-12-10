using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P1NGMU
{
    public class Player : MonoBehaviour
    {
        //총알 딜레이
        public float bulletTime = 0.1f;
        //총알 딜레이 만큼 시간이 지났는지 체크
        public float reloadTime = 0f;
        Rigidbody thisRigi;
        // 플레이어 이동 속도
        public float speed = 2.0f;
        // 총알 프리퓁
        public GameObject objBullet;
        // 총알이 생성 될 위치
        public Transform BulletPoint;


        void Update()
        {
            Move();
        }

        void Start()
        {
            thisRigi = GetComponent<Rigidbody>();
        }

        public void Move()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(moveX, 0.0f, moveZ);
            thisRigi.velocity = move * speed;

            Vector3 poslnWorld = Camera.main.WorldToScreenPoint(this.transform.position);

            float posX = Mathf.Clamp(poslnWorld.x, 0, Screen.width);
            float posZ = Mathf.Clamp(poslnWorld.y, 0, Screen.height);

            Vector3 poslnScreen = Camera.main.ScreenToWorldPoint(new Vector3(posX, posZ, 0));

            thisRigi.position = new Vector3(poslnScreen.x, 0, poslnScreen.z);
        }
    }
}
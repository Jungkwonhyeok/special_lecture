using PlasticGui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P1NGMU
{
    public class Enemy2 : MonoBehaviour
    {
        public float speed;
        public float ThrowPower = 50.0f;
        private GameObject Player;
        public float delay = 0.5f;
        public float hp = 1.0f;

        void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");

            if (Player == null)
            {
                Debug.Log("게임 Player 존재하지 않습니다.");
            }

            this.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            Invoke("ThrowPlayer", Random.Range(0.5f, 1.5f));
        }

        void ThrowPlayer()
        {
            Vector3 dir = Player.transform.position - this.transform.position;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(dir.x, 0, 0) * ThrowPower);
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                return;
            }

            if (other.CompareTag("Bullet"))
            {
                hp -= 1f;
                if (hp < 1.0f)
                {
                    Destroy(gameObject);
                }
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
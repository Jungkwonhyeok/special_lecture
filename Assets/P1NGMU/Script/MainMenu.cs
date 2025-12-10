using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P1NGMU
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject MenualBack;
        public GameObject Menual;
        public GameObject Story;
        public void BtnManual()
        {
            MenualBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenMenual", 1.8f);
        }

        public void BtnStory()
        {
            MenualBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenStory", 1.8f);
        }

        public void BtnBack(int num)
        {
            switch (num)
            {
                case 0: //Menual
                    Menual.GetComponent<Animator>().SetTrigger("Close");
                    Invoke("OpenMenuBack", 1.8f);
                    break;
                case 1: //Story
                    Story.GetComponent<Animator>().SetTrigger("Close");
                    Invoke("OpenMenuBack", 1.8f);
                    break;
            }
        }

        void OpenMenual()
        {
            Menual.SetActive(true);
            Menual.GetComponent<Animator>().SetTrigger("Open");
        }

        void OpenMenuBack()
        {
            MenualBack.GetComponent<Animator>().SetTrigger("Open");
        }
        void OpenStory()
        {
            Story.SetActive(true);
            Story.GetComponent<Animator>().SetTrigger("Open");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public float hold = 5f;


    void Start(){
         cam2.SetActive(false);
         StartCoroutine(Switch());
    }

    private IEnumerator Switch(){
        yield return new WaitForSeconds(hold);
        cam1.SetActive(false);
        cam2.SetActive(true);
    }

    private IEnumerator SwitchBack(){
        yield return new WaitForSeconds(hold);
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("main")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("aerial")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

    }
}

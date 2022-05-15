using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // private void Awake()
    // {

    // } 
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }
    [SerializeField] float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }
}

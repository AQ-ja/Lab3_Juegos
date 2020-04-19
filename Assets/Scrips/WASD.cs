using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float speed = 5;
    public float jumpforce = 5;
    // Update is called once per frame
    void Start()
    {
        GameObject Personaje = GameObject.Find("PlayerController");
    }
    private void FixedUpdate()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
       
    }
}



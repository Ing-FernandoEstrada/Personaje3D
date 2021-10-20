using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{

    // Animation controller

    public float velocidadP = 3.0f;
    public float rotateP = 50.0f;
    public float px, py;
    private Animator miAnim;
    void Start()
    {
        miAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //capturrar los eventos del teclado

        px = Input.GetAxis("Horizontal");
        py = Input.GetAxis("Vertical");

        transform.Translate(0, 0, py * Time.deltaTime * velocidadP);

        // calcular el despalzamiento para girar

        transform.Rotate(0, px * Time.deltaTime * rotateP, 0);

        //Acceder a los paramentros del controller

        miAnim.SetFloat("Vel-X", px);
        miAnim.SetFloat("Vel-Y", py);
    }
}

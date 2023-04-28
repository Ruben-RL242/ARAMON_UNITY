using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "portal1")
        {
            Vector3 posicioncamara = new Vector3(0, -13.11f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-3.13f, -10.32f, 0);
            this.transform.position = posicionPlayer;
        }
        if (obj.gameObject.tag == "portal2")
        {
            Vector3 posicioncamara = new Vector3(0, -5.54f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-3.23f, -8.64f, 0);
            this.transform.position = posicionPlayer;
        }
    }


}

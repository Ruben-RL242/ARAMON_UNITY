using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    private Vector2 dirMov;
    public float velMov;
    public Rigidbody2D rb;
    public Animator anim;

    // Update is called once per frame
    void FixedUpdate() {
        Movimiento();
        Animacionesplayer();
    }

    private void Animacionesplayer() {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        dirMov = new Vector2(movX, movY).normalized;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(dirMov.x * (velMov*2), dirMov.y * (velMov * 2));
            anim.SetBool("shift", true);
        }
        else
        {
            rb.velocity = new Vector2(dirMov.x * velMov, dirMov.y * velMov);
            anim.SetBool("shift", false);
        }
    }

    private void Movimiento() {
        anim.SetFloat("movX", dirMov.x);
        anim.SetFloat("movY", dirMov.y);
    }

}

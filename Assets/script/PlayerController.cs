using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer spr;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDerecha()
    {
      //transform.position= new Vector3(transform.position.x+0.5f,transform.position.y,transform.position.z);
      
      transform.Translate(Vector3.right);
      spr.flipX= false;
      anim.SetBool("Run",true);
    }

    void OnIzquierda()
    {
      //transform.position= new Vector3(transform.position.x+0.5f,transform.position.y,transform.position.z);
      transform.Translate(Vector3.left);
      spr.flipX= true;
      anim.SetBool("Run",true);
    }
}

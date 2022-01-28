using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictursController : MonoBehaviour
{
  private float tiempo=0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      if(tiempo>=0.1f){
            transform.position= new Vector3(transform.position.x,transform.position.y-0.3f,transform.position.z);
            tiempo=0;
      }
      tiempo+=Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other){
      if(other.collider.CompareTag("Player")){
        Debug.Log("choco");
        Destroy(gameObject);
      }

      if(other.collider.CompareTag("Piso")){
        Debug.Log("fallo");
        Destroy(gameObject);
      }
    }
}

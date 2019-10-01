using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoFisica1 : MonoBehaviour
{

    Rigidbody rigidiBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //aplicar força ao clicar
/*      if(Input.GetMouseButtonDown(0)){
        rigidiBody.AddForce(transform.forward * 30, ForceMode.Impulse);
      }   */
    }

   /*public void  OnCollisionStay(Collision outro){
         print("Colisão comecou com " +gameObject.name);
    }*/


    public void  OnCollisionEnter(Collision outro){
        print("Colisão comecou com "+gameObject.name);
    }

    /*public void  OnCollisioExit(Collision outro){    
        print("Colisão comecou com " +gameObject.name + "acabou");
    }*/

   /*public void OnTriggerEnter(Collider outro){
       //marcar box trigger em esfera rosa
        print("Trigger disparada");
    }*/
}

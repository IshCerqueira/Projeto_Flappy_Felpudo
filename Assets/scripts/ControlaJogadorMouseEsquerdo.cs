using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogadorMouseEsquerdo : MonoBehaviour {

    public bool comecou;
    public int vida;
    
  

    Rigidbody2D corpoJogador;
  Vector2 forcaImpulso = new Vector2(0, 500f);

  void Start () { 
    corpoJogador = GetComponent<Rigidbody2D> ();
        vida = 3;
  }
  
  void Update () {

    if (Input.GetButtonDown ("Fire1")) { 
    
      if (!comecou) {
        comecou = true;
        corpoJogador.isKinematic = false;
      }

      corpoJogador.velocity = new Vector2 (0, 0);
      corpoJogador.AddForce(forcaImpulso);    
    }
    
  }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            vida--;
            Debug.Log(vida);
        }

    }


}

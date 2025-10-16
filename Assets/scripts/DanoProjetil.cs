using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class DanoProjetil : MonoBehaviour
{

    [SerializeField] private DadosDoJogador _dadosDoJogador;
    [SerializeField] private DadosdoChefe _dadosDoChefe;
  

   
    private void Start()
    {
        _dadosDoChefe = GameObject.Find("BossData").GetComponent<DadosdoChefe>();
        _dadosDoJogador = GameObject.Find("Felpudo_Flying0001").GetComponent<DadosDoJogador>();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            _dadosDoJogador.AumentarScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Chefe")
        {
            _dadosDoChefe.ReduzirVida();

            if ( _dadosDoChefe.vidaChefe == 2)
            {
                _dadosDoChefe.AumentarVelocidade();
                Destroy(gameObject);
            }
          
            else
            {
                Destroy(gameObject);
            }

        }

    }

}
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class DanoProjetil : MonoBehaviour
{

    [SerializeField] private DadosDoJogador _dadosDoJogador;

    private void Start()
    {
        _dadosDoJogador = GameObject.Find("Felpudo_Flying0001").GetComponent<DadosDoJogador>();   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            _dadosDoJogador.aumentarScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }

}
 
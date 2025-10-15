using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDoChefe : MonoBehaviour
{

    public Transform chefe;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 3f;
        StartCoroutine(Mover());
    }


    IEnumerator Mover()
    {
        
            while (chefe.position.x > 0)
            {
                // Move o inimigo da direita para a esquerda
                chefe.transform.Translate(Vector2.left * velocidade * Time.deltaTime);

                yield return null; // Espera o próximo frame

                if((chefe.position.x < 0))
                {
                yield return new WaitForSeconds(1.0f);
                break;
                }
            }

         

        while (chefe.position.x < 0)
            {
                UpMove();

            yield return null; // Espera o próximo frame
            
            if(chefe.position.x < 0 && chefe.position.y >= 3)
            {
                break;
            }
        }

        while (chefe.position.x < 0 )
        {
            DownMove();

            yield return null; // Espera o próximo frame

            if (chefe.position.x < 0 && chefe.position.y <= -3)
            {
                StartCoroutine(Mover());
                break;
            }
        }

    }

    void UpMove()
    {
        
        chefe.transform.Translate(Vector2.up * velocidade * Time.deltaTime);
    }

    void DownMove()
    {
        chefe.transform.Translate(Vector2.down * velocidade * Time.deltaTime);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Rank dos Cômodos
 * Sala = 11;
 * Cozinha = 2;
 * Corredor = 0;
 * Banheiro = 5;
 * Quarto = 7;
 */

public class Connect : MonoBehaviour
{
    public GameObject tier0;
    public GameObject tier1;
    
    public GameObject portal;

    public string location;
    static int rank = 0;
    static int insanidade = 0;
    public int comodo;


    private void OnTriggerEnter(Collider other)
    {
        insanidade++;
        rank += comodo;
        Debug.Log(location + " " + rank + ", insanidade: " + insanidade);
        CasaFantasma();
        Insanidade();
    }

    void Insanidade()
    {
        if (insanidade > 2)
        {
            //tier0.SetActive(false);
          //  tier1.SetActive(true);
        }
    }

    void CasaFantasma()
    {
        if (location == "Cozinha")
        { if(rank == 26)
            { Debug.Log("Vai para Banheiro da casa fantasma");
                portal.SetActive(true);
            }
        }

        if (location == "Banheiro")
        {
            if (rank == 29)
            { Debug.Log("Vai para Sala da casa fantasma"); }
            else if (rank == 21|| rank == 23)
              Debug.Log("Vai para Quarto da casa fantasma");
        }

        if (location == "Quarto")
        {
            if (rank == 31 || rank == 23 || rank == 25)
            { Debug.Log("Vai para Sala da casa fantasma"); }
        }

        if (location == "Sala")
        {
            if (rank == 29 || rank == 31)
            { Debug.Log("Vai para Sala da casa fantasma"); }
        }
    }
}
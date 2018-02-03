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

    public string location;
    static int rank = 0;
    static int insanidade = 0;
    public int comodo;

    private void OnTriggerEnter(Collider other)
    {
        insanidade++;
        rank += comodo;
        Debug.Log(location + " " + rank);
        CasaFantasma();
    }

    void CasaFantasma()
    {
        if (location == "Cozinha")
        { if(rank == 26)
            { Debug.Log("Vai para Banheiro da casa fantasma"); }
        }

        if (location == "Banheiro")
        {
            if (rank == 29)
            { Debug.Log("Vai para Sala da casa fantasma"); }
            else Debug.Log("Vai para Quarto da casa fantasma");
        }

        if (location == "Quarto")
        {
            if (rank == 31)
            { Debug.Log("Vai para Cozinha da casa fantasma"); }
            else Debug.Log("Vai para Sala da casa fantasma");
        }

        if (location == "Sala")
        {
            if (rank == 29 || rank == 31)
            { Debug.Log("Vai para Sala da casa fantasma"); }
        }
    }
}
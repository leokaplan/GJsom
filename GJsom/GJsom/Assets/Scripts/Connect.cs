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

public class Connect : MonoBehaviour {

    public string location;
    static int rank;
    static int i=0;

    private void OnTriggerEnter(Collider other)
    {
        i++;
        Debug.Log(location + " " + i);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class pawnScript : MonoBehaviour {

    public Transform pawnPrefab;
    public int nPawns;
    List<int> spawned = new List<int>();

    void Start ()
    {
        for (int i = 0; i < nPawns; i++)
        {
            int x = (int)(Random.value * 10);
            int z = (int)(Random.value * 4);

            if (i > 0)
            {
                 while(spawned.Contains(10 * x + z))
                {
                    x = (int)(Random.value * 10);
                    z = (int)(Random.value * 4);
                }
            }
            Instantiate(pawnPrefab, new Vector3(x, 2, z), Quaternion.identity);
            spawned.Add(10 * x + z);
        }

    }
}

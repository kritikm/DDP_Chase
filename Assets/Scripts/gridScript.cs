using UnityEngine;
using System.Collections;

public class gridScript : MonoBehaviour {

    
    public Transform cellPrefab;
    public Vector3 size;

    void Start ()
    {
        CreateGrid();
	}
	
    void CreateGrid()
    {
        for(int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.z; j++)
                Instantiate(cellPrefab, new Vector3(i + (float)0.1, 1, j + (float)0.1), Quaternion.identity);
        }
    }
}

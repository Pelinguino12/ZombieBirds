using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGenerator : MonoBehaviour {

    [SerializeField] Transform prefabColumna;
    [SerializeField] float comienzo = 2.0f;
    [SerializeField] float crear = 4.0f;

    // Use this for initialization
    void Start () {
        //CREAR COLUMNA
        InvokeRepeating("CreateColumn", comienzo, crear);
    }

    void CreateColumn()
    {
        if (GameConfig.IsPlaying())
        {
            Instantiate(prefabColumna, transform.position, Quaternion.identity);
        }
    }
   
}

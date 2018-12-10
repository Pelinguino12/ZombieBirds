using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandeGenerator : MonoBehaviour {
    [SerializeField] Transform prefabGrande;
    [SerializeField] float comienzo = 4.0f;
    [SerializeField] float crear = 4.0f;
    // Use this for initialization
    void Start ()
    {
        //CREAR GRANDE
        InvokeRepeating("CreateGrande", comienzo, crear);
    }
    void CreateGrande()
    {
        if (GameConfig.IsPlaying())
        {
            Instantiate(prefabGrande, transform.position, Quaternion.identity);
        }
    }
}

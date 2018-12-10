using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour 
{
    [SerializeField] int speed = 3;
    [SerializeField] float maxUp = 5.0f;
    [SerializeField] float maxDown = -5.0f;
    [SerializeField] float posicionAleatoria;
    // Use this for initialization
    void Start ()
    {
        posicionAleatoria = Random.Range(maxDown, maxUp);
        Vector3 position = new Vector3(transform.position.x, posicionAleatoria, transform.position.z);
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameConfig.IsPlaying())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < -25)
            {
                Destroy(gameObject);
            }
        } 
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cours : MonoBehaviour
{
    [SerializeField] private Vector3 _deplacement;
    [SerializeField] private float vitesse;
    // Start is called before the first frame update
    void Start()
    {
        vitesse = Random.Range(0f, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, vitesse * Time.deltaTime, Space.Self);


    }
}

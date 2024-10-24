using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboBrilhante : MonoBehaviour

{
   [SerializeField] private float rx;
   [SerializeField] private float ry;
   [SerializeField] private float rz;
   [SerializeField] private float velocidade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rx * velocidade * Time.deltaTime, ry * velocidade * Time.deltaTime, rz * velocidade * Time.deltaTime);
    }
}

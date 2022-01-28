using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Posición global: {transform.position}");
        Debug.Log($"Posición local: {transform.localPosition}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

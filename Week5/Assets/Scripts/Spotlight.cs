using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour
{

    public Light isik;

    // Start is called before the first frame update
    void Start()
    {
        isik = this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isik.enabled = !isik.enabled;
        }

    }
}

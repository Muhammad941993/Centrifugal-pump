using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMeter : MonoBehaviour
{
    [SerializeField] Rotation Tap;
    [SerializeField] Rotation WaterSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        MeterFlow();
    }
    // Update is called once per frame
  

    void MeterFlow()
    {
        if (transform.localScale.z > 1) return;
        if(Tap.GetButtonState && WaterSource.GetButtonState)
        {
            transform.localScale += new Vector3(0, 0, .1f) * Time.deltaTime;
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] Rotation pumpSpeed;
    Vector3 newScale = new Vector3(.2f, 0, 0);
   

    public void MoveUp()
    {
        if ( !pumpSpeed.GetButtonState ) return;
        if (transform.localScale.x <= 0.2) 
        {
            gameObject.SetActive(false);
            return;
        } 
        transform.localScale -= newScale;
    }

    public void MoveDown()
    {
        if (!pumpSpeed.GetButtonState) return;
        if (transform.localScale.x >= 2) return;
        transform.localScale += newScale;
        gameObject.SetActive(true);
    }
}

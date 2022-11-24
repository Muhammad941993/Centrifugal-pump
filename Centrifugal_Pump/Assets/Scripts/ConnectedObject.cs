using UnityEngine;
using UnityEngine.Events;

public class ConnectedObject : MonoBehaviour
{
    [SerializeField] UnityEvent ConnectOn;
    [SerializeField] UnityEvent ConnectOff;
    Rotation rotation;
    private void Start()
    {
        rotation = GetComponent<Rotation>();
    }
  

    private void Update()
    {
       
    }


    public void  Updateobject()
    {
        if (rotation.GetButtonState)
        {
            ConnectOn?.Invoke();
        }
        else
        {
            ConnectOff?.Invoke();
        }
    }
 
}

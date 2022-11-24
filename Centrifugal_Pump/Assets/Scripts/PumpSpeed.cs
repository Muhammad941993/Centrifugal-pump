using System.Collections;
using UnityEngine.Events;
using UnityEngine;
using TMPro;

public class PumpSpeed : MonoBehaviour
{
    [SerializeField] Rotation PumbPower;
    [SerializeField] Rotation Power;
    [SerializeField] TextMeshProUGUI TextPumpSpeed;
    Rotation Rotation;
    [SerializeField] UnityEvent PumpActionIncrease;
    [SerializeField] UnityEvent PumpActionDecrease;

    int CurrentSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Rotation = GetComponent<Rotation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CalculatePumpSpeed()
    {
        if (!PumbPower.GetButtonState) return;
        if (!Power.GetButtonState) return;

        int NewSpeed =Mathf.RoundToInt( Rotation.GetCurrentDegree / 27) * 141;
        SpeedEffect(NewSpeed);
        CurrentSpeed = NewSpeed;
        TextPumpSpeed.text = NewSpeed.ToString();
    }

    void SpeedEffect(int newSpeed)
    {
        if(newSpeed > CurrentSpeed)
        {
            PumpActionIncrease?.Invoke();
        }
      
    }

}

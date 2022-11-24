using UnityEngine;
using UnityEngine.Events;

public class Rotation : MonoBehaviour
{
    enum RotateIn { X, Y, Z }

    [SerializeField] float Degree = 0;
    [SerializeField] RotateIn Rotatein;
    [SerializeField] float MaxDegree = 360;
    [SerializeField] float MinDegree = 0;
    [SerializeField] bool ClockWise = true;
    [SerializeField] bool OneClickButton = true;
    [SerializeField] UnityEvent RotationAction;
   public bool ButtonOn = false;
    Vector3 Axi;
    
    float CurrentDegree = 0;
    private void Start()
    {
        GetTheAxie();
    }

    private void OnMouseDown()
    {
        StartRotaion();

    }

    public void StartRotaion()
    {
        RotateInDirection(Degree, ClockWise);
    }
    private void RotateInDirection(float degree, bool direction)
    {
        if (!IfRotationInRange()) return;

        float newdegree = GetDirection(direction) * degree;
        gameObject.transform.Rotate(Axi, newdegree);
        CurrentDegree += newdegree;

      if(OneClickButton)  UpdateRotationDirection();

        UpdateButtonState();

        RotationAction?.Invoke();
    }

    private int GetDirection(bool direction)
    {
        return (direction) ? 1 : -1;
    }

    public void RotateRight()
    {
        if (CurrentDegree == MaxDegree) return;
        RotateInDirection(Degree, true);
    }
    public void RotateLeft()
    {
        if (CurrentDegree == MinDegree) return;
        RotateInDirection(Degree, false);
    }

   
    bool IfRotationInRange()
    {
        return ((CurrentDegree <= MaxDegree) && (CurrentDegree >= MinDegree));
    }

    void UpdateRotationDirection()
    {

        if (OneClickButton || CurrentDegree >= MaxDegree || CurrentDegree <= MinDegree)
        {
            ClockWise = !ClockWise;
        }
    }

    void UpdateButtonState()
    {
        if (CurrentDegree == 0)
        {
            ButtonOn = false;
        }
        else
        {
           
            ButtonOn = true;
        }
    }
    public bool GetButtonState => ButtonOn;
    public float GetCurrentDegree => CurrentDegree;
    public void SetDegree(float degree) { Degree = degree; }
    void GetTheAxie()
    {
        switch (Rotatein)
        {
            case RotateIn.X:
                Axi = Vector3.right;
                break;
            case RotateIn.Y:
                Axi = Vector3.up;
                break;
            case RotateIn.Z:
                Axi = Vector3.forward;
                break;

        }
    }

    
}

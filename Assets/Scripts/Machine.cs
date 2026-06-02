using UnityEngine;
using UnityEngine.EventSystems;

public class Machine : MonoBehaviour, IRobot
{
    public virtual void Run()
    {
        Debug.Log("행동합니다.");
    }
}

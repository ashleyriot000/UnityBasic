using UnityEngine;

public class BallDetector : MonoBehaviour
{
    public GripperController controller;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name}");
        if (other.tag != "Ball")
            return;

        if (other.attachedRigidbody.isKinematic)
            return;

        controller.PickUp();
    }

}

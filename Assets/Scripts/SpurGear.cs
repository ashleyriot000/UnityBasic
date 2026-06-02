using UnityEngine;

public class SpurGear : MonoBehaviour
{
    public Animator anim;

    private bool isOn;
    private float rotateSpeed = 0f;


    public void Rotate(bool isOn)
    {
        this.isOn = isOn;
        anim.SetFloat("Speed", isOn ? rotateSpeed : 0f);
    }
    public void ChangeSpeed(float speed)
    {
        this.rotateSpeed += speed;
        anim.SetFloat("Speed", isOn ? rotateSpeed : 0f);
    }
}

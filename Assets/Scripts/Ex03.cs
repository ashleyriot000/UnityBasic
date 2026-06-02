using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public MeshRenderer mr;
    public Color enterColor;

    private Color defaultColor;

    private void Start()
    {
        if (mr == null)
        {
            mr = GetComponent<MeshRenderer>();
        }
        if (mr != null)
        {
            defaultColor = mr.material.color;
        }
    }

    //캡슐이 영역 안에 들어오면 큐브 색을 빨간색 혹은 지정된 색으로 바꾼다.
    private void OnTriggerEnter(Collider other)
    {
        if (mr == null)
            return;

        mr.material.color = enterColor;
    }

    //캡슐이 영역 밖으로 나가면 큐브색을 파랑색 혹은 원래색으로 바꾼다.
    private void OnTriggerExit(Collider other)
    {
        if (mr == null)
            return;

        mr.material.color = defaultColor;
    }
}

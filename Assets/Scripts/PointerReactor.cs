using UnityEngine;
using UnityEngine.EventSystems;

public class PointerReactor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public MeshRenderer[] meshRenderers;
    public Color enterColor;
    public Color exitColor;
    public bool enableEmission;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Foreach 반복문 사용 예제
        foreach (MeshRenderer r in meshRenderers)
        {
            r.material.color = enterColor;
            if (enableEmission)
                r.material.EnableKeyword("_EMISSION");
        }

        transform.localScale = Vector3.one * 1.5f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //foreach (MeshRenderer r in meshRenderers)
        //{
        //    r.material.color = exitColor;
        //}

        //for문 예제
        for (int i = 0; i < meshRenderers.Length; ++i)
        {
            meshRenderers[i].material.color = exitColor;
            if(enableEmission)
                meshRenderers[i].material.DisableKeyword("_EMISSION");
        }

        transform.localScale = Vector3.one;
    }

    void Start()
    {
        foreach (MeshRenderer r in meshRenderers)
        {
            r.material.color = exitColor;
        }
    }
}

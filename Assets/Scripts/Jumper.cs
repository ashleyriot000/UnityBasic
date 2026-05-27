using UnityEngine;

public class Jumper : MonoBehaviour
{
    public MeshRenderer meshRenderer;   //매쉬 그리는 컴포넌트
    public float moveSpeed = 1f;    //점프 속도
    public float maxHeight = 3f;    //최대 점프 높이
    public float minHeight = 0f;    //최저 높이
    public bool isJumping = false;  //점프중인지 여부
    public Color jumpColor;         //점프하는 동안의 컬러
    public Color fallColor;         //떨어지는 동안의 컬러

    void Start()
    {
        //매쉬 그리는 컴포넌트가 비어있다면
        if(meshRenderer == null)
        {
            //찾아서 넣어줘라.
            meshRenderer = GetComponent<MeshRenderer>();
        }
        //점프중이면
        if(isJumping == true)
        {
            //점프중인 컬러로 적용.
            meshRenderer.material.color = jumpColor;
        }
        //그게 아니면
        else
        {
            //떨어지는 컬러로 적용.
            meshRenderer.material.color = fallColor;
        }
        //transform.Translate(Vector3.up * moveSpeed);
    }

    void Update()
    {
        if(isJumping == true)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if(transform.position.y > maxHeight)
            {
                isJumping = false;
                meshRenderer.material.color = fallColor;
            }
        }
        else
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            if (transform.position.y < minHeight)
            {
                isJumping = true;
                meshRenderer.material.color = jumpColor;
            }
        }
        
    }
}

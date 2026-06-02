using Unity.VisualScripting;
using UnityEngine;

public class Classes : MonoBehaviour
{
    public struct MeshStruct
    {
        public int value;
    }
    public class MeshClass
    {
        public int value;
    }

    private void Start()
    {
        //구조체 : 값 타입
        MeshStruct s0 = new MeshStruct();
        s0.value = 15;
        MeshStruct s1 = new MeshStruct();
        s1.value = 30;
        Debug.Log($"Before : S0의 값은 {s0.value}, S1의 값은 {s1.value}");
        SwapStruct(s0, s1);
        Debug.Log($"After : S0의 값은 {s0.value}, S1의 값은 {s1.value}");
        //클래스 : 참조 타입
        MeshClass c0 = new MeshClass();
        MeshClass c1 = new MeshClass();
        c0.value = 100;
        c1.value = 200;
        Debug.Log($"Before : C0의 값은 {c0.value}, C1의 값은 {c1.value}");
        SwapClass(c0, c1);
        Debug.Log($"After : C0의 값은 {c0.value}, C1의 값은 {c1.value}");
    }

    private void SwapStruct(MeshStruct left, MeshStruct right)
    {
        int temp = left.value;
        left.value = right.value;
        right.value = temp;
    }

    private void SwapClass(MeshClass left, MeshClass right)
    {
        int temp = left.value;
        left.value = right.value;
        right.value = temp;
    }
}

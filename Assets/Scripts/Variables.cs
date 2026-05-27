using UnityEngine;

public class Variables : MonoBehaviour
{
    //Integer 정수 타입 : 딱 떨어지는 수.
    public sbyte sbyteValue; //-128 ~ 127
    public short shortValue; //6만 ~ -6만
    public int intValue; //21억 ~ - 21억
    public int resultValue;
    public long longValue; //900조 ~ -900조

    //실수 타입 : 소수점이 포함된 타입
    public float floatValue;    //소수점 7자리까지 표현가능
    public float fResultValue;

    //참거짓
    public bool boolValue = true;

    //활성화될 때마다 한번만 호출
    private void OnEnable()
    {
        Debug.Log("활성화됨");
    }
    //비활성될 때마다 한번만 호출
    private void OnDisable()
    {
        Debug.Log("비활성화됨");
    }

    //처음 시작시 한번만
    void Start()
    {
        intValue = intValue + intValue;
        if (intValue == 2)
        {
            Debug.Log("intValue는 2가 맞아");
        }
        else
        {
            Debug.Log("intValue는 2가 아니야");
        }
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;
        fResultValue += floatValue;

        //실수는 근사치로만 표현되기 때문에 == 으로 비교하면 
        //원하는 결과를 도출할 수 없다.
        if (fResultValue > 1f)
        {
            Debug.Log($"fResultValue는 1보다 커 => {fResultValue:F7}");
        }
        else
        {
            Debug.Log($"fResultValue는 1보다 작아 => {fResultValue:F7}");
        }

        if (boolValue == true)
        {
            Debug.Log($"boolValue는 참이다");
        }
        else
        {
            Debug.Log($"boolValue는 거짓이다");
        }
    }

    //켜져있는 동안 한번씩 계속
    void Update()
    {
        resultValue += intValue;
    }
}

using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;
    public int[] arr2 = new int[3];
    public char[,] ch2 = new char[3, 3];
    void Start()
    {
        if (a > b)
        {
            Debug.Log("a 가 b 보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("b 가 a 보다 큽니다.");
        }
        else
        {
            Debug.Log("a 와 b 는 같습니다.");        
        }

        switch(this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다.");
                break;

            case "바나나":
                Debug.Log("바나나는 노랗습니다.");
                break;

            case "포도":
                Debug.Log("포도는 보라색입니다.");
                break;

            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i 의 값: " + i);
        }

        while (a < 10)
        {
            Debug.Log("a 의 값:" + a);
            a++;
        }

        do
        {
            Debug.Log("b 의 값: " + b);
            b--;
        } while (b > 0);

        string[] array = new string[5]; //배열은 0 부터 시작
        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] scores = { 90, 85, 78, 92, 88 };

        for (int j = 0; j < arr2.Length; j++)
        {
            Debug.Log("배열의 값" + j + ": " + arr2[j]);
        }

        int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        Debug.Log(samsam[3, 2]);
      
   
        }


void Update()
    {
        
    }
}

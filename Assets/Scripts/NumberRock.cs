using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberRock : MonoBehaviour
{
    const int MAXNUM = 9;
    [SerializeField, Range(0, MAXNUM)] int[] numbers;
    [SerializeField] TextMeshPro[] numberTexts;
    public void SetNumbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numberTexts[i].text = numbers[i].ToString();
        }
    }

    public void IncreaseNum(int index)
    {
        numbers[index] = ++numbers[index] % (MAXNUM + 1);
        SetNumbers();
    }

    void Start()
    {

    }

    void Update()
    {

    }
}

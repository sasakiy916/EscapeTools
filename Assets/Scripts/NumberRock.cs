using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberRock : MonoBehaviour
{
    const int MAXNUM = 9;
    [SerializeField, Range(0, MAXNUM)] int[] correctNumbers;
    [SerializeField, Range(0, MAXNUM)] int[] numbers;
    [SerializeField] TextMeshPro[] numberTexts;

    // 数字の表示を反映させる
    public void SetNumbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numberTexts[i].text = numbers[i].ToString();
        }
    }

    // 数字を増やして、正解判定する
    public void IncreaseNum(int index)
    {
        numbers[index] = ++numbers[index] % (MAXNUM + 1);
        SetNumbers();
        bool correct = CheckCorrectNumber();
        Debug.Log(correct);
    }

    // 正解判定
    public bool CheckCorrectNumber()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != correctNumbers[i]) return false;
        }
        return true;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NumberRock : MonoBehaviour
{
    const int MAXNUM = 9;
    [SerializeField, Range(0, MAXNUM)] int[] correctNumbers;
    [SerializeField, Range(0, MAXNUM)] int[] numbers;
    [SerializeField] TextMeshPro[] numberTexts;
    [SerializeField] Door door;
    [SerializeField] Animator buttonAnimator;

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
        // bool correct = CheckCorrectNumber();
        // Debug.Log(correct);
    }

    // 正解判定
    public void CheckCorrectNumber()
    {
        buttonAnimator.SetTrigger("Push");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != correctNumbers[i]) return;
        }
        door.UnLock();
        // return true;
    }


    // Numberオブジェクトのアタッチ、それに合わせてフィールドの配列要素数変更
    public void AttachNumberTextObject()
    {
        numberTexts = GetComponentsInChildren<TextMeshPro>();
        numbers = new int[numberTexts.Length];
        correctNumbers = new int[numberTexts.Length];
    }

    void Start()
    {
        buttonAnimator = buttonAnimator.GetComponent<Animator>();
    }

    void Update()
    {

    }
}

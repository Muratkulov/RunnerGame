using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCalculator : MonoBehaviour
    //minus
{
  public void AddTwoMinusTwo()
    {
        int result = AddNumbers(2, 2);

    }
    public int AddNumbers(int numberOne, int numberTwo)
    {
        int result = numberOne - numberTwo;
        return result;
    }
    //umnozh
    public void AddTwoUmnozhTwo()
    {
        int result = AddNumbers(2, 2);

    }
    public int AddNumbers(int numberOne, int numberTwo)
    {
        int result = numberOne * numberTwo;
        return result;
    }
    //del
    public void AddTwoDelTwo()
    {
        int result = AddNumbers(20, 2);

    }
    public float AddNumbers(float numberOne, float numberTwo)
    {
        float result = numberOne / numberTwo;
        return result;
    }
    //percent
    public void AddTwoPercentTwo()
    {
        int result = FindPercentage(20, 2);

    }
    public float FindPercentage(float number, float percent)

        float result = (number/100) * percent;
        return result;
    }
}

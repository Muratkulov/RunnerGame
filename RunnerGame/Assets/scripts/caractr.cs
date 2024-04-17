using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string neme;
    private bool isFinished;

    [SerializeField] private float speed;
    private bool isJumping;
    private void Update()
    {
        Run();

        bool isSpaceClicked = Input.GetKeyUp(KeyCode.Space);
        if (isSpaceClicked == true)
        {
            Boost(2);
        }
    }

    public void Boost(float multiplier)
    {
        speed = speed * multiplier;
    }
    private void Jump()
    {
        isJumping = true;
    }
    private void Run()
    {
        transform.position = GetNextPosition(speed);
    }

    private Vector3 GetNextPosition(float stepLenth)
    {
        Vector3 newPosition = new Vector3();

        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + stepLenth;


        return newPosition;

    }
    private int GetSum(int firstNumber, int secondNumber)
    {
        int sum = 0;
        sum = firstNumber + secondNumber;
        return sum;
    }
    private float jarymynber(int number)
    {
        float sum = 0;
        sum = number / 2;

        return sum;
    }
}


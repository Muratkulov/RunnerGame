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
        Vector3 newPosition = new Vector3();
        newPosition.x = transform.position.x;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + speed;


        transform.position = newPosition;

    }
}

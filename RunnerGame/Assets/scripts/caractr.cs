using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] private float forwardspeed;
    [SerializeField] private float sidespeed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position = GetNextPosition(forwardspeed, 1);

        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position = GetNextPosition(forwardspeed, -1);
        }
        if (CanBoost() == true)
        {
            Boost(2);
        }
    }

    public void Boost(float multiplier)
    {
        forwardspeed = forwardspeed * multiplier;
        ; sidespeed = sidespeed * multiplier;
    }



    private Vector3 GetNextPosition(float stepLenth, float sideDirection)
    {
        Vector3 newPosition = new Vector3();

        newPosition.x = transform.position.x + sideDirection * sidespeed;
        newPosition.y = transform.position.y;
        newPosition.z = transform.position.z + stepLenth;


        return newPosition;

    }

    private bool CanBoost()


    {
        return Input.GetKeyUp(KeyCode.Space);
    }



}
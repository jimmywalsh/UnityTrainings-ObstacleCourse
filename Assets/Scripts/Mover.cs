using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructionsToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerCharacter();
    }

    void MovePlayerCharacter()
    {
        var horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        var verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;


        transform.Translate(horizontalInput, 0, verticalInput);
    }

    void PrintInstructionsToConsole()
    {
        Debug.Log("Welcome to the game!");
    }
}
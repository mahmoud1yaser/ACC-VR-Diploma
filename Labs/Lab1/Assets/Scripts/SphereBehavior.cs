using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Move the game object to the right when the "D" key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(1, 0, 0);
        }

        // Move the game object to the left when the "A" key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-1, 0, 0);
        }

        // Move the game object up when the "Q" key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.position += new Vector3(0, 1, 0);
        }

        // Move the game object down when the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
        }

        // Move the game object forward when the "W" key is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0, 0, 1);
        }

        // Move the game object backward when the "S" key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(0, 0, -1);
        }

    }

    // This method is called when the game object collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        // Set the game object's mesh renderer color to the random color
        GetComponent<MeshRenderer>().material.color = randomColor;

        // Print out in the console 
        Debug.Log($"The Sphere is collided with the {collision.gameObject.name}");
    }

}

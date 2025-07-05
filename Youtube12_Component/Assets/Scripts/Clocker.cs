using UnityEngine;

public class Clocker : MonoBehaviour
{
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Log the current time since the start of the game
        Debug.Log(Time.time);

        // Log the time scale of the game
        Debug.Log(Time.timeScale);

        // Log the fieed time step of the game
        Debug.Log(Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // Increment timer by the time since the last frame
      //  Debug.Log("Time.deltaTime: " + Time.deltaTime);

        if(timer > 3) {
            Debug.Log("3 seconds have passed since the start of the game.");
        }
    }
}

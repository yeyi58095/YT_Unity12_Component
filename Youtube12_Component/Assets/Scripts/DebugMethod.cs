using UnityEngine;

public class DebugMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Debug");
        Debug.LogWarning("Debug Warning");
        Debug.LogError("Debug Error");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(1, 0, 0), new Vector3(1, 1, 0), Color.red);

        Debug.DrawRay(new Vector3(1, 0, 0), new Vector3(1, 1, 0), Color.blue);
    }
}

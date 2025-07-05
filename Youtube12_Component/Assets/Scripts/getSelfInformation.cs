using UnityEngine;
using UnityEngine.Rendering;

public class getSelfInformation : MonoBehaviour
{

    public GameObject cube; // cube had been created in the scene by myself
    public GameObject Prefab; // prefab had been created in the scene by myself
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get itself and tend to omit it just use "gameObject"
        GameObject self = this.gameObject;
        // get the name of the game object
        Debug.Log("GameObject Name: " + self.name);

        // get the tag of the game object
        Debug.Log("GameObject Tag: " + gameObject.tag);

        // get the layer of the game object
        Debug.Log("GameObject Layer: " + LayerMask.LayerToName(gameObject.layer));


        // get the name of the cube
        Debug.Log("Cube Name: " + cube.name);

        // the real active status of the game object in the hierarchy
        Debug.Log("Cube Active Self: " + cube.activeInHierarchy);

        // the active status of the game object itself
        Debug.Log("Cube Active Self: " + cube.activeSelf);

        // get the transform component of the game object
        Transform trans = this.transform;
        trans = self.transform;
        trans = gameObject.transform;
        trans = GetComponent<Transform>();

        // get the position of the game object
        Debug.Log("GameObject Position : " + trans.position);

        // get the other components of the game object instead of transform
        BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();

        // get the component of the child of the game object
        BoxCollider childBoxCollider = gameObject.GetComponentInChildren<BoxCollider>();

        // get the component of the parent of the game object
        BoxCollider parentBoxCollider = gameObject.GetComponentInParent<BoxCollider>();

        // aad a component  on it
        gameObject.AddComponent<AudioSource>();

        // find the game object in the scene
        GameObject plane = GameObject.Find("Plane");
        Debug.Log("Plane Name: " + plane.name);

        // find the game object by tag
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject  obj in enemies)
        {
            Debug.Log("Enemy Name: " + obj.name);
        }

        // using prefab to instantiate a game object
        GameObject go = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
        Destroy(go, 5f); // destroy the game object after 5 seconds

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

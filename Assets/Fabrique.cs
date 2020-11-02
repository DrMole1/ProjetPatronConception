using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fabrique : MonoBehaviour
{
    // ========================== VARIABLES ==========================

    [Header("Objects in the scene")]
    [SerializeField]
    private Transform spawner;
    [SerializeField]
    private Transform pool;
    [Header("Drag from the project")]
    [SerializeField]
    private Material[] materials;
    [SerializeField]
    private GameObject objectPrefab;

    private int height;
    private int color;

    // ===============================================================



    /// <summary>
    /// Get the necessary height
    /// </summary>
    /// <param name="_height">The height of the spawned object</param>
    public void GetHeight(int _height)
    {
        height = _height;
    }

    /// <summary>
    /// Get the necessary color
    /// </summary>
    /// <param name="_color">The color of the spawned object</param>
    public void GetColor(int _color)
    {
        color = _color;
    }

    /// <summary>
    /// Creating new instance of prefab.
    /// </summary>
    public void GetNewInstance()
    {
        GameObject objectInstance;

        objectInstance = Instantiate(objectPrefab, spawner.position, Quaternion.identity, pool);
        
        // Set the properties of the new instance
        objectInstance.transform.localScale = new Vector3(height, height, height);
        objectInstance.GetComponent<MeshRenderer>().material = materials[color];
    }

}

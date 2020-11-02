using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype : MonoBehaviour
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
    private GameObject lastObjectCreated;

    // ===============================================================

    public void Clone()
    {
        if(pool.childCount == 0)
        {
            print("There are no object in the pool !");
            return;
        }

        lastObjectCreated = pool.GetChild(pool.childCount - 1).gameObject;

        height = (int)lastObjectCreated.transform.localScale.x;
        for(int i = 0; i < materials.Length; i++)
        {
            if (materials[i].color == lastObjectCreated.GetComponent<MeshRenderer>().material.color)
            {
                color = i;
            }
        }

        GameObject objectInstance;

        objectInstance = Instantiate(objectPrefab, spawner.position, Quaternion.identity, pool);

        // Set the properties of the new instance
        objectInstance.transform.localScale = new Vector3(height, height, height);
        objectInstance.GetComponent<MeshRenderer>().material = materials[color];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testFactory : MonoBehaviour
{

    [SerializeField] CNPCSpawner m_SpawnefrNPC=default;

    // Start is called before the first frame update
    void Start()
    {
        m_SpawnefrNPC.SpwanVillagers();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

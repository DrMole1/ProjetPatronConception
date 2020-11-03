using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CWorker;

public class CNPCSpawner : MonoBehaviour
{

    CWorker m_beggar = default;
    CWorker m_Farmer = default;
    CWorker m_Shopowner = default;

   [SerializeField] CNPCFactory m_Factory=default;

   public void SpwanVillagers()
    {
        //Appel GetNPC
        m_beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.ShopOwner);

        m_beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();

    }
}

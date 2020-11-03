using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CWorker;

public class CNPCFactory : MonoBehaviour
{
   public CWorker GetNPC(NPCType typeNpc)
    {
        switch (typeNpc)
        {
             case NPCType.Beggar : return new CBeggar();
             case NPCType.Farmer:return new CFarmer();
             case NPCType.ShopOwner:return new CShopowner();
             default: return null;
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CWorker : INPC
{
    public enum NPCType { Farmer, Beggar, ShopOwner }

    abstract public void Speak();
}

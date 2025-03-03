﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCell : BoardCell
{
    public override void OnObjectPlaced()
    {
        Rigidbody rb = placedObject.GetComponent<Rigidbody>();
        if (rb == null) placedObject.gameObject.AddComponent<Rigidbody>();
        if (rb != null)
            rb.isKinematic = false;

        placedObject.gameObject.GetComponent<Animator>().Play("Fall");
        placedObject.SetMovable(false);
        placedObject.SetRotatable(false);

        if (placedObject.GetComponent<LaserEmitter>() != null)
        {
            placedObject.GetComponent<LaserEmitter>().ChangeIntensity(0.0f);
            boardManager.InvokeLevelFailed();
        }
    }

    public override string[] GetArgs()
    {
        return new string[0];
    }
}

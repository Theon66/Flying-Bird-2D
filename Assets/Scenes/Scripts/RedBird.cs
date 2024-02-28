using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// INHERITANCE
public class RedBird : Bird
{
    // POLYMORPHISM
    // ENCAPSULATION
    protected override void Fly()
    {
        birdPrefab.transform.Translate(Vector3.left * Time.deltaTime * 2);
        if (birdPrefab.transform.position.x < -14)
        {
            Destroy(birdPrefab);
        }
    }

    void Update()
    {
        Fly();
    }

}

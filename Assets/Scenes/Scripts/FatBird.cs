using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class FatBird : Bird
{
    // POLYMORPHISM
    // ENCAPSULATION
    protected override void Fly()
    {
        birdPrefab.transform.Translate(Vector3.left * Time.deltaTime * 2);
        birdPrefab.transform.Translate(Vector3.down * Time.deltaTime * 0.6f);

        if (birdPrefab.transform.position.x < -14 || birdPrefab.transform.position.y < -10)
        {
            Destroy(birdPrefab);
        }
    }

    void Update()
    {
        Fly();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkBird : Bird
{
    protected override void Fly()
    {
        birdPrefab.transform.Translate(Vector3.left * Time.deltaTime * 4);
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

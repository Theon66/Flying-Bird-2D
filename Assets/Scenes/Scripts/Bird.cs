using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : MonoBehaviour
{
    public GameObject birdPrefab;

    // ABSTRACTION
    protected abstract void Fly();
}

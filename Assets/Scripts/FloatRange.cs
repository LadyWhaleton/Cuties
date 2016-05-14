using UnityEngine;
using System.Collections;

/*
    FloatRange generates a random float value between
    a given min and max. 

    The purpose of this script is to reduce amount of functions
    for randomizing certain floats. This can be used by any
    float variable and reduces the need of calling Random.Range
    and then assigning that value to the float.

    For example, you might have scale (which is already a property).
    Suppose you want to randomize the scale and multiply it by a factor
    of two. You would probably have to do:
    scale = Random.range(min, max);
    scale *= 2;

    Usage:
    floatVar.RandomInRange

    example:
    velocity.RandomInRange, scale.RandomInRange

*/

public class FloatRange : MonoBehaviour {

    public float min, max;

    public float RandomInRange
    {
        get { return Random.Range(min, max);  }
    }

    void Start() {
        min = 0.05f;
        max = 0.15f;
    }
}

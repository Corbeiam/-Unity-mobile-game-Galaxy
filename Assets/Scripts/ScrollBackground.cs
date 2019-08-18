using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

    public float scrollSpeed;
    public float tilesSize;
    private Transform currentObject;

    void Start()
    {
        currentObject = GetComponent<Transform>();
    }

    void Update()
    {
        currentObject.position = new Vector3(
            currentObject.position.x,
            Mathf.Repeat(Time.time * scrollSpeed, tilesSize),
            currentObject.position.z
            );
    }
}

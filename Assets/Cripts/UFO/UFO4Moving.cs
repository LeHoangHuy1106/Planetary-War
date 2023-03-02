using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO4Moving : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    private float amplitude = 0.5f; // biên độ sóng
    [SerializeField]
    private float speed = 1f; // tốc độ di chuyển
    [SerializeField]
    private float offset = 0f; // độ trễ
     float startPosX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

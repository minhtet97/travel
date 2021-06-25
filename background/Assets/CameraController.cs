using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, -12f, 150f), // ���b�N�ŌF�q:������ւ񏭂����������܂���
            Mathf.Clamp(targetToFollow.position.y, -10.38f, 14f),
            transform.position.z);
    }
}

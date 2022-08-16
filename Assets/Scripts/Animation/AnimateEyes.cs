using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEyes : MonoBehaviour
{

    public GameObject leftEye;
    public GameObject rightEye;
    public GameObject targetObject;

    public float rotationXOld;
    public float rotationYOld;
    public float rotationZOld;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        rotationXOld = transform.rotation.x;
        rotationYOld = transform.rotation.y;
        rotationZOld = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = ((leftEye.transform.position + rightEye.transform.position) * 0.5f);

        transform.LookAt(targetObject.transform);

        float rotationDiffX = GetRotationDiff(transform.rotation.x, rotationXOld);
        float rotationDiffY = GetRotationDiff(transform.rotation.y, rotationYOld);
        float rotationDiffZ = GetRotationDiff(transform.rotation.z, rotationZOld);

        leftEye.transform.Rotate(rotationDiffX, rotationDiffY, rotationDiffZ);
        rightEye.transform.Rotate(rotationDiffX, rotationDiffY, rotationDiffZ);

        rotationXOld = transform.rotation.x;
        rotationYOld = transform.rotation.y;
        rotationZOld = transform.rotation.z;
    }

    float GetRotationDiff(float newRotation, float oldRotation)
    {
        return newRotation - oldRotation;
    }
}

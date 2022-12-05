using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;

public class speedPlayer : TrackedPoseDriver
{
    [SerializeField]
    float movementSpeed = 10f;

    void Update()
    {
        base.OnUpdate();
    }
    protected override void SetLocalTransform(Vector3 newPosition, Quaternion newRotation)
    {
        if (trackingType == TrackingType.RotationAndPosition ||
            trackingType == TrackingType.RotationOnly)
        {
            transform.localRotation = newRotation;
        }

        if (trackingType == TrackingType.RotationAndPosition ||
            trackingType == TrackingType.PositionOnly)
        {
            transform.localPosition = new Vector3(newPosition.x * movementSpeed, newPosition.y * movementSpeed, newPosition.z * movementSpeed * 3f);
        }
        UnityEngine.Debug.Log(newPosition);
    }
}

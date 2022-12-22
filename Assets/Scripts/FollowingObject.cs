using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingObject : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float offsetLength;
    private float zPos;
    private void Start()
    {
        var offset = target.transform.position - transform.position;
        offset.z = 0;
        offsetLength = offset.magnitude;
        zPos = transform.position.z;
    }

    private void LateUpdate()
    {
        var tmpVec3 = target.position;
        var targetPos = new Vector2(tmpVec3.x, tmpVec3.y);
        tmpVec3 = transform.position;
        var pos = new Vector2(tmpVec3.x, tmpVec3.y);
        var dir = targetPos - pos;
        var distance = dir.magnitude;
        if (distance > offsetLength)
        {
            var newPos = pos + dir.normalized * (distance - offsetLength);
            transform.position = new Vector3(newPos.x, newPos.y, zPos);
        }
    }
}

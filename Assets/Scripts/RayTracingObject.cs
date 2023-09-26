using System;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(MeshRenderer))]
    [RequireComponent(typeof(MeshFilter))]
    public class RayTracingObject : MonoBehaviour
    {
        private void OnEnable()
        {
            RayTracingMaster.RegisterObject(this);
        }

        private void OnDisable()
        {
            RayTracingMaster.UnregisterObject(this);
        }
    }
}
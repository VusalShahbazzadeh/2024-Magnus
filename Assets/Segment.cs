using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Segment : MonoBehaviour
    {
        public Transform nextSegmentPosition;

        private Vector3 parentLastMove = Vector3.zero;
        private Quaternion parentLastRotationChange = Quaternion.identity;

        private Vector3 parentLastPosition = Vector3.zero;
        private Quaternion parentLastRotation = Quaternion.identity;

        public Segment parent;

        private void Update()
        {
            if (parent)
            {
                transform.position = Vector3.MoveTowards(transform.position, parent.nextSegmentPosition.transform.position, Time.deltaTime);
                transform.LookAt(parent.nextSegmentPosition.transform);
                // transform.position += parentLastMove;
                // transform.rotation *= parentLastRotationChange;
                //
                // parentLastMove = parent.transform.position - parentLastPosition;
                // parentLastRotationChange = parent.transform.rotation * Quaternion.Inverse(parentLastRotation);
                //
                // parentLastPosition = parent.transform.position;
                // parentLastRotation = parent.transform.rotation;
            }
        }
    }
}
using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player {
    public class MovementScript : MonoBehaviour {
        public float moveSpeed;
        public float turnSpeed;
        public float turnValue;

        void Start() {
        }

        void Update() {
            CaptureTranslation();
            CaptureTurn();
        }

        private void CaptureTranslation() {
            var zInput = Input.GetAxis("Horizontal");
            var xInput = Input.GetAxis("Vertical");
            var translation = Time.deltaTime * moveSpeed * new Vector3(-xInput, 0, zInput);
            transform.Translate(translation);
        }

        private void CaptureTurn() {
            var yTurn = Input.GetAxis("Mouse X");
            if (yTurn == 0) return;
            turnValue += turnSpeed * yTurn * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, turnValue, 0);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickRotater : MonoBehaviour
{
        private float speed = 3f;

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.World);
            }
        }

}

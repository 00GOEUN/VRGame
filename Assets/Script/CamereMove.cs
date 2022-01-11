using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereMove : MonoBehaviour
{
    private GameObject Target;


    private Vector3 Offset;

    private void Awake()
    {
        Target = GameObject.Find("Player");
    }

    void Start()
    {
        Offset = new Vector3(0.0f, 12.0f, -10.0f);

        this.transform.position = new Vector3(
            Offset.x + Target.transform.position.x,
            Offset.y + Target.transform.position.y,
            Offset.z + Target.transform.position.z);

        this.transform.rotation = Quaternion.LookRotation(
            (Target.transform.position - this.transform.position).normalized);
    }

    void Update()
    {
        FolloingCamera();
    }

    void FolloingCamera()
    {
        // ** 카메라가 목표지점까지 이동하는 시간을 셋팅.
        // ** Vector3.Lerp(시작점, 도착점, 시간)
        Vector3 SmoothFolloingPosition = Vector3.Lerp(
            this.transform.position, Target.transform.position + Offset, Time.deltaTime * 5.0f);

        // ** 위에서 셋팅된 위치로 적용.d
        this.transform.position = SmoothFolloingPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    float _Angel;

    void Update() {
        Transform cameraTrans = this.transform;
        _Angel += Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(_Angel) / 10f, Mathf.Sin(_Angel * 2) /   10f + 1, cameraTrans.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoCap : MonoBehaviour {

    public Transform NeckBone;
    public Transform LeftArm;
    public Transform RightArm;
    public Transform LeftToe;
    public Transform RightToe;

    public Transform HMD;
    public Transform LeftController;
    public Transform RightController;

    [SerializeField]
    private Vector3 NeckToLeftArm;
    [SerializeField]
    private Vector3 NeckToRightArm;
    [SerializeField]
    private Vector3 HMDToLeft;
    [SerializeField]
    private Vector3 HMDToRight;
    [SerializeField]
    private float NeckToLeftMag;
    [SerializeField]
    private float NeckToRightMag;
    [SerializeField]
    private float HMDToLeftMag;
    [SerializeField]
    private float HMDToRightMag;
    [SerializeField]
    private Vector3 ToeMidPoint;
    [SerializeField]
    private float userHeight;
    [SerializeField]
    private float modelHeight;

	// Use this for initialization
	void Start () {
        CalculateVectors();
	}
	
	// Update is called once per frame
	void Update () {
        CalculateVectors();
    }

    private void CalculateVectors()
    {
        NeckToLeftArm = LeftArm.position - NeckBone.position;
        NeckToLeftMag = NeckToLeftArm.magnitude;
        NeckToRightArm = RightArm.position - NeckBone.position;
        NeckToRightMag = NeckToRightArm.magnitude;
        ToeMidPoint = (LeftToe.position + RightToe.position) / 2;
        modelHeight = NeckBone.position.y - ToeMidPoint.y;

        HMDToLeft = LeftController.position - HMD.position;
        HMDToLeftMag = HMDToLeft.magnitude;
        HMDToRight = RightController.position - HMD.position;
        HMDToRightMag = HMDToRight.magnitude;
        userHeight = HMD.position.y;
    }
}

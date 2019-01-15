using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetTypes : MonoBehaviour
{
	public struct PoseData
	{
		public Vector3[] bonePos;
		public Vector3[] boneAngles;
	};

	public static PoseData getPoseData()
	{
		PoseData pd = new PoseData();
		CubemanController cm = GameObject.Find("Cubeman").GetComponent<CubemanController>();
		GameObject[] bones = cm.GetBones();
		for(int i = 0; i < 20; i++)
		{
			pd.bonePos[i] = bones[i].transform.position;
			pd.bonePos[i] = bones[i].transform.localEulerAngles;
		}
		return pd;
	}
}
public class AuthMessage : MessageBase
{
	public int id;
}
public class MyNetworkMessage : MessageBase
{
	public int id;
    public string message;
}
public class PoseDataMessage : MessageBase
{
	public int id;
	public NetTypes.PoseData pd;
}
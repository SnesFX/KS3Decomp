using System;
using UnityEngine;

[Serializable]
public class SM_rotateThis : MonoBehaviour
{
	public float rotationSpeedX;

	public float rotationSpeedY;

	public float rotationSpeedZ;

	private Vector3 rotationVector;

	public SM_rotateThis()
	{
		rotationSpeedX = 90f;
		rotationVector = new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ);
	}

	public virtual void Update()
	{
		transform.Rotate(new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ) * Time.deltaTime);
	}

	public virtual void Main()
	{
	}
}

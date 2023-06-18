using System;
using UnityEngine;

[Serializable]
public class SM_destroyThisTimed : MonoBehaviour
{
	public float destroyTime;

	public SM_destroyThisTimed()
	{
		destroyTime = 5f;
	}

	public virtual void Start()
	{
		UnityEngine.Object.Destroy(gameObject, destroyTime);
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}

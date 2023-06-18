using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class OsanaScript : MonoBehaviour
{
	public Rigidbody[] Rigidbodies;

	public AudioClip[] PainScream;

	public float Force;

	public OsanaScript()
	{
		Force = 100f;
	}

	public virtual void KinematicFalse()
	{
		for (int i = 0; i < Extensions.get_length((System.Array)Rigidbodies); i++)
		{
			Rigidbodies[i].isKinematic = false;
		}
		Rigidbodies[0].AddForce(transform.forward * Force * -1f);
		GetComponent<AudioSource>().clip = PainScream[UnityEngine.Random.Range(0, Extensions.get_length((System.Array)PainScream))];
		GetComponent<AudioSource>().Play();
	}

	public virtual void Main()
	{
	}
}

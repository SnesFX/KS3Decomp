using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class SM_effectCaster : MonoBehaviour
{
	public GameObject moveThis;

	public RaycastHit hit;

	public GameObject[] createThis;

	public float cooldown;

	public float changeCooldown;

	public int selected;

	public GUIText writeThis;

	private float rndNr;

	private GameObject effect;

	public virtual void Start()
	{
		selected = Extensions.get_length((System.Array)createThis) - 1;
		writeThis.text = selected.ToString() + " " + createThis[selected].name;
	}

	public virtual void Update()
	{
		if (!(cooldown <= 0f))
		{
			cooldown -= Time.deltaTime;
		}
		if (!(changeCooldown <= 0f))
		{
			changeCooldown -= Time.deltaTime;
		}
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			moveThis.transform.position = hit.point;
			if (Input.GetMouseButton(0) && !(cooldown > 0f))
			{
				effect = (GameObject)UnityEngine.Object.Instantiate(createThis[selected], moveThis.transform.position, moveThis.transform.rotation);
				if (effect.tag == "explosion" || effect.tag == "missile" || effect.tag == "breath")
				{
					float y = effect.transform.position.y + 1.5f;
					Vector3 position = effect.transform.position;
					float num = (position.y = y);
					Vector3 vector2 = (effect.transform.position = position);
				}
				if (effect.tag == "shield")
				{
					float y2 = effect.transform.position.y + 0.5f;
					Vector3 position2 = effect.transform.position;
					float num2 = (position2.y = y2);
					Vector3 vector4 = (effect.transform.position = position2);
				}
				cooldown = 0.15f;
			}
		}
		if (Input.GetKeyDown(KeyCode.UpArrow) && !(changeCooldown > 0f))
		{
			selected++;
			if (selected > Extensions.get_length((System.Array)createThis) - 1)
			{
				selected = 0;
			}
			writeThis.text = selected.ToString() + " " + createThis[selected].name;
			changeCooldown = 0.1f;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow) && !(changeCooldown > 0f))
		{
			selected--;
			if (selected < 0)
			{
				selected = Extensions.get_length((System.Array)createThis) - 1;
			}
			writeThis.text = selected.ToString() + " " + createThis[selected].name;
			changeCooldown = 0.1f;
		}
	}

	public virtual void Main()
	{
	}
}

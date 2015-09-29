﻿using UnityEngine;
using System.Collections;

public class DieCommand : Command
{
	public DieCommand(GameObject gameObject)
		: base(gameObject)
	{
	
	}

	public override void execute ()
	{
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		animator.SetTrigger ("die");
		gameObject.GetComponent<NinjaController> ().CurrentState = NinjaController.FLAG_STATE_DIE;
		AudioUtils.GetInstance().PlayOnce (audioSource, "die");
		Destroy (gameObject, 2.0f);
	}
}
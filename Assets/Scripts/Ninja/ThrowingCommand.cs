﻿using UnityEngine;
using System.Collections;

public class ThrowingCommand : Command
{
	public ThrowingCommand(GameObject gameObject)
		: base(gameObject)
	{
	}

	public override void execute ()
	{
		animator.SetTrigger ("shouldThrow");
		Vector2 position = gameObject.transform.position;
		position.x += 0.5f;
		position.y += gameObject.GetComponent<Renderer> ().bounds.size.y / 2;
		GameObject dart = Instantiate (Resources.Load ("Prefabs/Dart", typeof(GameObject)),
		                               position,
		                               Quaternion.identity) as GameObject;
		dart.GetComponent<Rigidbody2D> ().velocity = new Vector2 (15, 0);
		Destroy (dart, 1.5f);
		var utils = AudioUtils.GetInstance ();
		utils.StopSound(audioSource);
		utils.PlayOnce(audioSource, "throw");
	}
}
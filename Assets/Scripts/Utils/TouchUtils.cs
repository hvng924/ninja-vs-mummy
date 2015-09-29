﻿using UnityEngine;
using System.Collections;

public class TouchUtils : Object
{
	public const int SWIPE_NONE = -1;
	public const int SWIPE_UP = 0;
	public const int SWIPE_RIGHT = 1;
	public const int SWIPE_DOWN = 2;
	public const int SWIPE_LEFT = 3;

	public static int GetSwipe()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			Vector2 touchDelta = Input.GetTouch (0).deltaPosition;
			if (touchDelta.x < -20 && Mathf.Abs (touchDelta.x) > Mathf.Abs (touchDelta.y)) {
				return SWIPE_LEFT;
			}

			if (touchDelta.x > 20 && Mathf.Abs (touchDelta.x) > Mathf.Abs (touchDelta.y)) {
				return SWIPE_RIGHT;
			}
			
			if (touchDelta.y > 20 && Mathf.Abs (touchDelta.y) > Mathf.Abs (touchDelta.x)) {
				return SWIPE_UP;
			}
			
			if (touchDelta.y < -20 && Mathf.Abs (touchDelta.y) > Mathf.Abs (touchDelta.x)) {
				return SWIPE_DOWN;
			}
		}
		return SWIPE_NONE;
	}

	public static int GetTapCount ()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			Vector2 touchDelta = Input.GetTouch (0).deltaPosition;
			if (touchDelta.x < 10 && touchDelta.y < 10) {
				return Input.GetTouch (0).tapCount;
			}
		}
		return 0;
	}
}
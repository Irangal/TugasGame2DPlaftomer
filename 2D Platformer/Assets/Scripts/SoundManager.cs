using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SoundManager : MonoBehaviour 
{
	private static SoundManager instance = null;
	public static SoundManager Instance;

			void Awake()
			{
				if (instance !=null && instance != this )
				{
					Destroy (this.gameObject  );
					return ;
				}
				else
		{
					instance = this;
				}
		DontDestroyOnLoad (this.gameObject);
	}
}
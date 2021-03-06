using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

	private static T _instance;

	public static T instance {
		get {
	
			if (_instance == null)
			{
		
				_instance = FindObjectOfType<T>();    

				if (_instance == null) {
					Debug.LogError("Nie można znaleźć obiektu tyou " + typeof(T) + "!");
				}
			}
			return _instance;
		}
	}
}

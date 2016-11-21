using UnityEngine;
using System.Collections;

public class GameManager : MonoSingleton<GameManager>
{

	// Use this for initialization
	void Start ()
	{
        Init();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

    private void Init()
    {
        TetrisManager.CreateInstance();
    }
}

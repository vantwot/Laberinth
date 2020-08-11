using System.Collections;
using UnityEngine;

public class OnEndGame : MonoBehaviour
{
	public Rotar m_Rotar;

    void Start()
    {
        
    }

    void Update() 
    {
        
    }

	void OnTriggerEnter()
	{
		m_Rotar.SetOnGUIEndGameState();
	}

}

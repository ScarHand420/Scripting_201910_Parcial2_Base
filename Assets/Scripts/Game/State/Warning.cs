using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : State
{
    [SerializeField]
    private GameObject yo;

    [SerializeField]
    private GameObject player;

    public override void Execute()
    {
        yo.transform.LookAt(player.transform);

        Debug.Log("Estoy en WARNING");

        //if (!yo.GetComponent<AICharacter>().Warning)
        //{
        //    SwitchToNextState();
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

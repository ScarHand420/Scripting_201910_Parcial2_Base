using UnityEngine;

public class Idle : State
{
    [SerializeField]
    private GameObject yo;

    //private void Update()
    //{
    //    Execute();
    //}

    public override void Execute()
    {
        Debug.Log("Estoy en IDLE");

        //if (!yo.GetComponent<AICharacter>().Idle)
        //{
        //    SwitchToNextState();
        //}


    }
}
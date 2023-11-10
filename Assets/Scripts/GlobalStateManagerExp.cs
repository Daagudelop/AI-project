using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum GuardStates
    {
        toPatrol,
        underFire,
        nani,

    }

public class GlobalStateManagerExp : MonoBehaviour
{
    public GuardStates currentGuardState = GuardStates.toPatrol;
    public static GlobalStateManagerExp sharedInstanceGlobalStateManager;

    private void Awake()
    {
        //------------------------
        //  2.1(Game Manager)Singleton: se inicializa
        if (sharedInstanceGlobalStateManager == null)
        {
            sharedInstanceGlobalStateManager = this;
        }
        //-----------------------
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToPatrol()
    {
        SetGuardStates(GuardStates.toPatrol);

    }

    public void ToTakeCover()
    {
        SetGuardStates(GuardStates.underFire);
    }

    public void ToBeAlert()
    {
        SetGuardStates(GuardStates.nani);
    }

    private void SetGuardStates(GuardStates newGuardState)
    {
        if (newGuardState == GuardStates.toPatrol)
        {
            //TODO
           
        }
        else if (newGuardState == GuardStates.underFire)
        {
            //TODO
        }
        else if (newGuardState == GuardStates.nani)
        {
            //TODO
        }
        this.currentGuardState = newGuardState;
    }

}

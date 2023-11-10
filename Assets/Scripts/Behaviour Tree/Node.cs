using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] //visible at inspector

public enum NodeState
{
    SUCCESS,
    RUNNING,
    FAILURE,
}

public abstract class Node 
{
    protected NodeState _nodeState;

    public NodeState nodeState { get { return _nodeState; } }

    public abstract NodeState Evaluate();

}

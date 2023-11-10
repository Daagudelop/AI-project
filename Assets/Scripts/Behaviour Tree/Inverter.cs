using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : Node //Decorator node, it flips one node from failure to success and the other way as well.
{
    protected Node children;

    public Inverter(Node children)
    {
        this.children = children;
    }

    public override NodeState Evaluate()
    {
        switch (children.Evaluate())
        {
            case NodeState.RUNNING:
                _nodeState = NodeState.RUNNING;
                break;
            case NodeState.SUCCESS:
                _nodeState = NodeState.FAILURE;
                break;
            case NodeState.FAILURE:
                _nodeState = NodeState.SUCCESS;
                break;
            default:
                break;
        }
        return _nodeState;
    }
}
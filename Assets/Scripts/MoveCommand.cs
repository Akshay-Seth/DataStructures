using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Vector3 startPosition;
    private Vector3 endPosition;
    private GameObject playerObject;

    public MoveCommand(GameObject player, Vector3 start, Vector3 end)
    {
        startPosition = start;
        endPosition = end;
        playerObject = player;
    }
    public void Execute()
    {
        playerObject.transform.position = endPosition;
    }
    public void Undo()
    {
        playerObject.transform.position = startPosition;
    }
}

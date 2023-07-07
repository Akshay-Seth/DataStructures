using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UndoRedoManager undoRedoManager;
    public void MovePlayer(Vector3 newPosition)
    {
        Vector3 oldPosition = transform.position;
        ICommand command = new MoveCommand(this.gameObject, oldPosition, newPosition);
        undoRedoManager.ExecuteCommand(command);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newPosition = transform.position + Vector3.forward;
            MovePlayer(newPosition);
            return;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            undoRedoManager.Undo();
            return;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            undoRedoManager.Redo();
            return;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelectState : StateMachineBehaviour
{
    private GameController _controller;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _controller = animator.GetComponent<GameController>();
        _controller.GameSelection.SetActive(true);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _controller.GameSelection.SetActive(false);
    }

}

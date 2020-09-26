using OrnekGithubUdemy.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrnekGithubUdemy.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Mover _mover;

        private void Awake()
        {
            _mover = new Mover(this);
        }

        private void Update()
        {
            _mover.Tick();
        }
    }
}


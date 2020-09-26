using OrnekGithubUdemy.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrnekGithubUdemy.Movements
{
    public class Mover
    {
        PlayerController _player;

        public Mover(PlayerController player)
        {
            _player = player;
        }

        public void Tick()
        {
            _player.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}


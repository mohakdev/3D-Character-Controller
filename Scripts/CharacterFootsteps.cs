using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadiantTools.CharacterManager
{
    public class CharacterFootsteps : MonoBehaviour
    {
        // Variables
        CharacterController cc;
        AudioSource audioPlayer;
        private void Awake()
        {
            cc = transform.parent.GetComponent<CharacterController>();
            audioPlayer = GetComponent<AudioSource>();
        }
        //Update Method
        void Update()
        {
            //If character is on ground and not moving and audio source is not playing then
            if (cc.isGrounded && cc.velocity.magnitude > 0 && !audioPlayer.isPlaying )
            {
                if (Input.GetKey(KeyCode.LeftShift)) 
                {
                    audioPlayer.volume = Random.Range(0.8f, 1);
                }
                else
                {
                    audioPlayer.volume = Random.Range(0.6f, 0.8f);
                }
                
                audioPlayer.pitch = Random.Range(0.7f, 1.2f);
                audioPlayer.Play();
            }
        }
    }
}

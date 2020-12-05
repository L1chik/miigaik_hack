using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;

public class UIInteraction : MonoBehaviour
{
    public UIView playerView;
    bool isViewing = false;
    public SFPSC_FPSCamera playerCamera;
    SFPSC_PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SFPSC_PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isViewing)
            {
                isViewing = true;
                PlayerActions(!isViewing);
                playerView.Show();
            }
            else
            {
                isViewing = false;
                PlayerActions(!isViewing);

                playerView.Hide();

            }
        }
         
    }

    public void PlayerActions(bool isEnabled)
    {
        if (isEnabled)
        {
            player.enabled = true;
            playerCamera.enabled = true;
        }
        else
        {
            player.enabled = false;
            playerCamera.enabled = false;
        }
    }

}

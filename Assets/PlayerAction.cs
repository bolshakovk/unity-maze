using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject menu;
    MenuManager menuManager;
    public GameObject player;
    public int speed;
    public int rotationSpeed;
    public GameObject finish;
    public GameObject[] walls;

    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Panel");
        menuManager = menu.GetComponent<MenuManager>();
        var finishRenderer = finish.GetComponent<Renderer>();
        finishRenderer.material.SetColor("_Color", Color.red);
        
        var playerRenderer = player.GetComponent<Renderer>();
        playerRenderer.material.SetColor("_Color", Color.green);
        for(int i = 0; i < walls.Length; i ++)
        {
            var wallRenderer = walls[i].GetComponent<Renderer>();
            wallRenderer.material.SetColor("_Color", Color.blue);
        }
    }
    // Win point
    private void OnGUI() 
    {
        
        if (player.transform.position.z >= finish.transform.position.z && player.transform.position.y >= finish.transform.position.y &&  player.transform.position.x >= finish.transform.position.x)
         {
            speed = 0;
            if (GUI.Button (new Rect (200, 200, 800, 400), "You are win!\nExit"))
	            {
                    Application.Quit ();
                }
        }
    }

    // Moving
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W))
         {
	        player.transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.S)) 
        {
	        player.transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.D)) 
        {
	    player.transform.Rotate (Vector3.up * rotationSpeed*Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.A)) 
        {
	        player.transform.Rotate (Vector3.down * rotationSpeed*Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.Escape)) 
        {
	        menu.gameObject.SetActive(!menu.gameObject.activeSelf);
        }
    }
}

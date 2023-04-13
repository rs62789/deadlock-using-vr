// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class mind : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public GameObject car1;
//     public GameObject car2;
//     public GameObject car3;
//     public GameObject car4;

//     void Start()
//     {
//         car1.GetComponent<moveCar>().enabled = true;
//         car2.GetComponent<moveCar>().enabled = false;
//         car3.GetComponent<moveCar>().enabled = false;
//         car4.GetComponent<moveCar>().enabled = false;

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetButtonDown("1Key")){
//             car1.GetComponent<moveCar>().enabled = true;
//             car2.GetComponent<moveCar>().enabled = false;
//             car3.GetComponent<moveCar>().enabled = false;
//             car4.GetComponent<moveCar>().enabled = false;
//         }else if (Input.GetButtonDown("2Key")){
//             car1.GetComponent<moveCar>().enabled = false;
//             car2.GetComponent<moveCar>().enabled = false;
//             car3.GetComponent<moveCar>().enabled = false;
//             car4.GetComponent<moveCar>().enabled = false;
//         }else if (Input.GetButtonDown("3Key")){
//             car1.GetComponent<moveCar>().enabled = false;
//             car2.GetComponent<moveCar>().enabled = false;
//             car3.GetComponent<moveCar>().enabled = true;
//             car4.GetComponent<moveCar>().enabled = false;
//         }else if (Input.GetButtonDown("4Key")){
//             car1.GetComponent<moveCar>().enabled = false;
//             car2.GetComponent<moveCar>().enabled = false;
//             car3.GetComponent<moveCar>().enabled = false;
//             car4.GetComponent<moveCar>().enabled = false;
//         }

//     }
// }

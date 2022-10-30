using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class VideoStudioManager : MonoBehaviour
{
    [SerializeField]
    GameObject cam1, cam2, cam3, cam4, cam5, cam6, cam7, cam8, cam9, selficam;

    [SerializeField]
    GameObject cam1preview, cam2preview, cam3preview, cam4preview, cam5preview, cam6preview, cam7preview, cam8preview, camPlayerPerview, camSelfiCamPreview;

    [SerializeField]
    GameObject selectionImage;

    [SerializeField]
    List<GameObject> uiObjects = new List<GameObject>();

    Animator cam1Animator, cam2Animator, cam3Animator, cam4Animator, cam5Animator, cam6Animator, cam7Animator, cam8Animator, cam9Animator;

    void Start()
    {

        cam1Animator = cam1.GetComponent<Animator>();
        cam2Animator = cam2.GetComponent<Animator>();
        cam3Animator = cam3.GetComponent<Animator>();
        cam4Animator = cam4.GetComponent<Animator>();
        cam5Animator = cam5.GetComponent<Animator>();
        cam6Animator = cam6.GetComponent<Animator>();
        cam7Animator = cam7.GetComponent<Animator>();
        cam8Animator = cam8.GetComponent<Animator>();
        cam9Animator = cam9.GetComponent<Animator>();

        cam1Animator.speed = 0;
        cam2Animator.speed = 0;
        cam3Animator.speed = 0;
        cam4Animator.speed = 0;
        cam5Animator.speed = 0;
        cam6Animator.speed = 0;
        cam7Animator.speed = 0;
        cam8Animator.speed = 0;
        cam9Animator.speed = 0;


    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            PlayCamera1();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            PlayCamera2();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            PlayCamera3();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            PlayCamera4();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            PlayCamera5();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            PlayCamera6();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            PlayCamera7();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            PlayCamera8();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            PlayCamera9();

        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            PlayCameraPlayer();

        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //else if (Input.GetKeyDown(KeyCode.Minus))
        //{
        //    GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
        //    foreach (GameObject go in gos)
        //    {
        //        if (go.layer == 5 && go.activeInHierarchy)
        //        {
        //            uiObjects.Add(go);
        //        }
        //    }

        //    foreach (GameObject uiObject in uiObjects)
        //    {
        //        uiObject.SetActive(false);
        //    }
        //}
        //else if (Input.GetKeyDown(KeyCode.Equals))
        //{
        //    foreach (GameObject uiObject in uiObjects)
        //    {
        //        uiObject.SetActive(true);
        //    }
        //    uiObjects.Clear();
        //}
    }

    private void DisableAllCams()
    {
        cam1.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam2.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam3.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam4.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam5.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam6.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam7.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam8.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;
        cam9.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = false;

        cam1Animator.speed = 0;
        cam2Animator.speed = 0;
        cam3Animator.speed = 0;
        cam4Animator.speed = 0;
        cam5Animator.speed = 0;
        cam6Animator.speed = 0;
        cam7Animator.speed = 0;
        cam8Animator.speed = 0;
        cam9Animator.speed = 0;

        selficam.SetActive(false);

    }





    public void PlayCamera1()
    {

        DisableAllCams();
        cam1.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam1preview.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam1Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam1Animator.speed = 0;
        }
        else
        {
            cam1Animator.Play("Cam1_Animation", -1, 0f);
            cam1Animator.speed = 1;
        }
    }

    public void PlayCamera2()
    {

        DisableAllCams();
        cam2.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam2preview.transform.position;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam2Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam2Animator.speed = 0;
        }
        else
        {
            cam2Animator.Play("Cam2_Animation", -1, 0f);
            cam2Animator.speed = 1;
        }

    }

    public void PlayCamera3()
    {


        DisableAllCams();
        cam3.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam3preview.transform.position;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam3Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam3Animator.speed = 0;
        }
        else
        {
            cam3Animator.Play("Cam3_Animation", -1, 0f);
            cam3Animator.speed = 1;
        }

    }

    public void PlayCamera4()
    {
        DisableAllCams();
        cam4.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam4preview.transform.position;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam4Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam4Animator.speed = 0;
        }
        else
        {
            cam4Animator.Play("Cam4_Animation", -1, 0f);
            cam4Animator.speed = 1;
        }

    }

    public void PlayCamera5()
    {

        DisableAllCams();
        cam5.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam5preview.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam5Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam5Animator.speed = 0;
        }
        else
        {
            cam5Animator.Play("Cam4_Animation", -1, 0f);
            cam5Animator.speed = 1;
        }


    }

    public void PlayCamera6()
    {

        DisableAllCams();
        cam6.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam6preview.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam6Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam6Animator.speed = 0;
        }
        else
        {
            cam6Animator.Play("Cam6_Animation", -1, 0f);
            cam6Animator.speed = 1;
        }

    }

    public void PlayCamera7()
    {
        DisableAllCams();
        cam7.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam7preview.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam7Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam7Animator.speed = 0;
        }
        else
        {
            cam7Animator.Play("Cam7_Animation", -1, 0f);
            cam7Animator.speed = 1;
        }

    }

    public void PlayCamera8()
    {
        DisableAllCams();
        cam8.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;
        selectionImage.transform.position = cam8preview.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam8Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam8Animator.speed = 0;
        }
        else
        {
            cam8Animator.Play("Cam8_Animation", -1, 0f);
            cam8Animator.speed = 1;
        }
    }

    public void PlayCamera9()
    {
        DisableAllCams();
        cam9.GetComponent<Cinemachine.CinemachineVirtualCamera>().enabled = true;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam9Animator.speed = 1;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            cam9Animator.speed = 0;
        }
        else
        {
            cam9Animator.Play("Cam9_Animation", -1, 0f);
            cam9Animator.speed = 1;
        }
    }





    public void PlaySelfiCam()
    {
        DisableAllCams();
        selectionImage.transform.position = camSelfiCamPreview.transform.position;
        selficam.SetActive(true);
    }


    public void PlayCameraPlayer()
    {
        DisableAllCams();
        selectionImage.transform.position = camPlayerPerview.transform.position;

    }
}

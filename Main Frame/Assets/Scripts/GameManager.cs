using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //Insert functions for loading scene for avatar creation
        //현재는 photoninit에서 loadscene하고 여기서 avatar 생성.
        //photoninit의 select tema 에서 create room 하기 전에 avatar 저작 기능 씬으로 이동했다가 가기
        //태곤이 구현해놓은 아바타 씬이동 코드 분석부터
        //CreateFemale();
        PhotonNetwork.IsMessageQueueRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFemale()
    {
        PhotonNetwork.Instantiate("Female 1 Variant", new Vector3(0, 3.0f, 0), Quaternion.identity);
    }
}

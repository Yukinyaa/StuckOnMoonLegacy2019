using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Collections;




public class GameThread : MonoBehaviour
{
    public bool usejobsystem;



    // Start is called before the first frame update
    void Start()
    {

    }

    public struct ItemCraftingData
    {
        
    }
    public struct ItemAssemblerGroup
    {
        [ReadOnly] public ItemCraftingData recipieSelected;

    }

    // Update is called once per frame
    void Update()
    {
        //렌더 끝내기
        //시뮬레이션 완료 기다리기
        //렌더 데이터 준비 및 렌더
        //맵 파일 락 풀기
        //저번 시뮬레이션에서 맵 파일 접근 작업 핸들
        //시뮬레이션 잡 시작
        //  조립기계 업데이트
        //  물류 업데이트
        //    삽입 - 제거 - 이동
    }
}

using UnityEngine;
using System.Collections;

namespace greta
{
    /// <summary>
    /// 學習協同程序，簡稱協程 Coroutine
    /// 目的 : 讓程式停留達到等待的效果
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        //使用協同程式的三個條件
        //1. 引用命名空間 System.Collections
        //2. 定義一個傳回 IEnumrator的方法
        //3. 方法內必須要使用 yield return
        //4. 使用 StartCoroutine 啟動

        private string testDIalogue = "好餓......好餓......";

        private void Awake()
        {
            // StartCoroutine(Test());

            //print("取得測試對話的第一個字 : " + testDIalogue[0]);
            // StartCoroutine(ShowDialogue());

            StartCoroutine(ShowDialogueUseFor());
        }

        private IEnumerator Test() 
        {
            print("<color=#33ff33>第一行程式</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>第二行程式</color>");
            yield return new WaitForSeconds(3);
            print("<color=#3333ff>第三行程式</color>");
        }

        private IEnumerator ShowDialogue() 
        {
            print(testDIalogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(testDIalogue[1]);
            yield return new WaitForSeconds(0.1f);
            print(testDIalogue[2]);
            yield return new WaitForSeconds(0.1f);
        }

        private IEnumerator ShowDialogueUseFor() 
        {
            for (int i = 0; i < testDIalogue.Length; i++) 
            {
                print(testDIalogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }
    }

}


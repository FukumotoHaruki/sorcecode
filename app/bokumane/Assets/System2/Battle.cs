using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour {
    public static int battlecount; //何バトル目か
    private Status status;
    private TekiStatus teki;
    private Bar bar;

    const string ButtonName1 = "Button1";
    private GameObject buttonObj1;
    const string ButtonName2 = "Button2";
    private GameObject buttonObj2;
    const string ButtonName3 = "Button3";
    private GameObject buttonObj3;
    const string ButtonName4 = "Button4";
    private GameObject buttonObj4;

    const string wearName = "Avater0";
    const string aName = "Avatera";
    const string AName = "AvaterA";
    const string bName = "Avaterb";
    const string BName = "AvaterB";
    const string cName = "Avaterc";
    const string CName = "AvaterC";
    const string dName = "Avaterd";
    const string DName = "AvaterD";
    const string eName = "Avatere";
    const string EName = "AvaterE";
    private GameObject Ava;

    public void Battles(int x)
    {
        teki = GetComponent<TekiStatus>(); //コマンドの処理
        bar = GetComponent<Bar>();

        if (x == 1)
        {
            Ava.GetComponent<Animator>().SetTrigger("AttackTrigger");
            if (battlecount == 2)
            {
                GameObject.Find("boss").GetComponent<Animator>().SetTrigger("boss1DamageTrigger");
            }
            else
            {
                GameObject.Find("Teki").GetComponent<Animator>().SetTrigger("Teki1DamageTrigger");
            }
                teki.TekiHp -= Status.Attack;
        }
        else if (x == 2)
        {
            Ava.GetComponent<Animator>().SetTrigger("AttackTrigger");
            if (battlecount == 2)
            {
                GameObject.Find("boss").GetComponent<Animator>().SetTrigger("boss1DamageTrigger");
            }
            else
            {
                GameObject.Find("Teki").GetComponent<Animator>().SetTrigger("Teki1DamageTrigger");
            }
            Status.Mp -= 10;
            teki.TekiHp = teki.TekiHp - Status.Attack * 2;
        }
        else if (x == 3)
        {
            Ava.GetComponent<Animator>().SetTrigger("AttackTrigger");
            if (battlecount == 2)
            {
                GameObject.Find("boss").GetComponent<Animator>().SetTrigger("boss1DamageTrigger");
            }
            else
            {
                GameObject.Find("Teki").GetComponent<Animator>().SetTrigger("Teki1DamageTrigger");
            }
            Status.Mp -= (Avater.MP / 2);
            teki.TekiHp = teki.TekiHp - Status.Attack * 7;
        }
        else if (x == 4)
        {
            if (Status.Mp <= (Avater.MP - 20))
            {
                Status.Mp += 20;
            }
            else
            {
                Status.Mp = Avater.MP;
            }

            if (Status.Hp <= (Avater.HP - 20))
            {
                Status.Hp += 20;
            }
            else
            {
                Status.Hp = Avater.HP;
            }
        }
        bar.MPset(Status.Mp);
        bar.TekiHPset(teki.TekiHp);

        if (teki.TekiHp > 0)
        {
            StartCoroutine("Tekiattack");
        }
        else
        {
            if (battlecount == 2)
            {
                GameObject.Find("boss").GetComponent<Animator>().SetTrigger("boss1FlyTrigger");
            }
            else
            {
                GameObject.Find("Teki").GetComponent<Animator>().SetTrigger("FlyTrigger");
            }
            Ava.GetComponent<Animator>().SetTrigger("ClearTrigger");
            StartCoroutine("Clear");
        }

        
    }
    public IEnumerator Tekiattack()
    {
            yield return new WaitForSeconds(1);
        if (battlecount == 2)
        {
            GameObject.Find("boss").GetComponent<Animator>().SetTrigger("boss1AttackTrigger");
        }
        else
        {
            GameObject.Find("Teki").GetComponent<Animator>().SetTrigger("Teki1AttackTrigger");
        }
            Ava.GetComponent<Animator>().SetTrigger("DamageTrigger");
        //if ((teki.TekiAttack - Status.Defense) <= 0 || (teki.TekiAttack - Status.Defense) <= 20){
       //     Status.Hp = Status.Hp - 20;
       // }else{
            Status.Hp = Status.Hp - (teki.TekiAttack - Status.Defense);/////////////////////////////////
       // }
            bar.HPset(Status.Hp);

        buttonObj1.SetActive(true);
        buttonObj4.SetActive(true);
        if (Status.Mp <= 10)
        {
            buttonObj2.SetActive(false);
        }
        else
        {
            buttonObj2.SetActive(true);
        }
        if (Status.Mp <= (Avater.MP / 2))
        {
            buttonObj3.SetActive(false);
        }
        else
        {
            buttonObj3.SetActive(true);
        }
        //Debug.Log("sute" + Status.Hp);
    }
    public IEnumerator Clear()
    {
        yield return new WaitForSeconds(3); // num秒待機
        if (battlecount == 0)
        {
            battlecount += 1;
            if (Dungeon.DUNGEON == 1)
            {
                SceneManager.LoadScene("Battle1-2");
            }
            else if (Dungeon.DUNGEON == 2)
            {
                SceneManager.LoadScene("Battle2-2");
            }
            else if (Dungeon.DUNGEON == 3)
            {
                SceneManager.LoadScene("Battle3-2");
            }
            else if (Dungeon.DUNGEON == 4)
            {
                SceneManager.LoadScene("Battle4-2");
            }
            else if (Dungeon.DUNGEON == 5)
            {
                SceneManager.LoadScene("Battle5-2");
            }
        }
        else if (battlecount == 1)
        {
            battlecount += 1;
            if (Dungeon.DUNGEON == 1)
            {
                SceneManager.LoadScene("Battle1-3");
            }
            else if (Dungeon.DUNGEON == 2)
            {
                SceneManager.LoadScene("Battle2-3");
            }
            else if (Dungeon.DUNGEON == 3)
            {
                SceneManager.LoadScene("Battle3-3");
            }
            else if (Dungeon.DUNGEON == 4)
            {
                SceneManager.LoadScene("Battle4-3");
            }
            else if (Dungeon.DUNGEON == 5)
            {
                SceneManager.LoadScene("Battle5-3");
            }
        }
        else if (battlecount == 2)
        {
            battlecount = 0;
           // Debug.Log("win");
            SceneManager.LoadScene("gameclear");
        }
    }
    // Use this for initialization
    void Start()
    {
        if(battlecount == 0)
        {
            status = GetComponent<Status>();
            status.StatusReset();
        }
        else if(battlecount == 1)
        {
            //Debug.Log("battle2!");
        }
        else if(battlecount == 2)
        {
           // Debug.Log("battle3!");
        }

        buttonObj1 = GameObject.Find(ButtonName1);
        buttonObj2 = GameObject.Find(ButtonName2);
        buttonObj3 = GameObject.Find(ButtonName3);
        buttonObj4 = GameObject.Find(ButtonName4);

        buttonObj1.SetActive(true);
        buttonObj2.SetActive(true);
        buttonObj3.SetActive(true);
        buttonObj4.SetActive(true);
        if (Status.Mp <= 10)
        {
            buttonObj2.SetActive(false);
        }
        if (Status.Mp <= (Avater.MP / 2))
        {
            buttonObj3.SetActive(false);
        }

        if (Avater.WEAR == 0)
        {
            Ava = GameObject.Find(wearName);
        }
        else if (Avater.WEAR == 1)
        {
            Ava = GameObject.Find(aName);
        }
        else if (Avater.WEAR == 2)
        {
            Ava = GameObject.Find(bName);
        }
        else if (Avater.WEAR == 3)
        {
            Ava = GameObject.Find(cName);
        }
        else if (Avater.WEAR == 4)
        {
            Ava = GameObject.Find(dName);
        }
        else if (Avater.WEAR == 5)
        {
            Ava = GameObject.Find(eName);
        }
        else if (Avater.WEAR == 6)
        {
            Ava = GameObject.Find(AName);
        }
        else if (Avater.WEAR == 7)
        {
            Ava = GameObject.Find(BName);
        }
        else if (Avater.WEAR == 8)
        {
            Ava = GameObject.Find(CName);
        }
        else if (Avater.WEAR == 9)
        {
            Ava = GameObject.Find(DName);
        }
        else if (Avater.WEAR == 10)
        {
            Ava = GameObject.Find(EName);
        }
        else
        {
            Ava = GameObject.Find(wearName);
        }
    }
    
	// Update is called once per frame
	void Update () {
        if (Status.Hp < 0)
        {
            SceneManager.LoadScene("gameover");
        }
        
    }
}

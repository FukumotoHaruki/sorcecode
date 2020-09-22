using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class ItemManager : MonoBehaviour {

    GameObject a1Item;
    GameObject a2Item;
    GameObject a3Item;
    GameObject a4Item;
    GameObject A1Item;
    GameObject A2Item;
    GameObject A3Item;
    GameObject A4Item;
    GameObject b1Item;
    GameObject b2Item;
    GameObject b3Item;
    GameObject b4Item;
    GameObject B1Item;
    GameObject B2Item;
    GameObject B3Item;
    GameObject B4Item;
    GameObject c1Item;
    GameObject c2Item;
    GameObject c3Item;
    GameObject c4Item;
    GameObject C1Item;
    GameObject C2Item;
    GameObject C3Item;
    GameObject C4Item;
    GameObject d1Item;
    GameObject d2Item;
    GameObject d3Item;
    GameObject d4Item;
    GameObject D1Item;
    GameObject D2Item;
    GameObject D3Item;
    GameObject D4Item;
    GameObject e1Item;
    GameObject e2Item;
    GameObject e3Item;
    GameObject e4Item;
    GameObject E1Item;
    GameObject E2Item;
    GameObject E3Item;
    GameObject E4Item;

    GameObject Item0;
    GameObject Item1;
    GameObject Item2;
    GameObject Item3;
    GameObject Item4;
    GameObject Item5;
    GameObject Item6;
    GameObject Item7;
    GameObject Item8;
    GameObject Item9;

    GameObject button0;
    GameObject button1;
    GameObject button2;
    GameObject button3;
    GameObject button4;
    GameObject button5;
    GameObject button6;
    GameObject button7;
    GameObject button8;
    GameObject button9;

    // Use this for initialization
    void Start () {
        string[] W = new string[41];

        StreamReader srW = new StreamReader("DropData.txt", Encoding.GetEncoding("UTF-8"));
        for (int i = 0; i < 41; i++)
        {

            string line = srW.ReadLine();
            W[i] = line;
        }
        // StreamReaderを閉じる
        srW.Close();

        if (W[1] == "0"){
            a1Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a1Image");
            a1Item.SetActive(false);
        }else if (W[1] == "1"){
            a1Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a1Image");
            a1Item.SetActive(true);
        }

        if (W[11] == "0") {
            a2Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a2Image");
            a2Item.SetActive(false);
        }else if (W[11] == "1"){
            a2Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a2Image");
            a2Item.SetActive(true);
        }

        if (W[21] == "0"){ 
            a3Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a3Image");
            a3Item.SetActive(false);
        }else if (W[21] == "1"){
            a3Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a3Image");
            a3Item.SetActive(true);
        }

        if (W[31] == "0"){
            a4Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a4Image");
            a4Item.SetActive(false);
        }else if (W[31] == "1"){
            a4Item = GameObject.Find("Canvas/ScrollViewer/Content/aItem/ItemImage/a4Image");
            a4Item.SetActive(true);
        }

        if (W[0] == "0"){
            A1Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A1Image");
            A1Item.SetActive(false);
        }else if (W[0] == "1"){
            A1Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A1Image");
            A1Item.SetActive(true);
        }

        if (W[10] == "0"){
            A2Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A2Image");
            A2Item.SetActive(false);
        }else if (W[10] == "1"){
            A2Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A2Image");
            A2Item.SetActive(true);
        }

        if (W[20] == "0"){
            A3Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A3Image");
            A3Item.SetActive(false);
        }else if (W[20] == "1"){
            A3Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A3Image");
            A3Item.SetActive(true);
        }
        
        if (W[30] == "0"){
            A4Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A4Image");
            A4Item.SetActive(false);
        }else if (W[30] == "1"){
            A4Item = GameObject.Find("Canvas/ScrollViewer/Content/AItem/ItemImage/A4Image");
            A4Item.SetActive(true);
        }
        
        if (W[3] == "0"){
            b1Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b1Image");
            b1Item.SetActive(false);
        }else if (W[3] == "1"){
            b1Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b1Image");
            b1Item.SetActive(true);
        }
        
        if (W[13] == "0"){
            b2Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b2Image");
            b2Item.SetActive(false);
        }else if (W[13] == "1"){
            b2Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b2Image");
            b2Item.SetActive(true);
        }
        
        if (W[23] == "0"){
            b3Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b3Image");
            b3Item.SetActive(false);
        }else if (W[23] == "1"){
            b3Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b3Image");
            b3Item.SetActive(true);
        }
        
        if (W[33] == "0"){
            b4Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b4Image");
            b4Item.SetActive(false);
        }else if (W[33] == "1"){
            b4Item = GameObject.Find("Canvas/ScrollViewer/Content/bItem/ItemImage/b4Image");
            b4Item.SetActive(true);
        }
        
        if (W[2] == "0"){
            B1Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B1Image");
            B1Item.SetActive(false);
        }else if (W[2] == "1"){
            B1Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B1Image");
            B1Item.SetActive(true);
        }
        
        if (W[12] == "0"){
            B2Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B2Image");
            B2Item.SetActive(false);
        }else if (W[12] == "1"){
            B2Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B2Image");
            B2Item.SetActive(true);
        }

        if (W[22] == "0"){
            B3Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B3Image");
            B3Item.SetActive(false);
        }else if (W[22] == "1"){
            B3Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B3Image");
            B3Item.SetActive(true);
        }

        if (W[32] == "0"){
            B4Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B4Image");
            B4Item.SetActive(false);
        }else if (W[32] == "1"){
            B4Item = GameObject.Find("Canvas/ScrollViewer/Content/BItem/ItemImage/B4Image");
            B4Item.SetActive(true);
        }

        if (W[5] == "0"){
            c1Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c1Image");
            c1Item.SetActive(false);
        }else if (W[5] == "1"){
            c1Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c1Image");
            c1Item.SetActive(true);
        }

        if (W[15] == "0"){
            c2Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c2Image");
            c2Item.SetActive(false);
        }else if (W[15] == "1"){
            c2Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c2Image");
            c2Item.SetActive(true);
        }

        if (W[25] == "0"){
            c3Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c3Image");
            c3Item.SetActive(false);
        }else if (W[25] == "1"){
            c3Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c3Image");
            c3Item.SetActive(true);
        }

        if (W[35] == "0"){
            c4Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c4Image");
            c4Item.SetActive(false);
        }else if (W[35] == "1"){
            c4Item = GameObject.Find("Canvas/ScrollViewer/Content/cItem/ItemImage/c4Image");
            c4Item.SetActive(true);
        }

        if (W[4] == "0"){
            C1Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C1Image");
            C1Item.SetActive(false);
        }else if (W[4] == "1"){
            C1Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C1Image");
            C1Item.SetActive(true);
        }

        if (W[14] == "0"){
            C2Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C2Image");
            C2Item.SetActive(false);
        }else if (W[14] == "1"){
            C2Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C2Image");
            C2Item.SetActive(true);
        }

        if (W[24] == "0"){
            C3Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C3Image");
            C3Item.SetActive(false);
        }else if (W[24] == "1"){
            C3Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C3Image");
            C3Item.SetActive(true);
        }

        if (W[34] == "0"){
            C4Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C4Image");
            C4Item.SetActive(false);
        }else if (W[34] == "1"){
            C4Item = GameObject.Find("Canvas/ScrollViewer/Content/CItem/ItemImage/C4Image");
            C4Item.SetActive(true);
        }

        if (W[7] == "0"){
            d1Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d1Image");
            d1Item.SetActive(false);
        }else if (W[7] == "1"){
            d1Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d1Image");
            d1Item.SetActive(true);
        }

        if (W[17] == "0"){
            d2Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d2Image");
            d2Item.SetActive(false);
        }else if (W[17] == "1"){
            d2Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d2Image");
            d2Item.SetActive(true);
        }

        if (W[27] == "0"){
            d3Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d3Image");
            d3Item.SetActive(false);
        }else if (W[27] == "1"){
            d3Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d3Image");
            d3Item.SetActive(true);
        }

        if (W[37] == "0"){
            d4Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d4Image");
            d4Item.SetActive(false);
        }else if (W[37] == "1"){
            d4Item = GameObject.Find("Canvas/ScrollViewer/Content/dItem/ItemImage/d4Image");
            d4Item.SetActive(true);
        }

        if (W[6] == "0"){
            D1Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D1Image");
            D1Item.SetActive(false);
        }else if (W[6] == "1"){
            D1Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D1Image");
            D1Item.SetActive(true);
        }

        if (W[16] == "0"){
            D2Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D2Image");
            D2Item.SetActive(false);
        }else if (W[16] == "1"){
            D2Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D2Image");
            D2Item.SetActive(true);
        }

        if (W[26] == "0"){
            D3Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D3Image");
            D3Item.SetActive(false);
        }else if (W[26] == "1"){
            D3Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D3Image");
            D3Item.SetActive(true);
        }

        if (W[36] == "0"){
            D4Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D4Image");
            D4Item.SetActive(false);
        }else if (W[36] == "1"){
            D4Item = GameObject.Find("Canvas/ScrollViewer/Content/DItem/ItemImage/D4Image");
            D4Item.SetActive(true);
        }

        if (W[9] == "0"){
            e1Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e1Image");
            e1Item.SetActive(false);
        }else if (W[9] == "1"){
            e1Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e1Image");
            e1Item.SetActive(true);
        }

        if (W[19] == "0"){
            e2Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e2Image");
            e2Item.SetActive(false);
        }else if (W[19] == "1"){
            e2Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e2Image");
            e2Item.SetActive(true);
        }

        if (W[29] == "0"){
            e3Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e3Image");
            e3Item.SetActive(false);
        }else if (W[29] == "1"){
            e3Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e3Image");
            e3Item.SetActive(true);
        }

        if (W[39] == "0"){
            e4Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e4Image");
            e4Item.SetActive(false);
        }else if (W[39] == "1"){
            e4Item = GameObject.Find("Canvas/ScrollViewer/Content/eItem/ItemImage/e4Image");
            e4Item.SetActive(true);
        }

        if (W[8] == "0"){
            E1Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E1Image");
            E1Item.SetActive(false);
        }else if (W[8] == "1"){
            E1Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E1Image");
            E1Item.SetActive(true);
        }

        if (W[18] == "0"){
            E2Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E2Image");
            E2Item.SetActive(false);
        }else if (W[18] == "1"){
            E2Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E2Image");
            E2Item.SetActive(true);
        }

        if (W[28] == "0"){
            E3Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E3Image");
            E3Item.SetActive(false);
        }else if (W[28] == "1"){
            E3Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E3Image");
            E3Item.SetActive(true);
        }

        if (W[38] == "0"){
            E4Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E4Image");
            E4Item.SetActive(false);
        }else if (W[38] == "1"){
            E4Item = GameObject.Find("Canvas/ScrollViewer/Content/EItem/ItemImage/E4Image");
            E4Item.SetActive(true);
        }


        if (W[1] == "1" && W[11] == "1" && W[21] == "1" && W[31] == "1")
        {
            Item1 = GameObject.Find("Canvas/ScrollViewer/Content/aItem/TrueItem");
            Item1.SetActive(true);
        }else
        {
            Item1 = GameObject.Find("Canvas/ScrollViewer/Content/aItem/TrueItem");
            Item1.SetActive(false);
        }

        if (W[0] == "1" && W[10] == "1" && W[20] == "1" && W[30] == "1")
        {
            Item0 = GameObject.Find("Canvas/ScrollViewer/Content/AItem/TrueItem");
            Item0.SetActive(true);
        }
        else
        {
            Item0 = GameObject.Find("Canvas/ScrollViewer/Content/AItem/TrueItem");
            Item0.SetActive(false);
        }

        if (W[3] == "1" && W[13] == "1" && W[23] == "1" && W[33] == "1")
        {
            Item3 = GameObject.Find("Canvas/ScrollViewer/Content/bItem/TrueItem");
            Item3.SetActive(true);
        }
        else
        {
            Item3 = GameObject.Find("Canvas/ScrollViewer/Content/bItem/TrueItem");
            Item3.SetActive(false);
        }

        if (W[2] == "1" && W[12] == "1" && W[22] == "1" && W[32] == "1")
        {
            Item2 = GameObject.Find("Canvas/ScrollViewer/Content/BItem/TrueItem");
            Item2.SetActive(true);
        }
        else
        {
            Item2 = GameObject.Find("Canvas/ScrollViewer/Content/BItem/TrueItem");
            Item2.SetActive(false);
        }

        if (W[5] == "1" && W[15] == "1" && W[25] == "1" && W[35] == "1")
        {
            Item5 = GameObject.Find("Canvas/ScrollViewer/Content/cItem/TrueItem");
            Item5.SetActive(true);
        }
        else
        {
            Item5 = GameObject.Find("Canvas/ScrollViewer/Content/cItem/TrueItem");
            Item5.SetActive(false);
        }

        if (W[4] == "1" && W[14] == "1" && W[24] == "1" && W[34] == "1")
        {
            Item4 = GameObject.Find("Canvas/ScrollViewer/Content/CItem/TrueItem");
            Item4.SetActive(true);
        }
        else
        {
            Item4 = GameObject.Find("Canvas/ScrollViewer/Content/CItem/TrueItem");
            Item4.SetActive(false);
        }

        if (W[7] == "1" && W[17] == "1" && W[27] == "1" && W[37] == "1")
        {
            Item7 = GameObject.Find("Canvas/ScrollViewer/Content/dItem/TrueItem");
            Item7.SetActive(true);
        }
        else
        {
            Item7 = GameObject.Find("Canvas/ScrollViewer/Content/dItem/TrueItem");
            Item7.SetActive(false);
        }

        if (W[6] == "1" && W[16] == "1" && W[26] == "1" && W[36] == "1")
        {
            Item6 = GameObject.Find("Canvas/ScrollViewer/Content/DItem/TrueItem");
            Item6.SetActive(true);
        }
        else
        {
            Item6 = GameObject.Find("Canvas/ScrollViewer/Content/DItem/TrueItem");
            Item6.SetActive(false);
        }

        if (W[9] == "1" && W[19] == "1" && W[29] == "1" && W[39] == "1")
        {
            Item9 = GameObject.Find("Canvas/ScrollViewer/Content/eItem/TrueItem");
            Item9.SetActive(true);
        }
        else
        {
            Item9 = GameObject.Find("Canvas/ScrollViewer/Content/eItem/TrueItem");
            Item9.SetActive(false);
        }

        if (W[8] == "1" && W[18] == "1" && W[28] == "1" && W[38] == "1")
        {
            Item8 = GameObject.Find("Canvas/ScrollViewer/Content/EItem/TrueItem");
            Item8.SetActive(true);
        }
        else
        {
            Item8 = GameObject.Find("Canvas/ScrollViewer/Content/EItem/TrueItem");
            Item8.SetActive(false);
        }

        button0 = GameObject.Find("Canvas/ScrollViewer/Content/aItem/reset");
        button0.SetActive(false);
        button1 = GameObject.Find("Canvas/ScrollViewer/Content/AItem/reset");
        button1.SetActive(false);
        button2 = GameObject.Find("Canvas/ScrollViewer/Content/bItem/reset");
        button2.SetActive(false);
        button3 = GameObject.Find("Canvas/ScrollViewer/Content/BItem/reset");
        button3.SetActive(false);
        button4 = GameObject.Find("Canvas/ScrollViewer/Content/cItem/reset");
        button4.SetActive(false);
        button5 = GameObject.Find("Canvas/ScrollViewer/Content/CItem/reset");
        button5.SetActive(false);
        button6 = GameObject.Find("Canvas/ScrollViewer/Content/dItem/reset");
        button6.SetActive(false);
        button7 = GameObject.Find("Canvas/ScrollViewer/Content/DItem/reset");
        button7.SetActive(false);
        button8 = GameObject.Find("Canvas/ScrollViewer/Content/eItem/reset");
        button8.SetActive(false);
        button9 = GameObject.Find("Canvas/ScrollViewer/Content/EItem/reset");
        button9.SetActive(false);

        if (Avater.WEAR == 1)
        {
            button0 = GameObject.Find("Canvas/ScrollViewer/Content/aItem/reset");
            button0.SetActive(true);
        }
        else if (Avater.WEAR == 6)
        {
            button1 = GameObject.Find("Canvas/ScrollViewer/Content/AItem/reset");
            button1.SetActive(true);
        }
        else if (Avater.WEAR == 2)
        {
            button2 = GameObject.Find("Canvas/ScrollViewer/Content/bItem/reset");
            button2.SetActive(true);
        }
        else if (Avater.WEAR == 7)
        {
            button3 = GameObject.Find("Canvas/ScrollViewer/Content/BItem/reset");
            button3.SetActive(true);
        }
        else if (Avater.WEAR == 3)
        {
            button4 = GameObject.Find("Canvas/ScrollViewer/Content/cItem/reset");
            button4.SetActive(true);
        }
        else if (Avater.WEAR == 8)
        {
            button5 = GameObject.Find("Canvas/ScrollViewer/Content/CItem/reset");
            button5.SetActive(true);
        }
        else if (Avater.WEAR == 4)
        {
            button6 = GameObject.Find("Canvas/ScrollViewer/Content/dItem/reset");
            button6.SetActive(true);
        }
        else if (Avater.WEAR == 9)
        {
            button7 = GameObject.Find("Canvas/ScrollViewer/Content/DItem/reset");
            button7.SetActive(true);
        }
        else if (Avater.WEAR == 5)
        {
            button8 = GameObject.Find("Canvas/ScrollViewer/Content/eItem/reset");
            button8.SetActive(true);
        }
        else if (Avater.WEAR == 10)
        {
            button9 = GameObject.Find("Canvas/ScrollViewer/Content/EItem/reset");
            button9.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

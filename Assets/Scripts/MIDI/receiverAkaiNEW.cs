using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;


public class receiverAkaiNEW : MonoBehaviour
{
    [Header("RECEIVED VALUES")]
    //==FIRST ROW==//
    //Knobs
    [Header("First Row")]
    public float receive11;
    public float receive12;
    public float receive13;
    public float receive14;
    public float receive15;
    public float receive16;
    public float receive17;
    public float receive18;
    //Key 
    //DONT USE THAT! IT JUST SENDS ALL VALUES
    //public bool receive19;

    //==SECOND ROW==//
    //Knobs
    [Header("Second Row")]
    public float receive21;
    public float receive22;
    public float receive23;
    public float receive24;
    public float receive25;
    public float receive26;
    public float receive27;
    public float receive28;
    //Key
    public bool receive29;

    //==THIRD ROW==//
    //Knobs
    [Header("Third Row")]
    public float receive31;
    public float receive32;
    public float receive33;
    public float receive34;
    public float receive35;
    public float receive36;
    public float receive37;
    public float receive38;
    //Key
    public bool receive39;



    //==FOURTH ROW==//
    //Key
    [Header("Fourth Row")]
    public bool receive41;
    public bool receive42;
    public bool receive43;
    public bool receive44;
    public bool receive45;
    public bool receive46;
    public bool receive47;
    public bool receive48;
    public bool receive49;


    //==FIFTH ROW==//
    //Key
    [Header("Fifth Row")]
    public bool receive51;
    public bool receive52;
    public bool receive53;
    public bool receive54;
    public bool receive55;
    public bool receive56;
    public bool receive57;
    public bool receive58;



    //==SIXTH ROW==//
    //Knobs
    [Header("Sixth Row")]
    public float receive61;
    public float receive62;
    public float receive63;
    public float receive64;
    public float receive65;
    public float receive66;
    public float receive67;
    public float receive68;
    public float receive69;


    void Start()
    {
        print("START AKAI");
    }
    void Update()
    {
        //GetAllValues();
        UpdateMIDIValues();
    }

    void OnEnable()
    {
        // MidiMaster.noteOnDelegate += NoteOn;
    }

    void OnDisable()
    {
        //MidiMaster.noteOnDelegate -= NoteOn;
    }

    public int SetReceiverMidiValue(int receiver)
    {
        int val = 0;

        switch (receiver)
        {
            case 11:
                val = 16;
                break;
            case 12:
                val = 20;
                break;
            case 13:
                val = 24;
                break;
            case 14:
                val = 28;
                break;
            case 15:
                val = 46;
                break;
            case 16:
                val = 50;
                break;
            case 17:
                val = 54;
                break;
            case 18:
                val = 58;
                break;

            case 21:
                val = 17;
                break;
            case 22:
                val = 21;
                break;
            case 23:
                val = 25;
                break;
            case 24:
                val = 29;
                break;
            case 25:
                val = 47;
                break;
            case 26:
                val = 51;
                break;
            case 27:
                val = 55;
                break;
            case 28:
                val = 59;
                break;

            case 31:
                val = 18;
                break;
            case 32:
                val = 22;
                break;
            case 33:
                val = 26;
                break;
            case 34:
                val = 30;
                break;
            case 35:
                val = 48;
                break;
            case 36:
                val = 52;
                break;
            case 37:
                val = 56;
                break;
            case 38:
                val = 60;
                break;

            case 61:
                val = 19;
                break;
            case 62:
                val = 23;
                break;
            case 63:
                val = 27;
                break;
            case 64:
                val = 31;
                break;
            case 65:
                val = 49;
                break;
            case 66:
                val = 53;
                break;
            case 67:
                val = 57;
                break;
            case 68:
                val = 61;
                break;
            case 69:
                val = 62;
                break;
        }
        return val;
    }
    public void UpdateMIDIValues()
    {
        receive11 = MidiMaster.GetKnob(16);
        receive12 = MidiMaster.GetKnob(20);
        receive13 = MidiMaster.GetKnob(24);
        receive14 = MidiMaster.GetKnob(28);
        receive15 = MidiMaster.GetKnob(46);
        receive16 = MidiMaster.GetKnob(50);
        receive17 = MidiMaster.GetKnob(54);
        receive18 = MidiMaster.GetKnob(58);

        receive21 = MidiMaster.GetKnob(17);
        receive22 = MidiMaster.GetKnob(21);
        receive23 = MidiMaster.GetKnob(25);
        receive24 = MidiMaster.GetKnob(29);
        receive25 = MidiMaster.GetKnob(47);
        receive26 = MidiMaster.GetKnob(51);
        receive27 = MidiMaster.GetKnob(55);
        receive28 = MidiMaster.GetKnob(59);


        receive31 = MidiMaster.GetKnob(18);
        receive32 = MidiMaster.GetKnob(22);
        receive33 = MidiMaster.GetKnob(26);
        receive34 = MidiMaster.GetKnob(30);
        receive35 = MidiMaster.GetKnob(48);
        receive36 = MidiMaster.GetKnob(52);
        receive37 = MidiMaster.GetKnob(56);
        receive38 = MidiMaster.GetKnob(60);

        receive61 = MidiMaster.GetKnob(19);
        receive62 = MidiMaster.GetKnob(23);
        receive63 = MidiMaster.GetKnob(27);
        receive64 = MidiMaster.GetKnob(31);
        receive65 = MidiMaster.GetKnob(49);
        receive66 = MidiMaster.GetKnob(53);
        receive67 = MidiMaster.GetKnob(57);
        receive68 = MidiMaster.GetKnob(61);
        receive69 = MidiMaster.GetKnob(62);
    }


    public void GetAllValues()
    {
        Receive11();
        Receive12();
        Receive13();
        Receive14();
        Receive15();
        Receive16();
        Receive17();
        Receive18();

        Receive21();
        Receive22();
        Receive23();
        Receive24();
        Receive25();
        Receive26();
        Receive27();
        Receive28();

        Receive31();
        Receive32();
        Receive33();
        Receive34();
        Receive35();
        Receive36();
        Receive37();
        Receive38();

        Receive61();
        Receive62();
        Receive63();
        Receive64();
        Receive65();
        Receive66();
        Receive67();
        Receive68();
        Receive69();
    }

    #region FIRST ROW FUNTIONS
    public float Receive11()
    {
        return receive11 = MidiMaster.GetKnob(16);
    }
    public float Receive12()
    {
        return receive12 = MidiMaster.GetKnob(20);
    }
    public float Receive13()
    {
        return receive13 = MidiMaster.GetKnob(24);
    }
    public float Receive14()
    {
        return receive14 = MidiMaster.GetKnob(28);
    }
    public float Receive15()
    {
        return receive15 = MidiMaster.GetKnob(46);
    }
    public float Receive16()
    {
        return receive16 = MidiMaster.GetKnob(50);
    }
    public float Receive17()
    {
        return receive17 = MidiMaster.GetKnob(54);
    }
    public float Receive18()
    {
        return receive18 = MidiMaster.GetKnob(58);
    }
    #endregion

    #region SECOND ROW FUNCTIONS
    public float Receive21()
    {
        return receive21 = MidiMaster.GetKnob(17);
    }
    public float Receive22()
    {
        return receive22 = MidiMaster.GetKnob(21);
    }
    public float Receive23()
    {
        return receive23 = MidiMaster.GetKnob(25);
    }
    public float Receive24()
    {
        return receive24 = MidiMaster.GetKnob(29);
    }
    public float Receive25()
    {
        return receive25 = MidiMaster.GetKnob(47);
    }
    public float Receive26()
    {
        return receive26 = MidiMaster.GetKnob(51);
    }
    public float Receive27()
    {
        return receive27 = MidiMaster.GetKnob(55);
    }
    public float Receive28()
    {
        return receive28 = MidiMaster.GetKnob(59);
    }
    #endregion

    #region THIRD ROW FUNCTIONS
    public float Receive31()
    {
        return receive31 = MidiMaster.GetKnob(18);
    }
    public float Receive32()
    {
        return receive32 = MidiMaster.GetKnob(22);
    }
    public float Receive33()
    {
        return receive33 = MidiMaster.GetKnob(26);
    }
    public float Receive34()
    {
        return receive34 = MidiMaster.GetKnob(30);
    }
    public float Receive35()
    {
        return receive35 = MidiMaster.GetKnob(48);
    }
    public float Receive36()
    {
        return receive36 = MidiMaster.GetKnob(52);
    }
    public float Receive37()
    {
        return receive37 = MidiMaster.GetKnob(56);
    }
    public float Receive38()
    {
        return receive38 = MidiMaster.GetKnob(60);
    }
    #endregion

    #region SIXTH ROW FUNCTIONS
    public float Receive61()
    {
        return receive61 = MidiMaster.GetKnob(19);
    }
    public float Receive62()
    {
        return receive62 = MidiMaster.GetKnob(23);
    }
    public float Receive63()
    {
        return receive63 = MidiMaster.GetKnob(27);
    }
    public float Receive64()
    {
        return receive64 = MidiMaster.GetKnob(31);
    }
    public float Receive65()
    {
        return receive65 = MidiMaster.GetKnob(49);
    }
    public float Receive66()
    {
        return receive66 = MidiMaster.GetKnob(53);
    }
    public float Receive67()
    {
        return receive67 = MidiMaster.GetKnob(57);
    }
    public float Receive68()
    {
        return receive68 = MidiMaster.GetKnob(61);
    }

    public float Receive69()
    {
        return receive69 = MidiMaster.GetKnob(62);
    }
    #endregion

    void NoteOn(MidiChannel channel, int note, float velocity)
    {
        switch (note)
        {
            case 25:
                receive29 = (!receive29);
                print("29" + receive29);
                break;
            case 26:
                receive39 = (!receive39);
                print("39" + receive39);
                break;
            case 1:
                receive41 = (!receive41);
                print("29" + receive41);
                break;
            case 4:
                receive42 = (!receive42);
                print("39" + receive42);
                break;
            case 7:
                receive43 = (!receive43);
                print("29" + receive43);
                break;
            case 10:
                receive44 = (!receive44);
                print("39" + receive44);
                break;
            case 13:
                receive45 = (!receive45);
                print("29" + receive45);
                break;
            case 16:
                receive46 = (!receive46);
                print("39" + receive46);
                break;
            case 19:
                receive47 = (!receive47);
                print("29" + receive47);
                break;
            case 22:
                receive48 = (!receive48);
                print("39" + receive48);
                break;
            case 27:
                receive49 = (!receive49);
                print("39" + receive49);
                break;
            case 3:
                receive51 = (!receive51);
                print("29" + receive51);
                break;
            case 6:
                receive52 = (!receive52);
                print("39" + receive52);
                break;
            case 9:
                receive53 = (!receive53);
                print("29" + receive53);
                break;
            case 12:
                receive54 = (!receive54);
                print("39" + receive54);
                break;
            case 15:
                receive55 = (!receive55);
                print("29" + receive55);
                break;
            case 18:
                receive56 = (!receive56);
                print("39" + receive56);
                break;
            case 21:
                receive57 = (!receive57);
                print("29" + receive57);
                break;
            case 24:
                receive58 = (!receive58);
                print("39" + receive58);
                break;
        }
    }

}

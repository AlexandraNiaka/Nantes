using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;
using Unity.Mathematics;
public class rotateMoveCameraAkaiNEW : MonoBehaviour
{
    #region MIDI Ports
    [Header("CHOSEN MIDI CHANNEL")]
    [SerializeField]
    private int xMIDI;
    private int receiverX;
    [SerializeField]
    private int yMIDI;
    private int receiverY;
    [SerializeField]
    private int zMIDI;
    private int receiverZ;
    [SerializeField]
    private int yRotMIDI;
    private int receiverYRot;
    [SerializeField]
    private int zRotMIDI;
    private int receiverZRot;
    #endregion

    #region Public Attributes
    [Header("MIDI Receiver")]
    [SerializeField]
    private receiverAkaiNEW receiverMIDI;
    [SerializeField]
    private float midiMin;
    [SerializeField]
    private float midiMax;

    [Header("Rotation Parameters")]
    [Range(0, 1.0f)]
    public float maxYRotation;
    [Range(0, 1.0f)]
    public float maxYPosition;
    #endregion

    public AnimationCurve valuesEvaluation;
    private Vector3 m_Position;
    private Transform transform;

    void Start()
    {
        m_Position = Vector3.zero;
        transform = gameObject.transform;

        receiverX = receiverMIDI.SetReceiverMidiValue(xMIDI);
        receiverY = receiverMIDI.SetReceiverMidiValue(yMIDI);
        receiverZ = receiverMIDI.SetReceiverMidiValue(zMIDI);
        receiverYRot= receiverMIDI.SetReceiverMidiValue(yRotMIDI);
        receiverZRot = receiverMIDI.SetReceiverMidiValue(zRotMIDI);
    }


    //void Update()
    //{
    //    transform.Rotate(GetInputRotationDirection(), Space.Self);
    //   // m_Position = GetInputTranslationDirection();
    //    UpdateTransform();
    //}

    private void LateUpdate()
    {
        transform.Rotate(GetInputRotationDirection(), Space.Self);
        // m_Position = GetInputTranslationDirection();
        UpdateTransform();
    }

    Vector3 GetInputRotationDirection()
    {
        float yvalue = 0;
        float xvalue = 0;
        yvalue = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverYRot))*maxYRotation;

        //yvalue = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverYRot));
        //yvalue += Mathf.Lerp(-maxYRotation, maxYRotation, yvalue);
        // yvalue += math.remap(midiMin, midiMax, -maxYRotation, maxYRotation, MidiMaster.GetKnob(receiverYRot));

        xvalue = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverZRot)) * -maxYRotation;
        //xvalue = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverZRot));
        //xvalue += math.remap(midiMin, midiMax, -maxYRotation, maxYRotation, MidiMaster.GetKnob(receiverZRot));
        Vector3 direction = new Vector3();
        direction.x = xvalue;
        direction.y = yvalue;
        direction.z = 0;
        return direction;
    }
     float translationDirectionForward=0;
     float translationDirectionUp = 0;

    Vector3 GetInputTranslationDirection()
    {
        Vector3 direction = new Vector3();
        translationDirectionForward =  valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverZ))*maxYPosition;
        direction += Vector3.forward * translationDirectionForward;
        translationDirectionUp = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverY)) * maxYPosition;
        direction += Vector3.up * translationDirectionUp;
        return direction;
    }

    void UpdateTransform()
    {
        translationDirectionForward = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverZ)) * maxYPosition;
        transform.position += transform.forward * translationDirectionForward;
        translationDirectionUp = valuesEvaluation.Evaluate(MidiMaster.GetKnob(receiverY)) * maxYPosition;
        transform.position += transform.up * translationDirectionUp;

        //transform.position += transform.forward * math.remap(midiMin, midiMax, -maxYPosition, maxYPosition, MidiMaster.GetKnob(receiverZ));
        //transform.position += transform.up * math.remap(midiMin, midiMax, -maxYPosition, maxYPosition, MidiMaster.GetKnob(receiverY));
    }
}

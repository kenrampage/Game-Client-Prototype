using Unity.VisualScripting;
using UnityEngine;
using Obvious.Soap;

[UnitTitle("Invoke Scriptable Event No Param")]
[UnitCategory("Custom")]
public class InvokeScriptableEventNoParamNode : Unit
{
    [DoNotSerialize]
    public ControlInput enter;

    [DoNotSerialize]
    public ControlOutput exit;

    [DoNotSerialize]
    public ControlOutput flow;

    [DoNotSerialize]
    [Inspectable]
    [UnitHeaderInspectable("Scriptable Event")]
    public ScriptableEventNoParam scriptableEvent;

    protected override void Definition()
    {
        enter = ControlInput("Enter", InvokeScriptableEvent);
        exit = ControlOutput("Exit");
        flow = ControlOutput("Flow");

        Succession(enter, exit);
        Succession(enter, flow);
    }

    private ControlOutput InvokeScriptableEvent(Flow flow)
    {
        if (scriptableEvent != null)
        {
            scriptableEvent.Raise();
        }

        return exit;
    }
}

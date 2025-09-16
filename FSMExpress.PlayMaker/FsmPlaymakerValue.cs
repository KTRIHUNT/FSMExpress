using FSMExpress.Common.Document;

namespace FSMExpress.PlayMaker;
public class FsmPlaymakerValue(IFsmPlaymakerValuePreviewer value, string name, int indent) : FsmDocumentNodeFieldValue
{
    public override int DisplayIndent => indent;
    public override string DisplayType => value.GetType().Name;
    public override string DisplayString
    {
        get
        {
            var baseStr = value.ToString();
            return FieldKind switch
            {
                FsmDocumentNodeDataFieldKind.Float => baseStr + "f" + GetNameString(name),
                FsmDocumentNodeDataFieldKind.String => "\"" + baseStr + "\"" + GetNameString(name),
                _ => baseStr + GetNameString(name)
            };
        }
    }
    public override FsmDocumentNodeDataFieldKind FieldKind => value.FieldKind;
}

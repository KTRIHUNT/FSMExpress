using FSMExpress.Common.Assets;
using FSMExpress.Common.Document;
using FSMExpress.Common.Interfaces;

namespace FSMExpress.PlayMaker.Structs;
public class FsmObject : NamedVariable, IFsmPlaymakerValuePreviewer
{
    public string TypeName { get; set; }
    public NamedAssetPPtr Value { get; set; }

    public FsmDocumentNodeDataFieldKind FieldKind => FsmDocumentNodeDataFieldKind.Object;

    public FsmObject()
    {
        TypeName = string.Empty;
        Value = new NamedAssetPPtr();
    }

    public FsmObject(IAssetField field) : base(field)
    {
        // only exists if FsmObject is the complete class
        // for example, FsmGameObject will not have this field
        if (field.Exists("typeName"))
            TypeName = field.GetValue<string>("typeName");
        else
            TypeName = string.Empty;

        Value = field.GetValue<NamedAssetPPtr>("value");
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
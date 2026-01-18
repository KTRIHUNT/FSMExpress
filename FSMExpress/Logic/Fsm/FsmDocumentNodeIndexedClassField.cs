using FSMExpress.Common.Document;

namespace FSMExpress.Logic.Fsm;
public class FsmDocumentNodeIndexedClassField(FsmDocumentNodeClassField field, int index)
    : FsmDocumentNodeClassField(field.TypeRef, field.IsEnabled)
{
    public int Index { get; set; } = index;
    public string DisplayText => $"({Index}) {TypeRef.ClassName}";
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

// Generated from: Test3.proto
// Note: requires additional types generated from: Test2.proto
namespace MichaelReukauff.Lexer.Protobufs
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"test3")]
  public partial class test3 : global::ProtoBuf.IExtensible
  {
    public test3() {}

    private string _t1 = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"t1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string t1
    {
      get { return _t1; }
      set { _t1 = value; }
    }
    private string _t2 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"t2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string t2
    {
      get { return _t2; }
      set { _t2 = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _t3 = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"t3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> t3
    {
      get { return _t3; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"test31")]
  public partial class test31 : global::ProtoBuf.IExtensible
  {
    public test31() {}

    private test2 _t1 = null;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"t1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public test2 t1
    {
      get { return _t1; }
      set { _t1 = value; }
    }
    private test2 _t2 = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"t2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public test2 t2
    {
      get { return _t2; }
      set { _t2 = value; }
    }
    private test2 _t3 = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"t3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public test2 t3
    {
      get { return _t3; }
      set { _t3 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"enumTest")]
    public enum enumTest
    {
      
      [global::ProtoBuf.ProtoEnum(Name=@"Val1", Value=12)]
      Val1 = 12,
      
      [global::ProtoBuf.ProtoEnum(Name=@"Val2", Value=12)]
      Val2 = 12
    }
  
}

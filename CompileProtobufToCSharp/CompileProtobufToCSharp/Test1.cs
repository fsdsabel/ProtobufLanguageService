//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: binary serialization (ISerializable) enabled
    
// Generated from: Test1.proto
namespace Test1
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"required1")]
  public partial class required1 : global::ProtoBuf.IExtensible, global::System.Runtime.Serialization.ISerializable
  {
    public required1() {}
    
    private int _i1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"i1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int i1
    {
      get { return _i1; }
      set { _i1 = value; }
    }

    private int _i2 = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"i2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int i2
    {
      get { return _i2; }
      set { _i2 = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _i3 = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"i3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> i3
    {
      get { return _i3; }
    }
  

    private string _i4 = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"i4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i4
    {
      get { return _i4; }
      set { _i4 = value; }
    }

    private t1 _i5 = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"i5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public t1 i5
    {
      get { return _i5; }
      set { _i5 = value; }
    }
    protected required1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
      : this() { global::ProtoBuf.Serializer.Merge(info, this); }
    void global::System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
      { global::ProtoBuf.Serializer.Serialize(info, this); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"t1")]
  public partial class t1 : global::ProtoBuf.IExtensible, global::System.Runtime.Serialization.ISerializable
  {
    public t1() {}
    
    protected t1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
      : this() { global::ProtoBuf.Serializer.Merge(info, this); }
    void global::System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
      { global::ProtoBuf.Serializer.Serialize(info, this); }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}

// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::FlatBuffers;

public struct fheader : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static fheader GetRootAsfheader(ByteBuffer _bb) { return GetRootAsfheader(_bb, new fheader()); }
  public static fheader GetRootAsfheader(ByteBuffer _bb, fheader obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public fheader __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Class CType { get { int o = __p.__offset(4); return o != 0 ? (Class)__p.bb.GetInt(o + __p.bb_pos) : Class.Base; } }
  public int PacketSize { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<fheader> Createfheader(FlatBufferBuilder builder,
      Class cType = Class.Base,
      int PacketSize = 0) {
    builder.StartObject(2);
    fheader.AddPacketSize(builder, PacketSize);
    fheader.AddCType(builder, cType);
    return fheader.Endfheader(builder);
  }

  public static void Startfheader(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddCType(FlatBufferBuilder builder, Class cType) { builder.AddInt(0, (int)cType, 0); }
  public static void AddPacketSize(FlatBufferBuilder builder, int PacketSize) { builder.AddInt(1, PacketSize, 0); }
  public static Offset<fheader> Endfheader(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<fheader>(o);
  }
};


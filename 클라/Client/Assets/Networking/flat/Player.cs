// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using global::System;
using global::FlatBuffers;

public struct Player : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Player GetRootAsPlayer(ByteBuffer _bb) { return GetRootAsPlayer(_bb, new Player()); }
  public static Player GetRootAsPlayer(ByteBuffer _bb, Player obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Player __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Class CType { get { int o = __p.__offset(4); return o != 0 ? (Class)__p.bb.GetInt(o + __p.bb_pos) : Class.Base; } }
  public Vec3? Pos { get { int o = __p.__offset(6); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Vec3? Vel { get { int o = __p.__offset(8); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Vec3? Rot { get { int o = __p.__offset(10); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float W { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int ID { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Vertical { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Horizontal { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool Jump { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Attack { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Run { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static void StartPlayer(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddCType(FlatBufferBuilder builder, Class cType) { builder.AddInt(0, (int)cType, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<Vec3> posOffset) { builder.AddStruct(1, posOffset.Value, 0); }
  public static void AddVel(FlatBufferBuilder builder, Offset<Vec3> velOffset) { builder.AddStruct(2, velOffset.Value, 0); }
  public static void AddRot(FlatBufferBuilder builder, Offset<Vec3> rotOffset) { builder.AddStruct(3, rotOffset.Value, 0); }
  public static void AddW(FlatBufferBuilder builder, float w) { builder.AddFloat(4, w, 0.0f); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(5, ID, 0); }
  public static void AddVertical(FlatBufferBuilder builder, float Vertical) { builder.AddFloat(6, Vertical, 0.0f); }
  public static void AddHorizontal(FlatBufferBuilder builder, float Horizontal) { builder.AddFloat(7, Horizontal, 0.0f); }
  public static void AddJump(FlatBufferBuilder builder, bool Jump) { builder.AddBool(8, Jump, false); }
  public static void AddAttack(FlatBufferBuilder builder, bool Attack) { builder.AddBool(9, Attack, false); }
  public static void AddRun(FlatBufferBuilder builder, bool Run) { builder.AddBool(10, Run, false); }
  public static Offset<Player> EndPlayer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Player>(o);
  }
};


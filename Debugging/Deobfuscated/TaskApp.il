
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v2.0.50727
.assembly extern System.Windows.Forms
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 2:0:0:0
}
.assembly extern System.Core
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 3:5:0:0
}
.assembly extern System.Drawing
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 2:0:0:0
}
.assembly CrackMe
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 6C 43 72 61 63 6B 4D 65 20 4F 62 66 75 73   // ..lCrackMe Obfus
                                                                                              63 61 74 65 64 20 77 69 74 68 20 44 6F 74 66 75   // cated with Dotfu
                                                                                              73 63 61 74 6F 72 20 50 72 6F 66 65 73 73 69 6F   // scator Professio
                                                                                              6E 61 6C 20 45 76 61 6C 75 61 74 69 6F 6E 2E 20   // nal Evaluation. 
                                                                                              49 6C 6C 65 67 61 6C 20 74 6F 20 75 73 65 20 6F   // Illegal to use o
                                                                                              6E 20 73 6F 66 74 77 61 72 65 20 66 6F 72 20 67   // n software for g
                                                                                              65 6E 65 72 61 6C 20 72 65 6C 65 61 73 65 2E 00   // eneral release..
                                                                                              00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 43 72 61 63 6B 4D 65 00 00 )             // ...CrackMe..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 36 00 00 )                            //  2016..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 38 30 30 30 34 65 35 65 2D 61 63 65 36   // ..$80004e5e-ace6
                                                                                                  2D 34 31 30 39 2D 61 39 38 61 2D 35 64 32 38 65   // -4109-a98a-5d28e
                                                                                                  61 65 34 39 62 61 31 00 00 )                      // ae49ba1..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.mresource public CrackMe.Form1.resources
{
  // Offset: 0x00000000 Length: 0x000000B4
  // WARNING: managed resource file CrackMe.Form1.resources created
}
.mresource public CrackMe.Properties.Resources.resources
{
  // Offset: 0x000000B8 Length: 0x000000B4
  // WARNING: managed resource file CrackMe.Properties.Resources.resources created
}
.module CrackMe.exe
// MVID: {E929FEB7-F3DD-449F-99CD-83285EA760B5}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0002       // WINDOWS_GUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x07B20000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit CrackMe.Form1
       extends [System.Windows.Forms]System.Windows.Forms.Form
{
  .class auto ansi sealed nested private beforefieldinit Class0
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public uint8[] byte_0
    .field public int32[] int_0
    .field privatescope notserialized string string_0$PST0400000A = uint8(0x20)
    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method Class0::.ctor

    .method assembly hidebysig instance int32 
            method_0(uint8 byte_1,
                     int32 int_1) cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  ldarg.0
      IL_0002:  ldfld      uint8[] CrackMe.Form1/Class0::byte_0
      IL_0007:  ldarg.2
      IL_0008:  ldelem.u1
      IL_0009:  xor
      IL_000a:  ret
    } // end of method Class0::method_0

    .method assembly hidebysig instance int32 
            method_1(int32 int_1,
                     int32 int_2) cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  ldarg.0
      IL_0002:  ldfld      int32[] CrackMe.Form1/Class0::int_0
      IL_0007:  ldarg.2
      IL_0008:  ldelem.i4
      IL_0009:  sub
      IL_000a:  ret
    } // end of method Class0::method_1

  } // end of class Class0

  .class auto ansi serializable sealed nested private beforefieldinit '<>c'
         extends [mscorlib]System.Object
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    .field public static initonly class CrackMe.Form1/'<>c' '<>9'
    .field public static class [System.Core]System.Func`2<int32,int32> '<>9__3_1'
    .field public static class [System.Core]System.Func`2<int32,bool> '<>9__3_3'
    .field privatescope notserialized string string_0$PST0400000E = uint8(0x20)
    .method private hidebysig specialname rtspecialname static 
            void  .cctor() cil managed
    {
      // Code size       11 (0xb)
      .maxstack  8
      IL_0000:  newobj     instance void CrackMe.Form1/'<>c'::.ctor()
      IL_0005:  stsfld     class CrackMe.Form1/'<>c' CrackMe.Form1/'<>c'::'<>9'
      IL_000a:  ret
    } // end of method '<>c'::.cctor

    .method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method '<>c'::.ctor

    .method assembly hidebysig instance int32 
            method_0(int32 int_0) cil managed
    {
      // Code size       15 (0xf)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  ldc.i4     0x3e7
      IL_0006:  bgt.s      IL_000d

      IL_0008:  ldarg.1
      IL_0009:  ldc.i4.s   10
      IL_000b:  mul
      IL_000c:  ret

      IL_000d:  ldarg.1
      IL_000e:  ret
    } // end of method '<>c'::method_0

    .method assembly hidebysig instance bool 
            method_1(int32 int_0) cil managed
    {
      // Code size       5 (0x5)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  ldc.i4.0
      IL_0002:  ceq
      IL_0004:  ret
    } // end of method '<>c'::method_1

  } // end of class '<>c'

  .field private string[] string_0
  .field private class [System]System.ComponentModel.IContainer icontainer_0
  .field private class [System.Windows.Forms]System.Windows.Forms.Button bt_check
  .field private class [System.Windows.Forms]System.Windows.Forms.TextBox tb_key
  .field private class [System.Windows.Forms]System.Windows.Forms.Label label1
  .field private class [System.Windows.Forms]System.Windows.Forms.Label lb_status
  .field privatescope notserialized string string_1$PST04000007 = uint8(0x20)
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Windows.Forms]System.Windows.Forms.Form::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  call       instance void CrackMe.Form1::InitializeComponent()
    IL_000c:  ret
  } // end of method Form1::.ctor

  .method private hidebysig instance void 
          bt_check_Click(object sender,
                         class [mscorlib]System.EventArgs e) cil managed
  {
    // Code size       118 (0x76)
    .maxstack  6
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_0006:  callvirt   instance string [System.Windows.Forms]System.Windows.Forms.Control::get_Text()
    IL_000b:  call       bool [mscorlib]System.String::IsNullOrEmpty(string)
    IL_0010:  brfalse.s  IL_0023

    IL_0012:  ldarg.0
    IL_0013:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_0018:  ldstr      "Key cannot be empty"
    IL_001d:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_0022:  ret

    IL_0023:  ldarg.0
    IL_0024:  ldarg.0
    IL_0025:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_002a:  callvirt   instance string [System.Windows.Forms]System.Windows.Forms.Control::get_Text()
    IL_002f:  ldc.i4.1
    IL_0030:  newarr     [mscorlib]System.Char
    IL_0035:  dup
    IL_0036:  ldc.i4.0
    IL_0037:  ldc.i4.s   45
    IL_0039:  stelem.i2
    IL_003a:  callvirt   instance string[] [mscorlib]System.String::Split(char[])
    IL_003f:  stfld      string[] CrackMe.Form1::string_0
    IL_0044:  ldarg.0
    IL_0045:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_004a:  ldarg.0
    IL_004b:  ldarg.0
    IL_004c:  ldfld      string[] CrackMe.Form1::string_0
    IL_0051:  call       instance bool CrackMe.Form1::method_0(string[])
    IL_0056:  brtrue.s   IL_005f

    IL_0058:  ldstr      "Wrong key"
    IL_005d:  br.s       IL_0064

    IL_005f:  ldstr      "Correct key"
    IL_0064:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_0069:  ldarg.0
    IL_006a:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_006f:  ldc.i4.1
    IL_0070:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Visible(bool)
    IL_0075:  ret
  } // end of method Form1::bt_check_Click

  .method private hidebysig instance bool 
          method_0(string[] string_2) cil managed
  {
    // Code size       206 (0xce)
    .maxstack  5
    .locals init (class CrackMe.Form1/Class0 V_0,
             class [System]System.Net.NetworkInformation.NetworkInterface V_1,
             valuetype [mscorlib]System.DateTime V_2)
    IL_0000:  newobj     instance void CrackMe.Form1/Class0::.ctor()
    IL_0005:  stloc.0
    IL_0006:  call       class [System]System.Net.NetworkInformation.NetworkInterface[] [System]System.Net.NetworkInformation.NetworkInterface::GetAllNetworkInterfaces()
    IL_000b:  call       !!0 [System.Core]System.Linq.Enumerable::FirstOrDefault<class [System]System.Net.NetworkInformation.NetworkInterface>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0010:  stloc.1
    IL_0011:  ldloc.1
    IL_0012:  brtrue.s   IL_0016

    IL_0014:  ldc.i4.0
    IL_0015:  ret

    IL_0016:  ldloc.1
    IL_0017:  callvirt   instance class [System]System.Net.NetworkInformation.PhysicalAddress [System]System.Net.NetworkInformation.NetworkInterface::GetPhysicalAddress()
    IL_001c:  callvirt   instance uint8[] [System]System.Net.NetworkInformation.PhysicalAddress::GetAddressBytes()
    IL_0021:  ldloc.0
    IL_0022:  call       valuetype [mscorlib]System.DateTime [mscorlib]System.DateTime::get_Now()
    IL_0027:  stloc.2
    IL_0028:  ldloca.s   V_2
    IL_002a:  call       instance valuetype [mscorlib]System.DateTime [mscorlib]System.DateTime::get_Date()
    IL_002f:  stloc.2
    IL_0030:  ldloca.s   V_2
    IL_0032:  call       instance int64 [mscorlib]System.DateTime::ToBinary()
    IL_0037:  call       uint8[] [mscorlib]System.BitConverter::GetBytes(int64)
    IL_003c:  stfld      uint8[] CrackMe.Form1/Class0::byte_0
    IL_0041:  ldloc.0
    IL_0042:  ldftn      instance int32 CrackMe.Form1/Class0::method_0(uint8,
                                                                       int32)
    IL_0048:  newobj     instance void class [System.Core]System.Func`3<uint8,int32,int32>::.ctor(object,
                                                                                                  native int)
    IL_004d:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<uint8,int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                class [System.Core]System.Func`3<!!0,int32,!!1>)
    IL_0052:  ldsfld     class [System.Core]System.Func`2<int32,int32> CrackMe.Form1/'<>c'::'<>9__3_1'
    IL_0057:  dup
    IL_0058:  brtrue.s   IL_0071

    IL_005a:  pop
    IL_005b:  ldsfld     class CrackMe.Form1/'<>c' CrackMe.Form1/'<>c'::'<>9'
    IL_0060:  ldftn      instance int32 CrackMe.Form1/'<>c'::method_0(int32)
    IL_0066:  newobj     instance void class [System.Core]System.Func`2<int32,int32>::.ctor(object,
                                                                                            native int)
    IL_006b:  dup
    IL_006c:  stsfld     class [System.Core]System.Func`2<int32,int32> CrackMe.Form1/'<>c'::'<>9__3_1'
    IL_0071:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<int32,int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                class [System.Core]System.Func`2<!!0,!!1>)
    IL_0076:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_007b:  ldloc.0
    IL_007c:  ldarg.1
    IL_007d:  ldnull
    IL_007e:  ldftn      int32 [mscorlib]System.Int32::Parse(string)
    IL_0084:  newobj     instance void class [System.Core]System.Func`2<string,int32>::.ctor(object,
                                                                                             native int)
    IL_0089:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<string,int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                 class [System.Core]System.Func`2<!!0,!!1>)
    IL_008e:  call       !!0[] [System.Core]System.Linq.Enumerable::ToArray<int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>)
    IL_0093:  stfld      int32[] CrackMe.Form1/Class0::int_0
    IL_0098:  ldloc.0
    IL_0099:  ldftn      instance int32 CrackMe.Form1/Class0::method_1(int32,
                                                                       int32)
    IL_009f:  newobj     instance void class [System.Core]System.Func`3<int32,int32,int32>::.ctor(object,
                                                                                                  native int)
    IL_00a4:  call       class [mscorlib]System.Collections.Generic.IEnumerable`1<!!1> [System.Core]System.Linq.Enumerable::Select<int32,int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                                                                                                class [System.Core]System.Func`3<!!0,int32,!!1>)
    IL_00a9:  ldsfld     class [System.Core]System.Func`2<int32,bool> CrackMe.Form1/'<>c'::'<>9__3_3'
    IL_00ae:  dup
    IL_00af:  brtrue.s   IL_00c8

    IL_00b1:  pop
    IL_00b2:  ldsfld     class CrackMe.Form1/'<>c' CrackMe.Form1/'<>c'::'<>9'
    IL_00b7:  ldftn      instance bool CrackMe.Form1/'<>c'::method_1(int32)
    IL_00bd:  newobj     instance void class [System.Core]System.Func`2<int32,bool>::.ctor(object,
                                                                                           native int)
    IL_00c2:  dup
    IL_00c3:  stsfld     class [System.Core]System.Func`2<int32,bool> CrackMe.Form1/'<>c'::'<>9__3_3'
    IL_00c8:  call       bool [System.Core]System.Linq.Enumerable::All<int32>(class [mscorlib]System.Collections.Generic.IEnumerable`1<!!0>,
                                                                              class [System.Core]System.Func`2<!!0,bool>)
    IL_00cd:  ret
  } // end of method Form1::method_0

  .method family hidebysig virtual instance void 
          Dispose(bool disposing) cil managed
  {
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  brfalse.s  IL_0016

    IL_0003:  ldarg.0
    IL_0004:  ldfld      class [System]System.ComponentModel.IContainer CrackMe.Form1::icontainer_0
    IL_0009:  brfalse.s  IL_0016

    IL_000b:  ldarg.0
    IL_000c:  ldfld      class [System]System.ComponentModel.IContainer CrackMe.Form1::icontainer_0
    IL_0011:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
    IL_0016:  ldarg.0
    IL_0017:  ldarg.1
    IL_0018:  call       instance void [System.Windows.Forms]System.Windows.Forms.Form::Dispose(bool)
    IL_001d:  ret
  } // end of method Form1::Dispose

  .method private hidebysig instance void 
          InitializeComponent() cil managed
  {
    // Code size       597 (0x255)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void [System.Windows.Forms]System.Windows.Forms.Button::.ctor()
    IL_0006:  stfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_000b:  ldarg.0
    IL_000c:  newobj     instance void [System.Windows.Forms]System.Windows.Forms.TextBox::.ctor()
    IL_0011:  stfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_0016:  ldarg.0
    IL_0017:  newobj     instance void [System.Windows.Forms]System.Windows.Forms.Label::.ctor()
    IL_001c:  stfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_0021:  ldarg.0
    IL_0022:  newobj     instance void [System.Windows.Forms]System.Windows.Forms.Label::.ctor()
    IL_0027:  stfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_002c:  ldarg.0
    IL_002d:  call       instance void [System.Windows.Forms]System.Windows.Forms.Control::SuspendLayout()
    IL_0032:  ldarg.0
    IL_0033:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_0038:  ldc.i4     0x10c
    IL_003d:  ldc.i4.s   51
    IL_003f:  newobj     instance void [System.Drawing]System.Drawing.Point::.ctor(int32,
                                                                                   int32)
    IL_0044:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Location(valuetype [System.Drawing]System.Drawing.Point)
    IL_0049:  ldarg.0
    IL_004a:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_004f:  ldstr      "bt_check"
    IL_0054:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Name(string)
    IL_0059:  ldarg.0
    IL_005a:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_005f:  ldc.i4.s   75
    IL_0061:  ldc.i4.s   23
    IL_0063:  newobj     instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                  int32)
    IL_0068:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Size(valuetype [System.Drawing]System.Drawing.Size)
    IL_006d:  ldarg.0
    IL_006e:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_0073:  ldc.i4.0
    IL_0074:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_TabIndex(int32)
    IL_0079:  ldarg.0
    IL_007a:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_007f:  ldstr      "Check"
    IL_0084:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_0089:  ldarg.0
    IL_008a:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_008f:  ldc.i4.1
    IL_0090:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.ButtonBase::set_UseVisualStyleBackColor(bool)
    IL_0095:  ldarg.0
    IL_0096:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_009b:  ldarg.0
    IL_009c:  ldftn      instance void CrackMe.Form1::bt_check_Click(object,
                                                                     class [mscorlib]System.EventArgs)
    IL_00a2:  newobj     instance void [mscorlib]System.EventHandler::.ctor(object,
                                                                            native int)
    IL_00a7:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::add_Click(class [mscorlib]System.EventHandler)
    IL_00ac:  ldarg.0
    IL_00ad:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_00b2:  ldc.i4.s   35
    IL_00b4:  ldc.i4.s   25
    IL_00b6:  newobj     instance void [System.Drawing]System.Drawing.Point::.ctor(int32,
                                                                                   int32)
    IL_00bb:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Location(valuetype [System.Drawing]System.Drawing.Point)
    IL_00c0:  ldarg.0
    IL_00c1:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_00c6:  ldstr      "tb_key"
    IL_00cb:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Name(string)
    IL_00d0:  ldarg.0
    IL_00d1:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_00d6:  ldc.i4     0x134
    IL_00db:  ldc.i4.s   20
    IL_00dd:  newobj     instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                  int32)
    IL_00e2:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Size(valuetype [System.Drawing]System.Drawing.Size)
    IL_00e7:  ldarg.0
    IL_00e8:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_00ed:  ldc.i4.1
    IL_00ee:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_TabIndex(int32)
    IL_00f3:  ldarg.0
    IL_00f4:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_00f9:  ldc.i4.1
    IL_00fa:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_AutoSize(bool)
    IL_00ff:  ldarg.0
    IL_0100:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_0105:  ldc.i4.s   32
    IL_0107:  ldc.i4.s   9
    IL_0109:  newobj     instance void [System.Drawing]System.Drawing.Point::.ctor(int32,
                                                                                   int32)
    IL_010e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Location(valuetype [System.Drawing]System.Drawing.Point)
    IL_0113:  ldarg.0
    IL_0114:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_0119:  ldstr      "label1"
    IL_011e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Name(string)
    IL_0123:  ldarg.0
    IL_0124:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_0129:  ldc.i4.s   107
    IL_012b:  ldc.i4.s   13
    IL_012d:  newobj     instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                  int32)
    IL_0132:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Size(valuetype [System.Drawing]System.Drawing.Size)
    IL_0137:  ldarg.0
    IL_0138:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_013d:  ldc.i4.2
    IL_013e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_TabIndex(int32)
    IL_0143:  ldarg.0
    IL_0144:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_0149:  ldstr      "Please, enter the key"
    IL_014e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_0153:  ldarg.0
    IL_0154:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_0159:  ldc.i4.1
    IL_015a:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_AutoSize(bool)
    IL_015f:  ldarg.0
    IL_0160:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_0165:  ldc.i4.s   35
    IL_0167:  ldc.i4.s   52
    IL_0169:  newobj     instance void [System.Drawing]System.Drawing.Point::.ctor(int32,
                                                                                   int32)
    IL_016e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Location(valuetype [System.Drawing]System.Drawing.Point)
    IL_0173:  ldarg.0
    IL_0174:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_0179:  ldstr      "lb_status"
    IL_017e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Name(string)
    IL_0183:  ldarg.0
    IL_0184:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_0189:  ldc.i4.s   35
    IL_018b:  ldc.i4.s   13
    IL_018d:  newobj     instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                  int32)
    IL_0192:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Size(valuetype [System.Drawing]System.Drawing.Size)
    IL_0197:  ldarg.0
    IL_0198:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_019d:  ldc.i4.3
    IL_019e:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_TabIndex(int32)
    IL_01a3:  ldarg.0
    IL_01a4:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_01a9:  ldstr      "label2"
    IL_01ae:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_01b3:  ldarg.0
    IL_01b4:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_01b9:  ldc.i4.0
    IL_01ba:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Visible(bool)
    IL_01bf:  ldarg.0
    IL_01c0:  ldc.r4     6.
    IL_01c5:  ldc.r4     13.
    IL_01ca:  newobj     instance void [System.Drawing]System.Drawing.SizeF::.ctor(float32,
                                                                                   float32)
    IL_01cf:  call       instance void [System.Windows.Forms]System.Windows.Forms.ContainerControl::set_AutoScaleDimensions(valuetype [System.Drawing]System.Drawing.SizeF)
    IL_01d4:  ldarg.0
    IL_01d5:  ldc.i4.1
    IL_01d6:  call       instance void [System.Windows.Forms]System.Windows.Forms.ContainerControl::set_AutoScaleMode(valuetype [System.Windows.Forms]System.Windows.Forms.AutoScaleMode)
    IL_01db:  ldarg.0
    IL_01dc:  ldc.i4     0x171
    IL_01e1:  ldc.i4.s   86
    IL_01e3:  newobj     instance void [System.Drawing]System.Drawing.Size::.ctor(int32,
                                                                                  int32)
    IL_01e8:  call       instance void [System.Windows.Forms]System.Windows.Forms.Form::set_ClientSize(valuetype [System.Drawing]System.Drawing.Size)
    IL_01ed:  ldarg.0
    IL_01ee:  call       instance class [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection [System.Windows.Forms]System.Windows.Forms.Control::get_Controls()
    IL_01f3:  ldarg.0
    IL_01f4:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::lb_status
    IL_01f9:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection::Add(class [System.Windows.Forms]System.Windows.Forms.Control)
    IL_01fe:  ldarg.0
    IL_01ff:  call       instance class [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection [System.Windows.Forms]System.Windows.Forms.Control::get_Controls()
    IL_0204:  ldarg.0
    IL_0205:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Label CrackMe.Form1::label1
    IL_020a:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection::Add(class [System.Windows.Forms]System.Windows.Forms.Control)
    IL_020f:  ldarg.0
    IL_0210:  call       instance class [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection [System.Windows.Forms]System.Windows.Forms.Control::get_Controls()
    IL_0215:  ldarg.0
    IL_0216:  ldfld      class [System.Windows.Forms]System.Windows.Forms.TextBox CrackMe.Form1::tb_key
    IL_021b:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection::Add(class [System.Windows.Forms]System.Windows.Forms.Control)
    IL_0220:  ldarg.0
    IL_0221:  call       instance class [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection [System.Windows.Forms]System.Windows.Forms.Control::get_Controls()
    IL_0226:  ldarg.0
    IL_0227:  ldfld      class [System.Windows.Forms]System.Windows.Forms.Button CrackMe.Form1::bt_check
    IL_022c:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control/ControlCollection::Add(class [System.Windows.Forms]System.Windows.Forms.Control)
    IL_0231:  ldarg.0
    IL_0232:  ldstr      "Form1"
    IL_0237:  call       instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Name(string)
    IL_023c:  ldarg.0
    IL_023d:  ldstr      "Crack me"
    IL_0242:  callvirt   instance void [System.Windows.Forms]System.Windows.Forms.Control::set_Text(string)
    IL_0247:  ldarg.0
    IL_0248:  ldc.i4.0
    IL_0249:  call       instance void [System.Windows.Forms]System.Windows.Forms.Control::ResumeLayout(bool)
    IL_024e:  ldarg.0
    IL_024f:  call       instance void [System.Windows.Forms]System.Windows.Forms.Control::PerformLayout()
    IL_0254:  ret
  } // end of method Form1::InitializeComponent

} // end of class CrackMe.Form1

.class private abstract auto ansi sealed beforefieldinit Class1
       extends [mscorlib]System.Object
{
  .field private notserialized string string_0 = uint8(0x20)
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    .custom instance void [mscorlib]System.STAThreadAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       22 (0x16)
    .maxstack  8
    IL_0000:  call       void [System.Windows.Forms]System.Windows.Forms.Application::EnableVisualStyles()
    IL_0005:  ldc.i4.0
    IL_0006:  call       void [System.Windows.Forms]System.Windows.Forms.Application::SetCompatibleTextRenderingDefault(bool)
    IL_000b:  newobj     instance void CrackMe.Form1::.ctor()
    IL_0010:  call       void [System.Windows.Forms]System.Windows.Forms.Application::Run(class [System.Windows.Forms]System.Windows.Forms.Form)
    IL_0015:  ret
  } // end of method Class1::Main

} // end of class Class1

.class private auto ansi beforefieldinit CrackMe.Properties.Resources
       extends [mscorlib]System.Object
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 33 53 79 73 74 65 6D 2E 52 65 73 6F 75 72   // ..3System.Resour
                                                                                                  63 65 73 2E 54 6F 6F 6C 73 2E 53 74 72 6F 6E 67   // ces.Tools.Strong
                                                                                                  6C 79 54 79 70 65 64 52 65 73 6F 75 72 63 65 42   // lyTypedResourceB
                                                                                                  75 69 6C 64 65 72 07 34 2E 30 2E 30 2E 30 00 00 ) // uilder.4.0.0.0..
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private static class [mscorlib]System.Resources.ResourceManager resourceManager_0
  .field private static class [mscorlib]System.Globalization.CultureInfo cultureInfo_0
  .field private notserialized string string_0 = uint8(0x20)
  .method assembly hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Resources::.ctor

  .method assembly hidebysig specialname static 
          class [mscorlib]System.Resources.ResourceManager 
          get_ResourceManager() cil managed
  {
    // Code size       43 (0x2b)
    .maxstack  8
    IL_0000:  ldsfld     class [mscorlib]System.Resources.ResourceManager CrackMe.Properties.Resources::resourceManager_0
    IL_0005:  brtrue.s   IL_0025

    IL_0007:  ldstr      "CrackMe.Properties.Resources"
    IL_000c:  ldtoken    CrackMe.Properties.Resources
    IL_0011:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_0016:  callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Type::get_Assembly()
    IL_001b:  newobj     instance void [mscorlib]System.Resources.ResourceManager::.ctor(string,
                                                                                         class [mscorlib]System.Reflection.Assembly)
    IL_0020:  stsfld     class [mscorlib]System.Resources.ResourceManager CrackMe.Properties.Resources::resourceManager_0
    IL_0025:  ldsfld     class [mscorlib]System.Resources.ResourceManager CrackMe.Properties.Resources::resourceManager_0
    IL_002a:  ret
  } // end of method Resources::get_ResourceManager

  .method assembly hidebysig specialname static 
          class [mscorlib]System.Globalization.CultureInfo 
          get_Culture() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     class [mscorlib]System.Globalization.CultureInfo CrackMe.Properties.Resources::cultureInfo_0
    IL_0005:  ret
  } // end of method Resources::get_Culture

  .method assembly hidebysig specialname static 
          void  set_Culture(class [mscorlib]System.Globalization.CultureInfo 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  stsfld     class [mscorlib]System.Globalization.CultureInfo CrackMe.Properties.Resources::cultureInfo_0
    IL_0006:  ret
  } // end of method Resources::set_Culture

  .property class [mscorlib]System.Resources.ResourceManager
          ResourceManager()
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 ) 
    .get class [mscorlib]System.Resources.ResourceManager CrackMe.Properties.Resources::get_ResourceManager()
  } // end of property Resources::ResourceManager
  .property class [mscorlib]System.Globalization.CultureInfo
          Culture()
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 ) 
    .get class [mscorlib]System.Globalization.CultureInfo CrackMe.Properties.Resources::get_Culture()
    .set void CrackMe.Properties.Resources::set_Culture(class [mscorlib]System.Globalization.CultureInfo)
  } // end of property Resources::Culture
} // end of class CrackMe.Properties.Resources

.class private auto ansi sealed beforefieldinit CrackMe.Properties.Settings
       extends [System]System.Configuration.ApplicationSettingsBase
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 4B 4D 69 63 72 6F 73 6F 66 74 2E 56 69 73   // ..KMicrosoft.Vis
                                                                                                  75 61 6C 53 74 75 64 69 6F 2E 45 64 69 74 6F 72   // ualStudio.Editor
                                                                                                  73 2E 53 65 74 74 69 6E 67 73 44 65 73 69 67 6E   // s.SettingsDesign
                                                                                                  65 72 2E 53 65 74 74 69 6E 67 73 53 69 6E 67 6C   // er.SettingsSingl
                                                                                                  65 46 69 6C 65 47 65 6E 65 72 61 74 6F 72 08 31   // eFileGenerator.1
                                                                                                  31 2E 30 2E 30 2E 30 00 00 )                      // 1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private static class CrackMe.Properties.Settings settings_0
  .field private notserialized string string_0 = uint8(0x20)
  .method public hidebysig specialname static 
          class CrackMe.Properties.Settings 
          get_Default() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     class CrackMe.Properties.Settings CrackMe.Properties.Settings::settings_0
    IL_0005:  ret
  } // end of method Settings::get_Default

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System]System.Configuration.ApplicationSettingsBase::.ctor()
    IL_0006:  ret
  } // end of method Settings::.ctor

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       21 (0x15)
    .maxstack  8
    IL_0000:  newobj     instance void CrackMe.Properties.Settings::.ctor()
    IL_0005:  call       class [System]System.Configuration.SettingsBase [System]System.Configuration.SettingsBase::Synchronized(class [System]System.Configuration.SettingsBase)
    IL_000a:  castclass  CrackMe.Properties.Settings
    IL_000f:  stsfld     class CrackMe.Properties.Settings CrackMe.Properties.Settings::settings_0
    IL_0014:  ret
  } // end of method Settings::.cctor

  .property class CrackMe.Properties.Settings
          Default()
  {
    .get class CrackMe.Properties.Settings CrackMe.Properties.Settings::get_Default()
  } // end of property Settings::Default
} // end of class CrackMe.Properties.Settings


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file TaskApp.res

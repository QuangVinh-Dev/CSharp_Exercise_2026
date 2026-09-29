
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 8:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 8:0:0:0
}
.assembly Bai01
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 38 2E 30 01 00 54 0E 14   // ersion=v8.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 08 2E 4E 45 54 20 38 2E 30 )          // Name..NET 8.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 05 42 61 69 30 31 00 00 )                   // ...Bai01..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 2E 31 2E 30 2E 30 2B 66 38 36 65 36 35 61   // ...1.0.0+f86e65a
                                                                                                                   39 38 66 63 39 34 64 39 34 64 61 63 33 38 64 35   // 98fc94d94dac38d5
                                                                                                                   34 65 39 39 35 66 38 35 31 62 65 36 62 64 34 66   // 4e995f851be6bd4f
                                                                                                                   65 00 00 )                                        // e..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 05 42 61 69 30 31 00 00 )                   // ...Bai01..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 05 42 61 69 30 31 00 00 )                   // ...Bai01..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Bai01.dll
// MVID: {915DFC71-84A0-4C85-B286-88772871E167}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x09800000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lab01.Bai01.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 01 00 00 ) 
    // Code size       149 (0x95)
    .maxstack  2
    .locals init (string V_0,
             bool V_1)
    IL_0000:  nop
    IL_0001:  ldstr      "=== BAI 01: MA NGUON CHUONG TRINH (ILDASM / ILASM)"
    + " ==="
    IL_0006:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ldstr      "Nhap ho ten cua ban: "
    IL_0011:  call       void [System.Console]System.Console::Write(string)
    IL_0016:  nop
    IL_0017:  call       string [System.Console]System.Console::ReadLine()
    IL_001c:  stloc.0
    IL_001d:  ldloc.0
    IL_001e:  call       bool [System.Runtime]System.String::IsNullOrWhiteSpace(string)
    IL_0023:  stloc.1
    IL_0024:  ldloc.1
    IL_0025:  brfalse.s  IL_0036

    IL_0027:  nop
    IL_0028:  ldstr      "Nguyen Van A"
    IL_002d:  stloc.0
    IL_002e:  ldloc.0
    IL_002f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0034:  nop
    IL_0035:  nop
    IL_0036:  ldstr      "Xin chao: "
    IL_003b:  ldloc.0
    IL_003c:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0041:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0046:  nop
    IL_0047:  ldstr      "\n--- HUONG DAN SU DUNG ILDASM VA ILASM ---"
    IL_004c:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0051:  nop
    IL_0052:  ldstr      "B1: Bien dich chuong trinh thanh file PE (.exe hoa"
    + "c .dll):"
    IL_0057:  call       void [System.Console]System.Console::WriteLine(string)
    IL_005c:  nop
    IL_005d:  ldstr      "    dotnet build"
    IL_0062:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0067:  nop
    IL_0068:  ldstr      "B2: Su dung ildasm.exe de xem ma MSIL va xuat sang"
    + " file .il:"
    IL_006d:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0072:  nop
    IL_0073:  ldstr      "    ildasm Bai01.dll /out=Bai01.il"
    IL_0078:  call       void [System.Console]System.Console::WriteLine(string)
    IL_007d:  nop
    IL_007e:  ldstr      "B3: Su dung ilasm.exe de dong goi file .il tro lai"
    + " file PE:"
    IL_0083:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0088:  nop
    IL_0089:  ldstr      "    ilasm Bai01.il /exe /output=Bai01_Rebuilt.exe"
    IL_008e:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0093:  nop
    IL_0094:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Lab01.Bai01.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\admin\Desktop\Study\c#\lab02\Lab02_HoTen_MaSV\Lab01\Bai01\Bai01.res

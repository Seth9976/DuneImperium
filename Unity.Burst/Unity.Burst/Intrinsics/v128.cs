using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct v128
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000A6B0 File Offset: 0x000088B0
		// Note: this type is marked as 'beforefieldinit'.
		static v128()
		{
			Il2CppClassPointerStore<v128>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "v128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<v128>.NativeClassPtr);
			v128.NativeFieldInfoPtr_Byte0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte0");
			v128.NativeFieldInfoPtr_Byte1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte1");
			v128.NativeFieldInfoPtr_Byte2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte2");
			v128.NativeFieldInfoPtr_Byte3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte3");
			v128.NativeFieldInfoPtr_Byte4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte4");
			v128.NativeFieldInfoPtr_Byte5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte5");
			v128.NativeFieldInfoPtr_Byte6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte6");
			v128.NativeFieldInfoPtr_Byte7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte7");
			v128.NativeFieldInfoPtr_Byte8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte8");
			v128.NativeFieldInfoPtr_Byte9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte9");
			v128.NativeFieldInfoPtr_Byte10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte10");
			v128.NativeFieldInfoPtr_Byte11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte11");
			v128.NativeFieldInfoPtr_Byte12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte12");
			v128.NativeFieldInfoPtr_Byte13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte13");
			v128.NativeFieldInfoPtr_Byte14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte14");
			v128.NativeFieldInfoPtr_Byte15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Byte15");
			v128.NativeFieldInfoPtr_SByte0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte0");
			v128.NativeFieldInfoPtr_SByte1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte1");
			v128.NativeFieldInfoPtr_SByte2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte2");
			v128.NativeFieldInfoPtr_SByte3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte3");
			v128.NativeFieldInfoPtr_SByte4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte4");
			v128.NativeFieldInfoPtr_SByte5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte5");
			v128.NativeFieldInfoPtr_SByte6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte6");
			v128.NativeFieldInfoPtr_SByte7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte7");
			v128.NativeFieldInfoPtr_SByte8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte8");
			v128.NativeFieldInfoPtr_SByte9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte9");
			v128.NativeFieldInfoPtr_SByte10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte10");
			v128.NativeFieldInfoPtr_SByte11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte11");
			v128.NativeFieldInfoPtr_SByte12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte12");
			v128.NativeFieldInfoPtr_SByte13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte13");
			v128.NativeFieldInfoPtr_SByte14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte14");
			v128.NativeFieldInfoPtr_SByte15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SByte15");
			v128.NativeFieldInfoPtr_UShort0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort0");
			v128.NativeFieldInfoPtr_UShort1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort1");
			v128.NativeFieldInfoPtr_UShort2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort2");
			v128.NativeFieldInfoPtr_UShort3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort3");
			v128.NativeFieldInfoPtr_UShort4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort4");
			v128.NativeFieldInfoPtr_UShort5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort5");
			v128.NativeFieldInfoPtr_UShort6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort6");
			v128.NativeFieldInfoPtr_UShort7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UShort7");
			v128.NativeFieldInfoPtr_SShort0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort0");
			v128.NativeFieldInfoPtr_SShort1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort1");
			v128.NativeFieldInfoPtr_SShort2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort2");
			v128.NativeFieldInfoPtr_SShort3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort3");
			v128.NativeFieldInfoPtr_SShort4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort4");
			v128.NativeFieldInfoPtr_SShort5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort5");
			v128.NativeFieldInfoPtr_SShort6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort6");
			v128.NativeFieldInfoPtr_SShort7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SShort7");
			v128.NativeFieldInfoPtr_UInt0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt0");
			v128.NativeFieldInfoPtr_UInt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt1");
			v128.NativeFieldInfoPtr_UInt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt2");
			v128.NativeFieldInfoPtr_UInt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "UInt3");
			v128.NativeFieldInfoPtr_SInt0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt0");
			v128.NativeFieldInfoPtr_SInt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt1");
			v128.NativeFieldInfoPtr_SInt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt2");
			v128.NativeFieldInfoPtr_SInt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SInt3");
			v128.NativeFieldInfoPtr_ULong0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "ULong0");
			v128.NativeFieldInfoPtr_ULong1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "ULong1");
			v128.NativeFieldInfoPtr_SLong0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SLong0");
			v128.NativeFieldInfoPtr_SLong1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "SLong1");
			v128.NativeFieldInfoPtr_Float0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float0");
			v128.NativeFieldInfoPtr_Float1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float1");
			v128.NativeFieldInfoPtr_Float2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float2");
			v128.NativeFieldInfoPtr_Float3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Float3");
			v128.NativeFieldInfoPtr_Double0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Double0");
			v128.NativeFieldInfoPtr_Double1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Double1");
			v128.NativeFieldInfoPtr_Lo64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Lo64");
			v128.NativeFieldInfoPtr_Hi64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<v128>.NativeClassPtr, "Hi64");
			v128.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665975);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665976);
			v128.NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665977);
			v128.NativeMethodInfoPtr__ctor_Public_Void_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665978);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665979);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_Int16_Int16_Int16_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665980);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665981);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665982);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665983);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665984);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665985);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665986);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665987);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665988);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665989);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665990);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665991);
			v128.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665992);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665993);
			v128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665994);
			v128.NativeMethodInfoPtr__ctor_Public_Void_v64_v64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<v128>.NativeClassPtr, 100665995);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062798, RefRangeEnd = 1062806, XrefRangeStart = 1062798, XrefRangeEnd = 1062798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(byte b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000AE08 File Offset: 0x00009008
		[CallerCount(0)]
		public unsafe v128(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000AF14 File Offset: 0x00009114
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062798, RefRangeEnd = 1062806, XrefRangeStart = 1062798, XrefRangeEnd = 1062806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(sbyte b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_SByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000AF48 File Offset: 0x00009148
		[CallerCount(0)]
		public unsafe v128(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B054 File Offset: 0x00009254
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062806, RefRangeEnd = 1062814, XrefRangeStart = 1062806, XrefRangeEnd = 1062806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(short v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B088 File Offset: 0x00009288
		[CallerCount(0)]
		public unsafe v128(short a, short b, short c, short d, short e, short f, short g, short h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_Int16_Int16_Int16_Int16_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B11C File Offset: 0x0000931C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062806, RefRangeEnd = 1062814, XrefRangeStart = 1062806, XrefRangeEnd = 1062814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(ushort v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000B150 File Offset: 0x00009350
		[CallerCount(0)]
		public unsafe v128(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B1E4 File Offset: 0x000093E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062814, RefRangeEnd = 1062822, XrefRangeStart = 1062814, XrefRangeEnd = 1062814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000B218 File Offset: 0x00009418
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(int a, int b, int c, int d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B274 File Offset: 0x00009474
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1062814, RefRangeEnd = 1062822, XrefRangeStart = 1062814, XrefRangeEnd = 1062822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B2A8 File Offset: 0x000094A8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(uint a, uint b, uint c, uint d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B304 File Offset: 0x00009504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 637906, RefRangeEnd = 637908, XrefRangeStart = 637906, XrefRangeEnd = 637908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B338 File Offset: 0x00009538
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(float a, float b, float c, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B394 File Offset: 0x00009594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 634777, RefRangeEnd = 634779, XrefRangeStart = 634777, XrefRangeEnd = 634779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(double f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000B3C8 File Offset: 0x000095C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 596903, RefRangeEnd = 596910, XrefRangeStart = 596903, XrefRangeEnd = 596910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000B408 File Offset: 0x00009608
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1062822, RefRangeEnd = 1062831, XrefRangeStart = 1062822, XrefRangeEnd = 1062822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(long f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000B43C File Offset: 0x0000963C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(long a, long b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000B47C File Offset: 0x0000967C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1062822, RefRangeEnd = 1062831, XrefRangeStart = 1062822, XrefRangeEnd = 1062831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(ulong f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(ulong a, ulong b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe v128(v64 lo, v64 hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(v128.NativeMethodInfoPtr__ctor_Public_Void_v64_v64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002D7D File Offset: 0x00000F7D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<v128>.NativeClassPtr, ref this));
		}

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_Byte0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_Byte1;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_Byte2;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_Byte3;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_Byte4;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_Byte5;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_Byte6;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_Byte7;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_Byte8;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_Byte9;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_Byte10;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_Byte11;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_Byte12;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_Byte13;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_Byte14;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_Byte15;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_SByte0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_SByte1;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_SByte2;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_SByte3;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_SByte4;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_SByte5;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_SByte6;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_SByte7;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_SByte8;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_SByte9;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_SByte10;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_SByte11;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_SByte12;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_SByte13;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_SByte14;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_SByte15;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_UShort0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_UShort1;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_UShort2;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_UShort3;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_UShort4;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_UShort5;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_UShort6;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_UShort7;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_SShort0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_SShort1;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_SShort2;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_SShort3;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_SShort4;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_SShort5;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_SShort6;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_SShort7;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_UInt0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_UInt1;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_UInt2;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_UInt3;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_SInt0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_SInt1;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_SInt2;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_SInt3;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_ULong0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_ULong1;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_SLong0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_SLong1;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_Float0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_Float1;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_Float2;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_Float3;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_Double0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_Double1;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_Lo64;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_Hi64;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_SByte_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_Int16_Int16_Int16_Int16_Int16_Int16_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_UInt16_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_v64_v64_0;

		// Token: 0x04000282 RID: 642
		[FieldOffset(0)]
		public byte Byte0;

		// Token: 0x04000283 RID: 643
		[FieldOffset(1)]
		public byte Byte1;

		// Token: 0x04000284 RID: 644
		[FieldOffset(2)]
		public byte Byte2;

		// Token: 0x04000285 RID: 645
		[FieldOffset(3)]
		public byte Byte3;

		// Token: 0x04000286 RID: 646
		[FieldOffset(4)]
		public byte Byte4;

		// Token: 0x04000287 RID: 647
		[FieldOffset(5)]
		public byte Byte5;

		// Token: 0x04000288 RID: 648
		[FieldOffset(6)]
		public byte Byte6;

		// Token: 0x04000289 RID: 649
		[FieldOffset(7)]
		public byte Byte7;

		// Token: 0x0400028A RID: 650
		[FieldOffset(8)]
		public byte Byte8;

		// Token: 0x0400028B RID: 651
		[FieldOffset(9)]
		public byte Byte9;

		// Token: 0x0400028C RID: 652
		[FieldOffset(10)]
		public byte Byte10;

		// Token: 0x0400028D RID: 653
		[FieldOffset(11)]
		public byte Byte11;

		// Token: 0x0400028E RID: 654
		[FieldOffset(12)]
		public byte Byte12;

		// Token: 0x0400028F RID: 655
		[FieldOffset(13)]
		public byte Byte13;

		// Token: 0x04000290 RID: 656
		[FieldOffset(14)]
		public byte Byte14;

		// Token: 0x04000291 RID: 657
		[FieldOffset(15)]
		public byte Byte15;

		// Token: 0x04000292 RID: 658
		[FieldOffset(0)]
		public sbyte SByte0;

		// Token: 0x04000293 RID: 659
		[FieldOffset(1)]
		public sbyte SByte1;

		// Token: 0x04000294 RID: 660
		[FieldOffset(2)]
		public sbyte SByte2;

		// Token: 0x04000295 RID: 661
		[FieldOffset(3)]
		public sbyte SByte3;

		// Token: 0x04000296 RID: 662
		[FieldOffset(4)]
		public sbyte SByte4;

		// Token: 0x04000297 RID: 663
		[FieldOffset(5)]
		public sbyte SByte5;

		// Token: 0x04000298 RID: 664
		[FieldOffset(6)]
		public sbyte SByte6;

		// Token: 0x04000299 RID: 665
		[FieldOffset(7)]
		public sbyte SByte7;

		// Token: 0x0400029A RID: 666
		[FieldOffset(8)]
		public sbyte SByte8;

		// Token: 0x0400029B RID: 667
		[FieldOffset(9)]
		public sbyte SByte9;

		// Token: 0x0400029C RID: 668
		[FieldOffset(10)]
		public sbyte SByte10;

		// Token: 0x0400029D RID: 669
		[FieldOffset(11)]
		public sbyte SByte11;

		// Token: 0x0400029E RID: 670
		[FieldOffset(12)]
		public sbyte SByte12;

		// Token: 0x0400029F RID: 671
		[FieldOffset(13)]
		public sbyte SByte13;

		// Token: 0x040002A0 RID: 672
		[FieldOffset(14)]
		public sbyte SByte14;

		// Token: 0x040002A1 RID: 673
		[FieldOffset(15)]
		public sbyte SByte15;

		// Token: 0x040002A2 RID: 674
		[FieldOffset(0)]
		public ushort UShort0;

		// Token: 0x040002A3 RID: 675
		[FieldOffset(2)]
		public ushort UShort1;

		// Token: 0x040002A4 RID: 676
		[FieldOffset(4)]
		public ushort UShort2;

		// Token: 0x040002A5 RID: 677
		[FieldOffset(6)]
		public ushort UShort3;

		// Token: 0x040002A6 RID: 678
		[FieldOffset(8)]
		public ushort UShort4;

		// Token: 0x040002A7 RID: 679
		[FieldOffset(10)]
		public ushort UShort5;

		// Token: 0x040002A8 RID: 680
		[FieldOffset(12)]
		public ushort UShort6;

		// Token: 0x040002A9 RID: 681
		[FieldOffset(14)]
		public ushort UShort7;

		// Token: 0x040002AA RID: 682
		[FieldOffset(0)]
		public short SShort0;

		// Token: 0x040002AB RID: 683
		[FieldOffset(2)]
		public short SShort1;

		// Token: 0x040002AC RID: 684
		[FieldOffset(4)]
		public short SShort2;

		// Token: 0x040002AD RID: 685
		[FieldOffset(6)]
		public short SShort3;

		// Token: 0x040002AE RID: 686
		[FieldOffset(8)]
		public short SShort4;

		// Token: 0x040002AF RID: 687
		[FieldOffset(10)]
		public short SShort5;

		// Token: 0x040002B0 RID: 688
		[FieldOffset(12)]
		public short SShort6;

		// Token: 0x040002B1 RID: 689
		[FieldOffset(14)]
		public short SShort7;

		// Token: 0x040002B2 RID: 690
		[FieldOffset(0)]
		public uint UInt0;

		// Token: 0x040002B3 RID: 691
		[FieldOffset(4)]
		public uint UInt1;

		// Token: 0x040002B4 RID: 692
		[FieldOffset(8)]
		public uint UInt2;

		// Token: 0x040002B5 RID: 693
		[FieldOffset(12)]
		public uint UInt3;

		// Token: 0x040002B6 RID: 694
		[FieldOffset(0)]
		public int SInt0;

		// Token: 0x040002B7 RID: 695
		[FieldOffset(4)]
		public int SInt1;

		// Token: 0x040002B8 RID: 696
		[FieldOffset(8)]
		public int SInt2;

		// Token: 0x040002B9 RID: 697
		[FieldOffset(12)]
		public int SInt3;

		// Token: 0x040002BA RID: 698
		[FieldOffset(0)]
		public ulong ULong0;

		// Token: 0x040002BB RID: 699
		[FieldOffset(8)]
		public ulong ULong1;

		// Token: 0x040002BC RID: 700
		[FieldOffset(0)]
		public long SLong0;

		// Token: 0x040002BD RID: 701
		[FieldOffset(8)]
		public long SLong1;

		// Token: 0x040002BE RID: 702
		[FieldOffset(0)]
		public float Float0;

		// Token: 0x040002BF RID: 703
		[FieldOffset(4)]
		public float Float1;

		// Token: 0x040002C0 RID: 704
		[FieldOffset(8)]
		public float Float2;

		// Token: 0x040002C1 RID: 705
		[FieldOffset(12)]
		public float Float3;

		// Token: 0x040002C2 RID: 706
		[FieldOffset(0)]
		public double Double0;

		// Token: 0x040002C3 RID: 707
		[FieldOffset(8)]
		public double Double1;

		// Token: 0x040002C4 RID: 708
		[FieldOffset(0)]
		public v64 Lo64;

		// Token: 0x040002C5 RID: 709
		[FieldOffset(8)]
		public v64 Hi64;
	}
}

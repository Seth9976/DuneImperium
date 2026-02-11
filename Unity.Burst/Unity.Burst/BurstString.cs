using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000011 RID: 17
	public static class BurstString : Object
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00007610 File Offset: 0x00005810
		// Note: this type is marked as 'beforefieldinit'.
		static BurstString()
		{
			Il2CppClassPointerStore<BurstString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString>.NativeClassPtr);
			BurstString.NativeFieldInfoPtr_SplitByColon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "SplitByColon");
			BurstString.NativeFieldInfoPtr_logTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "logTable");
			BurstString.NativeFieldInfoPtr_g_PowerOf10_U32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "g_PowerOf10_U32");
			BurstString.NativeFieldInfoPtr_InfinityString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "InfinityString");
			BurstString.NativeFieldInfoPtr_NanString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "NanString");
			BurstString.NativeFieldInfoPtr_SinglePrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "SinglePrecision");
			BurstString.NativeFieldInfoPtr_DoublePrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "DoublePrecision");
			BurstString.NativeFieldInfoPtr_SingleNumberBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "SingleNumberBufferLength");
			BurstString.NativeFieldInfoPtr_DoubleNumberBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "DoubleNumberBufferLength");
			BurstString.NativeFieldInfoPtr_SinglePrecisionCustomFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "SinglePrecisionCustomFormat");
			BurstString.NativeFieldInfoPtr_DoublePrecisionCustomFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "DoublePrecisionCustomFormat");
			BurstString.NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663435);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663436);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663437);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663438);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663439);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663440);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663441);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663442);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663443);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663444);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663445);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663446);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663447);
			BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663448);
			BurstString.NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663449);
			BurstString.NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663450);
			BurstString.NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663451);
			BurstString.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663452);
			BurstString.NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663453);
			BurstString.NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663454);
			BurstString.NativeMethodInfoPtr_OptsSplit_Private_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663455);
			BurstString.NativeMethodInfoPtr_ParseFormatToFormatOptions_Public_Static_FormatOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663456);
			BurstString.NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663457);
			BurstString.NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663458);
			BurstString.NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663459);
			BurstString.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663460);
			BurstString.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663461);
			BurstString.NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663462);
			BurstString.NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663463);
			BurstString.NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663464);
			BurstString.NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663465);
			BurstString.NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663466);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663467);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663468);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663469);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663470);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663471);
			BurstString.NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663472);
			BurstString.NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663473);
			BurstString.NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663474);
			BurstString.NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663475);
			BurstString.NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663476);
			BurstString.NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663477);
			BurstString.NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663478);
			BurstString.NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663479);
			BurstString.NativeMethodInfoPtr_FormatPositional_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663480);
			BurstString.NativeMethodInfoPtr_FormatScientific_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663481);
			BurstString.NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663482);
			BurstString.NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663483);
			BurstString.NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663484);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007B04 File Offset: 0x00005D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051899, XrefRangeEnd = 1051900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007B60 File Offset: 0x00005D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051900, XrefRangeEnd = 1051907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051907, XrefRangeEnd = 1051911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007C44 File Offset: 0x00005E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051911, XrefRangeEnd = 1051915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051915, XrefRangeEnd = 1051922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007D1C File Offset: 0x00005F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051922, XrefRangeEnd = 1051932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007D88 File Offset: 0x00005F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051932, XrefRangeEnd = 1051939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007DF4 File Offset: 0x00005FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051939, XrefRangeEnd = 1051946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007E60 File Offset: 0x00006060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051946, XrefRangeEnd = 1051950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007ECC File Offset: 0x000060CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051950, XrefRangeEnd = 1051954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007F38 File Offset: 0x00006138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051954, XrefRangeEnd = 1051961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007FA4 File Offset: 0x000061A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051961, XrefRangeEnd = 1051968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008010 File Offset: 0x00006210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051968, XrefRangeEnd = 1051975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000807C File Offset: 0x0000627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051975, XrefRangeEnd = 1051982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptionsRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000080E8 File Offset: 0x000062E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1051993, RefRangeEnd = 1052001, XrefRangeStart = 1051982, XrefRangeEnd = 1051993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, BurstString.FormatOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008154 File Offset: 0x00006354
		[CallerCount(0)]
		public unsafe static int GetLengthIntegerToString(long value, int basis, int zeroPadding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref basis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroPadding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000081B0 File Offset: 0x000063B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1052012, RefRangeEnd = 1052017, XrefRangeStart = 1052001, XrefRangeEnd = 1052012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, BurstString.FormatOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000821C File Offset: 0x0000641C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1052037, RefRangeEnd = 1052041, XrefRangeStart = 1052017, XrefRangeEnd = 1052037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, BurstString.FormatOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008294 File Offset: 0x00006494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052041, XrefRangeEnd = 1052042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroPadding;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputPositiveSign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000830C File Offset: 0x0000650C
		[CallerCount(0)]
		public unsafe static byte ValueToIntegerChar(int value, bool uppercase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uppercase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008358 File Offset: 0x00006558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052052, RefRangeEnd = 1052053, XrefRangeStart = 1052042, XrefRangeEnd = 1052052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OptsSplit(string fullFormat, out string padding, out string format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullFormat);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_OptsSplit_Private_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			padding = IL2CPP.Il2CppStringToManaged(intPtr);
			format = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000083C4 File Offset: 0x000065C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052053, XrefRangeEnd = 1052074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstString.FormatOptions ParseFormatToFormatOptions(string fullFormat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullFormat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ParseFormatToFormatOptions_Public_Static_FormatOptions_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008408 File Offset: 0x00006608
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1052077, RefRangeEnd = 1052082, XrefRangeStart = 1052074, XrefRangeEnd = 1052077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000847C File Offset: 0x0000667C
		[CallerCount(0)]
		public unsafe static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000084F0 File Offset: 0x000066F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052086, RefRangeEnd = 1052087, XrefRangeStart = 1052082, XrefRangeEnd = 1052086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLengthForFormatGeneral(ref BurstString.NumberBuffer number, int nMaxDigits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000853C File Offset: 0x0000673C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052093, RefRangeEnd = 1052094, XrefRangeStart = 1052087, XrefRangeEnd = 1052093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, byte expChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000085B4 File Offset: 0x000067B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052094, XrefRangeEnd = 1052099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RoundNumber(ref BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCorrectlyRounded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008604 File Offset: 0x00006804
		[CallerCount(0)]
		public unsafe static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dig;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCorrectlyRounded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000865C File Offset: 0x0000685C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052103, RefRangeEnd = 1052106, XrefRangeStart = 1052099, XrefRangeEnd = 1052103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint LogBase2(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000869C File Offset: 0x0000689C
		[CallerCount(0)]
		public unsafe static int BigInt_Compare([In] ref BurstString.tBigInt lhs, [In] ref BurstString.tBigInt rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000086E8 File Offset: 0x000068E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052106, XrefRangeEnd = 1052112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_Add(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt lhs, [In] ref BurstString.tBigInt rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008738 File Offset: 0x00006938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1052113, RefRangeEnd = 1052115, XrefRangeStart = 1052112, XrefRangeEnd = 1052113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_Add_internal(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt pLarge, [In] ref BurstString.tBigInt pSmall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLarge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSmall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00008788 File Offset: 0x00006988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052121, RefRangeEnd = 1052124, XrefRangeStart = 1052115, XrefRangeEnd = 1052121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_Multiply(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt lhs, [In] ref BurstString.tBigInt rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000087D8 File Offset: 0x000069D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052126, RefRangeEnd = 1052129, XrefRangeStart = 1052124, XrefRangeEnd = 1052126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_Multiply_internal(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt pLarge, [In] ref BurstString.tBigInt pSmall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLarge;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSmall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008828 File Offset: 0x00006A28
		[CallerCount(0)]
		public unsafe static void BigInt_Multiply(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00008878 File Offset: 0x00006A78
		[CallerCount(0)]
		public unsafe static void BigInt_Multiply2(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt input)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000088B8 File Offset: 0x00006AB8
		[CallerCount(0)]
		public unsafe static void BigInt_Multiply2(ref BurstString.tBigInt pResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000088EC File Offset: 0x00006AEC
		[CallerCount(0)]
		public unsafe static void BigInt_Multiply10(ref BurstString.tBigInt pResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008920 File Offset: 0x00006B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1052129, RefRangeEnd = 1052132, XrefRangeStart = 1052129, XrefRangeEnd = 1052129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstString.tBigInt g_PowerOf10_Big(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00008960 File Offset: 0x00006B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052132, XrefRangeEnd = 1052141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_Pow10(out BurstString.tBigInt pResult, uint exponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000089A0 File Offset: 0x00006BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052151, RefRangeEnd = 1052152, XrefRangeStart = 1052141, XrefRangeEnd = 1052151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_MultiplyPow10(out BurstString.tBigInt pResult, [In] ref BurstString.tBigInt input, uint exponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000089F0 File Offset: 0x00006BF0
		[CallerCount(0)]
		public unsafe static void BigInt_Pow2(out BurstString.tBigInt pResult, uint exponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008A30 File Offset: 0x00006C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1052157, RefRangeEnd = 1052159, XrefRangeStart = 1052152, XrefRangeEnd = 1052157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint BigInt_DivideWithRemainder_MaxQuotient9(ref BurstString.tBigInt pDividend, [In] ref BurstString.tBigInt divisor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pDividend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &divisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008A7C File Offset: 0x00006C7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1052159, RefRangeEnd = 1052166, XrefRangeStart = 1052159, XrefRangeEnd = 1052159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BigInt_ShiftLeft(ref BurstString.tBigInt pResult, uint shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00008ABC File Offset: 0x00006CBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1052278, RefRangeEnd = 1052282, XrefRangeStart = 1052166, XrefRangeEnd = 1052278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mantissa;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissaHighBitIdx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnequalMargins;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cutoffMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cutoffNumber;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pOutBuffer;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutExponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008B6C File Offset: 0x00006D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052282, XrefRangeEnd = 1052298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pOutBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissa;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissaHighBitIdx;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnequalMargins;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatPositional_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00008BFC File Offset: 0x00006DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052298, XrefRangeEnd = 1052308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pOutBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissa;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissaHighBitIdx;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnequalMargins;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatScientific_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008C8C File Offset: 0x00006E8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1052321, RefRangeEnd = 1052323, XrefRangeStart = 1052308, XrefRangeEnd = 1052321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, BurstString.FormatOptions formatOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mantissa;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNegative;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00008D04 File Offset: 0x00006F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052345, RefRangeEnd = 1052346, XrefRangeStart = 1052323, XrefRangeEnd = 1052345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, BurstString.FormatOptions formatOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008D70 File Offset: 0x00006F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1052368, RefRangeEnd = 1052369, XrefRangeStart = 1052346, XrefRangeEnd = 1052368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, BurstString.FormatOptions formatOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public BurstString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00008DDC File Offset: 0x00006FDC
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002B02 File Offset: 0x00000D02
		public unsafe static Il2CppStructArray<char> SplitByColon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_SplitByColon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_SplitByColon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00008E04 File Offset: 0x00007004
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe static Il2CppStructArray<byte> logTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_logTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_logTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00008E2C File Offset: 0x0000702C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002B26 File Offset: 0x00000D26
		public unsafe static Il2CppStructArray<uint> g_PowerOf10_U32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_g_PowerOf10_U32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_g_PowerOf10_U32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00008E54 File Offset: 0x00007054
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002B38 File Offset: 0x00000D38
		public unsafe static Il2CppStructArray<byte> InfinityString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_InfinityString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_InfinityString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00008E7C File Offset: 0x0000707C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002B4A File Offset: 0x00000D4A
		public unsafe static Il2CppStructArray<byte> NanString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_NanString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_NanString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00008EA4 File Offset: 0x000070A4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002B5C File Offset: 0x00000D5C
		public unsafe static int SinglePrecision
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_SinglePrecision, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_SinglePrecision, (void*)(&value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00008EC0 File Offset: 0x000070C0
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002B6A File Offset: 0x00000D6A
		public unsafe static int DoublePrecision
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_DoublePrecision, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_DoublePrecision, (void*)(&value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00008EDC File Offset: 0x000070DC
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002B78 File Offset: 0x00000D78
		public unsafe static int SingleNumberBufferLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_SingleNumberBufferLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_SingleNumberBufferLength, (void*)(&value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00008EF8 File Offset: 0x000070F8
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe static int DoubleNumberBufferLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_DoubleNumberBufferLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_DoubleNumberBufferLength, (void*)(&value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00008F14 File Offset: 0x00007114
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe static int SinglePrecisionCustomFormat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_SinglePrecisionCustomFormat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_SinglePrecisionCustomFormat, (void*)(&value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00008F30 File Offset: 0x00007130
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public unsafe static int DoublePrecisionCustomFormat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BurstString.NativeFieldInfoPtr_DoublePrecisionCustomFormat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstString.NativeFieldInfoPtr_DoublePrecisionCustomFormat, (void*)(&value));
			}
		}

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_SplitByColon;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_logTable;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_g_PowerOf10_U32;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_InfinityString;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_NanString;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_SinglePrecision;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_DoublePrecision;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_SingleNumberBufferLength;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_DoubleNumberBufferLength;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_SinglePrecisionCustomFormat;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_DoublePrecisionCustomFormat;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_OptsSplit_Private_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ParseFormatToFormatOptions_Public_Static_FormatOptions_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_FormatPositional_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_FormatScientific_Private_Static_Int32_ptr_Byte_UInt32_UInt64_Int32_UInt32_Boolean_Int32_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0;

		// Token: 0x02000039 RID: 57
		public class PreserveAttribute : Attribute
		{
			// Token: 0x060002FF RID: 767 RVA: 0x0000311F File Offset: 0x0000131F
			// Note: this type is marked as 'beforefieldinit'.
			static PreserveAttribute()
			{
				Il2CppClassPointerStore<BurstString.PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "PreserveAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.PreserveAttribute>.NativeClassPtr);
				BurstString.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.PreserveAttribute>.NativeClassPtr, 100663486);
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreserveAttribute()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstString.PreserveAttribute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x00003153 File Offset: 0x00001353
			public PreserveAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200003A RID: 58
		public enum NumberBufferKind
		{
			// Token: 0x0400048C RID: 1164
			Integer,
			// Token: 0x0400048D RID: 1165
			Float
		}

		// Token: 0x0200003B RID: 59
		[StructLayout(2)]
		public struct NumberBuffer
		{
			// Token: 0x06000302 RID: 770 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
			// Note: this type is marked as 'beforefieldinit'.
			static NumberBuffer()
			{
				Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "NumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr);
				BurstString.NumberBuffer.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, "_buffer");
				BurstString.NumberBuffer.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, "Kind");
				BurstString.NumberBuffer.NativeFieldInfoPtr_DigitsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, "DigitsCount");
				BurstString.NumberBuffer.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, "Scale");
				BurstString.NumberBuffer.NativeFieldInfoPtr_IsNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, "IsNegative");
				BurstString.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, 100663487);
				BurstString.NumberBuffer.NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, 100663488);
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0000F198 File Offset: 0x0000D398
			[CallerCount(0)]
			public unsafe NumberBuffer(BurstString.NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref kind;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitsCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNegative;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0000F204 File Offset: 0x0000D404
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte* GetDigitsPointer()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.NumberBuffer.NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0000315C File Offset: 0x0000135C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.NumberBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeFieldInfoPtr_Kind;

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeFieldInfoPtr_DigitsCount;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeFieldInfoPtr_Scale;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeFieldInfoPtr_IsNegative;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0;

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0;

			// Token: 0x04000495 RID: 1173
			[FieldOffset(0)]
			public readonly IntPtr _buffer;

			// Token: 0x04000496 RID: 1174
			[FieldOffset(8)]
			public BurstString.NumberBufferKind Kind;

			// Token: 0x04000497 RID: 1175
			[FieldOffset(12)]
			public int DigitsCount;

			// Token: 0x04000498 RID: 1176
			[FieldOffset(16)]
			public int Scale;

			// Token: 0x04000499 RID: 1177
			[FieldOffset(20)]
			[MarshalAs(4)]
			public readonly bool IsNegative;
		}

		// Token: 0x0200003C RID: 60
		public enum NumberFormatKind : byte
		{
			// Token: 0x0400049B RID: 1179
			General,
			// Token: 0x0400049C RID: 1180
			Decimal,
			// Token: 0x0400049D RID: 1181
			DecimalForceSigned,
			// Token: 0x0400049E RID: 1182
			Hexadecimal
		}

		// Token: 0x0200003D RID: 61
		[StructLayout(2)]
		public struct FormatOptions
		{
			// Token: 0x06000306 RID: 774 RVA: 0x0000F22C File Offset: 0x0000D42C
			// Note: this type is marked as 'beforefieldinit'.
			static FormatOptions()
			{
				Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "FormatOptions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr);
				BurstString.FormatOptions.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, "Kind");
				BurstString.FormatOptions.NativeFieldInfoPtr_AlignAndSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, "AlignAndSize");
				BurstString.FormatOptions.NativeFieldInfoPtr_Specifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, "Specifier");
				BurstString.FormatOptions.NativeFieldInfoPtr_Lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, "Lowercase");
				BurstString.FormatOptions.NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, 100663489);
				BurstString.FormatOptions.NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, 100663490);
				BurstString.FormatOptions.NativeMethodInfoPtr_EncodeToRaw_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, 100663491);
				BurstString.FormatOptions.NativeMethodInfoPtr_GetBase_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, 100663492);
				BurstString.FormatOptions.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, 100663493);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0000F30C File Offset: 0x0000D50C
			[CallerCount(0)]
			public unsafe FormatOptions(BurstString.NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref kind;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignAndSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specifier;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowercase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.FormatOptions.NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000308 RID: 776 RVA: 0x0000F368 File Offset: 0x0000D568
			public unsafe bool Uppercase
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.FormatOptions.NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000F398 File Offset: 0x0000D598
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EncodeToRaw()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.FormatOptions.NativeMethodInfoPtr_EncodeToRaw_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600030A RID: 778 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
			[CallerCount(0)]
			public unsafe int GetBase()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.FormatOptions.NativeMethodInfoPtr_GetBase_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0000F3F8 File Offset: 0x0000D5F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051853, XrefRangeEnd = 1051899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.FormatOptions.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600030C RID: 780 RVA: 0x0000316E File Offset: 0x0000136E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.FormatOptions>.NativeClassPtr, ref this));
			}

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeFieldInfoPtr_Kind;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeFieldInfoPtr_AlignAndSize;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeFieldInfoPtr_Specifier;

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeFieldInfoPtr_Lowercase;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0;

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeMethodInfoPtr_EncodeToRaw_Public_Int32_0;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeMethodInfoPtr_GetBase_Public_Int32_0;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040004A8 RID: 1192
			[FieldOffset(0)]
			public BurstString.NumberFormatKind Kind;

			// Token: 0x040004A9 RID: 1193
			[FieldOffset(1)]
			public sbyte AlignAndSize;

			// Token: 0x040004AA RID: 1194
			[FieldOffset(2)]
			public byte Specifier;

			// Token: 0x040004AB RID: 1195
			[FieldOffset(3)]
			[MarshalAs(4)]
			public bool Lowercase;
		}

		// Token: 0x0200003E RID: 62
		[StructLayout(2)]
		public struct tBigInt
		{
			// Token: 0x0600030D RID: 781 RVA: 0x0000F424 File Offset: 0x0000D624
			// Note: this type is marked as 'beforefieldinit'.
			static tBigInt()
			{
				Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tBigInt");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr);
				BurstString.tBigInt.NativeFieldInfoPtr_c_BigInt_MaxBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, "c_BigInt_MaxBlocks");
				BurstString.tBigInt.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, "m_length");
				BurstString.tBigInt.NativeFieldInfoPtr_m_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, "m_blocks");
				BurstString.tBigInt.NativeMethodInfoPtr_GetLength_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663494);
				BurstString.tBigInt.NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663495);
				BurstString.tBigInt.NativeMethodInfoPtr_SetZero_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663496);
				BurstString.tBigInt.NativeMethodInfoPtr_IsZero_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663497);
				BurstString.tBigInt.NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663498);
				BurstString.tBigInt.NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663499);
				BurstString.tBigInt.NativeMethodInfoPtr_GetU32_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, 100663500);
			}

			// Token: 0x0600030E RID: 782 RVA: 0x0000F518 File Offset: 0x0000D718
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetLength()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_GetLength_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600030F RID: 783 RVA: 0x0000F548 File Offset: 0x0000D748
			[CallerCount(0)]
			public unsafe uint GetBlock(int idx)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref idx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000310 RID: 784 RVA: 0x0000F588 File Offset: 0x0000D788
			[CallerCount(0)]
			public unsafe void SetZero()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_SetZero_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 974118, RefRangeEnd = 974122, XrefRangeStart = 974118, XrefRangeEnd = 974122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsZero()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_IsZero_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
			[CallerCount(0)]
			public unsafe void SetU64(ulong val)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref val;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000313 RID: 787 RVA: 0x0000F614 File Offset: 0x0000D814
			[CallerCount(0)]
			public unsafe void SetU32(uint val)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref val;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000314 RID: 788 RVA: 0x0000F648 File Offset: 0x0000D848
			[CallerCount(0)]
			public unsafe uint GetU32()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tBigInt.NativeMethodInfoPtr_GetU32_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000315 RID: 789 RVA: 0x00003180 File Offset: 0x00001380
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, ref this));
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000316 RID: 790 RVA: 0x0000F678 File Offset: 0x0000D878
			// (set) Token: 0x06000317 RID: 791 RVA: 0x00003192 File Offset: 0x00001392
			public unsafe static int c_BigInt_MaxBlocks
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(BurstString.tBigInt.NativeFieldInfoPtr_c_BigInt_MaxBlocks, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstString.tBigInt.NativeFieldInfoPtr_c_BigInt_MaxBlocks, (void*)(&value));
				}
			}

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeFieldInfoPtr_c_BigInt_MaxBlocks;

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeFieldInfoPtr_m_length;

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeFieldInfoPtr_m_blocks;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_0;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0;

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeMethodInfoPtr_SetZero_Public_Void_0;

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Boolean_0;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0;

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeMethodInfoPtr_GetU32_Public_UInt32_0;

			// Token: 0x040004B6 RID: 1206
			[FieldOffset(0)]
			public int m_length;

			// Token: 0x040004B7 RID: 1207
			[FieldOffset(4)]
			public BurstString.tBigInt._m_blocks_e__FixedBuffer m_blocks;

			// Token: 0x02000068 RID: 104
			[ObfuscatedName("Unity.Burst.BurstString+tBigInt+<m_blocks>e__FixedBuffer")]
			[StructLayout(2)]
			public struct _m_blocks_e__FixedBuffer
			{
				// Token: 0x06001036 RID: 4150 RVA: 0x0000340F File Offset: 0x0000160F
				// Note: this type is marked as 'beforefieldinit'.
				static _m_blocks_e__FixedBuffer()
				{
					Il2CppClassPointerStore<BurstString.tBigInt._m_blocks_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString.tBigInt>.NativeClassPtr, "<m_blocks>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.tBigInt._m_blocks_e__FixedBuffer>.NativeClassPtr);
					BurstString.tBigInt._m_blocks_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tBigInt._m_blocks_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06001037 RID: 4151 RVA: 0x00003443 File Offset: 0x00001643
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.tBigInt._m_blocks_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x040011D6 RID: 4566
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x040011D7 RID: 4567
				[FieldOffset(0)]
				public uint FixedElementField;
			}
		}

		// Token: 0x0200003F RID: 63
		public enum CutoffMode
		{
			// Token: 0x040004B9 RID: 1209
			Unique,
			// Token: 0x040004BA RID: 1210
			TotalLength,
			// Token: 0x040004BB RID: 1211
			FractionLength
		}

		// Token: 0x02000040 RID: 64
		public enum PrintFloatFormat
		{
			// Token: 0x040004BD RID: 1213
			Positional,
			// Token: 0x040004BE RID: 1214
			Scientific
		}

		// Token: 0x02000041 RID: 65
		[StructLayout(2)]
		public struct tFloatUnion32
		{
			// Token: 0x06000318 RID: 792 RVA: 0x0000F694 File Offset: 0x0000D894
			// Note: this type is marked as 'beforefieldinit'.
			static tFloatUnion32()
			{
				Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tFloatUnion32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr);
				BurstString.tFloatUnion32.NativeFieldInfoPtr_m_floatingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, "m_floatingPoint");
				BurstString.tFloatUnion32.NativeFieldInfoPtr_m_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, "m_integer");
				BurstString.tFloatUnion32.NativeMethodInfoPtr_IsNegative_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, 100663501);
				BurstString.tFloatUnion32.NativeMethodInfoPtr_GetExponent_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, 100663502);
				BurstString.tFloatUnion32.NativeMethodInfoPtr_GetMantissa_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, 100663503);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000F724 File Offset: 0x0000D924
			[CallerCount(0)]
			public unsafe bool IsNegative()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion32.NativeMethodInfoPtr_IsNegative_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600031A RID: 794 RVA: 0x0000F754 File Offset: 0x0000D954
			[CallerCount(0)]
			public unsafe uint GetExponent()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion32.NativeMethodInfoPtr_GetExponent_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x0000F784 File Offset: 0x0000D984
			[CallerCount(0)]
			public unsafe uint GetMantissa()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion32.NativeMethodInfoPtr_GetMantissa_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x000031A0 File Offset: 0x000013A0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.tFloatUnion32>.NativeClassPtr, ref this));
			}

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeFieldInfoPtr_m_floatingPoint;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeFieldInfoPtr_m_integer;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr_IsNegative_Public_Boolean_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr_GetExponent_Public_UInt32_0;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeMethodInfoPtr_GetMantissa_Public_UInt32_0;

			// Token: 0x040004C4 RID: 1220
			[FieldOffset(0)]
			public float m_floatingPoint;

			// Token: 0x040004C5 RID: 1221
			[FieldOffset(0)]
			public uint m_integer;
		}

		// Token: 0x02000042 RID: 66
		[StructLayout(2)]
		public struct tFloatUnion64
		{
			// Token: 0x0600031D RID: 797 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
			// Note: this type is marked as 'beforefieldinit'.
			static tFloatUnion64()
			{
				Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tFloatUnion64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr);
				BurstString.tFloatUnion64.NativeFieldInfoPtr_m_floatingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, "m_floatingPoint");
				BurstString.tFloatUnion64.NativeFieldInfoPtr_m_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, "m_integer");
				BurstString.tFloatUnion64.NativeMethodInfoPtr_IsNegative_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, 100663504);
				BurstString.tFloatUnion64.NativeMethodInfoPtr_GetExponent_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, 100663505);
				BurstString.tFloatUnion64.NativeMethodInfoPtr_GetMantissa_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, 100663506);
			}

			// Token: 0x0600031E RID: 798 RVA: 0x0000F844 File Offset: 0x0000DA44
			[CallerCount(0)]
			public unsafe bool IsNegative()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion64.NativeMethodInfoPtr_IsNegative_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600031F RID: 799 RVA: 0x0000F874 File Offset: 0x0000DA74
			[CallerCount(0)]
			public unsafe uint GetExponent()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion64.NativeMethodInfoPtr_GetExponent_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000320 RID: 800 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
			[CallerCount(0)]
			public unsafe ulong GetMantissa()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstString.tFloatUnion64.NativeMethodInfoPtr_GetMantissa_Public_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000321 RID: 801 RVA: 0x000031B2 File Offset: 0x000013B2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstString.tFloatUnion64>.NativeClassPtr, ref this));
			}

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeFieldInfoPtr_m_floatingPoint;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeFieldInfoPtr_m_integer;

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeMethodInfoPtr_IsNegative_Public_Boolean_0;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeMethodInfoPtr_GetExponent_Public_UInt32_0;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr_GetMantissa_Public_UInt64_0;

			// Token: 0x040004CB RID: 1227
			[FieldOffset(0)]
			public double m_floatingPoint;

			// Token: 0x040004CC RID: 1228
			[FieldOffset(0)]
			public ulong m_integer;
		}
	}
}

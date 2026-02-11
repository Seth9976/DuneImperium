using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public sealed class BigInteger : ValueType
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000023A8 File Offset: 0x000005A8
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
			Il2CppClassPointerStore<BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "BigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger>.NativeClassPtr);
			BigInteger.NativeFieldInfoPtr__sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "_sign");
			BigInteger.NativeFieldInfoPtr__bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "_bits");
			BigInteger.NativeFieldInfoPtr_s_bnMinInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "s_bnMinInt");
			BigInteger.NativeFieldInfoPtr_s_bnOneInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "s_bnOneInt");
			BigInteger.NativeFieldInfoPtr_s_bnZeroInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "s_bnZeroInt");
			BigInteger.NativeFieldInfoPtr_s_bnMinusOneInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "s_bnMinusOneInt");
			BigInteger.NativeFieldInfoPtr_s_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "s_success");
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663298);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663299);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663300);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663301);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663302);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663303);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663304);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663305);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663306);
			BigInteger.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663307);
			BigInteger.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663308);
			BigInteger.NativeMethodInfoPtr_get_Zero_Public_Static_get_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663309);
			BigInteger.NativeMethodInfoPtr_get_MinusOne_Public_Static_get_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663310);
			BigInteger.NativeMethodInfoPtr_get_IsZero_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663311);
			BigInteger.NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663312);
			BigInteger.NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663313);
			BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663314);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663315);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663316);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663317);
			BigInteger.NativeMethodInfoPtr_CompareTo_Public_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663318);
			BigInteger.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663319);
			BigInteger.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663320);
			BigInteger.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663321);
			BigInteger.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663322);
			BigInteger.NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663323);
			BigInteger.NativeMethodInfoPtr_TryWriteOrCountBytes_Internal_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663324);
			BigInteger.NativeMethodInfoPtr_TryGetBytes_Private_Il2CppStructArray_1_Byte_GetBytesMode_Span_1_Byte_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663325);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663326);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663327);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663328);
			BigInteger.NativeMethodInfoPtr_Add_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663329);
			BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663330);
			BigInteger.NativeMethodInfoPtr_Subtract_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663331);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663332);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663333);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663334);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663335);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663336);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663337);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663338);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663339);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663340);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663341);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663342);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663343);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663344);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663345);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663346);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663347);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663348);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663349);
			BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663350);
			BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663351);
			BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663352);
			BigInteger.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663353);
			BigInteger.NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663354);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663355);
			BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663356);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663357);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663358);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663359);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663360);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663361);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663362);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663363);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int64_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663364);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int64_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663365);
			BigInteger.NativeMethodInfoPtr_GetPartsForBitManipulation_Private_Static_Boolean_byref_BigInteger_byref_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663366);
			BigInteger.NativeMethodInfoPtr_GetDiffLength_Internal_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000029DC File Offset: 0x00000BDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1235205, RefRangeEnd = 1235213, XrefRangeStart = 1235199, XrefRangeEnd = 1235205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002A28 File Offset: 0x00000C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235217, RefRangeEnd = 1235219, XrefRangeStart = 1235213, XrefRangeEnd = 1235217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(uint value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A74 File Offset: 0x00000C74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235224, RefRangeEnd = 1235231, XrefRangeStart = 1235219, XrefRangeEnd = 1235224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(long value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235235, RefRangeEnd = 1235237, XrefRangeStart = 1235231, XrefRangeEnd = 1235235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(ulong value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B0C File Offset: 0x00000D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235241, RefRangeEnd = 1235242, XrefRangeStart = 1235237, XrefRangeEnd = 1235241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(float value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002B58 File Offset: 0x00000D58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235250, RefRangeEnd = 1235253, XrefRangeStart = 1235242, XrefRangeEnd = 1235250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(double value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235264, RefRangeEnd = 1235265, XrefRangeStart = 1235253, XrefRangeEnd = 1235264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(Decimal value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235270, RefRangeEnd = 1235272, XrefRangeStart = 1235265, XrefRangeEnd = 1235270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(Il2CppStructArray<byte> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C40 File Offset: 0x00000E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235287, RefRangeEnd = 1235289, XrefRangeStart = 1235272, XrefRangeEnd = 1235287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBigEndian;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(int n, Il2CppStructArray<uint> rgu)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgu);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppStructArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D14 File Offset: 0x00000F14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1235296, RefRangeEnd = 1235306, XrefRangeStart = 1235289, XrefRangeEnd = 1235296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(Il2CppStructArray<uint> value, bool negative)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negative;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002D74 File Offset: 0x00000F74
		public unsafe static BigInteger Zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235306, XrefRangeEnd = 1235310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_get_Zero_Public_Static_get_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002DA0 File Offset: 0x00000FA0
		public unsafe static BigInteger MinusOne
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235310, XrefRangeEnd = 1235314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_get_MinusOne_Public_Static_get_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002DCC File Offset: 0x00000FCC
		public unsafe bool IsZero
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 974118, RefRangeEnd = 974122, XrefRangeStart = 974118, XrefRangeEnd = 974122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_get_IsZero_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002E10 File Offset: 0x00001010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235320, RefRangeEnd = 1235323, XrefRangeStart = 1235314, XrefRangeEnd = 1235320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger Parse(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002E60 File Offset: 0x00001060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235323, XrefRangeEnd = 1235325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EBC File Offset: 0x000010BC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F00 File Offset: 0x00001100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235325, XrefRangeEnd = 1235331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F54 File Offset: 0x00001154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235331, RefRangeEnd = 1235333, XrefRangeStart = 1235331, XrefRangeEnd = 1235331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(long other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Equals_Public_Boolean_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002FA4 File Offset: 0x000011A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235336, RefRangeEnd = 1235338, XrefRangeStart = 1235333, XrefRangeEnd = 1235336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BigInteger other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BigInteger_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FFC File Offset: 0x000011FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1235340, RefRangeEnd = 1235344, XrefRangeStart = 1235338, XrefRangeEnd = 1235340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(long other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_CompareTo_Public_Int32_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000304C File Offset: 0x0000124C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1235347, RefRangeEnd = 1235351, XrefRangeStart = 1235344, XrefRangeEnd = 1235347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(BigInteger other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BigInteger_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000030A4 File Offset: 0x000012A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235351, XrefRangeEnd = 1235357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030F8 File Offset: 0x000012F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235361, RefRangeEnd = 1235363, XrefRangeStart = 1235357, XrefRangeEnd = 1235361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ToByteArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000313C File Offset: 0x0000133C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235367, RefRangeEnd = 1235368, XrefRangeStart = 1235363, XrefRangeEnd = 1235367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ToByteArray(bool isUnsigned = false, bool isBigEndian = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isUnsigned;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBigEndian;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000319C File Offset: 0x0000139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235368, XrefRangeEnd = 1235373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBigEndian;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003220 File Offset: 0x00001420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235373, XrefRangeEnd = 1235377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBigEndian;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TryWriteOrCountBytes_Internal_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000032A4 File Offset: 0x000014A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1235406, RefRangeEnd = 1235411, XrefRangeStart = 1235377, XrefRangeEnd = 1235406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUnsigned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBigEndian;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TryGetBytes_Private_Il2CppStructArray_1_Byte_GetBytesMode_Span_1_Byte_Boolean_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003338 File Offset: 0x00001538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235411, XrefRangeEnd = 1235414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003374 File Offset: 0x00001574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1235417, RefRangeEnd = 1235421, XrefRangeStart = 1235414, XrefRangeEnd = 1235417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000033C4 File Offset: 0x000015C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235426, RefRangeEnd = 1235428, XrefRangeStart = 1235421, XrefRangeEnd = 1235426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003424 File Offset: 0x00001624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235428, XrefRangeEnd = 1235450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger Add(Il2CppStructArray<uint> leftBits, int leftSign, Il2CppStructArray<uint> rightBits, int rightSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftBits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftSign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightBits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightSign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Add_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003490 File Offset: 0x00001690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235494, RefRangeEnd = 1235495, XrefRangeStart = 1235450, XrefRangeEnd = 1235494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator -(BigInteger left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000034E8 File Offset: 0x000016E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235495, XrefRangeEnd = 1235518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger Subtract(Il2CppStructArray<uint> leftBits, int leftSign, Il2CppStructArray<uint> rightBits, int rightSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftBits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftSign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightBits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightSign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Subtract_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003554 File Offset: 0x00001754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235519, RefRangeEnd = 1235521, XrefRangeStart = 1235518, XrefRangeEnd = 1235519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000358C File Offset: 0x0000178C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235521, XrefRangeEnd = 1235522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000035C4 File Offset: 0x000017C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235522, XrefRangeEnd = 1235523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000035FC File Offset: 0x000017FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235523, XrefRangeEnd = 1235524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003634 File Offset: 0x00001834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235525, RefRangeEnd = 1235527, XrefRangeStart = 1235524, XrefRangeEnd = 1235525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000366C File Offset: 0x0000186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235527, XrefRangeEnd = 1235528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000036A4 File Offset: 0x000018A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235529, RefRangeEnd = 1235536, XrefRangeStart = 1235528, XrefRangeEnd = 1235529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000036DC File Offset: 0x000018DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235536, XrefRangeEnd = 1235537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003714 File Offset: 0x00001914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235542, RefRangeEnd = 1235543, XrefRangeStart = 1235537, XrefRangeEnd = 1235542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator byte(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000375C File Offset: 0x0000195C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235548, RefRangeEnd = 1235549, XrefRangeStart = 1235543, XrefRangeEnd = 1235548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator sbyte(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000037A4 File Offset: 0x000019A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235554, RefRangeEnd = 1235555, XrefRangeStart = 1235549, XrefRangeEnd = 1235554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator short(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000037EC File Offset: 0x000019EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235560, RefRangeEnd = 1235562, XrefRangeStart = 1235555, XrefRangeEnd = 1235560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ushort(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003834 File Offset: 0x00001A34
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1235563, RefRangeEnd = 1235571, XrefRangeStart = 1235562, XrefRangeEnd = 1235563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000387C File Offset: 0x00001A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235572, RefRangeEnd = 1235573, XrefRangeStart = 1235571, XrefRangeEnd = 1235572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000038C4 File Offset: 0x00001AC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1235574, RefRangeEnd = 1235579, XrefRangeStart = 1235573, XrefRangeEnd = 1235574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000390C File Offset: 0x00001B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235580, RefRangeEnd = 1235582, XrefRangeStart = 1235579, XrefRangeEnd = 1235580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003954 File Offset: 0x00001B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235591, RefRangeEnd = 1235592, XrefRangeStart = 1235582, XrefRangeEnd = 1235591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000399C File Offset: 0x00001B9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235595, RefRangeEnd = 1235598, XrefRangeStart = 1235592, XrefRangeEnd = 1235595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000039E4 File Offset: 0x00001BE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235602, RefRangeEnd = 1235605, XrefRangeStart = 1235598, XrefRangeEnd = 1235602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003A2C File Offset: 0x00001C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235620, RefRangeEnd = 1235621, XrefRangeStart = 1235605, XrefRangeEnd = 1235620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator <<(BigInteger value, int shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003A7C File Offset: 0x00001C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235621, XrefRangeEnd = 1235645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator >>(BigInteger value, int shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003ACC File Offset: 0x00001CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235645, XrefRangeEnd = 1235646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator -(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003B10 File Offset: 0x00001D10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1235691, RefRangeEnd = 1235696, XrefRangeStart = 1235646, XrefRangeEnd = 1235691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator +(BigInteger left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003B68 File Offset: 0x00001D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235716, RefRangeEnd = 1235717, XrefRangeStart = 1235696, XrefRangeEnd = 1235716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator *(BigInteger left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003BC0 File Offset: 0x00001DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235717, XrefRangeEnd = 1235733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator /(BigInteger dividend, BigInteger divisor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dividend));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(divisor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003C18 File Offset: 0x00001E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235752, RefRangeEnd = 1235753, XrefRangeStart = 1235733, XrefRangeEnd = 1235752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator %(BigInteger dividend, BigInteger divisor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dividend));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(divisor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003C70 File Offset: 0x00001E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235757, RefRangeEnd = 1235758, XrefRangeStart = 1235753, XrefRangeEnd = 1235757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(BigInteger left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235762, RefRangeEnd = 1235763, XrefRangeStart = 1235758, XrefRangeEnd = 1235762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BigInteger left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003D30 File Offset: 0x00001F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235767, RefRangeEnd = 1235768, XrefRangeStart = 1235763, XrefRangeEnd = 1235767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(BigInteger left, long right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D84 File Offset: 0x00001F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235772, RefRangeEnd = 1235773, XrefRangeStart = 1235768, XrefRangeEnd = 1235772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(BigInteger left, long right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003DD8 File Offset: 0x00001FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235777, RefRangeEnd = 1235778, XrefRangeStart = 1235773, XrefRangeEnd = 1235777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BigInteger left, long right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003E2C File Offset: 0x0000202C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1235782, RefRangeEnd = 1235788, XrefRangeStart = 1235778, XrefRangeEnd = 1235782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BigInteger left, long right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003E80 File Offset: 0x00002080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235788, XrefRangeEnd = 1235792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(long left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int64_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003ED4 File Offset: 0x000020D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235792, XrefRangeEnd = 1235796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(long left, BigInteger right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int64_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003F28 File Offset: 0x00002128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235796, XrefRangeEnd = 1235803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetPartsForBitManipulation(ref BigInteger x, out Il2CppStructArray<uint> xd, out int xl)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(x);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xl;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GetPartsForBitManipulation_Private_Static_Boolean_byref_BigInteger_byref_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			xd = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003F9C File Offset: 0x0000219C
		[CallerCount(0)]
		public unsafe static int GetDiffLength(Il2CppStructArray<uint> rgu1, Il2CppStructArray<uint> rgu2, int cu)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgu1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgu2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cu;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GetDiffLength_Internal_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002092 File Offset: 0x00000292
		public BigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000209B File Offset: 0x0000029B
		public BigInteger()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00004000 File Offset: 0x00002200
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000020AD File Offset: 0x000002AD
		public unsafe int _sign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr__sign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr__sign)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004028 File Offset: 0x00002228
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000020C8 File Offset: 0x000002C8
		public unsafe Il2CppStructArray<uint> _bits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr__bits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr__bits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00004058 File Offset: 0x00002258
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000020E7 File Offset: 0x000002E7
		public unsafe static BigInteger s_bnMinInt
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_s_bnMinInt, intPtr);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_s_bnMinInt, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00004094 File Offset: 0x00002294
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000020FE File Offset: 0x000002FE
		public unsafe static BigInteger s_bnOneInt
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_s_bnOneInt, intPtr);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_s_bnOneInt, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000040D0 File Offset: 0x000022D0
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002115 File Offset: 0x00000315
		public unsafe static BigInteger s_bnZeroInt
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_s_bnZeroInt, intPtr);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_s_bnZeroInt, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000212C File Offset: 0x0000032C
		public unsafe static BigInteger s_bnMinusOneInt
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_s_bnMinusOneInt, intPtr);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_s_bnMinusOneInt, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004148 File Offset: 0x00002348
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002143 File Offset: 0x00000343
		public unsafe static Il2CppStructArray<byte> s_success
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_s_success, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_s_success, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr__sign;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr__bits;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_s_bnMinInt;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_s_bnOneInt;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_s_bnZeroInt;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_s_bnMinusOneInt;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_s_success;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_Boolean_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_Zero_Public_Static_get_BigInteger_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_MinusOne_Public_Static_get_BigInteger_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZero_Public_get_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_IFormatProvider_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_BigInteger_String_NumberStyles_IFormatProvider_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Int64_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BigInteger_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_Int64_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BigInteger_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_Boolean_Boolean_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_TryWriteBytes_Public_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_TryWriteOrCountBytes_Internal_Boolean_Span_1_Byte_byref_Int32_Boolean_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBytes_Private_Il2CppStructArray_1_Byte_GetBytesMode_Span_1_Byte_Boolean_Boolean_byref_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Private_Static_BigInteger_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Byte_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_SByte_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int16_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt16_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int64_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt64_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_BigInteger_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_BigInteger_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_BigInteger_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_BigInteger_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_BigInteger_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_BigInteger_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_BigInteger_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_BigInteger_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_BigInteger_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_BigInteger_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_BigInteger_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_BigInteger_BigInteger_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_Int64_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_Int64_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_Int64_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_Int64_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int64_BigInteger_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int64_BigInteger_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetPartsForBitManipulation_Private_Static_Boolean_byref_BigInteger_byref_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_GetDiffLength_Internal_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x0200000A RID: 10
		public enum GetBytesMode
		{
			// Token: 0x04000096 RID: 150
			AllocateArray,
			// Token: 0x04000097 RID: 151
			Count,
			// Token: 0x04000098 RID: 152
			Span
		}
	}
}

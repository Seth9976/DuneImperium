using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Math
{
	// Token: 0x0200003E RID: 62
	public class BigInteger : Object
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00011A30 File Offset: 0x0000FC30
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
			Il2CppClassPointerStore<BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math", "BigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger>.NativeClassPtr);
			BigInteger.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "length");
			BigInteger.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "data");
			BigInteger.NativeFieldInfoPtr_smallPrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "smallPrimes");
			BigInteger.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "rng");
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663813);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663814);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663815);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663816);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663817);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663818);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663819);
			BigInteger.NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663820);
			BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663821);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663822);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663823);
			BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663824);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663825);
			BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663826);
			BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663827);
			BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663828);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663829);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663830);
			BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663831);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663832);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663833);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663834);
			BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663835);
			BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663836);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663837);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663838);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663839);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663840);
			BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663841);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663842);
			BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663843);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663844);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663845);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663846);
			BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663847);
			BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663848);
			BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663849);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663850);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663851);
			BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663852);
			BigInteger.NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663853);
			BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663854);
			BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663855);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00011E0C File Offset: 0x0001000C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151672, RefRangeEnd = 1151673, XrefRangeStart = 1151667, XrefRangeEnd = 1151672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger.Sign sign, uint len)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sign;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00011E64 File Offset: 0x00010064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1151682, RefRangeEnd = 1151684, XrefRangeStart = 1151673, XrefRangeEnd = 1151682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger bi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00011EB0 File Offset: 0x000100B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151684, XrefRangeEnd = 1151690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger bi, uint len)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00011F0C File Offset: 0x0001010C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1151700, RefRangeEnd = 1151710, XrefRangeStart = 1151690, XrefRangeEnd = 1151700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(Il2CppStructArray<byte> inData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00011F58 File Offset: 0x00010158
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1151717, RefRangeEnd = 1151738, XrefRangeStart = 1151710, XrefRangeEnd = 1151717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(uint ui)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ui;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00011FA0 File Offset: 0x000101A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151738, XrefRangeEnd = 1151742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00011FE0 File Offset: 0x000101E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151746, RefRangeEnd = 1151747, XrefRangeStart = 1151742, XrefRangeEnd = 1151746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00012020 File Offset: 0x00010220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151753, RefRangeEnd = 1151754, XrefRangeStart = 1151747, XrefRangeEnd = 1151753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00012078 File Offset: 0x00010278
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1151760, RefRangeEnd = 1151770, XrefRangeStart = 1151754, XrefRangeEnd = 1151760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000120D0 File Offset: 0x000102D0
		[CallerCount(0)]
		public unsafe static uint operator %(BigInteger bi, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00012120 File Offset: 0x00010320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151770, XrefRangeEnd = 1151771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00012178 File Offset: 0x00010378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151771, XrefRangeEnd = 1151772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000121D0 File Offset: 0x000103D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1151783, RefRangeEnd = 1151794, XrefRangeStart = 1151772, XrefRangeEnd = 1151783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00012228 File Offset: 0x00010428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151794, XrefRangeEnd = 1151795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001227C File Offset: 0x0001047C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151795, XrefRangeEnd = 1151796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000122D0 File Offset: 0x000104D0
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151796, XrefRangeEnd = 1151809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00012304 File Offset: 0x00010504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151822, RefRangeEnd = 1151823, XrefRangeStart = 1151809, XrefRangeEnd = 1151822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rng);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00012358 File Offset: 0x00010558
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1151840, RefRangeEnd = 1151843, XrefRangeStart = 1151823, XrefRangeEnd = 1151840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GenerateRandom(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00012398 File Offset: 0x00010598
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1151843, RefRangeEnd = 1151859, XrefRangeStart = 1151843, XrefRangeEnd = 1151843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BitCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000123D4 File Offset: 0x000105D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1151859, RefRangeEnd = 1151861, XrefRangeStart = 1151859, XrefRangeEnd = 1151859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestBit(int bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00012420 File Offset: 0x00010620
		[CallerCount(0)]
		public unsafe void SetBit(uint bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00012460 File Offset: 0x00010660
		[CallerCount(0)]
		public unsafe void SetBit(uint bitNum, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000124AC File Offset: 0x000106AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151861, XrefRangeEnd = 1151864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LowestSetBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000124E8 File Offset: 0x000106E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1151873, RefRangeEnd = 1151877, XrefRangeStart = 1151864, XrefRangeEnd = 1151873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00012528 File Offset: 0x00010728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1151877, RefRangeEnd = 1151881, XrefRangeStart = 1151877, XrefRangeEnd = 1151877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BigInteger bi1, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00012578 File Offset: 0x00010778
		[CallerCount(0)]
		public unsafe static bool operator !=(BigInteger bi1, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000125C8 File Offset: 0x000107C8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1151889, RefRangeEnd = 1151905, XrefRangeStart = 1151881, XrefRangeEnd = 1151889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001261C File Offset: 0x0001081C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1151913, RefRangeEnd = 1151933, XrefRangeStart = 1151905, XrefRangeEnd = 1151913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00012670 File Offset: 0x00010870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151933, XrefRangeEnd = 1151934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000126C4 File Offset: 0x000108C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151934, XrefRangeEnd = 1151935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00012718 File Offset: 0x00010918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151935, XrefRangeEnd = 1151936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001276C File Offset: 0x0001096C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151936, XrefRangeEnd = 1151937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000127C0 File Offset: 0x000109C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151937, XrefRangeEnd = 1151940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(uint radix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00012804 File Offset: 0x00010A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1151948, RefRangeEnd = 1151950, XrefRangeStart = 1151940, XrefRangeEnd = 1151948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(uint radix, string characterSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0001285C File Offset: 0x00010A5C
		[CallerCount(0)]
		public unsafe void Normalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00012890 File Offset: 0x00010A90
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000128C4 File Offset: 0x00010AC4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001290C File Offset: 0x00010B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151950, XrefRangeEnd = 1151963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00012950 File Offset: 0x00010B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151963, XrefRangeEnd = 1151972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000129A8 File Offset: 0x00010BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151972, XrefRangeEnd = 1151973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger ModInverse(BigInteger modulus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modulus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000129F8 File Offset: 0x00010BF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1151979, RefRangeEnd = 1151984, XrefRangeStart = 1151973, XrefRangeEnd = 1151979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(n);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00012A5C File Offset: 0x00010C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151984, XrefRangeEnd = 1151989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GeneratePseudoPrime(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00012A9C File Offset: 0x00010C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151989, XrefRangeEnd = 1151990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incr2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000039B7 File Offset: 0x00001BB7
		public BigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00012AD0 File Offset: 0x00010CD0
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000039C0 File Offset: 0x00001BC0
		public unsafe uint length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012AF8 File Offset: 0x00010CF8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000039DB File Offset: 0x00001BDB
		public unsafe Il2CppStructArray<uint> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00012B28 File Offset: 0x00010D28
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000039FA File Offset: 0x00001BFA
		public unsafe static Il2CppStructArray<uint> smallPrimes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_smallPrimes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_smallPrimes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00012B50 File Offset: 0x00010D50
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003A0C File Offset: 0x00001C0C
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_smallPrimes;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_BitCount_Public_Int32_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_LowestSetBit_Public_Int32_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Void_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_Incr2_Public_Void_0;

		// Token: 0x02000060 RID: 96
		public enum Sign
		{
			// Token: 0x040004AF RID: 1199
			Negative = -1,
			// Token: 0x040004B0 RID: 1200
			Zero,
			// Token: 0x040004B1 RID: 1201
			Positive
		}

		// Token: 0x02000061 RID: 97
		public sealed class ModulusRing : Object
		{
			// Token: 0x06000523 RID: 1315 RVA: 0x00016550 File Offset: 0x00014750
			// Note: this type is marked as 'beforefieldinit'.
			static ModulusRing()
			{
				Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "ModulusRing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr);
				BigInteger.ModulusRing.NativeFieldInfoPtr_mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "mod");
				BigInteger.ModulusRing.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "constant");
				BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663857);
				BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663858);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663859);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663860);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663861);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663862);
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x0001661C File Offset: 0x0001481C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1151342, RefRangeEnd = 1151345, XrefRangeStart = 1151325, XrefRangeEnd = 1151342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModulusRing(BigInteger modulus)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(modulus);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00016668 File Offset: 0x00014868
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1151380, RefRangeEnd = 1151381, XrefRangeStart = 1151345, XrefRangeEnd = 1151380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BarrettReduction(BigInteger x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x000166AC File Offset: 0x000148AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151381, XrefRangeEnd = 1151392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Multiply(BigInteger a, BigInteger b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00016710 File Offset: 0x00014910
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1151414, RefRangeEnd = 1151416, XrefRangeStart = 1151392, XrefRangeEnd = 1151414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Difference(BigInteger a, BigInteger b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00016774 File Offset: 0x00014974
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1151422, RefRangeEnd = 1151427, XrefRangeStart = 1151416, XrefRangeEnd = 1151422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Pow(BigInteger a, BigInteger k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(k);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x000167D8 File Offset: 0x000149D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151427, XrefRangeEnd = 1151432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Pow(uint b, BigInteger exp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x000045A5 File Offset: 0x000027A5
			public ModulusRing(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x00016838 File Offset: 0x00014A38
			// (set) Token: 0x0600052C RID: 1324 RVA: 0x000045AE File Offset: 0x000027AE
			public unsafe BigInteger mod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_mod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_mod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x00016868 File Offset: 0x00014A68
			// (set) Token: 0x0600052E RID: 1326 RVA: 0x000045CD File Offset: 0x000027CD
			public unsafe BigInteger constant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_constant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_constant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeFieldInfoPtr_mod;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeFieldInfoPtr_constant;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0;

			// Token: 0x040004B6 RID: 1206
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004B7 RID: 1207
			private static readonly IntPtr NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004B8 RID: 1208
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004B9 RID: 1209
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0;
		}

		// Token: 0x02000062 RID: 98
		public sealed class Kernel : Object
		{
			// Token: 0x0600052F RID: 1327 RVA: 0x00016898 File Offset: 0x00014A98
			// Note: this type is marked as 'beforefieldinit'.
			static Kernel()
			{
				Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "Kernel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr);
				BigInteger.Kernel.NativeMethodInfoPtr_AddSameSign_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663863);
				BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663864);
				BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663865);
				BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663866);
				BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663867);
				BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663868);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663869);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663870);
				BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663871);
				BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663872);
				BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663873);
				BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663874);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663875);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663876);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663877);
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x000169F0 File Offset: 0x00014BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151432, XrefRangeEnd = 1151441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_AddSameSign_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00016A48 File Offset: 0x00014C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151441, XrefRangeEnd = 1151449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(small);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00016AA0 File Offset: 0x00014CA0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1151450, RefRangeEnd = 1151454, XrefRangeStart = 1151449, XrefRangeEnd = 1151450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void MinusEq(BigInteger big, BigInteger small)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(small);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00016AE8 File Offset: 0x00014CE8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1151455, RefRangeEnd = 1151457, XrefRangeStart = 1151454, XrefRangeEnd = 1151455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00016B30 File Offset: 0x00014D30
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1151457, RefRangeEnd = 1151498, XrefRangeStart = 1151457, XrefRangeEnd = 1151457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00016B84 File Offset: 0x00014D84
			[CallerCount(0)]
			public unsafe static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00016BD4 File Offset: 0x00014DD4
			[CallerCount(0)]
			public unsafe static uint DwordMod(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00016C24 File Offset: 0x00014E24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1151519, RefRangeEnd = 1151520, XrefRangeStart = 1151498, XrefRangeEnd = 1151519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<BigInteger> DwordDivMod(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BigInteger>>(intPtr3) : null;
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x00016C78 File Offset: 0x00014E78
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1151547, RefRangeEnd = 1151560, XrefRangeStart = 1151520, XrefRangeEnd = 1151547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<BigInteger> multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BigInteger>>(intPtr3) : null;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00016CD0 File Offset: 0x00014ED0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1151570, RefRangeEnd = 1151573, XrefRangeStart = 1151560, XrefRangeEnd = 1151570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger LeftShift(BigInteger bi, int n)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x00016D24 File Offset: 0x00014F24
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1151583, RefRangeEnd = 1151586, XrefRangeStart = 1151573, XrefRangeEnd = 1151583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger RightShift(BigInteger bi, int n)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x00016D78 File Offset: 0x00014F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151586, XrefRangeEnd = 1151589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Multiply(Il2CppStructArray<uint> x, uint xOffset, uint xLen, Il2CppStructArray<uint> y, uint yOffset, uint yLen, Il2CppStructArray<uint> d, uint dOffset)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x00016E1C File Offset: 0x0001501C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151589, XrefRangeEnd = 1151592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void MultiplyMod2p32pmod(Il2CppStructArray<uint> x, int xOffset, int xLen, Il2CppStructArray<uint> y, int yOffest, int yLen, Il2CppStructArray<uint> d, int dOffset, int mod)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffest;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dOffset;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x00016ECC File Offset: 0x000150CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151592, XrefRangeEnd = 1151595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint modInverse(BigInteger bi, uint modulus)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modulus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x00016F1C File Offset: 0x0001511C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1151661, RefRangeEnd = 1151667, XrefRangeStart = 1151595, XrefRangeEnd = 1151661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modulus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x000045EC File Offset: 0x000027EC
			public Kernel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040004BA RID: 1210
			private static readonly IntPtr NativeMethodInfoPtr_AddSameSign_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004BB RID: 1211
			private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0;

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0;
		}
	}
}

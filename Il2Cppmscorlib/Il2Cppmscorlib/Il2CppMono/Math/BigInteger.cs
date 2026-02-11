using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Math
{
	// Token: 0x02000036 RID: 54
	public class BigInteger : Object
	{
		// Token: 0x06000326 RID: 806 RVA: 0x00031C5C File Offset: 0x0002FE5C
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
			Il2CppClassPointerStore<BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math", "BigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger>.NativeClassPtr);
			BigInteger.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "length");
			BigInteger.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "data");
			BigInteger.NativeFieldInfoPtr_smallPrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "smallPrimes");
			BigInteger.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "rng");
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663740);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663741);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663742);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663743);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663744);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663745);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663746);
			BigInteger.NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663747);
			BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663748);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663749);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663750);
			BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663751);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663752);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663753);
			BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663754);
			BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663755);
			BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663756);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663757);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663758);
			BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663759);
			BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663760);
			BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663761);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663762);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663763);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663764);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663765);
			BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663766);
			BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663767);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663768);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663769);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663770);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663771);
			BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663772);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663773);
			BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663774);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663775);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663776);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663777);
			BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663778);
			BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663779);
			BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663780);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663781);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663782);
			BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663783);
			BigInteger.NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663784);
			BigInteger.NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663785);
			BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663786);
			BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663787);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0003209C File Offset: 0x0003029C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279753, RefRangeEnd = 1279754, XrefRangeStart = 1279748, XrefRangeEnd = 1279753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000328 RID: 808 RVA: 0x000320F4 File Offset: 0x000302F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1279763, RefRangeEnd = 1279765, XrefRangeStart = 1279754, XrefRangeEnd = 1279763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000329 RID: 809 RVA: 0x00032140 File Offset: 0x00030340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279765, XrefRangeEnd = 1279771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032A RID: 810 RVA: 0x0003219C File Offset: 0x0003039C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1279781, RefRangeEnd = 1279804, XrefRangeStart = 1279771, XrefRangeEnd = 1279781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032B RID: 811 RVA: 0x000321E8 File Offset: 0x000303E8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1279811, RefRangeEnd = 1279843, XrefRangeStart = 1279804, XrefRangeEnd = 1279811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032C RID: 812 RVA: 0x00032230 File Offset: 0x00030430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279843, XrefRangeEnd = 1279847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032D RID: 813 RVA: 0x00032270 File Offset: 0x00030470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279851, RefRangeEnd = 1279852, XrefRangeStart = 1279847, XrefRangeEnd = 1279851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032E RID: 814 RVA: 0x000322B0 File Offset: 0x000304B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279858, RefRangeEnd = 1279859, XrefRangeStart = 1279852, XrefRangeEnd = 1279858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600032F RID: 815 RVA: 0x00032308 File Offset: 0x00030508
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1279865, RefRangeEnd = 1279882, XrefRangeStart = 1279859, XrefRangeEnd = 1279865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000330 RID: 816 RVA: 0x00032360 File Offset: 0x00030560
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

		// Token: 0x06000331 RID: 817 RVA: 0x000323B0 File Offset: 0x000305B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279882, XrefRangeEnd = 1279883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000332 RID: 818 RVA: 0x00032408 File Offset: 0x00030608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279883, XrefRangeEnd = 1279884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000333 RID: 819 RVA: 0x00032460 File Offset: 0x00030660
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1279895, RefRangeEnd = 1279910, XrefRangeStart = 1279884, XrefRangeEnd = 1279895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000334 RID: 820 RVA: 0x000324B8 File Offset: 0x000306B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279919, RefRangeEnd = 1279920, XrefRangeStart = 1279910, XrefRangeEnd = 1279919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator *(BigInteger bi, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0003250C File Offset: 0x0003070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279920, XrefRangeEnd = 1279921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000336 RID: 822 RVA: 0x00032560 File Offset: 0x00030760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279921, XrefRangeEnd = 1279922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000325B4 File Offset: 0x000307B4
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1279935, RefRangeEnd = 1279942, XrefRangeStart = 1279922, XrefRangeEnd = 1279935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000338 RID: 824 RVA: 0x000325E8 File Offset: 0x000307E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1279955, RefRangeEnd = 1279960, XrefRangeStart = 1279942, XrefRangeEnd = 1279955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000339 RID: 825 RVA: 0x0003263C File Offset: 0x0003083C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279965, RefRangeEnd = 1279966, XrefRangeStart = 1279960, XrefRangeEnd = 1279965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600033A RID: 826 RVA: 0x0003267C File Offset: 0x0003087C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1279975, RefRangeEnd = 1279977, XrefRangeStart = 1279966, XrefRangeEnd = 1279975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize(RandomNumberGenerator rng)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rng);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000326C0 File Offset: 0x000308C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279977, XrefRangeEnd = 1279982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000326F4 File Offset: 0x000308F4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1151843, RefRangeEnd = 1151859, XrefRangeStart = 1151843, XrefRangeEnd = 1151859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BitCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00032730 File Offset: 0x00030930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279982, RefRangeEnd = 1279983, XrefRangeStart = 1279982, XrefRangeEnd = 1279982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestBit(uint bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0003277C File Offset: 0x0003097C
		[CallerCount(0)]
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

		// Token: 0x0600033F RID: 831 RVA: 0x000327C8 File Offset: 0x000309C8
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

		// Token: 0x06000340 RID: 832 RVA: 0x00032808 File Offset: 0x00030A08
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

		// Token: 0x06000341 RID: 833 RVA: 0x00032854 File Offset: 0x00030A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1279986, RefRangeEnd = 1279988, XrefRangeStart = 1279983, XrefRangeEnd = 1279986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LowestSetBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00032890 File Offset: 0x00030A90
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1279997, RefRangeEnd = 1280008, XrefRangeStart = 1279988, XrefRangeEnd = 1279997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000343 RID: 835 RVA: 0x000328D0 File Offset: 0x00030AD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1151877, RefRangeEnd = 1151881, XrefRangeStart = 1151877, XrefRangeEnd = 1151881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000344 RID: 836 RVA: 0x00032920 File Offset: 0x00030B20
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

		// Token: 0x06000345 RID: 837 RVA: 0x00032970 File Offset: 0x00030B70
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1280016, RefRangeEnd = 1280035, XrefRangeStart = 1280008, XrefRangeEnd = 1280016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000346 RID: 838 RVA: 0x000329C4 File Offset: 0x00030BC4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1280043, RefRangeEnd = 1280070, XrefRangeStart = 1280035, XrefRangeEnd = 1280043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000347 RID: 839 RVA: 0x00032A18 File Offset: 0x00030C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000348 RID: 840 RVA: 0x00032A6C File Offset: 0x00030C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000349 RID: 841 RVA: 0x00032AC0 File Offset: 0x00030CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600034A RID: 842 RVA: 0x00032B14 File Offset: 0x00030D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600034B RID: 843 RVA: 0x00032B68 File Offset: 0x00030D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280070, XrefRangeEnd = 1280073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600034C RID: 844 RVA: 0x00032BAC File Offset: 0x00030DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280081, RefRangeEnd = 1280083, XrefRangeStart = 1280073, XrefRangeEnd = 1280081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600034D RID: 845 RVA: 0x00032C04 File Offset: 0x00030E04
		[CallerCount(0)]
		public unsafe void Normalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00032C38 File Offset: 0x00030E38
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00032C6C File Offset: 0x00030E6C
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

		// Token: 0x06000350 RID: 848 RVA: 0x00032CB4 File Offset: 0x00030EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280083, XrefRangeEnd = 1280086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00032CF8 File Offset: 0x00030EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280086, XrefRangeEnd = 1280095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000352 RID: 850 RVA: 0x00032D50 File Offset: 0x00030F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280095, XrefRangeEnd = 1280096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000353 RID: 851 RVA: 0x00032DA0 File Offset: 0x00030FA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1280102, RefRangeEnd = 1280111, XrefRangeStart = 1280096, XrefRangeEnd = 1280102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000354 RID: 852 RVA: 0x00032E04 File Offset: 0x00031004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280135, RefRangeEnd = 1280137, XrefRangeStart = 1280111, XrefRangeEnd = 1280135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsProbablePrime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00032E40 File Offset: 0x00031040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280137, XrefRangeEnd = 1280142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000356 RID: 854 RVA: 0x00032E80 File Offset: 0x00031080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incr2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003508 File Offset: 0x00001708
		public BigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00032EB4 File Offset: 0x000310B4
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003511 File Offset: 0x00001711
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00032EDC File Offset: 0x000310DC
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000352C File Offset: 0x0000172C
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00032F0C File Offset: 0x0003110C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0000354B File Offset: 0x0000174B
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00032F34 File Offset: 0x00031134
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000355D File Offset: 0x0000175D
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

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_smallPrimes;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_BitCount_Public_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_LowestSetBit_Public_Int32_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Void_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_Incr2_Public_Void_0;

		// Token: 0x02000570 RID: 1392
		public enum Sign
		{
			// Token: 0x04004611 RID: 17937
			Negative = -1,
			// Token: 0x04004612 RID: 17938
			Zero,
			// Token: 0x04004613 RID: 17939
			Positive
		}

		// Token: 0x02000571 RID: 1393
		public sealed class ModulusRing : Object
		{
			// Token: 0x060055E4 RID: 21988 RVA: 0x0018CC94 File Offset: 0x0018AE94
			// Note: this type is marked as 'beforefieldinit'.
			static ModulusRing()
			{
				Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "ModulusRing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr);
				BigInteger.ModulusRing.NativeFieldInfoPtr_mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "mod");
				BigInteger.ModulusRing.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "constant");
				BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663789);
				BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663790);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663791);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663792);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663793);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663794);
			}

			// Token: 0x060055E5 RID: 21989 RVA: 0x0018CD60 File Offset: 0x0018AF60
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1279455, RefRangeEnd = 1279460, XrefRangeStart = 1279438, XrefRangeEnd = 1279455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055E6 RID: 21990 RVA: 0x0018CDAC File Offset: 0x0018AFAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1279495, RefRangeEnd = 1279496, XrefRangeStart = 1279460, XrefRangeEnd = 1279495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055E7 RID: 21991 RVA: 0x0018CDF0 File Offset: 0x0018AFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279496, XrefRangeEnd = 1279507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055E8 RID: 21992 RVA: 0x0018CE54 File Offset: 0x0018B054
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1279529, RefRangeEnd = 1279531, XrefRangeStart = 1279507, XrefRangeEnd = 1279529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055E9 RID: 21993 RVA: 0x0018CEB8 File Offset: 0x0018B0B8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1279537, RefRangeEnd = 1279542, XrefRangeStart = 1279531, XrefRangeEnd = 1279537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055EA RID: 21994 RVA: 0x0018CF1C File Offset: 0x0018B11C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1279547, RefRangeEnd = 1279549, XrefRangeStart = 1279542, XrefRangeEnd = 1279547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055EB RID: 21995 RVA: 0x0001E8A1 File Offset: 0x0001CAA1
			public ModulusRing(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F2 RID: 5618
			// (get) Token: 0x060055EC RID: 21996 RVA: 0x0018CF7C File Offset: 0x0018B17C
			// (set) Token: 0x060055ED RID: 21997 RVA: 0x0001E8AA File Offset: 0x0001CAAA
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

			// Token: 0x170015F3 RID: 5619
			// (get) Token: 0x060055EE RID: 21998 RVA: 0x0018CFAC File Offset: 0x0018B1AC
			// (set) Token: 0x060055EF RID: 21999 RVA: 0x0001E8C9 File Offset: 0x0001CAC9
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

			// Token: 0x04004614 RID: 17940
			private static readonly IntPtr NativeFieldInfoPtr_mod;

			// Token: 0x04004615 RID: 17941
			private static readonly IntPtr NativeFieldInfoPtr_constant;

			// Token: 0x04004616 RID: 17942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

			// Token: 0x04004617 RID: 17943
			private static readonly IntPtr NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0;

			// Token: 0x04004618 RID: 17944
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04004619 RID: 17945
			private static readonly IntPtr NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x0400461A RID: 17946
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x0400461B RID: 17947
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0;
		}

		// Token: 0x02000572 RID: 1394
		public sealed class Kernel : Object
		{
			// Token: 0x060055F0 RID: 22000 RVA: 0x0018CFDC File Offset: 0x0018B1DC
			// Note: this type is marked as 'beforefieldinit'.
			static Kernel()
			{
				Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "Kernel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr);
				BigInteger.Kernel.NativeMethodInfoPtr_AddSameSign_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663795);
				BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663796);
				BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663797);
				BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663798);
				BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663799);
				BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663800);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663801);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663802);
				BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663803);
				BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663804);
				BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663805);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663806);
				BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663807);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663808);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663809);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663810);
			}

			// Token: 0x060055F1 RID: 22001 RVA: 0x0018D148 File Offset: 0x0018B348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279549, XrefRangeEnd = 1279558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F2 RID: 22002 RVA: 0x0018D1A0 File Offset: 0x0018B3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279558, XrefRangeEnd = 1279566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F3 RID: 22003 RVA: 0x0018D1F8 File Offset: 0x0018B3F8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1151450, RefRangeEnd = 1151454, XrefRangeStart = 1151450, XrefRangeEnd = 1151454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F4 RID: 22004 RVA: 0x0018D240 File Offset: 0x0018B440
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1151455, RefRangeEnd = 1151457, XrefRangeStart = 1151455, XrefRangeEnd = 1151457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F5 RID: 22005 RVA: 0x0018D288 File Offset: 0x0018B488
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1151457, RefRangeEnd = 1151498, XrefRangeStart = 1151457, XrefRangeEnd = 1151498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F6 RID: 22006 RVA: 0x0018D2DC File Offset: 0x0018B4DC
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

			// Token: 0x060055F7 RID: 22007 RVA: 0x0018D32C File Offset: 0x0018B52C
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

			// Token: 0x060055F8 RID: 22008 RVA: 0x0018D37C File Offset: 0x0018B57C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1279587, RefRangeEnd = 1279588, XrefRangeStart = 1279566, XrefRangeEnd = 1279587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055F9 RID: 22009 RVA: 0x0018D3D0 File Offset: 0x0018B5D0
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1279615, RefRangeEnd = 1279637, XrefRangeStart = 1279588, XrefRangeEnd = 1279615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055FA RID: 22010 RVA: 0x0018D428 File Offset: 0x0018B628
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1279647, RefRangeEnd = 1279650, XrefRangeStart = 1279637, XrefRangeEnd = 1279647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055FB RID: 22011 RVA: 0x0018D47C File Offset: 0x0018B67C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1279660, RefRangeEnd = 1279664, XrefRangeStart = 1279650, XrefRangeEnd = 1279660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055FC RID: 22012 RVA: 0x0018D4D0 File Offset: 0x0018B6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279664, XrefRangeEnd = 1279672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger MultiplyByDword(BigInteger n, uint f)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x060055FD RID: 22013 RVA: 0x0018D524 File Offset: 0x0018B724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055FE RID: 22014 RVA: 0x0018D5C8 File Offset: 0x0018B7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x060055FF RID: 22015 RVA: 0x0018D678 File Offset: 0x0018B878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279672, XrefRangeEnd = 1279675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06005600 RID: 22016 RVA: 0x0018D6C8 File Offset: 0x0018B8C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1279741, RefRangeEnd = 1279748, XrefRangeStart = 1279675, XrefRangeEnd = 1279741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06005601 RID: 22017 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
			public Kernel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400461C RID: 17948
			private static readonly IntPtr NativeMethodInfoPtr_AddSameSign_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x0400461D RID: 17949
			private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x0400461E RID: 17950
			private static readonly IntPtr NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x0400461F RID: 17951
			private static readonly IntPtr NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x04004620 RID: 17952
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0;

			// Token: 0x04004621 RID: 17953
			private static readonly IntPtr NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x04004622 RID: 17954
			private static readonly IntPtr NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x04004623 RID: 17955
			private static readonly IntPtr NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0;

			// Token: 0x04004624 RID: 17956
			private static readonly IntPtr NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04004625 RID: 17957
			private static readonly IntPtr NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x04004626 RID: 17958
			private static readonly IntPtr NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x04004627 RID: 17959
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0;

			// Token: 0x04004628 RID: 17960
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

			// Token: 0x04004629 RID: 17961
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0;

			// Token: 0x0400462A RID: 17962
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x0400462B RID: 17963
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0;
		}
	}
}

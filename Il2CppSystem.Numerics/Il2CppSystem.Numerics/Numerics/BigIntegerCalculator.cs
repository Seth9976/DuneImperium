using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000004 RID: 4
	public static class BigIntegerCalculator : Object
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00004170 File Offset: 0x00002370
		// Note: this type is marked as 'beforefieldinit'.
		static BigIntegerCalculator()
		{
			Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "BigIntegerCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr);
			BigIntegerCalculator.NativeFieldInfoPtr_ReducerThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "ReducerThreshold");
			BigIntegerCalculator.NativeFieldInfoPtr_SquareThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "SquareThreshold");
			BigIntegerCalculator.NativeFieldInfoPtr_AllocationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "AllocationThreshold");
			BigIntegerCalculator.NativeFieldInfoPtr_MultiplyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, "MultiplyThreshold");
			BigIntegerCalculator.NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663369);
			BigIntegerCalculator.NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663370);
			BigIntegerCalculator.NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663371);
			BigIntegerCalculator.NativeMethodInfoPtr_AddSelf_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663372);
			BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663373);
			BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663374);
			BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663375);
			BigIntegerCalculator.NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663376);
			BigIntegerCalculator.NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663377);
			BigIntegerCalculator.NativeMethodInfoPtr_Remainder_Public_Static_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663378);
			BigIntegerCalculator.NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663379);
			BigIntegerCalculator.NativeMethodInfoPtr_Remainder_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663380);
			BigIntegerCalculator.NativeMethodInfoPtr_Divide_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663381);
			BigIntegerCalculator.NativeMethodInfoPtr_AddDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663382);
			BigIntegerCalculator.NativeMethodInfoPtr_SubtractDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663383);
			BigIntegerCalculator.NativeMethodInfoPtr_DivideGuessTooBig_Private_Static_Boolean_UInt64_UInt64_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663384);
			BigIntegerCalculator.NativeMethodInfoPtr_CreateCopy_Private_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663385);
			BigIntegerCalculator.NativeMethodInfoPtr_LeadingZeros_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663386);
			BigIntegerCalculator.NativeMethodInfoPtr_Square_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663387);
			BigIntegerCalculator.NativeMethodInfoPtr_Square_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663388);
			BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663389);
			BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663390);
			BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663391);
			BigIntegerCalculator.NativeMethodInfoPtr_SubtractCore_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerCalculator>.NativeClassPtr, 100663392);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000043D0 File Offset: 0x000025D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1235807, RefRangeEnd = 1235812, XrefRangeStart = 1235803, XrefRangeEnd = 1235807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Add(Il2CppStructArray<uint> left, uint right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004424 File Offset: 0x00002624
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1235821, RefRangeEnd = 1235827, XrefRangeStart = 1235812, XrefRangeEnd = 1235821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Add(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000447C File Offset: 0x0000267C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235827, RefRangeEnd = 1235834, XrefRangeStart = 1235827, XrefRangeEnd = 1235827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitsLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000044F4 File Offset: 0x000026F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235834, RefRangeEnd = 1235836, XrefRangeStart = 1235834, XrefRangeEnd = 1235834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSelf(uint* left, int leftLength, uint* right, int rightLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_AddSelf_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004550 File Offset: 0x00002750
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1235840, RefRangeEnd = 1235846, XrefRangeStart = 1235836, XrefRangeEnd = 1235840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Subtract(Il2CppStructArray<uint> left, uint right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000045A4 File Offset: 0x000027A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1235855, RefRangeEnd = 1235861, XrefRangeStart = 1235846, XrefRangeEnd = 1235855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Subtract(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000045FC File Offset: 0x000027FC
		[CallerCount(0)]
		public unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitsLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004674 File Offset: 0x00002874
		[CallerCount(0)]
		public unsafe static int Compare(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000046C8 File Offset: 0x000028C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235861, XrefRangeEnd = 1235864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Divide(Il2CppStructArray<uint> left, uint right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000471C File Offset: 0x0000291C
		[CallerCount(0)]
		public unsafe static uint Remainder(Il2CppStructArray<uint> left, uint right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Remainder_Public_Static_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000476C File Offset: 0x0000296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235864, XrefRangeEnd = 1235875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Divide(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000047C4 File Offset: 0x000029C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235875, XrefRangeEnd = 1235883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Remainder(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Remainder_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000481C File Offset: 0x00002A1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1235900, RefRangeEnd = 1235904, XrefRangeStart = 1235883, XrefRangeEnd = 1235900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitsLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Divide_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004894 File Offset: 0x00002A94
		[CallerCount(0)]
		public unsafe static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_AddDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000048FC File Offset: 0x00002AFC
		[CallerCount(0)]
		public unsafe static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_SubtractDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004970 File Offset: 0x00002B70
		[CallerCount(0)]
		public unsafe static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valHi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valLo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref divHi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref divLo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_DivideGuessTooBig_Private_Static_Boolean_UInt64_UInt64_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000049E8 File Offset: 0x00002BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235904, XrefRangeEnd = 1235908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> CreateCopy(Il2CppStructArray<uint> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_CreateCopy_Private_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004A2C File Offset: 0x00002C2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235908, RefRangeEnd = 1235911, XrefRangeStart = 1235908, XrefRangeEnd = 1235908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeadingZeros(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_LeadingZeros_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004A6C File Offset: 0x00002C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235911, XrefRangeEnd = 1235920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Square(Il2CppStructArray<uint> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Square_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004AB0 File Offset: 0x00002CB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1235955, RefRangeEnd = 1235961, XrefRangeStart = 1235920, XrefRangeEnd = 1235955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Square(uint* value, int valueLength, uint* bits, int bitsLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitsLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Square_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004B0C File Offset: 0x00002D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235961, XrefRangeEnd = 1235965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Multiply(Il2CppStructArray<uint> left, uint right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004B60 File Offset: 0x00002D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235975, RefRangeEnd = 1235976, XrefRangeStart = 1235965, XrefRangeEnd = 1235975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<uint> Multiply(Il2CppStructArray<uint> left, Il2CppStructArray<uint> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004BB8 File Offset: 0x00002DB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1236019, RefRangeEnd = 1236024, XrefRangeStart = 1235976, XrefRangeEnd = 1236019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitsLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_Multiply_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004C30 File Offset: 0x00002E30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1236024, RefRangeEnd = 1236028, XrefRangeStart = 1236024, XrefRangeEnd = 1236024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = right;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = core;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coreLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigIntegerCalculator.NativeMethodInfoPtr_SubtractCore_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002155 File Offset: 0x00000355
		public BigIntegerCalculator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004CA8 File Offset: 0x00002EA8
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000215E File Offset: 0x0000035E
		public unsafe static int ReducerThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BigIntegerCalculator.NativeFieldInfoPtr_ReducerThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigIntegerCalculator.NativeFieldInfoPtr_ReducerThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004CC4 File Offset: 0x00002EC4
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000216C File Offset: 0x0000036C
		public unsafe static int SquareThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BigIntegerCalculator.NativeFieldInfoPtr_SquareThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigIntegerCalculator.NativeFieldInfoPtr_SquareThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004CE0 File Offset: 0x00002EE0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000217A File Offset: 0x0000037A
		public unsafe static int AllocationThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BigIntegerCalculator.NativeFieldInfoPtr_AllocationThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigIntegerCalculator.NativeFieldInfoPtr_AllocationThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004CFC File Offset: 0x00002EFC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe static int MultiplyThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BigIntegerCalculator.NativeFieldInfoPtr_MultiplyThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigIntegerCalculator.NativeFieldInfoPtr_MultiplyThreshold, (void*)(&value));
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_ReducerThreshold;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_SquareThreshold;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_AllocationThreshold;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_MultiplyThreshold;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_AddSelf_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Remainder_Public_Static_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Remainder_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_AddDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_SubtractDivisor_Private_Static_UInt32_ptr_UInt32_Int32_ptr_UInt32_Int32_UInt64_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_DivideGuessTooBig_Private_Static_Boolean_UInt64_UInt64_UInt32_UInt32_UInt32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Private_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_LeadingZeros_Private_Static_Int32_UInt32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Square_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Square_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_SubtractCore_Private_Static_Void_ptr_UInt32_Int32_ptr_UInt32_Int32_ptr_UInt32_Int32_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	[StructLayout(2)]
	public struct OptionalUInt32
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x0002B874 File Offset: 0x00029A74
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalUInt32()
		{
			Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalUInt32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr);
			OptionalUInt32.NativeFieldInfoPtr_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, "hasValue");
			OptionalUInt32.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, "value");
			OptionalUInt32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664639);
			OptionalUInt32.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664640);
			OptionalUInt32.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664641);
			OptionalUInt32.NativeMethodInfoPtr_get_Value_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664642);
			OptionalUInt32.NativeMethodInfoPtr_set_Value_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664643);
			OptionalUInt32.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664644);
			OptionalUInt32.NativeMethodInfoPtr_GetValueOrDefault_Public_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664645);
			OptionalUInt32.NativeMethodInfoPtr_GetValueOrZero_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664646);
			OptionalUInt32.NativeMethodInfoPtr_SetValue_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664647);
			OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664648);
			OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664649);
			OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664650);
			OptionalUInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664651);
			OptionalUInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664652);
			OptionalUInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664653);
			OptionalUInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664654);
			OptionalUInt32.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664655);
			OptionalUInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664656);
			OptionalUInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664657);
			OptionalUInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664658);
			OptionalUInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, 100664659);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002BA70 File Offset: 0x00029C70
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalUInt32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002BAA4 File Offset: 0x00029CA4
		public unsafe bool HasValue
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		public unsafe bool HasNoValue
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002BB04 File Offset: 0x00029D04
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0002BB34 File Offset: 0x00029D34
		public unsafe uint Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 790401, RefRangeEnd = 790402, XrefRangeStart = 790401, XrefRangeEnd = 790401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_get_Value_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2754)]
			[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_set_Value_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002BB68 File Offset: 0x00029D68
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002BB90 File Offset: 0x00029D90
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 790326, RefRangeEnd = 790366, XrefRangeStart = 790326, XrefRangeEnd = 790366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetValueOrDefault(uint defaultValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_GetValueOrDefault_Public_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		[CallerCount(0)]
		public unsafe uint GetValueOrZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_GetValueOrZero_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002BC00 File Offset: 0x00029E00
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_SetValue_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002BC34 File Offset: 0x00029E34
		[CallerCount(0)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002BC78 File Offset: 0x00029E78
		[CallerCount(0)]
		public unsafe bool Equals(OptionalUInt32 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002BCB8 File Offset: 0x00029EB8
		[CallerCount(0)]
		public unsafe bool Equals(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_Equals_Public_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalUInt32 a, OptionalUInt32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002BD44 File Offset: 0x00029F44
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalUInt32 a, OptionalUInt32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002BD90 File Offset: 0x00029F90
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalUInt32 a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0002BDDC File Offset: 0x00029FDC
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalUInt32 a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002BE28 File Offset: 0x0002A028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002BE74 File Offset: 0x0002A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790402, XrefRangeEnd = 790407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790407, XrefRangeEnd = 790414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002BED0 File Offset: 0x0002A0D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 790378, RefRangeEnd = 790387, XrefRangeStart = 790378, XrefRangeEnd = 790387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator OptionalUInt32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002BF10 File Offset: 0x0002A110
		[CallerCount(0)]
		public unsafe static explicit operator uint(OptionalUInt32 optional)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optional;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_OptionalUInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00005D6F File Offset: 0x00003F6F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalUInt32>.NativeClassPtr, ref this));
		}

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_hasValue;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_UInt32_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_UInt32_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_UInt32_UInt32_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrZero_Public_UInt32_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_UInt32_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt32_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_UInt32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_OptionalUInt32_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt32_UInt32_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt32_UInt32_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt32_UInt32_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_OptionalUInt32_0;

		// Token: 0x04000971 RID: 2417
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool hasValue;

		// Token: 0x04000972 RID: 2418
		[FieldOffset(4)]
		public uint value;
	}
}

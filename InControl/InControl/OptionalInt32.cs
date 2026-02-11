using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	[StructLayout(2)]
	public struct OptionalInt32
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x0002AABC File Offset: 0x00028CBC
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalInt32()
		{
			Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalInt32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr);
			OptionalInt32.NativeFieldInfoPtr_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, "hasValue");
			OptionalInt32.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, "value");
			OptionalInt32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664597);
			OptionalInt32.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664598);
			OptionalInt32.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664599);
			OptionalInt32.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664600);
			OptionalInt32.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664601);
			OptionalInt32.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664602);
			OptionalInt32.NativeMethodInfoPtr_GetValueOrDefault_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664603);
			OptionalInt32.NativeMethodInfoPtr_GetValueOrZero_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664604);
			OptionalInt32.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664605);
			OptionalInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664606);
			OptionalInt32.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664607);
			OptionalInt32.NativeMethodInfoPtr_Equals_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664608);
			OptionalInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664609);
			OptionalInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664610);
			OptionalInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664611);
			OptionalInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664612);
			OptionalInt32.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664613);
			OptionalInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664614);
			OptionalInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664615);
			OptionalInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664616);
			OptionalInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_OptionalInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, 100664617);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002ACB8 File Offset: 0x00028EB8
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 787572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0002ACEC File Offset: 0x00028EEC
		public unsafe bool HasValue
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002AD1C File Offset: 0x00028F1C
		public unsafe bool HasNoValue
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0002AD4C File Offset: 0x00028F4C
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0002AD7C File Offset: 0x00028F7C
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002ADD8 File Offset: 0x00028FD8
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 790326, RefRangeEnd = 790366, XrefRangeStart = 790326, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetValueOrDefault(int defaultValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_GetValueOrDefault_Public_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002AE18 File Offset: 0x00029018
		[CallerCount(0)]
		public unsafe int GetValueOrZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_GetValueOrZero_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002AE48 File Offset: 0x00029048
		[CallerCount(2754)]
		[CachedScanResults(RefRangeStart = 787572, RefRangeEnd = 790326, XrefRangeStart = 787572, XrefRangeEnd = 790326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002AE7C File Offset: 0x0002907C
		[CallerCount(0)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002AEC0 File Offset: 0x000290C0
		[CallerCount(0)]
		public unsafe bool Equals(OptionalInt32 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002AF00 File Offset: 0x00029100
		[CallerCount(0)]
		public unsafe bool Equals(int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_Equals_Public_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002AF40 File Offset: 0x00029140
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalInt32 a, OptionalInt32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002AF8C File Offset: 0x0002918C
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalInt32 a, OptionalInt32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalInt32 a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002B024 File Offset: 0x00029224
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalInt32 a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002B070 File Offset: 0x00029270
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002B0BC File Offset: 0x000292BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790366, XrefRangeEnd = 790371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002B0EC File Offset: 0x000292EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790371, XrefRangeEnd = 790378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002B118 File Offset: 0x00029318
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 790378, RefRangeEnd = 790387, XrefRangeStart = 790378, XrefRangeEnd = 790378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator OptionalInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002B158 File Offset: 0x00029358
		[CallerCount(0)]
		public unsafe static explicit operator int(OptionalInt32 optional)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optional;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalInt32.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_OptionalInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00005D4B File Offset: 0x00003F4B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalInt32>.NativeClassPtr, ref this));
		}

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_hasValue;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_Int32_Int32_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrZero_Public_Int32_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_OptionalInt32_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Int32_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_OptionalInt32_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalInt32_Int32_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalInt32_Int32_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalInt32_Int32_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_OptionalInt32_0;

		// Token: 0x0400093F RID: 2367
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool hasValue;

		// Token: 0x04000940 RID: 2368
		[FieldOffset(4)]
		public int value;
	}
}

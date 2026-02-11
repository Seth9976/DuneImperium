using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	[StructLayout(2)]
	public struct OptionalUInt16
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x0002B198 File Offset: 0x00029398
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalUInt16()
		{
			Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalUInt16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr);
			OptionalUInt16.NativeFieldInfoPtr_hasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, "hasValue");
			OptionalUInt16.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, "value");
			OptionalUInt16.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664618);
			OptionalUInt16.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664619);
			OptionalUInt16.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664620);
			OptionalUInt16.NativeMethodInfoPtr_get_Value_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664621);
			OptionalUInt16.NativeMethodInfoPtr_set_Value_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664622);
			OptionalUInt16.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664623);
			OptionalUInt16.NativeMethodInfoPtr_GetValueOrDefault_Public_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664624);
			OptionalUInt16.NativeMethodInfoPtr_GetValueOrZero_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664625);
			OptionalUInt16.NativeMethodInfoPtr_SetValue_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664626);
			OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664627);
			OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664628);
			OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664629);
			OptionalUInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664630);
			OptionalUInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664631);
			OptionalUInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664632);
			OptionalUInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664633);
			OptionalUInt16.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664634);
			OptionalUInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664635);
			OptionalUInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664636);
			OptionalUInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664637);
			OptionalUInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, 100664638);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002B394 File Offset: 0x00029594
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalUInt16(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002B3C8 File Offset: 0x000295C8
		public unsafe bool HasValue
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002B3F8 File Offset: 0x000295F8
		public unsafe bool HasNoValue
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002B428 File Offset: 0x00029628
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0002B458 File Offset: 0x00029658
		public unsafe ushort Value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 790387, RefRangeEnd = 790389, XrefRangeStart = 790387, XrefRangeEnd = 790387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_get_Value_Public_get_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_set_Value_Public_set_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002B48C File Offset: 0x0002968C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002B4B4 File Offset: 0x000296B4
		[CallerCount(0)]
		public unsafe ushort GetValueOrDefault(ushort defaultValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_GetValueOrDefault_Public_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002B4F4 File Offset: 0x000296F4
		[CallerCount(0)]
		public unsafe ushort GetValueOrZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_GetValueOrZero_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002B524 File Offset: 0x00029724
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 786838, RefRangeEnd = 786847, XrefRangeStart = 786838, XrefRangeEnd = 786847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_SetValue_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002B558 File Offset: 0x00029758
		[CallerCount(0)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002B59C File Offset: 0x0002979C
		[CallerCount(0)]
		public unsafe bool Equals(OptionalUInt16 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002B5DC File Offset: 0x000297DC
		[CallerCount(0)]
		public unsafe bool Equals(ushort other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_Equals_Public_Boolean_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002B61C File Offset: 0x0002981C
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalUInt16 a, OptionalUInt16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002B668 File Offset: 0x00029868
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalUInt16 a, OptionalUInt16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002B6B4 File Offset: 0x000298B4
		[CallerCount(0)]
		public unsafe static bool operator ==(OptionalUInt16 a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002B700 File Offset: 0x00029900
		[CallerCount(0)]
		public unsafe static bool operator !=(OptionalUInt16 a, ushort b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002B74C File Offset: 0x0002994C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002B798 File Offset: 0x00029998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790389, XrefRangeEnd = 790394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002B7C8 File Offset: 0x000299C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790394, XrefRangeEnd = 790401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002B7F4 File Offset: 0x000299F4
		[CallerCount(691)]
		[CachedScanResults(RefRangeStart = 786858, RefRangeEnd = 787549, XrefRangeStart = 786858, XrefRangeEnd = 787549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator OptionalUInt16(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002B834 File Offset: 0x00029A34
		[CallerCount(0)]
		public unsafe static explicit operator ushort(OptionalUInt16 optional)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref optional;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalUInt16.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_OptionalUInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00005D5D File Offset: 0x00003F5D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionalUInt16>.NativeClassPtr, ref this));
		}

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_hasValue;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNoValue_Public_get_Boolean_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_UInt16_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_UInt16_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_UInt16_UInt16_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrZero_Public_UInt16_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_UInt16_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_OptionalUInt16_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_UInt16_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_OptionalUInt16_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_OptionalUInt16_UInt16_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_OptionalUInt16_UInt16_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_OptionalUInt16_UInt16_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_OptionalUInt16_0;

		// Token: 0x04000958 RID: 2392
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool hasValue;

		// Token: 0x04000959 RID: 2393
		[FieldOffset(2)]
		public ushort value;
	}
}

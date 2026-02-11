using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	[StructLayout(2)]
	public struct VersionInfo
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x0002DA30 File Offset: 0x0002BC30
		// Note: this type is marked as 'beforefieldinit'.
		static VersionInfo()
		{
			Il2CppClassPointerStore<VersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "VersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr);
			VersionInfo.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "major");
			VersionInfo.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "minor");
			VersionInfo.NativeFieldInfoPtr_patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "patch");
			VersionInfo.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "build");
			VersionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664732);
			VersionInfo.NativeMethodInfoPtr_InControlVersion_Public_Static_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664733);
			VersionInfo.NativeMethodInfoPtr_UnityVersion_Public_Static_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664734);
			VersionInfo.NativeMethodInfoPtr_get_Min_Public_Static_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664735);
			VersionInfo.NativeMethodInfoPtr_get_Max_Public_Static_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664736);
			VersionInfo.NativeMethodInfoPtr_get_Next_Public_get_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664737);
			VersionInfo.NativeMethodInfoPtr_get_Build_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664738);
			VersionInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664739);
			VersionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664740);
			VersionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664741);
			VersionInfo.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664742);
			VersionInfo.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664743);
			VersionInfo.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664744);
			VersionInfo.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_VersionInfo_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664745);
			VersionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664746);
			VersionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664747);
			VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664748);
			VersionInfo.NativeMethodInfoPtr_ToShortString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100664749);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002DC18 File Offset: 0x0002BE18
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo(int major, int minor, int patch, int build)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref patch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002DC74 File Offset: 0x0002BE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791042, RefRangeEnd = 791043, XrefRangeStart = 791042, XrefRangeEnd = 791042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VersionInfo InControlVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_InControlVersion_Public_Static_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 791068, RefRangeEnd = 791070, XrefRangeStart = 791043, XrefRangeEnd = 791068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VersionInfo UnityVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_UnityVersion_Public_Static_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002DCD4 File Offset: 0x0002BED4
		public unsafe static VersionInfo Min
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 791070, RefRangeEnd = 791071, XrefRangeStart = 791070, XrefRangeEnd = 791070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Min_Public_Static_get_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002DD04 File Offset: 0x0002BF04
		public unsafe static VersionInfo Max
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 791071, RefRangeEnd = 791072, XrefRangeStart = 791071, XrefRangeEnd = 791071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Max_Public_Static_get_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0002DD34 File Offset: 0x0002BF34
		public unsafe VersionInfo Next
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Next_Public_get_VersionInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002DD64 File Offset: 0x0002BF64
		public unsafe int Build
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Build_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002DD94 File Offset: 0x0002BF94
		[CallerCount(0)]
		public unsafe int CompareTo(VersionInfo other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VersionInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		[CallerCount(0)]
		public unsafe static bool operator ==(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002DE20 File Offset: 0x0002C020
		[CallerCount(0)]
		public unsafe static bool operator !=(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002DE6C File Offset: 0x0002C06C
		[CallerCount(0)]
		public unsafe static bool operator <=(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		[CallerCount(0)]
		public unsafe static bool operator >=(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0002DF04 File Offset: 0x0002C104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791072, RefRangeEnd = 791073, XrefRangeStart = 791072, XrefRangeEnd = 791072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002DF50 File Offset: 0x0002C150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791073, RefRangeEnd = 791074, XrefRangeStart = 791073, XrefRangeEnd = 791073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(VersionInfo a, VersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_VersionInfo_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002DF9C File Offset: 0x0002C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791074, XrefRangeEnd = 791077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791077, XrefRangeEnd = 791081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002E010 File Offset: 0x0002C210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791105, RefRangeEnd = 791106, XrefRangeStart = 791081, XrefRangeEnd = 791105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0002E03C File Offset: 0x0002C23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791106, XrefRangeEnd = 791130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToShortString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_ToShortString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00005E97 File Offset: 0x00004097
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_patch;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_InControlVersion_Public_Static_VersionInfo_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_UnityVersion_Public_Static_VersionInfo_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_Static_get_VersionInfo_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_Static_get_VersionInfo_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_VersionInfo_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_get_Build_Public_get_Int32_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VersionInfo_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_VersionInfo_VersionInfo_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_ToShortString_Public_String_0;

		// Token: 0x040009D4 RID: 2516
		[FieldOffset(0)]
		public int major;

		// Token: 0x040009D5 RID: 2517
		[FieldOffset(4)]
		public int minor;

		// Token: 0x040009D6 RID: 2518
		[FieldOffset(8)]
		public int patch;

		// Token: 0x040009D7 RID: 2519
		[FieldOffset(12)]
		public int build;
	}
}

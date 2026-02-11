using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000087 RID: 135
	public sealed class RegexPrefix : ValueType
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00042D58 File Offset: 0x00040F58
		// Note: this type is marked as 'beforefieldinit'.
		static RegexPrefix()
		{
			Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexPrefix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr);
			RegexPrefix.NativeFieldInfoPtr__CaseInsensitive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<CaseInsensitive>k__BackingField");
			RegexPrefix.NativeFieldInfoPtr__Empty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<Empty>k__BackingField");
			RegexPrefix.NativeFieldInfoPtr__Prefix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<Prefix>k__BackingField");
			RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664852);
			RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664853);
			RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664854);
			RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664855);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00042E14 File Offset: 0x00041014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441991, RefRangeEnd = 441993, XrefRangeStart = 441990, XrefRangeEnd = 441991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexPrefix(string prefix, bool ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ci;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00042E74 File Offset: 0x00041074
		public unsafe bool CaseInsensitive
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 441993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00042EB8 File Offset: 0x000410B8
		public unsafe static RegexPrefix Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442038, XrefRangeEnd = 442042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RegexPrefix(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00042EE4 File Offset: 0x000410E4
		public unsafe string Prefix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00005657 File Offset: 0x00003857
		public RegexPrefix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00005660 File Offset: 0x00003860
		public RegexPrefix()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00042F20 File Offset: 0x00041120
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00005672 File Offset: 0x00003872
		public unsafe bool _CaseInsensitive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__CaseInsensitive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__CaseInsensitive_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00042F48 File Offset: 0x00041148
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0000568D File Offset: 0x0000388D
		public unsafe static RegexPrefix _Empty_k__BackingField
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(RegexPrefix.NativeFieldInfoPtr__Empty_k__BackingField, intPtr);
				return new RegexPrefix(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexPrefix.NativeFieldInfoPtr__Empty_k__BackingField, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00042F84 File Offset: 0x00041184
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000056A4 File Offset: 0x000038A4
		public unsafe string _Prefix_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__Prefix_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__Prefix_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr__CaseInsensitive_k__BackingField;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr__Empty_k__BackingField;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr__Prefix_k__BackingField;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;
	}
}

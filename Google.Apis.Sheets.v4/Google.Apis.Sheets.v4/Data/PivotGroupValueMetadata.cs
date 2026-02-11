using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000093 RID: 147
	public class PivotGroupValueMetadata : Object
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00035448 File Offset: 0x00033648
		// Note: this type is marked as 'beforefieldinit'.
		static PivotGroupValueMetadata()
		{
			Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "PivotGroupValueMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr);
			PivotGroupValueMetadata.NativeFieldInfoPtr__Collapsed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, "<Collapsed>k__BackingField");
			PivotGroupValueMetadata.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, "<Value>k__BackingField");
			PivotGroupValueMetadata.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, "<ETag>k__BackingField");
			PivotGroupValueMetadata.NativeMethodInfoPtr_get_Collapsed_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664869);
			PivotGroupValueMetadata.NativeMethodInfoPtr_set_Collapsed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664870);
			PivotGroupValueMetadata.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664871);
			PivotGroupValueMetadata.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664872);
			PivotGroupValueMetadata.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664873);
			PivotGroupValueMetadata.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664874);
			PivotGroupValueMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr, 100664875);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00035540 File Offset: 0x00033740
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00035584 File Offset: 0x00033784
		public unsafe virtual Nullable<bool> Collapsed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_get_Collapsed_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_set_Collapsed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000355D8 File Offset: 0x000337D8
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00035624 File Offset: 0x00033824
		public unsafe virtual ExtendedValue Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00035674 File Offset: 0x00033874
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000356B8 File Offset: 0x000338B8
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotGroupValueMetadata.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00035708 File Offset: 0x00033908
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotGroupValueMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotGroupValueMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotGroupValueMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00007595 File Offset: 0x00005795
		public PivotGroupValueMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00035744 File Offset: 0x00033944
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0000759E File Offset: 0x0000579E
		public Nullable<bool> _Collapsed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__Collapsed_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__Collapsed_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00035774 File Offset: 0x00033974
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000075CC File Offset: 0x000057CC
		public unsafe ExtendedValue _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000357A4 File Offset: 0x000339A4
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000075EB File Offset: 0x000057EB
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotGroupValueMetadata.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeFieldInfoPtr__Collapsed_k__BackingField;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_Collapsed_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_set_Collapsed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_ExtendedValue_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_ExtendedValue_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

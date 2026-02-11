using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000AA RID: 170
	public class SpreadsheetTheme : Object
	{
		// Token: 0x06000E81 RID: 3713 RVA: 0x00042B0C File Offset: 0x00040D0C
		// Note: this type is marked as 'beforefieldinit'.
		static SpreadsheetTheme()
		{
			Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "SpreadsheetTheme");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr);
			SpreadsheetTheme.NativeFieldInfoPtr__PrimaryFontFamily_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, "<PrimaryFontFamily>k__BackingField");
			SpreadsheetTheme.NativeFieldInfoPtr__ThemeColors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, "<ThemeColors>k__BackingField");
			SpreadsheetTheme.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, "<ETag>k__BackingField");
			SpreadsheetTheme.NativeMethodInfoPtr_get_PrimaryFontFamily_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665292);
			SpreadsheetTheme.NativeMethodInfoPtr_set_PrimaryFontFamily_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665293);
			SpreadsheetTheme.NativeMethodInfoPtr_get_ThemeColors_Public_Virtual_New_get_IList_1_ThemeColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665294);
			SpreadsheetTheme.NativeMethodInfoPtr_set_ThemeColors_Public_Virtual_New_set_Void_IList_1_ThemeColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665295);
			SpreadsheetTheme.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665296);
			SpreadsheetTheme.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665297);
			SpreadsheetTheme.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr, 100665298);
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00042C04 File Offset: 0x00040E04
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00042C48 File Offset: 0x00040E48
		public unsafe virtual string PrimaryFontFamily
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_get_PrimaryFontFamily_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_set_PrimaryFontFamily_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00042C98 File Offset: 0x00040E98
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00042CE4 File Offset: 0x00040EE4
		public unsafe virtual IList<ThemeColorPair> ThemeColors
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_get_ThemeColors_Public_Virtual_New_get_IList_1_ThemeColorPair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ThemeColorPair>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_set_ThemeColors_Public_Virtual_New_set_Void_IList_1_ThemeColorPair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00042D34 File Offset: 0x00040F34
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00042D78 File Offset: 0x00040F78
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpreadsheetTheme.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00042DC8 File Offset: 0x00040FC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpreadsheetTheme()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpreadsheetTheme>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpreadsheetTheme.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00008F7D File Offset: 0x0000717D
		public SpreadsheetTheme(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00042E04 File Offset: 0x00041004
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00008F86 File Offset: 0x00007186
		public unsafe string _PrimaryFontFamily_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__PrimaryFontFamily_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__PrimaryFontFamily_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00042E2C File Offset: 0x0004102C
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00008FA5 File Offset: 0x000071A5
		public unsafe IList<ThemeColorPair> _ThemeColors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__ThemeColors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ThemeColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__ThemeColors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00042E5C File Offset: 0x0004105C
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00008FC4 File Offset: 0x000071C4
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpreadsheetTheme.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr__PrimaryFontFamily_k__BackingField;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr__ThemeColors_k__BackingField;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryFontFamily_Public_Virtual_New_get_String_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_set_PrimaryFontFamily_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_ThemeColors_Public_Virtual_New_get_IList_1_ThemeColorPair_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_set_ThemeColors_Public_Virtual_New_set_Void_IList_1_ThemeColorPair_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

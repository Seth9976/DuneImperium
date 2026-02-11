using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000046 RID: 70
	public class ConditionalFormatRule : Object
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0001FE60 File Offset: 0x0001E060
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalFormatRule()
		{
			Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ConditionalFormatRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr);
			ConditionalFormatRule.NativeFieldInfoPtr__BooleanRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, "<BooleanRule>k__BackingField");
			ConditionalFormatRule.NativeFieldInfoPtr__GradientRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, "<GradientRule>k__BackingField");
			ConditionalFormatRule.NativeFieldInfoPtr__Ranges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, "<Ranges>k__BackingField");
			ConditionalFormatRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, "<ETag>k__BackingField");
			ConditionalFormatRule.NativeMethodInfoPtr_get_BooleanRule_Public_Virtual_New_get_BooleanRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664186);
			ConditionalFormatRule.NativeMethodInfoPtr_set_BooleanRule_Public_Virtual_New_set_Void_BooleanRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664187);
			ConditionalFormatRule.NativeMethodInfoPtr_get_GradientRule_Public_Virtual_New_get_GradientRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664188);
			ConditionalFormatRule.NativeMethodInfoPtr_set_GradientRule_Public_Virtual_New_set_Void_GradientRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664189);
			ConditionalFormatRule.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664190);
			ConditionalFormatRule.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_IList_1_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664191);
			ConditionalFormatRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664192);
			ConditionalFormatRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664193);
			ConditionalFormatRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr, 100664194);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001FF94 File Offset: 0x0001E194
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		public unsafe virtual BooleanRule BooleanRule
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_get_BooleanRule_Public_Virtual_New_get_BooleanRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BooleanRule>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_set_BooleanRule_Public_Virtual_New_set_Void_BooleanRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00020030 File Offset: 0x0001E230
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0002007C File Offset: 0x0001E27C
		public unsafe virtual GradientRule GradientRule
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_get_GradientRule_Public_Virtual_New_get_GradientRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GradientRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_set_GradientRule_Public_Virtual_New_set_Void_GradientRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x000200CC File Offset: 0x0001E2CC
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00020118 File Offset: 0x0001E318
		public unsafe virtual IList<GridRange> Ranges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_IList_1_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00020168 File Offset: 0x0001E368
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000201AC File Offset: 0x0001E3AC
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConditionalFormatRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000201FC File Offset: 0x0001E3FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalFormatRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalFormatRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalFormatRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00004907 File Offset: 0x00002B07
		public ConditionalFormatRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00020238 File Offset: 0x0001E438
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00004910 File Offset: 0x00002B10
		public unsafe BooleanRule _BooleanRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__BooleanRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BooleanRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__BooleanRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0000492F File Offset: 0x00002B2F
		public unsafe GradientRule _GradientRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__GradientRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__GradientRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00020298 File Offset: 0x0001E498
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0000494E File Offset: 0x00002B4E
		public unsafe IList<GridRange> _Ranges_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__Ranges_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<GridRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__Ranges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x000202C8 File Offset: 0x0001E4C8
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0000496D File Offset: 0x00002B6D
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalFormatRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr__BooleanRule_k__BackingField;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr__GradientRule_k__BackingField;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr__Ranges_k__BackingField;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_get_BooleanRule_Public_Virtual_New_get_BooleanRule_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_set_BooleanRule_Public_Virtual_New_set_Void_BooleanRule_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_get_GradientRule_Public_Virtual_New_get_GradientRule_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_set_GradientRule_Public_Virtual_New_set_Void_GradientRule_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_get_Ranges_Public_Virtual_New_get_IList_1_GridRange_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_set_Ranges_Public_Virtual_New_set_Void_IList_1_GridRange_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

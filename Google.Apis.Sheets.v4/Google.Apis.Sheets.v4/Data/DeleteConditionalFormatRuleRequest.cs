using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000051 RID: 81
	public class DeleteConditionalFormatRuleRequest : Object
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x000227C4 File Offset: 0x000209C4
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteConditionalFormatRuleRequest()
		{
			Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteConditionalFormatRuleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr);
			DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, "<Index>k__BackingField");
			DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, "<SheetId>k__BackingField");
			DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664269);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664270);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664271);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664272);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664273);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664274);
			DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr, 100664275);
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000228BC File Offset: 0x00020ABC
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00022900 File Offset: 0x00020B00
		public unsafe virtual Nullable<int> Index
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00022954 File Offset: 0x00020B54
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00022998 File Offset: 0x00020B98
		public unsafe virtual Nullable<int> SheetId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000229EC File Offset: 0x00020BEC
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00022A30 File Offset: 0x00020C30
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00022A80 File Offset: 0x00020C80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteConditionalFormatRuleRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteConditionalFormatRuleRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00004DF3 File Offset: 0x00002FF3
		public DeleteConditionalFormatRuleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00022ABC File Offset: 0x00020CBC
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00004DFC File Offset: 0x00002FFC
		public Nullable<int> _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00022AEC File Offset: 0x00020CEC
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00004E2A File Offset: 0x0000302A
		public Nullable<int> _SheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00022B1C File Offset: 0x00020D1C
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00004E58 File Offset: 0x00003058
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr__SheetId_k__BackingField;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

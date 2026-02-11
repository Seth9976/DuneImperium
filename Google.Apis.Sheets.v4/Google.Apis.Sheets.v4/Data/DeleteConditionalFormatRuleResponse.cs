using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000052 RID: 82
	public class DeleteConditionalFormatRuleResponse : Object
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00022B44 File Offset: 0x00020D44
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteConditionalFormatRuleResponse()
		{
			Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DeleteConditionalFormatRuleResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr);
			DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__Rule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, "<Rule>k__BackingField");
			DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, "<ETag>k__BackingField");
			DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, 100664276);
			DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, 100664277);
			DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, 100664278);
			DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, 100664279);
			DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr, 100664280);
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00022C00 File Offset: 0x00020E00
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00022C4C File Offset: 0x00020E4C
		public unsafe virtual ConditionalFormatRule Rule
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00022C9C File Offset: 0x00020E9C
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00022CE0 File Offset: 0x00020EE0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00022D30 File Offset: 0x00020F30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteConditionalFormatRuleResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteConditionalFormatRuleResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteConditionalFormatRuleResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004E77 File Offset: 0x00003077
		public DeleteConditionalFormatRuleResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00022D6C File Offset: 0x00020F6C
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00004E80 File Offset: 0x00003080
		public unsafe ConditionalFormatRule _Rule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__Rule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__Rule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00022D9C File Offset: 0x00020F9C
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00004E9F File Offset: 0x0000309F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr__Rule_k__BackingField;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

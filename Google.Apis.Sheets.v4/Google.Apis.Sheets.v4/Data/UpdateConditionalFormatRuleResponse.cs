using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000BB RID: 187
	public class UpdateConditionalFormatRuleResponse : Object
	{
		// Token: 0x06000FF4 RID: 4084 RVA: 0x00048454 File Offset: 0x00046654
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateConditionalFormatRuleResponse()
		{
			Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateConditionalFormatRuleResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr);
			UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, "<NewIndex>k__BackingField");
			UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, "<NewRule>k__BackingField");
			UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, "<OldIndex>k__BackingField");
			UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, "<OldRule>k__BackingField");
			UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665469);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665470);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_NewRule_Public_Virtual_New_get_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665471);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_NewRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665472);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_OldIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665473);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_OldIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665474);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_OldRule_Public_Virtual_New_get_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665475);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_OldRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665476);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665477);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665478);
			UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr, 100665479);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000485C4 File Offset: 0x000467C4
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00048608 File Offset: 0x00046808
		public unsafe virtual Nullable<int> NewIndex
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0004865C File Offset: 0x0004685C
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x000486A8 File Offset: 0x000468A8
		public unsafe virtual ConditionalFormatRule NewRule
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_NewRule_Public_Virtual_New_get_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_NewRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000486F8 File Offset: 0x000468F8
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x0004873C File Offset: 0x0004693C
		public unsafe virtual Nullable<int> OldIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_OldIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_OldIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00048790 File Offset: 0x00046990
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x000487DC File Offset: 0x000469DC
		public unsafe virtual ConditionalFormatRule OldRule
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_OldRule_Public_Virtual_New_get_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_OldRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0004882C File Offset: 0x00046A2C
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00048870 File Offset: 0x00046A70
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000488C0 File Offset: 0x00046AC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateConditionalFormatRuleResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateConditionalFormatRuleResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateConditionalFormatRuleResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public UpdateConditionalFormatRuleResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000488FC File Offset: 0x00046AFC
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x00009ADD File Offset: 0x00007CDD
		public Nullable<int> _NewIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0004892C File Offset: 0x00046B2C
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x00009B0B File Offset: 0x00007D0B
		public unsafe ConditionalFormatRule _NewRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__NewRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0004895C File Offset: 0x00046B5C
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00009B2A File Offset: 0x00007D2A
		public Nullable<int> _OldIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x0004898C File Offset: 0x00046B8C
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00009B58 File Offset: 0x00007D58
		public unsafe ConditionalFormatRule _OldRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__OldRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000489BC File Offset: 0x00046BBC
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00009B77 File Offset: 0x00007D77
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr__NewIndex_k__BackingField;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr__NewRule_k__BackingField;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr__OldIndex_k__BackingField;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr__OldRule_k__BackingField;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_get_NewRule_Public_Virtual_New_get_ConditionalFormatRule_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_set_NewRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_get_OldIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_set_OldIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_get_OldRule_Public_Virtual_New_get_ConditionalFormatRule_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_set_OldRule_Public_Virtual_New_set_Void_ConditionalFormatRule_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

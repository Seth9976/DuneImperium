using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000BA RID: 186
	public class UpdateConditionalFormatRuleRequest : Object
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x00047EC8 File Offset: 0x000460C8
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateConditionalFormatRuleRequest()
		{
			Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateConditionalFormatRuleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr);
			UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, "<Index>k__BackingField");
			UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__NewIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, "<NewIndex>k__BackingField");
			UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, "<Rule>k__BackingField");
			UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, "<SheetId>k__BackingField");
			UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665458);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665459);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665460);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665461);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665462);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665463);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665464);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665465);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665466);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665467);
			UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr, 100665468);
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00048038 File Offset: 0x00046238
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0004807C File Offset: 0x0004627C
		public unsafe virtual Nullable<int> Index
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000480D0 File Offset: 0x000462D0
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00048114 File Offset: 0x00046314
		public unsafe virtual Nullable<int> NewIndex
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00048168 File Offset: 0x00046368
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x000481B4 File Offset: 0x000463B4
		public unsafe virtual ConditionalFormatRule Rule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00048204 File Offset: 0x00046404
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00048248 File Offset: 0x00046448
		public unsafe virtual Nullable<int> SheetId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0004829C File Offset: 0x0004649C
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x000482E0 File Offset: 0x000464E0
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00048330 File Offset: 0x00046530
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateConditionalFormatRuleRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateConditionalFormatRuleRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00009A03 File Offset: 0x00007C03
		public UpdateConditionalFormatRuleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0004836C File Offset: 0x0004656C
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00009A0C File Offset: 0x00007C0C
		public Nullable<int> _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0004839C File Offset: 0x0004659C
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00009A3A File Offset: 0x00007C3A
		public Nullable<int> _NewIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__NewIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__NewIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000483CC File Offset: 0x000465CC
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00009A68 File Offset: 0x00007C68
		public unsafe ConditionalFormatRule _Rule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000483FC File Offset: 0x000465FC
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00009A87 File Offset: 0x00007C87
		public Nullable<int> _SheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__SheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0004842C File Offset: 0x0004662C
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00009AB5 File Offset: 0x00007CB5
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr__NewIndex_k__BackingField;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr__Rule_k__BackingField;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr__SheetId_k__BackingField;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_get_NewIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_set_NewIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

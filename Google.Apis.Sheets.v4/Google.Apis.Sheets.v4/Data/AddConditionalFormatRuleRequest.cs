using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000009 RID: 9
	public class AddConditionalFormatRuleRequest : Object
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000CF10 File Offset: 0x0000B110
		// Note: this type is marked as 'beforefieldinit'.
		static AddConditionalFormatRuleRequest()
		{
			Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddConditionalFormatRuleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr);
			AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, "<Index>k__BackingField");
			AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, "<Rule>k__BackingField");
			AddConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663581);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663582);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663583);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663584);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663585);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663586);
			AddConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr, 100663587);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000D008 File Offset: 0x0000B208
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000D04C File Offset: 0x0000B24C
		public unsafe virtual Nullable<int> Index
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		public unsafe virtual ConditionalFormatRule Rule
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000D13C File Offset: 0x0000B33C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000D180 File Offset: 0x0000B380
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddConditionalFormatRuleRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddConditionalFormatRuleRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddConditionalFormatRuleRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddConditionalFormatRuleRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000023D6 File Offset: 0x000005D6
		public AddConditionalFormatRuleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000D20C File Offset: 0x0000B40C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000023DF File Offset: 0x000005DF
		public Nullable<int> _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Index_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000D23C File Offset: 0x0000B43C
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe ConditionalFormatRule _Rule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalFormatRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__Rule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000D26C File Offset: 0x0000B46C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000242C File Offset: 0x0000062C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddConditionalFormatRuleRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr__Rule_k__BackingField;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_set_Index_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_Rule_Public_Virtual_New_get_ConditionalFormatRule_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_Rule_Public_Virtual_New_set_Void_ConditionalFormatRule_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

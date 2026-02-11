using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000031 RID: 49
	public class BooleanRule : Object
	{
		// Token: 0x06000376 RID: 886 RVA: 0x0001824C File Offset: 0x0001644C
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanRule()
		{
			Il2CppClassPointerStore<BooleanRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BooleanRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr);
			BooleanRule.NativeFieldInfoPtr__Condition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, "<Condition>k__BackingField");
			BooleanRule.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, "<Format>k__BackingField");
			BooleanRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, "<ETag>k__BackingField");
			BooleanRule.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663939);
			BooleanRule.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663940);
			BooleanRule.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663941);
			BooleanRule.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_CellFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663942);
			BooleanRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663943);
			BooleanRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663944);
			BooleanRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr, 100663945);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00018344 File Offset: 0x00016544
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00018390 File Offset: 0x00016590
		public unsafe virtual BooleanCondition Condition
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000183E0 File Offset: 0x000165E0
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0001842C File Offset: 0x0001662C
		public unsafe virtual CellFormat Format
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_CellFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0001847C File Offset: 0x0001667C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000184C0 File Offset: 0x000166C0
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00018510 File Offset: 0x00016710
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000039D8 File Offset: 0x00001BD8
		public BooleanRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0001854C File Offset: 0x0001674C
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000039E1 File Offset: 0x00001BE1
		public unsafe BooleanCondition _Condition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__Condition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__Condition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0001857C File Offset: 0x0001677C
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003A00 File Offset: 0x00001C00
		public unsafe CellFormat _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CellFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000185AC File Offset: 0x000167AC
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003A1F File Offset: 0x00001C1F
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr__Condition_k__BackingField;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_CellFormat_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_CellFormat_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

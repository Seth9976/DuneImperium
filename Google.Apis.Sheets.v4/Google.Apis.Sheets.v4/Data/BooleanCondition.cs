using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000030 RID: 48
	public class BooleanCondition : Object
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00017ED4 File Offset: 0x000160D4
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanCondition()
		{
			Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "BooleanCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr);
			BooleanCondition.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, "<Type>k__BackingField");
			BooleanCondition.NativeFieldInfoPtr__Values_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, "<Values>k__BackingField");
			BooleanCondition.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, "<ETag>k__BackingField");
			BooleanCondition.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663932);
			BooleanCondition.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663933);
			BooleanCondition.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_ConditionValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663934);
			BooleanCondition.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_ConditionValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663935);
			BooleanCondition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663936);
			BooleanCondition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663937);
			BooleanCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr, 100663938);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00017FCC File Offset: 0x000161CC
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00018010 File Offset: 0x00016210
		public unsafe virtual string Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00018060 File Offset: 0x00016260
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000180AC File Offset: 0x000162AC
		public unsafe virtual IList<ConditionValue> Values
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_ConditionValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ConditionValue>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_ConditionValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000180FC File Offset: 0x000162FC
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00018140 File Offset: 0x00016340
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BooleanCondition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00018190 File Offset: 0x00016390
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanCondition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003972 File Offset: 0x00001B72
		public BooleanCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000181CC File Offset: 0x000163CC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000397B File Offset: 0x00001B7B
		public unsafe string _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__Type_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000181F4 File Offset: 0x000163F4
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000399A File Offset: 0x00001B9A
		public unsafe IList<ConditionValue> _Values_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__Values_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ConditionValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__Values_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00018224 File Offset: 0x00016424
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000039B9 File Offset: 0x00001BB9
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BooleanCondition.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr__Values_k__BackingField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_New_get_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_IList_1_ConditionValue_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_set_Values_Public_Virtual_New_set_Void_IList_1_ConditionValue_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

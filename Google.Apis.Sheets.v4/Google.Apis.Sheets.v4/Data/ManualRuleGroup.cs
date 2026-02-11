using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000083 RID: 131
	public class ManualRuleGroup : Object
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00030408 File Offset: 0x0002E608
		// Note: this type is marked as 'beforefieldinit'.
		static ManualRuleGroup()
		{
			Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "ManualRuleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr);
			ManualRuleGroup.NativeFieldInfoPtr__GroupName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, "<GroupName>k__BackingField");
			ManualRuleGroup.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, "<Items>k__BackingField");
			ManualRuleGroup.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, "<ETag>k__BackingField");
			ManualRuleGroup.NativeMethodInfoPtr_get_GroupName_Public_Virtual_New_get_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664709);
			ManualRuleGroup.NativeMethodInfoPtr_set_GroupName_Public_Virtual_New_set_Void_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664710);
			ManualRuleGroup.NativeMethodInfoPtr_get_Items_Public_Virtual_New_get_IList_1_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664711);
			ManualRuleGroup.NativeMethodInfoPtr_set_Items_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664712);
			ManualRuleGroup.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664713);
			ManualRuleGroup.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664714);
			ManualRuleGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr, 100664715);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00030500 File Offset: 0x0002E700
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0003054C File Offset: 0x0002E74C
		public unsafe virtual ExtendedValue GroupName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_get_GroupName_Public_Virtual_New_get_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_set_GroupName_Public_Virtual_New_set_Void_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0003059C File Offset: 0x0002E79C
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000305E8 File Offset: 0x0002E7E8
		public unsafe virtual IList<ExtendedValue> Items
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_get_Items_Public_Virtual_New_get_IList_1_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ExtendedValue>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_set_Items_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00030638 File Offset: 0x0002E838
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x0003067C File Offset: 0x0002E87C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualRuleGroup.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000306CC File Offset: 0x0002E8CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualRuleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualRuleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualRuleGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00006B5D File Offset: 0x00004D5D
		public ManualRuleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00030708 File Offset: 0x0002E908
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00006B66 File Offset: 0x00004D66
		public unsafe ExtendedValue _GroupName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__GroupName_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtendedValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__GroupName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00030738 File Offset: 0x0002E938
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00006B85 File Offset: 0x00004D85
		public unsafe IList<ExtendedValue> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ExtendedValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00030768 File Offset: 0x0002E968
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualRuleGroup.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__GroupName_k__BackingField;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_GroupName_Public_Virtual_New_get_ExtendedValue_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_set_GroupName_Public_Virtual_New_set_Void_ExtendedValue_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_New_get_IList_1_ExtendedValue_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Public_Virtual_New_set_Void_IList_1_ExtendedValue_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

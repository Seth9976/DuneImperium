using System;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000268 RID: 616
	public class DBGSelectEntityPrompt : DBGSelectionPrompt
	{
		// Token: 0x06001C7A RID: 7290 RVA: 0x0007B9F8 File Offset: 0x00079BF8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectEntityPrompt()
		{
			Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectEntityPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr);
			DBGSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, "<Choices>k__BackingField");
			DBGSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, "<MinToSelect>k__BackingField");
			DBGSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, "<MaxToSelect>k__BackingField");
			DBGSelectEntityPrompt.NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, 100667965);
			DBGSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, 100667966);
			DBGSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, 100667967);
			DBGSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_List_1_EntityComponent_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr, 100667968);
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0007BAB4 File Offset: 0x00079CB4
		public unsafe ReadOnlyList<EntityComponent> Choices
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPrompt.NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0007BAF4 File Offset: 0x00079CF4
		public unsafe int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0007BB30 File Offset: 0x00079D30
		public unsafe int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0007BB6C File Offset: 0x00079D6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 535749, RefRangeEnd = 535752, XrefRangeStart = 535734, XrefRangeEnd = 535749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectEntityPrompt(DataComposition promptData, bool mayCancel, IEnumerable<string> prefabTags, List<EntityComponent> choices, int minToSelect, int maxToSelect)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectEntityPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefabTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minToSelect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxToSelect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_List_1_EntityComponent_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0000F44E File Offset: 0x0000D64E
		public DBGSelectEntityPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0007BC08 File Offset: 0x00079E08
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0000F457 File Offset: 0x0000D657
		public unsafe ReadOnlyList<EntityComponent> _Choices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0007BC38 File Offset: 0x00079E38
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x0000F476 File Offset: 0x0000D676
		public unsafe int _MinToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0007BC60 File Offset: 0x00079E60
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000F491 File Offset: 0x0000D691
		public unsafe int _MaxToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr__Choices_k__BackingField;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr__MinToSelect_k__BackingField;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr__MaxToSelect_k__BackingField;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_List_1_EntityComponent_Int32_Int32_0;
	}
}

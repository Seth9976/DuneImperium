using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x0200025D RID: 605
	public class ArchetypeCustomChoiceInfoPrompt : FlavoredResolvablePrompt<List<int>>
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x000789C0 File Offset: 0x00076BC0
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeCustomChoiceInfoPrompt()
		{
			Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "ArchetypeCustomChoiceInfoPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr);
			ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__Buttons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, "<Buttons>k__BackingField");
			ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, "<MinToSelect>k__BackingField");
			ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, "<MaxToSelect>k__BackingField");
			ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, "<MayCancel>k__BackingField");
			ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Buttons_Public_get_IReadOnlyList_1_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, 100667818);
			ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, 100667819);
			ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, 100667820);
			ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, 100667821);
			ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IReadOnlyList_1_ReadOnlyAttributes_Int32_Int32_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr, 100667822);
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00078AA4 File Offset: 0x00076CA4
		public unsafe IReadOnlyList<ReadOnlyAttributes> Buttons
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Buttons_Public_get_IReadOnlyList_1_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00078AE4 File Offset: 0x00076CE4
		public unsafe int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00078B20 File Offset: 0x00076D20
		public unsafe int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00078B5C File Offset: 0x00076D5C
		public unsafe bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00078B98 File Offset: 0x00076D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534347, XrefRangeEnd = 534351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceInfoPrompt(DataComposition promptData, IReadOnlyList<ReadOnlyAttributes> buttons, int minToSelect, int maxToSelect, bool mayCancel, IEnumerable<string> additionalTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCustomChoiceInfoPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minToSelect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxToSelect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeCustomChoiceInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IReadOnlyList_1_ReadOnlyAttributes_Int32_Int32_Boolean_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000EFA1 File Offset: 0x0000D1A1
		public ArchetypeCustomChoiceInfoPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00078C34 File Offset: 0x00076E34
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0000EFAA File Offset: 0x0000D1AA
		public unsafe IReadOnlyList<ReadOnlyAttributes> _Buttons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__Buttons_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ReadOnlyAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__Buttons_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00078C64 File Offset: 0x00076E64
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0000EFC9 File Offset: 0x0000D1C9
		public unsafe int _MinToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00078C8C File Offset: 0x00076E8C
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		public unsafe int _MaxToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00078CB4 File Offset: 0x00076EB4
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000EFFF File Offset: 0x0000D1FF
		public unsafe bool _MayCancel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeCustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField)) = value;
			}
		}

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr__Buttons_k__BackingField;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeFieldInfoPtr__MinToSelect_k__BackingField;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeFieldInfoPtr__MaxToSelect_k__BackingField;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr__MayCancel_k__BackingField;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_get_IReadOnlyList_1_ReadOnlyAttributes_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IReadOnlyList_1_ReadOnlyAttributes_Int32_Int32_Boolean_IEnumerable_1_String_0;
	}
}

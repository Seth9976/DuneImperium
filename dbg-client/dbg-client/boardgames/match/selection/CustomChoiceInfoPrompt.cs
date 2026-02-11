using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x0200025F RID: 607
	public class CustomChoiceInfoPrompt : FlavoredResolvablePrompt<int>
	{
		// Token: 0x06001BD3 RID: 7123 RVA: 0x00078FA0 File Offset: 0x000771A0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceInfoPrompt()
		{
			Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "CustomChoiceInfoPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr);
			CustomChoiceInfoPrompt.NativeFieldInfoPtr__Choices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, "<Choices>k__BackingField");
			CustomChoiceInfoPrompt.NativeFieldInfoPtr__Titles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, "<Titles>k__BackingField");
			CustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, "<MayCancel>k__BackingField");
			CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Choices_Public_get_IList_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, 100667836);
			CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Titles_Public_get_IList_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, 100667837);
			CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, 100667838);
			CustomChoiceInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IList_1_LocalizableText_IList_1_LocalizableText_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr, 100667839);
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0007905C File Offset: 0x0007725C
		public unsafe IList<LocalizableText> Choices
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Choices_Public_get_IList_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x0007909C File Offset: 0x0007729C
		public unsafe IList<LocalizableText> Titles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_Titles_Public_get_IList_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000790DC File Offset: 0x000772DC
		public unsafe bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00079118 File Offset: 0x00077318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534401, XrefRangeEnd = 534406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceInfoPrompt(DataComposition promptData, IList<LocalizableText> choices, IList<LocalizableText> titles, bool mayCancel, IEnumerable<string> additionalTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceInfoPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(titles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IList_1_LocalizableText_IList_1_LocalizableText_Boolean_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0000F023 File Offset: 0x0000D223
		public CustomChoiceInfoPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000791A8 File Offset: 0x000773A8
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000F02C File Offset: 0x0000D22C
		public unsafe IList<LocalizableText> _Choices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__Choices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__Choices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000791D8 File Offset: 0x000773D8
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000F04B File Offset: 0x0000D24B
		public unsafe IList<LocalizableText> _Titles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__Titles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__Titles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00079208 File Offset: 0x00077408
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000F06A File Offset: 0x0000D26A
		public unsafe bool _MayCancel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField)) = value;
			}
		}

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr__Choices_k__BackingField;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr__Titles_k__BackingField;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr__MayCancel_k__BackingField;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_get_IList_1_LocalizableText_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_get_Titles_Public_get_IList_1_LocalizableText_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IList_1_LocalizableText_IList_1_LocalizableText_Boolean_IEnumerable_1_String_0;
	}
}

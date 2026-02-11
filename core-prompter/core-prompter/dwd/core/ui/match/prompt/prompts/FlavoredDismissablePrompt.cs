using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.match.prompt.prompts
{
	// Token: 0x02000007 RID: 7
	public class FlavoredDismissablePrompt : DismissablePrompt
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00004538 File Offset: 0x00002738
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredDismissablePrompt()
		{
			Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.match.prompt.prompts", "FlavoredDismissablePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr);
			FlavoredDismissablePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			FlavoredDismissablePrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, "<TheySeenMe>k__BackingField");
			FlavoredDismissablePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663309);
			FlavoredDismissablePrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663310);
			FlavoredDismissablePrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663311);
			FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663312);
			FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663313);
			FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr, 100663314);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00004608 File Offset: 0x00002808
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004648 File Offset: 0x00002848
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00004684 File Offset: 0x00002884
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000046C4 File Offset: 0x000028C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1212929, RefRangeEnd = 1212939, XrefRangeStart = 1212916, XrefRangeEnd = 1212929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredDismissablePrompt(DataComposition data, IEnumerable<string> additionalTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004724 File Offset: 0x00002924
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1212954, RefRangeEnd = 1212965, XrefRangeStart = 1212939, XrefRangeEnd = 1212954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredDismissablePrompt(DataComposition data, string flavor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004784 File Offset: 0x00002984
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1212996, RefRangeEnd = 1213043, XrefRangeStart = 1212965, XrefRangeEnd = 1212996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredDismissablePrompt(LocalizedString text = null, LocalizedString title = null, IEnumerable<string> additionalTags = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredDismissablePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredDismissablePrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020F0 File Offset: 0x000002F0
		public FlavoredDismissablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000047F4 File Offset: 0x000029F4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredDismissablePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredDismissablePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004824 File Offset: 0x00002A24
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe bool _TheySeenMe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredDismissablePrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredDismissablePrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField)) = value;
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__TheySeenMe_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_IEnumerable_1_String_0;
	}
}

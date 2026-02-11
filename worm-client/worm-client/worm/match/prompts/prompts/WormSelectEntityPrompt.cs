using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using dwd.core.match;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000BE RID: 190
	public class WormSelectEntityPrompt : ResolvablePrompt<List<EntityID>>
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectEntityPrompt()
		{
			Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormSelectEntityPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr);
			WormSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<Choices>k__BackingField");
			WormSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<TheySeenMe>k__BackingField");
			WormSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<MayCancel>k__BackingField");
			WormSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<MinToSelect>k__BackingField");
			WormSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, "<MaxToSelect>k__BackingField");
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664291);
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664292);
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664293);
			WormSelectEntityPrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664294);
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664295);
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664296);
			WormSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664297);
			WormSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr, 100664298);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002F4FC File Offset: 0x0002D6FC
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0002F53C File Offset: 0x0002D73C
		public unsafe ReadOnlyList<EntityComponent> Choices
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0002F57C File Offset: 0x0002D77C
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0002F5B8 File Offset: 0x0002D7B8
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		public unsafe bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0002F634 File Offset: 0x0002D834
		public unsafe int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0002F670 File Offset: 0x0002D870
		public unsafe int MaxToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002F6AC File Offset: 0x0002D8AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696877, RefRangeEnd = 696879, XrefRangeStart = 696862, XrefRangeEnd = 696877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectEntityPrompt(DataComposition promptData, List<EntityComponent> choices, int minToSelect, int maxToSelect, bool mayCancel, IEnumerable<string> prefabTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectEntityPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minToSelect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxToSelect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefabTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00005CFB File Offset: 0x00003EFB
		public WormSelectEntityPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0002F748 File Offset: 0x0002D948
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00005D04 File Offset: 0x00003F04
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0002F778 File Offset: 0x0002D978
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00005D23 File Offset: 0x00003F23
		public unsafe ReadOnlyList<EntityComponent> _Choices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__Choices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00005D42 File Offset: 0x00003F42
		public unsafe bool _TheySeenMe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00005D5D File Offset: 0x00003F5D
		public unsafe bool _MayCancel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0002F7F8 File Offset: 0x0002D9F8
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00005D78 File Offset: 0x00003F78
		public unsafe int _MinToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0002F820 File Offset: 0x0002DA20
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00005D93 File Offset: 0x00003F93
		public unsafe int _MaxToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr__Choices_k__BackingField;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr__TheySeenMe_k__BackingField;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr__MayCancel_k__BackingField;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr__MinToSelect_k__BackingField;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr__MaxToSelect_k__BackingField;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0;
	}
}

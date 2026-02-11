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
	// Token: 0x020000BB RID: 187
	public class WormImperiumSelectEntityPrompt : ResolvablePrompt<List<EntityID>>
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x0002EC68 File Offset: 0x0002CE68
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumSelectEntityPrompt()
		{
			Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormImperiumSelectEntityPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr);
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ImperiumChoices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<ImperiumChoices>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ReserveChoices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<ReserveChoices>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__HelenaReserveChoices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<HelenaReserveChoices>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<TheySeenMe>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<MayCancel>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<MinToSelect>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, "<MaxToSelect>k__BackingField");
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664278);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_ImperiumChoices_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664279);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_ReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664280);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_HelenaReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664281);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664282);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664283);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664284);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664285);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664286);
			WormImperiumSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_List_1_EntityComponent_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr, 100664287);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002EE00 File Offset: 0x0002D000
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002EE40 File Offset: 0x0002D040
		public unsafe ReadOnlyList<EntityComponent> ImperiumChoices
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_ImperiumChoices_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0002EE80 File Offset: 0x0002D080
		public unsafe ReadOnlyList<EntityComponent> ReserveChoices
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_ReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		public unsafe ReadOnlyList<EntityComponent> HelenaReserveChoices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_HelenaReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0002EF00 File Offset: 0x0002D100
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0002EF3C File Offset: 0x0002D13C
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0002EF7C File Offset: 0x0002D17C
		public unsafe bool MayCancel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		public unsafe int MinToSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
		public unsafe int MaxToSelect
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0002F030 File Offset: 0x0002D230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696837, XrefRangeEnd = 696862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumSelectEntityPrompt(DataComposition promptData, List<EntityComponent> imperiumChoices, List<EntityComponent> reserveChoices, List<EntityComponent> helenaReserveChoices, int minToSelect, int maxToSelect, bool mayCancel, IEnumerable<string> prefabTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumSelectEntityPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imperiumChoices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reserveChoices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helenaReserveChoices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minToSelect;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxToSelect;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefabTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumSelectEntityPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_List_1_EntityComponent_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00005BA0 File Offset: 0x00003DA0
		public WormImperiumSelectEntityPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00005BA9 File Offset: 0x00003DA9
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0002F120 File Offset: 0x0002D320
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public unsafe ReadOnlyList<EntityComponent> _ImperiumChoices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ImperiumChoices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ImperiumChoices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002F150 File Offset: 0x0002D350
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00005BE7 File Offset: 0x00003DE7
		public unsafe ReadOnlyList<EntityComponent> _ReserveChoices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ReserveChoices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__ReserveChoices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0002F180 File Offset: 0x0002D380
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00005C06 File Offset: 0x00003E06
		public unsafe ReadOnlyList<EntityComponent> _HelenaReserveChoices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__HelenaReserveChoices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__HelenaReserveChoices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002F1B0 File Offset: 0x0002D3B0
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00005C25 File Offset: 0x00003E25
		public unsafe bool _TheySeenMe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__TheySeenMe_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe bool _MayCancel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MayCancel_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002F200 File Offset: 0x0002D400
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005C5B File Offset: 0x00003E5B
		public unsafe int _MinToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MinToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0002F228 File Offset: 0x0002D428
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005C76 File Offset: 0x00003E76
		public unsafe int _MaxToSelect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumSelectEntityPrompt.NativeFieldInfoPtr__MaxToSelect_k__BackingField)) = value;
			}
		}

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr__ImperiumChoices_k__BackingField;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr__ReserveChoices_k__BackingField;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr__HelenaReserveChoices_k__BackingField;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr__TheySeenMe_k__BackingField;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr__MayCancel_k__BackingField;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr__MinToSelect_k__BackingField;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr__MaxToSelect_k__BackingField;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumChoices_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_get_ReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_HelenaReserveChoices_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_get_Boolean_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_get_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_get_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_List_1_EntityComponent_List_1_EntityComponent_List_1_EntityComponent_Int32_Int32_Boolean_IEnumerable_1_String_0;
	}
}

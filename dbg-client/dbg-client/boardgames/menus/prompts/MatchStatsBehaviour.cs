using System;
using boardgames.menus.commands;
using Canis.utils.ids;
using dbgclient.data;
using dbgclient.dataRenderers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001D8 RID: 472
	public class MatchStatsBehaviour : MonoBehaviour
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x000636E0 File Offset: 0x000618E0
		// Note: this type is marked as 'beforefieldinit'.
		static MatchStatsBehaviour()
		{
			Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "MatchStatsBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr);
			MatchStatsBehaviour.NativeFieldInfoPtr_categoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "categoryPrefab");
			MatchStatsBehaviour.NativeFieldInfoPtr_categoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "categoryContainer");
			MatchStatsBehaviour.NativeFieldInfoPtr_includeAllAvailableCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "includeAllAvailableCategories");
			MatchStatsBehaviour.NativeFieldInfoPtr_defaultMaxOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "defaultMaxOnly");
			MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "defaultAsTotal");
			MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "defaultAsPercent");
			MatchStatsBehaviour.NativeFieldInfoPtr_defaultLocFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "defaultLocFormat");
			MatchStatsBehaviour.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "categories");
			MatchStatsBehaviour.NativeFieldInfoPtr_noDataWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "noDataWarning");
			MatchStatsBehaviour.NativeFieldInfoPtr_additionalFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "additionalFilters");
			MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "additionalFiltersForJustOwner");
			MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "additionalFiltersForJustFriends");
			MatchStatsBehaviour.NativeFieldInfoPtr__entryRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "_entryRenderers");
			MatchStatsBehaviour.NativeFieldInfoPtr__cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "_cachedData");
			MatchStatsBehaviour.NativeMethodInfoPtr_get_Categories_Protected_Virtual_New_get_Il2CppReferenceArray_1_CategoryDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666467);
			MatchStatsBehaviour.NativeMethodInfoPtr_UpdateDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666468);
			MatchStatsBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666469);
			MatchStatsBehaviour.NativeMethodInfoPtr_SelectFilter_Public_Void_StatsFilter_MatchStatsFilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666470);
			MatchStatsBehaviour.NativeMethodInfoPtr_DeselectFilter_Public_Void_StatsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666471);
			MatchStatsBehaviour.NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_New_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666472);
			MatchStatsBehaviour.NativeMethodInfoPtr_ShowMatchStatsData_Protected_Virtual_New_Void_List_1_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666473);
			MatchStatsBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, 100666474);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000638C8 File Offset: 0x00061AC8
		public unsafe virtual Il2CppReferenceArray<CategoryDefinition> Categories
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchStatsBehaviour.NativeMethodInfoPtr_get_Categories_Protected_Virtual_New_get_Il2CppReferenceArray_1_CategoryDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CategoryDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00063914 File Offset: 0x00061B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522622, XrefRangeEnd = 522623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.NativeMethodInfoPtr_UpdateDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00063948 File Offset: 0x00061B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522623, XrefRangeEnd = 522628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator FetchAndUpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchStatsBehaviour.NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00063994 File Offset: 0x00061B94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 522638, RefRangeEnd = 522641, XrefRangeStart = 522628, XrefRangeEnd = 522638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectFilter(StatsFilter filter, MatchStatsFilterType filterType = MatchStatsFilterType.All)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.NativeMethodInfoPtr_SelectFilter_Public_Void_StatsFilter_MatchStatsFilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000639E4 File Offset: 0x00061BE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 522656, RefRangeEnd = 522659, XrefRangeStart = 522641, XrefRangeEnd = 522656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectFilter(StatsFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.NativeMethodInfoPtr_DeselectFilter_Public_Void_StatsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00063A28 File Offset: 0x00061C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522659, XrefRangeEnd = 522774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTuple<string, string> GetCategoryValues(CategoryDefinition category, MatchStatsData ownerData, List<MatchStatsData> friendData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friendData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchStatsBehaviour.NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_New_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<string, string>(intPtr);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00063AA0 File Offset: 0x00061CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522774, XrefRangeEnd = 522945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMatchStatsData(List<MatchStatsData> matchStatsDatas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchStatsDatas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchStatsBehaviour.NativeMethodInfoPtr_ShowMatchStatsData_Protected_Virtual_New_Void_List_1_MatchStatsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00063AF0 File Offset: 0x00061CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 522974, RefRangeEnd = 522975, XrefRangeStart = 522945, XrefRangeEnd = 522974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStatsBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000C2D1 File Offset: 0x0000A4D1
		public MatchStatsBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00063B2C File Offset: 0x00061D2C
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000C2DA File Offset: 0x0000A4DA
		public unsafe PlayerStatsEntryRenderer categoryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categoryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerStatsEntryRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categoryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00063B5C File Offset: 0x00061D5C
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000C2F9 File Offset: 0x0000A4F9
		public unsafe Transform categoryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categoryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00063B8C File Offset: 0x00061D8C
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0000C318 File Offset: 0x0000A518
		public unsafe bool includeAllAvailableCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_includeAllAvailableCategories);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_includeAllAvailableCategories)) = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00063BB4 File Offset: 0x00061DB4
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0000C333 File Offset: 0x0000A533
		public unsafe bool defaultMaxOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultMaxOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultMaxOnly)) = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00063BDC File Offset: 0x00061DDC
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0000C34E File Offset: 0x0000A54E
		public unsafe bool defaultAsTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsTotal)) = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00063C04 File Offset: 0x00061E04
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0000C369 File Offset: 0x0000A569
		public unsafe bool defaultAsPercent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsPercent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultAsPercent)) = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00063C2C File Offset: 0x00061E2C
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x0000C384 File Offset: 0x0000A584
		public unsafe string defaultLocFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultLocFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_defaultLocFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00063C54 File Offset: 0x00061E54
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000C3A3 File Offset: 0x0000A5A3
		public unsafe Il2CppReferenceArray<CategoryDefinition> categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CategoryDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00063C84 File Offset: 0x00061E84
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
		public unsafe GameObject noDataWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_noDataWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_noDataWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00063CB4 File Offset: 0x00061EB4
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x0000C3E1 File Offset: 0x0000A5E1
		public unsafe List<StatsFilter> additionalFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatsFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00063CE4 File Offset: 0x00061EE4
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x0000C400 File Offset: 0x0000A600
		public unsafe List<StatsFilter> additionalFiltersForJustOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustOwner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatsFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustOwner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00063D14 File Offset: 0x00061F14
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0000C41F File Offset: 0x0000A61F
		public unsafe List<StatsFilter> additionalFiltersForJustFriends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustFriends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatsFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr_additionalFiltersForJustFriends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00063D44 File Offset: 0x00061F44
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000C43E File Offset: 0x0000A63E
		public unsafe List<PlayerStatsEntryRenderer> _entryRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr__entryRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerStatsEntryRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr__entryRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00063D74 File Offset: 0x00061F74
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000C45D File Offset: 0x0000A65D
		public unsafe List<MatchStatsData> _cachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr__cachedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchStatsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.NativeFieldInfoPtr__cachedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_categoryPrefab;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_categoryContainer;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_includeAllAvailableCategories;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaxOnly;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeFieldInfoPtr_defaultAsTotal;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeFieldInfoPtr_defaultAsPercent;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr_defaultLocFormat;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr_noDataWarning;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeFieldInfoPtr_additionalFilters;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeFieldInfoPtr_additionalFiltersForJustOwner;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr_additionalFiltersForJustFriends;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeFieldInfoPtr__entryRenderers;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr__cachedData;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_get_Categories_Protected_Virtual_New_get_Il2CppReferenceArray_1_CategoryDefinition_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_FetchAndUpdateDisplay_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_SelectFilter_Public_Void_StatsFilter_MatchStatsFilterType_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_DeselectFilter_Public_Void_StatsFilter_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryValues_Protected_Virtual_New_ValueTuple_2_String_String_CategoryDefinition_MatchStatsData_List_1_MatchStatsData_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_ShowMatchStatsData_Protected_Virtual_New_Void_List_1_MatchStatsData_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C4 RID: 964
		[ObfuscatedName("boardgames.menus.prompts.MatchStatsBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002CF2 RID: 11506 RVA: 0x000AEBC8 File Offset: 0x000ACDC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr);
				MatchStatsBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, "<>9");
				MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, "<>9__20_0");
				MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, "<>9__21_2");
				MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, "<>9__21_3");
				MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, "<>9__21_5");
				MatchStatsBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, 100666476);
				MatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__20_0_Internal_Int32_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, 100666477);
				MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_2_Internal_IEnumerable_1_String_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, 100666478);
				MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_3_Internal___f__AnonymousType0_2_MatchStatsEntry_String_MatchStatsEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, 100666479);
				MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_5_Internal_String___f__AnonymousType0_2_MatchStatsEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr, 100666480);
			}

			// Token: 0x06002CF3 RID: 11507 RVA: 0x000AECBC File Offset: 0x000ACEBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF4 RID: 11508 RVA: 0x000AECF8 File Offset: 0x000ACEF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522558, XrefRangeEnd = 522560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCategoryValues_b__20_0(MatchStatsData entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c.NativeMethodInfoPtr__GetCategoryValues_b__20_0_Internal_Int32_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002CF5 RID: 11509 RVA: 0x000AED48 File Offset: 0x000ACF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522560, XrefRangeEnd = 522564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _ShowMatchStatsData_b__21_2(MatchStatsEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_2_Internal_IEnumerable_1_String_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002CF6 RID: 11510 RVA: 0x000AED98 File Offset: 0x000ACF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522564, XrefRangeEnd = 522570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<MatchStatsEntry, string> _ShowMatchStatsData_b__21_3(MatchStatsEntry entry, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_3_Internal___f__AnonymousType0_2_MatchStatsEntry_String_MatchStatsEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<MatchStatsEntry, string>>(intPtr3) : null;
			}

			// Token: 0x06002CF7 RID: 11511 RVA: 0x000AEDFC File Offset: 0x000ACFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522570, XrefRangeEnd = 522571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ShowMatchStatsData_b__21_5(__f__AnonymousType0<MatchStatsEntry, string> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c.NativeMethodInfoPtr__ShowMatchStatsData_b__21_5_Internal_String___f__AnonymousType0_2_MatchStatsEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002CF8 RID: 11512 RVA: 0x0001743A File Offset: 0x0001563A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000AEE44 File Offset: 0x000AD044
			// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00017443 File Offset: 0x00015643
			public unsafe static MatchStatsBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000AEE6C File Offset: 0x000AD06C
			// (set) Token: 0x06002CFC RID: 11516 RVA: 0x00017455 File Offset: 0x00015655
			public unsafe static Func<MatchStatsData, int> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000AEE94 File Offset: 0x000AD094
			// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00017467 File Offset: 0x00015667
			public unsafe static Func<MatchStatsEntry, IEnumerable<string>> __9__21_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000AEEBC File Offset: 0x000AD0BC
			// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00017479 File Offset: 0x00015679
			public unsafe static Func<MatchStatsEntry, string, __f__AnonymousType0<MatchStatsEntry, string>> __9__21_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, string, __f__AnonymousType0<MatchStatsEntry, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000AEEE4 File Offset: 0x000AD0E4
			// (set) Token: 0x06002D02 RID: 11522 RVA: 0x0001748B File Offset: 0x0001568B
			public unsafe static Func<__f__AnonymousType0<MatchStatsEntry, string>, string> __9__21_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<MatchStatsEntry, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsBehaviour.__c.NativeFieldInfoPtr___9__21_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BE5 RID: 7141
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001BE6 RID: 7142
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04001BE7 RID: 7143
			private static readonly IntPtr NativeFieldInfoPtr___9__21_2;

			// Token: 0x04001BE8 RID: 7144
			private static readonly IntPtr NativeFieldInfoPtr___9__21_3;

			// Token: 0x04001BE9 RID: 7145
			private static readonly IntPtr NativeFieldInfoPtr___9__21_5;

			// Token: 0x04001BEA RID: 7146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BEB RID: 7147
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryValues_b__20_0_Internal_Int32_MatchStatsData_0;

			// Token: 0x04001BEC RID: 7148
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__21_2_Internal_IEnumerable_1_String_MatchStatsEntry_0;

			// Token: 0x04001BED RID: 7149
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__21_3_Internal___f__AnonymousType0_2_MatchStatsEntry_String_MatchStatsEntry_String_0;

			// Token: 0x04001BEE RID: 7150
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__21_5_Internal_String___f__AnonymousType0_2_MatchStatsEntry_String_0;
		}

		// Token: 0x020003C5 RID: 965
		[ObfuscatedName("boardgames.menus.prompts.MatchStatsBehaviour+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D03 RID: 11523 RVA: 0x000AEF0C File Offset: 0x000AD10C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr);
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_actualCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, "actualCategories");
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, "accountID");
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, "<>9__4");
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666481);
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__4_Internal_Boolean___f__AnonymousType0_2_MatchStatsEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666482);
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__0_Internal_Boolean_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666483);
				MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__1_Internal_Boolean_MatchStatsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr, 100666484);
			}

			// Token: 0x06002D04 RID: 11524 RVA: 0x000AEFC4 File Offset: 0x000AD1C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D05 RID: 11525 RVA: 0x000AF000 File Offset: 0x000AD200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522571, XrefRangeEnd = 522586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowMatchStatsData_b__4(__f__AnonymousType0<MatchStatsEntry, string> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__4_Internal_Boolean___f__AnonymousType0_2_MatchStatsEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D06 RID: 11526 RVA: 0x000AF050 File Offset: 0x000AD250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522586, XrefRangeEnd = 522591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowMatchStatsData_b__0(MatchStatsData d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__0_Internal_Boolean_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D07 RID: 11527 RVA: 0x000AF0A0 File Offset: 0x000AD2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522591, XrefRangeEnd = 522596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowMatchStatsData_b__1(MatchStatsData e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_0.NativeMethodInfoPtr__ShowMatchStatsData_b__1_Internal_Boolean_MatchStatsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D08 RID: 11528 RVA: 0x0001749D File Offset: 0x0001569D
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000AF0F0 File Offset: 0x000AD2F0
			// (set) Token: 0x06002D0A RID: 11530 RVA: 0x000174A6 File Offset: 0x000156A6
			public unsafe List<CategoryDefinition> actualCategories
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_actualCategories);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CategoryDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_actualCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000AF120 File Offset: 0x000AD320
			// (set) Token: 0x06002D0C RID: 11532 RVA: 0x000174C5 File Offset: 0x000156C5
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000AF150 File Offset: 0x000AD350
			// (set) Token: 0x06002D0E RID: 11534 RVA: 0x000174E4 File Offset: 0x000156E4
			public unsafe Func<__f__AnonymousType0<MatchStatsEntry, string>, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<MatchStatsEntry, string>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BEF RID: 7151
			private static readonly IntPtr NativeFieldInfoPtr_actualCategories;

			// Token: 0x04001BF0 RID: 7152
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001BF1 RID: 7153
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04001BF2 RID: 7154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BF3 RID: 7155
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__4_Internal_Boolean___f__AnonymousType0_2_MatchStatsEntry_String_0;

			// Token: 0x04001BF4 RID: 7156
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__0_Internal_Boolean_MatchStatsData_0;

			// Token: 0x04001BF5 RID: 7157
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__1_Internal_Boolean_MatchStatsData_0;
		}

		// Token: 0x020003C6 RID: 966
		[ObfuscatedName("boardgames.menus.prompts.MatchStatsBehaviour+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D0F RID: 11535 RVA: 0x000AF180 File Offset: 0x000AD380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr);
				MatchStatsBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr___h__TransparentIdentifier0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr, "<>h__TransparentIdentifier0");
				MatchStatsBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr, 100666485);
				MatchStatsBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ShowMatchStatsData_b__6_Internal_Boolean_CategoryDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr, 100666486);
			}

			// Token: 0x06002D10 RID: 11536 RVA: 0x000AF1E8 File Offset: 0x000AD3E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsBehaviour.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D11 RID: 11537 RVA: 0x000AF224 File Offset: 0x000AD424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522596, XrefRangeEnd = 522599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowMatchStatsData_b__6(CategoryDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour.__c__DisplayClass21_1.NativeMethodInfoPtr__ShowMatchStatsData_b__6_Internal_Boolean_CategoryDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D12 RID: 11538 RVA: 0x00017503 File Offset: 0x00015703
			public __c__DisplayClass21_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000AF274 File Offset: 0x000AD474
			// (set) Token: 0x06002D14 RID: 11540 RVA: 0x0001750C File Offset: 0x0001570C
			public unsafe __f__AnonymousType0<MatchStatsEntry, string> __h__TransparentIdentifier0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr___h__TransparentIdentifier0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<MatchStatsEntry, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour.__c__DisplayClass21_1.NativeFieldInfoPtr___h__TransparentIdentifier0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BF6 RID: 7158
			private static readonly IntPtr NativeFieldInfoPtr___h__TransparentIdentifier0;

			// Token: 0x04001BF7 RID: 7159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BF8 RID: 7160
			private static readonly IntPtr NativeMethodInfoPtr__ShowMatchStatsData_b__6_Internal_Boolean_CategoryDefinition_0;
		}

		// Token: 0x020003C7 RID: 967
		[ObfuscatedName("boardgames.menus.prompts.MatchStatsBehaviour+<FetchAndUpdateDisplay>d__17")]
		public sealed class _FetchAndUpdateDisplay_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D15 RID: 11541 RVA: 0x000AF2A4 File Offset: 0x000AD4A4
			// Note: this type is marked as 'beforefieldinit'.
			static _FetchAndUpdateDisplay_d__17()
			{
				Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchStatsBehaviour>.NativeClassPtr, "<FetchAndUpdateDisplay>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, "<>1__state");
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, "<>2__current");
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, "<>4__this");
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr__loadCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, "<loadCommand>5__2");
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666487);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666488);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666489);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666490);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666491);
				MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr, 100666492);
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x000AF398 File Offset: 0x000AD598
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FetchAndUpdateDisplay_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsBehaviour._FetchAndUpdateDisplay_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D17 RID: 11543 RVA: 0x000AF3E0 File Offset: 0x000AD5E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D18 RID: 11544 RVA: 0x000AF414 File Offset: 0x000AD614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522599, XrefRangeEnd = 522617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000AF450 File Offset: 0x000AD650
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x000AF490 File Offset: 0x000AD690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 522617, XrefRangeEnd = 522622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000AF4C4 File Offset: 0x000AD6C4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x0001752B File Offset: 0x0001572B
			public _FetchAndUpdateDisplay_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000AF504 File Offset: 0x000AD704
			// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00017534 File Offset: 0x00015734
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000AF52C File Offset: 0x000AD72C
			// (set) Token: 0x06002D20 RID: 11552 RVA: 0x0001754F File Offset: 0x0001574F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000AF55C File Offset: 0x000AD75C
			// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0001756E File Offset: 0x0001576E
			public unsafe MatchStatsBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000AF58C File Offset: 0x000AD78C
			// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0001758D File Offset: 0x0001578D
			public unsafe LoadMatchStats _loadCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr__loadCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadMatchStats>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsBehaviour._FetchAndUpdateDisplay_d__17.NativeFieldInfoPtr__loadCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BF9 RID: 7161
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BFA RID: 7162
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BFB RID: 7163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BFC RID: 7164
			private static readonly IntPtr NativeFieldInfoPtr__loadCommand_5__2;

			// Token: 0x04001BFD RID: 7165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BFE RID: 7166
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BFF RID: 7167
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C00 RID: 7168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C01 RID: 7169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C02 RID: 7170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

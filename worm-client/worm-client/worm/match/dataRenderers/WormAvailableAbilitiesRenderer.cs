using System;
using boardgames.match.data;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F9 RID: 249
	public class WormAvailableAbilitiesRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000AF9 RID: 2809 RVA: 0x00039674 File Offset: 0x00037874
		// Note: this type is marked as 'beforefieldinit'.
		static WormAvailableAbilitiesRenderer()
		{
			Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAvailableAbilitiesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr);
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "availableAbilitiesContainerView");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_disabledAbilitiesContainerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "disabledAbilitiesContainerView");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "abilitiesCanvasGroup");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_kindsToObserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "kindsToObserve");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_triggerOnAbilityAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "triggerOnAbilityAdded");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_overrideFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "overrideFor");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "lastSelectedAbilityIndex");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_activePlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "activePlayerData");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "wormEntities");
			WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "tempEntities");
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664801);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664802);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664803);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664804);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_UpdateContainerViewWithAbilities_Private_Boolean_ContainerView_IReadOnlyCollection_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664805);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_AutoSelectAbility_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664806);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_Event_OnAbilitySelected_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664807);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664808);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__dirtyUpdate_b__14_4_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664809);
			WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__dirtyUpdate_b__14_5_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, 100664810);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00039834 File Offset: 0x00037A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702352, XrefRangeEnd = 702391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00039870 File Offset: 0x00037A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702391, XrefRangeEnd = 702410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000398A4 File Offset: 0x00037AA4
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702410, XrefRangeEnd = 702413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000398EC File Offset: 0x00037AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702413, XrefRangeEnd = 702568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00039928 File Offset: 0x00037B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 702631, RefRangeEnd = 702633, XrefRangeStart = 702568, XrefRangeEnd = 702631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateContainerViewWithAbilities(ContainerView view, IReadOnlyCollection<EntityID> availableSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(availableSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_UpdateContainerViewWithAbilities_Private_Boolean_ContainerView_IReadOnlyCollection_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00039988 File Offset: 0x00037B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702633, XrefRangeEnd = 702638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AutoSelectAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_AutoSelectAbility_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000399C8 File Offset: 0x00037BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702638, XrefRangeEnd = 702655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnAbilitySelected(EntityID abilityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr_Event_OnAbilitySelected_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00039A0C File Offset: 0x00037C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702655, XrefRangeEnd = 702677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAvailableAbilitiesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00039A48 File Offset: 0x00037C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702677, XrefRangeEnd = 702682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__14_4(EntityID a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__dirtyUpdate_b__14_4_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00039A98 File Offset: 0x00037C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702682, XrefRangeEnd = 702683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__14_5(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.NativeMethodInfoPtr__dirtyUpdate_b__14_5_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00007C21 File Offset: 0x00005E21
		public WormAvailableAbilitiesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00039AE8 File Offset: 0x00037CE8
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00007C2A File Offset: 0x00005E2A
		public unsafe ContainerView availableAbilitiesContainerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00039B18 File Offset: 0x00037D18
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00007C49 File Offset: 0x00005E49
		public unsafe ContainerView disabledAbilitiesContainerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_disabledAbilitiesContainerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_disabledAbilitiesContainerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00039B48 File Offset: 0x00037D48
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00007C68 File Offset: 0x00005E68
		public unsafe CanvasGroup abilitiesCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00039B78 File Offset: 0x00037D78
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00007C87 File Offset: 0x00005E87
		public unsafe List<string> kindsToObserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_kindsToObserve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_kindsToObserve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00039BA8 File Offset: 0x00037DA8
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00007CA6 File Offset: 0x00005EA6
		public unsafe UnityEvent triggerOnAbilityAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_triggerOnAbilityAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_triggerOnAbilityAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00039BD8 File Offset: 0x00037DD8
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00007CC5 File Offset: 0x00005EC5
		public unsafe ArchetypeID overrideFor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_overrideFor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_overrideFor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00039C08 File Offset: 0x00037E08
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public unsafe int lastSelectedAbilityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00039C30 File Offset: 0x00037E30
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00007CFF File Offset: 0x00005EFF
		public unsafe ActivePlayerData activePlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_activePlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivePlayerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_activePlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00039C60 File Offset: 0x00037E60
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00007D1E File Offset: 0x00005F1E
		public unsafe WormEntities wormEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_wormEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00039C90 File Offset: 0x00037E90
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00007D3D File Offset: 0x00005F3D
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_availableAbilitiesContainerView;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_disabledAbilitiesContainerView;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesCanvasGroup;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_kindsToObserve;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr_triggerOnAbilityAdded;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr_overrideFor;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedAbilityIndex;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeFieldInfoPtr_activePlayerData;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContainerViewWithAbilities_Private_Boolean_ContainerView_IReadOnlyCollection_1_EntityID_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_AutoSelectAbility_Private_IEnumerator_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnAbilitySelected_Public_Void_EntityID_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__14_4_Private_Boolean_EntityID_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__14_5_Private_Boolean_EntityID_0;

		// Token: 0x02000359 RID: 857
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600229B RID: 8859 RVA: 0x00081360 File Offset: 0x0007F560
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, "<>9");
				WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, "<>9__14_0");
				WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, "<>9__14_2");
				WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, "<>9__14_3");
				WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, 100664812);
				WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_0_Internal_EntityID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, 100664813);
				WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_2_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, 100664814);
				WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_3_Internal_EntityID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr, 100664815);
			}

			// Token: 0x0600229C RID: 8860 RVA: 0x0008142C File Offset: 0x0007F62C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600229D RID: 8861 RVA: 0x00081468 File Offset: 0x0007F668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702274, XrefRangeEnd = 702276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _dirtyUpdate_b__14_0(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_0_Internal_EntityID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600229E RID: 8862 RVA: 0x000814B8 File Offset: 0x0007F6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702276, XrefRangeEnd = 702283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__14_2(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_2_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600229F RID: 8863 RVA: 0x00081508 File Offset: 0x0007F708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _dirtyUpdate_b__14_3(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__14_3_Internal_EntityID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060022A0 RID: 8864 RVA: 0x00013632 File Offset: 0x00011832
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00081558 File Offset: 0x0007F758
			// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0001363B File Offset: 0x0001183B
			public unsafe static WormAvailableAbilitiesRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAvailableAbilitiesRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00081580 File Offset: 0x0007F780
			// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0001364D File Offset: 0x0001184D
			public unsafe static Func<UnitView, EntityID> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000815A8 File Offset: 0x0007F7A8
			// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0001365F File Offset: 0x0001185F
			public unsafe static Func<UnitView, bool> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000815D0 File Offset: 0x0007F7D0
			// (set) Token: 0x060022A8 RID: 8872 RVA: 0x00013671 File Offset: 0x00011871
			public unsafe static Func<UnitView, EntityID> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableAbilitiesRenderer.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E7 RID: 5095
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040013E8 RID: 5096
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040013E9 RID: 5097
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x040013EA RID: 5098
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x040013EB RID: 5099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013EC RID: 5100
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__14_0_Internal_EntityID_UnitView_0;

			// Token: 0x040013ED RID: 5101
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__14_2_Internal_Boolean_UnitView_0;

			// Token: 0x040013EE RID: 5102
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__14_3_Internal_EntityID_UnitView_0;
		}

		// Token: 0x0200035A RID: 858
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022A9 RID: 8873 RVA: 0x000815F8 File Offset: 0x0007F7F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeFieldInfoPtr_listSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr, "listSelection");
				WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr, 100664816);
				WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr, 100664817);
			}

			// Token: 0x060022AA RID: 8874 RVA: 0x00081660 File Offset: 0x0007F860
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022AB RID: 8875 RVA: 0x0008169C File Offset: 0x0007F89C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702283, XrefRangeEnd = 702289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(EntityID e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022AC RID: 8876 RVA: 0x00013683 File Offset: 0x00011883
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x000816EC File Offset: 0x0007F8EC
			// (set) Token: 0x060022AE RID: 8878 RVA: 0x0001368C File Offset: 0x0001188C
			public unsafe IEntityListSelection listSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeFieldInfoPtr_listSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityListSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass14_0.NativeFieldInfoPtr_listSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013EF RID: 5103
			private static readonly IntPtr NativeFieldInfoPtr_listSelection;

			// Token: 0x040013F0 RID: 5104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013F1 RID: 5105
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200035B RID: 859
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022AF RID: 8879 RVA: 0x0008171C File Offset: 0x0007F91C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_availableSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, "availableSelections");
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, "view");
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, 100664818);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, 100664819);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__1_Internal_EntityComponent_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, 100664820);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr, 100664821);
			}

			// Token: 0x060022B0 RID: 8880 RVA: 0x000817D4 File Offset: 0x0007F9D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B1 RID: 8881 RVA: 0x00081810 File Offset: 0x0007FA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702289, XrefRangeEnd = 702304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateContainerViewWithAbilities_b__0(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022B2 RID: 8882 RVA: 0x00081860 File Offset: 0x0007FA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702304, XrefRangeEnd = 702305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityComponent _UpdateContainerViewWithAbilities_b__1(EntityID entityID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__1_Internal_EntityComponent_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x060022B3 RID: 8883 RVA: 0x000818B0 File Offset: 0x0007FAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702305, XrefRangeEnd = 702313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateContainerViewWithAbilities_b__2(EntityComponent entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022B4 RID: 8884 RVA: 0x000136AB File Offset: 0x000118AB
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00081900 File Offset: 0x0007FB00
			// (set) Token: 0x060022B6 RID: 8886 RVA: 0x000136B4 File Offset: 0x000118B4
			public unsafe IReadOnlyCollection<EntityID> availableSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_availableSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_availableSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000993 RID: 2451
			// (get) Token: 0x060022B7 RID: 8887 RVA: 0x00081930 File Offset: 0x0007FB30
			// (set) Token: 0x060022B8 RID: 8888 RVA: 0x000136D3 File Offset: 0x000118D3
			public unsafe WormAvailableAbilitiesRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAvailableAbilitiesRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x060022B9 RID: 8889 RVA: 0x00081960 File Offset: 0x0007FB60
			// (set) Token: 0x060022BA RID: 8890 RVA: 0x000136F2 File Offset: 0x000118F2
			public unsafe ContainerView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_0.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013F2 RID: 5106
			private static readonly IntPtr NativeFieldInfoPtr_availableSelections;

			// Token: 0x040013F3 RID: 5107
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013F4 RID: 5108
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x040013F5 RID: 5109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013F6 RID: 5110
			private static readonly IntPtr NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__0_Internal_Boolean_UnitView_0;

			// Token: 0x040013F7 RID: 5111
			private static readonly IntPtr NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__1_Internal_EntityComponent_EntityID_0;

			// Token: 0x040013F8 RID: 5112
			private static readonly IntPtr NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x0200035C RID: 860
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : global::Il2CppSystem.Object
		{
			// Token: 0x060022BB RID: 8891 RVA: 0x00081990 File Offset: 0x0007FB90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr, "v");
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr, 100664822);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__3_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr, 100664823);
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x000819F8 File Offset: 0x0007FBF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x00081A34 File Offset: 0x0007FC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702313, XrefRangeEnd = 702319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateContainerViewWithAbilities_b__3(EntityID availableSelection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSelection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__3_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00013711 File Offset: 0x00011911
			public __c__DisplayClass15_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x060022BF RID: 8895 RVA: 0x00081A84 File Offset: 0x0007FC84
			// (set) Token: 0x060022C0 RID: 8896 RVA: 0x0001371A File Offset: 0x0001191A
			public unsafe UnitView v
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeFieldInfoPtr_v);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_1.NativeFieldInfoPtr_v), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013F9 RID: 5113
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x040013FA RID: 5114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013FB RID: 5115
			private static readonly IntPtr NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__3_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c__DisplayClass15_2")]
		public sealed class __c__DisplayClass15_2 : global::Il2CppSystem.Object
		{
			// Token: 0x060022C1 RID: 8897 RVA: 0x00081AB4 File Offset: 0x0007FCB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_2()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c__DisplayClass15_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr, "entity");
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr, 100664824);
				WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__4_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr, 100664825);
			}

			// Token: 0x060022C2 RID: 8898 RVA: 0x00081B1C File Offset: 0x0007FD1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass15_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C3 RID: 8899 RVA: 0x00081B58 File Offset: 0x0007FD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702319, XrefRangeEnd = 702325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateContainerViewWithAbilities_b__4(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__4_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x00013739 File Offset: 0x00011939
			public __c__DisplayClass15_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00081BA8 File Offset: 0x0007FDA8
			// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00013742 File Offset: 0x00011942
			public unsafe EntityComponent entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass15_2.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013FC RID: 5116
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x040013FD RID: 5117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013FE RID: 5118
			private static readonly IntPtr NativeMethodInfoPtr__UpdateContainerViewWithAbilities_b__4_Internal_Boolean_UnitView_0;
		}

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022C7 RID: 8903 RVA: 0x00081BD8 File Offset: 0x0007FDD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr);
				WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeFieldInfoPtr_abilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr, "abilityId");
				WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr, 100664826);
				WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeMethodInfoPtr__Event_OnAbilitySelected_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr, 100664827);
			}

			// Token: 0x060022C8 RID: 8904 RVA: 0x00081C40 File Offset: 0x0007FE40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C9 RID: 8905 RVA: 0x00081C7C File Offset: 0x0007FE7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702325, XrefRangeEnd = 702331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_OnAbilitySelected_b__0(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeMethodInfoPtr__Event_OnAbilitySelected_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022CA RID: 8906 RVA: 0x00013761 File Offset: 0x00011961
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x060022CB RID: 8907 RVA: 0x00081CCC File Offset: 0x0007FECC
			// (set) Token: 0x060022CC RID: 8908 RVA: 0x0001376A File Offset: 0x0001196A
			public unsafe EntityID abilityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeFieldInfoPtr_abilityId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer.__c__DisplayClass17_0.NativeFieldInfoPtr_abilityId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013FF RID: 5119
			private static readonly IntPtr NativeFieldInfoPtr_abilityId;

			// Token: 0x04001400 RID: 5120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001401 RID: 5121
			private static readonly IntPtr NativeMethodInfoPtr__Event_OnAbilitySelected_b__0_Internal_Boolean_UnitView_0;
		}

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableAbilitiesRenderer+<AutoSelectAbility>d__16")]
		public sealed class _AutoSelectAbility_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x060022CD RID: 8909 RVA: 0x00081CFC File Offset: 0x0007FEFC
			// Note: this type is marked as 'beforefieldinit'.
			static _AutoSelectAbility_d__16()
			{
				Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer>.NativeClassPtr, "<AutoSelectAbility>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, "<>1__state");
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, "<>2__current");
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, "<>4__this");
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__firstSelectable_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, "<firstSelectable>5__2");
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__views_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, "<views>5__3");
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664828);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664829);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664830);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664831);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664832);
				WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr, 100664833);
			}

			// Token: 0x060022CE RID: 8910 RVA: 0x00081E04 File Offset: 0x00080004
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AutoSelectAbility_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022CF RID: 8911 RVA: 0x00081E4C File Offset: 0x0008004C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D0 RID: 8912 RVA: 0x00081E80 File Offset: 0x00080080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702331, XrefRangeEnd = 702347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00081EBC File Offset: 0x000800BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022D2 RID: 8914 RVA: 0x00081EFC File Offset: 0x000800FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702347, XrefRangeEnd = 702352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x060022D3 RID: 8915 RVA: 0x00081F30 File Offset: 0x00080130
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x00013789 File Offset: 0x00011989
			public _AutoSelectAbility_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x060022D5 RID: 8917 RVA: 0x00081F70 File Offset: 0x00080170
			// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00013792 File Offset: 0x00011992
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00081F98 File Offset: 0x00080198
			// (set) Token: 0x060022D8 RID: 8920 RVA: 0x000137AD File Offset: 0x000119AD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00081FC8 File Offset: 0x000801C8
			// (set) Token: 0x060022DA RID: 8922 RVA: 0x000137CC File Offset: 0x000119CC
			public unsafe WormAvailableAbilitiesRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAvailableAbilitiesRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x060022DB RID: 8923 RVA: 0x00081FF8 File Offset: 0x000801F8
			// (set) Token: 0x060022DC RID: 8924 RVA: 0x000137EB File Offset: 0x000119EB
			public unsafe Selectable _firstSelectable_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__firstSelectable_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__firstSelectable_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x060022DD RID: 8925 RVA: 0x00082028 File Offset: 0x00080228
			// (set) Token: 0x060022DE RID: 8926 RVA: 0x0001380A File Offset: 0x00011A0A
			public unsafe List<UnitView> _views_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__views_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableAbilitiesRenderer._AutoSelectAbility_d__16.NativeFieldInfoPtr__views_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001402 RID: 5122
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001403 RID: 5123
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001404 RID: 5124
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001405 RID: 5125
			private static readonly IntPtr NativeFieldInfoPtr__firstSelectable_5__2;

			// Token: 0x04001406 RID: 5126
			private static readonly IntPtr NativeFieldInfoPtr__views_5__3;

			// Token: 0x04001407 RID: 5127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001408 RID: 5128
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001409 RID: 5129
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400140A RID: 5130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400140B RID: 5131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400140C RID: 5132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

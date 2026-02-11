using System;
using boardgames.match.data;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FA RID: 250
	public class WormAvailableTechRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x00039CC0 File Offset: 0x00037EC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormAvailableTechRenderer()
		{
			Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAvailableTechRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr);
			WormAvailableTechRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "availableAbilitiesContainerView");
			WormAvailableTechRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "abilitiesCanvasGroup");
			WormAvailableTechRenderer.NativeFieldInfoPtr_kindsToObserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "kindsToObserve");
			WormAvailableTechRenderer.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "anim");
			WormAvailableTechRenderer.NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "param");
			WormAvailableTechRenderer.NativeFieldInfoPtr_moreTechButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "moreTechButton");
			WormAvailableTechRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "lastSelectedAbilityIndex");
			WormAvailableTechRenderer.NativeFieldInfoPtr_activePlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "activePlayerData");
			WormAvailableTechRenderer.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "wormEntities");
			WormAvailableTechRenderer.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "tempEntities");
			WormAvailableTechRenderer.NativeMethodInfoPtr_get_MoreTechButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664834);
			WormAvailableTechRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664835);
			WormAvailableTechRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664836);
			WormAvailableTechRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664837);
			WormAvailableTechRenderer.NativeMethodInfoPtr_CreatePrefabs_Private_Void_IReadOnlyCollection_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664838);
			WormAvailableTechRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664839);
			WormAvailableTechRenderer.NativeMethodInfoPtr_priorityByArchId_Private_Static_Nullable_1_Int32_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664840);
			WormAvailableTechRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664841);
			WormAvailableTechRenderer.NativeMethodInfoPtr__dirtyUpdate_b__15_0_Private_ValueTuple_2_Boolean_ValueTuple_2_EntityID_Int32_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, 100664842);
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00039E6C File Offset: 0x0003806C
		public unsafe Button MoreTechButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr_get_MoreTechButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
			}
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00039EAC File Offset: 0x000380AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702718, XrefRangeEnd = 702751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableTechRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00039EE8 File Offset: 0x000380E8
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702751, XrefRangeEnd = 702759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableTechRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00039F30 File Offset: 0x00038130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702759, XrefRangeEnd = 702784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAvailableTechRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00039F6C File Offset: 0x0003816C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702784, XrefRangeEnd = 702851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePrefabs(IReadOnlyCollection<EntityID> techTiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(techTiles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr_CreatePrefabs_Private_Void_IReadOnlyCollection_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00039FB0 File Offset: 0x000381B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702851, XrefRangeEnd = 702869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00039FE4 File Offset: 0x000381E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 702920, RefRangeEnd = 702921, XrefRangeStart = 702869, XrefRangeEnd = 702920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> priorityByArchId(ArchetypeID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr_priorityByArchId_Private_Static_Nullable_1_Int32_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0003A020 File Offset: 0x00038220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702921, XrefRangeEnd = 702941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAvailableTechRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003A05C File Offset: 0x0003825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702941, XrefRangeEnd = 702967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, ValueTuple<EntityID, int>> _dirtyUpdate_b__15_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.NativeMethodInfoPtr__dirtyUpdate_b__15_0_Private_ValueTuple_2_Boolean_ValueTuple_2_EntityID_Int32_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, ValueTuple<EntityID, int>>(intPtr);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00007D5C File Offset: 0x00005F5C
		public WormAvailableTechRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0003A0A4 File Offset: 0x000382A4
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00007D65 File Offset: 0x00005F65
		public unsafe ContainerView availableAbilitiesContainerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_availableAbilitiesContainerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0003A0D4 File Offset: 0x000382D4
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00007D84 File Offset: 0x00005F84
		public unsafe CanvasGroup abilitiesCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_abilitiesCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0003A104 File Offset: 0x00038304
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public unsafe List<string> kindsToObserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_kindsToObserve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_kindsToObserve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0003A134 File Offset: 0x00038334
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x00007DC2 File Offset: 0x00005FC2
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0003A164 File Offset: 0x00038364
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00007DE1 File Offset: 0x00005FE1
		public unsafe string param
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_param);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_param), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0003A18C File Offset: 0x0003838C
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00007E00 File Offset: 0x00006000
		public unsafe Button moreTechButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_moreTechButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_moreTechButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0003A1BC File Offset: 0x000383BC
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00007E1F File Offset: 0x0000601F
		public unsafe int lastSelectedAbilityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_lastSelectedAbilityIndex)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0003A1E4 File Offset: 0x000383E4
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00007E3A File Offset: 0x0000603A
		public unsafe ActivePlayerData activePlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_activePlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivePlayerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_activePlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0003A214 File Offset: 0x00038414
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00007E59 File Offset: 0x00006059
		public unsafe WormEntities wormEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_wormEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003A244 File Offset: 0x00038444
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00007E78 File Offset: 0x00006078
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_availableAbilitiesContainerView;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesCanvasGroup;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_kindsToObserve;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_param;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_moreTechButton;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedAbilityIndex;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_activePlayerData;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_get_MoreTechButton_Public_get_Button_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrefabs_Private_Void_IReadOnlyCollection_1_EntityID_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_priorityByArchId_Private_Static_Nullable_1_Int32_ArchetypeID_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__15_0_Private_ValueTuple_2_Boolean_ValueTuple_2_EntityID_Int32_EntityID_0;

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableTechRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060022DF RID: 8927 RVA: 0x00082058 File Offset: 0x00080258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr);
				WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, "<>9");
				WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, "<>9__15_1");
				WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, "<>9__15_2");
				WormAvailableTechRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, 100664844);
				WormAvailableTechRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__15_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, 100664845);
				WormAvailableTechRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__15_2_Internal_EntityID_ValueTuple_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr, 100664846);
			}

			// Token: 0x060022E0 RID: 8928 RVA: 0x000820FC File Offset: 0x000802FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableTechRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022E1 RID: 8929 RVA: 0x00082138 File Offset: 0x00080338
			[CallerCount(0)]
			public unsafe int _dirtyUpdate_b__15_1(ValueTuple<EntityID, int> ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ability));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__15_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022E2 RID: 8930 RVA: 0x0008218C File Offset: 0x0008038C
			[CallerCount(0)]
			public unsafe EntityID _dirtyUpdate_b__15_2(ValueTuple<EntityID, int> ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ability));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__15_2_Internal_EntityID_ValueTuple_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060022E3 RID: 8931 RVA: 0x00013829 File Offset: 0x00011A29
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000821E4 File Offset: 0x000803E4
			// (set) Token: 0x060022E5 RID: 8933 RVA: 0x00013832 File Offset: 0x00011A32
			public unsafe static WormAvailableTechRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAvailableTechRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0008220C File Offset: 0x0008040C
			// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00013844 File Offset: 0x00011A44
			public unsafe static Func<ValueTuple<EntityID, int>, int> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00082234 File Offset: 0x00080434
			// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00013856 File Offset: 0x00011A56
			public unsafe static Func<ValueTuple<EntityID, int>, EntityID> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<EntityID, int>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAvailableTechRenderer.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400140D RID: 5133
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400140E RID: 5134
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x0400140F RID: 5135
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x04001410 RID: 5136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001411 RID: 5137
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__15_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0;

			// Token: 0x04001412 RID: 5138
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__15_2_Internal_EntityID_ValueTuple_2_EntityID_Int32_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableTechRenderer+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022EA RID: 8938 RVA: 0x0008225C File Offset: 0x0008045C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr);
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr_techTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, "techTiles");
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, 100664847);
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, 100664848);
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__1_Internal_EntityComponent_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, 100664849);
				WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr, 100664850);
			}

			// Token: 0x060022EB RID: 8939 RVA: 0x00082300 File Offset: 0x00080500
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022EC RID: 8940 RVA: 0x0008233C File Offset: 0x0008053C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702683, XrefRangeEnd = 702698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePrefabs_b__0(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022ED RID: 8941 RVA: 0x0008238C File Offset: 0x0008058C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityComponent _CreatePrefabs_b__1(EntityID entityID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__1_Internal_EntityComponent_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x060022EE RID: 8942 RVA: 0x000823DC File Offset: 0x000805DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702698, XrefRangeEnd = 702706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePrefabs_b__2(EntityComponent entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeMethodInfoPtr__CreatePrefabs_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022EF RID: 8943 RVA: 0x00013868 File Offset: 0x00011A68
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0008242C File Offset: 0x0008062C
			// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00013871 File Offset: 0x00011A71
			public unsafe IReadOnlyCollection<EntityID> techTiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr_techTiles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr_techTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0008245C File Offset: 0x0008065C
			// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00013890 File Offset: 0x00011A90
			public unsafe WormAvailableTechRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAvailableTechRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001413 RID: 5139
			private static readonly IntPtr NativeFieldInfoPtr_techTiles;

			// Token: 0x04001414 RID: 5140
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001415 RID: 5141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001416 RID: 5142
			private static readonly IntPtr NativeMethodInfoPtr__CreatePrefabs_b__0_Internal_Boolean_UnitView_0;

			// Token: 0x04001417 RID: 5143
			private static readonly IntPtr NativeMethodInfoPtr__CreatePrefabs_b__1_Internal_EntityComponent_EntityID_0;

			// Token: 0x04001418 RID: 5144
			private static readonly IntPtr NativeMethodInfoPtr__CreatePrefabs_b__2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000362 RID: 866
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableTechRenderer+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : global::Il2CppSystem.Object
		{
			// Token: 0x060022F4 RID: 8948 RVA: 0x0008248C File Offset: 0x0008068C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr);
				WormAvailableTechRenderer.__c__DisplayClass16_1.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr, "v");
				WormAvailableTechRenderer.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr, 100664851);
				WormAvailableTechRenderer.__c__DisplayClass16_1.NativeMethodInfoPtr__CreatePrefabs_b__3_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr, 100664852);
			}

			// Token: 0x060022F5 RID: 8949 RVA: 0x000824F4 File Offset: 0x000806F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F6 RID: 8950 RVA: 0x00082530 File Offset: 0x00080730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702706, XrefRangeEnd = 702712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePrefabs_b__3(EntityID availableSelection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSelection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_1.NativeMethodInfoPtr__CreatePrefabs_b__3_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022F7 RID: 8951 RVA: 0x000138AF File Offset: 0x00011AAF
			public __c__DisplayClass16_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x060022F8 RID: 8952 RVA: 0x00082580 File Offset: 0x00080780
			// (set) Token: 0x060022F9 RID: 8953 RVA: 0x000138B8 File Offset: 0x00011AB8
			public unsafe UnitView v
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_1.NativeFieldInfoPtr_v);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_1.NativeFieldInfoPtr_v), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001419 RID: 5145
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x0400141A RID: 5146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400141B RID: 5147
			private static readonly IntPtr NativeMethodInfoPtr__CreatePrefabs_b__3_Internal_Boolean_EntityID_0;
		}

		// Token: 0x02000363 RID: 867
		[ObfuscatedName("worm.match.dataRenderers.WormAvailableTechRenderer+<>c__DisplayClass16_2")]
		public sealed class __c__DisplayClass16_2 : global::Il2CppSystem.Object
		{
			// Token: 0x060022FA RID: 8954 RVA: 0x000825B0 File Offset: 0x000807B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_2()
			{
				Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAvailableTechRenderer>.NativeClassPtr, "<>c__DisplayClass16_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr);
				WormAvailableTechRenderer.__c__DisplayClass16_2.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr, "entity");
				WormAvailableTechRenderer.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr, 100664853);
				WormAvailableTechRenderer.__c__DisplayClass16_2.NativeMethodInfoPtr__CreatePrefabs_b__4_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr, 100664854);
			}

			// Token: 0x060022FB RID: 8955 RVA: 0x00082618 File Offset: 0x00080818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAvailableTechRenderer.__c__DisplayClass16_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022FC RID: 8956 RVA: 0x00082654 File Offset: 0x00080854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702712, XrefRangeEnd = 702718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePrefabs_b__4(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAvailableTechRenderer.__c__DisplayClass16_2.NativeMethodInfoPtr__CreatePrefabs_b__4_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022FD RID: 8957 RVA: 0x000138D7 File Offset: 0x00011AD7
			public __c__DisplayClass16_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x060022FE RID: 8958 RVA: 0x000826A4 File Offset: 0x000808A4
			// (set) Token: 0x060022FF RID: 8959 RVA: 0x000138E0 File Offset: 0x00011AE0
			public unsafe EntityComponent entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_2.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAvailableTechRenderer.__c__DisplayClass16_2.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400141C RID: 5148
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x0400141D RID: 5149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400141E RID: 5150
			private static readonly IntPtr NativeMethodInfoPtr__CreatePrefabs_b__4_Internal_Boolean_UnitView_0;
		}
	}
}

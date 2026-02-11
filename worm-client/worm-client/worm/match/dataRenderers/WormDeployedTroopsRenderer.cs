using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.dataRenderers
{
	// Token: 0x02000112 RID: 274
	public class WormDeployedTroopsRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
		// Note: this type is marked as 'beforefieldinit'.
		static WormDeployedTroopsRenderer()
		{
			Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormDeployedTroopsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr);
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "garrisonView");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_troops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "troops");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_troopsIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "troopsIX");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_dreadnoughts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "dreadnoughts");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "garrisonCount");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountIx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "garrisonCountIx");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountDreadnoughts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "garrisonCountDreadnoughts");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_onTroopsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "onTroopsUpdated");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "entitiesProvider");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "garrisonAnimator");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedTroopsByLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "selectedTroopsByLocation");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedDreadnoughtsByLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "selectedDreadnoughtsByLocation");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "availableSupplyTroops");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "lastGameplaySetGarrison");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "dirty");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_GarrisonAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "GarrisonAdd");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeploy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "<LastGameplaySetDeploy>k__BackingField");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "<DisplayedDeployedCount>k__BackingField");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyDreadnoughts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "availableSupplyDreadnoughts");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrisonDN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "lastGameplaySetGarrisonDN");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeployDN_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "<LastGameplaySetDeployDN>k__BackingField");
			WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedDNCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "<DisplayedDeployedDNCount>k__BackingField");
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_LastGameplaySetDeploy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665021);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_LastGameplaySetDeploy_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665022);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_DisplayedDeployedCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665023);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_DisplayedDeployedCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665024);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_LastGameplaySetDeployDN_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665025);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_LastGameplaySetDeployDN_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665026);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_DisplayedDeployedDNCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665027);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_DisplayedDeployedDNCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665028);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665029);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_Event_SetDeployed_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665030);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_Event_SetGarrisoned_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665031);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665032);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665033);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665034);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_In_Private_Int32_IEnumerable_1_EntityID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665035);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_SelectedIn_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665036);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_IsMyTroop_Private_Boolean_EntityID_byref_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665037);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_SelectedDreadnoughtsIn_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665038);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr_IsMyDreadnought_Private_Boolean_EntityID_byref_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665039);
			WormDeployedTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, 100665040);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003E258 File Offset: 0x0003C458
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0003E294 File Offset: 0x0003C494
		public unsafe int LastGameplaySetDeploy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_LastGameplaySetDeploy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_LastGameplaySetDeploy_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0003E310 File Offset: 0x0003C510
		public unsafe int DisplayedDeployedCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_DisplayedDeployedCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314559, RefRangeEnd = 314560, XrefRangeStart = 314559, XrefRangeEnd = 314560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_DisplayedDeployedCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003E350 File Offset: 0x0003C550
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0003E38C File Offset: 0x0003C58C
		public unsafe int LastGameplaySetDeployDN
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_LastGameplaySetDeployDN_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683675, RefRangeEnd = 683676, XrefRangeStart = 683675, XrefRangeEnd = 683676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_LastGameplaySetDeployDN_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0003E408 File Offset: 0x0003C608
		public unsafe int DisplayedDeployedDNCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_get_DisplayedDeployedDNCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_set_DisplayedDeployedDNCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003E448 File Offset: 0x0003C648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704414, XrefRangeEnd = 704423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedTroopsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003E484 File Offset: 0x0003C684
		[CallerCount(0)]
		public unsafe void Event_SetDeployed(Il2CppStructArray<int> count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(count);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_Event_SetDeployed_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		[CallerCount(0)]
		public unsafe void Event_SetGarrisoned(Il2CppStructArray<int> count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(count);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_Event_SetGarrisoned_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003E50C File Offset: 0x0003C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704423, XrefRangeEnd = 704595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedTroopsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003E548 File Offset: 0x0003C748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704595, XrefRangeEnd = 704599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeployedTroopsRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003E584 File Offset: 0x0003C784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 704692, RefRangeEnd = 704693, XrefRangeStart = 704599, XrefRangeEnd = 704692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003E5B8 File Offset: 0x0003C7B8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 704709, RefRangeEnd = 704720, XrefRangeStart = 704693, XrefRangeEnd = 704709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int In(IEnumerable<EntityID> set, string location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_In_Private_Int32_IEnumerable_1_EntityID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003E618 File Offset: 0x0003C818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704720, XrefRangeEnd = 704725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectedIn(string location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_SelectedIn_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003E668 File Offset: 0x0003C868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704725, XrefRangeEnd = 704738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMyTroop(EntityID id, out EntityComponent troop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_IsMyTroop_Private_Boolean_EntityID_byref_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			troop = ((intPtr4 == 0) ? null : new EntityComponent(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0003E6D8 File Offset: 0x0003C8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704738, XrefRangeEnd = 704743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectedDreadnoughtsIn(string location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_SelectedDreadnoughtsIn_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0003E728 File Offset: 0x0003C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704743, XrefRangeEnd = 704756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMyDreadnought(EntityID id, out EntityComponent troop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr_IsMyDreadnought_Private_Boolean_EntityID_byref_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			troop = ((intPtr4 == 0) ? null : new EntityComponent(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0003E798 File Offset: 0x0003C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704756, XrefRangeEnd = 704862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDeployedTroopsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00008908 File Offset: 0x00006B08
		public WormDeployedTroopsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0003E7D4 File Offset: 0x0003C9D4
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00008911 File Offset: 0x00006B11
		public unsafe EntityView garrisonView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0003E804 File Offset: 0x0003CA04
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00008930 File Offset: 0x00006B30
		public unsafe List<WormDeployedHighlighter> troops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_troops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormDeployedHighlighter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_troops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0003E834 File Offset: 0x0003CA34
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0000894F File Offset: 0x00006B4F
		public unsafe List<WormDeployedHighlighter> troopsIX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_troopsIX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormDeployedHighlighter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_troopsIX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0003E864 File Offset: 0x0003CA64
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x0000896E File Offset: 0x00006B6E
		public unsafe List<WormDeployedHighlighter> dreadnoughts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_dreadnoughts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormDeployedHighlighter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_dreadnoughts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0003E894 File Offset: 0x0003CA94
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0000898D File Offset: 0x00006B8D
		public unsafe TMP_Text garrisonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x000089AC File Offset: 0x00006BAC
		public unsafe TMP_Text garrisonCountIx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountIx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountIx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000089CB File Offset: 0x00006BCB
		public unsafe TMP_Text garrisonCountDreadnoughts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountDreadnoughts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonCountDreadnoughts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0003E924 File Offset: 0x0003CB24
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x000089EA File Offset: 0x00006BEA
		public unsafe UnityEvent onTroopsUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_onTroopsUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_onTroopsUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0003E954 File Offset: 0x0003CB54
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00008A09 File Offset: 0x00006C09
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0003E984 File Offset: 0x0003CB84
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00008A28 File Offset: 0x00006C28
		public unsafe Animator garrisonAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_garrisonAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00008A47 File Offset: 0x00006C47
		public unsafe Dictionary<string, HashSet<EntityID>> selectedTroopsByLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedTroopsByLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedTroopsByLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00008A66 File Offset: 0x00006C66
		public unsafe Dictionary<string, HashSet<EntityID>> selectedDreadnoughtsByLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedDreadnoughtsByLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_selectedDreadnoughtsByLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0003EA14 File Offset: 0x0003CC14
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00008A85 File Offset: 0x00006C85
		public unsafe HashSet<EntityID> availableSupplyTroops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyTroops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyTroops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0003EA44 File Offset: 0x0003CC44
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public unsafe int lastGameplaySetGarrison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrison);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrison)) = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0003EA6C File Offset: 0x0003CC6C
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00008ABF File Offset: 0x00006CBF
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0003EA94 File Offset: 0x0003CC94
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00008ADA File Offset: 0x00006CDA
		public unsafe static int GarrisonAdd
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormDeployedTroopsRenderer.NativeFieldInfoPtr_GarrisonAdd, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormDeployedTroopsRenderer.NativeFieldInfoPtr_GarrisonAdd, (void*)(&value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public unsafe int _LastGameplaySetDeploy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeploy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeploy_k__BackingField)) = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0003EAD8 File Offset: 0x0003CCD8
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00008B03 File Offset: 0x00006D03
		public unsafe int _DisplayedDeployedCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0003EB00 File Offset: 0x0003CD00
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00008B1E File Offset: 0x00006D1E
		public unsafe HashSet<EntityID> availableSupplyDreadnoughts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyDreadnoughts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_availableSupplyDreadnoughts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0003EB30 File Offset: 0x0003CD30
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00008B3D File Offset: 0x00006D3D
		public unsafe int lastGameplaySetGarrisonDN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrisonDN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr_lastGameplaySetGarrisonDN)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0003EB58 File Offset: 0x0003CD58
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00008B58 File Offset: 0x00006D58
		public unsafe int _LastGameplaySetDeployDN_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeployDN_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__LastGameplaySetDeployDN_k__BackingField)) = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0003EB80 File Offset: 0x0003CD80
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00008B73 File Offset: 0x00006D73
		public unsafe int _DisplayedDeployedDNCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedDNCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.NativeFieldInfoPtr__DisplayedDeployedDNCount_k__BackingField)) = value;
			}
		}

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_garrisonView;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_troops;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_troopsIX;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_dreadnoughts;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_garrisonCount;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_garrisonCountIx;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_garrisonCountDreadnoughts;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_onTroopsUpdated;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_garrisonAnimator;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_selectedTroopsByLocation;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_selectedDreadnoughtsByLocation;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_availableSupplyTroops;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_lastGameplaySetGarrison;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_GarrisonAdd;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr__LastGameplaySetDeploy_k__BackingField;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr__DisplayedDeployedCount_k__BackingField;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_availableSupplyDreadnoughts;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_lastGameplaySetGarrisonDN;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr__LastGameplaySetDeployDN_k__BackingField;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr__DisplayedDeployedDNCount_k__BackingField;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGameplaySetDeploy_Public_get_Int32_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_set_LastGameplaySetDeploy_Private_set_Void_Int32_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayedDeployedCount_Public_get_Int32_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayedDeployedCount_Private_set_Void_Int32_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGameplaySetDeployDN_Public_get_Int32_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_set_LastGameplaySetDeployDN_Private_set_Void_Int32_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayedDeployedDNCount_Public_get_Int32_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayedDeployedDNCount_Private_set_Void_Int32_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetDeployed_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetGarrisoned_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_In_Private_Int32_IEnumerable_1_EntityID_String_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_SelectedIn_Private_Int32_String_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_IsMyTroop_Private_Boolean_EntityID_byref_EntityComponent_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_SelectedDreadnoughtsIn_Private_Int32_String_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_IsMyDreadnought_Private_Boolean_EntityID_byref_EntityComponent_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000376 RID: 886
		[ObfuscatedName("worm.match.dataRenderers.WormDeployedTroopsRenderer+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023B2 RID: 9138 RVA: 0x00084618 File Offset: 0x00082818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDeployedTroopsRenderer>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr);
				WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr, "location");
				WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr, 100665042);
				WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeMethodInfoPtr__In_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr, 100665043);
			}

			// Token: 0x060023B3 RID: 9139 RVA: 0x00084694 File Offset: 0x00082894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedTroopsRenderer.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023B4 RID: 9140 RVA: 0x000846D0 File Offset: 0x000828D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704412, XrefRangeEnd = 704414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _In_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeMethodInfoPtr__In_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060023B5 RID: 9141 RVA: 0x00013E9D File Offset: 0x0001209D
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x060023B6 RID: 9142 RVA: 0x00084720 File Offset: 0x00082920
			// (set) Token: 0x060023B7 RID: 9143 RVA: 0x00013EA6 File Offset: 0x000120A6
			public unsafe WormDeployedTroopsRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDeployedTroopsRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x060023B8 RID: 9144 RVA: 0x00084750 File Offset: 0x00082950
			// (set) Token: 0x060023B9 RID: 9145 RVA: 0x00013EC5 File Offset: 0x000120C5
			public unsafe string location
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr_location);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedTroopsRenderer.__c__DisplayClass40_0.NativeFieldInfoPtr_location), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001480 RID: 5248
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeFieldInfoPtr_location;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeMethodInfoPtr__In_b__0_Internal_Boolean_EntityID_0;
		}
	}
}

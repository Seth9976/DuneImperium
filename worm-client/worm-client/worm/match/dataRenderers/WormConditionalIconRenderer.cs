using System;
using boardgames.attributes;
using boardgames.match.behaviours;
using boardgames.match.data;
using boardgames.match.selection;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.dataRenderers
{
	// Token: 0x0200010B RID: 267
	public class WormConditionalIconRenderer : AttributeView
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x0003C174 File Offset: 0x0003A374
		// Note: this type is marked as 'beforefieldinit'.
		static WormConditionalIconRenderer()
		{
			Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormConditionalIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr);
			WormConditionalIconRenderer.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "entity");
			WormConditionalIconRenderer.NativeFieldInfoPtr_activePlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "activePlayerData");
			WormConditionalIconRenderer.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "selectionResponder");
			WormConditionalIconRenderer.NativeFieldInfoPtr_imperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "imperiumRow");
			WormConditionalIconRenderer.NativeFieldInfoPtr__LocalPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<LocalPlayerID>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__EntitiesProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<EntitiesProvider>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__LocalHand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<LocalHand>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__PlayAreas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<PlayAreas>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__ActiveAgentAreas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<ActiveAgentAreas>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<Version>k__BackingField");
			WormConditionalIconRenderer.NativeFieldInfoPtr__ShowIcons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<ShowIcons>k__BackingField");
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_LocalPlayerID_Protected_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664929);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664930);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_EntitiesProvider_Protected_get_DBGEntitiesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664931);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_EntitiesProvider_Private_set_Void_DBGEntitiesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664932);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_LocalHand_Protected_get_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664933);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_LocalHand_Private_set_Void_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664934);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_PlayAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664935);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_PlayAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664936);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_ActiveAgentAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664937);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_ActiveAgentAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664938);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664939);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_EntityID_Protected_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664940);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664941);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664942);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664943);
			WormConditionalIconRenderer.NativeMethodInfoPtr_get_ShowIcons_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664944);
			WormConditionalIconRenderer.NativeMethodInfoPtr_set_ShowIcons_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664945);
			WormConditionalIconRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664946);
			WormConditionalIconRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664947);
			WormConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664948);
			WormConditionalIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664949);
			WormConditionalIconRenderer.NativeMethodInfoPtr_GetPlayerPiles_Protected_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664950);
			WormConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664951);
			WormConditionalIconRenderer.NativeMethodInfoPtr_InHand_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664952);
			WormConditionalIconRenderer.NativeMethodInfoPtr_InActiveArea_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664953);
			WormConditionalIconRenderer.NativeMethodInfoPtr_CurrentChoice_Protected_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664954);
			WormConditionalIconRenderer.NativeMethodInfoPtr_CanUsurp_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664955);
			WormConditionalIconRenderer.NativeMethodInfoPtr_IsGraft_Protected_Static_Boolean_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664956);
			WormConditionalIconRenderer.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664957);
			WormConditionalIconRenderer.NativeMethodInfoPtr_SetShowIcons_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664958);
			WormConditionalIconRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664959);
			WormConditionalIconRenderer.NativeMethodInfoPtr__dirtyUpdate_b__41_0_Private_Boolean_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664960);
			WormConditionalIconRenderer.NativeMethodInfoPtr__CanUsurp_b__47_1_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664961);
			WormConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, 100664962);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0003C528 File Offset: 0x0003A728
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0003C568 File Offset: 0x0003A768
		public unsafe AccountID LocalPlayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_LocalPlayerID_Protected_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0003C5AC File Offset: 0x0003A7AC
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003C5EC File Offset: 0x0003A7EC
		public unsafe DBGEntitiesProvider EntitiesProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_EntitiesProvider_Protected_get_DBGEntitiesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_EntitiesProvider_Private_set_Void_DBGEntitiesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0003C630 File Offset: 0x0003A830
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0003C670 File Offset: 0x0003A870
		public unsafe ReadOnlyVersionedList<EntityComponent> LocalHand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_LocalHand_Protected_get_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_LocalHand_Private_set_Void_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0003C6F4 File Offset: 0x0003A8F4
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> PlayAreas
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_PlayAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_PlayAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003C738 File Offset: 0x0003A938
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0003C778 File Offset: 0x0003A978
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> ActiveAgentAreas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_ActiveAgentAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_ActiveAgentAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003C7BC File Offset: 0x0003A9BC
		public unsafe virtual bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 702967, RefRangeEnd = 702968, XrefRangeStart = 702967, XrefRangeEnd = 702968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_get_Initialized_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0003C804 File Offset: 0x0003AA04
		public unsafe EntityID EntityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_EntityID_Protected_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0003C844 File Offset: 0x0003AA44
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 703748, RefRangeEnd = 703749, XrefRangeStart = 703736, XrefRangeEnd = 703748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003C88C File Offset: 0x0003AA8C
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0003C8C8 File Offset: 0x0003AAC8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0003C908 File Offset: 0x0003AB08
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x0003C944 File Offset: 0x0003AB44
		public unsafe virtual bool ShowIcons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_get_ShowIcons_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_set_ShowIcons_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0003C984 File Offset: 0x0003AB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703749, XrefRangeEnd = 703756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703756, XrefRangeEnd = 703761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0003CA00 File Offset: 0x0003AC00
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0003CA3C File Offset: 0x0003AC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703761, XrefRangeEnd = 703791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0003CA78 File Offset: 0x0003AC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703840, RefRangeEnd = 703841, XrefRangeStart = 703791, XrefRangeEnd = 703840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> GetPlayerPiles(string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_GetPlayerPiles_Protected_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		[CallerCount(0)]
		public unsafe virtual bool ShowIconsOnTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0003CB10 File Offset: 0x0003AD10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 703842, RefRangeEnd = 703846, XrefRangeStart = 703841, XrefRangeEnd = 703842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InHand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_InHand_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0003CB4C File Offset: 0x0003AD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703846, XrefRangeEnd = 703848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InActiveArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_InActiveArea_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0003CB88 File Offset: 0x0003AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703848, XrefRangeEnd = 703850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISelectionNode CurrentChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_CurrentChoice_Protected_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0003CBC8 File Offset: 0x0003ADC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 703881, RefRangeEnd = 703883, XrefRangeStart = 703850, XrefRangeEnd = 703881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUsurp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_CanUsurp_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0003CC04 File Offset: 0x0003AE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703895, RefRangeEnd = 703896, XrefRangeStart = 703883, XrefRangeEnd = 703895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGraft(IHasAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_IsGraft_Protected_Static_Boolean_IHasAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703896, XrefRangeEnd = 703903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConditionalIconRenderer.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0003CC98 File Offset: 0x0003AE98
		[CallerCount(0)]
		public unsafe void SetShowIcons(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_SetShowIcons_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0003CCD8 File Offset: 0x0003AED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703020, RefRangeEnd = 703021, XrefRangeStart = 703020, XrefRangeEnd = 703021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConditionalIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0003CD14 File Offset: 0x0003AF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703903, XrefRangeEnd = 703907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__41_0(ReadOnlyVersionedList<EntityComponent> p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr__dirtyUpdate_b__41_0_Private_Boolean_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0003CD64 File Offset: 0x0003AF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703907, XrefRangeEnd = 703909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CanUsurp_b__47_1(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr__CanUsurp_b__47_1_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0003CDB4 File Offset: 0x0003AFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703909, XrefRangeEnd = 703930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_IHasAttributes_PDM_0(IHasAttributes entity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00008466 File Offset: 0x00006666
		public WormConditionalIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0000846F File Offset: 0x0000666F
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003CE28 File Offset: 0x0003B028
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0000848E File Offset: 0x0000668E
		public unsafe ActivePlayerData activePlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_activePlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivePlayerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_activePlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0003CE58 File Offset: 0x0003B058
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000084AD File Offset: 0x000066AD
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003CE88 File Offset: 0x0003B088
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000084CC File Offset: 0x000066CC
		public unsafe ReadOnlyVersionedList<EntityComponent> imperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_imperiumRow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr_imperiumRow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000084EB File Offset: 0x000066EB
		public unsafe AccountID _LocalPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__LocalPlayerID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__LocalPlayerID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0000850A File Offset: 0x0000670A
		public unsafe DBGEntitiesProvider _EntitiesProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__EntitiesProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__EntitiesProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0003CF18 File Offset: 0x0003B118
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00008529 File Offset: 0x00006729
		public unsafe ReadOnlyVersionedList<EntityComponent> _LocalHand_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__LocalHand_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__LocalHand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0003CF48 File Offset: 0x0003B148
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00008548 File Offset: 0x00006748
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> _PlayAreas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__PlayAreas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__PlayAreas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003CF78 File Offset: 0x0003B178
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00008567 File Offset: 0x00006767
		public unsafe Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>> _ActiveAgentAreas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__ActiveAgentAreas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, ReadOnlyVersionedList<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__ActiveAgentAreas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00008586 File Offset: 0x00006786
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000085A1 File Offset: 0x000067A1
		public unsafe bool _ShowIcons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__ShowIcons_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.NativeFieldInfoPtr__ShowIcons_k__BackingField)) = value;
			}
		}

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_activePlayerData;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_imperiumRow;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerID_k__BackingField;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr__EntitiesProvider_k__BackingField;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr__LocalHand_k__BackingField;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr__PlayAreas_k__BackingField;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAgentAreas_k__BackingField;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr__ShowIcons_k__BackingField;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerID_Protected_get_AccountID_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_AccountID_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_EntitiesProvider_Protected_get_DBGEntitiesProvider_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_set_EntitiesProvider_Private_set_Void_DBGEntitiesProvider_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalHand_Protected_get_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalHand_Private_set_Void_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAgentAreas_Protected_get_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAgentAreas_Private_set_Void_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Protected_get_EntityID_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowIcons_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_set_ShowIcons_Private_set_Void_Boolean_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPiles_Protected_Dictionary_2_AccountID_ReadOnlyVersionedList_1_EntityComponent_String_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_ShowIconsOnTurn_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_InHand_Protected_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_InActiveArea_Protected_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_CurrentChoice_Protected_ISelectionNode_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_CanUsurp_Protected_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_IsGraft_Protected_Static_Boolean_IHasAttributes_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_SetShowIcons_Private_Void_Boolean_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__41_0_Private_Boolean_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr__CanUsurp_b__47_1_Private_Boolean_EntityID_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_IHasAttributes_PDM_0;

		// Token: 0x0200036B RID: 875
		[ObfuscatedName("worm.match.dataRenderers.WormConditionalIconRenderer+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002347 RID: 9031 RVA: 0x00013B54 File Offset: 0x00011D54
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormConditionalIconRenderer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConditionalIconRenderer.__O>.NativeClassPtr);
				WormConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsUsurp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__O>.NativeClassPtr, "<0>__IsUsurp");
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x00013B88 File Offset: 0x00011D88
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x06002349 RID: 9033 RVA: 0x000832F0 File Offset: 0x000814F0
			// (set) Token: 0x0600234A RID: 9034 RVA: 0x00013B91 File Offset: 0x00011D91
			public unsafe static Func<EntityComponent, bool> _0___IsUsurp
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsUsurp, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConditionalIconRenderer.__O.NativeFieldInfoPtr__0___IsUsurp, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001445 RID: 5189
			private static readonly IntPtr NativeFieldInfoPtr__0___IsUsurp;
		}

		// Token: 0x0200036C RID: 876
		[ObfuscatedName("worm.match.dataRenderers.WormConditionalIconRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600234B RID: 9035 RVA: 0x00083318 File Offset: 0x00081518
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr);
				WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, "<>9");
				WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, "<>9__42_1");
				WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, "<>9__42_2");
				WormConditionalIconRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, 100664964);
				WormConditionalIconRenderer.__c.NativeMethodInfoPtr__GetPlayerPiles_b__42_1_Internal_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, 100664965);
				WormConditionalIconRenderer.__c.NativeMethodInfoPtr__GetPlayerPiles_b__42_2_Internal_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr, 100664966);
			}

			// Token: 0x0600234C RID: 9036 RVA: 0x000833BC File Offset: 0x000815BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConditionalIconRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600234D RID: 9037 RVA: 0x000833F8 File Offset: 0x000815F8
			[CallerCount(0)]
			public unsafe AccountID _GetPlayerPiles_b__42_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.__c.NativeMethodInfoPtr__GetPlayerPiles_b__42_1_Internal_AccountID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600234E RID: 9038 RVA: 0x00083448 File Offset: 0x00081648
			[CallerCount(0)]
			public unsafe ReadOnlyVersionedList<EntityComponent> _GetPlayerPiles_b__42_2(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.__c.NativeMethodInfoPtr__GetPlayerPiles_b__42_2_Internal_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr3) : null;
				}
			}

			// Token: 0x0600234F RID: 9039 RVA: 0x00013BA3 File Offset: 0x00011DA3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x06002350 RID: 9040 RVA: 0x00083498 File Offset: 0x00081698
			// (set) Token: 0x06002351 RID: 9041 RVA: 0x00013BAC File Offset: 0x00011DAC
			public unsafe static WormConditionalIconRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConditionalIconRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x06002352 RID: 9042 RVA: 0x000834C0 File Offset: 0x000816C0
			// (set) Token: 0x06002353 RID: 9043 RVA: 0x00013BBE File Offset: 0x00011DBE
			public unsafe static Func<EntityComponent, AccountID> __9__42_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x06002354 RID: 9044 RVA: 0x000834E8 File Offset: 0x000816E8
			// (set) Token: 0x06002355 RID: 9045 RVA: 0x00013BD0 File Offset: 0x00011DD0
			public unsafe static Func<EntityComponent, ReadOnlyVersionedList<EntityComponent>> __9__42_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, ReadOnlyVersionedList<EntityComponent>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConditionalIconRenderer.__c.NativeFieldInfoPtr___9__42_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001446 RID: 5190
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001447 RID: 5191
			private static readonly IntPtr NativeFieldInfoPtr___9__42_1;

			// Token: 0x04001448 RID: 5192
			private static readonly IntPtr NativeFieldInfoPtr___9__42_2;

			// Token: 0x04001449 RID: 5193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400144A RID: 5194
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPiles_b__42_1_Internal_AccountID_EntityComponent_0;

			// Token: 0x0400144B RID: 5195
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPiles_b__42_2_Internal_ReadOnlyVersionedList_1_EntityComponent_EntityComponent_0;
		}

		// Token: 0x0200036D RID: 877
		[ObfuscatedName("worm.match.dataRenderers.WormConditionalIconRenderer+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Object
		{
			// Token: 0x06002356 RID: 9046 RVA: 0x00083510 File Offset: 0x00081710
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr);
				WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr, "entityName");
				WormConditionalIconRenderer.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr, 100664967);
				WormConditionalIconRenderer.__c__DisplayClass42_0.NativeMethodInfoPtr__GetPlayerPiles_b__0_Internal_EntityComponent_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr, 100664968);
			}

			// Token: 0x06002357 RID: 9047 RVA: 0x0008358C File Offset: 0x0008178C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConditionalIconRenderer.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002358 RID: 9048 RVA: 0x000835C8 File Offset: 0x000817C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703717, XrefRangeEnd = 703720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityComponent _GetPlayerPiles_b__0(AccountID a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeMethodInfoPtr__GetPlayerPiles_b__0_Internal_EntityComponent_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x00013BE2 File Offset: 0x00011DE2
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x0600235A RID: 9050 RVA: 0x00083618 File Offset: 0x00081818
			// (set) Token: 0x0600235B RID: 9051 RVA: 0x00013BEB File Offset: 0x00011DEB
			public unsafe WormConditionalIconRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConditionalIconRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x0600235C RID: 9052 RVA: 0x00083648 File Offset: 0x00081848
			// (set) Token: 0x0600235D RID: 9053 RVA: 0x00013C0A File Offset: 0x00011E0A
			public unsafe string entityName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr_entityName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer.__c__DisplayClass42_0.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400144C RID: 5196
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400144D RID: 5197
			private static readonly IntPtr NativeFieldInfoPtr_entityName;

			// Token: 0x0400144E RID: 5198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400144F RID: 5199
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerPiles_b__0_Internal_EntityComponent_AccountID_0;
		}

		// Token: 0x0200036E RID: 878
		[ObfuscatedName("worm.match.dataRenderers.WormConditionalIconRenderer+<Init>d__39")]
		public sealed class _Init_d__39 : Object
		{
			// Token: 0x0600235E RID: 9054 RVA: 0x00083670 File Offset: 0x00081870
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__39()
			{
				Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConditionalIconRenderer>.NativeClassPtr, "<Init>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr);
				WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, "<>1__state");
				WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, "<>2__current");
				WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, "<>4__this");
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664969);
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664970);
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664971);
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664972);
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664973);
				WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr, 100664974);
			}

			// Token: 0x0600235F RID: 9055 RVA: 0x00083750 File Offset: 0x00081950
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConditionalIconRenderer._Init_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002360 RID: 9056 RVA: 0x00083798 File Offset: 0x00081998
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x000837CC File Offset: 0x000819CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703720, XrefRangeEnd = 703731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x06002362 RID: 9058 RVA: 0x00083808 File Offset: 0x00081A08
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x00083848 File Offset: 0x00081A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703731, XrefRangeEnd = 703736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x06002364 RID: 9060 RVA: 0x0008387C File Offset: 0x00081A7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConditionalIconRenderer._Init_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002365 RID: 9061 RVA: 0x00013C29 File Offset: 0x00011E29
			public _Init_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x06002366 RID: 9062 RVA: 0x000838BC File Offset: 0x00081ABC
			// (set) Token: 0x06002367 RID: 9063 RVA: 0x00013C32 File Offset: 0x00011E32
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x06002368 RID: 9064 RVA: 0x000838E4 File Offset: 0x00081AE4
			// (set) Token: 0x06002369 RID: 9065 RVA: 0x00013C4D File Offset: 0x00011E4D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x0600236A RID: 9066 RVA: 0x00083914 File Offset: 0x00081B14
			// (set) Token: 0x0600236B RID: 9067 RVA: 0x00013C6C File Offset: 0x00011E6C
			public unsafe WormConditionalIconRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConditionalIconRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConditionalIconRenderer._Init_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001450 RID: 5200
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001451 RID: 5201
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001452 RID: 5202
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001453 RID: 5203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001454 RID: 5204
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001455 RID: 5205
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001456 RID: 5206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001457 RID: 5207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001458 RID: 5208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

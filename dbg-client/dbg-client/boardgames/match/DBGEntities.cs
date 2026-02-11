using System;
using boardgames.match.data;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match
{
	// Token: 0x02000246 RID: 582
	public class DBGEntities : Entities
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x00072B8C File Offset: 0x00070D8C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntities()
		{
			Il2CppClassPointerStore<DBGEntities>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match", "DBGEntities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr);
			DBGEntities.NativeFieldInfoPtr_AllEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "AllEntities");
			DBGEntities.NativeFieldInfoPtr_TempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "TempEntities");
			DBGEntities.NativeFieldInfoPtr_PlayerAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "PlayerAccounts");
			DBGEntities.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "Players");
			DBGEntities.NativeFieldInfoPtr_PlayersByAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "PlayersByAccountID");
			DBGEntities.NativeFieldInfoPtr__Camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<Camera>k__BackingField");
			DBGEntities.NativeFieldInfoPtr_playmatPileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "playmatPileMap");
			DBGEntities.NativeFieldInfoPtr_playerPileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "playerPileMap");
			DBGEntities.NativeFieldInfoPtr_observedPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "observedPlayerID");
			DBGEntities.NativeFieldInfoPtr__SelectionFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<SelectionFilters>k__BackingField");
			DBGEntities.NativeFieldInfoPtr_emptyAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "emptyAttributes");
			DBGEntities.NativeMethodInfoPtr_get_Camera_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667460);
			DBGEntities.NativeMethodInfoPtr_set_Camera_Protected_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667461);
			DBGEntities.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667462);
			DBGEntities.NativeMethodInfoPtr_GetClonedTempEntities_Public_IEnumerable_1_EntityComponent_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667463);
			DBGEntities.NativeMethodInfoPtr_get_SelectionFilters_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667464);
			DBGEntities.NativeMethodInfoPtr_set_SelectionFilters_Protected_set_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667465);
			DBGEntities.NativeMethodInfoPtr_setActivePlayer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667466);
			DBGEntities.NativeMethodInfoPtr_add_Protected_Virtual_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667467);
			DBGEntities.NativeMethodInfoPtr_remove_Protected_Virtual_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667468);
			DBGEntities.NativeMethodInfoPtr_isEntityNamed_Public_Static_Boolean_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667469);
			DBGEntities.NativeMethodInfoPtr_createEntity_Protected_Virtual_EntityComponent_EntityID_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667470);
			DBGEntities.NativeMethodInfoPtr_configureEntity_Protected_Virtual_New_Void_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667471);
			DBGEntities.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667472);
			DBGEntities.NativeMethodInfoPtr_SetActiveLocalPlayer_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667473);
			DBGEntities.NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667474);
			DBGEntities.NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Virtual_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667475);
			DBGEntities.NativeMethodInfoPtr_GetObservedPlayerID_Public_Virtual_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667476);
			DBGEntities.NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_EntityComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667477);
			DBGEntities.NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Virtual_Int32_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667478);
			DBGEntities.NativeMethodInfoPtr_AddPlaymatPile_Protected_Void_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667479);
			DBGEntities.NativeMethodInfoPtr_GetPlaymatPile_Public_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667480);
			DBGEntities.NativeMethodInfoPtr_GetPlaymatPile_Public_Virtual_EntityComponent_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667481);
			DBGEntities.NativeMethodInfoPtr_GetPlaymatPileNames_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667482);
			DBGEntities.NativeMethodInfoPtr_AddPlayerPile_Protected_Void_AccountID_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667483);
			DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667484);
			DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667485);
			DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_Virtual_EntityComponent_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667486);
			DBGEntities.NativeMethodInfoPtr_GetPileForPlayer_Private_EntityComponent_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667487);
			DBGEntities.NativeMethodInfoPtr_GetPlayerPileNames_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667488);
			DBGEntities.NativeMethodInfoPtr_GetSelectionFilterForActivePlayer_Public_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667489);
			DBGEntities.NativeMethodInfoPtr_reorderPlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667490);
			DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667491);
			DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667492);
			DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, 100667493);
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00072F40 File Offset: 0x00071140
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00072F80 File Offset: 0x00071180
		public unsafe EntityComponent Camera
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_get_Camera_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_set_Camera_Protected_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00072FC4 File Offset: 0x000711C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 531520, RefRangeEnd = 531522, XrefRangeStart = 531464, XrefRangeEnd = 531520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGEntities(Il2CppReferenceArray<AccountID> playerAccounts, SerializedEntity playmat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAccounts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playmat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00073024 File Offset: 0x00071224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531522, XrefRangeEnd = 531529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityComponent> GetClonedTempEntities(EntityID originalID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetClonedTempEntities_Public_IEnumerable_1_EntityComponent_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00073074 File Offset: 0x00071274
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x000730B4 File Offset: 0x000712B4
		public unsafe EntityComponent SelectionFilters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_get_SelectionFilters_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_set_SelectionFilters_Protected_set_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000730F8 File Offset: 0x000712F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531529, XrefRangeEnd = 531588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setActivePlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_setActivePlayer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00073134 File Offset: 0x00071334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531588, XrefRangeEnd = 531592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_add_Protected_Virtual_Void_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00073184 File Offset: 0x00071384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531592, XrefRangeEnd = 531627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove(EntityID entityIDToRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIDToRemove);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_remove_Protected_Virtual_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000731D4 File Offset: 0x000713D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 531639, RefRangeEnd = 531644, XrefRangeStart = 531627, XrefRangeEnd = 531639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isEntityNamed(EntityComponent entity, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_isEntityNamed_Public_Static_Boolean_EntityComponent_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00073228 File Offset: 0x00071428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531644, XrefRangeEnd = 531674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent createEntity(EntityID id, AccountID owningPlayerID, EntityComponent parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayerID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_createEntity_Protected_Virtual_EntityComponent_EntityID_AccountID_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000732A8 File Offset: 0x000714A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configureEntity(EntityComponent entity, EntityComponent parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_configureEntity_Protected_Virtual_New_Void_EntityComponent_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00073308 File Offset: 0x00071508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531740, RefRangeEnd = 531741, XrefRangeStart = 531674, XrefRangeEnd = 531740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void introduce(EntityComponent entity, ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00073368 File Offset: 0x00071568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531746, RefRangeEnd = 531747, XrefRangeStart = 531741, XrefRangeEnd = 531746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveLocalPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_SetActiveLocalPlayer_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x000733AC File Offset: 0x000715AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531747, XrefRangeEnd = 531752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent GetActiveLocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000733F8 File Offset: 0x000715F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531752, XrefRangeEnd = 531755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AccountID GetActiveLocalPlayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Virtual_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00073444 File Offset: 0x00071644
		[CallerCount(0)]
		public unsafe override AccountID GetObservedPlayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetObservedPlayerID_Public_Virtual_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00073490 File Offset: 0x00071690
		[CallerCount(0)]
		public unsafe override EntityComponent GetPlayerByIndex(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_EntityComponent_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000734E8 File Offset: 0x000716E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531755, XrefRangeEnd = 531758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetPlayerIndexForAccountID(AccountID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Virtual_Int32_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00073540 File Offset: 0x00071740
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 531762, RefRangeEnd = 531765, XrefRangeStart = 531758, XrefRangeEnd = 531762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlaymatPile(string pile, EntityComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_AddPlaymatPile_Protected_Void_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00073594 File Offset: 0x00071794
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 531765, RefRangeEnd = 531782, XrefRangeStart = 531765, XrefRangeEnd = 531765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPlaymatPile(string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPlaymatPile_Public_EntityComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x000735E4 File Offset: 0x000717E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531782, XrefRangeEnd = 531799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent GetPlaymatPile(string pile, bool failSilently)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failSilently;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetPlaymatPile_Public_Virtual_EntityComponent_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00073650 File Offset: 0x00071850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531799, XrefRangeEnd = 531806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetPlaymatPileNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPlaymatPileNames_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00073690 File Offset: 0x00071890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531825, RefRangeEnd = 531826, XrefRangeStart = 531806, XrefRangeEnd = 531825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerPile(AccountID accountID, string pile, EntityComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_AddPlayerPile_Protected_Void_AccountID_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000736F8 File Offset: 0x000718F8
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 531827, RefRangeEnd = 531856, XrefRangeStart = 531826, XrefRangeEnd = 531827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPlayerPile(AccountID playerID, string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0007375C File Offset: 0x0007195C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 531866, RefRangeEnd = 531874, XrefRangeStart = 531856, XrefRangeEnd = 531866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPlayerPile(AccountID playerID, string pile, bool failSilently)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failSilently;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000737CC File Offset: 0x000719CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531874, XrefRangeEnd = 531881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent GetPlayerPile(int playerIndex, string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_GetPlayerPile_Public_Virtual_EntityComponent_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00073838 File Offset: 0x00071A38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 531896, RefRangeEnd = 531899, XrefRangeStart = 531881, XrefRangeEnd = 531896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPileForPlayer(EntityComponent player, string pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPileForPlayer_Private_EntityComponent_EntityComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0007389C File Offset: 0x00071A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531899, XrefRangeEnd = 531933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetPlayerPileNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetPlayerPileNames_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000738DC File Offset: 0x00071ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531938, RefRangeEnd = 531939, XrefRangeStart = 531933, XrefRangeEnd = 531938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetSelectionFilterForActivePlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_GetSelectionFilterForActivePlayer_Public_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007391C File Offset: 0x00071B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531962, RefRangeEnd = 531963, XrefRangeStart = 531939, XrefRangeEnd = 531962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void reorderPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.NativeMethodInfoPtr_reorderPlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00073950 File Offset: 0x00071B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531963, XrefRangeEnd = 531975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent CreateTemporaryEntity(string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000739AC File Offset: 0x00071BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531975, XrefRangeEnd = 531989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent CreateTemporaryEntity(string entityName, EntityComponent other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00073A1C File Offset: 0x00071C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531989, XrefRangeEnd = 532001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent CreateTemporaryEntity(string entityName, ReadOnlyAttributes attributes, AccountID owner = null, EntityID parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntities.NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0000E60A File Offset: 0x0000C80A
		public DBGEntities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00073AB0 File Offset: 0x00071CB0
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000E613 File Offset: 0x0000C813
		public unsafe Dictionary<EntityID, EntityComponent> AllEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_AllEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_AllEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00073AE0 File Offset: 0x00071CE0
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000E632 File Offset: 0x0000C832
		public unsafe List<EntityComponent> TempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_TempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_TempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00073B10 File Offset: 0x00071D10
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000E651 File Offset: 0x0000C851
		public unsafe Il2CppReferenceArray<AccountID> PlayerAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_PlayerAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_PlayerAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00073B40 File Offset: 0x00071D40
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000E670 File Offset: 0x0000C870
		public unsafe Il2CppReferenceArray<EntityComponent> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00073B70 File Offset: 0x00071D70
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000E68F File Offset: 0x0000C88F
		public unsafe Dictionary<AccountID, EntityComponent> PlayersByAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_PlayersByAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_PlayersByAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00073BA0 File Offset: 0x00071DA0
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000E6AE File Offset: 0x0000C8AE
		public unsafe EntityComponent _Camera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr__Camera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr__Camera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00073BD0 File Offset: 0x00071DD0
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000E6CD File Offset: 0x0000C8CD
		public unsafe Dictionary<string, EntityComponent> playmatPileMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_playmatPileMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_playmatPileMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00073C00 File Offset: 0x00071E00
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		public unsafe Dictionary<AccountID, Dictionary<string, EntityComponent>> playerPileMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_playerPileMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, Dictionary<string, EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_playerPileMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00073C30 File Offset: 0x00071E30
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0000E70B File Offset: 0x0000C90B
		public unsafe AccountID observedPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_observedPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_observedPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00073C60 File Offset: 0x00071E60
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000E72A File Offset: 0x0000C92A
		public unsafe EntityComponent _SelectionFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr__SelectionFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr__SelectionFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x00073C90 File Offset: 0x00071E90
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000E749 File Offset: 0x0000C949
		public unsafe ReadOnlyAttributes emptyAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_emptyAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.NativeFieldInfoPtr_emptyAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_AllEntities;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_TempEntities;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccounts;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_PlayersByAccountID;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr__Camera_k__BackingField;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_playmatPileMap;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_playerPileMap;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr_observedPlayerID;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr__SelectionFilters_k__BackingField;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeFieldInfoPtr_emptyAttributes;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_get_EntityComponent_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_set_Camera_Protected_set_Void_EntityComponent_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_GetClonedTempEntities_Public_IEnumerable_1_EntityComponent_EntityID_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionFilters_Public_get_EntityComponent_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionFilters_Protected_set_Void_EntityComponent_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_setActivePlayer_Protected_Virtual_New_Void_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_add_Protected_Virtual_Void_EntityComponent_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_remove_Protected_Virtual_Void_EntityID_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_isEntityNamed_Public_Static_Boolean_EntityComponent_String_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_createEntity_Protected_Virtual_EntityComponent_EntityID_AccountID_EntityComponent_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_configureEntity_Protected_Virtual_New_Void_EntityComponent_EntityComponent_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveLocalPlayer_Public_Void_AccountID_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocalPlayer_Public_Virtual_EntityComponent_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveLocalPlayerID_Public_Virtual_AccountID_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_GetObservedPlayerID_Public_Virtual_AccountID_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_EntityComponent_Int32_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndexForAccountID_Public_Virtual_Int32_AccountID_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_AddPlaymatPile_Protected_Void_String_EntityComponent_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaymatPile_Public_EntityComponent_String_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaymatPile_Public_Virtual_EntityComponent_String_Boolean_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaymatPileNames_Public_List_1_String_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerPile_Protected_Void_AccountID_String_EntityComponent_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPile_Public_EntityComponent_AccountID_String_Boolean_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPile_Public_Virtual_EntityComponent_Int32_String_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_GetPileForPlayer_Private_EntityComponent_EntityComponent_String_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPileNames_Public_List_1_String_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionFilterForActivePlayer_Public_EntityComponent_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_reorderPlayers_Private_Void_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_EntityComponent_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryEntity_Public_Virtual_EntityComponent_String_ReadOnlyAttributes_AccountID_EntityID_0;

		// Token: 0x02000432 RID: 1074
		[ObfuscatedName("boardgames.match.DBGEntities+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060032D7 RID: 13015 RVA: 0x000C02DC File Offset: 0x000BE4DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr);
				DBGEntities.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr, "<>9");
				DBGEntities.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr, "<>9__18_1");
				DBGEntities.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr, 100667495);
				DBGEntities.__c.NativeMethodInfoPtr__setActivePlayer_b__18_1_Internal_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr, 100667496);
			}

			// Token: 0x060032D8 RID: 13016 RVA: 0x000C0358 File Offset: 0x000BE558
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032D9 RID: 13017 RVA: 0x000C0394 File Offset: 0x000BE594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531399, XrefRangeEnd = 531401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _setActivePlayer_b__18_1(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c.NativeMethodInfoPtr__setActivePlayer_b__18_1_Internal_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060032DA RID: 13018 RVA: 0x0001A42B File Offset: 0x0001862B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED3 RID: 3795
			// (get) Token: 0x060032DB RID: 13019 RVA: 0x000C03DC File Offset: 0x000BE5DC
			// (set) Token: 0x060032DC RID: 13020 RVA: 0x0001A434 File Offset: 0x00018634
			public unsafe static DBGEntities.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGEntities.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGEntities.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x060032DD RID: 13021 RVA: 0x000C0404 File Offset: 0x000BE604
			// (set) Token: 0x060032DE RID: 13022 RVA: 0x0001A446 File Offset: 0x00018646
			public unsafe static Func<EntityComponent, string> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGEntities.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGEntities.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F62 RID: 8034
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F63 RID: 8035
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04001F64 RID: 8036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F65 RID: 8037
			private static readonly IntPtr NativeMethodInfoPtr__setActivePlayer_b__18_1_Internal_String_EntityComponent_0;
		}

		// Token: 0x02000433 RID: 1075
		[ObfuscatedName("boardgames.match.DBGEntities+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x060032DF RID: 13023 RVA: 0x000C042C File Offset: 0x000BE62C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr);
				DBGEntities.__c__DisplayClass18_0.NativeFieldInfoPtr_activePlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr, "activePlayerData");
				DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr, 100667497);
				DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__setActivePlayer_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr, 100667498);
				DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__setActivePlayer_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr, 100667499);
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x000C04A8 File Offset: 0x000BE6A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032E1 RID: 13025 RVA: 0x000C04E4 File Offset: 0x000BE6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531401, XrefRangeEnd = 531406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setActivePlayer_b__0(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__setActivePlayer_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032E2 RID: 13026 RVA: 0x000C0534 File Offset: 0x000BE734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531406, XrefRangeEnd = 531411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setActivePlayer_b__2(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass18_0.NativeMethodInfoPtr__setActivePlayer_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032E3 RID: 13027 RVA: 0x0001A458 File Offset: 0x00018658
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000C0584 File Offset: 0x000BE784
			// (set) Token: 0x060032E5 RID: 13029 RVA: 0x0001A461 File Offset: 0x00018661
			public unsafe ActivePlayerData activePlayerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass18_0.NativeFieldInfoPtr_activePlayerData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivePlayerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass18_0.NativeFieldInfoPtr_activePlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F66 RID: 8038
			private static readonly IntPtr NativeFieldInfoPtr_activePlayerData;

			// Token: 0x04001F67 RID: 8039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F68 RID: 8040
			private static readonly IntPtr NativeMethodInfoPtr__setActivePlayer_b__0_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001F69 RID: 8041
			private static readonly IntPtr NativeMethodInfoPtr__setActivePlayer_b__2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000434 RID: 1076
		[ObfuscatedName("boardgames.match.DBGEntities+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x060032E6 RID: 13030 RVA: 0x000C05B4 File Offset: 0x000BE7B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr);
				DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr_entityIDToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr, "entityIDToRemove");
				DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr, "<>9__0");
				DBGEntities.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr, 100667500);
				DBGEntities.__c__DisplayClass20_0.NativeMethodInfoPtr__remove_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr, 100667501);
			}

			// Token: 0x060032E7 RID: 13031 RVA: 0x000C0630 File Offset: 0x000BE830
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032E8 RID: 13032 RVA: 0x000C066C File Offset: 0x000BE86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531411, XrefRangeEnd = 531416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _remove_b__0(EntityComponent entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass20_0.NativeMethodInfoPtr__remove_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032E9 RID: 13033 RVA: 0x0001A480 File Offset: 0x00018680
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x060032EA RID: 13034 RVA: 0x000C06BC File Offset: 0x000BE8BC
			// (set) Token: 0x060032EB RID: 13035 RVA: 0x0001A489 File Offset: 0x00018689
			public unsafe EntityID entityIDToRemove
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr_entityIDToRemove);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr_entityIDToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x060032EC RID: 13036 RVA: 0x000C06EC File Offset: 0x000BE8EC
			// (set) Token: 0x060032ED RID: 13037 RVA: 0x0001A4A8 File Offset: 0x000186A8
			public unsafe Func<EntityComponent, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass20_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F6A RID: 8042
			private static readonly IntPtr NativeFieldInfoPtr_entityIDToRemove;

			// Token: 0x04001F6B RID: 8043
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001F6C RID: 8044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F6D RID: 8045
			private static readonly IntPtr NativeMethodInfoPtr__remove_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000435 RID: 1077
		[ObfuscatedName("boardgames.match.DBGEntities+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x060032EE RID: 13038 RVA: 0x000C071C File Offset: 0x000BE91C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr);
				DBGEntities.__c__DisplayClass33_0.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr, "pile");
				DBGEntities.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr, 100667502);
				DBGEntities.__c__DisplayClass33_0.NativeMethodInfoPtr__GetPlaymatPile_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr, 100667503);
			}

			// Token: 0x060032EF RID: 13039 RVA: 0x000C0784 File Offset: 0x000BE984
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032F0 RID: 13040 RVA: 0x000C07C0 File Offset: 0x000BE9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531416, XrefRangeEnd = 531417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPlaymatPile_b__0(EntityComponent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass33_0.NativeMethodInfoPtr__GetPlaymatPile_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032F1 RID: 13041 RVA: 0x0001A4C7 File Offset: 0x000186C7
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED8 RID: 3800
			// (get) Token: 0x060032F2 RID: 13042 RVA: 0x000C0810 File Offset: 0x000BEA10
			// (set) Token: 0x060032F3 RID: 13043 RVA: 0x0001A4D0 File Offset: 0x000186D0
			public unsafe string pile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass33_0.NativeFieldInfoPtr_pile);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass33_0.NativeFieldInfoPtr_pile), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001F6E RID: 8046
			private static readonly IntPtr NativeFieldInfoPtr_pile;

			// Token: 0x04001F6F RID: 8047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F70 RID: 8048
			private static readonly IntPtr NativeMethodInfoPtr__GetPlaymatPile_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000436 RID: 1078
		[ObfuscatedName("boardgames.match.DBGEntities+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Object
		{
			// Token: 0x060032F4 RID: 13044 RVA: 0x000C0838 File Offset: 0x000BEA38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr);
				DBGEntities.__c__DisplayClass39_0.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr, "pile");
				DBGEntities.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr, 100667504);
				DBGEntities.__c__DisplayClass39_0.NativeMethodInfoPtr__GetPileForPlayer_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr, 100667505);
			}

			// Token: 0x060032F5 RID: 13045 RVA: 0x000C08A0 File Offset: 0x000BEAA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032F6 RID: 13046 RVA: 0x000C08DC File Offset: 0x000BEADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPileForPlayer_b__0(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities.__c__DisplayClass39_0.NativeMethodInfoPtr__GetPileForPlayer_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060032F7 RID: 13047 RVA: 0x0001A4EF File Offset: 0x000186EF
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED9 RID: 3801
			// (get) Token: 0x060032F8 RID: 13048 RVA: 0x000C092C File Offset: 0x000BEB2C
			// (set) Token: 0x060032F9 RID: 13049 RVA: 0x0001A4F8 File Offset: 0x000186F8
			public unsafe string pile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass39_0.NativeFieldInfoPtr_pile);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities.__c__DisplayClass39_0.NativeFieldInfoPtr_pile), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001F71 RID: 8049
			private static readonly IntPtr NativeFieldInfoPtr_pile;

			// Token: 0x04001F72 RID: 8050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F73 RID: 8051
			private static readonly IntPtr NativeMethodInfoPtr__GetPileForPlayer_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000437 RID: 1079
		[ObfuscatedName("boardgames.match.DBGEntities+<GetClonedTempEntities>d__13")]
		public sealed class _GetClonedTempEntities_d__13 : Object
		{
			// Token: 0x060032FA RID: 13050 RVA: 0x000C0954 File Offset: 0x000BEB54
			// Note: this type is marked as 'beforefieldinit'.
			static _GetClonedTempEntities_d__13()
			{
				Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntities>.NativeClassPtr, "<GetClonedTempEntities>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr);
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>1__state");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>2__current");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>l__initialThreadId");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>4__this");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr_originalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "originalID");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___3__originalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>3__originalID");
				DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, "<>7__wrap1");
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667506);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667507);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667508);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667509);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_EntityComponent__get_Current_Private_Virtual_Final_New_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667510);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667511);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667512);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_EntityComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667513);
				DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr, 100667514);
			}

			// Token: 0x060032FB RID: 13051 RVA: 0x000C0AC0 File Offset: 0x000BECC0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetClonedTempEntities_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntities._GetClonedTempEntities_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032FC RID: 13052 RVA: 0x000C0B08 File Offset: 0x000BED08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 531422, RefRangeEnd = 531423, XrefRangeStart = 531417, XrefRangeEnd = 531422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032FD RID: 13053 RVA: 0x000C0B3C File Offset: 0x000BED3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531423, XrefRangeEnd = 531447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060032FE RID: 13054 RVA: 0x000C0B78 File Offset: 0x000BED78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531447, XrefRangeEnd = 531450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x060032FF RID: 13055 RVA: 0x000C0BAC File Offset: 0x000BEDAC
			public unsafe EntityComponent System.Collections.Generic.IEnumerator<dwd.core.match.EntityComponent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_EntityComponent__get_Current_Private_Virtual_Final_New_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06003300 RID: 13056 RVA: 0x000C0BEC File Offset: 0x000BEDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531450, XrefRangeEnd = 531455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x06003301 RID: 13057 RVA: 0x000C0C20 File Offset: 0x000BEE20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003302 RID: 13058 RVA: 0x000C0C60 File Offset: 0x000BEE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531455, XrefRangeEnd = 531464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<EntityComponent> System_Collections_Generic_IEnumerable_dwd_core_match_EntityComponent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_EntityComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<EntityComponent>>(intPtr3) : null;
			}

			// Token: 0x06003303 RID: 13059 RVA: 0x000C0CA0 File Offset: 0x000BEEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntities._GetClonedTempEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003304 RID: 13060 RVA: 0x0001A517 File Offset: 0x00018717
			public _GetClonedTempEntities_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x06003305 RID: 13061 RVA: 0x000C0CE0 File Offset: 0x000BEEE0
			// (set) Token: 0x06003306 RID: 13062 RVA: 0x0001A520 File Offset: 0x00018720
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x06003307 RID: 13063 RVA: 0x000C0D08 File Offset: 0x000BEF08
			// (set) Token: 0x06003308 RID: 13064 RVA: 0x0001A53B File Offset: 0x0001873B
			public unsafe EntityComponent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x06003309 RID: 13065 RVA: 0x000C0D38 File Offset: 0x000BEF38
			// (set) Token: 0x0600330A RID: 13066 RVA: 0x0001A55A File Offset: 0x0001875A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x0600330B RID: 13067 RVA: 0x000C0D60 File Offset: 0x000BEF60
			// (set) Token: 0x0600330C RID: 13068 RVA: 0x0001A575 File Offset: 0x00018775
			public unsafe DBGEntities __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EDE RID: 3806
			// (get) Token: 0x0600330D RID: 13069 RVA: 0x000C0D90 File Offset: 0x000BEF90
			// (set) Token: 0x0600330E RID: 13070 RVA: 0x0001A594 File Offset: 0x00018794
			public unsafe EntityID originalID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr_originalID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr_originalID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EDF RID: 3807
			// (get) Token: 0x0600330F RID: 13071 RVA: 0x000C0DC0 File Offset: 0x000BEFC0
			// (set) Token: 0x06003310 RID: 13072 RVA: 0x0001A5B3 File Offset: 0x000187B3
			public unsafe EntityID __3__originalID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___3__originalID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___3__originalID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06003311 RID: 13073 RVA: 0x000C0DF0 File Offset: 0x000BEFF0
			// (set) Token: 0x06003312 RID: 13074 RVA: 0x0001A5D2 File Offset: 0x000187D2
			public List<EntityComponent>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___7__wrap1);
					return new List<EntityComponent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<EntityComponent>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntities._GetClonedTempEntities_d__13.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<EntityComponent>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001F74 RID: 8052
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F75 RID: 8053
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F76 RID: 8054
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F77 RID: 8055
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F78 RID: 8056
			private static readonly IntPtr NativeFieldInfoPtr_originalID;

			// Token: 0x04001F79 RID: 8057
			private static readonly IntPtr NativeFieldInfoPtr___3__originalID;

			// Token: 0x04001F7A RID: 8058
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001F7B RID: 8059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F7C RID: 8060
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F7D RID: 8061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F7E RID: 8062
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001F7F RID: 8063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_match_EntityComponent__get_Current_Private_Virtual_Final_New_get_EntityComponent_0;

			// Token: 0x04001F80 RID: 8064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F81 RID: 8065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F82 RID: 8066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_match_EntityComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_EntityComponent_0;

			// Token: 0x04001F83 RID: 8067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

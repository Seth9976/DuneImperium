using System;
using boardgames.match;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm
{
	// Token: 0x02000056 RID: 86
	public class WormEntities : DBGEntities
	{
		// Token: 0x06000366 RID: 870 RVA: 0x000236C8 File Offset: 0x000218C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntities()
		{
			Il2CppClassPointerStore<WormEntities>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormEntities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntities>.NativeClassPtr);
			WormEntities.NativeFieldInfoPtr_playerLeaderMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "playerLeaderMap");
			WormEntities.NativeFieldInfoPtr_troopMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "troopMap");
			WormEntities.NativeFieldInfoPtr_UsableNonDeferredAbilityEntityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "UsableNonDeferredAbilityEntityNames");
			WormEntities.NativeFieldInfoPtr_OnPlayerPileAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "OnPlayerPileAdded");
			WormEntities.NativeFieldInfoPtr__PlayerOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "<PlayerOrder>k__BackingField");
			WormEntities.NativeMethodInfoPtr_get_PlayerOrder_Public_get_IReadOnlyList_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663866);
			WormEntities.NativeMethodInfoPtr_get_PlayerLeaderMap_Public_get_IReadOnlyDictionary_2_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663867);
			WormEntities.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663868);
			WormEntities.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663869);
			WormEntities.NativeMethodInfoPtr_ConfigureSpace_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663870);
			WormEntities.NativeMethodInfoPtr_ConfigurePlaymat_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663871);
			WormEntities.NativeMethodInfoPtr_ConfigurePlaymatPile_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663872);
			WormEntities.NativeMethodInfoPtr_ConfigurePlayer_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663873);
			WormEntities.NativeMethodInfoPtr_ConfigurePlayerPile_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663874);
			WormEntities.NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663875);
			WormEntities.NativeMethodInfoPtr_ConfigureTroop_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663876);
			WormEntities.NativeMethodInfoPtr_ConfigureControlMarker_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663877);
			WormEntities.NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663878);
			WormEntities.NativeMethodInfoPtr_ConfigureToken_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663879);
			WormEntities.NativeMethodInfoPtr_ConfigureFactionTrack_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663880);
			WormEntities.NativeMethodInfoPtr_ConfigureAgent_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663881);
			WormEntities.NativeMethodInfoPtr_AddPlayerLeader_Private_Void_AccountID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663882);
			WormEntities.NativeMethodInfoPtr_GetPlayerLeader_Public_EntityComponent_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663883);
			WormEntities.NativeMethodInfoPtr_GetLeaderByArchID_Public_EntityComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663884);
			WormEntities.NativeMethodInfoPtr_IsUsableNonDeferredAbility_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, 100663885);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000367 RID: 871 RVA: 0x000238EC File Offset: 0x00021AEC
		public unsafe IReadOnlyList<AccountID> PlayerOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_get_PlayerOrder_Public_get_IReadOnlyList_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AccountID>>(intPtr3) : null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0002392C File Offset: 0x00021B2C
		public unsafe IReadOnlyDictionary<AccountID, EntityComponent> PlayerLeaderMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_get_PlayerLeaderMap_Public_get_IReadOnlyDictionary_2_AccountID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<AccountID, EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0002396C File Offset: 0x00021B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692090, XrefRangeEnd = 692108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntities(Il2CppReferenceArray<AccountID> playerAccounts, SerializedEntity playmat)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntities>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerAccounts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playmat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000239CC File Offset: 0x00021BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692108, XrefRangeEnd = 692458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntities.NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00023A2C File Offset: 0x00021C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692508, RefRangeEnd = 692509, XrefRangeStart = 692458, XrefRangeEnd = 692508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureSpace(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureSpace_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00023A70 File Offset: 0x00021C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692509, XrefRangeEnd = 692531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlaymat(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigurePlaymat_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00023AB4 File Offset: 0x00021CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692531, XrefRangeEnd = 692539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlaymatPile(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigurePlaymatPile_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00023AF8 File Offset: 0x00021CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692621, RefRangeEnd = 692622, XrefRangeStart = 692539, XrefRangeEnd = 692621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlayer(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigurePlayer_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00023B3C File Offset: 0x00021D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692622, XrefRangeEnd = 692630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlayerPile(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigurePlayerPile_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00023B80 File Offset: 0x00021D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692690, RefRangeEnd = 692691, XrefRangeStart = 692630, XrefRangeEnd = 692690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureLeader(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00023BC4 File Offset: 0x00021DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692716, RefRangeEnd = 692717, XrefRangeStart = 692691, XrefRangeEnd = 692716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTroop(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureTroop_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00023C08 File Offset: 0x00021E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692725, RefRangeEnd = 692726, XrefRangeStart = 692717, XrefRangeEnd = 692725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureControlMarker(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureControlMarker_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00023C4C File Offset: 0x00021E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692773, RefRangeEnd = 692774, XrefRangeStart = 692726, XrefRangeEnd = 692773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlayable(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00023C90 File Offset: 0x00021E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692789, RefRangeEnd = 692790, XrefRangeStart = 692774, XrefRangeEnd = 692789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureToken(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureToken_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00023CD4 File Offset: 0x00021ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692798, RefRangeEnd = 692799, XrefRangeStart = 692790, XrefRangeEnd = 692798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureFactionTrack(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureFactionTrack_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00023D18 File Offset: 0x00021F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692807, RefRangeEnd = 692808, XrefRangeStart = 692799, XrefRangeEnd = 692807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureAgent(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_ConfigureAgent_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00023D5C File Offset: 0x00021F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 692812, RefRangeEnd = 692813, XrefRangeStart = 692808, XrefRangeEnd = 692812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerLeader(AccountID accountID, EntityComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_AddPlayerLeader_Private_Void_AccountID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00023DB0 File Offset: 0x00021FB0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 692818, RefRangeEnd = 692832, XrefRangeStart = 692813, XrefRangeEnd = 692818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPlayerLeader(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_GetPlayerLeader_Public_EntityComponent_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00023E00 File Offset: 0x00022000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692850, RefRangeEnd = 692852, XrefRangeStart = 692832, XrefRangeEnd = 692850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetLeaderByArchID(ArchetypeID leaderArchID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderArchID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_GetLeaderByArchID_Public_EntityComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00023E50 File Offset: 0x00022050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 692855, RefRangeEnd = 692858, XrefRangeStart = 692852, XrefRangeEnd = 692855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUsableNonDeferredAbility(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.NativeMethodInfoPtr_IsUsableNonDeferredAbility_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000038AC File Offset: 0x00001AAC
		public WormEntities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00023EA0 File Offset: 0x000220A0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000038B5 File Offset: 0x00001AB5
		public unsafe Dictionary<AccountID, EntityComponent> playerLeaderMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_playerLeaderMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_playerLeaderMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00023ED0 File Offset: 0x000220D0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000038D4 File Offset: 0x00001AD4
		public unsafe Dictionary<AccountID, List<EntityComponent>> troopMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_troopMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, List<EntityComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_troopMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00023F00 File Offset: 0x00022100
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000038F3 File Offset: 0x00001AF3
		public unsafe static IReadOnlyList<string> UsableNonDeferredAbilityEntityNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormEntities.NativeFieldInfoPtr_UsableNonDeferredAbilityEntityNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEntities.NativeFieldInfoPtr_UsableNonDeferredAbilityEntityNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00023F28 File Offset: 0x00022128
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003905 File Offset: 0x00001B05
		public unsafe Action<EntityComponent> OnPlayerPileAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_OnPlayerPileAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr_OnPlayerPileAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00023F58 File Offset: 0x00022158
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003924 File Offset: 0x00001B24
		public unsafe IReadOnlyList<AccountID> _PlayerOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr__PlayerOrder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.NativeFieldInfoPtr__PlayerOrder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_playerLeaderMap;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_troopMap;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_UsableNonDeferredAbilityEntityNames;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerPileAdded;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr__PlayerOrder_k__BackingField;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerOrder_Public_get_IReadOnlyList_1_AccountID_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerLeaderMap_Public_get_IReadOnlyDictionary_2_AccountID_EntityComponent_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_SerializedEntity_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_introduce_Protected_Virtual_Void_EntityComponent_ReadOnlyAttributes_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpace_Private_Void_EntityComponent_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlaymat_Private_Void_EntityComponent_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlaymatPile_Private_Void_EntityComponent_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayer_Private_Void_EntityComponent_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayerPile_Private_Void_EntityComponent_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureLeader_Private_Void_EntityComponent_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTroop_Private_Void_EntityComponent_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControlMarker_Private_Void_EntityComponent_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayable_Private_Void_EntityComponent_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureToken_Private_Void_EntityComponent_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureFactionTrack_Private_Void_EntityComponent_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAgent_Private_Void_EntityComponent_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerLeader_Private_Void_AccountID_EntityComponent_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerLeader_Public_EntityComponent_AccountID_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderByArchID_Public_EntityComponent_ArchetypeID_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_IsUsableNonDeferredAbility_Public_Boolean_EntityID_0;

		// Token: 0x020002EB RID: 747
		[ObfuscatedName("worm.WormEntities+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06001E6C RID: 7788 RVA: 0x000754F0 File Offset: 0x000736F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEntities>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr);
				WormEntities.__c__DisplayClass25_0.NativeFieldInfoPtr_leaderArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr, "leaderArchID");
				WormEntities.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr, 100663887);
				WormEntities.__c__DisplayClass25_0.NativeMethodInfoPtr__GetLeaderByArchID_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr, 100663888);
			}

			// Token: 0x06001E6D RID: 7789 RVA: 0x00075558 File Offset: 0x00073758
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntities.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E6E RID: 7790 RVA: 0x00075594 File Offset: 0x00073794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 692075, XrefRangeEnd = 692090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLeaderByArchID_b__0(EntityComponent l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntities.__c__DisplayClass25_0.NativeMethodInfoPtr__GetLeaderByArchID_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E6F RID: 7791 RVA: 0x00011461 File Offset: 0x0000F661
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06001E70 RID: 7792 RVA: 0x000755E4 File Offset: 0x000737E4
			// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0001146A File Offset: 0x0000F66A
			public unsafe ArchetypeID leaderArchID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.__c__DisplayClass25_0.NativeFieldInfoPtr_leaderArchID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntities.__c__DisplayClass25_0.NativeFieldInfoPtr_leaderArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeFieldInfoPtr_leaderArchID;

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeMethodInfoPtr__GetLeaderByArchID_b__0_Internal_Boolean_EntityComponent_0;
		}
	}
}

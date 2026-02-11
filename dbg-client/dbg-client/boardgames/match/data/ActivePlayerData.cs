using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.match.data
{
	// Token: 0x02000275 RID: 629
	public class ActivePlayerData : VersionedDataComponent
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x0007F454 File Offset: 0x0007D654
		// Note: this type is marked as 'beforefieldinit'.
		static ActivePlayerData()
		{
			Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "ActivePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr);
			ActivePlayerData.NativeFieldInfoPtr_currentTurnPlayerAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, "currentTurnPlayerAttribute");
			ActivePlayerData.NativeFieldInfoPtr_currentSelectionPlayerAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, "currentSelectionPlayerAttribute");
			ActivePlayerData.NativeFieldInfoPtr_activeLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, "activeLocalPlayer");
			ActivePlayerData.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, "entities");
			ActivePlayerData.NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_IAttribute_1_AccountID_IAttribute_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668123);
			ActivePlayerData.NativeMethodInfoPtr_get_CurrentTurnPlayerID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668124);
			ActivePlayerData.NativeMethodInfoPtr_get_ActiveLocalPlayerID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668125);
			ActivePlayerData.NativeMethodInfoPtr_set_ActiveLocalPlayerID_Public_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668126);
			ActivePlayerData.NativeMethodInfoPtr_get_LocalPlayerSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668127);
			ActivePlayerData.NativeMethodInfoPtr_get_CurrentTurnPlayer_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668128);
			ActivePlayerData.NativeMethodInfoPtr_get_ActiveLocalPlayer_Public_get_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668129);
			ActivePlayerData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr, 100668130);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0007F574 File Offset: 0x0007D774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536990, RefRangeEnd = 536991, XrefRangeStart = 536986, XrefRangeEnd = 536990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivePlayerData(DBGEntities entities, IAttribute<AccountID> currentTurnPlayerAttribute, IAttribute<AccountID> currentSelectionPlayerAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivePlayerData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTurnPlayerAttribute);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelectionPlayerAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_IAttribute_1_AccountID_IAttribute_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0007F5E4 File Offset: 0x0007D7E4
		public unsafe AccountID CurrentTurnPlayerID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 536995, RefRangeEnd = 537005, XrefRangeStart = 536991, XrefRangeEnd = 536995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_get_CurrentTurnPlayerID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0007F624 File Offset: 0x0007D824
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0007F664 File Offset: 0x0007D864
		public unsafe AccountID ActiveLocalPlayerID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_get_ActiveLocalPlayerID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 514415, RefRangeEnd = 514417, XrefRangeStart = 514415, XrefRangeEnd = 514417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_set_ActiveLocalPlayerID_Public_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0007F6A8 File Offset: 0x0007D8A8
		public unsafe bool LocalPlayerSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537005, XrefRangeEnd = 537013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_get_LocalPlayerSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0007F6E4 File Offset: 0x0007D8E4
		public unsafe EntityComponent CurrentTurnPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537013, XrefRangeEnd = 537018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_get_CurrentTurnPlayer_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0007F724 File Offset: 0x0007D924
		public unsafe EntityComponent ActiveLocalPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537018, XrefRangeEnd = 537020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivePlayerData.NativeMethodInfoPtr_get_ActiveLocalPlayer_Public_get_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0007F764 File Offset: 0x0007D964
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537020, XrefRangeEnd = 537025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivePlayerData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0000F9BD File Offset: 0x0000DBBD
		public ActivePlayerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0007F7AC File Offset: 0x0007D9AC
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0000F9C6 File Offset: 0x0000DBC6
		public unsafe IAttribute<AccountID> currentTurnPlayerAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_currentTurnPlayerAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_currentTurnPlayerAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0007F7DC File Offset: 0x0007D9DC
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0000F9E5 File Offset: 0x0000DBE5
		public unsafe IAttribute<AccountID> currentSelectionPlayerAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_currentSelectionPlayerAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_currentSelectionPlayerAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0007F80C File Offset: 0x0007DA0C
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000FA04 File Offset: 0x0000DC04
		public unsafe AccountID activeLocalPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_activeLocalPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_activeLocalPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0007F83C File Offset: 0x0007DA3C
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000FA23 File Offset: 0x0000DC23
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivePlayerData.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_currentTurnPlayerAttribute;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectionPlayerAttribute;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_activeLocalPlayer;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_IAttribute_1_AccountID_IAttribute_1_AccountID_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTurnPlayerID_Public_get_AccountID_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLocalPlayerID_Public_get_AccountID_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveLocalPlayerID_Public_set_Void_AccountID_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerSelection_Public_get_Boolean_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTurnPlayer_Public_get_EntityComponent_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLocalPlayer_Public_get_EntityComponent_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}

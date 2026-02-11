using System;
using Canis.utils.ids;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x0200006E RID: 110
	public class EventEntryMatchHistory : Object
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x00026094 File Offset: 0x00024294
		// Note: this type is marked as 'beforefieldinit'.
		static EventEntryMatchHistory()
		{
			Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventEntryMatchHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr);
			EventEntryMatchHistory.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "gameID");
			EventEntryMatchHistory.NativeFieldInfoPtr_roundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "roundID");
			EventEntryMatchHistory.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "players");
			EventEntryMatchHistory.NativeFieldInfoPtr_gameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "gameResults");
			EventEntryMatchHistory.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "started");
			EventEntryMatchHistory.NativeFieldInfoPtr_ended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, "ended");
			EventEntryMatchHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr, 100663945);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00026150 File Offset: 0x00024350
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntryMatchHistory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntryMatchHistory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntryMatchHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000410C File Offset: 0x0000230C
		public EventEntryMatchHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0002618C File Offset: 0x0002438C
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00004115 File Offset: 0x00002315
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000261BC File Offset: 0x000243BC
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00004134 File Offset: 0x00002334
		public unsafe RoundID roundID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_roundID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_roundID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000261EC File Offset: 0x000243EC
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00004153 File Offset: 0x00002353
		public unsafe Il2CppReferenceArray<AccountID> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0002621C File Offset: 0x0002441C
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00004172 File Offset: 0x00002372
		public unsafe Il2CppReferenceArray<DBGGameResultsEntry> gameResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_gameResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DBGGameResultsEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_gameResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0002624C File Offset: 0x0002444C
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00004191 File Offset: 0x00002391
		public WargTime started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_started);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_started), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0002627C File Offset: 0x0002447C
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x000041BF File Offset: 0x000023BF
		public WargTime ended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_ended);
				return new WargTime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WargTime>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryMatchHistory.NativeFieldInfoPtr_ended), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WargTime>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_roundID;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_gameResults;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_ended;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

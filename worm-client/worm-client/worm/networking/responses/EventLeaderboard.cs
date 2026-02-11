using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000073 RID: 115
	public class EventLeaderboard : NetworkMessageEvent
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x000266E8 File Offset: 0x000248E8
		// Note: this type is marked as 'beforefieldinit'.
		static EventLeaderboard()
		{
			Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventLeaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr);
			EventLeaderboard.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr, "eventID");
			EventLeaderboard.NativeFieldInfoPtr_orderedEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr, "orderedEntries");
			EventLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr, 100663950);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00026754 File Offset: 0x00024954
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventLeaderboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventLeaderboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00004320 File Offset: 0x00002520
		public EventLeaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00026790 File Offset: 0x00024990
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00004329 File Offset: 0x00002529
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboard.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboard.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000267C0 File Offset: 0x000249C0
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00004348 File Offset: 0x00002548
		public unsafe Il2CppReferenceArray<EventLeaderboardEntry> orderedEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboard.NativeFieldInfoPtr_orderedEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventLeaderboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboard.NativeFieldInfoPtr_orderedEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_orderedEntries;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

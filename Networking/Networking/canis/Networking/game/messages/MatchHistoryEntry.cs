using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace canis.Networking.game.messages
{
	// Token: 0x0200000E RID: 14
	public class MatchHistoryEntry : Object
	{
		// Token: 0x0600006B RID: 107 RVA: 0x000073EC File Offset: 0x000055EC
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryEntry()
		{
			Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "canis.Networking.game.messages", "MatchHistoryEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr);
			MatchHistoryEntry.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "Client");
			MatchHistoryEntry.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "GameID");
			MatchHistoryEntry.NativeFieldInfoPtr_GameProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "GameProperties");
			MatchHistoryEntry.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "MatchType");
			MatchHistoryEntry.NativeFieldInfoPtr_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "Date");
			MatchHistoryEntry.NativeFieldInfoPtr_Winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "Winner");
			MatchHistoryEntry.NativeFieldInfoPtr_PlayerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "PlayerNames");
			MatchHistoryEntry.NativeFieldInfoPtr_PlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "PlayerCount");
			MatchHistoryEntry.NativeFieldInfoPtr_AiCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "AiCount");
			MatchHistoryEntry.NativeFieldInfoPtr_ResultDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "ResultDetails");
			MatchHistoryEntry.NativeFieldInfoPtr_Expansions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "Expansions");
			MatchHistoryEntry.NativeFieldInfoPtr_Filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "Filters");
			MatchHistoryEntry.NativeFieldInfoPtr_IgnorePlayerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, "IgnorePlayerStats");
			MatchHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr, 100663325);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007534 File Offset: 0x00005734
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002426 File Offset: 0x00000626
		public MatchHistoryEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00007570 File Offset: 0x00005770
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000242F File Offset: 0x0000062F
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00007598 File Offset: 0x00005798
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000244E File Offset: 0x0000064E
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000075C8 File Offset: 0x000057C8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe Dictionary<string, string> GameProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_GameProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_GameProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000075F8 File Offset: 0x000057F8
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000248C File Offset: 0x0000068C
		public unsafe string MatchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_MatchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_MatchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00007620 File Offset: 0x00005820
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000024AB File Offset: 0x000006AB
		public unsafe long Date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Date)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00007648 File Offset: 0x00005848
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000024C6 File Offset: 0x000006C6
		public unsafe AccountID Winner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Winner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Winner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007678 File Offset: 0x00005878
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000024E5 File Offset: 0x000006E5
		public unsafe List<string> PlayerNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_PlayerNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_PlayerNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000076A8 File Offset: 0x000058A8
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002504 File Offset: 0x00000704
		public unsafe int PlayerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_PlayerCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_PlayerCount)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000076D0 File Offset: 0x000058D0
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000251F File Offset: 0x0000071F
		public unsafe int AiCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_AiCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_AiCount)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000076F8 File Offset: 0x000058F8
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe List<MatchHistoryResultDetail> ResultDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_ResultDetails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchHistoryResultDetail>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_ResultDetails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00007728 File Offset: 0x00005928
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002559 File Offset: 0x00000759
		public unsafe List<string> Expansions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Expansions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Expansions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00007758 File Offset: 0x00005958
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002578 File Offset: 0x00000778
		public unsafe Dictionary<string, string> Filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_Filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00007788 File Offset: 0x00005988
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002597 File Offset: 0x00000797
		public unsafe bool IgnorePlayerStats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_IgnorePlayerStats);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryEntry.NativeFieldInfoPtr_IgnorePlayerStats)) = value;
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_GameProperties;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_MatchType;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_Date;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_Winner;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_PlayerNames;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_PlayerCount;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_AiCount;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_ResultDetails;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_Expansions;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_Filters;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_IgnorePlayerStats;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

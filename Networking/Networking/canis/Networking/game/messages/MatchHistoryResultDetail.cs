using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace canis.Networking.game.messages
{
	// Token: 0x0200000F RID: 15
	public class MatchHistoryResultDetail : Object
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000077B0 File Offset: 0x000059B0
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryResultDetail()
		{
			Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "canis.Networking.game.messages", "MatchHistoryResultDetail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr);
			MatchHistoryResultDetail.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, "Player");
			MatchHistoryResultDetail.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, "Position");
			MatchHistoryResultDetail.NativeFieldInfoPtr_IsAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, "IsAI");
			MatchHistoryResultDetail.NativeFieldInfoPtr_Resigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, "Resigned");
			MatchHistoryResultDetail.NativeFieldInfoPtr_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, "Stats");
			MatchHistoryResultDetail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007858 File Offset: 0x00005A58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryResultDetail()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryResultDetail>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryResultDetail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000025B2 File Offset: 0x000007B2
		public MatchHistoryResultDetail(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00007894 File Offset: 0x00005A94
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000025BB File Offset: 0x000007BB
		public unsafe AccountIDUsernameMetadata Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000025DA File Offset: 0x000007DA
		public unsafe int Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000078EC File Offset: 0x00005AEC
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000025F5 File Offset: 0x000007F5
		public unsafe bool IsAI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_IsAI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_IsAI)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007914 File Offset: 0x00005B14
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002610 File Offset: 0x00000810
		public unsafe bool Resigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Resigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Resigned)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000793C File Offset: 0x00005B3C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000262B File Offset: 0x0000082B
		public unsafe Dictionary<string, int> Stats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Stats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryResultDetail.NativeFieldInfoPtr_Stats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_IsAI;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_Resigned;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_Stats;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

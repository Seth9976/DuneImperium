using System;
using boardgames.ranked.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001E RID: 30
	public class RankedLeaderboardEntrySubscriber : Subscriber<RankedLeaderboardEntryData>
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00005C90 File Offset: 0x00003E90
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardEntrySubscriber()
		{
			Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedLeaderboardEntrySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr);
			RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr, "rank");
			RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_elo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr, "elo");
			RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr, "highlight");
			RankedLeaderboardEntrySubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr, 100663349);
			RankedLeaderboardEntrySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr, 100663350);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005D24 File Offset: 0x00003F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224975, XrefRangeEnd = 1224989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedLeaderboardEntrySubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005D60 File Offset: 0x00003F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224989, XrefRangeEnd = 1224992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardEntrySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardEntrySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardEntrySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002A57 File Offset: 0x00000C57
		public RankedLeaderboardEntrySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005D9C File Offset: 0x00003F9C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002A60 File Offset: 0x00000C60
		public unsafe TMP_Text rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005DCC File Offset: 0x00003FCC
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002A7F File Offset: 0x00000C7F
		public unsafe TMP_Text elo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_elo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_elo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005DFC File Offset: 0x00003FFC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002A9E File Offset: 0x00000C9E
		public unsafe GameObject highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_elo;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

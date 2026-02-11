using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000088 RID: 136
	public class WormEventLeaderboardEntrySubscriber : Subscriber<WormEventLeaderboardEntryData>
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x00028FA4 File Offset: 0x000271A4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardEntrySubscriber()
		{
			Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventLeaderboardEntrySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr);
			WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, "rank");
			WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, "score");
			WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, "played");
			WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, "highlight");
			WormEventLeaderboardEntrySubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, 100664063);
			WormEventLeaderboardEntrySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr, 100664064);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002904C File Offset: 0x0002724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695009, XrefRangeEnd = 695024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventLeaderboardEntrySubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00029088 File Offset: 0x00027288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695024, XrefRangeEnd = 695027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardEntrySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardEntrySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardEntrySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000049DE File Offset: 0x00002BDE
		public WormEventLeaderboardEntrySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000290C4 File Offset: 0x000272C4
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x000049E7 File Offset: 0x00002BE7
		public unsafe TMP_Text rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_rank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000290F4 File Offset: 0x000272F4
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004A06 File Offset: 0x00002C06
		public unsafe TMP_Text score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_score);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00029124 File Offset: 0x00027324
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00004A25 File Offset: 0x00002C25
		public unsafe TMP_Text played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_played);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_played), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00029154 File Offset: 0x00027354
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00004A44 File Offset: 0x00002C44
		public unsafe GameObject highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntrySubscriber.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

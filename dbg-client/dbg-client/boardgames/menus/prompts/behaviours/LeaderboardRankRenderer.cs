using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000202 RID: 514
	public class LeaderboardRankRenderer : Subscriber<LeaderboardScoreData>
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x0006A540 File Offset: 0x00068740
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardRankRenderer()
		{
			Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "LeaderboardRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr);
			LeaderboardRankRenderer.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr, "rank");
			LeaderboardRankRenderer.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr, "score");
			LeaderboardRankRenderer.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr, "highlight");
			LeaderboardRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr, 100666749);
			LeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr, 100666750);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0006A5D4 File Offset: 0x000687D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525298, XrefRangeEnd = 525302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeaderboardRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0006A610 File Offset: 0x00068810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525302, XrefRangeEnd = 525305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0000D273 File Offset: 0x0000B473
		public LeaderboardRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0006A64C File Offset: 0x0006884C
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000D27C File Offset: 0x0000B47C
		public unsafe TMP_Text rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_rank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_rank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0006A67C File Offset: 0x0006887C
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000D29B File Offset: 0x0000B49B
		public unsafe TMP_Text score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_score);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0006A6AC File Offset: 0x000688AC
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0000D2BA File Offset: 0x0000B4BA
		public unsafe GameObject highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardRankRenderer.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

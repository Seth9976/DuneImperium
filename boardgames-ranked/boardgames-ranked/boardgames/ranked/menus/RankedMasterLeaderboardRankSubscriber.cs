using System;
using boardgames.ranked.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.ranked.menus
{
	// Token: 0x02000020 RID: 32
	public class RankedMasterLeaderboardRankSubscriber : Subscriber<RankedMasterLeaderboardRankData>
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00006048 File Offset: 0x00004248
		// Note: this type is marked as 'beforefieldinit'.
		static RankedMasterLeaderboardRankSubscriber()
		{
			Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedMasterLeaderboardRankSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr);
			RankedMasterLeaderboardRankSubscriber.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr, "display");
			RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr, 100663353);
			RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr, 100663354);
			RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr, 100663355);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000060C8 File Offset: 0x000042C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225055, XrefRangeEnd = 1225062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006104 File Offset: 0x00004304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225062, XrefRangeEnd = 1225066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006140 File Offset: 0x00004340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225066, XrefRangeEnd = 1225069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedMasterLeaderboardRankSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedMasterLeaderboardRankSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedMasterLeaderboardRankSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002B5D File Offset: 0x00000D5D
		public RankedMasterLeaderboardRankSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000617C File Offset: 0x0000437C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002B66 File Offset: 0x00000D66
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedMasterLeaderboardRankSubscriber.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedMasterLeaderboardRankSubscriber.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using boardgames.ranked.data;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001D RID: 29
	public class RankedLeaderboardEmptyRenderer : Subscriber<RankedLeaderboardData>
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00005B7C File Offset: 0x00003D7C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardEmptyRenderer()
		{
			Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedLeaderboardEmptyRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr);
			RankedLeaderboardEmptyRenderer.NativeFieldInfoPtr_leaderboardEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr, "leaderboardEmpty");
			RankedLeaderboardEmptyRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr, 100663347);
			RankedLeaderboardEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr, 100663348);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224961, XrefRangeEnd = 1224967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedLeaderboardEmptyRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005C24 File Offset: 0x00003E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224967, XrefRangeEnd = 1224975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardEmptyRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardEmptyRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002A2F File Offset: 0x00000C2F
		public RankedLeaderboardEmptyRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005C60 File Offset: 0x00003E60
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002A38 File Offset: 0x00000C38
		public unsafe BoolUnityEvents leaderboardEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEmptyRenderer.NativeFieldInfoPtr_leaderboardEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEmptyRenderer.NativeFieldInfoPtr_leaderboardEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_leaderboardEmpty;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

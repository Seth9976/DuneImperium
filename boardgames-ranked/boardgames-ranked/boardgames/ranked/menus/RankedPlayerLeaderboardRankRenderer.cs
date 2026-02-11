using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.ranked.menus
{
	// Token: 0x02000023 RID: 35
	public class RankedPlayerLeaderboardRankRenderer : VersionedView<RankedPlayProvider>
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000064E0 File Offset: 0x000046E0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayerLeaderboardRankRenderer()
		{
			Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayerLeaderboardRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr);
			RankedPlayerLeaderboardRankRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr, "display");
			RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr, 100663370);
			RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr, 100663371);
			RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr, 100663372);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006560 File Offset: 0x00004760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225146, XrefRangeEnd = 1225159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000659C File Offset: 0x0000479C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225159, XrefRangeEnd = 1225162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000065D8 File Offset: 0x000047D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225162, XrefRangeEnd = 1225165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayerLeaderboardRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayerLeaderboardRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayerLeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public RankedPlayerLeaderboardRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006614 File Offset: 0x00004814
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002BEC File Offset: 0x00000DEC
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayerLeaderboardRankRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayerLeaderboardRankRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

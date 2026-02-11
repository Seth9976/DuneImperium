using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012B RID: 299
	public class WormGameResultsLeaderNameRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000D9A RID: 3482 RVA: 0x00041324 File Offset: 0x0003F524
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsLeaderNameRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsLeaderNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr);
			WormGameResultsLeaderNameRenderer.NativeFieldInfoPtr_leaderNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr, "leaderNameText");
			WormGameResultsLeaderNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr, 100665145);
			WormGameResultsLeaderNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr, 100665146);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00041390 File Offset: 0x0003F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705793, XrefRangeEnd = 705824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsLeaderNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000413CC File Offset: 0x0003F5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705824, XrefRangeEnd = 705827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsLeaderNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsLeaderNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsLeaderNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00009313 File Offset: 0x00007513
		public WormGameResultsLeaderNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00041408 File Offset: 0x0003F608
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x0000931C File Offset: 0x0000751C
		public unsafe TMP_Text leaderNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderNameRenderer.NativeFieldInfoPtr_leaderNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderNameRenderer.NativeFieldInfoPtr_leaderNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_leaderNameText;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

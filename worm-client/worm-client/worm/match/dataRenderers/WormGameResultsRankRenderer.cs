using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012D RID: 301
	public class WormGameResultsRankRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DA6 RID: 3494 RVA: 0x0004154C File Offset: 0x0003F74C
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsRankRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr);
			WormGameResultsRankRenderer.NativeFieldInfoPtr_rankText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr, "rankText");
			WormGameResultsRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr, 100665149);
			WormGameResultsRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr, 100665150);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000415B8 File Offset: 0x0003F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705832, XrefRangeEnd = 705856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000415F4 File Offset: 0x0003F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705856, XrefRangeEnd = 705859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00009363 File Offset: 0x00007563
		public WormGameResultsRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00041630 File Offset: 0x0003F830
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe TMP_Text rankText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsRankRenderer.NativeFieldInfoPtr_rankText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsRankRenderer.NativeFieldInfoPtr_rankText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeFieldInfoPtr_rankText;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

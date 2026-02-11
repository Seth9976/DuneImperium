using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000131 RID: 305
	public class WormGameResultsWaterRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x000419E4 File Offset: 0x0003FBE4
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsWaterRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsWaterRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr);
			WormGameResultsWaterRenderer.NativeFieldInfoPtr_waterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr, "waterText");
			WormGameResultsWaterRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr, 100665158);
			WormGameResultsWaterRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr, 100665159);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00041A50 File Offset: 0x0003FC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705906, XrefRangeEnd = 705908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsWaterRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00041A8C File Offset: 0x0003FC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705908, XrefRangeEnd = 705911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsWaterRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsWaterRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsWaterRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00009403 File Offset: 0x00007603
		public WormGameResultsWaterRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00041AC8 File Offset: 0x0003FCC8
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000940C File Offset: 0x0000760C
		public unsafe TMP_Text waterText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsWaterRenderer.NativeFieldInfoPtr_waterText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsWaterRenderer.NativeFieldInfoPtr_waterText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr_waterText;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

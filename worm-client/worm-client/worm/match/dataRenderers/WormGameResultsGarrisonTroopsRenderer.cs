using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000129 RID: 297
	public class WormGameResultsGarrisonTroopsRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000D8C RID: 3468 RVA: 0x000410B8 File Offset: 0x0003F2B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsGarrisonTroopsRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsGarrisonTroopsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr);
			WormGameResultsGarrisonTroopsRenderer.NativeFieldInfoPtr_garrisonTroopsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr, "garrisonTroopsText");
			WormGameResultsGarrisonTroopsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr, 100665140);
			WormGameResultsGarrisonTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr, 100665141);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00041124 File Offset: 0x0003F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705756, XrefRangeEnd = 705758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsGarrisonTroopsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00041160 File Offset: 0x0003F360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705758, XrefRangeEnd = 705761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsGarrisonTroopsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsGarrisonTroopsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsGarrisonTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000092A4 File Offset: 0x000074A4
		public WormGameResultsGarrisonTroopsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0004119C File Offset: 0x0003F39C
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000092AD File Offset: 0x000074AD
		public unsafe TMP_Text garrisonTroopsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsGarrisonTroopsRenderer.NativeFieldInfoPtr_garrisonTroopsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsGarrisonTroopsRenderer.NativeFieldInfoPtr_garrisonTroopsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_garrisonTroopsText;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

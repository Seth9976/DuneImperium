using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012F RID: 303
	public class WormGameResultsSolariRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DB3 RID: 3507 RVA: 0x000417BC File Offset: 0x0003F9BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsSolariRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsSolariRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr);
			WormGameResultsSolariRenderer.NativeFieldInfoPtr_solariText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr, "solariText");
			WormGameResultsSolariRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr, 100665154);
			WormGameResultsSolariRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr, 100665155);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00041828 File Offset: 0x0003FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705896, XrefRangeEnd = 705898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsSolariRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00041864 File Offset: 0x0003FA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705898, XrefRangeEnd = 705901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsSolariRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsSolariRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsSolariRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000093B3 File Offset: 0x000075B3
		public WormGameResultsSolariRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x000418A0 File Offset: 0x0003FAA0
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000093BC File Offset: 0x000075BC
		public unsafe TMP_Text solariText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsSolariRenderer.NativeFieldInfoPtr_solariText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsSolariRenderer.NativeFieldInfoPtr_solariText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_solariText;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

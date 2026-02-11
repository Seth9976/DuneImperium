using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace lib.canis.dataRenderers
{
	// Token: 0x0200002E RID: 46
	public class GameResultsPlayerDataRenderer : Subscriber<GameResultsPlayerData>
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x000231CC File Offset: 0x000213CC
		// Note: this type is marked as 'beforefieldinit'.
		static GameResultsPlayerDataRenderer()
		{
			Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataRenderers", "GameResultsPlayerDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr);
			GameResultsPlayerDataRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr, "nameText");
			GameResultsPlayerDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr, 100663592);
			GameResultsPlayerDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr, 100663593);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00023238 File Offset: 0x00021438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497854, XrefRangeEnd = 497865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPlayerDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00023274 File Offset: 0x00021474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497865, XrefRangeEnd = 497868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameResultsPlayerDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsPlayerDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPlayerDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002B7D File Offset: 0x00000D7D
		public GameResultsPlayerDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000232B0 File Offset: 0x000214B0
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe TextMeshProUGUI nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerDataRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPlayerDataRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000177 RID: 375
	public class WormVictoryPointsRenderer : VersionedDataComponentObserver<WormVictoryPointsData>
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x0004AA74 File Offset: 0x00048C74
		// Note: this type is marked as 'beforefieldinit'.
		static WormVictoryPointsRenderer()
		{
			Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVictoryPointsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr);
			WormVictoryPointsRenderer.NativeFieldInfoPtr_vpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr, "vpText");
			WormVictoryPointsRenderer.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr, "prompt");
			WormVictoryPointsRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr, 100665635);
			WormVictoryPointsRenderer.NativeMethodInfoPtr_Event_ShowSources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr, 100665636);
			WormVictoryPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr, 100665637);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0004AB08 File Offset: 0x00048D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710484, XrefRangeEnd = 710490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVictoryPointsRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0004AB44 File Offset: 0x00048D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710490, XrefRangeEnd = 710526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointsRenderer.NativeMethodInfoPtr_Event_ShowSources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0004AB78 File Offset: 0x00048D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710526, XrefRangeEnd = 710529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVictoryPointsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVictoryPointsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVictoryPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public WormVictoryPointsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0004ABB4 File Offset: 0x00048DB4
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x0000ADE5 File Offset: 0x00008FE5
		public unsafe TMP_Text vpText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsRenderer.NativeFieldInfoPtr_vpText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsRenderer.NativeFieldInfoPtr_vpText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x0000AE04 File Offset: 0x00009004
		public unsafe FlavoredDismissablePrompt prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsRenderer.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVictoryPointsRenderer.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_vpText;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowSources_Public_Void_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

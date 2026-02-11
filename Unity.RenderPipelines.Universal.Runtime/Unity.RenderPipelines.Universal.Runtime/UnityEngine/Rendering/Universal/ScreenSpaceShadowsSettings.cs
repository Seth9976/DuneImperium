using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class ScreenSpaceShadowsSettings : Object
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x00009B3F File Offset: 0x00007D3F
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceShadowsSettings()
		{
			Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceShadowsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr);
			ScreenSpaceShadowsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr, 100665259);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004B27C File Offset: 0x0004947C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceShadowsSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceShadowsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00009B78 File Offset: 0x00007D78
		public ScreenSpaceShadowsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

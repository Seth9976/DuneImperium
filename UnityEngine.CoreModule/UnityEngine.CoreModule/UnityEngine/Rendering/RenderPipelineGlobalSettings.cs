using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000240 RID: 576
	public class RenderPipelineGlobalSettings : ScriptableObject
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x0000F0B2 File Offset: 0x0000D2B2
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineGlobalSettings()
		{
			Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineGlobalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr);
			RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100668245);
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x000A3758 File Offset: 0x000A1958
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineGlobalSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0000F0EB File Offset: 0x0000D2EB
		public RenderPipelineGlobalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

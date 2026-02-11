using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E0 RID: 224
	public class SceneRenderPipeline : MonoBehaviour
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x000089F3 File Offset: 0x00006BF3
		// Note: this type is marked as 'beforefieldinit'.
		static SceneRenderPipeline()
		{
			Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SceneRenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr);
			SceneRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr, 100665716);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004B528 File Offset: 0x00049728
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneRenderPipeline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneRenderPipeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00008A2C File Offset: 0x00006C2C
		public SceneRenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

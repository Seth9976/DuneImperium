using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.VFX
{
	// Token: 0x0200000E RID: 14
	public sealed class VFXRenderer : Renderer
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00003139 File Offset: 0x00001339
		// Note: this type is marked as 'beforefieldinit'.
		static VFXRenderer()
		{
			Il2CppClassPointerStore<VFXRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXRenderer>.NativeClassPtr);
			VFXRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRenderer>.NativeClassPtr, 100663333);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005C98 File Offset: 0x00003E98
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003172 File Offset: 0x00001372
		public VFXRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009F RID: 159
	public sealed class ImageEffectAllowedInSceneView : Attribute
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x0000609B File Offset: 0x0000429B
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEffectAllowedInSceneView()
		{
			Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ImageEffectAllowedInSceneView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr);
			ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr, 100664416);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000365BC File Offset: 0x000347BC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageEffectAllowedInSceneView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000060D4 File Offset: 0x000042D4
		public ImageEffectAllowedInSceneView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

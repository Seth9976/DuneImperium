using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200009E RID: 158
	[Serializable]
	public sealed class MotionBlurModeParameter : VolumeParameter<MotionBlurMode>
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x000081FF File Offset: 0x000063FF
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurModeParameter()
		{
			Il2CppClassPointerStore<MotionBlurModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionBlurModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurModeParameter>.NativeClassPtr);
			MotionBlurModeParameter.NativeMethodInfoPtr__ctor_Public_Void_MotionBlurMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModeParameter>.NativeClassPtr, 100665034);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00043428 File Offset: 0x00041628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612229, XrefRangeEnd = 612232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurModeParameter(MotionBlurMode value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModeParameter.NativeMethodInfoPtr__ctor_Public_Void_MotionBlurMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00008238 File Offset: 0x00006438
		public MotionBlurModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MotionBlurMode_Boolean_0;
	}
}

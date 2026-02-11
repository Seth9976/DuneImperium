using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public sealed class MotionBlurQualityParameter : VolumeParameter<MotionBlurQuality>
	{
		// Token: 0x06000D2F RID: 3375 RVA: 0x00008241 File Offset: 0x00006441
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurQualityParameter()
		{
			Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionBlurQualityParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr);
			MotionBlurQualityParameter.NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr, 100665035);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00043480 File Offset: 0x00041680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612232, XrefRangeEnd = 612235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurQualityParameter(MotionBlurQuality value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurQualityParameter.NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0000827A File Offset: 0x0000647A
		public MotionBlurQualityParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0;
	}
}

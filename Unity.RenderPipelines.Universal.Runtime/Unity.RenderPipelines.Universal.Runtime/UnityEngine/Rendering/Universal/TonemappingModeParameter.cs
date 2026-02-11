using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public sealed class TonemappingModeParameter : VolumeParameter<TonemappingMode>
	{
		// Token: 0x06000D70 RID: 3440 RVA: 0x00008532 File Offset: 0x00006732
		// Note: this type is marked as 'beforefieldinit'.
		static TonemappingModeParameter()
		{
			Il2CppClassPointerStore<TonemappingModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TonemappingModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TonemappingModeParameter>.NativeClassPtr);
			TonemappingModeParameter.NativeMethodInfoPtr__ctor_Public_Void_TonemappingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TonemappingModeParameter>.NativeClassPtr, 100665048);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00043EEC File Offset: 0x000420EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612349, XrefRangeEnd = 612352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TonemappingModeParameter(TonemappingMode value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TonemappingModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TonemappingModeParameter.NativeMethodInfoPtr__ctor_Public_Void_TonemappingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0000856B File Offset: 0x0000676B
		public TonemappingModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TonemappingMode_Boolean_0;
	}
}

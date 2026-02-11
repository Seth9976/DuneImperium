using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	public sealed class DepthOfFieldModeParameter : VolumeParameter<DepthOfFieldMode>
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x00007F67 File Offset: 0x00006167
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldModeParameter()
		{
			Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DepthOfFieldModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr);
			DepthOfFieldModeParameter.NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr, 100665020);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00042AB8 File Offset: 0x00040CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612131, XrefRangeEnd = 612134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldModeParameter(DepthOfFieldMode value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldModeParameter.NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00007FA0 File Offset: 0x000061A0
		public DepthOfFieldModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0;
	}
}

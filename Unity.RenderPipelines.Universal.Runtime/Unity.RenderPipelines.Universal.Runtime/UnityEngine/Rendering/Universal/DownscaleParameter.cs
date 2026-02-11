using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200008D RID: 141
	[Serializable]
	public sealed class DownscaleParameter : VolumeParameter<BloomDownscaleMode>
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x00007A93 File Offset: 0x00005C93
		// Note: this type is marked as 'beforefieldinit'.
		static DownscaleParameter()
		{
			Il2CppClassPointerStore<DownscaleParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DownscaleParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownscaleParameter>.NativeClassPtr);
			DownscaleParameter.NativeMethodInfoPtr__ctor_Public_Void_BloomDownscaleMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownscaleParameter>.NativeClassPtr, 100665000);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000419C0 File Offset: 0x0003FBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611884, XrefRangeEnd = 611887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownscaleParameter(BloomDownscaleMode value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownscaleParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownscaleParameter.NativeMethodInfoPtr__ctor_Public_Void_BloomDownscaleMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00007ACC File Offset: 0x00005CCC
		public DownscaleParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BloomDownscaleMode_Boolean_0;
	}
}

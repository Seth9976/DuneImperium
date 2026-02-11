using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A8 RID: 168
	[Serializable]
	public sealed class NeutralRangeReductionModeParameter : VolumeParameter<NeutralRangeReductionMode>
	{
		// Token: 0x06000D73 RID: 3443 RVA: 0x00008574 File Offset: 0x00006774
		// Note: this type is marked as 'beforefieldinit'.
		static NeutralRangeReductionModeParameter()
		{
			Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "NeutralRangeReductionModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr);
			NeutralRangeReductionModeParameter.NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr, 100665049);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00043F44 File Offset: 0x00042144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612352, XrefRangeEnd = 612355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NeutralRangeReductionModeParameter(NeutralRangeReductionMode value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralRangeReductionModeParameter.NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000085AD File Offset: 0x000067AD
		public NeutralRangeReductionModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public sealed class HDRACESPresetParameter : VolumeParameter<HDRACESPreset>
	{
		// Token: 0x06000D76 RID: 3446 RVA: 0x000085B6 File Offset: 0x000067B6
		// Note: this type is marked as 'beforefieldinit'.
		static HDRACESPresetParameter()
		{
			Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "HDRACESPresetParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr);
			HDRACESPresetParameter.NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr, 100665050);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00043F9C File Offset: 0x0004219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612355, XrefRangeEnd = 612358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDRACESPresetParameter(HDRACESPreset value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRACESPresetParameter.NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000085EF File Offset: 0x000067EF
		public HDRACESPresetParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture>
	{
		// Token: 0x06001202 RID: 4610 RVA: 0x00051C70 File Offset: 0x0004FE70
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpRenderTextureParameter()
		{
			Il2CppClassPointerStore<NoInterpRenderTextureParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpRenderTextureParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpRenderTextureParameter>.NativeClassPtr);
			NoInterpRenderTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpRenderTextureParameter>.NativeClassPtr, 100665928);
			NoInterpRenderTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpRenderTextureParameter>.NativeClassPtr, 100665929);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979139, XrefRangeEnd = 979142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpRenderTextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpRenderTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00051D24 File Offset: 0x0004FF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979142, XrefRangeEnd = 979153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpRenderTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000094E0 File Offset: 0x000076E0
		public NoInterpRenderTextureParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

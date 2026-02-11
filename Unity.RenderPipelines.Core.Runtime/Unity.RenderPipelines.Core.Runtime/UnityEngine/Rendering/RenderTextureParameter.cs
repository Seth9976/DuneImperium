using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000110 RID: 272
	[Serializable]
	public class RenderTextureParameter : VolumeParameter<RenderTexture>
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x00051B74 File Offset: 0x0004FD74
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureParameter()
		{
			Il2CppClassPointerStore<RenderTextureParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RenderTextureParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureParameter>.NativeClassPtr);
			RenderTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureParameter>.NativeClassPtr, 100665926);
			RenderTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureParameter>.NativeClassPtr, 100665927);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00051BCC File Offset: 0x0004FDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979100, XrefRangeEnd = 979128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureParameter(RenderTexture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00051C28 File Offset: 0x0004FE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979128, XrefRangeEnd = 979139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000094D7 File Offset: 0x000076D7
		public RenderTextureParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_Boolean_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public class NoInterpTextureParameter : VolumeParameter<Texture>
	{
		// Token: 0x060011F2 RID: 4594 RVA: 0x00051880 File Offset: 0x0004FA80
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpTextureParameter()
		{
			Il2CppClassPointerStore<NoInterpTextureParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpTextureParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpTextureParameter>.NativeClassPtr);
			NoInterpTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpTextureParameter>.NativeClassPtr, 100665920);
			NoInterpTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpTextureParameter>.NativeClassPtr, 100665921);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000518D8 File Offset: 0x0004FAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 979060, RefRangeEnd = 979061, XrefRangeStart = 979057, XrefRangeEnd = 979060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpTextureParameter(Texture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpTextureParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpTextureParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00051934 File Offset: 0x0004FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979061, XrefRangeEnd = 979072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpTextureParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000094BC File Offset: 0x000076BC
		public NoInterpTextureParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

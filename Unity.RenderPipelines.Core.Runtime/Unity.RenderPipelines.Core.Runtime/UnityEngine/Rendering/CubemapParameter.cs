using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	public class CubemapParameter : VolumeParameter<Texture>
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x00051D6C File Offset: 0x0004FF6C
		// Note: this type is marked as 'beforefieldinit'.
		static CubemapParameter()
		{
			Il2CppClassPointerStore<CubemapParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CubemapParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubemapParameter>.NativeClassPtr);
			CubemapParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapParameter>.NativeClassPtr, 100665930);
			CubemapParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubemapParameter>.NativeClassPtr, 100665931);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00051DC4 File Offset: 0x0004FFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979153, XrefRangeEnd = 979156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubemapParameter(Texture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubemapParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubemapParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00051E20 File Offset: 0x00050020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979156, XrefRangeEnd = 979167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CubemapParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000094E9 File Offset: 0x000076E9
		public CubemapParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

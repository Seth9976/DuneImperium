using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class NoInterpCubemapParameter : VolumeParameter<Cubemap>
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x00051E68 File Offset: 0x00050068
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpCubemapParameter()
		{
			Il2CppClassPointerStore<NoInterpCubemapParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpCubemapParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpCubemapParameter>.NativeClassPtr);
			NoInterpCubemapParameter.NativeMethodInfoPtr__ctor_Public_Void_Cubemap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpCubemapParameter>.NativeClassPtr, 100665932);
			NoInterpCubemapParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpCubemapParameter>.NativeClassPtr, 100665933);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00051EC0 File Offset: 0x000500C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979167, XrefRangeEnd = 979170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpCubemapParameter(Cubemap value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpCubemapParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpCubemapParameter.NativeMethodInfoPtr__ctor_Public_Void_Cubemap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00051F1C File Offset: 0x0005011C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979170, XrefRangeEnd = 979181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoInterpCubemapParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000094F2 File Offset: 0x000076F2
		public NoInterpCubemapParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Cubemap_Boolean_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

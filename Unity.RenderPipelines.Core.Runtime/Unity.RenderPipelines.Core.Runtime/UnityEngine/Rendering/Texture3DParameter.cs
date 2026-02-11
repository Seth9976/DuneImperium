using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class Texture3DParameter : VolumeParameter<Texture>
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x00051A78 File Offset: 0x0004FC78
		// Note: this type is marked as 'beforefieldinit'.
		static Texture3DParameter()
		{
			Il2CppClassPointerStore<Texture3DParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Texture3DParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture3DParameter>.NativeClassPtr);
			Texture3DParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3DParameter>.NativeClassPtr, 100665924);
			Texture3DParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture3DParameter>.NativeClassPtr, 100665925);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979086, XrefRangeEnd = 979089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture3DParameter(Texture value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture3DParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture3DParameter.NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00051B2C File Offset: 0x0004FD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979089, XrefRangeEnd = 979100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture3DParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000094CE File Offset: 0x000076CE
		public Texture3DParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Boolean_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

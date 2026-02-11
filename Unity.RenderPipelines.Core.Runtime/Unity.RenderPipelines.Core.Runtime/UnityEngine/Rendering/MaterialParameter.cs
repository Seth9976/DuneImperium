using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000116 RID: 278
	[Serializable]
	public class MaterialParameter : VolumeParameter<Material>
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x0000952C File Offset: 0x0000772C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialParameter()
		{
			Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "MaterialParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr);
			MaterialParameter.NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr, 100665952);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00052604 File Offset: 0x00050804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979316, XrefRangeEnd = 979319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialParameter(Material value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialParameter.NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00009565 File Offset: 0x00007765
		public MaterialParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_Boolean_0;
	}
}

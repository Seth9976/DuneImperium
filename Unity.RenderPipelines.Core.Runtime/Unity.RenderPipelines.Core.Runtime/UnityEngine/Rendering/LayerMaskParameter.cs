using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class LayerMaskParameter : VolumeParameter<LayerMask>
	{
		// Token: 0x06001141 RID: 4417 RVA: 0x00008F91 File Offset: 0x00007191
		// Note: this type is marked as 'beforefieldinit'.
		static LayerMaskParameter()
		{
			Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LayerMaskParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr);
			LayerMaskParameter.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr, 100665853);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0004F214 File Offset: 0x0004D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978890, XrefRangeEnd = 978893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayerMaskParameter(LayerMask value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMaskParameter.NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00008FCA File Offset: 0x000071CA
		public LayerMaskParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0;
	}
}

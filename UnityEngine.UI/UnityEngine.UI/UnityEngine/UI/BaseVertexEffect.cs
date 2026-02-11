using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003F RID: 63
	public class BaseVertexEffect : Object
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x00026B98 File Offset: 0x00024D98
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVertexEffect()
		{
			Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "BaseVertexEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr);
			BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664617);
			BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664618);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00026BF0 File Offset: 0x00024DF0
		[CallerCount(0)]
		public unsafe virtual void ModifyVertices(List<UIVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00026C40 File Offset: 0x00024E40
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVertexEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00004CCE File Offset: 0x00002ECE
		public BaseVertexEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

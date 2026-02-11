using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityEditor.Rendering.Universal
{
	// Token: 0x02000076 RID: 118
	public static class MaterialAccess : global::Il2CppSystem.Object
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x00006293 File Offset: 0x00004493
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialAccess()
		{
			Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEditor.Rendering.Universal", "MaterialAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr);
			MaterialAccess.NativeMethodInfoPtr_ReadMaterialRawRenderQueue_Internal_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr, 100665197);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000342FC File Offset: 0x000324FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadMaterialRawRenderQueue(Material mat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialAccess.NativeMethodInfoPtr_ReadMaterialRawRenderQueue_Internal_Static_Int32_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000062CC File Offset: 0x000044CC
		public MaterialAccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_ReadMaterialRawRenderQueue_Internal_Static_Int32_Material_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityEditor.Rendering.BuiltIn.ShaderGraph
{
	// Token: 0x02000075 RID: 117
	public static class MaterialAccess : global::Il2CppSystem.Object
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x00006251 File Offset: 0x00004451
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialAccess()
		{
			Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEditor.Rendering.BuiltIn.ShaderGraph", "MaterialAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr);
			MaterialAccess.NativeMethodInfoPtr_ReadMaterialRawRenderQueue_Internal_Static_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialAccess>.NativeClassPtr, 100665196);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000342B8 File Offset: 0x000324B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097831, XrefRangeEnd = 1097833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000628A File Offset: 0x0000448A
		public MaterialAccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_ReadMaterialRawRenderQueue_Internal_Static_Int32_Material_0;
	}
}

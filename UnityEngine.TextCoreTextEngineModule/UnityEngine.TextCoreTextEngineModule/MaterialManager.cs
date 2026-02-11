using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000E RID: 14
	public static class MaterialManager : Object
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0000B478 File Offset: 0x00009678
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialManager()
		{
			Il2CppClassPointerStore<MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "MaterialManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr);
			MaterialManager.NativeFieldInfoPtr_s_FallbackMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "s_FallbackMaterials");
			MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100663447);
			MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_FontAsset_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100663448);
			MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100663449);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000B4F8 File Offset: 0x000096F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100211, RefRangeEnd = 1100213, XrefRangeStart = 1100149, XrefRangeEnd = 1100211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000B550 File Offset: 0x00009750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100284, RefRangeEnd = 1100285, XrefRangeStart = 1100213, XrefRangeEnd = 1100284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_FontAsset_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000B5B4 File Offset: 0x000097B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100326, RefRangeEnd = 1100327, XrefRangeStart = 1100285, XrefRangeEnd = 1100326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyMaterialPresetProperties(Material source, Material destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Private_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002B70 File Offset: 0x00000D70
		public MaterialManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000B5FC File Offset: 0x000097FC
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002B79 File Offset: 0x00000D79
		public unsafe static Dictionary<long, Material> s_FallbackMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_s_FallbackMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_s_FallbackMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_s_FallbackMaterials;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_FontAsset_Material_Int32_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_CopyMaterialPresetProperties_Private_Static_Void_Material_Material_0;
	}
}

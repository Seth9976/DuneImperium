using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000045 RID: 69
	public static class TMP_MaterialManager : global::Il2CppSystem.Object
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x0002417C File Offset: 0x0002237C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialManager()
		{
			Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MaterialManager");
			TMP_MaterialManager.NativeFieldInfoPtr_m_materialList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_materialList");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterials");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackMaterialLookup");
			TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "m_fallbackCleanupList");
			TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "isFallbackListDirty");
			TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664207);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664208);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664209);
			TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664210);
			TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664211);
			TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664212);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664213);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664214);
			TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664215);
			TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664216);
			TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664217);
			TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664218);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664219);
			TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664220);
			TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664221);
			TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664222);
			TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664223);
			TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664224);
			TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, 100664225);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00024384 File Offset: 0x00022584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043885, XrefRangeEnd = 1043892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnPreRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000243AC File Offset: 0x000225AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043892, XrefRangeEnd = 1043928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00024400 File Offset: 0x00022600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043959, RefRangeEnd = 1043961, XrefRangeStart = 1043928, XrefRangeEnd = 1043959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00024438 File Offset: 0x00022638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043961, XrefRangeEnd = 1043985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetBaseMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0002447C File Offset: 0x0002267C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043985, XrefRangeEnd = 1043997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material SetStencil(Material material, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000244D0 File Offset: 0x000226D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043997, XrefRangeEnd = 1044027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00024528 File Offset: 0x00022728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044027, XrefRangeEnd = 1044051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveStencilMaterial(Material stencilMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stencilMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00024560 File Offset: 0x00022760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044051, XrefRangeEnd = 1044111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseBaseMaterial(Material baseMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00024598 File Offset: 0x00022798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044111, XrefRangeEnd = 1044135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000245C0 File Offset: 0x000227C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044135, XrefRangeEnd = 1044201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilID(GameObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00024604 File Offset: 0x00022804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1044228, RefRangeEnd = 1044230, XrefRangeStart = 1044201, XrefRangeEnd = 1044228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002465C File Offset: 0x0002285C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044230, XrefRangeEnd = 1044255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000246A0 File Offset: 0x000228A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1044293, RefRangeEnd = 1044295, XrefRangeStart = 1044255, XrefRangeEnd = 1044293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00024704 File Offset: 0x00022904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1044363, RefRangeEnd = 1044367, XrefRangeStart = 1044295, XrefRangeEnd = 1044363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0002475C File Offset: 0x0002295C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1044385, RefRangeEnd = 1044387, XrefRangeStart = 1044367, XrefRangeEnd = 1044385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00024794 File Offset: 0x00022994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044387, XrefRangeEnd = 1044411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000247CC File Offset: 0x000229CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1044444, RefRangeEnd = 1044445, XrefRangeStart = 1044411, XrefRangeEnd = 1044444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupFallbackMaterials()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000247F4 File Offset: 0x000229F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1044472, RefRangeEnd = 1044478, XrefRangeStart = 1044445, XrefRangeEnd = 1044472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallbackMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002482C File Offset: 0x00022A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044478, XrefRangeEnd = 1044516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000059E8 File Offset: 0x00003BE8
		public TMP_MaterialManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00024874 File Offset: 0x00022A74
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x000059F1 File Offset: 0x00003BF1
		public unsafe static List<TMP_MaterialManager.MaskingMaterial> m_materialList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.MaskingMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_materialList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x0002489C File Offset: 0x00022A9C
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00005A03 File Offset: 0x00003C03
		public unsafe static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterials, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000248C4 File Offset: 0x00022AC4
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00005A15 File Offset: 0x00003C15
		public unsafe static Dictionary<int, long> m_fallbackMaterialLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackMaterialLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x000248EC File Offset: 0x00022AEC
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00005A27 File Offset: 0x00003C27
		public unsafe static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_MaterialManager.FallbackMaterial>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_m_fallbackCleanupList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00024914 File Offset: 0x00022B14
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00005A39 File Offset: 0x00003C39
		public unsafe static bool isFallbackListDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MaterialManager.NativeFieldInfoPtr_isFallbackListDirty, (void*)(&value));
			}
		}

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_m_materialList;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterials;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterialLookup;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackCleanupList;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_isFallbackListDirty;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Static_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilMaterial_Public_Static_Material_Material_Int32_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseMaterial_Public_Static_Material_Material_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_SetStencil_Public_Static_Material_Material_Int32_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_AddMaskingMaterial_Public_Static_Void_Material_Material_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStencilMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBaseMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_ClearMaterials_Public_Static_Void_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilID_Public_Static_Int32_GameObject_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialForRendering_Public_Static_Material_MaskableGraphic_Material_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Private_Static_Transform_Transform_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Internal_Static_Material_TMP_FontAsset_Material_Int32_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackMaterial_Public_Static_Material_Material_Material_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_AddFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFallbackMaterialReference_Public_Static_Void_Material_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_CleanupFallbackMaterials_Public_Static_Void_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFallbackMaterial_Public_Static_Void_Material_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_CopyMaterialPresetProperties_Public_Static_Void_Material_Material_0;

		// Token: 0x020000A0 RID: 160
		public class FallbackMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000F97 RID: 3991 RVA: 0x0003DEC4 File Offset: 0x0003C0C4
			// Note: this type is marked as 'beforefieldinit'.
			static FallbackMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "FallbackMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr);
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackID");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "sourceMaterialCRC");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "fallbackMaterial");
				TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr, 100664226);
			}

			// Token: 0x06000F98 RID: 3992 RVA: 0x0003DF68 File Offset: 0x0003C168
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FallbackMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.FallbackMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.FallbackMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F99 RID: 3993 RVA: 0x00009643 File Offset: 0x00007843
			public FallbackMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
			// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0000964C File Offset: 0x0000784C
			public unsafe long fallbackID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackID)) = value;
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0003DFCC File Offset: 0x0003C1CC
			// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00009667 File Offset: 0x00007867
			public unsafe Material sourceMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0003DFFC File Offset: 0x0003C1FC
			// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00009686 File Offset: 0x00007886
			public unsafe int sourceMaterialCRC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_sourceMaterialCRC)) = value;
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0003E024 File Offset: 0x0003C224
			// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000096A1 File Offset: 0x000078A1
			public unsafe Material fallbackMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0003E054 File Offset: 0x0003C254
			// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000096C0 File Offset: 0x000078C0
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.FallbackMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x04000C49 RID: 3145
			private static readonly IntPtr NativeFieldInfoPtr_fallbackID;

			// Token: 0x04000C4A RID: 3146
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterial;

			// Token: 0x04000C4B RID: 3147
			private static readonly IntPtr NativeFieldInfoPtr_sourceMaterialCRC;

			// Token: 0x04000C4C RID: 3148
			private static readonly IntPtr NativeFieldInfoPtr_fallbackMaterial;

			// Token: 0x04000C4D RID: 3149
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C4E RID: 3150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A1 RID: 161
		public class MaskingMaterial : global::Il2CppSystem.Object
		{
			// Token: 0x06000FA4 RID: 4004 RVA: 0x0003E07C File Offset: 0x0003C27C
			// Note: this type is marked as 'beforefieldinit'.
			static MaskingMaterial()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "MaskingMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr);
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "count");
				TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, "stencilID");
				TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr, 100664227);
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x0003E10C File Offset: 0x0003C30C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaskingMaterial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.MaskingMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.MaskingMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FA6 RID: 4006 RVA: 0x000096DB File Offset: 0x000078DB
			public MaskingMaterial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0003E148 File Offset: 0x0003C348
			// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x000096E4 File Offset: 0x000078E4
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0003E178 File Offset: 0x0003C378
			// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00009703 File Offset: 0x00007903
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
			// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00009722 File Offset: 0x00007922
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
			// (set) Token: 0x06000FAE RID: 4014 RVA: 0x0000973D File Offset: 0x0000793D
			public unsafe int stencilID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.MaskingMaterial.NativeFieldInfoPtr_stencilID)) = value;
				}
			}

			// Token: 0x04000C4F RID: 3151
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C50 RID: 3152
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C51 RID: 3153
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000C52 RID: 3154
			private static readonly IntPtr NativeFieldInfoPtr_stencilID;

			// Token: 0x04000C53 RID: 3155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FAF RID: 4015 RVA: 0x0003E1F8 File Offset: 0x0003C3F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100664228);
				TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr, 100664229);
			}

			// Token: 0x06000FB0 RID: 4016 RVA: 0x0003E260 File Offset: 0x0003C460
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FB1 RID: 4017 RVA: 0x0003E29C File Offset: 0x0003C49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043851, XrefRangeEnd = 1043856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddMaskingMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass11_0.NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FB2 RID: 4018 RVA: 0x00009758 File Offset: 0x00007958
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0003E2EC File Offset: 0x0003C4EC
			// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00009761 File Offset: 0x00007961
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass11_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C54 RID: 3156
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C55 RID: 3157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C56 RID: 3158
			private static readonly IntPtr NativeMethodInfoPtr__AddMaskingMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FB5 RID: 4021 RVA: 0x0003E31C File Offset: 0x0003C51C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100664230);
				TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr, 100664231);
			}

			// Token: 0x06000FB6 RID: 4022 RVA: 0x0003E384 File Offset: 0x0003C584
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FB7 RID: 4023 RVA: 0x0003E3C0 File Offset: 0x0003C5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043856, XrefRangeEnd = 1043861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveStencilMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FB8 RID: 4024 RVA: 0x00009780 File Offset: 0x00007980
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0003E410 File Offset: 0x0003C610
			// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00009789 File Offset: 0x00007989
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass12_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeMethodInfoPtr__RemoveStencilMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A4 RID: 164
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FBB RID: 4027 RVA: 0x0003E440 File Offset: 0x0003C640
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, "baseMaterial");
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100664232);
				TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr, 100664233);
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x0003E4A8 File Offset: 0x0003C6A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043861, XrefRangeEnd = 1043866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReleaseBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass13_0.NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FBE RID: 4030 RVA: 0x000097A8 File Offset: 0x000079A8
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0003E534 File Offset: 0x0003C734
			// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x000097B1 File Offset: 0x000079B1
			public unsafe Material baseMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass13_0.NativeFieldInfoPtr_baseMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeFieldInfoPtr_baseMaterial;

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("TMPro.TMP_MaterialManager+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FC1 RID: 4033 RVA: 0x0003E564 File Offset: 0x0003C764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_MaterialManager>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, "stencilMaterial");
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100664234);
				TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr, 100664235);
			}

			// Token: 0x06000FC2 RID: 4034 RVA: 0x0003E5CC File Offset: 0x0003C7CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MaterialManager.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x0003E608 File Offset: 0x0003C808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043866, XrefRangeEnd = 1043885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBaseMaterial_b__0(TMP_MaterialManager.MaskingMaterial item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MaterialManager.__c__DisplayClass9_0.NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FC4 RID: 4036 RVA: 0x000097D0 File Offset: 0x000079D0
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0003E658 File Offset: 0x0003C858
			// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000097D9 File Offset: 0x000079D9
			public unsafe Material stencilMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MaterialManager.__c__DisplayClass9_0.NativeFieldInfoPtr_stencilMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeFieldInfoPtr_stencilMaterial;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeMethodInfoPtr__GetBaseMaterial_b__0_Internal_Boolean_MaskingMaterial_0;
		}
	}
}

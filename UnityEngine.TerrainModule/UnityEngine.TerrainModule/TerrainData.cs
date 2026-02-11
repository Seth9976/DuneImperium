using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public sealed class TerrainData : Object
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00004304 File Offset: 0x00002504
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainData()
		{
			Il2CppClassPointerStore<TerrainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine", "TerrainData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainData>.NativeClassPtr);
			TerrainData.NativeFieldInfoPtr_k_MaximumResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumResolution");
			TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumDetailResolutionPerPatch");
			TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailResolutionPerPatch");
			TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumDetailPatchCount");
			TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumAlphamapResolution");
			TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumAlphamapResolution");
			TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MinimumBaseMapResolution");
			TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, "k_MaximumBaseMapResolution");
			TerrainData.NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663309);
			TerrainData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663310);
			TerrainData.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663311);
			TerrainData.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663312);
			TerrainData.NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663313);
			TerrainData.NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663314);
			TerrainData.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainData>.NativeClassPtr, 100663316);
			TerrainData.get_heightmapTextureDelegateField = IL2CPP.ResolveICall<TerrainData.get_heightmapTextureDelegate>("UnityEngine.TerrainData::get_heightmapTexture");
			TerrainData.get_internalHeightmapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_internalHeightmapResolutionDelegate>("UnityEngine.TerrainData::get_internalHeightmapResolution");
			TerrainData.set_internalHeightmapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_internalHeightmapResolutionDelegate>("UnityEngine.TerrainData::set_internalHeightmapResolution");
			TerrainData.get_enableHolesTextureCompressionDelegateField = IL2CPP.ResolveICall<TerrainData.get_enableHolesTextureCompressionDelegate>("UnityEngine.TerrainData::get_enableHolesTextureCompression");
			TerrainData.set_enableHolesTextureCompressionDelegateField = IL2CPP.ResolveICall<TerrainData.set_enableHolesTextureCompressionDelegate>("UnityEngine.TerrainData::set_enableHolesTextureCompression");
			TerrainData.IsHolesTextureCompressedDelegateField = IL2CPP.ResolveICall<TerrainData.IsHolesTextureCompressedDelegate>("UnityEngine.TerrainData::IsHolesTextureCompressed");
			TerrainData.GetHolesTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetHolesTextureDelegate>("UnityEngine.TerrainData::GetHolesTexture");
			TerrainData.GetCompressedHolesTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetCompressedHolesTextureDelegate>("UnityEngine.TerrainData::GetCompressedHolesTexture");
			TerrainData.GetHeightDelegateField = IL2CPP.ResolveICall<TerrainData.GetHeightDelegate>("UnityEngine.TerrainData::GetHeight");
			TerrainData.GetInterpolatedHeightDelegateField = IL2CPP.ResolveICall<TerrainData.GetInterpolatedHeightDelegate>("UnityEngine.TerrainData::GetInterpolatedHeight");
			TerrainData.GetMaximumHeightErrorDelegateField = IL2CPP.ResolveICall<TerrainData.GetMaximumHeightErrorDelegate>("UnityEngine.TerrainData::GetMaximumHeightError");
			TerrainData.OverrideMaximumHeightErrorDelegateField = IL2CPP.ResolveICall<TerrainData.OverrideMaximumHeightErrorDelegate>("UnityEngine.TerrainData::OverrideMaximumHeightError");
			TerrainData.Internal_IsHoleDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_IsHoleDelegate>("UnityEngine.TerrainData::Internal_IsHole");
			TerrainData.GetSteepnessDelegateField = IL2CPP.ResolveICall<TerrainData.GetSteepnessDelegate>("UnityEngine.TerrainData::GetSteepness");
			TerrainData.GetAdjustedSizeDelegateField = IL2CPP.ResolveICall<TerrainData.GetAdjustedSizeDelegate>("UnityEngine.TerrainData::GetAdjustedSize");
			TerrainData.get_wavingGrassStrengthDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassStrengthDelegate>("UnityEngine.TerrainData::get_wavingGrassStrength");
			TerrainData.set_wavingGrassStrengthDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassStrengthDelegate>("UnityEngine.TerrainData::set_wavingGrassStrength");
			TerrainData.get_wavingGrassAmountDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassAmountDelegate>("UnityEngine.TerrainData::get_wavingGrassAmount");
			TerrainData.set_wavingGrassAmountDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassAmountDelegate>("UnityEngine.TerrainData::set_wavingGrassAmount");
			TerrainData.get_wavingGrassSpeedDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassSpeedDelegate>("UnityEngine.TerrainData::get_wavingGrassSpeed");
			TerrainData.set_wavingGrassSpeedDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassSpeedDelegate>("UnityEngine.TerrainData::set_wavingGrassSpeed");
			TerrainData.get_detailWidthDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailWidthDelegate>("UnityEngine.TerrainData::get_detailWidth");
			TerrainData.get_detailHeightDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailHeightDelegate>("UnityEngine.TerrainData::get_detailHeight");
			TerrainData.get_maxDetailScatterPerResDelegateField = IL2CPP.ResolveICall<TerrainData.get_maxDetailScatterPerResDelegate>("UnityEngine.TerrainData::get_maxDetailScatterPerRes");
			TerrainData.Internal_SetDetailResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SetDetailResolutionDelegate>("UnityEngine.TerrainData::Internal_SetDetailResolution");
			TerrainData.Internal_SetDetailScatterModeDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SetDetailScatterModeDelegate>("UnityEngine.TerrainData::Internal_SetDetailScatterMode");
			TerrainData.get_detailPatchCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailPatchCountDelegate>("UnityEngine.TerrainData::get_detailPatchCount");
			TerrainData.get_detailResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailResolutionDelegate>("UnityEngine.TerrainData::get_detailResolution");
			TerrainData.get_detailResolutionPerPatchDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailResolutionPerPatchDelegate>("UnityEngine.TerrainData::get_detailResolutionPerPatch");
			TerrainData.get_detailScatterModeDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailScatterModeDelegate>("UnityEngine.TerrainData::get_detailScatterMode");
			TerrainData.ResetDirtyDetailsDelegateField = IL2CPP.ResolveICall<TerrainData.ResetDirtyDetailsDelegate>("UnityEngine.TerrainData::ResetDirtyDetails");
			TerrainData.RefreshPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.RefreshPrototypesDelegate>("UnityEngine.TerrainData::RefreshPrototypes");
			TerrainData.get_detailPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_detailPrototypesDelegate>("UnityEngine.TerrainData::get_detailPrototypes");
			TerrainData.set_detailPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_detailPrototypesDelegate>("UnityEngine.TerrainData::set_detailPrototypes");
			TerrainData.GetSupportedLayersDelegateField = IL2CPP.ResolveICall<TerrainData.GetSupportedLayersDelegate>("UnityEngine.TerrainData::GetSupportedLayers");
			TerrainData.ComputeDetailCoverageDelegateField = IL2CPP.ResolveICall<TerrainData.ComputeDetailCoverageDelegate>("UnityEngine.TerrainData::ComputeDetailCoverage");
			TerrainData.get_treeInstanceCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_treeInstanceCountDelegate>("UnityEngine.TerrainData::get_treeInstanceCount");
			TerrainData.get_treePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_treePrototypesDelegate>("UnityEngine.TerrainData::get_treePrototypes");
			TerrainData.set_treePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_treePrototypesDelegate>("UnityEngine.TerrainData::set_treePrototypes");
			TerrainData.RemoveTreePrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveTreePrototypeDelegate>("UnityEngine.TerrainData::RemoveTreePrototype");
			TerrainData.RemoveDetailPrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveDetailPrototypeDelegate>("UnityEngine.TerrainData::RemoveDetailPrototype");
			TerrainData.NeedUpgradeScaledTreePrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.NeedUpgradeScaledTreePrototypesDelegate>("UnityEngine.TerrainData::NeedUpgradeScaledTreePrototypes");
			TerrainData.UpgradeScaledTreePrototypeDelegateField = IL2CPP.ResolveICall<TerrainData.UpgradeScaledTreePrototypeDelegate>("UnityEngine.TerrainData::UpgradeScaledTreePrototype");
			TerrainData.get_alphamapLayersDelegateField = IL2CPP.ResolveICall<TerrainData.get_alphamapLayersDelegate>("UnityEngine.TerrainData::get_alphamapLayers");
			TerrainData.get_Internal_alphamapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_Internal_alphamapResolutionDelegate>("UnityEngine.TerrainData::get_Internal_alphamapResolution");
			TerrainData.set_Internal_alphamapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_Internal_alphamapResolutionDelegate>("UnityEngine.TerrainData::set_Internal_alphamapResolution");
			TerrainData.get_Internal_baseMapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.get_Internal_baseMapResolutionDelegate>("UnityEngine.TerrainData::get_Internal_baseMapResolution");
			TerrainData.set_Internal_baseMapResolutionDelegateField = IL2CPP.ResolveICall<TerrainData.set_Internal_baseMapResolutionDelegate>("UnityEngine.TerrainData::set_Internal_baseMapResolution");
			TerrainData.SetBaseMapDirtyDelegateField = IL2CPP.ResolveICall<TerrainData.SetBaseMapDirtyDelegate>("UnityEngine.TerrainData::SetBaseMapDirty");
			TerrainData.GetAlphamapTextureDelegateField = IL2CPP.ResolveICall<TerrainData.GetAlphamapTextureDelegate>("UnityEngine.TerrainData::GetAlphamapTexture");
			TerrainData.get_alphamapTextureCountDelegateField = IL2CPP.ResolveICall<TerrainData.get_alphamapTextureCountDelegate>("UnityEngine.TerrainData::get_alphamapTextureCount");
			TerrainData.get_splatPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.get_splatPrototypesDelegate>("UnityEngine.TerrainData::get_splatPrototypes");
			TerrainData.set_splatPrototypesDelegateField = IL2CPP.ResolveICall<TerrainData.set_splatPrototypesDelegate>("UnityEngine.TerrainData::set_splatPrototypes");
			TerrainData.get_terrainLayersDelegateField = IL2CPP.ResolveICall<TerrainData.get_terrainLayersDelegate>("UnityEngine.TerrainData::get_terrainLayers");
			TerrainData.set_terrainLayersDelegateField = IL2CPP.ResolveICall<TerrainData.set_terrainLayersDelegate>("UnityEngine.TerrainData::set_terrainLayers");
			TerrainData.Internal_DirtyHeightmapRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_DirtyHeightmapRegionDelegate>("UnityEngine.TerrainData::Internal_DirtyHeightmapRegion");
			TerrainData.SyncHeightmapDelegateField = IL2CPP.ResolveICall<TerrainData.SyncHeightmapDelegate>("UnityEngine.TerrainData::SyncHeightmap");
			TerrainData.Internal_DirtyHolesRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_DirtyHolesRegionDelegate>("UnityEngine.TerrainData::Internal_DirtyHolesRegion");
			TerrainData.Internal_SyncHolesDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SyncHolesDelegate>("UnityEngine.TerrainData::Internal_SyncHoles");
			TerrainData.Internal_MarkAlphamapDirtyRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_MarkAlphamapDirtyRegionDelegate>("UnityEngine.TerrainData::Internal_MarkAlphamapDirtyRegion");
			TerrainData.Internal_ClearAlphamapDirtyRegionDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_ClearAlphamapDirtyRegionDelegate>("UnityEngine.TerrainData::Internal_ClearAlphamapDirtyRegion");
			TerrainData.Internal_SyncAlphamapsDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_SyncAlphamapsDelegate>("UnityEngine.TerrainData::Internal_SyncAlphamaps");
			TerrainData.get_atlasFormatDelegateField = IL2CPP.ResolveICall<TerrainData.get_atlasFormatDelegate>("UnityEngine.TerrainData::get_atlasFormat");
			TerrainData.get_heightmapScale_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_heightmapScale_InjectedDelegate>("UnityEngine.TerrainData::get_heightmapScale_Injected");
			TerrainData.set_size_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.set_size_InjectedDelegate>("UnityEngine.TerrainData::set_size_Injected");
			TerrainData.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_bounds_InjectedDelegate>("UnityEngine.TerrainData::get_bounds_Injected");
			TerrainData.GetInterpolatedNormal_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.GetInterpolatedNormal_InjectedDelegate>("UnityEngine.TerrainData::GetInterpolatedNormal_Injected");
			TerrainData.get_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.get_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::get_wavingGrassTint_Injected");
			TerrainData.set_wavingGrassTint_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.set_wavingGrassTint_InjectedDelegate>("UnityEngine.TerrainData::set_wavingGrassTint_Injected");
			TerrainData.RemoveTrees_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.RemoveTrees_InjectedDelegate>("UnityEngine.TerrainData::RemoveTrees_Injected");
			TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHeightmap_Injected");
			TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField = IL2CPP.ResolveICall<TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegate>("UnityEngine.TerrainData::Internal_CopyActiveRenderTextureToHoles_Injected");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004898 File Offset: 0x00002A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268448, XrefRangeEnd = 1268450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBoundaryValue(TerrainData.BoundaryValueType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000048D8 File Offset: 0x00002AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268450, XrefRangeEnd = 1268459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerrainData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004914 File Offset: 0x00002B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268459, XrefRangeEnd = 1268486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(TerrainData terrainData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000027F9 File Offset: 0x000009F9
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268486, XrefRangeEnd = 1268488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004988 File Offset: 0x00002B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268488, XrefRangeEnd = 1268490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAlphamapResolutionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000049C4 File Offset: 0x00002BC4
		public unsafe Il2CppReferenceArray<Terrain> users
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268490, XrefRangeEnd = 1268492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Terrain>>(intPtr3) : null;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004A04 File Offset: 0x00002C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268492, XrefRangeEnd = 1268494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_size_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainData.NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000026D3 File Offset: 0x000008D3
		public TerrainData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004A44 File Offset: 0x00002C44
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000026DC File Offset: 0x000008DC
		public unsafe static int k_MaximumResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumResolution, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004A60 File Offset: 0x00002C60
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000026EA File Offset: 0x000008EA
		public unsafe static int k_MinimumDetailResolutionPerPatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch, (void*)(&value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004A7C File Offset: 0x00002C7C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000026F8 File Offset: 0x000008F8
		public unsafe static int k_MaximumDetailResolutionPerPatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch, (void*)(&value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004A98 File Offset: 0x00002C98
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002706 File Offset: 0x00000906
		public unsafe static int k_MaximumDetailPatchCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumDetailPatchCount, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004AB4 File Offset: 0x00002CB4
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002714 File Offset: 0x00000914
		public unsafe static int k_MinimumAlphamapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumAlphamapResolution, (void*)(&value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004AD0 File Offset: 0x00002CD0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002722 File Offset: 0x00000922
		public unsafe static int k_MaximumAlphamapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumAlphamapResolution, (void*)(&value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004AEC File Offset: 0x00002CEC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002730 File Offset: 0x00000930
		public unsafe static int k_MinimumBaseMapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MinimumBaseMapResolution, (void*)(&value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004B08 File Offset: 0x00002D08
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000273E File Offset: 0x0000093E
		public unsafe static int k_MaximumBaseMapResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainData.NativeFieldInfoPtr_k_MaximumBaseMapResolution, (void*)(&value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004B24 File Offset: 0x00002D24
		public static bool SupportsCopyTextureBetweenRTAndTexture
		{
			get
			{
				return (SystemInfo.copyTextureSupport & (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture)) == (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004B44 File Offset: 0x00002D44
		public void CopyActiveRenderTextureToHeightmap(RectInt sourceRect, Vector2Int dest, TerrainHeightmapSyncControl syncControl)
		{
			RenderTexture active = RenderTexture.active;
			bool flag = active == null;
			if (flag)
			{
				throw new InvalidOperationException("Active RenderTexture is null.");
			}
			bool flag2 = sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceRect");
			}
			bool flag3 = dest.x < 0 || dest.x + sourceRect.width > this.heightmapResolution;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("dest.x");
			}
			bool flag4 = dest.y < 0 || dest.y + sourceRect.height > this.heightmapResolution;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("dest.y");
			}
			this.Internal_CopyActiveRenderTextureToHeightmap(sourceRect, dest.x, dest.y, syncControl);
			TerrainCallbacks.InvokeHeightmapChangedCallback(this, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), syncControl == TerrainHeightmapSyncControl.HeightAndLod);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004C60 File Offset: 0x00002E60
		public void DirtyHeightmapRegion(RectInt region, TerrainHeightmapSyncControl syncControl)
		{
			int heightmapResolution = this.heightmapResolution;
			bool flag = region.x < 0 || region.x >= heightmapResolution;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("region.x");
			}
			bool flag2 = region.width <= 0 || region.xMax > heightmapResolution;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("region.width");
			}
			bool flag3 = region.y < 0 || region.y >= heightmapResolution;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("region.y");
			}
			bool flag4 = region.height <= 0 || region.yMax > heightmapResolution;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("region.height");
			}
			this.Internal_DirtyHeightmapRegion(region.x, region.y, region.width, region.height, syncControl);
			TerrainCallbacks.InvokeHeightmapChangedCallback(this, region, syncControl == TerrainHeightmapSyncControl.HeightAndLod);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000274C File Offset: 0x0000094C
		public static string AlphamapTextureName
		{
			get
			{
				return "alphamap";
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002753 File Offset: 0x00000953
		public static string HolesTextureName
		{
			get
			{
				return "holes";
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004D48 File Offset: 0x00002F48
		public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, RectInt sourceRect, Vector2Int dest, bool allowDelayedCPUSync)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			RenderTexture active = RenderTexture.active;
			bool flag2 = active == null;
			if (flag2)
			{
				throw new InvalidOperationException("Active RenderTexture is null.");
			}
			bool flag3 = textureName == TerrainData.HolesTextureName;
			int num2;
			int num;
			if (flag3)
			{
				bool flag4 = textureIndex != 0;
				if (flag4)
				{
					throw new ArgumentOutOfRangeException("textureIndex");
				}
				bool flag5 = active == this.holesTexture;
				if (flag5)
				{
					throw new ArgumentException("source", "Active RenderTexture cannot be holesTexture.");
				}
				num = (num2 = this.holesResolution);
			}
			else
			{
				bool flag6 = textureName == TerrainData.AlphamapTextureName;
				if (!flag6)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				bool flag7 = textureIndex < 0 || textureIndex >= this.alphamapTextureCount;
				if (flag7)
				{
					throw new ArgumentOutOfRangeException("textureIndex");
				}
				num = (num2 = this.alphamapResolution);
			}
			bool flag8 = sourceRect.x < 0 || sourceRect.y < 0 || sourceRect.xMax > active.width || sourceRect.yMax > active.height;
			if (flag8)
			{
				throw new ArgumentOutOfRangeException("sourceRect");
			}
			bool flag9 = dest.x < 0 || dest.x + sourceRect.width > num2;
			if (flag9)
			{
				throw new ArgumentOutOfRangeException("dest.x");
			}
			bool flag10 = dest.y < 0 || dest.y + sourceRect.height > num;
			if (flag10)
			{
				throw new ArgumentOutOfRangeException("dest.y");
			}
			bool flag11 = textureName == TerrainData.HolesTextureName;
			if (flag11)
			{
				this.Internal_CopyActiveRenderTextureToHoles(sourceRect, dest.x, dest.y, allowDelayedCPUSync);
			}
			else
			{
				Texture2D alphamapTexture = this.GetAlphamapTexture(textureIndex);
				allowDelayedCPUSync = allowDelayedCPUSync && TerrainData.SupportsCopyTextureBetweenRTAndTexture && QualitySettings.globalTextureMipmapLimit == 0;
				bool flag12 = allowDelayedCPUSync;
				if (flag12)
				{
					bool flag13 = alphamapTexture.mipmapCount > 1;
					if (flag13)
					{
						RenderTexture temporary = RenderTexture.GetTemporary(new RenderTextureDescriptor(alphamapTexture.width, alphamapTexture.height, active.graphicsFormat, active.depthStencilFormat)
						{
							sRGB = false,
							useMipMap = true,
							autoGenerateMips = false
						});
						bool flag14 = !temporary.IsCreated();
						if (flag14)
						{
							temporary.Create();
						}
						Graphics.CopyTexture(alphamapTexture, 0, 0, temporary, 0, 0);
						Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, temporary, 0, 0, dest.x, dest.y);
						temporary.GenerateMips();
						Graphics.CopyTexture(temporary, alphamapTexture);
						RenderTexture.ReleaseTemporary(temporary);
					}
					else
					{
						Graphics.CopyTexture(active, 0, 0, sourceRect.x, sourceRect.y, sourceRect.width, sourceRect.height, alphamapTexture, 0, 0, dest.x, dest.y);
					}
					this.Internal_MarkAlphamapDirtyRegion(textureIndex, dest.x, dest.y, sourceRect.width, sourceRect.height);
				}
				else
				{
					alphamapTexture.ReadPixels(new Rect((float)sourceRect.x, (float)sourceRect.y, (float)sourceRect.width, (float)sourceRect.height), dest.x, dest.y);
					alphamapTexture.Apply(true);
					this.Internal_ClearAlphamapDirtyRegion(textureIndex);
				}
				TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, new RectInt(dest.x, dest.y, sourceRect.width, sourceRect.height), !allowDelayedCPUSync);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000050E8 File Offset: 0x000032E8
		public void DirtyTextureRegion(string textureName, RectInt region, bool allowDelayedCPUSync)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			bool flag2 = textureName == TerrainData.AlphamapTextureName;
			int num;
			if (flag2)
			{
				num = this.alphamapResolution;
			}
			else
			{
				bool flag3 = textureName == TerrainData.HolesTextureName;
				if (!flag3)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				num = this.holesResolution;
			}
			bool flag4 = region.x < 0 || region.x >= num;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("region.x");
			}
			bool flag5 = region.width <= 0 || region.xMax > num;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("region.width");
			}
			bool flag6 = region.y < 0 || region.y >= num;
			if (flag6)
			{
				throw new ArgumentOutOfRangeException("region.y");
			}
			bool flag7 = region.height <= 0 || region.yMax > num;
			if (flag7)
			{
				throw new ArgumentOutOfRangeException("region.height");
			}
			bool flag8 = textureName == TerrainData.HolesTextureName;
			if (flag8)
			{
				this.Internal_DirtyHolesRegion(region.x, region.y, region.width, region.height, allowDelayedCPUSync);
			}
			else
			{
				this.Internal_MarkAlphamapDirtyRegion(-1, region.x, region.y, region.width, region.height);
				bool flag9 = !allowDelayedCPUSync;
				if (flag9)
				{
					this.SyncTexture(textureName);
				}
				else
				{
					TerrainCallbacks.InvokeTextureChangedCallback(this, textureName, region, false);
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005278 File Offset: 0x00003478
		public void SyncTexture(string textureName)
		{
			bool flag = String.IsNullOrEmpty(textureName);
			if (flag)
			{
				throw new ArgumentNullException("textureName");
			}
			bool flag2 = textureName == TerrainData.AlphamapTextureName;
			if (flag2)
			{
				this.Internal_SyncAlphamaps();
			}
			else
			{
				bool flag3 = textureName == TerrainData.HolesTextureName;
				if (!flag3)
				{
					throw new ArgumentException(String.Concat("Unrecognized terrain texture name: \"", textureName, "\""));
				}
				bool flag4 = this.IsHolesTextureCompressed();
				if (flag4)
				{
					throw new InvalidOperationException("Holes texture is compressed. Compressed holes texture can not be read back from GPU. Use TerrainData.enableHolesTextureCompression to disable holes texture compression.");
				}
				this.Internal_SyncHoles();
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000275A File Offset: 0x0000095A
		public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately)
		{
			this.DirtyHeightmapRegion(new RectInt(x, y, width, height), syncHeightmapTextureImmediately ? TerrainHeightmapSyncControl.HeightOnly : TerrainHeightmapSyncControl.None);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002776 File Offset: 0x00000976
		public int heightmapWidth
		{
			get
			{
				return this.heightmapResolution;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000277E File Offset: 0x0000097E
		public int heightmapHeight
		{
			get
			{
				return this.heightmapResolution;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000052FC File Offset: 0x000034FC
		public RenderTexture heightmapTexture
		{
			get
			{
				IntPtr intPtr = TerrainData.get_heightmapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005328 File Offset: 0x00003528
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002786 File Offset: 0x00000986
		public int heightmapResolution
		{
			get
			{
				return this.internalHeightmapResolution;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002793 File Offset: 0x00000993
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000027A5 File Offset: 0x000009A5
		public int internalHeightmapResolution
		{
			get
			{
				return TerrainData.get_internalHeightmapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_internalHeightmapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00005340 File Offset: 0x00003540
		public Vector3 heightmapScale
		{
			get
			{
				Vector3 vector;
				this.get_heightmapScale_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005358 File Offset: 0x00003558
		public Texture holesTexture
		{
			get
			{
				bool flag = this.IsHolesTextureCompressed();
				Texture texture;
				if (flag)
				{
					texture = this.GetCompressedHolesTexture();
				}
				else
				{
					texture = this.GetHolesTexture();
				}
				return texture;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000027B8 File Offset: 0x000009B8
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000027CA File Offset: 0x000009CA
		public bool enableHolesTextureCompression
		{
			get
			{
				return TerrainData.get_enableHolesTextureCompressionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_enableHolesTextureCompressionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005388 File Offset: 0x00003588
		public RenderTexture holesRenderTexture
		{
			get
			{
				return this.GetHolesTexture();
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000027DD File Offset: 0x000009DD
		public bool IsHolesTextureCompressed()
		{
			return TerrainData.IsHolesTextureCompressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000053A0 File Offset: 0x000035A0
		public RenderTexture GetHolesTexture()
		{
			IntPtr intPtr = TerrainData.GetHolesTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000053CC File Offset: 0x000035CC
		public Texture2D GetCompressedHolesTexture()
		{
			IntPtr intPtr = TerrainData.GetCompressedHolesTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000027EF File Offset: 0x000009EF
		public int holesResolution
		{
			get
			{
				return this.heightmapResolution - 1;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000053F8 File Offset: 0x000035F8
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005410 File Offset: 0x00003610
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002803 File Offset: 0x00000A03
		public float thickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002806 File Offset: 0x00000A06
		public float GetHeight(int x, int y)
		{
			return TerrainData.GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000281A File Offset: 0x00000A1A
		public float GetInterpolatedHeight(float x, float y)
		{
			return TerrainData.GetInterpolatedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005428 File Offset: 0x00003628
		public Il2CppStructArray<float> GetMaximumHeightError()
		{
			IntPtr intPtr = TerrainData.GetMaximumHeightErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000282E File Offset: 0x00000A2E
		public void OverrideMaximumHeightError(Il2CppStructArray<float> maxError)
		{
			TerrainData.OverrideMaximumHeightErrorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(maxError));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005454 File Offset: 0x00003654
		public bool IsHole(int x, int y)
		{
			bool flag = x < 0 || x >= this.holesResolution || y < 0 || y >= this.holesResolution;
			if (flag)
			{
				throw new ArgumentException("Trying to access out-of-bounds terrain holes information.");
			}
			return this.Internal_IsHole(x, y);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002846 File Offset: 0x00000A46
		public bool Internal_IsHole(int x, int y)
		{
			return TerrainData.Internal_IsHoleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000285A File Offset: 0x00000A5A
		public float GetSteepness(float x, float y)
		{
			return TerrainData.GetSteepnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000054A0 File Offset: 0x000036A0
		public Vector3 GetInterpolatedNormal(float x, float y)
		{
			Vector3 vector;
			this.GetInterpolatedNormal_Injected(x, y, out vector);
			return vector;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000286E File Offset: 0x00000A6E
		public int GetAdjustedSize(int size)
		{
			return TerrainData.GetAdjustedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), size);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002881 File Offset: 0x00000A81
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002893 File Offset: 0x00000A93
		public float wavingGrassStrength
		{
			get
			{
				return TerrainData.get_wavingGrassStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassStrengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000028A6 File Offset: 0x00000AA6
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000028B8 File Offset: 0x00000AB8
		public float wavingGrassAmount
		{
			get
			{
				return TerrainData.get_wavingGrassAmountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassAmountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000028CB File Offset: 0x00000ACB
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000028DD File Offset: 0x00000ADD
		public float wavingGrassSpeed
		{
			get
			{
				return TerrainData.get_wavingGrassSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_wavingGrassSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000054B8 File Offset: 0x000036B8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000028F0 File Offset: 0x00000AF0
		public Color wavingGrassTint
		{
			get
			{
				Color color;
				this.get_wavingGrassTint_Injected(out color);
				return color;
			}
			set
			{
				this.set_wavingGrassTint_Injected(ref value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000028FA File Offset: 0x00000AFA
		public int detailWidth
		{
			get
			{
				return TerrainData.get_detailWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000290C File Offset: 0x00000B0C
		public int detailHeight
		{
			get
			{
				return TerrainData.get_detailHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000291E File Offset: 0x00000B1E
		public int maxDetailScatterPerRes
		{
			get
			{
				return TerrainData.get_maxDetailScatterPerResDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002930 File Offset: 0x00000B30
		public void SetDetailResolution(int detailResolution, int resolutionPerPatch)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000293D File Offset: 0x00000B3D
		public void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch)
		{
			TerrainData.Internal_SetDetailResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), patchCount, resolutionPerPatch);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002951 File Offset: 0x00000B51
		public void SetDetailScatterMode(DetailScatterMode scatterMode)
		{
			this.Internal_SetDetailScatterMode(scatterMode);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000295C File Offset: 0x00000B5C
		public void Internal_SetDetailScatterMode(DetailScatterMode scatterMode)
		{
			TerrainData.Internal_SetDetailScatterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), scatterMode);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000296F File Offset: 0x00000B6F
		public int detailPatchCount
		{
			get
			{
				return TerrainData.get_detailPatchCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002981 File Offset: 0x00000B81
		public int detailResolution
		{
			get
			{
				return TerrainData.get_detailResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002993 File Offset: 0x00000B93
		public int detailResolutionPerPatch
		{
			get
			{
				return TerrainData.get_detailResolutionPerPatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000029A5 File Offset: 0x00000BA5
		public DetailScatterMode detailScatterMode
		{
			get
			{
				return TerrainData.get_detailScatterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000029B7 File Offset: 0x00000BB7
		public void ResetDirtyDetails()
		{
			TerrainData.ResetDirtyDetailsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000029C9 File Offset: 0x00000BC9
		public void RefreshPrototypes()
		{
			TerrainData.RefreshPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000054D0 File Offset: 0x000036D0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000029DB File Offset: 0x00000BDB
		public Il2CppReferenceArray<DetailPrototype> detailPrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_detailPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetailPrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_detailPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000054FC File Offset: 0x000036FC
		public Il2CppStructArray<int> GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight)
		{
			IntPtr intPtr = TerrainData.GetSupportedLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), xBase, yBase, totalWidth, totalHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005530 File Offset: 0x00003730
		public Il2CppStructArray<int> GetSupportedLayers(Vector2Int positionBase, Vector2Int size)
		{
			return this.GetSupportedLayers(positionBase.x, positionBase.y, size.x, size.y);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000029F3 File Offset: 0x00000BF3
		public float ComputeDetailCoverage(int detailPrototypeIndex)
		{
			return TerrainData.ComputeDetailCoverageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), detailPrototypeIndex);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002A06 File Offset: 0x00000C06
		public int treeInstanceCount
		{
			get
			{
				return TerrainData.get_treeInstanceCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005564 File Offset: 0x00003764
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002A18 File Offset: 0x00000C18
		public Il2CppReferenceArray<TreePrototype> treePrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_treePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TreePrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_treePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002A30 File Offset: 0x00000C30
		public void RemoveTreePrototype(int index)
		{
			TerrainData.RemoveTreePrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A43 File Offset: 0x00000C43
		public void RemoveDetailPrototype(int index)
		{
			TerrainData.RemoveDetailPrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A56 File Offset: 0x00000C56
		public bool NeedUpgradeScaledTreePrototypes()
		{
			return TerrainData.NeedUpgradeScaledTreePrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002A68 File Offset: 0x00000C68
		public void UpgradeScaledTreePrototype()
		{
			TerrainData.UpgradeScaledTreePrototypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002A7A File Offset: 0x00000C7A
		public int alphamapLayers
		{
			get
			{
				return TerrainData.get_alphamapLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005590 File Offset: 0x00003790
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002A8C File Offset: 0x00000C8C
		public int alphamapResolution
		{
			get
			{
				return this.Internal_alphamapResolution;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002A99 File Offset: 0x00000C99
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002AAB File Offset: 0x00000CAB
		public int Internal_alphamapResolution
		{
			get
			{
				return TerrainData.get_Internal_alphamapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_Internal_alphamapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000055A8 File Offset: 0x000037A8
		public int alphamapWidth
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000055C0 File Offset: 0x000037C0
		public int alphamapHeight
		{
			get
			{
				return this.alphamapResolution;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002ABE File Offset: 0x00000CBE
		public int baseMapResolution
		{
			get
			{
				return this.Internal_baseMapResolution;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002ACB File Offset: 0x00000CCB
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002ADD File Offset: 0x00000CDD
		public int Internal_baseMapResolution
		{
			get
			{
				return TerrainData.get_Internal_baseMapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainData.set_Internal_baseMapResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public void SetBaseMapDirty()
		{
			TerrainData.SetBaseMapDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000055F0 File Offset: 0x000037F0
		public Texture2D GetAlphamapTexture(int index)
		{
			IntPtr intPtr = TerrainData.GetAlphamapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002B02 File Offset: 0x00000D02
		public int alphamapTextureCount
		{
			get
			{
				return TerrainData.get_alphamapTextureCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002B14 File Offset: 0x00000D14
		public Il2CppReferenceArray<Texture2D> alphamapTextures
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005620 File Offset: 0x00003820
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002B21 File Offset: 0x00000D21
		public Il2CppReferenceArray<SplatPrototype> splatPrototypes
		{
			get
			{
				IntPtr intPtr = TerrainData.get_splatPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SplatPrototype>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_splatPrototypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000564C File Offset: 0x0000384C
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002B39 File Offset: 0x00000D39
		public Il2CppReferenceArray<TerrainLayer> terrainLayers
		{
			get
			{
				IntPtr intPtr = TerrainData.get_terrainLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TerrainLayer>>(intPtr2) : null;
			}
			set
			{
				TerrainData.set_terrainLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B51 File Offset: 0x00000D51
		public int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
		{
			return this.RemoveTrees_Injected(ref position, radius, prototypeIndex);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B5D File Offset: 0x00000D5D
		public void Internal_CopyActiveRenderTextureToHeightmap(RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
		{
			this.Internal_CopyActiveRenderTextureToHeightmap_Injected(ref rect, destX, destY, syncControl);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002B6B File Offset: 0x00000D6B
		public void Internal_DirtyHeightmapRegion(int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl)
		{
			TerrainData.Internal_DirtyHeightmapRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, width, height, syncControl);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002B84 File Offset: 0x00000D84
		public void SyncHeightmap()
		{
			TerrainData.SyncHeightmapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002B96 File Offset: 0x00000D96
		public void Internal_CopyActiveRenderTextureToHoles(RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
		{
			this.Internal_CopyActiveRenderTextureToHoles_Injected(ref rect, destX, destY, allowDelayedCPUSync);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public void Internal_DirtyHolesRegion(int x, int y, int width, int height, bool allowDelayedCPUSync)
		{
			TerrainData.Internal_DirtyHolesRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, width, height, allowDelayedCPUSync);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002BBD File Offset: 0x00000DBD
		public void Internal_SyncHoles()
		{
			TerrainData.Internal_SyncHolesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002BCF File Offset: 0x00000DCF
		public void Internal_MarkAlphamapDirtyRegion(int alphamapIndex, int x, int y, int width, int height)
		{
			TerrainData.Internal_MarkAlphamapDirtyRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alphamapIndex, x, y, width, height);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public void Internal_ClearAlphamapDirtyRegion(int alphamapIndex)
		{
			TerrainData.Internal_ClearAlphamapDirtyRegionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alphamapIndex);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002BFB File Offset: 0x00000DFB
		public void Internal_SyncAlphamaps()
		{
			TerrainData.Internal_SyncAlphamapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002C0D File Offset: 0x00000E0D
		public TextureFormat atlasFormat
		{
			get
			{
				return TerrainData.get_atlasFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002C1F File Offset: 0x00000E1F
		public void get_heightmapScale_Injected(out Vector3 ret)
		{
			TerrainData.get_heightmapScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002C32 File Offset: 0x00000E32
		public void set_size_Injected(ref Vector3 value)
		{
			TerrainData.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002C45 File Offset: 0x00000E45
		public void get_bounds_Injected(out Bounds ret)
		{
			TerrainData.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002C58 File Offset: 0x00000E58
		public void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret)
		{
			TerrainData.GetInterpolatedNormal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, out ret);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002C6D File Offset: 0x00000E6D
		public void get_wavingGrassTint_Injected(out Color ret)
		{
			TerrainData.get_wavingGrassTint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002C80 File Offset: 0x00000E80
		public void set_wavingGrassTint_Injected(ref Color value)
		{
			TerrainData.set_wavingGrassTint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C93 File Offset: 0x00000E93
		public int RemoveTrees_Injected(ref Vector2 position, float radius, int prototypeIndex)
		{
			return TerrainData.RemoveTrees_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, radius, prototypeIndex);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public void Internal_CopyActiveRenderTextureToHeightmap_Injected(ref RectInt rect, int destX, int destY, TerrainHeightmapSyncControl syncControl)
		{
			TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, destX, destY, syncControl);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002CBF File Offset: 0x00000EBF
		public void Internal_CopyActiveRenderTextureToHoles_Injected(ref RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
		{
			TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, destX, destY, allowDelayedCPUSync);
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumResolution;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumDetailResolutionPerPatch;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumDetailResolutionPerPatch;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumDetailPatchCount;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumAlphamapResolution;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumAlphamapResolution;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumBaseMapResolution;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumBaseMapResolution;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundaryValue_Private_Static_Int32_BoundaryValueType_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_TerrainData_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetAlphamapResolutionInternal_Internal_Single_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_users_Internal_get_Il2CppReferenceArray_1_Terrain_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04000070 RID: 112
		public const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface";

		// Token: 0x04000071 RID: 113
		public const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::";

		// Token: 0x04000072 RID: 114
		public const string k_HeightmapPrefix = "GetHeightmap().";

		// Token: 0x04000073 RID: 115
		public const string k_DetailDatabasePrefix = "GetDetailDatabase().";

		// Token: 0x04000074 RID: 116
		public const string k_TreeDatabasePrefix = "GetTreeDatabase().";

		// Token: 0x04000075 RID: 117
		public const string k_SplatDatabasePrefix = "GetSplatDatabase().";

		// Token: 0x04000076 RID: 118
		private static readonly TerrainData.get_heightmapTextureDelegate get_heightmapTextureDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly TerrainData.get_internalHeightmapResolutionDelegate get_internalHeightmapResolutionDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly TerrainData.set_internalHeightmapResolutionDelegate set_internalHeightmapResolutionDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly TerrainData.get_enableHolesTextureCompressionDelegate get_enableHolesTextureCompressionDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly TerrainData.set_enableHolesTextureCompressionDelegate set_enableHolesTextureCompressionDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly TerrainData.IsHolesTextureCompressedDelegate IsHolesTextureCompressedDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly TerrainData.GetHolesTextureDelegate GetHolesTextureDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly TerrainData.GetCompressedHolesTextureDelegate GetCompressedHolesTextureDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly TerrainData.GetHeightDelegate GetHeightDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly TerrainData.GetInterpolatedHeightDelegate GetInterpolatedHeightDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly TerrainData.GetMaximumHeightErrorDelegate GetMaximumHeightErrorDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly TerrainData.OverrideMaximumHeightErrorDelegate OverrideMaximumHeightErrorDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly TerrainData.Internal_IsHoleDelegate Internal_IsHoleDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly TerrainData.GetSteepnessDelegate GetSteepnessDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly TerrainData.GetAdjustedSizeDelegate GetAdjustedSizeDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly TerrainData.get_wavingGrassStrengthDelegate get_wavingGrassStrengthDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly TerrainData.set_wavingGrassStrengthDelegate set_wavingGrassStrengthDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly TerrainData.get_wavingGrassAmountDelegate get_wavingGrassAmountDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly TerrainData.set_wavingGrassAmountDelegate set_wavingGrassAmountDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly TerrainData.get_wavingGrassSpeedDelegate get_wavingGrassSpeedDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly TerrainData.set_wavingGrassSpeedDelegate set_wavingGrassSpeedDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly TerrainData.get_detailWidthDelegate get_detailWidthDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly TerrainData.get_detailHeightDelegate get_detailHeightDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly TerrainData.get_maxDetailScatterPerResDelegate get_maxDetailScatterPerResDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly TerrainData.Internal_SetDetailResolutionDelegate Internal_SetDetailResolutionDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly TerrainData.Internal_SetDetailScatterModeDelegate Internal_SetDetailScatterModeDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly TerrainData.get_detailPatchCountDelegate get_detailPatchCountDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly TerrainData.get_detailResolutionDelegate get_detailResolutionDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly TerrainData.get_detailResolutionPerPatchDelegate get_detailResolutionPerPatchDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly TerrainData.get_detailScatterModeDelegate get_detailScatterModeDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly TerrainData.ResetDirtyDetailsDelegate ResetDirtyDetailsDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly TerrainData.RefreshPrototypesDelegate RefreshPrototypesDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly TerrainData.get_detailPrototypesDelegate get_detailPrototypesDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly TerrainData.set_detailPrototypesDelegate set_detailPrototypesDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly TerrainData.GetSupportedLayersDelegate GetSupportedLayersDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly TerrainData.ComputeDetailCoverageDelegate ComputeDetailCoverageDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly TerrainData.get_treeInstanceCountDelegate get_treeInstanceCountDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly TerrainData.get_treePrototypesDelegate get_treePrototypesDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly TerrainData.set_treePrototypesDelegate set_treePrototypesDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly TerrainData.RemoveTreePrototypeDelegate RemoveTreePrototypeDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly TerrainData.RemoveDetailPrototypeDelegate RemoveDetailPrototypeDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly TerrainData.NeedUpgradeScaledTreePrototypesDelegate NeedUpgradeScaledTreePrototypesDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly TerrainData.UpgradeScaledTreePrototypeDelegate UpgradeScaledTreePrototypeDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly TerrainData.get_alphamapLayersDelegate get_alphamapLayersDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly TerrainData.get_Internal_alphamapResolutionDelegate get_Internal_alphamapResolutionDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly TerrainData.set_Internal_alphamapResolutionDelegate set_Internal_alphamapResolutionDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly TerrainData.get_Internal_baseMapResolutionDelegate get_Internal_baseMapResolutionDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly TerrainData.set_Internal_baseMapResolutionDelegate set_Internal_baseMapResolutionDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly TerrainData.SetBaseMapDirtyDelegate SetBaseMapDirtyDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly TerrainData.GetAlphamapTextureDelegate GetAlphamapTextureDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly TerrainData.get_alphamapTextureCountDelegate get_alphamapTextureCountDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly TerrainData.get_splatPrototypesDelegate get_splatPrototypesDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly TerrainData.set_splatPrototypesDelegate set_splatPrototypesDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly TerrainData.get_terrainLayersDelegate get_terrainLayersDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly TerrainData.set_terrainLayersDelegate set_terrainLayersDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly TerrainData.Internal_DirtyHeightmapRegionDelegate Internal_DirtyHeightmapRegionDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly TerrainData.SyncHeightmapDelegate SyncHeightmapDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly TerrainData.Internal_DirtyHolesRegionDelegate Internal_DirtyHolesRegionDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly TerrainData.Internal_SyncHolesDelegate Internal_SyncHolesDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly TerrainData.Internal_MarkAlphamapDirtyRegionDelegate Internal_MarkAlphamapDirtyRegionDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly TerrainData.Internal_ClearAlphamapDirtyRegionDelegate Internal_ClearAlphamapDirtyRegionDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly TerrainData.Internal_SyncAlphamapsDelegate Internal_SyncAlphamapsDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly TerrainData.get_atlasFormatDelegate get_atlasFormatDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly TerrainData.get_heightmapScale_InjectedDelegate get_heightmapScale_InjectedDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly TerrainData.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly TerrainData.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly TerrainData.GetInterpolatedNormal_InjectedDelegate GetInterpolatedNormal_InjectedDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly TerrainData.get_wavingGrassTint_InjectedDelegate get_wavingGrassTint_InjectedDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly TerrainData.set_wavingGrassTint_InjectedDelegate set_wavingGrassTint_InjectedDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly TerrainData.RemoveTrees_InjectedDelegate RemoveTrees_InjectedDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly TerrainData.Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly TerrainData.Internal_CopyActiveRenderTextureToHoles_InjectedDelegate Internal_CopyActiveRenderTextureToHoles_InjectedDelegateField;

		// Token: 0x02000073 RID: 115
		public enum BoundaryValueType
		{
			// Token: 0x04000135 RID: 309
			MaxHeightmapRes,
			// Token: 0x04000136 RID: 310
			MinDetailResPerPatch,
			// Token: 0x04000137 RID: 311
			MaxDetailResPerPatch,
			// Token: 0x04000138 RID: 312
			MaxDetailPatchCount,
			// Token: 0x04000139 RID: 313
			MaxCoveragePerRes,
			// Token: 0x0400013A RID: 314
			MinAlphamapRes,
			// Token: 0x0400013B RID: 315
			MaxAlphamapRes,
			// Token: 0x0400013C RID: 316
			MinBaseMapRes,
			// Token: 0x0400013D RID: 317
			MaxBaseMapRes
		}

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060002AB RID: 683
		private delegate IntPtr get_heightmapTextureDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060002AD RID: 685
		private delegate int get_internalHeightmapResolutionDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060002AF RID: 687
		private delegate void set_internalHeightmapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060002B1 RID: 689
		private delegate bool get_enableHolesTextureCompressionDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060002B3 RID: 691
		private delegate void set_enableHolesTextureCompressionDelegate(IntPtr @this, bool value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060002B5 RID: 693
		private delegate bool IsHolesTextureCompressedDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060002B7 RID: 695
		private delegate IntPtr GetHolesTextureDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060002B9 RID: 697
		private delegate IntPtr GetCompressedHolesTextureDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060002BB RID: 699
		private delegate float GetHeightDelegate(IntPtr @this, int x, int y);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002BD RID: 701
		private delegate float GetInterpolatedHeightDelegate(IntPtr @this, float x, float y);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002BF RID: 703
		private delegate IntPtr GetMaximumHeightErrorDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002C1 RID: 705
		private delegate void OverrideMaximumHeightErrorDelegate(IntPtr @this, IntPtr maxError);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002C3 RID: 707
		private delegate bool Internal_IsHoleDelegate(IntPtr @this, int x, int y);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060002C5 RID: 709
		private delegate float GetSteepnessDelegate(IntPtr @this, float x, float y);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060002C7 RID: 711
		private delegate int GetAdjustedSizeDelegate(IntPtr @this, int size);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060002C9 RID: 713
		private delegate float get_wavingGrassStrengthDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002CB RID: 715
		private delegate void set_wavingGrassStrengthDelegate(IntPtr @this, float value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060002CD RID: 717
		private delegate float get_wavingGrassAmountDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060002CF RID: 719
		private delegate void set_wavingGrassAmountDelegate(IntPtr @this, float value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060002D1 RID: 721
		private delegate float get_wavingGrassSpeedDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060002D3 RID: 723
		private delegate void set_wavingGrassSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060002D5 RID: 725
		private delegate int get_detailWidthDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060002D7 RID: 727
		private delegate int get_detailHeightDelegate(IntPtr @this);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060002D9 RID: 729
		private delegate int get_maxDetailScatterPerResDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060002DB RID: 731
		private delegate void Internal_SetDetailResolutionDelegate(IntPtr @this, int patchCount, int resolutionPerPatch);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060002DD RID: 733
		private delegate void Internal_SetDetailScatterModeDelegate(IntPtr @this, DetailScatterMode scatterMode);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060002DF RID: 735
		private delegate int get_detailPatchCountDelegate(IntPtr @this);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060002E1 RID: 737
		private delegate int get_detailResolutionDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060002E3 RID: 739
		private delegate int get_detailResolutionPerPatchDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002E5 RID: 741
		private delegate DetailScatterMode get_detailScatterModeDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060002E7 RID: 743
		private delegate void ResetDirtyDetailsDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060002E9 RID: 745
		private delegate void RefreshPrototypesDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060002EB RID: 747
		private delegate IntPtr get_detailPrototypesDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060002ED RID: 749
		private delegate void set_detailPrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060002EF RID: 751
		private delegate IntPtr GetSupportedLayersDelegate(IntPtr @this, int xBase, int yBase, int totalWidth, int totalHeight);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060002F1 RID: 753
		private delegate float ComputeDetailCoverageDelegate(IntPtr @this, int detailPrototypeIndex);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060002F3 RID: 755
		private delegate int get_treeInstanceCountDelegate(IntPtr @this);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060002F5 RID: 757
		private delegate IntPtr get_treePrototypesDelegate(IntPtr @this);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060002F7 RID: 759
		private delegate void set_treePrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060002F9 RID: 761
		private delegate void RemoveTreePrototypeDelegate(IntPtr @this, int index);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060002FB RID: 763
		private delegate void RemoveDetailPrototypeDelegate(IntPtr @this, int index);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060002FD RID: 765
		private delegate bool NeedUpgradeScaledTreePrototypesDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060002FF RID: 767
		private delegate void UpgradeScaledTreePrototypeDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000301 RID: 769
		private delegate int get_alphamapLayersDelegate(IntPtr @this);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000303 RID: 771
		private delegate int get_Internal_alphamapResolutionDelegate(IntPtr @this);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000305 RID: 773
		private delegate void set_Internal_alphamapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000307 RID: 775
		private delegate int get_Internal_baseMapResolutionDelegate(IntPtr @this);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000309 RID: 777
		private delegate void set_Internal_baseMapResolutionDelegate(IntPtr @this, int value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x0600030B RID: 779
		private delegate void SetBaseMapDirtyDelegate(IntPtr @this);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x0600030D RID: 781
		private delegate IntPtr GetAlphamapTextureDelegate(IntPtr @this, int index);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x0600030F RID: 783
		private delegate int get_alphamapTextureCountDelegate(IntPtr @this);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x06000311 RID: 785
		private delegate IntPtr get_splatPrototypesDelegate(IntPtr @this);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x06000313 RID: 787
		private delegate void set_splatPrototypesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000315 RID: 789
		private delegate IntPtr get_terrainLayersDelegate(IntPtr @this);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000317 RID: 791
		private delegate void set_terrainLayersDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000319 RID: 793
		private delegate void Internal_DirtyHeightmapRegionDelegate(IntPtr @this, int x, int y, int width, int height, TerrainHeightmapSyncControl syncControl);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x0600031B RID: 795
		private delegate void SyncHeightmapDelegate(IntPtr @this);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x0600031D RID: 797
		private delegate void Internal_DirtyHolesRegionDelegate(IntPtr @this, int x, int y, int width, int height, bool allowDelayedCPUSync);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x0600031F RID: 799
		private delegate void Internal_SyncHolesDelegate(IntPtr @this);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000321 RID: 801
		private delegate void Internal_MarkAlphamapDirtyRegionDelegate(IntPtr @this, int alphamapIndex, int x, int y, int width, int height);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000323 RID: 803
		private delegate void Internal_ClearAlphamapDirtyRegionDelegate(IntPtr @this, int alphamapIndex);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000325 RID: 805
		private delegate void Internal_SyncAlphamapsDelegate(IntPtr @this);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000327 RID: 807
		private delegate TextureFormat get_atlasFormatDelegate(IntPtr @this);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000329 RID: 809
		private delegate void get_heightmapScale_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x0600032B RID: 811
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600032D RID: 813
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x0600032F RID: 815
		private delegate void GetInterpolatedNormal_InjectedDelegate(IntPtr @this, float x, float y, [Out] IntPtr ret);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000331 RID: 817
		private delegate void get_wavingGrassTint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000333 RID: 819
		private delegate void set_wavingGrassTint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000335 RID: 821
		private delegate int RemoveTrees_InjectedDelegate(IntPtr @this, IntPtr position, float radius, int prototypeIndex);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000337 RID: 823
		private delegate void Internal_CopyActiveRenderTextureToHeightmap_InjectedDelegate(IntPtr @this, IntPtr rect, int destX, int destY, TerrainHeightmapSyncControl syncControl);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000339 RID: 825
		private delegate void Internal_CopyActiveRenderTextureToHoles_InjectedDelegate(IntPtr @this, IntPtr rect, int destX, int destY, bool allowDelayedCPUSync);
	}
}

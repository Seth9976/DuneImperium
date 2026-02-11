using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000005 RID: 5
	public sealed class Tilemap : GridLayout
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003D78 File Offset: 0x00001F78
		// Note: this type is marked as 'beforefieldinit'.
		static Tilemap()
		{
			Il2CppClassPointerStore<Tilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "Tilemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tilemap>.NativeClassPtr);
			Tilemap.NativeFieldInfoPtr_tilemapTileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "tilemapTileChanged");
			Tilemap.NativeFieldInfoPtr_tilemapPositionsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "tilemapPositionsChanged");
			Tilemap.NativeFieldInfoPtr_m_BufferSyncTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "m_BufferSyncTile");
			Tilemap.NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663325);
			Tilemap.NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663326);
			Tilemap.NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663327);
			Tilemap.NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663328);
			Tilemap.NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663329);
			Tilemap.NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663330);
			Tilemap.NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663331);
			Tilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663332);
			Tilemap.NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663333);
			Tilemap.NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663334);
			Tilemap.NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663335);
			Tilemap.NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663336);
			Tilemap.NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, 100663337);
			Tilemap.get_layoutGridDelegateField = IL2CPP.ResolveICall<Tilemap.get_layoutGridDelegate>("UnityEngine.Tilemaps.Tilemap::get_layoutGrid");
			Tilemap.get_animationFrameRateDelegateField = IL2CPP.ResolveICall<Tilemap.get_animationFrameRateDelegate>("UnityEngine.Tilemaps.Tilemap::get_animationFrameRate");
			Tilemap.set_animationFrameRateDelegateField = IL2CPP.ResolveICall<Tilemap.set_animationFrameRateDelegate>("UnityEngine.Tilemaps.Tilemap::set_animationFrameRate");
			Tilemap.get_orientationDelegateField = IL2CPP.ResolveICall<Tilemap.get_orientationDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientation");
			Tilemap.set_orientationDelegateField = IL2CPP.ResolveICall<Tilemap.set_orientationDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientation");
			Tilemap.SetTileAssetsDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileAssetsDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAssets");
			Tilemap.SetTilesDelegateField = IL2CPP.ResolveICall<Tilemap.SetTilesDelegate>("UnityEngine.Tilemaps.Tilemap::SetTiles");
			Tilemap.RefreshAllTilesDelegateField = IL2CPP.ResolveICall<Tilemap.RefreshAllTilesDelegate>("UnityEngine.Tilemaps.Tilemap::RefreshAllTiles");
			Tilemap.SwapTileAssetDelegateField = IL2CPP.ResolveICall<Tilemap.SwapTileAssetDelegate>("UnityEngine.Tilemaps.Tilemap::SwapTileAsset");
			Tilemap.ContainsTileAssetDelegateField = IL2CPP.ResolveICall<Tilemap.ContainsTileAssetDelegate>("UnityEngine.Tilemaps.Tilemap::ContainsTileAsset");
			Tilemap.GetUsedTilesCountDelegateField = IL2CPP.ResolveICall<Tilemap.GetUsedTilesCountDelegate>("UnityEngine.Tilemaps.Tilemap::GetUsedTilesCount");
			Tilemap.GetUsedSpritesCountDelegateField = IL2CPP.ResolveICall<Tilemap.GetUsedSpritesCountDelegate>("UnityEngine.Tilemaps.Tilemap::GetUsedSpritesCount");
			Tilemap.Internal_GetUsedTilesNonAllocDelegateField = IL2CPP.ResolveICall<Tilemap.Internal_GetUsedTilesNonAllocDelegate>("UnityEngine.Tilemaps.Tilemap::Internal_GetUsedTilesNonAlloc");
			Tilemap.Internal_GetUsedSpritesNonAllocDelegateField = IL2CPP.ResolveICall<Tilemap.Internal_GetUsedSpritesNonAllocDelegate>("UnityEngine.Tilemaps.Tilemap::Internal_GetUsedSpritesNonAlloc");
			Tilemap.ClearAllTilesDelegateField = IL2CPP.ResolveICall<Tilemap.ClearAllTilesDelegate>("UnityEngine.Tilemaps.Tilemap::ClearAllTiles");
			Tilemap.ResizeBoundsDelegateField = IL2CPP.ResolveICall<Tilemap.ResizeBoundsDelegate>("UnityEngine.Tilemaps.Tilemap::ResizeBounds");
			Tilemap.CompressBoundsDelegateField = IL2CPP.ResolveICall<Tilemap.CompressBoundsDelegate>("UnityEngine.Tilemaps.Tilemap::CompressBounds");
			Tilemap.SendAndClearSyncTileBufferDelegateField = IL2CPP.ResolveICall<Tilemap.SendAndClearSyncTileBufferDelegate>("UnityEngine.Tilemaps.Tilemap::SendAndClearSyncTileBuffer");
			Tilemap.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_localBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localBounds_Injected");
			Tilemap.get_localFrameBounds_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_localFrameBounds_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_localFrameBounds_Injected");
			Tilemap.get_color_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_color_Injected");
			Tilemap.set_color_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_color_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_color_Injected");
			Tilemap.get_origin_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_origin_Injected");
			Tilemap.set_origin_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_origin_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_origin_Injected");
			Tilemap.get_size_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_size_Injected");
			Tilemap.set_size_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_size_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_size_Injected");
			Tilemap.get_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_tileAnchor_Injected");
			Tilemap.set_tileAnchor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_tileAnchor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_tileAnchor_Injected");
			Tilemap.get_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.get_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::get_orientationMatrix_Injected");
			Tilemap.set_orientationMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.set_orientationMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::set_orientationMatrix_Injected");
			Tilemap.GetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAsset_Injected");
			Tilemap.GetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsBlock_Injected");
			Tilemap.GetTileAssetsBlockNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAssetsBlockNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsBlockNonAlloc_Injected");
			Tilemap.GetTilesRangeCount_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTilesRangeCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTilesRangeCount_Injected");
			Tilemap.GetTileAssetsRangeNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAssetsRangeNonAlloc_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAssetsRangeNonAlloc_Injected");
			Tilemap.SetTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAsset_Injected");
			Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::INTERNAL_CALL_SetTileAssetsBlock_Injected");
			Tilemap.SetTile_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTile_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTile_Injected");
			Tilemap.GetSprite_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetSprite_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetSprite_Injected");
			Tilemap.GetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTransformMatrix_Injected");
			Tilemap.SetTransformMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTransformMatrix_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTransformMatrix_Injected");
			Tilemap.GetColor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColor_Injected");
			Tilemap.SetColor_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetColor_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColor_Injected");
			Tilemap.GetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileFlags_Injected");
			Tilemap.SetTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileFlags_Injected");
			Tilemap.AddTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.AddTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::AddTileFlags_Injected");
			Tilemap.RemoveTileFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.RemoveTileFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RemoveTileFlags_Injected");
			Tilemap.GetInstantiatedObject_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetInstantiatedObject_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetInstantiatedObject_Injected");
			Tilemap.GetObjectToInstantiate_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetObjectToInstantiate_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetObjectToInstantiate_Injected");
			Tilemap.SetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetColliderType_Injected");
			Tilemap.GetColliderType_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetColliderType_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetColliderType_Injected");
			Tilemap.GetAnimationFrameCount_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetAnimationFrameCount_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationFrameCount_Injected");
			Tilemap.GetAnimationFrame_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetAnimationFrame_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationFrame_Injected");
			Tilemap.SetAnimationFrame_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetAnimationFrame_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetAnimationFrame_Injected");
			Tilemap.GetAnimationTime_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetAnimationTime_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetAnimationTime_Injected");
			Tilemap.SetAnimationTime_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetAnimationTime_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetAnimationTime_Injected");
			Tilemap.GetTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.GetTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::GetTileAnimationFlags_Injected");
			Tilemap.SetTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.SetTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::SetTileAnimationFlags_Injected");
			Tilemap.AddTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.AddTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::AddTileAnimationFlags_Injected");
			Tilemap.RemoveTileAnimationFlags_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.RemoveTileAnimationFlags_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::RemoveTileAnimationFlags_Injected");
			Tilemap.FloodFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.FloodFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::FloodFillTileAsset_Injected");
			Tilemap.BoxFillTileAsset_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.BoxFillTileAsset_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::BoxFillTileAsset_Injected");
			Tilemap.InsertCells_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.InsertCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::InsertCells_Injected");
			Tilemap.DeleteCells_InjectedDelegateField = IL2CPP.ResolveICall<Tilemap.DeleteCells_InjectedDelegate>("UnityEngine.Tilemaps.Tilemap::DeleteCells_Injected");
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004674 File Offset: 0x00002874
		public unsafe bool bufferSyncTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value && this.m_BufferSyncTile != value && Tilemap.HasSyncTileCallback();
				if (flag)
				{
					this.SendAndClearSyncTileBuffer();
				}
				this.m_BufferSyncTile = value;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000042E4 File Offset: 0x000024E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268915, XrefRangeEnd = 1268917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSyncTileCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004314 File Offset: 0x00002514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268917, XrefRangeEnd = 1268919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasPositionsChangedCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004344 File Offset: 0x00002544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268919, XrefRangeEnd = 1268922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSyncTileCallback(Il2CppReferenceArray<Tilemap.SyncTile> syncTiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncTiles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004388 File Offset: 0x00002588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268922, XrefRangeEnd = 1268928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000043D4 File Offset: 0x000025D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1268934, RefRangeEnd = 1268936, XrefRangeStart = 1268928, XrefRangeEnd = 1268934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTilemapTileChangedCallback(Il2CppReferenceArray<Tilemap.SyncTile> syncTiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncTiles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004418 File Offset: 0x00002618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1268942, RefRangeEnd = 1268944, XrefRangeStart = 1268936, XrefRangeEnd = 1268942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004460 File Offset: 0x00002660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268944, XrefRangeEnd = 1268946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile(Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000044A0 File Offset: 0x000026A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268946, XrefRangeEnd = 1268948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTilesNative(void* positions, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = positions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000044EC File Offset: 0x000026EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268948, XrefRangeEnd = 1268952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSyncTileCallbackSettings(ref Tilemap.SyncTileCallbackSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000452C File Offset: 0x0000272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSyncTileCallback(Il2CppReferenceArray<Tilemap.SyncTile> syncTiles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncTiles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004570 File Offset: 0x00002770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000045BC File Offset: 0x000027BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268952, XrefRangeEnd = 1268954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile_Injected(ref Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tilemap.NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000021B4 File Offset: 0x000003B4
		public Tilemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000045FC File Offset: 0x000027FC
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021BD File Offset: 0x000003BD
		public unsafe static Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>> tilemapTileChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Tilemap.NativeFieldInfoPtr_tilemapTileChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tilemap.NativeFieldInfoPtr_tilemapTileChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004624 File Offset: 0x00002824
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000021CF File Offset: 0x000003CF
		public unsafe static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Tilemap.NativeFieldInfoPtr_tilemapPositionsChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Tilemap, NativeArray<Vector3Int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tilemap.NativeFieldInfoPtr_tilemapPositionsChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000021E1 File Offset: 0x000003E1
		public unsafe bool m_BufferSyncTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.NativeFieldInfoPtr_m_BufferSyncTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.NativeFieldInfoPtr_m_BufferSyncTile)) = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021FC File Offset: 0x000003FC
		public static void add_tilemapTileChanged(Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002209 File Offset: 0x00000409
		public static void remove_tilemapTileChanged(Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002216 File Offset: 0x00000416
		public static void add_tilemapPositionsChanged(Action<Tilemap, NativeArray<Vector3Int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002223 File Offset: 0x00000423
		public static void remove_tilemapPositionsChanged(Action<Tilemap, NativeArray<Vector3Int>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002230 File Offset: 0x00000430
		public static void SetSyncTileCallback(Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>> callback)
		{
			Tilemap.add_tilemapTileChanged(callback);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000223A File Offset: 0x0000043A
		public static void RemoveSyncTileCallback(Action<Tilemap, Il2CppReferenceArray<Tilemap.SyncTile>> callback)
		{
			Tilemap.remove_tilemapTileChanged(callback);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000046A8 File Offset: 0x000028A8
		public Grid layoutGrid
		{
			get
			{
				IntPtr intPtr = Tilemap.get_layoutGridDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000046D4 File Offset: 0x000028D4
		public Vector3 GetCellCenterLocal(Vector3Int position)
		{
			return base.CellToLocalInterpolated(position) + base.CellToLocalInterpolated(this.tileAnchor);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004704 File Offset: 0x00002904
		public Vector3 GetCellCenterWorld(Vector3Int position)
		{
			return base.LocalToWorld(base.CellToLocalInterpolated(position) + base.CellToLocalInterpolated(this.tileAnchor));
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000473C File Offset: 0x0000293C
		public BoundsInt cellBounds
		{
			get
			{
				return new BoundsInt(this.origin, this.size);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004760 File Offset: 0x00002960
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004778 File Offset: 0x00002978
		public Bounds localFrameBounds
		{
			get
			{
				Bounds bounds;
				this.get_localFrameBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002244 File Offset: 0x00000444
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002256 File Offset: 0x00000456
		public float animationFrameRate
		{
			get
			{
				return Tilemap.get_animationFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Tilemap.set_animationFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004790 File Offset: 0x00002990
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002269 File Offset: 0x00000469
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000047A8 File Offset: 0x000029A8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002273 File Offset: 0x00000473
		public Vector3Int origin
		{
			get
			{
				Vector3Int vector3Int;
				this.get_origin_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_origin_Injected(ref value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000047C0 File Offset: 0x000029C0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000227D File Offset: 0x0000047D
		public Vector3Int size
		{
			get
			{
				Vector3Int vector3Int;
				this.get_size_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000047D8 File Offset: 0x000029D8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002287 File Offset: 0x00000487
		public Vector3 tileAnchor
		{
			get
			{
				Vector3 vector;
				this.get_tileAnchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileAnchor_Injected(ref value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002291 File Offset: 0x00000491
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022A3 File Offset: 0x000004A3
		public Tilemap.Orientation orientation
		{
			get
			{
				return Tilemap.get_orientationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Tilemap.set_orientationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000047F0 File Offset: 0x000029F0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022B6 File Offset: 0x000004B6
		public Matrix4x4 orientationMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_orientationMatrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_orientationMatrix_Injected(ref value);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022C0 File Offset: 0x000004C0
		public Object GetTileAsset(Vector3Int position)
		{
			return this.GetTileAsset_Injected(ref position);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004808 File Offset: 0x00002A08
		public TileBase GetTile(Vector3Int position)
		{
			return this.GetTileAsset(position).TryCast<TileBase>();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004828 File Offset: 0x00002A28
		public T GetTile<T>(Vector3Int position) where T : TileBase
		{
			return this.GetTileAsset(position).TryCast<T>().Cast<T>();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000022CA File Offset: 0x000004CA
		public Il2CppReferenceArray<Object> GetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions)
		{
			return this.GetTileAssetsBlock_Injected(ref position, ref blockDimensions);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022D6 File Offset: 0x000004D6
		public Il2CppReferenceArray<TileBase> GetTilesBlock(BoundsInt bounds)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000022E3 File Offset: 0x000004E3
		public int GetTileAssetsBlockNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppReferenceArray<Object> tiles)
		{
			return this.GetTileAssetsBlockNonAlloc_Injected(ref startPosition, ref endPosition, tiles);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000484C File Offset: 0x00002A4C
		public int GetTilesBlockNonAlloc(BoundsInt bounds, Il2CppReferenceArray<TileBase> tiles)
		{
			return this.GetTileAssetsBlockNonAlloc(bounds.min, bounds.size, tiles);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000022F0 File Offset: 0x000004F0
		public int GetTilesRangeCount(Vector3Int startPosition, Vector3Int endPosition)
		{
			return this.GetTilesRangeCount_Injected(ref startPosition, ref endPosition);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022FC File Offset: 0x000004FC
		public int GetTileAssetsRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppStructArray<Vector3Int> positions, Il2CppReferenceArray<Object> tiles)
		{
			return this.GetTileAssetsRangeNonAlloc_Injected(ref startPosition, ref endPosition, positions, tiles);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004878 File Offset: 0x00002A78
		public int GetTilesRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Il2CppStructArray<Vector3Int> positions, Il2CppReferenceArray<TileBase> tiles)
		{
			return this.GetTileAssetsRangeNonAlloc(startPosition, endPosition, positions, tiles);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000230B File Offset: 0x0000050B
		public void SetTileAsset(Vector3Int position, Object tile)
		{
			this.SetTileAsset_Injected(ref position, tile);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002316 File Offset: 0x00000516
		public void SetTile(Vector3Int position, TileBase tile)
		{
			this.SetTileAsset(position, tile);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002322 File Offset: 0x00000522
		public void SetTileAssets(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<Object> tileArray)
		{
			Tilemap.SetTileAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positionArray), IL2CPP.Il2CppObjectBaseToPtr(tileArray));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004898 File Offset: 0x00002A98
		public void SetTiles(Il2CppStructArray<Vector3Int> positionArray, Il2CppReferenceArray<TileBase> tileArray)
		{
			this.SetTileAssets(positionArray, tileArray);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002340 File Offset: 0x00000540
		public void INTERNAL_CALL_SetTileAssetsBlock(Vector3Int position, Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
		{
			this.INTERNAL_CALL_SetTileAssetsBlock_Injected(ref position, ref blockDimensions, tileArray);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000048B4 File Offset: 0x00002AB4
		public void SetTilesBlock(BoundsInt position, Il2CppReferenceArray<TileBase> tileArray)
		{
			this.INTERNAL_CALL_SetTileAssetsBlock(position.min, position.size, tileArray);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000234D File Offset: 0x0000054D
		public void SetTile(TileChangeData tileChangeData, bool ignoreLockFlags)
		{
			this.SetTile_Injected(ref tileChangeData, ignoreLockFlags);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002358 File Offset: 0x00000558
		public void SetTiles(Il2CppReferenceArray<TileChangeData> tileChangeDataArray, bool ignoreLockFlags)
		{
			Tilemap.SetTilesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tileChangeDataArray), ignoreLockFlags);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000048DC File Offset: 0x00002ADC
		public bool HasTile(Vector3Int position)
		{
			return this.GetTileAsset(position) != null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002371 File Offset: 0x00000571
		public void RefreshAllTiles()
		{
			Tilemap.RefreshAllTilesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002383 File Offset: 0x00000583
		public void SwapTileAsset(Object changeTile, Object newTile)
		{
			Tilemap.SwapTileAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(changeTile), IL2CPP.Il2CppObjectBaseToPtr(newTile));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000023A1 File Offset: 0x000005A1
		public void SwapTile(TileBase changeTile, TileBase newTile)
		{
			this.SwapTileAsset(changeTile, newTile);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000023AD File Offset: 0x000005AD
		public bool ContainsTileAsset(Object tileAsset)
		{
			return Tilemap.ContainsTileAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(tileAsset));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000048FC File Offset: 0x00002AFC
		public bool ContainsTile(TileBase tileAsset)
		{
			return this.ContainsTileAsset(tileAsset);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000023C5 File Offset: 0x000005C5
		public int GetUsedTilesCount()
		{
			return Tilemap.GetUsedTilesCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000023D7 File Offset: 0x000005D7
		public int GetUsedSpritesCount()
		{
			return Tilemap.GetUsedSpritesCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004918 File Offset: 0x00002B18
		public int GetUsedTilesNonAlloc(Il2CppReferenceArray<TileBase> usedTiles)
		{
			return this.Internal_GetUsedTilesNonAlloc(usedTiles);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004934 File Offset: 0x00002B34
		public int GetUsedSpritesNonAlloc(Il2CppReferenceArray<Sprite> usedSprites)
		{
			return this.Internal_GetUsedSpritesNonAlloc(usedSprites);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000023E9 File Offset: 0x000005E9
		public int Internal_GetUsedTilesNonAlloc(Il2CppReferenceArray<Object> usedTiles)
		{
			return Tilemap.Internal_GetUsedTilesNonAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(usedTiles));
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002401 File Offset: 0x00000601
		public int Internal_GetUsedSpritesNonAlloc(Il2CppReferenceArray<Object> usedSprites)
		{
			return Tilemap.Internal_GetUsedSpritesNonAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(usedSprites));
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002419 File Offset: 0x00000619
		public Sprite GetSprite(Vector3Int position)
		{
			return this.GetSprite_Injected(ref position);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004950 File Offset: 0x00002B50
		public Matrix4x4 GetTransformMatrix(Vector3Int position)
		{
			Matrix4x4 matrix4x;
			this.GetTransformMatrix_Injected(ref position, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002423 File Offset: 0x00000623
		public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform)
		{
			this.SetTransformMatrix_Injected(ref position, ref transform);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004968 File Offset: 0x00002B68
		public Color GetColor(Vector3Int position)
		{
			Color color;
			this.GetColor_Injected(ref position, out color);
			return color;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000242F File Offset: 0x0000062F
		public void SetColor(Vector3Int position, Color color)
		{
			this.SetColor_Injected(ref position, ref color);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000243B File Offset: 0x0000063B
		public TileFlags GetTileFlags(Vector3Int position)
		{
			return this.GetTileFlags_Injected(ref position);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002445 File Offset: 0x00000645
		public void SetTileFlags(Vector3Int position, TileFlags flags)
		{
			this.SetTileFlags_Injected(ref position, flags);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002450 File Offset: 0x00000650
		public void AddTileFlags(Vector3Int position, TileFlags flags)
		{
			this.AddTileFlags_Injected(ref position, flags);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000245B File Offset: 0x0000065B
		public void RemoveTileFlags(Vector3Int position, TileFlags flags)
		{
			this.RemoveTileFlags_Injected(ref position, flags);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002466 File Offset: 0x00000666
		public GameObject GetInstantiatedObject(Vector3Int position)
		{
			return this.GetInstantiatedObject_Injected(ref position);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002470 File Offset: 0x00000670
		public GameObject GetObjectToInstantiate(Vector3Int position)
		{
			return this.GetObjectToInstantiate_Injected(ref position);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000247A File Offset: 0x0000067A
		public void SetColliderType(Vector3Int position, Tile.ColliderType colliderType)
		{
			this.SetColliderType_Injected(ref position, colliderType);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002485 File Offset: 0x00000685
		public Tile.ColliderType GetColliderType(Vector3Int position)
		{
			return this.GetColliderType_Injected(ref position);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000248F File Offset: 0x0000068F
		public int GetAnimationFrameCount(Vector3Int position)
		{
			return this.GetAnimationFrameCount_Injected(ref position);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002499 File Offset: 0x00000699
		public int GetAnimationFrame(Vector3Int position)
		{
			return this.GetAnimationFrame_Injected(ref position);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000024A3 File Offset: 0x000006A3
		public void SetAnimationFrame(Vector3Int position, int frame)
		{
			this.SetAnimationFrame_Injected(ref position, frame);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000024AE File Offset: 0x000006AE
		public float GetAnimationTime(Vector3Int position)
		{
			return this.GetAnimationTime_Injected(ref position);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000024B8 File Offset: 0x000006B8
		public void SetAnimationTime(Vector3Int position, float time)
		{
			this.SetAnimationTime_Injected(ref position, time);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000024C3 File Offset: 0x000006C3
		public TileAnimationFlags GetTileAnimationFlags(Vector3Int position)
		{
			return this.GetTileAnimationFlags_Injected(ref position);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000024CD File Offset: 0x000006CD
		public void SetTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
		{
			this.SetTileAnimationFlags_Injected(ref position, flags);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000024D8 File Offset: 0x000006D8
		public void AddTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
		{
			this.AddTileAnimationFlags_Injected(ref position, flags);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000024E3 File Offset: 0x000006E3
		public void RemoveTileAnimationFlags(Vector3Int position, TileAnimationFlags flags)
		{
			this.RemoveTileAnimationFlags_Injected(ref position, flags);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000024EE File Offset: 0x000006EE
		public void FloodFill(Vector3Int position, TileBase tile)
		{
			this.FloodFillTileAsset(position, tile);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000024FA File Offset: 0x000006FA
		public void FloodFillTileAsset(Vector3Int position, Object tile)
		{
			this.FloodFillTileAsset_Injected(ref position, tile);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002505 File Offset: 0x00000705
		public void BoxFill(Vector3Int position, TileBase tile, int startX, int startY, int endX, int endY)
		{
			this.BoxFillTileAsset(position, tile, startX, startY, endX, endY);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002518 File Offset: 0x00000718
		public void BoxFillTileAsset(Vector3Int position, Object tile, int startX, int startY, int endX, int endY)
		{
			this.BoxFillTileAsset_Injected(ref position, tile, startX, startY, endX, endY);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000252A File Offset: 0x0000072A
		public void InsertCells(Vector3Int position, Vector3Int insertCells)
		{
			this.InsertCells(position, insertCells.x, insertCells.y, insertCells.z);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000254A File Offset: 0x0000074A
		public void InsertCells(Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			this.InsertCells_Injected(ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002558 File Offset: 0x00000758
		public void DeleteCells(Vector3Int position, Vector3Int deleteCells)
		{
			this.DeleteCells(position, deleteCells.x, deleteCells.y, deleteCells.z);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002578 File Offset: 0x00000778
		public void DeleteCells(Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			this.DeleteCells_Injected(ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002586 File Offset: 0x00000786
		public void ClearAllTiles()
		{
			Tilemap.ClearAllTilesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002598 File Offset: 0x00000798
		public void ResizeBounds()
		{
			Tilemap.ResizeBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000025AA File Offset: 0x000007AA
		public void CompressBounds()
		{
			Tilemap.CompressBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000025BC File Offset: 0x000007BC
		public void SendAndClearSyncTileBuffer()
		{
			Tilemap.SendAndClearSyncTileBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000025CE File Offset: 0x000007CE
		public void get_localBounds_Injected(out Bounds ret)
		{
			Tilemap.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000025E1 File Offset: 0x000007E1
		public void get_localFrameBounds_Injected(out Bounds ret)
		{
			Tilemap.get_localFrameBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000025F4 File Offset: 0x000007F4
		public void get_color_Injected(out Color ret)
		{
			Tilemap.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002607 File Offset: 0x00000807
		public void set_color_Injected(ref Color value)
		{
			Tilemap.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000261A File Offset: 0x0000081A
		public void get_origin_Injected(out Vector3Int ret)
		{
			Tilemap.get_origin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000262D File Offset: 0x0000082D
		public void set_origin_Injected(ref Vector3Int value)
		{
			Tilemap.set_origin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002640 File Offset: 0x00000840
		public void get_size_Injected(out Vector3Int ret)
		{
			Tilemap.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002653 File Offset: 0x00000853
		public void set_size_Injected(ref Vector3Int value)
		{
			Tilemap.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002666 File Offset: 0x00000866
		public void get_tileAnchor_Injected(out Vector3 ret)
		{
			Tilemap.get_tileAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002679 File Offset: 0x00000879
		public void set_tileAnchor_Injected(ref Vector3 value)
		{
			Tilemap.set_tileAnchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000268C File Offset: 0x0000088C
		public void get_orientationMatrix_Injected(out Matrix4x4 ret)
		{
			Tilemap.get_orientationMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000269F File Offset: 0x0000089F
		public void set_orientationMatrix_Injected(ref Matrix4x4 value)
		{
			Tilemap.set_orientationMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004980 File Offset: 0x00002B80
		public Object GetTileAsset_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000049B0 File Offset: 0x00002BB0
		public Il2CppReferenceArray<Object> GetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions)
		{
			IntPtr intPtr = Tilemap.GetTileAssetsBlock_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref blockDimensions);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000026B2 File Offset: 0x000008B2
		public int GetTileAssetsBlockNonAlloc_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition, Il2CppReferenceArray<Object> tiles)
		{
			return Tilemap.GetTileAssetsBlockNonAlloc_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref startPosition, ref endPosition, IL2CPP.Il2CppObjectBaseToPtr(tiles));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000026CC File Offset: 0x000008CC
		public int GetTilesRangeCount_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition)
		{
			return Tilemap.GetTilesRangeCount_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref startPosition, ref endPosition);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000026E0 File Offset: 0x000008E0
		public int GetTileAssetsRangeNonAlloc_Injected(ref Vector3Int startPosition, ref Vector3Int endPosition, Il2CppStructArray<Vector3Int> positions, Il2CppReferenceArray<Object> tiles)
		{
			return Tilemap.GetTileAssetsRangeNonAlloc_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref startPosition, ref endPosition, IL2CPP.Il2CppObjectBaseToPtr(positions), IL2CPP.Il2CppObjectBaseToPtr(tiles));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002701 File Offset: 0x00000901
		public void SetTileAsset_Injected(ref Vector3Int position, Object tile)
		{
			Tilemap.SetTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile));
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000271A File Offset: 0x0000091A
		public void INTERNAL_CALL_SetTileAssetsBlock_Injected(ref Vector3Int position, ref Vector3Int blockDimensions, Il2CppReferenceArray<Object> tileArray)
		{
			Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref blockDimensions, IL2CPP.Il2CppObjectBaseToPtr(tileArray));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000049E0 File Offset: 0x00002BE0
		public unsafe void SetTile_Injected(ref TileChangeData tileChangeData, bool ignoreLockFlags)
		{
			Tilemap.SetTile_InjectedDelegate setTile_InjectedDelegateField = Tilemap.SetTile_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(tileChangeData);
			setTile_InjectedDelegateField(intPtr, &intPtr2, ignoreLockFlags);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004A0C File Offset: 0x00002C0C
		public Sprite GetSprite_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetSprite_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002734 File Offset: 0x00000934
		public void GetTransformMatrix_Injected(ref Vector3Int position, out Matrix4x4 ret)
		{
			Tilemap.GetTransformMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002748 File Offset: 0x00000948
		public void SetTransformMatrix_Injected(ref Vector3Int position, ref Matrix4x4 transform)
		{
			Tilemap.SetTransformMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref transform);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000275C File Offset: 0x0000095C
		public void GetColor_Injected(ref Vector3Int position, out Color ret)
		{
			Tilemap.GetColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002770 File Offset: 0x00000970
		public void SetColor_Injected(ref Vector3Int position, ref Color color)
		{
			Tilemap.SetColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref color);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002784 File Offset: 0x00000984
		public TileFlags GetTileFlags_Injected(ref Vector3Int position)
		{
			return Tilemap.GetTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002797 File Offset: 0x00000997
		public void SetTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.SetTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000027AB File Offset: 0x000009AB
		public void AddTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.AddTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000027BF File Offset: 0x000009BF
		public void RemoveTileFlags_Injected(ref Vector3Int position, TileFlags flags)
		{
			Tilemap.RemoveTileFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004A3C File Offset: 0x00002C3C
		public GameObject GetInstantiatedObject_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetInstantiatedObject_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004A6C File Offset: 0x00002C6C
		public GameObject GetObjectToInstantiate_Injected(ref Vector3Int position)
		{
			IntPtr intPtr = Tilemap.GetObjectToInstantiate_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000027D3 File Offset: 0x000009D3
		public void SetColliderType_Injected(ref Vector3Int position, Tile.ColliderType colliderType)
		{
			Tilemap.SetColliderType_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, colliderType);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000027E7 File Offset: 0x000009E7
		public Tile.ColliderType GetColliderType_Injected(ref Vector3Int position)
		{
			return Tilemap.GetColliderType_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000027FA File Offset: 0x000009FA
		public int GetAnimationFrameCount_Injected(ref Vector3Int position)
		{
			return Tilemap.GetAnimationFrameCount_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000280D File Offset: 0x00000A0D
		public int GetAnimationFrame_Injected(ref Vector3Int position)
		{
			return Tilemap.GetAnimationFrame_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002820 File Offset: 0x00000A20
		public void SetAnimationFrame_Injected(ref Vector3Int position, int frame)
		{
			Tilemap.SetAnimationFrame_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, frame);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002834 File Offset: 0x00000A34
		public float GetAnimationTime_Injected(ref Vector3Int position)
		{
			return Tilemap.GetAnimationTime_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002847 File Offset: 0x00000A47
		public void SetAnimationTime_Injected(ref Vector3Int position, float time)
		{
			Tilemap.SetAnimationTime_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, time);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000285B File Offset: 0x00000A5B
		public TileAnimationFlags GetTileAnimationFlags_Injected(ref Vector3Int position)
		{
			return Tilemap.GetTileAnimationFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000286E File Offset: 0x00000A6E
		public void SetTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags)
		{
			Tilemap.SetTileAnimationFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002882 File Offset: 0x00000A82
		public void AddTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags)
		{
			Tilemap.AddTileAnimationFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002896 File Offset: 0x00000A96
		public void RemoveTileAnimationFlags_Injected(ref Vector3Int position, TileAnimationFlags flags)
		{
			Tilemap.RemoveTileAnimationFlags_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, flags);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000028AA File Offset: 0x00000AAA
		public void FloodFillTileAsset_Injected(ref Vector3Int position, Object tile)
		{
			Tilemap.FloodFillTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000028C3 File Offset: 0x00000AC3
		public void BoxFillTileAsset_Injected(ref Vector3Int position, Object tile, int startX, int startY, int endX, int endY)
		{
			Tilemap.BoxFillTileAsset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, IL2CPP.Il2CppObjectBaseToPtr(tile), startX, startY, endX, endY);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000028E3 File Offset: 0x00000AE3
		public void InsertCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			Tilemap.InsertCells_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000028FA File Offset: 0x00000AFA
		public void DeleteCells_Injected(ref Vector3Int position, int numColumns, int numRows, int numLayers)
		{
			Tilemap.DeleteCells_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, numColumns, numRows, numLayers);
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_tilemapTileChanged;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_tilemapPositionsChanged;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferSyncTile;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_bufferSyncTile_Internal_get_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_HasSyncTileCallback_Internal_Static_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_HasPositionsChangedCallback_Internal_Static_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_HandleSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_HandlePositionsChangedCallback_Private_Void_Int32_IntPtr_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_SendTilemapTileChangedCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_SendTilemapPositionsChangedCallback_Private_Void_NativeArray_1_Vector3Int_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTilesNative_Internal_Void_ptr_Void_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetSyncTileCallbackSettings_Internal_Void_byref_SyncTileCallbackSettings_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_DoSyncTileCallback_Private_Void_Il2CppReferenceArray_1_SyncTile_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_DoPositionsChangedCallback_Private_Void_Int32_IntPtr_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Injected_Private_Void_byref_Vector3Int_0;

		// Token: 0x04000038 RID: 56
		private static readonly Tilemap.get_layoutGridDelegate get_layoutGridDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Tilemap.get_animationFrameRateDelegate get_animationFrameRateDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Tilemap.set_animationFrameRateDelegate set_animationFrameRateDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Tilemap.get_orientationDelegate get_orientationDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Tilemap.set_orientationDelegate set_orientationDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Tilemap.SetTileAssetsDelegate SetTileAssetsDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Tilemap.SetTilesDelegate SetTilesDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Tilemap.RefreshAllTilesDelegate RefreshAllTilesDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Tilemap.SwapTileAssetDelegate SwapTileAssetDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Tilemap.ContainsTileAssetDelegate ContainsTileAssetDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Tilemap.GetUsedTilesCountDelegate GetUsedTilesCountDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Tilemap.GetUsedSpritesCountDelegate GetUsedSpritesCountDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Tilemap.Internal_GetUsedTilesNonAllocDelegate Internal_GetUsedTilesNonAllocDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Tilemap.Internal_GetUsedSpritesNonAllocDelegate Internal_GetUsedSpritesNonAllocDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Tilemap.ClearAllTilesDelegate ClearAllTilesDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly Tilemap.ResizeBoundsDelegate ResizeBoundsDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly Tilemap.CompressBoundsDelegate CompressBoundsDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly Tilemap.SendAndClearSyncTileBufferDelegate SendAndClearSyncTileBufferDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly Tilemap.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly Tilemap.get_localFrameBounds_InjectedDelegate get_localFrameBounds_InjectedDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly Tilemap.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly Tilemap.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly Tilemap.get_origin_InjectedDelegate get_origin_InjectedDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly Tilemap.set_origin_InjectedDelegate set_origin_InjectedDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly Tilemap.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly Tilemap.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly Tilemap.get_tileAnchor_InjectedDelegate get_tileAnchor_InjectedDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly Tilemap.set_tileAnchor_InjectedDelegate set_tileAnchor_InjectedDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly Tilemap.get_orientationMatrix_InjectedDelegate get_orientationMatrix_InjectedDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly Tilemap.set_orientationMatrix_InjectedDelegate set_orientationMatrix_InjectedDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly Tilemap.GetTileAsset_InjectedDelegate GetTileAsset_InjectedDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Tilemap.GetTileAssetsBlock_InjectedDelegate GetTileAssetsBlock_InjectedDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Tilemap.GetTileAssetsBlockNonAlloc_InjectedDelegate GetTileAssetsBlockNonAlloc_InjectedDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Tilemap.GetTilesRangeCount_InjectedDelegate GetTilesRangeCount_InjectedDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Tilemap.GetTileAssetsRangeNonAlloc_InjectedDelegate GetTileAssetsRangeNonAlloc_InjectedDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Tilemap.SetTileAsset_InjectedDelegate SetTileAsset_InjectedDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Tilemap.INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Tilemap.SetTile_InjectedDelegate SetTile_InjectedDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Tilemap.GetSprite_InjectedDelegate GetSprite_InjectedDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Tilemap.GetTransformMatrix_InjectedDelegate GetTransformMatrix_InjectedDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Tilemap.SetTransformMatrix_InjectedDelegate SetTransformMatrix_InjectedDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Tilemap.GetColor_InjectedDelegate GetColor_InjectedDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Tilemap.SetColor_InjectedDelegate SetColor_InjectedDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Tilemap.GetTileFlags_InjectedDelegate GetTileFlags_InjectedDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Tilemap.SetTileFlags_InjectedDelegate SetTileFlags_InjectedDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Tilemap.AddTileFlags_InjectedDelegate AddTileFlags_InjectedDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Tilemap.RemoveTileFlags_InjectedDelegate RemoveTileFlags_InjectedDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Tilemap.GetInstantiatedObject_InjectedDelegate GetInstantiatedObject_InjectedDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Tilemap.GetObjectToInstantiate_InjectedDelegate GetObjectToInstantiate_InjectedDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Tilemap.SetColliderType_InjectedDelegate SetColliderType_InjectedDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Tilemap.GetColliderType_InjectedDelegate GetColliderType_InjectedDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Tilemap.GetAnimationFrameCount_InjectedDelegate GetAnimationFrameCount_InjectedDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Tilemap.GetAnimationFrame_InjectedDelegate GetAnimationFrame_InjectedDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Tilemap.SetAnimationFrame_InjectedDelegate SetAnimationFrame_InjectedDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Tilemap.GetAnimationTime_InjectedDelegate GetAnimationTime_InjectedDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Tilemap.SetAnimationTime_InjectedDelegate SetAnimationTime_InjectedDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Tilemap.GetTileAnimationFlags_InjectedDelegate GetTileAnimationFlags_InjectedDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Tilemap.SetTileAnimationFlags_InjectedDelegate SetTileAnimationFlags_InjectedDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Tilemap.AddTileAnimationFlags_InjectedDelegate AddTileAnimationFlags_InjectedDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Tilemap.RemoveTileAnimationFlags_InjectedDelegate RemoveTileAnimationFlags_InjectedDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Tilemap.FloodFillTileAsset_InjectedDelegate FloodFillTileAsset_InjectedDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Tilemap.BoxFillTileAsset_InjectedDelegate BoxFillTileAsset_InjectedDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Tilemap.InsertCells_InjectedDelegate InsertCells_InjectedDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Tilemap.DeleteCells_InjectedDelegate DeleteCells_InjectedDelegateField;

		// Token: 0x02000011 RID: 17
		public sealed class SyncTile : ValueType
		{
			// Token: 0x0600015E RID: 350 RVA: 0x000056CC File Offset: 0x000038CC
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTile()
			{
				Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "SyncTile");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr);
				Tilemap.SyncTile.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr, "m_Position");
				Tilemap.SyncTile.NativeFieldInfoPtr_m_Tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr, "m_Tile");
				Tilemap.SyncTile.NativeFieldInfoPtr_m_TileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr, "m_TileData");
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00002D17 File Offset: 0x00000F17
			public SyncTile(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00002D20 File Offset: 0x00000F20
			public SyncTile()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tilemap.SyncTile>.NativeClassPtr))
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000161 RID: 353 RVA: 0x00005734 File Offset: 0x00003934
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00002D32 File Offset: 0x00000F32
			public unsafe Vector3Int m_Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_Position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_Position)) = value;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000163 RID: 355 RVA: 0x0000575C File Offset: 0x0000395C
			// (set) Token: 0x06000164 RID: 356 RVA: 0x00002D4D File Offset: 0x00000F4D
			public unsafe TileBase m_Tile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_Tile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_Tile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000165 RID: 357 RVA: 0x0000578C File Offset: 0x0000398C
			// (set) Token: 0x06000166 RID: 358 RVA: 0x00002D6C File Offset: 0x00000F6C
			public unsafe TileData m_TileData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_TileData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tilemap.SyncTile.NativeFieldInfoPtr_m_TileData)) = value;
				}
			}

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeFieldInfoPtr_m_Position;

			// Token: 0x040000CC RID: 204
			private static readonly IntPtr NativeFieldInfoPtr_m_Tile;

			// Token: 0x040000CD RID: 205
			private static readonly IntPtr NativeFieldInfoPtr_m_TileData;
		}

		// Token: 0x02000012 RID: 18
		[StructLayout(2)]
		public struct SyncTileCallbackSettings
		{
			// Token: 0x06000167 RID: 359 RVA: 0x000057B4 File Offset: 0x000039B4
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTileCallbackSettings()
			{
				Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tilemap>.NativeClassPtr, "SyncTileCallbackSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr);
				Tilemap.SyncTileCallbackSettings.NativeFieldInfoPtr_hasSyncTileCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr, "hasSyncTileCallback");
				Tilemap.SyncTileCallbackSettings.NativeFieldInfoPtr_hasPositionsChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr, "hasPositionsChangedCallback");
				Tilemap.SyncTileCallbackSettings.NativeFieldInfoPtr_isBufferSyncTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr, "isBufferSyncTile");
			}

			// Token: 0x06000168 RID: 360 RVA: 0x00002D87 File Offset: 0x00000F87
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tilemap.SyncTileCallbackSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x040000CE RID: 206
			private static readonly IntPtr NativeFieldInfoPtr_hasSyncTileCallback;

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeFieldInfoPtr_hasPositionsChangedCallback;

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeFieldInfoPtr_isBufferSyncTile;

			// Token: 0x040000D1 RID: 209
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool hasSyncTileCallback;

			// Token: 0x040000D2 RID: 210
			[FieldOffset(1)]
			[MarshalAs(4)]
			public bool hasPositionsChangedCallback;

			// Token: 0x040000D3 RID: 211
			[FieldOffset(2)]
			[MarshalAs(4)]
			public bool isBufferSyncTile;
		}

		// Token: 0x02000013 RID: 19
		public enum Orientation
		{
			// Token: 0x040000D5 RID: 213
			XY,
			// Token: 0x040000D6 RID: 214
			XZ,
			// Token: 0x040000D7 RID: 215
			YX,
			// Token: 0x040000D8 RID: 216
			YZ,
			// Token: 0x040000D9 RID: 217
			ZX,
			// Token: 0x040000DA RID: 218
			ZY,
			// Token: 0x040000DB RID: 219
			Custom
		}

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate IntPtr get_layoutGridDelegate(IntPtr @this);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate float get_animationFrameRateDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate void set_animationFrameRateDelegate(IntPtr @this, float value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate Tilemap.Orientation get_orientationDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate void set_orientationDelegate(IntPtr @this, Tilemap.Orientation value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void SetTileAssetsDelegate(IntPtr @this, IntPtr positionArray, IntPtr tileArray);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate void SetTilesDelegate(IntPtr @this, IntPtr tileChangeDataArray, bool ignoreLockFlags);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void RefreshAllTilesDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate void SwapTileAssetDelegate(IntPtr @this, IntPtr changeTile, IntPtr newTile);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate bool ContainsTileAssetDelegate(IntPtr @this, IntPtr tileAsset);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate int GetUsedTilesCountDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate int GetUsedSpritesCountDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate int Internal_GetUsedTilesNonAllocDelegate(IntPtr @this, IntPtr usedTiles);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate int Internal_GetUsedSpritesNonAllocDelegate(IntPtr @this, IntPtr usedSprites);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate void ClearAllTilesDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void ResizeBoundsDelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate void CompressBoundsDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate void SendAndClearSyncTileBufferDelegate(IntPtr @this);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate void get_localFrameBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate void get_origin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate void set_origin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate void get_tileAnchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate void set_tileAnchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate void get_orientationMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate void set_orientationMatrix_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate IntPtr GetTileAsset_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate IntPtr GetTileAssetsBlock_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr blockDimensions);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate int GetTileAssetsBlockNonAlloc_InjectedDelegate(IntPtr @this, IntPtr startPosition, IntPtr endPosition, IntPtr tiles);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate int GetTilesRangeCount_InjectedDelegate(IntPtr @this, IntPtr startPosition, IntPtr endPosition);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate int GetTileAssetsRangeNonAlloc_InjectedDelegate(IntPtr @this, IntPtr startPosition, IntPtr endPosition, IntPtr positions, IntPtr tiles);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate void SetTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate void INTERNAL_CALL_SetTileAssetsBlock_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr blockDimensions, IntPtr tileArray);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate void SetTile_InjectedDelegate(IntPtr @this, IntPtr tileChangeData, bool ignoreLockFlags);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate IntPtr GetSprite_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate void GetTransformMatrix_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate void SetTransformMatrix_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr transform);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate void GetColor_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate void SetColor_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr color);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate TileFlags GetTileFlags_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate void SetTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate void AddTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void RemoveTileFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileFlags flags);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate IntPtr GetInstantiatedObject_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate IntPtr GetObjectToInstantiate_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate void SetColliderType_InjectedDelegate(IntPtr @this, IntPtr position, Tile.ColliderType colliderType);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate Tile.ColliderType GetColliderType_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate int GetAnimationFrameCount_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate int GetAnimationFrame_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate void SetAnimationFrame_InjectedDelegate(IntPtr @this, IntPtr position, int frame);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate float GetAnimationTime_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void SetAnimationTime_InjectedDelegate(IntPtr @this, IntPtr position, float time);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate TileAnimationFlags GetTileAnimationFlags_InjectedDelegate(IntPtr @this, IntPtr position);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate void SetTileAnimationFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileAnimationFlags flags);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate void AddTileAnimationFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileAnimationFlags flags);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate void RemoveTileAnimationFlags_InjectedDelegate(IntPtr @this, IntPtr position, TileAnimationFlags flags);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate void FloodFillTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void BoxFillTileAsset_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr tile, int startX, int startY, int endX, int endY);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate void InsertCells_InjectedDelegate(IntPtr @this, IntPtr position, int numColumns, int numRows, int numLayers);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate void DeleteCells_InjectedDelegate(IntPtr @this, IntPtr position, int numColumns, int numRows, int numLayers);
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000004 RID: 4
	public class TileBase : ScriptableObject
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003900 File Offset: 0x00001B00
		// Note: this type is marked as 'beforefieldinit'.
		static TileBase()
		{
			Il2CppClassPointerStore<TileBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBase>.NativeClassPtr);
			TileBase.NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663316);
			TileBase.NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663317);
			TileBase.NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663318);
			TileBase.NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663319);
			TileBase.NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663320);
			TileBase.NativeMethodInfoPtr_GetTileAnimationDataRef_Private_Void_Vector3Int_ITilemap_byref_TileAnimationData_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663321);
			TileBase.NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663322);
			TileBase.NativeMethodInfoPtr_StartUpRef_Private_Void_Vector3Int_ITilemap_GameObject_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663323);
			TileBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663324);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000039E4 File Offset: 0x00001BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268909, XrefRangeEnd = 1268915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A40 File Offset: 0x00001C40
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tileData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003AAC File Offset: 0x00001CAC
		[CallerCount(0)]
		public unsafe TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003B08 File Offset: 0x00001D08
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(tileAnimationData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003B84 File Offset: 0x00001D84
		[CallerCount(0)]
		public unsafe TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TileAnimationData(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003BDC File Offset: 0x00001DDC
		[CallerCount(0)]
		public unsafe void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(tileAnimationData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasAnimation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_GetTileAnimationDataRef_Private_Void_Vector3Int_ITilemap_byref_TileAnimationData_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003C50 File Offset: 0x00001E50
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003CC8 File Offset: 0x00001EC8
		[CallerCount(0)]
		public unsafe void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startUpInvokedByUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_StartUpRef_Private_Void_Vector3Int_ITilemap_GameObject_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D3C File Offset: 0x00001F3C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021AB File Offset: 0x000003AB
		public TileBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_GetTileAnimationDataRef_Private_Void_Vector3Int_ITilemap_byref_TileAnimationData_byref_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_StartUpRef_Private_Void_Vector3Int_ITilemap_GameObject_byref_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000021 RID: 33
	public class AssetTable : DetailedLocalizationTable<AssetTableEntry>
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		// Note: this type is marked as 'beforefieldinit'.
		static AssetTable()
		{
			Il2CppClassPointerStore<AssetTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "AssetTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetTable>.NativeClassPtr);
			AssetTable.NativeFieldInfoPtr_m_PreloadOperationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, "m_PreloadOperationHandle");
			AssetTable.NativeMethodInfoPtr_get_ResourceManager_Private_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663610);
			AssetTable.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663611);
			AssetTable.NativeMethodInfoPtr_PreloadAssets_Private_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663612);
			AssetTable.NativeMethodInfoPtr_GetAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663613);
			AssetTable.NativeMethodInfoPtr_GetAssetAsync_Internal_AsyncOperationHandle_1_TObject_AssetTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663614);
			AssetTable.NativeMethodInfoPtr_ReleaseAssets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663615);
			AssetTable.NativeMethodInfoPtr_ReleaseAsset_Public_Void_AssetTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663616);
			AssetTable.NativeMethodInfoPtr_ReleaseAsset_Public_Void_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663617);
			AssetTable.NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_AssetTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663618);
			AssetTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTable>.NativeClassPtr, 100663619);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public unsafe ResourceManager ResourceManager
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1064903, RefRangeEnd = 1064925, XrefRangeStart = 1064903, XrefRangeEnd = 1064925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr_get_ResourceManager_Private_get_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000F92C File Offset: 0x0000DB2C
		public unsafe virtual AsyncOperationHandle PreloadOperation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066731, XrefRangeEnd = 1066734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetTable.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_New_get_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F970 File Offset: 0x0000DB70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066798, RefRangeEnd = 1066799, XrefRangeStart = 1066734, XrefRangeEnd = 1066798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle PreloadAssets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr_PreloadAssets_Private_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066799, XrefRangeEnd = 1066813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> GetAssetAsync<TObject>(TableEntryReference entryReference) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.MethodInfoStoreGeneric_GetAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066837, RefRangeEnd = 1066839, XrefRangeStart = 1066813, XrefRangeEnd = 1066837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> GetAssetAsync<TObject>(AssetTableEntry entry) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.MethodInfoStoreGeneric_GetAssetAsync_Internal_AsyncOperationHandle_1_TObject_AssetTableEntry_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000FA40 File Offset: 0x0000DC40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066862, RefRangeEnd = 1066863, XrefRangeStart = 1066839, XrefRangeEnd = 1066862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAssets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr_ReleaseAssets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000FA74 File Offset: 0x0000DC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066874, RefRangeEnd = 1066876, XrefRangeStart = 1066863, XrefRangeEnd = 1066874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAsset(AssetTableEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr_ReleaseAsset_Public_Void_AssetTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066876, XrefRangeEnd = 1066880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAsset(TableEntryReference entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr_ReleaseAsset_Public_Void_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000FB00 File Offset: 0x0000DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066880, XrefRangeEnd = 1066895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AssetTableEntry CreateTableEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetTable.NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_AssetTableEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetTableEntry>(intPtr3) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066895, XrefRangeEnd = 1066898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002B46 File Offset: 0x00000D46
		public AssetTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002B4F File Offset: 0x00000D4F
		public AsyncOperationHandle m_PreloadOperationHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTable.NativeFieldInfoPtr_m_PreloadOperationHandle);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTable.NativeFieldInfoPtr_m_PreloadOperationHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadOperationHandle;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Private_get_ResourceManager_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_New_get_AsyncOperationHandle_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_PreloadAssets_Private_AsyncOperationHandle_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetAsync_Internal_AsyncOperationHandle_1_TObject_AssetTableEntry_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAssets_Public_Void_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAsset_Public_Void_AssetTableEntry_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAsset_Public_Void_TableEntryReference_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_AssetTableEntry_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200011C RID: 284
		private sealed class MethodInfoStoreGeneric_GetAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_0<TObject>
		{
			// Token: 0x04000911 RID: 2321
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetTable.NativeMethodInfoPtr_GetAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_0, Il2CppClassPointerStore<AssetTable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200011D RID: 285
		private sealed class MethodInfoStoreGeneric_GetAssetAsync_Internal_AsyncOperationHandle_1_TObject_AssetTableEntry_0<TObject>
		{
			// Token: 0x04000912 RID: 2322
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetTable.NativeMethodInfoPtr_GetAssetAsync_Internal_AsyncOperationHandle_1_TObject_AssetTableEntry_0, Il2CppClassPointerStore<AssetTable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}

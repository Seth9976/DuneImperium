using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.Localization
{
	// Token: 0x02000003 RID: 3
	public class AddressablesInterface : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00008E90 File Offset: 0x00007090
		// Note: this type is marked as 'beforefieldinit'.
		static AddressablesInterface()
		{
			Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "AddressablesInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr);
			AddressablesInterface.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, "s_Instance");
			AddressablesInterface.NativeMethodInfoPtr_get_Instance_Public_Static_get_AddressablesInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663299);
			AddressablesInterface.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_AddressablesInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663300);
			AddressablesInterface.NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663301);
			AddressablesInterface.NativeMethodInfoPtr_Acquire_Public_Static_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663302);
			AddressablesInterface.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663303);
			AddressablesInterface.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663304);
			AddressablesInterface.NativeMethodInfoPtr_ReleaseAndReset_Public_Static_Void_byref_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663305);
			AddressablesInterface.NativeMethodInfoPtr_CreateGroupOperation_Public_Static_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663306);
			AddressablesInterface.NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663307);
			AddressablesInterface.NativeMethodInfoPtr_LoadTableLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663308);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetsFromLocations_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663309);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromGUID_Public_Static_AsyncOperationHandle_1_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663310);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromName_Public_Static_AsyncOperationHandle_1_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663311);
			AddressablesInterface.NativeMethodInfoPtr_LoadTableFromLocation_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663312);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetsWithLabel_Public_Static_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663313);
			AddressablesInterface.NativeMethodInfoPtr_AcquireInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663314);
			AddressablesInterface.NativeMethodInfoPtr_ReleaseInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663315);
			AddressablesInterface.NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663316);
			AddressablesInterface.NativeMethodInfoPtr_LoadTableLocationsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663317);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetsFromLocationsInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663318);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromGUIDInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663319);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromNameInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663320);
			AddressablesInterface.NativeMethodInfoPtr_LoadTableFromLocationInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663321);
			AddressablesInterface.NativeMethodInfoPtr_LoadAssetsWithLabelInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663322);
			AddressablesInterface.NativeMethodInfoPtr_InitializeAddressablesAsync_Internal_Virtual_New_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663323);
			AddressablesInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr, 100663324);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000090DC File Offset: 0x000072DC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00009110 File Offset: 0x00007310
		public unsafe static AddressablesInterface Instance
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1064875, RefRangeEnd = 1064895, XrefRangeStart = 1064867, XrefRangeEnd = 1064875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_get_Instance_Public_Static_get_AddressablesInterface_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddressablesInterface>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1064895, XrefRangeEnd = 1064899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_AddressablesInterface_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00009148 File Offset: 0x00007348
		public unsafe static ResourceManager ResourceManager
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1064903, RefRangeEnd = 1064925, XrefRangeStart = 1064899, XrefRangeEnd = 1064903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000917C File Offset: 0x0000737C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1064926, RefRangeEnd = 1064937, XrefRangeStart = 1064925, XrefRangeEnd = 1064926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Acquire(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_Acquire_Public_Static_Void_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000091B8 File Offset: 0x000073B8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1064938, RefRangeEnd = 1064961, XrefRangeStart = 1064937, XrefRangeEnd = 1064938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000091F4 File Offset: 0x000073F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1064963, RefRangeEnd = 1064976, XrefRangeStart = 1064961, XrefRangeEnd = 1064963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SafeRelease(AsyncOperationHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_SafeRelease_Public_Static_Void_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00009230 File Offset: 0x00007430
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1064980, RefRangeEnd = 1064991, XrefRangeStart = 1064976, XrefRangeEnd = 1064980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseAndReset<TObject>(ref AsyncOperationHandle<TObject> handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_ReleaseAndReset_Public_Static_Void_byref_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00009268 File Offset: 0x00007468
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1065021, RefRangeEnd = 1065028, XrefRangeStart = 1064991, XrefRangeEnd = 1065021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation(List<AsyncOperationHandle> asyncOperations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOperations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_CreateGroupOperation_Public_Static_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000092A4 File Offset: 0x000074A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065029, RefRangeEnd = 1065030, XrefRangeStart = 1065028, XrefRangeEnd = 1065029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsync(IEnumerable labels, Addressables.MergeMode mode, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(labels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00009300 File Offset: 0x00007500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065031, RefRangeEnd = 1065032, XrefRangeStart = 1065030, XrefRangeEnd = 1065031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsync(string tableName, LocaleIdentifier id, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr_LoadTableLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00009368 File Offset: 0x00007568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065035, RefRangeEnd = 1065036, XrefRangeStart = 1065032, XrefRangeEnd = 1065035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocations<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_LoadAssetsFromLocations_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000093B8 File Offset: 0x000075B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1065039, RefRangeEnd = 1065045, XrefRangeStart = 1065036, XrefRangeEnd = 1065039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAssetFromGUID<TObject>(string guid) where TObject : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_LoadAssetFromGUID_Public_Static_AsyncOperationHandle_1_TObject_String_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000093F4 File Offset: 0x000075F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1065039, RefRangeEnd = 1065045, XrefRangeStart = 1065039, XrefRangeEnd = 1065045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadAssetFromName<TObject>(string name) where TObject : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_LoadAssetFromName_Public_Static_AsyncOperationHandle_1_TObject_String_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00009430 File Offset: 0x00007630
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1065039, RefRangeEnd = 1065045, XrefRangeStart = 1065039, XrefRangeEnd = 1065045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<TObject> LoadTableFromLocation<TObject>(IResourceLocation location) where TObject : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_LoadTableFromLocation_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000946C File Offset: 0x0000766C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065035, RefRangeEnd = 1065036, XrefRangeStart = 1065035, XrefRangeEnd = 1065036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabel<TObject>(string label, Action<TObject> callback) where TObject : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.MethodInfoStoreGeneric_LoadAssetsWithLabel_Public_Static_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0<TObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000094BC File Offset: 0x000076BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065045, XrefRangeEnd = 1065050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcquireInternal(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.NativeMethodInfoPtr_AcquireInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00009510 File Offset: 0x00007710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065050, XrefRangeEnd = 1065054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseInternal(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.NativeMethodInfoPtr_ReleaseInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00009564 File Offset: 0x00007764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065054, XrefRangeEnd = 1065058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithLabelsAsyncInternal(IEnumerable labels, Addressables.MergeMode mode, Type type = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(labels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000095D8 File Offset: 0x000077D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065058, XrefRangeEnd = 1065068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IList<IResourceLocation>> LoadTableLocationsAsyncInternal(string tableName, LocaleIdentifier id, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(id));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.NativeMethodInfoPtr_LoadTableLocationsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<IResourceLocation>>(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00009654 File Offset: 0x00007854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065068, XrefRangeEnd = 1065072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IList<TObject>> LoadAssetsFromLocationsInternal<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.MethodInfoStoreGeneric_LoadAssetsFromLocationsInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000096BC File Offset: 0x000078BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065072, XrefRangeEnd = 1065077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadAssetFromGUIDInternal<TObject>(string guid) where TObject : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.MethodInfoStoreGeneric_LoadAssetFromGUIDInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00009710 File Offset: 0x00007910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadAssetFromNameInternal<TObject>(string name) where TObject : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.MethodInfoStoreGeneric_LoadAssetFromNameInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00009764 File Offset: 0x00007964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065077, XrefRangeEnd = 1065082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadTableFromLocationInternal<TObject>(IResourceLocation location) where TObject : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.MethodInfoStoreGeneric_LoadTableFromLocationInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000097B8 File Offset: 0x000079B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065082, XrefRangeEnd = 1065087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IList<TObject>> LoadAssetsWithLabelInternal<TObject>(string label, Action<TObject> callback) where TObject : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.MethodInfoStoreGeneric_LoadAssetsWithLabelInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IList<TObject>>(intPtr);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00009820 File Offset: 0x00007A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065087, XrefRangeEnd = 1065091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IResourceLocator> InitializeAddressablesAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddressablesInterface.NativeMethodInfoPtr_InitializeAddressablesAsync_Internal_Virtual_New_AsyncOperationHandle_1_IResourceLocator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00009864 File Offset: 0x00007A64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressablesInterface()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002059 File Offset: 0x00000259
		public AddressablesInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000098A0 File Offset: 0x00007AA0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe static AddressablesInterface s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesInterface.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesInterface>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesInterface.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AddressablesInterface_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Public_Static_set_Void_AddressablesInterface_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Public_Static_get_ResourceManager_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_Void_AsyncOperationHandle_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_AsyncOperationHandle_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_SafeRelease_Public_Static_Void_AsyncOperationHandle_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAndReset_Public_Static_Void_byref_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupOperation_Public_Static_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_List_1_AsyncOperationHandle_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableLocationsAsync_Public_Static_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsFromLocations_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetFromGUID_Public_Static_AsyncOperationHandle_1_TObject_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetFromName_Public_Static_AsyncOperationHandle_1_TObject_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableFromLocation_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsWithLabel_Public_Static_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_AcquireInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInternal_Internal_Virtual_New_Void_AsyncOperationHandle_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourceLocationsWithLabelsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_IEnumerable_MergeMode_Type_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableLocationsAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_IResourceLocation_String_LocaleIdentifier_Type_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsFromLocationsInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetFromGUIDInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetFromNameInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableFromLocationInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_IResourceLocation_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsWithLabelInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAddressablesAsync_Internal_Virtual_New_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000103 RID: 259
		private sealed class MethodInfoStoreGeneric_ReleaseAndReset_Public_Static_Void_byref_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x040008B4 RID: 2228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_ReleaseAndReset_Public_Static_Void_byref_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000104 RID: 260
		private sealed class MethodInfoStoreGeneric_LoadAssetsFromLocations_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>
		{
			// Token: 0x040008B5 RID: 2229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetsFromLocations_Public_Static_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000105 RID: 261
		private sealed class MethodInfoStoreGeneric_LoadAssetFromGUID_Public_Static_AsyncOperationHandle_1_TObject_String_0<TObject>
		{
			// Token: 0x040008B6 RID: 2230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromGUID_Public_Static_AsyncOperationHandle_1_TObject_String_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000106 RID: 262
		private sealed class MethodInfoStoreGeneric_LoadAssetFromName_Public_Static_AsyncOperationHandle_1_TObject_String_0<TObject>
		{
			// Token: 0x040008B7 RID: 2231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromName_Public_Static_AsyncOperationHandle_1_TObject_String_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000107 RID: 263
		private sealed class MethodInfoStoreGeneric_LoadTableFromLocation_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x040008B8 RID: 2232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadTableFromLocation_Public_Static_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000108 RID: 264
		private sealed class MethodInfoStoreGeneric_LoadAssetsWithLabel_Public_Static_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0<TObject>
		{
			// Token: 0x040008B9 RID: 2233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetsWithLabel_Public_Static_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000109 RID: 265
		private sealed class MethodInfoStoreGeneric_LoadAssetsFromLocationsInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0<TObject>
		{
			// Token: 0x040008BA RID: 2234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetsFromLocationsInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_IList_1_IResourceLocation_Action_1_TObject_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200010A RID: 266
		private sealed class MethodInfoStoreGeneric_LoadAssetFromGUIDInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0<TObject>
		{
			// Token: 0x040008BB RID: 2235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromGUIDInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200010B RID: 267
		private sealed class MethodInfoStoreGeneric_LoadAssetFromNameInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0<TObject>
		{
			// Token: 0x040008BC RID: 2236
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetFromNameInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_String_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200010C RID: 268
		private sealed class MethodInfoStoreGeneric_LoadTableFromLocationInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_IResourceLocation_0<TObject>
		{
			// Token: 0x040008BD RID: 2237
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadTableFromLocationInternal_Internal_Virtual_New_AsyncOperationHandle_1_TObject_IResourceLocation_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200010D RID: 269
		private sealed class MethodInfoStoreGeneric_LoadAssetsWithLabelInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0<TObject>
		{
			// Token: 0x040008BE RID: 2238
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AddressablesInterface.NativeMethodInfoPtr_LoadAssetsWithLabelInternal_Internal_Virtual_New_AsyncOperationHandle_1_IList_1_TObject_String_Action_1_TObject_0, Il2CppClassPointerStore<AddressablesInterface>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}

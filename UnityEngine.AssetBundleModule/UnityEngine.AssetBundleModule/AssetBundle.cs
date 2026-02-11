using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class AssetBundle : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002180 File Offset: 0x00000380
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundle()
		{
			Il2CppClassPointerStore<AssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr);
			AssetBundle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663297);
			AssetBundle.NativeMethodInfoPtr_GetAllLoadedAssetBundles_Native_Internal_Static_Il2CppReferenceArray_1_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663298);
			AssetBundle.NativeMethodInfoPtr_GetAllLoadedAssetBundles_Public_Static_IEnumerable_1_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663299);
			AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663300);
			AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663301);
			AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663302);
			AssetBundle.NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663303);
			AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663304);
			AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663305);
			AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663306);
			AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663307);
			AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663308);
			AssetBundle.NativeMethodInfoPtr_LoadAsset_Internal_Private_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663309);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663310);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663311);
			AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssets_Public_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663312);
			AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Public_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663313);
			AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663314);
			AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663315);
			AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663316);
			AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663317);
			AssetBundle.NativeMethodInfoPtr_Unload_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663318);
			AssetBundle.NativeMethodInfoPtr_UnloadAsync_Public_AssetBundleUnloadOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663319);
			AssetBundle.NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663320);
			AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663321);
			AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr, 100663322);
			AssetBundle.returnMainAssetDelegateField = IL2CPP.ResolveICall<AssetBundle.returnMainAssetDelegate>("UnityEngine.AssetBundle::returnMainAsset");
			AssetBundle.UnloadAllAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundle.UnloadAllAssetBundlesDelegate>("UnityEngine.AssetBundle::UnloadAllAssetBundles");
			AssetBundle.LoadFromMemoryAsync_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemoryAsync_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemoryAsync_Internal");
			AssetBundle.LoadFromMemory_InternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromMemory_InternalDelegate>("UnityEngine.AssetBundle::LoadFromMemory_Internal");
			AssetBundle.LoadFromStreamAsyncInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamAsyncInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamAsyncInternal");
			AssetBundle.LoadFromStreamInternalDelegateField = IL2CPP.ResolveICall<AssetBundle.LoadFromStreamInternalDelegate>("UnityEngine.AssetBundle::LoadFromStreamInternal");
			AssetBundle.get_isStreamedSceneAssetBundleDelegateField = IL2CPP.ResolveICall<AssetBundle.get_isStreamedSceneAssetBundleDelegate>("UnityEngine.AssetBundle::get_isStreamedSceneAssetBundle");
			AssetBundle.ContainsDelegateField = IL2CPP.ResolveICall<AssetBundle.ContainsDelegate>("UnityEngine.AssetBundle::Contains");
			AssetBundle.GetAllScenePathsDelegateField = IL2CPP.ResolveICall<AssetBundle.GetAllScenePathsDelegate>("UnityEngine.AssetBundle::GetAllScenePaths");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002440 File Offset: 0x00000640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269854, XrefRangeEnd = 1269858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000247C File Offset: 0x0000067C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269860, RefRangeEnd = 1269861, XrefRangeStart = 1269858, XrefRangeEnd = 1269860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<AssetBundle> GetAllLoadedAssetBundles_Native()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_GetAllLoadedAssetBundles_Native_Internal_Static_Il2CppReferenceArray_1_AssetBundle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundle>>(intPtr3) : null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000024B0 File Offset: 0x000006B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269860, RefRangeEnd = 1269861, XrefRangeStart = 1269860, XrefRangeEnd = 1269861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssetBundle> GetAllLoadedAssetBundles()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_GetAllLoadedAssetBundles_Public_Static_IEnumerable_1_AssetBundle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssetBundle>>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000024E4 File Offset: 0x000006E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269861, XrefRangeEnd = 1269863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr3) : null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002544 File Offset: 0x00000744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269865, RefRangeEnd = 1269866, XrefRangeStart = 1269863, XrefRangeEnd = 1269865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundleCreateRequest LoadFromFileAsync(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002588 File Offset: 0x00000788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269868, RefRangeEnd = 1269869, XrefRangeStart = 1269866, XrefRangeEnd = 1269868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025DC File Offset: 0x000007DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269869, XrefRangeEnd = 1269871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000263C File Offset: 0x0000083C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1269873, RefRangeEnd = 1269875, XrefRangeStart = 1269871, XrefRangeEnd = 1269873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadFromFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002680 File Offset: 0x00000880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269875, XrefRangeEnd = 1269877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadFromFile(string path, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026D4 File Offset: 0x000008D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269877, XrefRangeEnd = 1269907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadAsset(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002724 File Offset: 0x00000924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269914, RefRangeEnd = 1269915, XrefRangeStart = 1269907, XrefRangeEnd = 1269914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadAsset<T>(string name) where T : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.MethodInfoStoreGeneric_LoadAsset_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002770 File Offset: 0x00000970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1269939, RefRangeEnd = 1269941, XrefRangeStart = 1269915, XrefRangeEnd = 1269939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadAsset(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027D4 File Offset: 0x000009D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269941, XrefRangeEnd = 1269943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadAsset_Internal(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAsset_Internal_Private_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002838 File Offset: 0x00000A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269943, XrefRangeEnd = 1269973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002888 File Offset: 0x00000A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269997, RefRangeEnd = 1269998, XrefRangeStart = 1269973, XrefRangeEnd = 1269997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000028EC File Offset: 0x00000AEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270022, RefRangeEnd = 1270024, XrefRangeStart = 1269998, XrefRangeEnd = 1270022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssets_Public_Il2CppReferenceArray_1_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002950 File Offset: 0x00000B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270047, RefRangeEnd = 1270048, XrefRangeStart = 1270024, XrefRangeEnd = 1270047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Public_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000029B4 File Offset: 0x00000BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270068, RefRangeEnd = 1270069, XrefRangeStart = 1270048, XrefRangeEnd = 1270068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAllAssetsAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000029F4 File Offset: 0x00000BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270075, RefRangeEnd = 1270077, XrefRangeStart = 1270069, XrefRangeEnd = 1270075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAllAssetsAsync<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.MethodInfoStoreGeneric_LoadAllAssetsAsync_Public_AssetBundleRequest_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A34 File Offset: 0x00000C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270091, RefRangeEnd = 1270092, XrefRangeStart = 1270077, XrefRangeEnd = 1270091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAllAssetsAsync(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002A84 File Offset: 0x00000C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270092, XrefRangeEnd = 1270094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetAsync_Internal(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002AE8 File Offset: 0x00000CE8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1270096, RefRangeEnd = 1270106, XrefRangeStart = 1270094, XrefRangeEnd = 1270096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unload(bool unloadAllLoadedObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unloadAllLoadedObjects;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_Unload_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B28 File Offset: 0x00000D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270108, RefRangeEnd = 1270110, XrefRangeStart = 1270106, XrefRangeEnd = 1270108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unloadAllLoadedObjects;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_UnloadAsync_Public_AssetBundleUnloadOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleUnloadOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B74 File Offset: 0x00000D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270112, RefRangeEnd = 1270113, XrefRangeStart = 1270110, XrefRangeEnd = 1270112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAllAssetNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002BB4 File Offset: 0x00000DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270113, XrefRangeEnd = 1270115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> LoadAssetWithSubAssets_Internal(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002C18 File Offset: 0x00000E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270117, RefRangeEnd = 1270118, XrefRangeStart = 1270115, XrefRangeEnd = 1270117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundle.NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		public AssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C7C File Offset: 0x00000E7C
		public Object mainAsset
		{
			get
			{
				return AssetBundle.returnMainAsset(this);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C94 File Offset: 0x00000E94
		public static Object returnMainAsset(AssetBundle bundle)
		{
			IntPtr intPtr = AssetBundle.returnMainAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundle));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002059 File Offset: 0x00000259
		public static void UnloadAllAssetBundles(bool unloadAllObjects)
		{
			AssetBundle.UnloadAllAssetBundlesDelegateField(unloadAllObjects);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFileAsync_Internal(path, crc, offset);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002CDC File Offset: 0x00000EDC
		public static AssetBundle LoadFromFile(string path, uint crc, ulong offset)
		{
			return AssetBundle.LoadFromFile_Internal(path, crc, offset);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemoryAsync_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D28 File Offset: 0x00000F28
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, 0U);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D44 File Offset: 0x00000F44
		public static AssetBundleCreateRequest LoadFromMemoryAsync(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemoryAsync_Internal(binary, crc);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D60 File Offset: 0x00000F60
		public static AssetBundle LoadFromMemory_Internal(Il2CppStructArray<byte> binary, uint crc)
		{
			IntPtr intPtr = AssetBundle.LoadFromMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(binary), crc);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D90 File Offset: 0x00000F90
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, 0U);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DAC File Offset: 0x00000FAC
		public static AssetBundle LoadFromMemory(Il2CppStructArray<byte> binary, uint crc)
		{
			return AssetBundle.LoadFromMemory_Internal(binary, crc);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public static void ValidateLoadFromStream(Stream stream)
		{
			bool flag = stream == null;
			if (flag)
			{
				throw new ArgumentNullException("ManagedStream object must be non-null", "stream");
			}
			bool flag2 = !stream.CanRead;
			if (flag2)
			{
				throw new ArgumentException("ManagedStream object must be readable (stream.CanRead must return true)", "stream");
			}
			bool flag3 = !stream.CanSeek;
			if (flag3)
			{
				throw new ArgumentException("ManagedStream object must be seekable (stream.CanSeek must return true)", "stream");
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002E28 File Offset: 0x00001028
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E4C File Offset: 0x0000104C
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, crc, 0U);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E70 File Offset: 0x00001070
		public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamAsyncInternal(stream, 0U, 0U);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E94 File Offset: 0x00001094
		public static AssetBundle LoadFromStream(Stream stream, uint crc, uint managedReadBufferSize)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, managedReadBufferSize);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002EB8 File Offset: 0x000010B8
		public static AssetBundle LoadFromStream(Stream stream, uint crc)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, crc, 0U);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002EDC File Offset: 0x000010DC
		public static AssetBundle LoadFromStream(Stream stream)
		{
			AssetBundle.ValidateLoadFromStream(stream);
			return AssetBundle.LoadFromStreamInternal(stream, 0U, 0U);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F00 File Offset: 0x00001100
		public static AssetBundleCreateRequest LoadFromStreamAsyncInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamAsyncInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002F30 File Offset: 0x00001130
		public static AssetBundle LoadFromStreamInternal(Stream stream, uint crc, uint managedReadBufferSize)
		{
			IntPtr intPtr = AssetBundle.LoadFromStreamInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(stream), crc, managedReadBufferSize);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		public bool isStreamedSceneAssetBundle
		{
			get
			{
				return AssetBundle.get_isStreamedSceneAssetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002078 File Offset: 0x00000278
		public bool Contains(string name)
		{
			return AssetBundle.ContainsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002F60 File Offset: 0x00001160
		public Object Load(string name)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002F74 File Offset: 0x00001174
		public Object Load<T>(string name)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002F88 File Offset: 0x00001188
		public Object Load(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002F9C File Offset: 0x0000119C
		public AssetBundleRequest LoadAsync(string name, Type type)
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002FB0 File Offset: 0x000011B0
		public Il2CppReferenceArray<Object> LoadAll(Type type)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002FC4 File Offset: 0x000011C4
		public Il2CppReferenceArray<Object> LoadAll()
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002FD8 File Offset: 0x000011D8
		public Il2CppArrayBase<T> LoadAll<T>() where T : Object
		{
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002FEC File Offset: 0x000011EC
		public Il2CppReferenceArray<Object> LoadAssetWithSubAssets(string name)
		{
			return this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002090 File Offset: 0x00000290
		public static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003010 File Offset: 0x00001210
		public Il2CppArrayBase<T> LoadAssetWithSubAssets<T>(string name) where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003038 File Offset: 0x00001238
		public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000305C File Offset: 0x0000125C
		public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
		{
			return this.LoadAssetWithSubAssetsAsync(name, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003080 File Offset: 0x00001280
		public Il2CppReferenceArray<Object> LoadAllAssets()
		{
			return this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000030A4 File Offset: 0x000012A4
		public Il2CppArrayBase<T> LoadAllAssets<T>() where T : Object
		{
			return AssetBundle.ConvertObjects<T>(this.LoadAllAssets(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000030CC File Offset: 0x000012CC
		public Il2CppReferenceArray<Object> LoadAllAssets(Type type)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new NullReferenceException("The input type cannot be null.");
			}
			return this.LoadAssetWithSubAssets_Internal("", type);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003104 File Offset: 0x00001304
		public Il2CppStringArray AllAssetNames()
		{
			return this.GetAllAssetNames();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000311C File Offset: 0x0000131C
		public Il2CppStringArray GetAllScenePaths()
		{
			IntPtr intPtr = AssetBundle.GetAllScenePathsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003148 File Offset: 0x00001348
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000209D File Offset: 0x0000029D
		public static uint memoryBudgetKB
		{
			get
			{
				return AssetBundleLoadingCache.memoryBudgetKB;
			}
			set
			{
				AssetBundleLoadingCache.memoryBudgetKB = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLoadedAssetBundles_Native_Internal_Static_Il2CppReferenceArray_1_AssetBundle_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLoadedAssetBundles_Public_Static_IEnumerable_1_AssetBundle_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Internal_Internal_Static_AssetBundleCreateRequest_String_UInt32_UInt64_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFileAsync_Public_Static_AssetBundleCreateRequest_String_UInt32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Internal_Internal_Static_AssetBundle_String_UInt32_UInt64_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Static_AssetBundle_String_UInt32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Object_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_T_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Object_String_Type_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Internal_Private_Object_String_Type_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AssetBundleRequest_String_Type_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssets_Public_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Public_AssetBundleRequest_String_Type_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_Type_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Internal_Private_AssetBundleRequest_String_Type_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Void_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsync_Public_AssetBundleUnloadOperation_Boolean_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAssetNames_Public_Il2CppStringArray_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssets_Internal_Internal_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetWithSubAssetsAsync_Internal_Private_AssetBundleRequest_String_Type_0;

		// Token: 0x0400001B RID: 27
		private static readonly AssetBundle.returnMainAssetDelegate returnMainAssetDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly AssetBundle.UnloadAllAssetBundlesDelegate UnloadAllAssetBundlesDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly AssetBundle.LoadFromMemoryAsync_InternalDelegate LoadFromMemoryAsync_InternalDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly AssetBundle.LoadFromMemory_InternalDelegate LoadFromMemory_InternalDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly AssetBundle.LoadFromStreamAsyncInternalDelegate LoadFromStreamAsyncInternalDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly AssetBundle.LoadFromStreamInternalDelegate LoadFromStreamInternalDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly AssetBundle.get_isStreamedSceneAssetBundleDelegate get_isStreamedSceneAssetBundleDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly AssetBundle.ContainsDelegate ContainsDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly AssetBundle.GetAllScenePathsDelegate GetAllScenePathsDelegateField;

		// Token: 0x0200000B RID: 11
		private sealed class MethodInfoStoreGeneric_LoadAsset_Public_T_String_0<T>
		{
			// Token: 0x0400004F RID: 79
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetBundle.NativeMethodInfoPtr_LoadAsset_Public_T_String_0, Il2CppClassPointerStore<AssetBundle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000C RID: 12
		private sealed class MethodInfoStoreGeneric_LoadAllAssetsAsync_Public_AssetBundleRequest_0<T>
		{
			// Token: 0x04000050 RID: 80
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetBundle.NativeMethodInfoPtr_LoadAllAssetsAsync_Public_AssetBundleRequest_0, Il2CppClassPointerStore<AssetBundle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000072 RID: 114
		private delegate IntPtr returnMainAssetDelegate(IntPtr bundle);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000074 RID: 116
		private delegate void UnloadAllAssetBundlesDelegate(bool unloadAllObjects);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000076 RID: 118
		private delegate IntPtr LoadFromMemoryAsync_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000078 RID: 120
		private delegate IntPtr LoadFromMemory_InternalDelegate(IntPtr binary, uint crc);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600007A RID: 122
		private delegate IntPtr LoadFromStreamAsyncInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600007C RID: 124
		private delegate IntPtr LoadFromStreamInternalDelegate(IntPtr stream, uint crc, uint managedReadBufferSize);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600007E RID: 126
		private delegate bool get_isStreamedSceneAssetBundleDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000080 RID: 128
		private delegate bool ContainsDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000082 RID: 130
		private delegate IntPtr GetAllScenePathsDelegate(IntPtr @this);
	}
}

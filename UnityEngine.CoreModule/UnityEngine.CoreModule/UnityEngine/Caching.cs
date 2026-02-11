using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000076 RID: 118
	public sealed class Caching : Object
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00022000 File Offset: 0x00020200
		// Note: this type is marked as 'beforefieldinit'.
		static Caching()
		{
			Il2CppClassPointerStore<Caching>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Caching");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Caching>.NativeClassPtr);
			Caching.NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663709);
			Caching.NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663710);
			Caching.NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663711);
			Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663712);
			Caching.NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663713);
			Caching.NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663714);
			Caching.NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663715);
			Caching.NativeMethodInfoPtr_GetCachedVersions_Internal_Static_Il2CppStructArray_1_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663716);
			Caching.NativeMethodInfoPtr_GetCachedVersions_Public_Static_Void_String_List_1_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663717);
			Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663718);
			Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663719);
			Caching.NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663720);
			Caching.NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663721);
			Caching.NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663722);
			Caching.NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663723);
			Caching.NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663724);
			Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663725);
			Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663726);
			Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663727);
			Caching.NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_String_byref_Hash128_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663728);
			Caching.NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_String_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663729);
			Caching.NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_String_Boolean_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663730);
			Caching.NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_String_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663731);
			Caching.NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663732);
			Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663733);
			Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663734);
			Caching.get_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");
			Caching.ClearCacheDelegateField = IL2CPP.ResolveICall<Caching.ClearCacheDelegate>("UnityEngine.Caching::ClearCache");
			Caching.ClearCache_IntDelegateField = IL2CPP.ResolveICall<Caching.ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");
			Caching.get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<Caching.get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");
			Caching.get_spaceFreeDelegateField = IL2CPP.ResolveICall<Caching.get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");
			Caching.get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");
			Caching.set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");
			Caching.get_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");
			Caching.set_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");
			Caching.get_cacheCountDelegateField = IL2CPP.ResolveICall<Caching.get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");
			Caching.MarkAsUsed_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MarkAsUsed_InjectedDelegate>("UnityEngine.Caching::MarkAsUsed_Injected");
			Caching.GetCacheAt_InjectedDelegateField = IL2CPP.ResolveICall<Caching.GetCacheAt_InjectedDelegate>("UnityEngine.Caching::GetCacheAt_Injected");
			Caching.RemoveCache_InjectedDelegateField = IL2CPP.ResolveICall<Caching.RemoveCache_InjectedDelegate>("UnityEngine.Caching::RemoveCache_Injected");
			Caching.MoveCacheBefore_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MoveCacheBefore_InjectedDelegate>("UnityEngine.Caching::MoveCacheBefore_Injected");
			Caching.MoveCacheAfter_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MoveCacheAfter_InjectedDelegate>("UnityEngine.Caching::MoveCacheAfter_Injected");
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00004077 File Offset: 0x00002277
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0002231C File Offset: 0x0002051C
		public unsafe static bool compressionEnabled
		{
			get
			{
				return Caching.get_compressionEnabledDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645198, RefRangeEnd = 645200, XrefRangeStart = 645196, XrefRangeEnd = 645198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00022350 File Offset: 0x00020550
		public unsafe static bool ready
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 645202, RefRangeEnd = 645205, XrefRangeStart = 645200, XrefRangeEnd = 645202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00022380 File Offset: 0x00020580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645208, RefRangeEnd = 645209, XrefRangeStart = 645205, XrefRangeEnd = 645208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearCachedVersion(string assetBundleName, Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000223D0 File Offset: 0x000205D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645209, XrefRangeEnd = 645211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00022420 File Offset: 0x00020620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 645214, RefRangeEnd = 645217, XrefRangeStart = 645211, XrefRangeEnd = 645214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00022470 File Offset: 0x00020670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 645220, RefRangeEnd = 645222, XrefRangeStart = 645217, XrefRangeEnd = 645220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearAllCachedVersions(string assetBundleName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000224B4 File Offset: 0x000206B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645222, XrefRangeEnd = 645224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepInputVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00022514 File Offset: 0x00020714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645224, XrefRangeEnd = 645226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Hash128> GetCachedVersions(string assetBundleName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCachedVersions_Internal_Static_Il2CppStructArray_1_Hash128_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Hash128>>(intPtr3) : null;
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00022558 File Offset: 0x00020758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645226, XrefRangeEnd = 645244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outCachedVersions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCachedVersions_Public_Static_Void_String_List_1_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000225A0 File Offset: 0x000207A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 645249, RefRangeEnd = 645251, XrefRangeStart = 645244, XrefRangeEnd = 645249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVersionCached(string url, Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000225F0 File Offset: 0x000207F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 645256, RefRangeEnd = 645258, XrefRangeStart = 645251, XrefRangeEnd = 645256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVersionCached(CachedAssetBundle cachedBundle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cachedBundle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00022638 File Offset: 0x00020838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645258, XrefRangeEnd = 645260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0002269C File Offset: 0x0002089C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 645277, RefRangeEnd = 645279, XrefRangeStart = 645260, XrefRangeEnd = 645277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Cache AddCache(string cachePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cachePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000226E0 File Offset: 0x000208E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645279, XrefRangeEnd = 645281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Cache AddCache(string cachePath, bool isReadonly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cachePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReadonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00022730 File Offset: 0x00020930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 645283, RefRangeEnd = 645285, XrefRangeStart = 645281, XrefRangeEnd = 645283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Cache GetCacheByPath(string cachePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cachePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00022774 File Offset: 0x00020974
		public unsafe static Cache defaultCache
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645287, RefRangeEnd = 645288, XrefRangeStart = 645285, XrefRangeEnd = 645287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000227A4 File Offset: 0x000209A4
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000227D4 File Offset: 0x000209D4
		public unsafe static Cache currentCacheForWriting
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 645290, RefRangeEnd = 645294, XrefRangeStart = 645288, XrefRangeEnd = 645290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645296, RefRangeEnd = 645298, XrefRangeStart = 645294, XrefRangeEnd = 645296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00022808 File Offset: 0x00020A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645298, XrefRangeEnd = 645300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearCachedVersionInternal_Injected(string assetBundleName, ref Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00022858 File Offset: 0x00020A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645300, XrefRangeEnd = 645302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepInputVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_String_byref_Hash128_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000228B8 File Offset: 0x00020AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645302, XrefRangeEnd = 645304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_String_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0002291C File Offset: 0x00020B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645304, XrefRangeEnd = 645306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCache_Injected(string cachePath, bool isReadonly, out Cache ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cachePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReadonly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_String_Boolean_byref_Cache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00022970 File Offset: 0x00020B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645306, XrefRangeEnd = 645308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCacheByPath_Injected(string cachePath, out Cache ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cachePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_String_byref_Cache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000229B4 File Offset: 0x00020BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645308, XrefRangeEnd = 645310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultCache_Injected(out Cache ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000229E8 File Offset: 0x00020BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645310, XrefRangeEnd = 645312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_currentCacheForWriting_Injected(out Cache ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00022A1C File Offset: 0x00020C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645312, XrefRangeEnd = 645314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_currentCacheForWriting_Injected(ref Cache value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000406E File Offset: 0x0000226E
		public Caching(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004083 File Offset: 0x00002283
		public static bool ClearCache()
		{
			return Caching.ClearCacheDelegateField();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00022A50 File Offset: 0x00020C50
		public static bool ClearCache(int expiration)
		{
			return Caching.ClearCache_Int(expiration);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000408F File Offset: 0x0000228F
		public static bool ClearCache_Int(int expiration)
		{
			return Caching.ClearCache_IntDelegateField(expiration);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00022A68 File Offset: 0x00020C68
		public static bool IsVersionCached(string url, int version)
		{
			return Caching.IsVersionCached(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00022A8C File Offset: 0x00020C8C
		public static bool MarkAsUsed(string url, int version)
		{
			return Caching.MarkAsUsed(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00022AB0 File Offset: 0x00020CB0
		public static bool MarkAsUsed(string url, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(url);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle url cannot be null or empty.");
			}
			return Caching.MarkAsUsed(url, "", hash);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00022AE4 File Offset: 0x00020CE4
		public static bool MarkAsUsed(CachedAssetBundle cachedBundle)
		{
			bool flag = String.IsNullOrEmpty(cachedBundle.name);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.MarkAsUsed("", cachedBundle.name, cachedBundle.hash);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000409C File Offset: 0x0000229C
		public static bool MarkAsUsed(string url, string assetBundleName, Hash128 hash)
		{
			return Caching.MarkAsUsed_Injected(url, assetBundleName, ref hash);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00022B2C File Offset: 0x00020D2C
		public static int GetVersionFromCache(string url)
		{
			return -1;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00022B40 File Offset: 0x00020D40
		public static int spaceUsed
		{
			get
			{
				return (int)Caching.spaceOccupied;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000040A7 File Offset: 0x000022A7
		public static long spaceOccupied
		{
			get
			{
				return Caching.get_spaceOccupiedDelegateField();
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00022B58 File Offset: 0x00020D58
		public static int spaceAvailable
		{
			get
			{
				return (int)Caching.spaceFree;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000040B3 File Offset: 0x000022B3
		public static long spaceFree
		{
			get
			{
				return Caching.get_spaceFreeDelegateField();
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000040BF File Offset: 0x000022BF
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x000040CB File Offset: 0x000022CB
		public static long maximumAvailableDiskSpace
		{
			get
			{
				return Caching.get_maximumAvailableDiskSpaceDelegateField();
			}
			set
			{
				Caching.set_maximumAvailableDiskSpaceDelegateField(value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000040D8 File Offset: 0x000022D8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000040E4 File Offset: 0x000022E4
		public static int expirationDelay
		{
			get
			{
				return Caching.get_expirationDelayDelegateField();
			}
			set
			{
				Caching.set_expirationDelayDelegateField(value);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00022B70 File Offset: 0x00020D70
		public static Cache GetCacheAt(int cacheIndex)
		{
			Cache cache;
			Caching.GetCacheAt_Injected(cacheIndex, out cache);
			return cache;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00022B88 File Offset: 0x00020D88
		public static void GetAllCachePaths(List<string> cachePaths)
		{
			cachePaths.Clear();
			for (int i = 0; i < Caching.cacheCount; i++)
			{
				cachePaths.Add(Caching.GetCacheAt(i).path);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000040F1 File Offset: 0x000022F1
		public static bool RemoveCache(Cache cache)
		{
			return Caching.RemoveCache_Injected(ref cache);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000040FA File Offset: 0x000022FA
		public static void MoveCacheBefore(Cache src, Cache dst)
		{
			Caching.MoveCacheBefore_Injected(ref src, ref dst);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00004105 File Offset: 0x00002305
		public static void MoveCacheAfter(Cache src, Cache dst)
		{
			Caching.MoveCacheAfter_Injected(ref src, ref dst);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00004110 File Offset: 0x00002310
		public static int cacheCount
		{
			get
			{
				return Caching.get_cacheCountDelegateField();
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00022BC8 File Offset: 0x00020DC8
		public static bool CleanCache()
		{
			return Caching.ClearCache();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000411C File Offset: 0x0000231C
		public static bool MarkAsUsed_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			return Caching.MarkAsUsed_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004135 File Offset: 0x00002335
		public static void GetCacheAt_Injected(int cacheIndex, out Cache ret)
		{
			Caching.GetCacheAt_InjectedDelegateField(cacheIndex, out ret);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00004143 File Offset: 0x00002343
		public static bool RemoveCache_Injected(ref Cache cache)
		{
			return Caching.RemoveCache_InjectedDelegateField(ref cache);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00004150 File Offset: 0x00002350
		public static void MoveCacheBefore_Injected(ref Cache src, ref Cache dst)
		{
			Caching.MoveCacheBefore_InjectedDelegateField(ref src, ref dst);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000415E File Offset: 0x0000235E
		public static void MoveCacheAfter_Injected(ref Cache src, ref Cache dst)
		{
			Caching.MoveCacheAfter_InjectedDelegateField(ref src, ref dst);
		}

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedVersions_Internal_Static_Il2CppStructArray_1_Hash128_String_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedVersions_Public_Static_Void_String_List_1_Hash128_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_String_Hash128_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_String_byref_Hash128_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_String_byref_Hash128_Boolean_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_String_String_byref_Hash128_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_String_Boolean_byref_Cache_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_String_byref_Cache_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0;

		// Token: 0x040003C3 RID: 963
		private static readonly Caching.get_compressionEnabledDelegate get_compressionEnabledDelegateField;

		// Token: 0x040003C4 RID: 964
		private static readonly Caching.ClearCacheDelegate ClearCacheDelegateField;

		// Token: 0x040003C5 RID: 965
		private static readonly Caching.ClearCache_IntDelegate ClearCache_IntDelegateField;

		// Token: 0x040003C6 RID: 966
		private static readonly Caching.get_spaceOccupiedDelegate get_spaceOccupiedDelegateField;

		// Token: 0x040003C7 RID: 967
		private static readonly Caching.get_spaceFreeDelegate get_spaceFreeDelegateField;

		// Token: 0x040003C8 RID: 968
		private static readonly Caching.get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField;

		// Token: 0x040003C9 RID: 969
		private static readonly Caching.set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField;

		// Token: 0x040003CA RID: 970
		private static readonly Caching.get_expirationDelayDelegate get_expirationDelayDelegateField;

		// Token: 0x040003CB RID: 971
		private static readonly Caching.set_expirationDelayDelegate set_expirationDelayDelegateField;

		// Token: 0x040003CC RID: 972
		private static readonly Caching.get_cacheCountDelegate get_cacheCountDelegateField;

		// Token: 0x040003CD RID: 973
		private static readonly Caching.MarkAsUsed_InjectedDelegate MarkAsUsed_InjectedDelegateField;

		// Token: 0x040003CE RID: 974
		private static readonly Caching.GetCacheAt_InjectedDelegate GetCacheAt_InjectedDelegateField;

		// Token: 0x040003CF RID: 975
		private static readonly Caching.RemoveCache_InjectedDelegate RemoveCache_InjectedDelegateField;

		// Token: 0x040003D0 RID: 976
		private static readonly Caching.MoveCacheBefore_InjectedDelegate MoveCacheBefore_InjectedDelegateField;

		// Token: 0x040003D1 RID: 977
		private static readonly Caching.MoveCacheAfter_InjectedDelegate MoveCacheAfter_InjectedDelegateField;

		// Token: 0x02000439 RID: 1081
		// (Invoke) Token: 0x0600316D RID: 12653
		private delegate bool get_compressionEnabledDelegate();

		// Token: 0x0200043A RID: 1082
		// (Invoke) Token: 0x0600316F RID: 12655
		private delegate bool ClearCacheDelegate();

		// Token: 0x0200043B RID: 1083
		// (Invoke) Token: 0x06003171 RID: 12657
		private delegate bool ClearCache_IntDelegate(int expiration);

		// Token: 0x0200043C RID: 1084
		// (Invoke) Token: 0x06003173 RID: 12659
		private delegate long get_spaceOccupiedDelegate();

		// Token: 0x0200043D RID: 1085
		// (Invoke) Token: 0x06003175 RID: 12661
		private delegate long get_spaceFreeDelegate();

		// Token: 0x0200043E RID: 1086
		// (Invoke) Token: 0x06003177 RID: 12663
		private delegate long get_maximumAvailableDiskSpaceDelegate();

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x06003179 RID: 12665
		private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x0600317B RID: 12667
		private delegate int get_expirationDelayDelegate();

		// Token: 0x02000441 RID: 1089
		// (Invoke) Token: 0x0600317D RID: 12669
		private delegate void set_expirationDelayDelegate(int value);

		// Token: 0x02000442 RID: 1090
		// (Invoke) Token: 0x0600317F RID: 12671
		private delegate int get_cacheCountDelegate();

		// Token: 0x02000443 RID: 1091
		// (Invoke) Token: 0x06003181 RID: 12673
		private delegate bool MarkAsUsed_InjectedDelegate(IntPtr url, IntPtr assetBundleName, IntPtr hash);

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x06003183 RID: 12675
		private delegate void GetCacheAt_InjectedDelegate(int cacheIndex, [Out] IntPtr ret);

		// Token: 0x02000445 RID: 1093
		// (Invoke) Token: 0x06003185 RID: 12677
		private delegate bool RemoveCache_InjectedDelegate(IntPtr cache);

		// Token: 0x02000446 RID: 1094
		// (Invoke) Token: 0x06003187 RID: 12679
		private delegate void MoveCacheBefore_InjectedDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000447 RID: 1095
		// (Invoke) Token: 0x06003189 RID: 12681
		private delegate void MoveCacheAfter_InjectedDelegate(IntPtr src, IntPtr dst);
	}
}

using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Networking;

namespace dwd.core.bundles
{
	// Token: 0x020001F7 RID: 503
	public sealed class AssetBundleRequest : RefCounted
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x00081CA8 File Offset: 0x0007FEA8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRequest()
		{
			Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetBundleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr);
			AssetBundleRequest.NativeFieldInfoPtr_assetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "assetBundle");
			AssetBundleRequest.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "url");
			AssetBundleRequest.NativeFieldInfoPtr_rerequestURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "rerequestURL");
			AssetBundleRequest.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "Version");
			AssetBundleRequest.NativeFieldInfoPtr_crc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "crc");
			AssetBundleRequest.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "Error");
			AssetBundleRequest.NativeFieldInfoPtr__Loading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "<Loading>k__BackingField");
			AssetBundleRequest.NativeFieldInfoPtr__Loaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "<Loaded>k__BackingField");
			AssetBundleRequest.NativeFieldInfoPtr_isVersionCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "isVersionCached");
			AssetBundleRequest.NativeFieldInfoPtr_currentWWW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, "currentWWW");
			AssetBundleRequest.NativeMethodInfoPtr_get_AssetBundle_Internal_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667709);
			AssetBundleRequest.NativeMethodInfoPtr_set_AssetBundle_Internal_set_Void_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667710);
			AssetBundleRequest.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667711);
			AssetBundleRequest.NativeMethodInfoPtr_set_Loading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667712);
			AssetBundleRequest.NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667713);
			AssetBundleRequest.NativeMethodInfoPtr_set_Loaded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667714);
			AssetBundleRequest.NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667715);
			AssetBundleRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_UInt32_CleanupHandler_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667716);
			AssetBundleRequest.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667717);
			AssetBundleRequest.NativeMethodInfoPtr_CreateURI_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667718);
			AssetBundleRequest.NativeMethodInfoPtr_GetWWW_Public_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667719);
			AssetBundleRequest.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667720);
			AssetBundleRequest.NativeMethodInfoPtr_Get_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667721);
			AssetBundleRequest.NativeMethodInfoPtr_logAssetNames_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667722);
			AssetBundleRequest.NativeMethodInfoPtr_GetAsync_Public_AssetBundleRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667723);
			AssetBundleRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667724);
			AssetBundleRequest.NativeMethodInfoPtr_GetProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100667725);
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00081EF4 File Offset: 0x000800F4
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00081F34 File Offset: 0x00080134
		public unsafe AssetBundle AssetBundle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_AssetBundle_Internal_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885043, XrefRangeEnd = 885044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_set_AssetBundle_Internal_set_Void_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00081F78 File Offset: 0x00080178
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x00081FB4 File Offset: 0x000801B4
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_set_Loading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00081FF4 File Offset: 0x000801F4
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00082030 File Offset: 0x00080230
		public unsafe bool Loaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_set_Loaded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00082070 File Offset: 0x00080270
		public unsafe bool IsVersionCached
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 885053, RefRangeEnd = 885057, XrefRangeStart = 885044, XrefRangeEnd = 885053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000820AC File Offset: 0x000802AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885057, XrefRangeEnd = 885064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest(string strUrlIn, int intVersionIn, uint crcValue, RefCounted.CleanupHandler handler, string env = "", string reURL = "", bool precachedBundle = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strUrlIn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intVersionIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crcValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(env);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reURL);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precachedBundle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_UInt32_CleanupHandler_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0008215C File Offset: 0x0008035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885064, XrefRangeEnd = 885067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00082190 File Offset: 0x00080390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885067, XrefRangeEnd = 885072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateURI(string newurl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newurl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_CreateURI_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000821D4 File Offset: 0x000803D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885072, XrefRangeEnd = 885074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest GetWWW()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_GetWWW_Public_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00082214 File Offset: 0x00080414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885074, XrefRangeEnd = 885080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00082248 File Offset: 0x00080448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885080, XrefRangeEnd = 885084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::UnityEngine.Object Get(string asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_Get_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00082298 File Offset: 0x00080498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885084, XrefRangeEnd = 885094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logAssetNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_logAssetNames_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000822CC File Offset: 0x000804CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885094, XrefRangeEnd = 885098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest GetAsync(string asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_GetAsync_Public_AssetBundleRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0008231C File Offset: 0x0008051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885098, XrefRangeEnd = 885125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00082354 File Offset: 0x00080554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 885126, RefRangeEnd = 885127, XrefRangeStart = 885125, XrefRangeEnd = 885126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_GetProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0000BFC2 File Offset: 0x0000A1C2
		public AssetBundleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00082390 File Offset: 0x00080590
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0000BFCB File Offset: 0x0000A1CB
		public unsafe AssetBundle assetBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_assetBundle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_assetBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000823C0 File Offset: 0x000805C0
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0000BFEA File Offset: 0x0000A1EA
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000823E8 File Offset: 0x000805E8
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0000C009 File Offset: 0x0000A209
		public unsafe string rerequestURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_rerequestURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_rerequestURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00082410 File Offset: 0x00080610
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0000C028 File Offset: 0x0000A228
		public unsafe uint Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_Version)) = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00082438 File Offset: 0x00080638
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x0000C043 File Offset: 0x0000A243
		public unsafe uint crc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_crc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_crc)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00082460 File Offset: 0x00080660
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0000C05E File Offset: 0x0000A25E
		public unsafe string Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_Error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_Error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00082488 File Offset: 0x00080688
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000C07D File Offset: 0x0000A27D
		public unsafe bool _Loading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr__Loading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr__Loading_k__BackingField)) = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000824B0 File Offset: 0x000806B0
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000C098 File Offset: 0x0000A298
		public unsafe bool _Loaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr__Loaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr__Loaded_k__BackingField)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000824D8 File Offset: 0x000806D8
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
		public Nullable<bool> isVersionCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_isVersionCached);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_isVersionCached), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00082508 File Offset: 0x00080708
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		public unsafe UnityWebRequest currentWWW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_currentWWW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequest.NativeFieldInfoPtr_currentWWW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeFieldInfoPtr_assetBundle;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeFieldInfoPtr_rerequestURL;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr_crc;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr__Loading_k__BackingField;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr__Loaded_k__BackingField;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_isVersionCached;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_currentWWW;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetBundle_Internal_get_AssetBundle_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetBundle_Internal_set_Void_AssetBundle_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_set_Loading_Private_set_Void_Boolean_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_set_Loaded_Private_set_Void_Boolean_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVersionCached_Public_get_Boolean_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_UInt32_CleanupHandler_String_String_Boolean_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_CreateURI_Private_Void_String_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_GetWWW_Public_UnityWebRequest_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Object_String_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_logAssetNames_Public_Void_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_AssetBundleRequest_String_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Public_Single_0;
	}
}

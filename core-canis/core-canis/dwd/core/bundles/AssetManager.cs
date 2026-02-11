using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.bundles
{
	// Token: 0x020001F8 RID: 504
	public sealed class AssetManager : MonoBehaviour
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x00082538 File Offset: 0x00080738
		// Note: this type is marked as 'beforefieldinit'.
		static AssetManager()
		{
			Il2CppClassPointerStore<AssetManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetManager>.NativeClassPtr);
			AssetManager.NativeFieldInfoPtr_bundleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, "bundleManager");
			AssetManager.NativeFieldInfoPtr_antiCacheMechanism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, "antiCacheMechanism");
			AssetManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667726);
			AssetManager.NativeMethodInfoPtr_get_UseVerboseLogging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667727);
			AssetManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667728);
			AssetManager.NativeMethodInfoPtr_InitConfig_Public_Void_IAssetBundleConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667729);
			AssetManager.NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_String_RequestPriority_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667730);
			AssetManager.NativeMethodInfoPtr_Get_Public_BundleRequest_String_RequestPriority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667731);
			AssetManager.NativeMethodInfoPtr_Find_Public_Static_AssetManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667732);
			AssetManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100667733);
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00082630 File Offset: 0x00080830
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0008266C File Offset: 0x0008086C
		public unsafe bool UseVerboseLogging
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 422977, RefRangeEnd = 422979, XrefRangeStart = 422977, XrefRangeEnd = 422979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_get_UseVerboseLogging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000826A8 File Offset: 0x000808A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885127, XrefRangeEnd = 885153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000826DC File Offset: 0x000808DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885153, XrefRangeEnd = 885155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitConfig(IAssetBundleConfig config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_InitConfig_Public_Void_IAssetBundleConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00082720 File Offset: 0x00080920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885155, XrefRangeEnd = 885179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetRequest<T> Get<T>(string assetName, RequestPriority priority = RequestPriority.Normal, string DefaultAsset = null, bool asyncGet = false) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(DefaultAsset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncGet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.MethodInfoStoreGeneric_Get_Public_AssetRequest_1_T_String_RequestPriority_String_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr3) : null;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000827A0 File Offset: 0x000809A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885179, XrefRangeEnd = 885189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundleRequest Get(string bundleName, RequestPriority priority = RequestPriority.Normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_Get_Public_BundleRequest_String_RequestPriority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BundleRequest>(intPtr3) : null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00082800 File Offset: 0x00080A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885189, XrefRangeEnd = 885192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetManager Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr_Find_Public_Static_AssetManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetManager>(intPtr3) : null;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00082834 File Offset: 0x00080A34
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000C100 File Offset: 0x0000A300
		public AssetManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00082870 File Offset: 0x00080A70
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0000C109 File Offset: 0x0000A309
		public unsafe AssetBundleManager bundleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetManager.NativeFieldInfoPtr_bundleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetManager.NativeFieldInfoPtr_bundleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000828A0 File Offset: 0x00080AA0
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x0000C128 File Offset: 0x0000A328
		public unsafe string antiCacheMechanism
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetManager.NativeFieldInfoPtr_antiCacheMechanism);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetManager.NativeFieldInfoPtr_antiCacheMechanism), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeFieldInfoPtr_bundleManager;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeFieldInfoPtr_antiCacheMechanism;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_get_UseVerboseLogging_Public_get_Boolean_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_InitConfig_Public_Void_IAssetBundleConfig_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_String_RequestPriority_String_Boolean_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_BundleRequest_String_RequestPriority_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_AssetManager_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038B RID: 907
		private sealed class MethodInfoStoreGeneric_Get_Public_AssetRequest_1_T_String_RequestPriority_String_Boolean_0<T>
		{
			// Token: 0x04001B7A RID: 7034
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetManager.NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_String_RequestPriority_String_Boolean_0, Il2CppClassPointerStore<AssetManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000023A4 File Offset: 0x000005A4
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandlerAssetBundle()
		{
			Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestAssetBundleModule.dll", "UnityEngine.Networking", "DownloadHandlerAssetBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663304);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_CreateCached_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_Hash128_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663305);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_InternalCreateAssetBundle_Private_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663306);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_InternalCreateAssetBundleCached_Private_Void_String_String_Hash128_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663307);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663308);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663309);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663310);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_CachedAssetBundle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663311);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663312);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663313);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663314);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_autoLoadAssetBundle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663315);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_set_autoLoadAssetBundle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663316);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_isDownloadComplete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663317);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetContent_Public_Static_AssetBundle_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663318);
			DownloadHandlerAssetBundle.NativeMethodInfoPtr_CreateCached_Injected_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_byref_Hash128_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr, 100663319);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002514 File Offset: 0x00000714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272378, XrefRangeEnd = 1272380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002578 File Offset: 0x00000778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272380, XrefRangeEnd = 1272382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_CreateCached_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_Hash128_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000025FC File Offset: 0x000007FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272382, XrefRangeEnd = 1272384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateAssetBundle(string url, uint crc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_InternalCreateAssetBundle_Private_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000264C File Offset: 0x0000084C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272384, XrefRangeEnd = 1272386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_InternalCreateAssetBundleCached_Private_Void_String_String_Hash128_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000026BC File Offset: 0x000008BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272386, XrefRangeEnd = 1272389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerAssetBundle(string url, uint crc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002718 File Offset: 0x00000918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272389, XrefRangeEnd = 1272395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerAssetBundle(string url, uint version, uint crc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002780 File Offset: 0x00000980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272395, XrefRangeEnd = 1272400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerAssetBundle(string url, Hash128 hash, uint crc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000027E8 File Offset: 0x000009E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272400, XrefRangeEnd = 1272405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandlerAssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cachedBundle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_CachedAssetBundle_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002858 File Offset: 0x00000A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272405, XrefRangeEnd = 1272411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002898 File Offset: 0x00000A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272411, XrefRangeEnd = 1272417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetText_Protected_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe AssetBundle assetBundle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1272419, RefRangeEnd = 1272422, XrefRangeStart = 1272417, XrefRangeEnd = 1272419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000294C File Offset: 0x00000B4C
		public unsafe bool autoLoadAssetBundle
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1272424, RefRangeEnd = 1272427, XrefRangeStart = 1272422, XrefRangeEnd = 1272424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_autoLoadAssetBundle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1272429, RefRangeEnd = 1272430, XrefRangeStart = 1272427, XrefRangeEnd = 1272429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_set_autoLoadAssetBundle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000298C File Offset: 0x00000B8C
		public unsafe bool isDownloadComplete
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1272432, RefRangeEnd = 1272434, XrefRangeStart = 1272430, XrefRangeEnd = 1272432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_get_isDownloadComplete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029C8 File Offset: 0x00000BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272440, RefRangeEnd = 1272442, XrefRangeStart = 1272434, XrefRangeEnd = 1272440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle GetContent(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_GetContent_Public_Static_AssetBundle_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A0C File Offset: 0x00000C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272442, XrefRangeEnd = 1272444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hash;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandlerAssetBundle.NativeMethodInfoPtr_CreateCached_Injected_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_byref_Hash128_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002059 File Offset: 0x00000259
		public DownloadHandlerAssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_UInt32_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_CreateCached_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_Hash128_UInt32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateAssetBundle_Private_Void_String_UInt32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateAssetBundleCached_Private_Void_String_String_Hash128_UInt32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UInt32_UInt32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_UInt32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CachedAssetBundle_UInt32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_autoLoadAssetBundle_Public_get_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_autoLoadAssetBundle_Public_set_Void_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_isDownloadComplete_Public_get_Boolean_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetContent_Public_Static_AssetBundle_UnityWebRequest_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_CreateCached_Injected_Private_Static_IntPtr_DownloadHandlerAssetBundle_String_String_byref_Hash128_UInt32_0;
	}
}

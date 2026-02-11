using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public static class UnityWebRequestAssetBundle : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002064 File Offset: 0x00000264
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestAssetBundle()
		{
			Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestAssetBundleModule.dll", "UnityEngine.Networking", "UnityWebRequestAssetBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663297);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663298);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663299);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663300);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663301);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_Hash128_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663302);
			UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_CachedAssetBundle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestAssetBundle>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002120 File Offset: 0x00000320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272290, RefRangeEnd = 1272291, XrefRangeStart = 1272278, XrefRangeEnd = 1272290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002164 File Offset: 0x00000364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272291, XrefRangeEnd = 1272304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(Uri uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021A8 File Offset: 0x000003A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272304, XrefRangeEnd = 1272316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021FC File Offset: 0x000003FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272329, RefRangeEnd = 1272330, XrefRangeStart = 1272316, XrefRangeEnd = 1272329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(Uri uri, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002250 File Offset: 0x00000450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272345, RefRangeEnd = 1272347, XrefRangeStart = 1272330, XrefRangeEnd = 1272345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022B0 File Offset: 0x000004B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272361, RefRangeEnd = 1272362, XrefRangeStart = 1272347, XrefRangeEnd = 1272361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc = 0U)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_Hash128_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002310 File Offset: 0x00000510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272377, RefRangeEnd = 1272378, XrefRangeStart = 1272362, XrefRangeEnd = 1272377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0U)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cachedAssetBundle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref crc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestAssetBundle.NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_CachedAssetBundle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		public UnityWebRequestAssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000237C File Offset: 0x0000057C
		public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, [Optional] uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, cachedAssetBundle, crc), null);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_UInt32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_UInt32_UInt32_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_String_Hash128_UInt32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Static_UnityWebRequest_Uri_CachedAssetBundle_UInt32_0;
	}
}

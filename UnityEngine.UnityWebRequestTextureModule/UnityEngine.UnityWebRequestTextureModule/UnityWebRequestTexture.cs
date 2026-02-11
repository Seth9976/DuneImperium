using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public static class UnityWebRequestTexture : Object
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000023CC File Offset: 0x000005CC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityWebRequestTexture()
		{
			Il2CppClassPointerStore<UnityWebRequestTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestTextureModule.dll", "UnityEngine.Networking", "UnityWebRequestTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestTexture>.NativeClassPtr);
			UnityWebRequestTexture.NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestTexture>.NativeClassPtr, 100663304);
			UnityWebRequestTexture.NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequestTexture>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002424 File Offset: 0x00000624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273062, RefRangeEnd = 1273063, XrefRangeStart = 1273050, XrefRangeEnd = 1273062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetTexture(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestTexture.NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002468 File Offset: 0x00000668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273063, XrefRangeEnd = 1273075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityWebRequestTexture.NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020A2 File Offset: 0x000002A2
		public UnityWebRequestTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Static_UnityWebRequest_String_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.platform.auth
{
	// Token: 0x02000056 RID: 86
	public sealed class GetSteamPlatformToken : GetPlatformTokenWithForm
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00010A64 File Offset: 0x0000EC64
		// Note: this type is marked as 'beforefieldinit'.
		static GetSteamPlatformToken()
		{
			Il2CppClassPointerStore<GetSteamPlatformToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetSteamPlatformToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSteamPlatformToken>.NativeClassPtr);
			GetSteamPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamPlatformToken>.NativeClassPtr, 100663826);
			GetSteamPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSteamPlatformToken>.NativeClassPtr, 100663827);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00010ABC File Offset: 0x0000ECBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170068, XrefRangeEnd = 1170093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSteamPlatformToken(string authServerURL, string steamID, string steamToken, string steamName, string uniqueDeviceIdentifier)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSteamPlatformToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00010B54 File Offset: 0x0000ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170093, XrefRangeEnd = 1170114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WWWForm getWWWForm(string steamID, string steamToken, string steamName, string uniqueDeviceIdentifier)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(steamID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(steamName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSteamPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WWWForm>(intPtr3) : null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003931 File Offset: 0x00001B31
		public GetSteamPlatformToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_String_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.platform.auth
{
	// Token: 0x02000051 RID: 81
	public sealed class GetGuestPlatformToken : GetPlatformTokenWithForm
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00010084 File Offset: 0x0000E284
		// Note: this type is marked as 'beforefieldinit'.
		static GetGuestPlatformToken()
		{
			Il2CppClassPointerStore<GetGuestPlatformToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetGuestPlatformToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGuestPlatformToken>.NativeClassPtr);
			GetGuestPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGuestPlatformToken>.NativeClassPtr, 100663801);
			GetGuestPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGuestPlatformToken>.NativeClassPtr, 100663802);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000100DC File Offset: 0x0000E2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169908, XrefRangeEnd = 1169924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetGuestPlatformToken(string authServerURL, string uniqueDeviceIdentifier)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGuestPlatformToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGuestPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001013C File Offset: 0x0000E33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169924, XrefRangeEnd = 1169936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WWWForm getWWWForm(string uniqueDeviceIdentifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uniqueDeviceIdentifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGuestPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WWWForm>(intPtr3) : null;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000384E File Offset: 0x00001A4E
		public GetGuestPlatformToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_0;
	}
}

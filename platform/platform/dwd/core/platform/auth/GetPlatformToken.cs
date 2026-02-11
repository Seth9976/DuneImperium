using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.platform.auth
{
	// Token: 0x02000052 RID: 82
	public sealed class GetPlatformToken : GetPlatformTokenWithForm
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00010180 File Offset: 0x0000E380
		// Note: this type is marked as 'beforefieldinit'.
		static GetPlatformToken()
		{
			Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetPlatformToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr);
			GetPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr, 100663803);
			GetPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr, 100663804);
			GetPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr, 100663805);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000101EC File Offset: 0x0000E3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169936, XrefRangeEnd = 1169955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformToken(string authServerURL, string username, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001025C File Offset: 0x0000E45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169958, RefRangeEnd = 1169959, XrefRangeStart = 1169955, XrefRangeEnd = 1169958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformToken(string authServerURL, WWWForm wwwForm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wwwForm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformToken.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000102BC File Offset: 0x0000E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169959, XrefRangeEnd = 1169974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WWWForm getWWWForm(string username, string password)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformToken.NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WWWForm>(intPtr3) : null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003857 File Offset: 0x00001A57
		public GetPlatformToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_getWWWForm_Private_Static_WWWForm_String_String_0;
	}
}

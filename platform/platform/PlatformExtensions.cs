using System;
using dwd.core.networking.commands;
using dwd.core.platform;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public static class PlatformExtensions : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x00004988 File Offset: 0x00002B88
	// Note: this type is marked as 'beforefieldinit'.
	static PlatformExtensions()
	{
		Il2CppClassPointerStore<PlatformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "", "PlatformExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformExtensions>.NativeClassPtr);
		PlatformExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformExtensions>.NativeClassPtr, 100663301);
		PlatformExtensions.NativeMethodInfoPtr_GetFriendAccountIDFromChannelID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformExtensions>.NativeClassPtr, 100663302);
		PlatformExtensions.NativeMethodInfoPtr_DisableErrorLog_Public_Static_DwdWebRequestCommand_DwdWebRequestCommand_ApiStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformExtensions>.NativeClassPtr, 100663303);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000049F4 File Offset: 0x00002BF4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1165338, RefRangeEnd = 1165345, XrefRangeStart = 1165338, XrefRangeEnd = 1165338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValid(this PlatformToken token)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00004A38 File Offset: 0x00002C38
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1165353, RefRangeEnd = 1165355, XrefRangeStart = 1165345, XrefRangeEnd = 1165353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFriendAccountIDFromChannelID(string channelID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(channelID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformExtensions.NativeMethodInfoPtr_GetFriendAccountIDFromChannelID_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004A74 File Offset: 0x00002C74
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1165357, RefRangeEnd = 1165360, XrefRangeStart = 1165355, XrefRangeEnd = 1165357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DwdWebRequestCommand DisableErrorLog(this DwdWebRequestCommand command, ApiStatus httpCode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref httpCode;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformExtensions.NativeMethodInfoPtr_DisableErrorLog_Public_Static_DwdWebRequestCommand_DwdWebRequestCommand_ApiStatus_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr3) : null;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020DE File Offset: 0x000002DE
	public PlatformExtensions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_PlatformToken_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendAccountIDFromChannelID_Public_Static_String_String_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_DisableErrorLog_Public_Static_DwdWebRequestCommand_DwdWebRequestCommand_ApiStatus_0;
}

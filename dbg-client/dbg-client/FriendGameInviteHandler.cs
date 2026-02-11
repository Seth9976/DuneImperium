using System;
using dwd.core.commands;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class FriendGameInviteHandler : MonoBehaviour
{
	// Token: 0x06000093 RID: 147 RVA: 0x0001F444 File Offset: 0x0001D644
	// Note: this type is marked as 'beforefieldinit'.
	static FriendGameInviteHandler()
	{
		Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "FriendGameInviteHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr);
		FriendGameInviteHandler.NativeMethodInfoPtr_AddPlatformHandlers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663413);
		FriendGameInviteHandler.NativeMethodInfoPtr_GetFriendGameInviteFlow_Public_Virtual_New_Command_RequestToJoinFriendGame_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663414);
		FriendGameInviteHandler.NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663415);
		FriendGameInviteHandler.NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGameDeclined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663416);
		FriendGameInviteHandler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663417);
		FriendGameInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr, 100663418);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0001F4EC File Offset: 0x0001D6EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 495755, RefRangeEnd = 495756, XrefRangeStart = 495733, XrefRangeEnd = 495755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPlatformHandlers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteHandler.NativeMethodInfoPtr_AddPlatformHandlers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0001F520 File Offset: 0x0001D720
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495756, XrefRangeEnd = 495776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Command GetFriendGameInviteFlow(RequestToJoinFriendGame request, bool promptUser = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promptUser;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameInviteHandler.NativeMethodInfoPtr_GetFriendGameInviteFlow_Public_Virtual_New_Command_RequestToJoinFriendGame_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0001F58C File Offset: 0x0001D78C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495776, XrefRangeEnd = 495777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunFlow(RequestToJoinFriendGame request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteHandler.NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495777, XrefRangeEnd = 495783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunFlow(RequestToJoinFriendGameDeclined request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteHandler.NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGameDeclined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0001F614 File Offset: 0x0001D814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495783, XrefRangeEnd = 495804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteHandler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0001F648 File Offset: 0x0001D848
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendGameInviteHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameInviteHandler>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002422 File Offset: 0x00000622
	public FriendGameInviteHandler(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_AddPlatformHandlers_Public_Void_0;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendGameInviteFlow_Public_Virtual_New_Command_RequestToJoinFriendGame_Boolean_0;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGame_0;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeMethodInfoPtr_RunFlow_Private_Void_RequestToJoinFriendGameDeclined_0;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class FriendChatView : ChatView
{
	// Token: 0x06000070 RID: 112 RVA: 0x00011EA8 File Offset: 0x000100A8
	// Note: this type is marked as 'beforefieldinit'.
	static FriendChatView()
	{
		Il2CppClassPointerStore<FriendChatView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "FriendChatView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr);
		FriendChatView.NativeFieldInfoPtr_friendID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, "friendID");
		FriendChatView.NativeFieldInfoPtr_initialLastViewedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, "initialLastViewedTimestamp");
		FriendChatView.NativeFieldInfoPtr_hasOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, "hasOpened");
		FriendChatView.NativeMethodInfoPtr_FindProvider_Protected_Virtual_ChatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663374);
		FriendChatView.NativeMethodInfoPtr_get_Provider_Private_get_FriendChatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663375);
		FriendChatView.NativeMethodInfoPtr_SetExternalChatButton_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663376);
		FriendChatView.NativeMethodInfoPtr_SetExternalNotificationPip_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663377);
		FriendChatView.NativeMethodInfoPtr_SetFriendID_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663378);
		FriendChatView.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663379);
		FriendChatView.NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663380);
		FriendChatView.NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_IReadOnlyList_1_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663381);
		FriendChatView.NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663382);
		FriendChatView.NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663383);
		FriendChatView.NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663384);
		FriendChatView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663385);
		FriendChatView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663386);
		FriendChatView.NativeMethodInfoPtr__Init_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663387);
		FriendChatView.NativeMethodInfoPtr__Init_b__9_1_Private_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, 100663388);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00012040 File Offset: 0x00010240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982642, XrefRangeEnd = 982645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ChatProvider FindProvider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_FindProvider_Protected_Virtual_ChatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChatProvider>(intPtr3) : null;
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000072 RID: 114 RVA: 0x0001208C File Offset: 0x0001028C
	public unsafe FriendChatProvider Provider
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 982647, RefRangeEnd = 982651, XrefRangeStart = 982645, XrefRangeEnd = 982647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr_get_Provider_Private_get_FriendChatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FriendChatProvider>(intPtr3) : null;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000120CC File Offset: 0x000102CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExternalChatButton(GameObject button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr_SetExternalChatButton_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00012110 File Offset: 0x00010310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExternalNotificationPip(GameObject pip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr_SetExternalNotificationPip_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00012154 File Offset: 0x00010354
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982652, RefRangeEnd = 982653, XrefRangeStart = 982651, XrefRangeEnd = 982652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFriendID(AccountID id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr_SetFriendID_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00012198 File Offset: 0x00010398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982653, XrefRangeEnd = 982674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000121D4 File Offset: 0x000103D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982674, XrefRangeEnd = 982680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SendChatMessage(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00012224 File Offset: 0x00010424
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982680, XrefRangeEnd = 982700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IReadOnlyList<ClientChatMessage> GetOrderedChatMessages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_IReadOnlyList_1_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ClientChatMessage>>(intPtr3) : null;
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000079 RID: 121 RVA: 0x00012270 File Offset: 0x00010470
	public unsafe override long MostRecentTimestamp
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982700, XrefRangeEnd = 982704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600007A RID: 122 RVA: 0x000122B8 File Offset: 0x000104B8
	// (set) Token: 0x0600007B RID: 123 RVA: 0x00012300 File Offset: 0x00010500
	public unsafe override long LastViewedTimestamp
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982704, XrefRangeEnd = 982712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982712, XrefRangeEnd = 982727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatView.NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0001234C File Offset: 0x0001054C
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00012380 File Offset: 0x00010580
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982727, XrefRangeEnd = 982728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendChatView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x000123BC File Offset: 0x000105BC
	[CallerCount(0)]
	public unsafe void _Init_b__9_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr__Init_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000123F0 File Offset: 0x000105F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982728, XrefRangeEnd = 982729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Init_b__9_1(ClientChatMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.NativeMethodInfoPtr__Init_b__9_1_Private_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002317 File Offset: 0x00000517
	public FriendChatView(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000081 RID: 129 RVA: 0x00012434 File Offset: 0x00010634
	// (set) Token: 0x06000082 RID: 130 RVA: 0x00002320 File Offset: 0x00000520
	public unsafe AccountID friendID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_friendID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_friendID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000083 RID: 131 RVA: 0x00012464 File Offset: 0x00010664
	// (set) Token: 0x06000084 RID: 132 RVA: 0x0000233F File Offset: 0x0000053F
	public unsafe long initialLastViewedTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_initialLastViewedTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_initialLastViewedTimestamp)) = value;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0001248C File Offset: 0x0001068C
	// (set) Token: 0x06000086 RID: 134 RVA: 0x0000235A File Offset: 0x0000055A
	public unsafe bool hasOpened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_hasOpened);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatView.NativeFieldInfoPtr_hasOpened)) = value;
		}
	}

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeFieldInfoPtr_friendID;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeFieldInfoPtr_initialLastViewedTimestamp;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeFieldInfoPtr_hasOpened;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_FindProvider_Protected_Virtual_ChatProvider_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Private_get_FriendChatProvider_0;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeMethodInfoPtr_SetExternalChatButton_Public_Void_GameObject_0;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_SetExternalNotificationPip_Public_Void_GameObject_0;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeMethodInfoPtr_SetFriendID_Public_Void_AccountID_0;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeMethodInfoPtr_SendChatMessage_Protected_Virtual_Void_String_0;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeMethodInfoPtr_GetOrderedChatMessages_Protected_Virtual_IReadOnlyList_1_ClientChatMessage_0;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeMethodInfoPtr_get_MostRecentTimestamp_Protected_Virtual_get_Int64_0;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeMethodInfoPtr_get_LastViewedTimestamp_Protected_Virtual_get_Int64_0;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeMethodInfoPtr_set_LastViewedTimestamp_Protected_Virtual_set_Void_Int64_0;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr__Init_b__9_0_Private_Void_0;

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeMethodInfoPtr__Init_b__9_1_Private_Void_ClientChatMessage_0;

	// Token: 0x02000190 RID: 400
	[ObfuscatedName("FriendChatView+<>c")]
	[Serializable]
	public new sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x0004D39C File Offset: 0x0004B59C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatView>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr);
			FriendChatView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr, "<>9");
			FriendChatView.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr, "<>9__11_0");
			FriendChatView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr, 100663390);
			FriendChatView.__c.NativeMethodInfoPtr__GetOrderedChatMessages_b__11_0_Internal_Int64_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr, 100663391);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0004D418 File Offset: 0x0004B618
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatView.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0004D454 File Offset: 0x0004B654
		[CallerCount(0)]
		public unsafe long _GetOrderedChatMessages_b__11_0(ClientChatMessage x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatView.__c.NativeMethodInfoPtr__GetOrderedChatMessages_b__11_0_Internal_Int64_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0000B1A7 File Offset: 0x000093A7
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0004D4A4 File Offset: 0x0004B6A4
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x0000B1B0 File Offset: 0x000093B0
		public unsafe static FriendChatView.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FriendChatView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatView.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendChatView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0004D4CC File Offset: 0x0004B6CC
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000B1C2 File Offset: 0x000093C2
		public unsafe static Func<ClientChatMessage, long> __9__11_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FriendChatView.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClientChatMessage, long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendChatView.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedChatMessages_b__11_0_Internal_Int64_ClientChatMessage_0;
	}
}

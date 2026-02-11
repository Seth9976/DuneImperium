using System;
using boardgames.account;
using Canis.utils.ids;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class FriendChatResponder : Subscriber<IDComponent<AccountID>>
{
	// Token: 0x0600005B RID: 91 RVA: 0x0001E854 File Offset: 0x0001CA54
	// Note: this type is marked as 'beforefieldinit'.
	static FriendChatResponder()
	{
		Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "FriendChatResponder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr);
		FriendChatResponder.NativeFieldInfoPtr_chatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "chatButton");
		FriendChatResponder.NativeFieldInfoPtr_notificationPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "notificationPip");
		FriendChatResponder.NativeFieldInfoPtr_chatView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "chatView");
		FriendChatResponder.NativeFieldInfoPtr_moveChatToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "moveChatToParent");
		FriendChatResponder.NativeFieldInfoPtr__ChatView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "<ChatView>k__BackingField");
		FriendChatResponder.NativeMethodInfoPtr_get_ChatView_Public_get_FriendChatView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663363);
		FriendChatResponder.NativeMethodInfoPtr_set_ChatView_Private_set_Void_FriendChatView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663364);
		FriendChatResponder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663365);
		FriendChatResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663366);
		FriendChatResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663367);
		FriendChatResponder.NativeMethodInfoPtr_Event_OpenChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663368);
		FriendChatResponder.NativeMethodInfoPtr_openChat_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663369);
		FriendChatResponder.NativeMethodInfoPtr_Event_CloseChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663370);
		FriendChatResponder.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663371);
		FriendChatResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, 100663372);
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600005C RID: 92 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
	// (set) Token: 0x0600005D RID: 93 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
	public unsafe FriendChatView ChatView
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_get_ChatView_Public_get_FriendChatView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FriendChatView>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_set_ChatView_Private_set_Void_FriendChatView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0001EA34 File Offset: 0x0001CC34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495316, XrefRangeEnd = 495335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0001EA68 File Offset: 0x0001CC68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495335, XrefRangeEnd = 495346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495346, XrefRangeEnd = 495357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void modelChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495357, XrefRangeEnd = 495363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_OpenChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_Event_OpenChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0001EB14 File Offset: 0x0001CD14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495363, XrefRangeEnd = 495368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator openChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_openChat_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0001EB54 File Offset: 0x0001CD54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495368, XrefRangeEnd = 495370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_CloseChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr_Event_CloseChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0001EB88 File Offset: 0x0001CD88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495370, XrefRangeEnd = 495378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void onDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendChatResponder.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495378, XrefRangeEnd = 495381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FriendChatResponder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002292 File Offset: 0x00000492
	public FriendChatResponder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000067 RID: 103 RVA: 0x0001EC00 File Offset: 0x0001CE00
	// (set) Token: 0x06000068 RID: 104 RVA: 0x0000229B File Offset: 0x0000049B
	public unsafe GameObject chatButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_chatButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_chatButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000069 RID: 105 RVA: 0x0001EC30 File Offset: 0x0001CE30
	// (set) Token: 0x0600006A RID: 106 RVA: 0x000022BA File Offset: 0x000004BA
	public unsafe GameObject notificationPip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_notificationPip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_notificationPip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600006B RID: 107 RVA: 0x0001EC60 File Offset: 0x0001CE60
	// (set) Token: 0x0600006C RID: 108 RVA: 0x000022D9 File Offset: 0x000004D9
	public unsafe FriendChatView chatView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_chatView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatView>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_chatView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600006D RID: 109 RVA: 0x0001EC90 File Offset: 0x0001CE90
	// (set) Token: 0x0600006E RID: 110 RVA: 0x000022F8 File Offset: 0x000004F8
	public unsafe Transform moveChatToParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_moveChatToParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr_moveChatToParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006F RID: 111 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
	// (set) Token: 0x06000070 RID: 112 RVA: 0x00002317 File Offset: 0x00000517
	public unsafe FriendChatView _ChatView_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr__ChatView_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatView>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder.NativeFieldInfoPtr__ChatView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeFieldInfoPtr_chatButton;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeFieldInfoPtr_notificationPip;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeFieldInfoPtr_chatView;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeFieldInfoPtr_moveChatToParent;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeFieldInfoPtr__ChatView_k__BackingField;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_get_ChatView_Public_get_FriendChatView_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_set_ChatView_Private_set_Void_FriendChatView_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_Event_OpenChat_Public_Void_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_openChat_Private_IEnumerator_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_Event_CloseChat_Public_Void_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002C9 RID: 713
	[ObfuscatedName("FriendChatResponder+<openChat>d__12")]
	public sealed class _openChat_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x0600216F RID: 8559 RVA: 0x0008C8DC File Offset: 0x0008AADC
		// Note: this type is marked as 'beforefieldinit'.
		static _openChat_d__12()
		{
			Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendChatResponder>.NativeClassPtr, "<openChat>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr);
			FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, "<>1__state");
			FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, "<>2__current");
			FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, "<>4__this");
			FriendChatResponder._openChat_d__12.NativeFieldInfoPtr__check_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, "<check>5__2");
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663373);
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663374);
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663375);
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663376);
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663377);
			FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr, 100663378);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _openChat_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendChatResponder._openChat_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0008CA18 File Offset: 0x0008AC18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x0008CA4C File Offset: 0x0008AC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495295, XrefRangeEnd = 495311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0008CA88 File Offset: 0x0008AC88
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0008CAC8 File Offset: 0x0008ACC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495311, XrefRangeEnd = 495316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x0008CAFC File Offset: 0x0008ACFC
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendChatResponder._openChat_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0001177F File Offset: 0x0000F97F
		public _openChat_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x0008CB3C File Offset: 0x0008AD3C
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00011788 File Offset: 0x0000F988
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0008CB64 File Offset: 0x0008AD64
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x000117A3 File Offset: 0x0000F9A3
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x0008CB94 File Offset: 0x0008AD94
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x000117C2 File Offset: 0x0000F9C2
		public unsafe FriendChatResponder __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x0008CBC4 File Offset: 0x0008ADC4
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x000117E1 File Offset: 0x0000F9E1
		public unsafe ICheckPrivilegesCommand _check_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr__check_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendChatResponder._openChat_d__12.NativeFieldInfoPtr__check_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr__check_5__2;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

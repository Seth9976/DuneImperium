using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000021 RID: 33
public class MessageBundleMessage : Object
{
	// Token: 0x060002FF RID: 767 RVA: 0x0001DEA8 File Offset: 0x0001C0A8
	// Note: this type is marked as 'beforefieldinit'.
	static MessageBundleMessage()
	{
		Il2CppClassPointerStore<MessageBundleMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MessageBundleMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBundleMessage>.NativeClassPtr);
		MessageBundleMessage.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBundleMessage>.NativeClassPtr, "messages");
		MessageBundleMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBundleMessage>.NativeClassPtr, 100663683);
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0001DF00 File Offset: 0x0001C100
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MessageBundleMessage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBundleMessage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBundleMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00003536 File Offset: 0x00001736
	public MessageBundleMessage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000302 RID: 770 RVA: 0x0001DF3C File Offset: 0x0001C13C
	// (set) Token: 0x06000303 RID: 771 RVA: 0x0000353F File Offset: 0x0000173F
	public unsafe Il2CppReferenceArray<NetworkMessageEvent> messages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBundleMessage.NativeFieldInfoPtr_messages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkMessageEvent>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBundleMessage.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400021F RID: 543
	private static readonly IntPtr NativeFieldInfoPtr_messages;

	// Token: 0x04000220 RID: 544
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

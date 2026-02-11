using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002CC RID: 716
	public class AsyncRequest : Object
	{
		// Token: 0x06002D33 RID: 11571 RVA: 0x000EBE34 File Offset: 0x000EA034
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncRequest()
		{
			Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "AsyncRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr);
			AsyncRequest.NativeFieldInfoPtr_ReplySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "ReplySink");
			AsyncRequest.NativeFieldInfoPtr_MsgRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "MsgRequest");
			AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, 100670565);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000EBEA0 File Offset: 0x000EA0A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138610, RefRangeEnd = 1138611, XrefRangeStart = 1138610, XrefRangeEnd = 1138611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncRequest(IMessage msgRequest, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x0000F262 File Offset: 0x0000D462
		public AsyncRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000EBF00 File Offset: 0x000EA100
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x0000F26B File Offset: 0x0000D46B
		public unsafe IMessageSink ReplySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000EBF30 File Offset: 0x000EA130
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x0000F28A File Offset: 0x0000D48A
		public unsafe IMessage MsgRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeFieldInfoPtr_ReplySink;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeFieldInfoPtr_MsgRequest;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0;
	}
}

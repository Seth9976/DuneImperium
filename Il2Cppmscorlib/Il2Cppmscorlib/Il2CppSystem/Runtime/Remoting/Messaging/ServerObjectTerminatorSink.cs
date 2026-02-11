using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200030E RID: 782
	public class ServerObjectTerminatorSink : Object
	{
		// Token: 0x0600304C RID: 12364 RVA: 0x000F6DE8 File Offset: 0x000F4FE8
		// Note: this type is marked as 'beforefieldinit'.
		static ServerObjectTerminatorSink()
		{
			Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ServerObjectTerminatorSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr);
			ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, "_nextSink");
			ServerObjectTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100670929);
			ServerObjectTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100670930);
			ServerObjectTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100670931);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000F6E68 File Offset: 0x000F5068
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerObjectTerminatorSink(IMessageSink nextSink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000F6EB4 File Offset: 0x000F50B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384334, XrefRangeEnd = 1384345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000F6F04 File Offset: 0x000F5104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384345, XrefRangeEnd = 1384363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000108BD File Offset: 0x0000EABD
		public ServerObjectTerminatorSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x000F6F68 File Offset: 0x000F5168
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x000108C6 File Offset: 0x0000EAC6
		public unsafe IMessageSink _nextSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeFieldInfoPtr__nextSink;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

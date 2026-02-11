using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200030F RID: 783
	public class ServerObjectReplySink : Object
	{
		// Token: 0x06003053 RID: 12371 RVA: 0x000F6F98 File Offset: 0x000F5198
		// Note: this type is marked as 'beforefieldinit'.
		static ServerObjectReplySink()
		{
			Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ServerObjectReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr);
			ServerObjectReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_replySink");
			ServerObjectReplySink.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_identity");
			ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100670932);
			ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100670933);
			ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100670934);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000F702C File Offset: 0x000F522C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138610, RefRangeEnd = 1138611, XrefRangeStart = 1138610, XrefRangeEnd = 1138611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000F708C File Offset: 0x000F528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384363, XrefRangeEnd = 1384368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x000F70DC File Offset: 0x000F52DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384368, XrefRangeEnd = 1384373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x000108E5 File Offset: 0x0000EAE5
		public ServerObjectReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x000F7140 File Offset: 0x000F5340
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x000108EE File Offset: 0x0000EAEE
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x000F7170 File Offset: 0x000F5370
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x0001090D File Offset: 0x0000EB0D
		public unsafe ServerIdentity _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

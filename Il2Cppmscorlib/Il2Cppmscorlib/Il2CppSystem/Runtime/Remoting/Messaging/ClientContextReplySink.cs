using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F2 RID: 754
	public class ClientContextReplySink : Object
	{
		// Token: 0x06002EB0 RID: 11952 RVA: 0x000F0D2C File Offset: 0x000EEF2C
		// Note: this type is marked as 'beforefieldinit'.
		static ClientContextReplySink()
		{
			Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ClientContextReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr);
			ClientContextReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_replySink");
			ClientContextReplySink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_context");
			ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100670720);
			ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100670721);
			ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100670722);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000F0DC0 File Offset: 0x000EEFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138610, RefRangeEnd = 1138611, XrefRangeStart = 1138610, XrefRangeEnd = 1138611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientContextReplySink(Context ctx, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000F0E20 File Offset: 0x000EF020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382998, XrefRangeEnd = 1383007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000F0E70 File Offset: 0x000EF070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383007, XrefRangeEnd = 1383012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x0000FE00 File Offset: 0x0000E000
		public ClientContextReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x000F0ED4 File Offset: 0x000EF0D4
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x0000FE09 File Offset: 0x0000E009
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x000F0F04 File Offset: 0x000EF104
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x0000FE28 File Offset: 0x0000E028
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

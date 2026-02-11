using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F1 RID: 753
	public class ClientContextTerminatorSink : Object
	{
		// Token: 0x06002EA9 RID: 11945 RVA: 0x000F0B7C File Offset: 0x000EED7C
		// Note: this type is marked as 'beforefieldinit'.
		static ClientContextTerminatorSink()
		{
			Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ClientContextTerminatorSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr);
			ClientContextTerminatorSink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, "_context");
			ClientContextTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100670717);
			ClientContextTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100670718);
			ClientContextTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100670719);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000F0BFC File Offset: 0x000EEDFC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientContextTerminatorSink(Context ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000F0C48 File Offset: 0x000EEE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382946, XrefRangeEnd = 1382970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000F0C98 File Offset: 0x000EEE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382970, XrefRangeEnd = 1382998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		public ClientContextTerminatorSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000F0CFC File Offset: 0x000EEEFC
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x0000FDE1 File Offset: 0x0000DFE1
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextTerminatorSink.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextTerminatorSink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

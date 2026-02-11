using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A5 RID: 677
	public class DisposerReplySink : Object
	{
		// Token: 0x06002B78 RID: 11128 RVA: 0x000E59A4 File Offset: 0x000E3BA4
		// Note: this type is marked as 'beforefieldinit'.
		static DisposerReplySink()
		{
			Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "DisposerReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr);
			DisposerReplySink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_next");
			DisposerReplySink.NativeFieldInfoPtr__disposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_disposable");
			DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100670340);
			DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100670341);
			DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100670342);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000E5A38 File Offset: 0x000E3C38
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposerReplySink(IMessageSink next, IDisposable disposable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(disposable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000E5A98 File Offset: 0x000E3C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379273, XrefRangeEnd = 1379280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000E5AE8 File Offset: 0x000E3CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379280, XrefRangeEnd = 1379285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0000E7BA File Offset: 0x0000C9BA
		public DisposerReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000E5B4C File Offset: 0x000E3D4C
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x0000E7C3 File Offset: 0x0000C9C3
		public unsafe IMessageSink _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000E5B7C File Offset: 0x000E3D7C
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x0000E7E2 File Offset: 0x0000C9E2
		public unsafe IDisposable _disposable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr__disposable;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B6 RID: 694
	public class LeaseSink : Object
	{
		// Token: 0x06002C55 RID: 11349 RVA: 0x000E8C34 File Offset: 0x000E6E34
		// Note: this type is marked as 'beforefieldinit'.
		static LeaseSink()
		{
			Il2CppClassPointerStore<LeaseSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr);
			LeaseSink.NativeFieldInfoPtr__nextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, "_nextSink");
			LeaseSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100670447);
			LeaseSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100670448);
			LeaseSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100670449);
			LeaseSink.NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100670450);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000E8CC8 File Offset: 0x000E6EC8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaseSink(IMessageSink nextSink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000E8D14 File Offset: 0x000E6F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380308, XrefRangeEnd = 1380313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000E8D64 File Offset: 0x000E6F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380313, XrefRangeEnd = 1380317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000E8DC8 File Offset: 0x000E6FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1380336, RefRangeEnd = 1380338, XrefRangeStart = 1380317, XrefRangeEnd = 1380336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenewLease(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		public LeaseSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000E8E0C File Offset: 0x000E700C
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x0000ED65 File Offset: 0x0000CF65
		public unsafe IMessageSink _nextSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseSink.NativeFieldInfoPtr__nextSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseSink.NativeFieldInfoPtr__nextSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeFieldInfoPtr__nextSink;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0;
	}
}

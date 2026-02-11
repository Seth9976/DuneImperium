using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BC RID: 700
	public class CrossContextChannel : Object
	{
		// Token: 0x06002CC3 RID: 11459 RVA: 0x000EA5B4 File Offset: 0x000E87B4
		// Note: this type is marked as 'beforefieldinit'.
		static CrossContextChannel()
		{
			Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "CrossContextChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr);
			CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100670506);
			CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100670507);
			CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100670508);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000EA620 File Offset: 0x000E8820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381065, RefRangeEnd = 1381066, XrefRangeStart = 1381029, XrefRangeEnd = 1381065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000EA670 File Offset: 0x000E8870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381066, XrefRangeEnd = 1381110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000EA6D4 File Offset: 0x000E88D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossContextChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0000EF8D File Offset: 0x0000D18D
		public CrossContextChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200066A RID: 1642
		public class ContextRestoreSink : Object
		{
			// Token: 0x06005B35 RID: 23349 RVA: 0x0019F3B4 File Offset: 0x0019D5B4
			// Note: this type is marked as 'beforefieldinit'.
			static ContextRestoreSink()
			{
				Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, "ContextRestoreSink");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr);
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_next");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_context");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_call");
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100670509);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100670510);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100670511);
			}

			// Token: 0x06005B36 RID: 23350 RVA: 0x0019F458 File Offset: 0x0019D658
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContextRestoreSink(IMessageSink next, Context context, IMessage call)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B37 RID: 23351 RVA: 0x0019F4C8 File Offset: 0x0019D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381002, XrefRangeEnd = 1381024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
				}
			}

			// Token: 0x06005B38 RID: 23352 RVA: 0x0019F518 File Offset: 0x0019D718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381024, XrefRangeEnd = 1381029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
			}

			// Token: 0x06005B39 RID: 23353 RVA: 0x0002109D File Offset: 0x0001F29D
			public ContextRestoreSink(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700175D RID: 5981
			// (get) Token: 0x06005B3A RID: 23354 RVA: 0x0019F57C File Offset: 0x0019D77C
			// (set) Token: 0x06005B3B RID: 23355 RVA: 0x000210A6 File Offset: 0x0001F2A6
			public unsafe IMessageSink _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700175E RID: 5982
			// (get) Token: 0x06005B3C RID: 23356 RVA: 0x0019F5AC File Offset: 0x0019D7AC
			// (set) Token: 0x06005B3D RID: 23357 RVA: 0x000210C5 File Offset: 0x0001F2C5
			public unsafe Context _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700175F RID: 5983
			// (get) Token: 0x06005B3E RID: 23358 RVA: 0x0019F5DC File Offset: 0x0019D7DC
			// (set) Token: 0x06005B3F RID: 23359 RVA: 0x000210E4 File Offset: 0x0001F2E4
			public unsafe IMessage _call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A5C RID: 19036
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x04004A5D RID: 19037
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x04004A5E RID: 19038
			private static readonly IntPtr NativeFieldInfoPtr__call;

			// Token: 0x04004A5F RID: 19039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0;

			// Token: 0x04004A60 RID: 19040
			private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

			// Token: 0x04004A61 RID: 19041
			private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
		}
	}
}

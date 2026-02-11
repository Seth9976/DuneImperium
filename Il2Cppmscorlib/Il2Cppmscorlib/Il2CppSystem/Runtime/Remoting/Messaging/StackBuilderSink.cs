using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000310 RID: 784
	public class StackBuilderSink : Object
	{
		// Token: 0x0600305C RID: 12380 RVA: 0x000F71A0 File Offset: 0x000F53A0
		// Note: this type is marked as 'beforefieldinit'.
		static StackBuilderSink()
		{
			Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "StackBuilderSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr);
			StackBuilderSink.NativeFieldInfoPtr__target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_target");
			StackBuilderSink.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, "_rp");
			StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670935);
			StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670936);
			StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670937);
			StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670938);
			StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670939);
			StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr, 100670940);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000F7270 File Offset: 0x000F5470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384373, XrefRangeEnd = 1384383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackBuilderSink(MarshalByRefObject obj, bool forceInternalExecute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackBuilderSink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000F72CC File Offset: 0x000F54CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384383, XrefRangeEnd = 1384394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000F731C File Offset: 0x000F551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384394, XrefRangeEnd = 1384408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000F7380 File Offset: 0x000F5580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384433, RefRangeEnd = 1384434, XrefRangeStart = 1384408, XrefRangeEnd = 1384433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteAsyncMessage(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000F73C4 File Offset: 0x000F55C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1384445, RefRangeEnd = 1384447, XrefRangeStart = 1384434, XrefRangeEnd = 1384445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckParameters(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x000F7408 File Offset: 0x000F5608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384447, XrefRangeEnd = 1384449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__4_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackBuilderSink.NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0001092C File Offset: 0x0000EB2C
		public StackBuilderSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x000F744C File Offset: 0x000F564C
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x00010935 File Offset: 0x0000EB35
		public unsafe MarshalByRefObject _target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x000F747C File Offset: 0x000F567C
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x00010954 File Offset: 0x0000EB54
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackBuilderSink.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeFieldInfoPtr__target;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MarshalByRefObject_Boolean_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsyncMessage_Private_Void_Object_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_CheckParameters_Private_Void_IMessage_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__4_0_Private_Void_Object_0;
	}
}

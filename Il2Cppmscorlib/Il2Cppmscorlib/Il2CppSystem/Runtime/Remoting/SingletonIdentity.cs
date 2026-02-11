using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A3 RID: 675
	public class SingletonIdentity : ServerIdentity
	{
		// Token: 0x06002B6D RID: 11117 RVA: 0x000E5600 File Offset: 0x000E3800
		// Note: this type is marked as 'beforefieldinit'.
		static SingletonIdentity()
		{
			Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SingletonIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr);
			SingletonIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100670333);
			SingletonIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100670334);
			SingletonIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100670335);
			SingletonIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr, 100670336);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000E5680 File Offset: 0x000E3880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingletonIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingletonIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000E56F0 File Offset: 0x000E38F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379221, RefRangeEnd = 1379223, XrefRangeStart = 1379214, XrefRangeEnd = 1379221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByRefObject GetServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingletonIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000E5730 File Offset: 0x000E3930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379223, XrefRangeEnd = 1379230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000E578C File Offset: 0x000E398C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379230, XrefRangeEnd = 1379236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingletonIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		public SingletonIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

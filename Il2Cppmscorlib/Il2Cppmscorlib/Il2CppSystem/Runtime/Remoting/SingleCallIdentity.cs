using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A4 RID: 676
	public class SingleCallIdentity : ServerIdentity
	{
		// Token: 0x06002B73 RID: 11123 RVA: 0x000E57FC File Offset: 0x000E39FC
		// Note: this type is marked as 'beforefieldinit'.
		static SingleCallIdentity()
		{
			Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SingleCallIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr);
			SingleCallIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100670337);
			SingleCallIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100670338);
			SingleCallIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr, 100670339);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000E5868 File Offset: 0x000E3A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleCallIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleCallIdentity>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleCallIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000E58D8 File Offset: 0x000E3AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379236, XrefRangeEnd = 1379254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingleCallIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000E5934 File Offset: 0x000E3B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379254, XrefRangeEnd = 1379273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SingleCallIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x0000E7B1 File Offset: 0x0000C9B1
		public SingleCallIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0;
	}
}

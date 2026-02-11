using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Lifetime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A1 RID: 673
	public class ServerIdentity : Identity
	{
		// Token: 0x06002B4B RID: 11083 RVA: 0x000E4D10 File Offset: 0x000E2F10
		// Note: this type is marked as 'beforefieldinit'.
		static ServerIdentity()
		{
			Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ServerIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr);
			ServerIdentity.NativeFieldInfoPtr__objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_objectType");
			ServerIdentity.NativeFieldInfoPtr__serverObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverObject");
			ServerIdentity.NativeFieldInfoPtr__serverSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverSink");
			ServerIdentity.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_context");
			ServerIdentity.NativeFieldInfoPtr__lease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_lease");
			ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670315);
			ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670316);
			ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670317);
			ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670318);
			ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670319);
			ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670320);
			ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670321);
			ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670322);
			ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670323);
			ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670324);
			ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670325);
			ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100670326);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000E4E94 File Offset: 0x000E3094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379137, XrefRangeEnd = 1379141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000E4F04 File Offset: 0x000E3104
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000E4F44 File Offset: 0x000E3144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379141, XrefRangeEnd = 1379152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrackingLifetime(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000E4F88 File Offset: 0x000E3188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379152, XrefRangeEnd = 1379153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLifetimeExpired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000E4FC4 File Offset: 0x000E31C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379153, XrefRangeEnd = 1379174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000E5020 File Offset: 0x000E3220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379181, RefRangeEnd = 1379183, XrefRangeStart = 1379174, XrefRangeEnd = 1379181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000E5074 File Offset: 0x000E3274
		public unsafe Lease Lease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr3) : null;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000E50B4 File Offset: 0x000E32B4
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x000E50F4 File Offset: 0x000E32F4
		public unsafe Context Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000E5138 File Offset: 0x000E3338
		[CallerCount(0)]
		public unsafe virtual IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000E5194 File Offset: 0x000E3394
		[CallerCount(0)]
		public unsafe virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000E5204 File Offset: 0x000E3404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1379190, RefRangeEnd = 1379193, XrefRangeStart = 1379183, XrefRangeEnd = 1379190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		public ServerIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000E5238 File Offset: 0x000E3438
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x0000E6E5 File Offset: 0x0000C8E5
		public unsafe Type _objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000E5268 File Offset: 0x000E3468
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0000E704 File Offset: 0x0000C904
		public unsafe MarshalByRefObject _serverObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000E5298 File Offset: 0x000E3498
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x0000E723 File Offset: 0x0000C923
		public unsafe IMessageSink _serverSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x000E52C8 File Offset: 0x000E34C8
		// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0000E742 File Offset: 0x0000C942
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000E52F8 File Offset: 0x000E34F8
		// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0000E761 File Offset: 0x0000C961
		public unsafe Lease _lease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeFieldInfoPtr__objectType;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeFieldInfoPtr__serverObject;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeFieldInfoPtr__serverSink;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeFieldInfoPtr__lease;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_get_Lease_Public_get_Lease_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Context_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020002B0 RID: 688
	public class RealProxy : Object
	{
		// Token: 0x06002BED RID: 11245 RVA: 0x000E7490 File Offset: 0x000E5690
		// Note: this type is marked as 'beforefieldinit'.
		static RealProxy()
		{
			Il2CppClassPointerStore<RealProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RealProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealProxy>.NativeClassPtr);
			RealProxy.NativeFieldInfoPtr_class_to_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "class_to_proxy");
			RealProxy.NativeFieldInfoPtr__targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetContext");
			RealProxy.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_server");
			RealProxy.NativeFieldInfoPtr__targetDomainId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetDomainId");
			RealProxy.NativeFieldInfoPtr__targetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetUri");
			RealProxy.NativeFieldInfoPtr__objectIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objectIdentity");
			RealProxy.NativeFieldInfoPtr__objTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objTP");
			RealProxy.NativeFieldInfoPtr__stubData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_stubData");
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670396);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670397);
			RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670398);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670399);
			RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670400);
			RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670401);
			RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670402);
			RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670403);
			RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670404);
			RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670405);
			RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670406);
			RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670407);
			RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670408);
			RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670409);
			RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670410);
			RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670411);
			RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100670412);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000E76B4 File Offset: 0x000E58B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379799, XrefRangeEnd = 1379800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000E76F0 File Offset: 0x000E58F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379801, RefRangeEnd = 1379802, XrefRangeStart = 1379800, XrefRangeEnd = 1379801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000E773C File Offset: 0x000E593C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379804, RefRangeEnd = 1379805, XrefRangeStart = 1379802, XrefRangeEnd = 1379804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000E779C File Offset: 0x000E599C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379810, RefRangeEnd = 1379812, XrefRangeStart = 1379805, XrefRangeEnd = 1379810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, IntPtr stub, Object stubData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stub;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stubData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000E7808 File Offset: 0x000E5A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379812, XrefRangeEnd = 1379813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type InternalGetProxyType(Object transparentProxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transparentProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000E784C File Offset: 0x000E5A4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1379817, RefRangeEnd = 1379821, XrefRangeStart = 1379813, XrefRangeEnd = 1379817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetProxiedType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000E788C File Offset: 0x000E5A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379821, XrefRangeEnd = 1379826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000E78F0 File Offset: 0x000E5AF0
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x000E7930 File Offset: 0x000E5B30
		public unsafe Identity ObjectIdentity
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000E7974 File Offset: 0x000E5B74
		[CallerCount(0)]
		public unsafe virtual IMessage Invoke(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000E79D0 File Offset: 0x000E5BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379931, RefRangeEnd = 1379933, XrefRangeStart = 1379826, XrefRangeEnd = 1379931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			exc = ((intPtr5 == 0) ? null : new Exception(intPtr5));
			IntPtr intPtr6 = intPtr2;
			out_args = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Object>(intPtr7) : null;
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000E7A6C File Offset: 0x000E5C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379933, XrefRangeEnd = 1379934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InternalGetTransparentProxy(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000E7AC8 File Offset: 0x000E5CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379934, XrefRangeEnd = 1379947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetTransparentProxy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000E7B14 File Offset: 0x000E5D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServer(MarshalByRefObject s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000E7B58 File Offset: 0x000E5D58
		[CallerCount(0)]
		public unsafe void SetTargetDomain(int domainId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000E7B98 File Offset: 0x000E5D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379947, XrefRangeEnd = 1379955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetAppDomainTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000E7BD8 File Offset: 0x000E5DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379968, RefRangeEnd = 1379970, XrefRangeStart = 1379955, XrefRangeEnd = 1379968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mrm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public RealProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000E7C30 File Offset: 0x000E5E30
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0000EA6D File Offset: 0x0000CC6D
		public unsafe Type class_to_proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000E7C60 File Offset: 0x000E5E60
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		public unsafe Context _targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x000E7C90 File Offset: 0x000E5E90
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x0000EAAB File Offset: 0x0000CCAB
		public unsafe MarshalByRefObject _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000E7CC0 File Offset: 0x000E5EC0
		// (set) Token: 0x06002C07 RID: 11271 RVA: 0x0000EACA File Offset: 0x0000CCCA
		public unsafe int _targetDomainId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId)) = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x000E7CE8 File Offset: 0x000E5EE8
		// (set) Token: 0x06002C09 RID: 11273 RVA: 0x0000EAE5 File Offset: 0x0000CCE5
		public unsafe string _targetUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000E7D10 File Offset: 0x000E5F10
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x0000EB04 File Offset: 0x0000CD04
		public unsafe Identity _objectIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x000E7D40 File Offset: 0x000E5F40
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x0000EB23 File Offset: 0x0000CD23
		public unsafe Object _objTP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000E7D70 File Offset: 0x000E5F70
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x0000EB42 File Offset: 0x0000CD42
		public unsafe Object _stubData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeFieldInfoPtr_class_to_proxy;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeFieldInfoPtr__targetContext;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeFieldInfoPtr__targetDomainId;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeFieldInfoPtr__targetUri;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeFieldInfoPtr__objectIdentity;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeFieldInfoPtr__objTP;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeFieldInfoPtr__stubData;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiedType_Public_Type_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0;
	}
}

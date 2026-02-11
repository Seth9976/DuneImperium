using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A0 RID: 672
	public static class RemotingServices : Object
	{
		// Token: 0x06002B10 RID: 11024 RVA: 0x000E3AD8 File Offset: 0x000E1CD8
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingServices()
		{
			Il2CppClassPointerStore<RemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingServices");
			RemotingServices.NativeFieldInfoPtr_uri_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "uri_hash");
			RemotingServices.NativeFieldInfoPtr__serializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_serializationFormatter");
			RemotingServices.NativeFieldInfoPtr__deserializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_deserializationFormatter");
			RemotingServices.NativeFieldInfoPtr_app_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id");
			RemotingServices.NativeFieldInfoPtr_app_id_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id_lock");
			RemotingServices.NativeFieldInfoPtr_next_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "next_id");
			RemotingServices.NativeFieldInfoPtr_FieldSetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldSetterMethod");
			RemotingServices.NativeFieldInfoPtr_FieldGetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldGetterMethod");
			RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670273);
			RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670274);
			RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670275);
			RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670276);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670277);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670278);
			RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670279);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670280);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670281);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670282);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670283);
			RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670284);
			RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670285);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670286);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670287);
			RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670288);
			RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670289);
			RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670290);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670291);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670292);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670293);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670294);
			RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670295);
			RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670296);
			RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670297);
			RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670298);
			RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670299);
			RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670300);
			RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670301);
			RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670302);
			RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670303);
			RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670304);
			RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670305);
			RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670306);
			RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670307);
			RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670308);
			RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670309);
			RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670310);
			RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670311);
			RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670312);
			RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100670313);
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000E3ED4 File Offset: 0x000E20D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378363, XrefRangeEnd = 1378364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InternalExecute(MethodBase method, Object obj, Il2CppReferenceArray<Object> parameters, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			out_args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000E3F60 File Offset: 0x000E2160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378365, RefRangeEnd = 1378366, XrefRangeStart = 1378364, XrefRangeEnd = 1378365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetVirtualMethod(Type type, MethodBase method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000E3FB8 File Offset: 0x000E21B8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1378371, RefRangeEnd = 1378380, XrefRangeStart = 1378366, XrefRangeEnd = 1378371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTransparentProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000E3FFC File Offset: 0x000E21FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1378452, RefRangeEnd = 1378456, XrefRangeStart = 1378380, XrefRangeEnd = 1378452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMethodReturnMessage>(intPtr3) : null;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000E4054 File Offset: 0x000E2254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378467, RefRangeEnd = 1378468, XrefRangeStart = 1378456, XrefRangeEnd = 1378467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000E40AC File Offset: 0x000E22AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378468, XrefRangeEnd = 1378479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000E4114 File Offset: 0x000E2314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378486, RefRangeEnd = 1378487, XrefRangeStart = 1378479, XrefRangeEnd = 1378486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetServerTypeForUri(string URI)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(URI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000E4158 File Offset: 0x000E2358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378487, XrefRangeEnd = 1378491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000E419C File Offset: 0x000E239C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378546, RefRangeEnd = 1378547, XrefRangeStart = 1378491, XrefRangeEnd = 1378546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRefine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000E41F0 File Offset: 0x000E23F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1378551, RefRangeEnd = 1378554, XrefRangeStart = 1378547, XrefRangeEnd = 1378551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000E4234 File Offset: 0x000E2434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1378563, RefRangeEnd = 1378565, XrefRangeStart = 1378554, XrefRangeEnd = 1378563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ObjURI);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(RequestedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000E429C File Offset: 0x000E249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378565, XrefRangeEnd = 1378612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NewUri()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000E42C8 File Offset: 0x000E24C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1378617, RefRangeEnd = 1378622, XrefRangeStart = 1378612, XrefRangeEnd = 1378617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RealProxy GetRealProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000E430C File Offset: 0x000E250C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1378659, RefRangeEnd = 1378662, XrefRangeStart = 1378622, XrefRangeEnd = 1378659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000E4350 File Offset: 0x000E2550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1378680, RefRangeEnd = 1378682, XrefRangeStart = 1378662, XrefRangeEnd = 1378680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromName(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000E43B8 File Offset: 0x000E25B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378692, RefRangeEnd = 1378693, XrefRangeStart = 1378682, XrefRangeEnd = 1378692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindInterfaceMethod(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000E4420 File Offset: 0x000E2620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1378706, RefRangeEnd = 1378708, XrefRangeStart = 1378693, XrefRangeEnd = 1378706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000E4480 File Offset: 0x000E2680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1378715, RefRangeEnd = 1378717, XrefRangeStart = 1378708, XrefRangeEnd = 1378715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOneWay(MethodBase method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000E44C4 File Offset: 0x000E26C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378717, XrefRangeEnd = 1378729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(ActivatedClientTypeEntry entry, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000E451C File Offset: 0x000E271C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378748, RefRangeEnd = 1378749, XrefRangeStart = 1378729, XrefRangeEnd = 1378748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(Type objectType, string url, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000E4584 File Offset: 0x000E2784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378749, XrefRangeEnd = 1378763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000E45C8 File Offset: 0x000E27C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378763, XrefRangeEnd = 1378775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxyForContextBound(Type type, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000E4620 File Offset: 0x000E2820
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1378812, RefRangeEnd = 1378817, XrefRangeStart = 1378775, XrefRangeEnd = 1378812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetIdentityForUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000E4664 File Offset: 0x000E2864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378817, XrefRangeEnd = 1378828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAppNameFromUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000E46A0 File Offset: 0x000E28A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1378900, RefRangeEnd = 1378905, XrefRangeStart = 1378828, XrefRangeEnd = 1378900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out Object clientProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientProxy = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ClientIdentity>(intPtr5) : null;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000E471C File Offset: 0x000E291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378905, XrefRangeEnd = 1378910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink GetClientChannelSinkChain(string url, Object channelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000E4790 File Offset: 0x000E2990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378925, RefRangeEnd = 1378926, XrefRangeStart = 1378910, XrefRangeEnd = 1378925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000E47D4 File Offset: 0x000E29D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378926, XrefRangeEnd = 1378938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(realObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000E483C File Offset: 0x000E2A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378958, RefRangeEnd = 1378959, XrefRangeStart = 1378938, XrefRangeEnd = 1378958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000E48A0 File Offset: 0x000E2AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378973, RefRangeEnd = 1378974, XrefRangeStart = 1378959, XrefRangeEnd = 1378973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerIdentity(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000E48D8 File Offset: 0x000E2AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1378981, RefRangeEnd = 1378983, XrefRangeStart = 1378974, XrefRangeEnd = 1378981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objref);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000E4930 File Offset: 0x000E2B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1378987, RefRangeEnd = 1378988, XrefRangeStart = 1378983, XrefRangeEnd = 1378987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000E4988 File Offset: 0x000E2B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1378988, XrefRangeEnd = 1379016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeCallData(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000E49CC File Offset: 0x000E2BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379016, XrefRangeEnd = 1379041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeCallData(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000E4A10 File Offset: 0x000E2C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379041, XrefRangeEnd = 1379046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeExceptionData(Exception ex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000E4A54 File Offset: 0x000E2C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379046, XrefRangeEnd = 1379050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternalChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000E4A7C File Offset: 0x000E2C7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1379071, RefRangeEnd = 1379074, XrefRangeStart = 1379050, XrefRangeEnd = 1379071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeIdentity(Identity ident)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ident);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000E4AB4 File Offset: 0x000E2CB4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1379102, RefRangeEnd = 1379113, XrefRangeStart = 1379074, XrefRangeEnd = 1379102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetMessageTargetIdentity(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000E4AF8 File Offset: 0x000E2CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1379122, RefRangeEnd = 1379125, XrefRangeStart = 1379113, XrefRangeEnd = 1379122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ident);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000E4B40 File Offset: 0x000E2D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379125, XrefRangeEnd = 1379134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateOutArgObject(ParameterInfo pi, Object local, Object remote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(local);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000E4BA8 File Offset: 0x000E2DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379134, XrefRangeEnd = 1379137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalizedUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0000E647 File Offset: 0x0000C847
		public RemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000E4BE4 File Offset: 0x000E2DE4
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0000E650 File Offset: 0x0000C850
		public unsafe static Hashtable uri_hash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_uri_hash, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_uri_hash, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000E4C0C File Offset: 0x000E2E0C
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0000E662 File Offset: 0x0000C862
		public unsafe static BinaryFormatter _serializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000E4C34 File Offset: 0x000E2E34
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x0000E674 File Offset: 0x0000C874
		public unsafe static BinaryFormatter _deserializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000E4C5C File Offset: 0x000E2E5C
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x0000E686 File Offset: 0x0000C886
		public unsafe static string app_id
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000E4C7C File Offset: 0x000E2E7C
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x0000E698 File Offset: 0x0000C898
		public unsafe static Object app_id_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000E4CA4 File Offset: 0x000E2EA4
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x0000E6AA File Offset: 0x0000C8AA
		public unsafe static int next_id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000E4CC0 File Offset: 0x000E2EC0
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public unsafe static MethodInfo FieldSetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000E4CE8 File Offset: 0x000E2EE8
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0000E6CA File Offset: 0x0000C8CA
		public unsafe static MethodInfo FieldGetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeFieldInfoPtr_uri_hash;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeFieldInfoPtr__serializationFormatter;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeFieldInfoPtr__deserializationFormatter;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeFieldInfoPtr_app_id;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeFieldInfoPtr_app_id_lock;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeFieldInfoPtr_next_id;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeFieldInfoPtr_FieldSetterMethod;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeFieldInfoPtr_FieldGetterMethod;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_NewUri_Private_Static_String_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0;

		// Token: 0x02000666 RID: 1638
		[Serializable]
		public class CACD : Object
		{
			// Token: 0x06005B17 RID: 23319 RVA: 0x0019EEC4 File Offset: 0x0019D0C4
			// Note: this type is marked as 'beforefieldinit'.
			static CACD()
			{
				Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "CACD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr);
				RemotingServices.CACD.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "d");
				RemotingServices.CACD.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "c");
				RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, 100670314);
			}

			// Token: 0x06005B18 RID: 23320 RVA: 0x0019EF2C File Offset: 0x0019D12C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CACD()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B19 RID: 23321 RVA: 0x00020F98 File Offset: 0x0001F198
			public CACD(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001757 RID: 5975
			// (get) Token: 0x06005B1A RID: 23322 RVA: 0x0019EF68 File Offset: 0x0019D168
			// (set) Token: 0x06005B1B RID: 23323 RVA: 0x00020FA1 File Offset: 0x0001F1A1
			public unsafe Object d
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001758 RID: 5976
			// (get) Token: 0x06005B1C RID: 23324 RVA: 0x0019EF98 File Offset: 0x0019D198
			// (set) Token: 0x06005B1D RID: 23325 RVA: 0x00020FC0 File Offset: 0x0001F1C0
			public unsafe Object c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A4F RID: 19023
			private static readonly IntPtr NativeFieldInfoPtr_d;

			// Token: 0x04004A50 RID: 19024
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04004A51 RID: 19025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

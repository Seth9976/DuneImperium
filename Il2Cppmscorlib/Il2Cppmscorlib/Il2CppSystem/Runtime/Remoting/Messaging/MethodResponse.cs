using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000304 RID: 772
	[Serializable]
	public class MethodResponse : Object
	{
		// Token: 0x06002F8A RID: 12170 RVA: 0x000F41B8 File Offset: 0x000F23B8
		// Note: this type is marked as 'beforefieldinit'.
		static MethodResponse()
		{
			Il2CppClassPointerStore<MethodResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr);
			MethodResponse.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodName");
			MethodResponse.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_uri");
			MethodResponse.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_typeName");
			MethodResponse.NativeFieldInfoPtr__methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodBase");
			MethodResponse.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_returnValue");
			MethodResponse.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_exception");
			MethodResponse.NativeFieldInfoPtr__methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodSignature");
			MethodResponse.NativeFieldInfoPtr__inArgInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_inArgInfo");
			MethodResponse.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_args");
			MethodResponse.NativeFieldInfoPtr__outArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_outArgs");
			MethodResponse.NativeFieldInfoPtr__callMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_callMsg");
			MethodResponse.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_callContext");
			MethodResponse.NativeFieldInfoPtr__targetIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_targetIdentity");
			MethodResponse.NativeFieldInfoPtr_ExternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "ExternalProperties");
			MethodResponse.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "InternalProperties");
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670845);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670846);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670847);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670848);
			MethodResponse.NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670849);
			MethodResponse.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670850);
			MethodResponse.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670851);
			MethodResponse.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670852);
			MethodResponse.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670853);
			MethodResponse.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670854);
			MethodResponse.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670855);
			MethodResponse.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670856);
			MethodResponse.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670857);
			MethodResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670858);
			MethodResponse.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670859);
			MethodResponse.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670860);
			MethodResponse.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670861);
			MethodResponse.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670862);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670863);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670864);
			MethodResponse.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670865);
			MethodResponse.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670866);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670867);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100670868);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000F44F4 File Offset: 0x000F26F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1383846, RefRangeEnd = 1383849, XrefRangeStart = 1383831, XrefRangeEnd = 1383846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(Exception e, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000F4554 File Offset: 0x000F2754
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1383859, RefRangeEnd = 1383864, XrefRangeStart = 1383849, XrefRangeEnd = 1383859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(Object returnValue, Il2CppReferenceArray<Object> outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArgs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000F45D8 File Offset: 0x000F27D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383916, RefRangeEnd = 1383917, XrefRangeStart = 1383864, XrefRangeEnd = 1383916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retmsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000F4638 File Offset: 0x000F2838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000F469C File Offset: 0x000F289C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1383983, RefRangeEnd = 1383985, XrefRangeStart = 1383917, XrefRangeEnd = 1383983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000F46F0 File Offset: 0x000F28F0
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000F472C File Offset: 0x000F292C
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000F476C File Offset: 0x000F296C
		public unsafe virtual Exception Exception
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000F47AC File Offset: 0x000F29AC
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383985, XrefRangeEnd = 1383990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000F47EC File Offset: 0x000F29EC
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383990, XrefRangeEnd = 1384005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000F482C File Offset: 0x000F2A2C
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384005, XrefRangeEnd = 1384009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000F4864 File Offset: 0x000F2A64
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384009, XrefRangeEnd = 1384019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x000F48A4 File Offset: 0x000F2AA4
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384019, XrefRangeEnd = 1384044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000F48E4 File Offset: 0x000F2AE4
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x000F4930 File Offset: 0x000F2B30
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000F4970 File Offset: 0x000F2B70
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384044, XrefRangeEnd = 1384048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x000F49A8 File Offset: 0x000F2BA8
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x000F49E0 File Offset: 0x000F2BE0
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384048, XrefRangeEnd = 1384052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x000F4A24 File Offset: 0x000F2C24
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x000F4A5C File Offset: 0x000F2C5C
		public unsafe virtual string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x000F4AA0 File Offset: 0x000F2CA0
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000F4AEC File Offset: 0x000F2CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384052, XrefRangeEnd = 1384099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodResponse.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000F4B50 File Offset: 0x000F2D50
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x000F4B90 File Offset: 0x000F2D90
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000102DB File Offset: 0x0000E4DB
		public MethodResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x000F4BD4 File Offset: 0x000F2DD4
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x000102E4 File Offset: 0x0000E4E4
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x000F4BFC File Offset: 0x000F2DFC
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x00010303 File Offset: 0x0000E503
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x000F4C24 File Offset: 0x000F2E24
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00010322 File Offset: 0x0000E522
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x000F4C4C File Offset: 0x000F2E4C
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x00010341 File Offset: 0x0000E541
		public unsafe MethodBase _methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x000F4C7C File Offset: 0x000F2E7C
		// (set) Token: 0x06002FAD RID: 12205 RVA: 0x00010360 File Offset: 0x0000E560
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000F4CAC File Offset: 0x000F2EAC
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x0001037F File Offset: 0x0000E57F
		public unsafe Exception _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000F4CDC File Offset: 0x000F2EDC
		// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x0001039E File Offset: 0x0000E59E
		public unsafe Il2CppReferenceArray<Type> _methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000F4D0C File Offset: 0x000F2F0C
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x000103BD File Offset: 0x0000E5BD
		public unsafe ArgInfo _inArgInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__inArgInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__inArgInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000F4D3C File Offset: 0x000F2F3C
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x000103DC File Offset: 0x0000E5DC
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002FB6 RID: 12214 RVA: 0x000F4D6C File Offset: 0x000F2F6C
		// (set) Token: 0x06002FB7 RID: 12215 RVA: 0x000103FB File Offset: 0x0000E5FB
		public unsafe Il2CppReferenceArray<Object> _outArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__outArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__outArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x000F4D9C File Offset: 0x000F2F9C
		// (set) Token: 0x06002FB9 RID: 12217 RVA: 0x0001041A File Offset: 0x0000E61A
		public unsafe IMethodCallMessage _callMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMethodCallMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000F4DCC File Offset: 0x000F2FCC
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x00010439 File Offset: 0x0000E639
		public unsafe LogicalCallContext _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x000F4DFC File Offset: 0x000F2FFC
		// (set) Token: 0x06002FBD RID: 12221 RVA: 0x00010458 File Offset: 0x0000E658
		public unsafe Identity _targetIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__targetIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__targetIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000F4E2C File Offset: 0x000F302C
		// (set) Token: 0x06002FBF RID: 12223 RVA: 0x00010477 File Offset: 0x0000E677
		public unsafe IDictionary ExternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_ExternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_ExternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x000F4E5C File Offset: 0x000F305C
		// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x00010496 File Offset: 0x0000E696
		public unsafe IDictionary InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeFieldInfoPtr__methodBase;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeFieldInfoPtr__methodSignature;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeFieldInfoPtr__inArgInfo;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeFieldInfoPtr__outArgs;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeFieldInfoPtr__callMsg;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeFieldInfoPtr__targetIdentity;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeFieldInfoPtr_ExternalProperties;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;
	}
}

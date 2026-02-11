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
	// Token: 0x02000301 RID: 769
	[Serializable]
	public class MethodCall : Object
	{
		// Token: 0x06002F2F RID: 12079 RVA: 0x000F2A7C File Offset: 0x000F0C7C
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCall()
		{
			Il2CppClassPointerStore<MethodCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodCall>.NativeClassPtr);
			MethodCall.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_uri");
			MethodCall.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_typeName");
			MethodCall.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodName");
			MethodCall.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_args");
			MethodCall.NativeFieldInfoPtr__methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodSignature");
			MethodCall.NativeFieldInfoPtr__methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodBase");
			MethodCall.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_callContext");
			MethodCall.NativeFieldInfoPtr__targetIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_targetIdentity");
			MethodCall.NativeFieldInfoPtr__genericArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_genericArguments");
			MethodCall.NativeFieldInfoPtr_ExternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "ExternalProperties");
			MethodCall.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "InternalProperties");
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670784);
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670785);
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670786);
			MethodCall.NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670787);
			MethodCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670788);
			MethodCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670789);
			MethodCall.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670790);
			MethodCall.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670791);
			MethodCall.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670792);
			MethodCall.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670793);
			MethodCall.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670794);
			MethodCall.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670795);
			MethodCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670796);
			MethodCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670797);
			MethodCall.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670798);
			MethodCall.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670799);
			MethodCall.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670800);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670801);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670802);
			MethodCall.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670803);
			MethodCall.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670804);
			MethodCall.NativeMethodInfoPtr_ResolveMethod_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670805);
			MethodCall.NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670806);
			MethodCall.NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670807);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670808);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670809);
			MethodCall.NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100670810);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000F2DA4 File Offset: 0x000F0FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000F2E08 File Offset: 0x000F1008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383354, RefRangeEnd = 1383355, XrefRangeStart = 1383315, XrefRangeEnd = 1383354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall(CADMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000F2E54 File Offset: 0x000F1054
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000F2E90 File Offset: 0x000F1090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383386, RefRangeEnd = 1383387, XrefRangeStart = 1383355, XrefRangeEnd = 1383386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(IMethodMessage call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000F2ED4 File Offset: 0x000F10D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383450, RefRangeEnd = 1383451, XrefRangeStart = 1383387, XrefRangeEnd = 1383450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitMethodProperty(string key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000F2F34 File Offset: 0x000F1134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383495, RefRangeEnd = 1383496, XrefRangeStart = 1383451, XrefRangeEnd = 1383495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000F2F98 File Offset: 0x000F1198
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000F2FD4 File Offset: 0x000F11D4
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x000F3014 File Offset: 0x000F1214
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383496, XrefRangeEnd = 1383501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x000F3054 File Offset: 0x000F1254
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1383503, RefRangeEnd = 1383504, XrefRangeStart = 1383501, XrefRangeEnd = 1383503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x000F3094 File Offset: 0x000F1294
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383504, XrefRangeEnd = 1383505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000F30CC File Offset: 0x000F12CC
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383505, XrefRangeEnd = 1383513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000F310C File Offset: 0x000F130C
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000F3158 File Offset: 0x000F1358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383513, XrefRangeEnd = 1383521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002F3E RID: 12094 RVA: 0x000F3194 File Offset: 0x000F1394
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383521, XrefRangeEnd = 1383522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000F31CC File Offset: 0x000F13CC
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x000F3204 File Offset: 0x000F1404
		public unsafe virtual string Uri
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000F3248 File Offset: 0x000F1448
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x000F3280 File Offset: 0x000F1480
		public unsafe virtual string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000F32C4 File Offset: 0x000F14C4
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000F3310 File Offset: 0x000F1510
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000F334C File Offset: 0x000F154C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383559, RefRangeEnd = 1383560, XrefRangeStart = 1383522, XrefRangeEnd = 1383559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_ResolveMethod_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000F3380 File Offset: 0x000F1580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383573, RefRangeEnd = 1383574, XrefRangeStart = 1383560, XrefRangeEnd = 1383573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type CastTo(string clientType, Type serverType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clientType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000F33E4 File Offset: 0x000F15E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383574, XrefRangeEnd = 1383580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aqname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x000F3420 File Offset: 0x000F1620
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x000F3460 File Offset: 0x000F1660
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000F34A4 File Offset: 0x000F16A4
		public unsafe Il2CppReferenceArray<Type> GenericArguments
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1383582, RefRangeEnd = 1383584, XrefRangeStart = 1383580, XrefRangeEnd = 1383582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000100E1 File Offset: 0x0000E2E1
		public MethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000F34E4 File Offset: 0x000F16E4
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x000100EA File Offset: 0x0000E2EA
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x000F350C File Offset: 0x000F170C
		// (set) Token: 0x06002F4F RID: 12111 RVA: 0x00010109 File Offset: 0x0000E309
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x000F3534 File Offset: 0x000F1734
		// (set) Token: 0x06002F51 RID: 12113 RVA: 0x00010128 File Offset: 0x0000E328
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x000F355C File Offset: 0x000F175C
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x00010147 File Offset: 0x0000E347
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000F358C File Offset: 0x000F178C
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x00010166 File Offset: 0x0000E366
		public unsafe Il2CppReferenceArray<Type> _methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000F35BC File Offset: 0x000F17BC
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00010185 File Offset: 0x0000E385
		public unsafe MethodBase _methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000F35EC File Offset: 0x000F17EC
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x000101A4 File Offset: 0x0000E3A4
		public unsafe LogicalCallContext _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x000F361C File Offset: 0x000F181C
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x000101C3 File Offset: 0x0000E3C3
		public unsafe Identity _targetIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__targetIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__targetIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000F364C File Offset: 0x000F184C
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x000101E2 File Offset: 0x0000E3E2
		public unsafe Il2CppReferenceArray<Type> _genericArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__genericArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__genericArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000F367C File Offset: 0x000F187C
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x00010201 File Offset: 0x0000E401
		public unsafe IDictionary ExternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_ExternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_ExternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000F36AC File Offset: 0x000F18AC
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x00010220 File Offset: 0x0000E420
		public unsafe IDictionary InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeFieldInfoPtr__methodSignature;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeFieldInfoPtr__methodBase;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeFieldInfoPtr__targetIdentity;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeFieldInfoPtr__genericArguments;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeFieldInfoPtr_ExternalProperties;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_ResolveMethod_Public_Void_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0;
	}
}

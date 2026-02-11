using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000306 RID: 774
	[Serializable]
	public class MonoMethodMessage : Object
	{
		// Token: 0x06002FC9 RID: 12233 RVA: 0x000F4F94 File Offset: 0x000F3194
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodMessage()
		{
			Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MonoMethodMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr);
			MonoMethodMessage.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "method");
			MonoMethodMessage.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "args");
			MonoMethodMessage.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "names");
			MonoMethodMessage.NativeFieldInfoPtr_arg_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "arg_types");
			MonoMethodMessage.NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "ctx");
			MonoMethodMessage.NativeFieldInfoPtr_rval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "rval");
			MonoMethodMessage.NativeFieldInfoPtr_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "exc");
			MonoMethodMessage.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "asyncResult");
			MonoMethodMessage.NativeFieldInfoPtr_call_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "call_type");
			MonoMethodMessage.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "uri");
			MonoMethodMessage.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "properties");
			MonoMethodMessage.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "identity");
			MonoMethodMessage.NativeFieldInfoPtr_methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "methodSignature");
			MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_RuntimeMethodInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670871);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670872);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670873);
			MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670874);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670875);
			MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670876);
			MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670877);
			MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670878);
			MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670879);
			MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670880);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670881);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670882);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670883);
			MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670884);
			MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670885);
			MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670886);
			MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670887);
			MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670888);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670889);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670890);
			MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670891);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670892);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670893);
			MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670894);
			MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670895);
			MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100670896);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x000F52D0 File Offset: 0x000F34D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1384136, RefRangeEnd = 1384139, XrefRangeStart = 1384116, XrefRangeEnd = 1384136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMessage(RuntimeMethodInfo method, Il2CppReferenceArray<Object> out_args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_RuntimeMethodInfo_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000F5324 File Offset: 0x000F3524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384139, XrefRangeEnd = 1384146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodBase method, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000F5384 File Offset: 0x000F3584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1384153, RefRangeEnd = 1384155, XrefRangeStart = 1384146, XrefRangeEnd = 1384153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodInfo minfo, Il2CppReferenceArray<Object> in_args, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(minfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000F53F4 File Offset: 0x000F35F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384155, XrefRangeEnd = 1384157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetMethodInfo(Type type, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x000F544C File Offset: 0x000F364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384157, XrefRangeEnd = 1384166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(Type type, string methodName, Il2CppReferenceArray<Object> in_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000F54BC File Offset: 0x000F36BC
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384166, XrefRangeEnd = 1384171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000F54FC File Offset: 0x000F36FC
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384171, XrefRangeEnd = 1384175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x000F5538 File Offset: 0x000F3738
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x000F5578 File Offset: 0x000F3778
		// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x000F55B8 File Offset: 0x000F37B8
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x000F55FC File Offset: 0x000F37FC
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x000F563C File Offset: 0x000F383C
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384175, XrefRangeEnd = 1384178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x000F5674 File Offset: 0x000F3874
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384178, XrefRangeEnd = 1384185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x000F56B4 File Offset: 0x000F38B4
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384185, XrefRangeEnd = 1384188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x000F56EC File Offset: 0x000F38EC
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x000F5724 File Offset: 0x000F3924
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x000F5768 File Offset: 0x000F3968
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int arg_num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg_num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x000F57B4 File Offset: 0x000F39B4
		public unsafe virtual Exception Exception
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000F57F4 File Offset: 0x000F39F4
		public unsafe virtual int OutArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384188, XrefRangeEnd = 1384189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x000F5830 File Offset: 0x000F3A30
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384189, XrefRangeEnd = 1384196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000F5870 File Offset: 0x000F3A70
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x000F58B0 File Offset: 0x000F3AB0
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x000F58F0 File Offset: 0x000F3AF0
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000F5934 File Offset: 0x000F3B34
		public unsafe AsyncResult AsyncResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr3) : null;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x000F5974 File Offset: 0x000F3B74
		public unsafe CallType CallType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1384200, RefRangeEnd = 1384204, XrefRangeStart = 1384196, XrefRangeEnd = 1384200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000F59B0 File Offset: 0x000F3BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384206, RefRangeEnd = 1384207, XrefRangeStart = 1384204, XrefRangeEnd = 1384206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsOutProcessing(out int outCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000104E2 File Offset: 0x0000E6E2
		public MonoMethodMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x000F59FC File Offset: 0x000F3BFC
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x000104EB File Offset: 0x0000E6EB
		public unsafe RuntimeMethodInfo method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeMethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x000F5A2C File Offset: 0x000F3C2C
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x0001050A File Offset: 0x0000E70A
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x000F5A5C File Offset: 0x000F3C5C
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x00010529 File Offset: 0x0000E729
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000F5A8C File Offset: 0x000F3C8C
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x00010548 File Offset: 0x0000E748
		public unsafe Il2CppStructArray<byte> arg_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000F5ABC File Offset: 0x000F3CBC
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x00010567 File Offset: 0x0000E767
		public unsafe LogicalCallContext ctx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x000F5AEC File Offset: 0x000F3CEC
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x00010586 File Offset: 0x0000E786
		public unsafe Object rval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x000F5B1C File Offset: 0x000F3D1C
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x000105A5 File Offset: 0x0000E7A5
		public unsafe Exception exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x000F5B4C File Offset: 0x000F3D4C
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x000105C4 File Offset: 0x0000E7C4
		public unsafe AsyncResult asyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x000F5B7C File Offset: 0x000F3D7C
		// (set) Token: 0x06002FF6 RID: 12278 RVA: 0x000105E3 File Offset: 0x0000E7E3
		public unsafe CallType call_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type)) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x000F5BA4 File Offset: 0x000F3DA4
		// (set) Token: 0x06002FF8 RID: 12280 RVA: 0x000105FE File Offset: 0x0000E7FE
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002FF9 RID: 12281 RVA: 0x000F5BCC File Offset: 0x000F3DCC
		// (set) Token: 0x06002FFA RID: 12282 RVA: 0x0001061D File Offset: 0x0000E81D
		public unsafe MCMDictionary properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MCMDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x000F5BFC File Offset: 0x000F3DFC
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x0001063C File Offset: 0x0000E83C
		public unsafe Identity identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x000F5C2C File Offset: 0x000F3E2C
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x0001065B File Offset: 0x0000E85B
		public unsafe Il2CppReferenceArray<Type> methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeFieldInfoPtr_arg_types;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeFieldInfoPtr_ctx;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeFieldInfoPtr_rval;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeFieldInfoPtr_exc;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeFieldInfoPtr_call_type;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeFieldInfoPtr_methodSignature;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeMethodInfoPtr_InitMessage_Internal_Void_RuntimeMethodInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000133 RID: 307
	[Serializable]
	public class Exception : Object
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x000898F8 File Offset: 0x00087AF8
		// Note: this type is marked as 'beforefieldinit'.
		static Exception()
		{
			Il2CppClassPointerStore<Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Exception>.NativeClassPtr);
			Exception.NativeFieldInfoPtr_s_EDILock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "s_EDILock");
			Exception.NativeFieldInfoPtr__className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_className");
			Exception.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_message");
			Exception.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_data");
			Exception.NativeFieldInfoPtr__innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_innerException");
			Exception.NativeFieldInfoPtr__helpURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_helpURL");
			Exception.NativeFieldInfoPtr__stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTrace");
			Exception.NativeFieldInfoPtr__stackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackIndex");
			Exception.NativeFieldInfoPtr__dynamicMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_dynamicMethods");
			Exception.NativeFieldInfoPtr__HResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_HResult");
			Exception.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_source");
			Exception.NativeFieldInfoPtr__safeSerializationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_safeSerializationManager");
			Exception.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "captured_traces");
			Exception.NativeFieldInfoPtr_native_trace_ips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "native_trace_ips");
			Exception.NativeFieldInfoPtr_caught_in_unmanaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "caught_in_unmanaged");
			Exception.NativeFieldInfoPtr__COMPlusExceptionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_COMPlusExceptionCode");
			Exception.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666965);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666966);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666967);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666968);
			Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666969);
			Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666970);
			Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666971);
			Exception.NativeMethodInfoPtr_GetClassName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666972);
			Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666973);
			Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666974);
			Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666975);
			Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666976);
			Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666977);
			Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666978);
			Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666979);
			Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666980);
			Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666981);
			Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666982);
			Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666983);
			Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666984);
			Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666985);
			Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666986);
			Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666987);
			Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666988);
			Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100666989);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00089C84 File Offset: 0x00087E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1341081, RefRangeEnd = 1341084, XrefRangeStart = 1341073, XrefRangeEnd = 1341081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00089CB8 File Offset: 0x00087EB8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1341086, RefRangeEnd = 1341118, XrefRangeStart = 1341084, XrefRangeEnd = 1341086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00089CF4 File Offset: 0x00087EF4
		[CallerCount(159)]
		[CachedScanResults(RefRangeStart = 1341121, RefRangeEnd = 1341280, XrefRangeStart = 1341118, XrefRangeEnd = 1341121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00089D40 File Offset: 0x00087F40
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 1341284, RefRangeEnd = 1341343, XrefRangeStart = 1341280, XrefRangeEnd = 1341284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00089DA0 File Offset: 0x00087FA0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1341415, RefRangeEnd = 1341442, XrefRangeStart = 1341343, XrefRangeEnd = 1341415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00089E04 File Offset: 0x00088004
		public unsafe virtual string Message
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 1341444, RefRangeEnd = 1341474, XrefRangeStart = 1341442, XrefRangeEnd = 1341444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00089E48 File Offset: 0x00088048
		public unsafe virtual IDictionary Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341474, XrefRangeEnd = 1341479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00089E94 File Offset: 0x00088094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341479, XrefRangeEnd = 1341481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetClassName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x00089ECC File Offset: 0x000880CC
		public unsafe virtual Exception InnerException
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00089F0C File Offset: 0x0008810C
		public unsafe virtual string StackTrace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1341483, RefRangeEnd = 1341484, XrefRangeStart = 1341481, XrefRangeEnd = 1341483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00089F50 File Offset: 0x00088150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341484, XrefRangeEnd = 1341486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStackTrace(bool needFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00089F94 File Offset: 0x00088194
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetErrorCode(int hr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00089FD4 File Offset: 0x000881D4
		public unsafe virtual string Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341486, XrefRangeEnd = 1341492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0008A018 File Offset: 0x00088218
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1341501, RefRangeEnd = 1341505, XrefRangeStart = 1341492, XrefRangeEnd = 1341501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0008A05C File Offset: 0x0008825C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1341536, RefRangeEnd = 1341538, XrefRangeStart = 1341505, XrefRangeEnd = 1341536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(bool needFileLineInfo, bool needMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileLineInfo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needMessage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0008A0B0 File Offset: 0x000882B0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1341613, RefRangeEnd = 1341638, XrefRangeStart = 1341538, XrefRangeEnd = 1341613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0008A114 File Offset: 0x00088314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341638, XrefRangeEnd = 1341645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0008A15C File Offset: 0x0008835C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRemoteStackTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0008A1B4 File Offset: 0x000883B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341657, RefRangeEnd = 1341658, XrefRangeStart = 1341645, XrefRangeEnd = 1341657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionDispatchInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0008A1F8 File Offset: 0x000883F8
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0008A234 File Offset: 0x00088434
		public unsafe int HResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0008A274 File Offset: 0x00088474
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1322242, RefRangeEnd = 1322256, XrefRangeStart = 1322242, XrefRangeEnd = 1322256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0008A2B4 File Offset: 0x000884B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1341663, RefRangeEnd = 1341665, XrefRangeStart = 1341658, XrefRangeEnd = 1341663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0008A2EC File Offset: 0x000884EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341676, RefRangeEnd = 1341677, XrefRangeStart = 1341665, XrefRangeEnd = 1341676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception FixRemotingException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0008A32C File Offset: 0x0008852C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341678, RefRangeEnd = 1341679, XrefRangeStart = 1341677, XrefRangeEnd = 1341678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportUnhandledException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000066EE File Offset: 0x000048EE
		public Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0008A364 File Offset: 0x00088564
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x000066F7 File Offset: 0x000048F7
		public unsafe static Object s_EDILock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr_s_EDILock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr_s_EDILock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0008A38C File Offset: 0x0008858C
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00006709 File Offset: 0x00004909
		public unsafe string _className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0008A3B4 File Offset: 0x000885B4
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00006728 File Offset: 0x00004928
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0008A3DC File Offset: 0x000885DC
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x00006747 File Offset: 0x00004947
		public unsafe IDictionary _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0008A40C File Offset: 0x0008860C
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00006766 File Offset: 0x00004966
		public unsafe Exception _innerException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0008A43C File Offset: 0x0008863C
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00006785 File Offset: 0x00004985
		public unsafe string _helpURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0008A464 File Offset: 0x00088664
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x000067A4 File Offset: 0x000049A4
		public unsafe Object _stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0008A494 File Offset: 0x00088694
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x000067C3 File Offset: 0x000049C3
		public unsafe string _stackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0008A4BC File Offset: 0x000886BC
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x000067E2 File Offset: 0x000049E2
		public unsafe string _remoteStackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0008A4E4 File Offset: 0x000886E4
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00006801 File Offset: 0x00004A01
		public unsafe int _remoteStackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0008A50C File Offset: 0x0008870C
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0000681C File Offset: 0x00004A1C
		public unsafe Object _dynamicMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0008A53C File Offset: 0x0008873C
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x0000683B File Offset: 0x00004A3B
		public unsafe int _HResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0008A564 File Offset: 0x00088764
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x00006856 File Offset: 0x00004A56
		public unsafe string _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0008A58C File Offset: 0x0008878C
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x00006875 File Offset: 0x00004A75
		public unsafe SafeSerializationManager _safeSerializationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSerializationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0008A5BC File Offset: 0x000887BC
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00006894 File Offset: 0x00004A94
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0008A5EC File Offset: 0x000887EC
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x000068B3 File Offset: 0x00004AB3
		public unsafe Il2CppStructArray<IntPtr> native_trace_ips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0008A61C File Offset: 0x0008881C
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x000068D2 File Offset: 0x00004AD2
		public unsafe int caught_in_unmanaged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_caught_in_unmanaged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_caught_in_unmanaged)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0008A644 File Offset: 0x00088844
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x000068ED File Offset: 0x00004AED
		public unsafe static int _COMPlusExceptionCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&value));
			}
		}

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_s_EDILock;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr__className;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr__innerException;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr__helpURL;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr__stackTrace;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr__stackTraceString;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackTraceString;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackIndex;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr__dynamicMethods;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr__HResult;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr__safeSerializationManager;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_native_trace_ips;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_caught_in_unmanaged;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr__COMPlusExceptionCode;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Private_String_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_get_HResult_Public_get_Int32_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0;

		// Token: 0x020005EE RID: 1518
		public enum ExceptionMessageKind
		{
			// Token: 0x040047D4 RID: 18388
			ThreadAbort = 1,
			// Token: 0x040047D5 RID: 18389
			ThreadInterrupted,
			// Token: 0x040047D6 RID: 18390
			OutOfMemory
		}
	}
}

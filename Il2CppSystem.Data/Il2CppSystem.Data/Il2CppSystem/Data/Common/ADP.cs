using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000A5 RID: 165
	public static class ADP : Object
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x00050D94 File Offset: 0x0004EF94
		// Note: this type is marked as 'beforefieldinit'.
		static ADP()
		{
			Il2CppClassPointerStore<ADP>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "ADP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ADP>.NativeClassPtr);
			ADP.NativeFieldInfoPtr_s_stackOverflowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_stackOverflowType");
			ADP.NativeFieldInfoPtr_s_outOfMemoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_outOfMemoryType");
			ADP.NativeFieldInfoPtr_s_threadAbortType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_threadAbortType");
			ADP.NativeFieldInfoPtr_s_nullReferenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_nullReferenceType");
			ADP.NativeFieldInfoPtr_s_accessViolationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_accessViolationType");
			ADP.NativeFieldInfoPtr_s_securityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "s_securityType");
			ADP.NativeFieldInfoPtr_StrEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "StrEmpty");
			ADP.NativeFieldInfoPtr_AzureSqlServerEndpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "AzureSqlServerEndpoints");
			ADP.NativeFieldInfoPtr_PtrZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "PtrZero");
			ADP.NativeFieldInfoPtr_PtrSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ADP>.NativeClassPtr, "PtrSize");
			ADP.NativeMethodInfoPtr_TraceException_Private_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666033);
			ADP.NativeMethodInfoPtr_TraceExceptionAsReturnValue_Internal_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666034);
			ADP.NativeMethodInfoPtr_TraceExceptionWithoutRethrow_Internal_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666035);
			ADP.NativeMethodInfoPtr_Argument_Internal_Static_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666036);
			ADP.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666037);
			ADP.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666038);
			ADP.NativeMethodInfoPtr_InvalidOperation_Internal_Static_InvalidOperationException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666039);
			ADP.NativeMethodInfoPtr_NotSupported_Internal_Static_NotSupportedException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666040);
			ADP.NativeMethodInfoPtr_IsCatchableExceptionType_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666041);
			ADP.NativeMethodInfoPtr_IsCatchableOrSecurityExceptionType_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666042);
			ADP.NativeMethodInfoPtr_InvalidEnumerationValue_Internal_Static_ArgumentOutOfRangeException_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666043);
			ADP.NativeMethodInfoPtr_InvalidSeekOrigin_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666044);
			ADP.NativeMethodInfoPtr_InvalidAcceptRejectRule_Internal_Static_ArgumentOutOfRangeException_AcceptRejectRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666045);
			ADP.NativeMethodInfoPtr_InvalidMissingSchemaAction_Internal_Static_ArgumentOutOfRangeException_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666046);
			ADP.NativeMethodInfoPtr_InvalidRule_Internal_Static_ArgumentOutOfRangeException_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666047);
			ADP.NativeMethodInfoPtr_WrongType_Internal_Static_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ADP>.NativeClassPtr, 100666048);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00050FCC File Offset: 0x0004F1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921049, XrefRangeEnd = 921056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceException(string trace, Exception e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_TraceException_Private_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00051014 File Offset: 0x0004F214
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 921068, RefRangeEnd = 921074, XrefRangeStart = 921056, XrefRangeEnd = 921068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceExceptionAsReturnValue(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_TraceExceptionAsReturnValue_Internal_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0005104C File Offset: 0x0004F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921074, XrefRangeEnd = 921086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceExceptionWithoutRethrow(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_TraceExceptionWithoutRethrow_Internal_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00051084 File Offset: 0x0004F284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921086, XrefRangeEnd = 921094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException Argument(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_Argument_Internal_Static_ArgumentException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000510C8 File Offset: 0x0004F2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921094, XrefRangeEnd = 921102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parameterName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005110C File Offset: 0x0004F30C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 921110, RefRangeEnd = 921112, XrefRangeStart = 921102, XrefRangeEnd = 921110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00051164 File Offset: 0x0004F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921112, XrefRangeEnd = 921120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidOperationException InvalidOperation(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidOperation_Internal_Static_InvalidOperationException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr3) : null;
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x000511A8 File Offset: 0x0004F3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 921128, RefRangeEnd = 921129, XrefRangeStart = 921120, XrefRangeEnd = 921128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NotSupportedException NotSupported(string error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_NotSupported_Internal_Static_NotSupportedException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x000511EC File Offset: 0x0004F3EC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 921165, RefRangeEnd = 921179, XrefRangeStart = 921129, XrefRangeEnd = 921165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCatchableExceptionType(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_IsCatchableExceptionType_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00051230 File Offset: 0x0004F430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 921212, RefRangeEnd = 921214, XrefRangeStart = 921179, XrefRangeEnd = 921212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCatchableOrSecurityExceptionType(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_IsCatchableOrSecurityExceptionType_Internal_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00051274 File Offset: 0x0004F474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 921226, RefRangeEnd = 921229, XrefRangeStart = 921214, XrefRangeEnd = 921226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidEnumerationValue_Internal_Static_ArgumentOutOfRangeException_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000512C8 File Offset: 0x0004F4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921229, XrefRangeEnd = 921235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidSeekOrigin(string parameterName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parameterName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidSeekOrigin_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005130C File Offset: 0x0004F50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921235, XrefRangeEnd = 921245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidAcceptRejectRule_Internal_Static_ArgumentOutOfRangeException_AcceptRejectRule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0005134C File Offset: 0x0004F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921245, XrefRangeEnd = 921255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidMissingSchemaAction_Internal_Static_ArgumentOutOfRangeException_MissingSchemaAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005138C File Offset: 0x0004F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921255, XrefRangeEnd = 921265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException InvalidRule(Rule value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_InvalidRule_Internal_Static_ArgumentOutOfRangeException_Rule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x000513CC File Offset: 0x0004F5CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 921279, RefRangeEnd = 921286, XrefRangeStart = 921265, XrefRangeEnd = 921279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception WrongType(Type got, Type expected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(got);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ADP.NativeMethodInfoPtr_WrongType_Internal_Static_Exception_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000070C8 File Offset: 0x000052C8
		public ADP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00051424 File Offset: 0x0004F624
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x000070D1 File Offset: 0x000052D1
		public unsafe static Type s_stackOverflowType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_stackOverflowType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_stackOverflowType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0005144C File Offset: 0x0004F64C
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x000070E3 File Offset: 0x000052E3
		public unsafe static Type s_outOfMemoryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_outOfMemoryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_outOfMemoryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00051474 File Offset: 0x0004F674
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x000070F5 File Offset: 0x000052F5
		public unsafe static Type s_threadAbortType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_threadAbortType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_threadAbortType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0005149C File Offset: 0x0004F69C
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x00007107 File Offset: 0x00005307
		public unsafe static Type s_nullReferenceType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_nullReferenceType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_nullReferenceType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x000514C4 File Offset: 0x0004F6C4
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x00007119 File Offset: 0x00005319
		public unsafe static Type s_accessViolationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_accessViolationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_accessViolationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000514EC File Offset: 0x0004F6EC
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x0000712B File Offset: 0x0000532B
		public unsafe static Type s_securityType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_s_securityType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_s_securityType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00051514 File Offset: 0x0004F714
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x0000713D File Offset: 0x0000533D
		public unsafe static string StrEmpty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_StrEmpty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_StrEmpty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00051534 File Offset: 0x0004F734
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0000714F File Offset: 0x0000534F
		public unsafe static Il2CppStringArray AzureSqlServerEndpoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_AzureSqlServerEndpoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_AzureSqlServerEndpoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0005155C File Offset: 0x0004F75C
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x00007161 File Offset: 0x00005361
		public unsafe static IntPtr PtrZero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_PtrZero, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_PtrZero, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00051578 File Offset: 0x0004F778
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x0000716F File Offset: 0x0000536F
		public unsafe static int PtrSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ADP.NativeFieldInfoPtr_PtrSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ADP.NativeFieldInfoPtr_PtrSize, (void*)(&value));
			}
		}

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr_s_stackOverflowType;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr_s_outOfMemoryType;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_s_threadAbortType;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_s_nullReferenceType;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr_s_accessViolationType;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr_s_securityType;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_StrEmpty;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr_AzureSqlServerEndpoints;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr_PtrZero;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr_PtrSize;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_TraceException_Private_Static_Void_String_Exception_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_TraceExceptionAsReturnValue_Internal_Static_Void_Exception_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_TraceExceptionWithoutRethrow_Internal_Static_Void_Exception_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_Argument_Internal_Static_ArgumentException_String_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_ArgumentOutOfRangeException_String_String_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_InvalidOperation_Internal_Static_InvalidOperationException_String_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_NotSupported_Internal_Static_NotSupportedException_String_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_IsCatchableExceptionType_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_IsCatchableOrSecurityExceptionType_Internal_Static_Boolean_Exception_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_InvalidEnumerationValue_Internal_Static_ArgumentOutOfRangeException_Type_Int32_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_InvalidSeekOrigin_Internal_Static_Exception_String_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_InvalidAcceptRejectRule_Internal_Static_ArgumentOutOfRangeException_AcceptRejectRule_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_InvalidMissingSchemaAction_Internal_Static_ArgumentOutOfRangeException_MissingSchemaAction_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_InvalidRule_Internal_Static_ArgumentOutOfRangeException_Rule_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_WrongType_Internal_Static_Exception_Type_Type_0;
	}
}

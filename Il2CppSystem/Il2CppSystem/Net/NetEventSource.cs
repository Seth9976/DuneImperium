using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Net
{
	// Token: 0x02000190 RID: 400
	public sealed class NetEventSource : EventSource
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x0007BB14 File Offset: 0x00079D14
		// Note: this type is marked as 'beforefieldinit'.
		static NetEventSource()
		{
			Il2CppClassPointerStore<NetEventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetEventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr);
			NetEventSource.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, "Log");
			NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667142);
			NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667143);
			NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667144);
			NetEventSource.NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667145);
			NetEventSource.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667146);
			NetEventSource.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667147);
			NetEventSource.NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667148);
			NetEventSource.NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667149);
			NetEventSource.NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667150);
			NetEventSource.NativeMethodInfoPtr_Info_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667151);
			NetEventSource.NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667152);
			NetEventSource.NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667153);
			NetEventSource.NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667154);
			NetEventSource.NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667155);
			NetEventSource.NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667156);
			NetEventSource.NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667157);
			NetEventSource.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667158);
			NetEventSource.NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667159);
			NetEventSource.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667160);
			NetEventSource.NativeMethodInfoPtr_Format_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667161);
			NetEventSource.NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667162);
			NetEventSource.NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667163);
			NetEventSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100667164);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0007BD24 File Offset: 0x00079F24
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 470870, RefRangeEnd = 470878, XrefRangeStart = 470849, XrefRangeEnd = 470870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattableString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0007BD80 File Offset: 0x00079F80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 470897, RefRangeEnd = 470900, XrefRangeStart = 470878, XrefRangeEnd = 470897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object thisOrContextObject, Object arg0, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0007BDDC File Offset: 0x00079FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470921, RefRangeEnd = 470922, XrefRangeStart = 470900, XrefRangeEnd = 470921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enter(Object thisOrContextObject, Object arg0, Object arg1, Object arg2, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0007BE5C File Offset: 0x0007A05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470922, XrefRangeEnd = 470925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter(string thisOrContextObject, string memberName, string parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0007BEC4 File Offset: 0x0007A0C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 470946, RefRangeEnd = 470948, XrefRangeStart = 470925, XrefRangeEnd = 470946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattableString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0007BF20 File Offset: 0x0007A120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470948, XrefRangeEnd = 470964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(Object thisOrContextObject, Object arg0, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0007BF7C File Offset: 0x0007A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470964, XrefRangeEnd = 470967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(string thisOrContextObject, string memberName, string result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0007BFE4 File Offset: 0x0007A1E4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 470988, RefRangeEnd = 471009, XrefRangeStart = 470967, XrefRangeEnd = 470988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Info(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattableString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0007C040 File Offset: 0x0007A240
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 471025, RefRangeEnd = 471035, XrefRangeStart = 471009, XrefRangeEnd = 471025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Info(Object thisOrContextObject, Object message, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0007C09C File Offset: 0x0007A29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471035, XrefRangeEnd = 471038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Info(string thisOrContextObject, string memberName, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Info_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0007C104 File Offset: 0x0007A304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471038, XrefRangeEnd = 471054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Error(Object thisOrContextObject, Object message, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0007C160 File Offset: 0x0007A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471054, XrefRangeEnd = 471057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ErrorMessage(string thisOrContextObject, string memberName, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0007C1C8 File Offset: 0x0007A3C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 471073, RefRangeEnd = 471079, XrefRangeStart = 471057, XrefRangeEnd = 471073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fail(Object thisOrContextObject, Object message, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0007C224 File Offset: 0x0007A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471079, XrefRangeEnd = 471082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CriticalFailure(string thisOrContextObject, string memberName, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0007C28C File Offset: 0x0007A48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471082, XrefRangeEnd = 471099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Associate(Object first, Object second, string memberName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0007C2E8 File Offset: 0x0007A4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471099, XrefRangeEnd = 471102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Associate(string thisOrContextObject, string memberName, string first, string second)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(first);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x0007C364 File Offset: 0x0007A564
		public new unsafe static bool IsEnabled
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 471108, RefRangeEnd = 471119, XrefRangeStart = 471102, XrefRangeEnd = 471108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0007C394 File Offset: 0x0007A594
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 471128, RefRangeEnd = 471143, XrefRangeStart = 471119, XrefRangeEnd = 471128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdOf(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
		[CallerCount(0)]
		public unsafe static int GetHashCode(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0007C414 File Offset: 0x0007A614
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 471162, RefRangeEnd = 471171, XrefRangeStart = 471143, XrefRangeEnd = 471162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Format(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Format_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0007C458 File Offset: 0x0007A658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 471182, RefRangeEnd = 471185, XrefRangeStart = 471171, XrefRangeEnd = 471182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(FormattableString s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0007C494 File Offset: 0x0007A694
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 471198, RefRangeEnd = 471201, XrefRangeStart = 471185, XrefRangeEnd = 471198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0007C51C File Offset: 0x0007A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471201, XrefRangeEnd = 471202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetEventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetEventSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000A79C File Offset: 0x0000899C
		public NetEventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0007C558 File Offset: 0x0007A758
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000A7A5 File Offset: 0x000089A5
		public unsafe static NetEventSource Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NetEventSource.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetEventSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NetEventSource.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_Info_Private_Void_String_String_String_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_Object_Object_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000311 RID: 785
		public class Keywords : Object
		{
			// Token: 0x06002E88 RID: 11912 RVA: 0x000CC0C4 File Offset: 0x000CA2C4
			// Note: this type is marked as 'beforefieldinit'.
			static Keywords()
			{
				Il2CppClassPointerStore<NetEventSource.Keywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, "Keywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetEventSource.Keywords>.NativeClassPtr);
				NetEventSource.Keywords.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetEventSource.Keywords>.NativeClassPtr, "Default");
				NetEventSource.Keywords.NativeFieldInfoPtr_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetEventSource.Keywords>.NativeClassPtr, "Debug");
				NetEventSource.Keywords.NativeFieldInfoPtr_EnterExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetEventSource.Keywords>.NativeClassPtr, "EnterExit");
			}

			// Token: 0x06002E89 RID: 11913 RVA: 0x00014C7D File Offset: 0x00012E7D
			public Keywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E93 RID: 3731
			// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000CC12C File Offset: 0x000CA32C
			// (set) Token: 0x06002E8B RID: 11915 RVA: 0x00014C86 File Offset: 0x00012E86
			public unsafe static EventKeywords Default
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(NetEventSource.Keywords.NativeFieldInfoPtr_Default, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetEventSource.Keywords.NativeFieldInfoPtr_Default, (void*)(&value));
				}
			}

			// Token: 0x17000E94 RID: 3732
			// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000CC148 File Offset: 0x000CA348
			// (set) Token: 0x06002E8D RID: 11917 RVA: 0x00014C94 File Offset: 0x00012E94
			public unsafe static EventKeywords Debug
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(NetEventSource.Keywords.NativeFieldInfoPtr_Debug, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetEventSource.Keywords.NativeFieldInfoPtr_Debug, (void*)(&value));
				}
			}

			// Token: 0x17000E95 RID: 3733
			// (get) Token: 0x06002E8E RID: 11918 RVA: 0x000CC164 File Offset: 0x000CA364
			// (set) Token: 0x06002E8F RID: 11919 RVA: 0x00014CA2 File Offset: 0x00012EA2
			public unsafe static EventKeywords EnterExit
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(NetEventSource.Keywords.NativeFieldInfoPtr_EnterExit, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetEventSource.Keywords.NativeFieldInfoPtr_EnterExit, (void*)(&value));
				}
			}

			// Token: 0x04002481 RID: 9345
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x04002482 RID: 9346
			private static readonly IntPtr NativeFieldInfoPtr_Debug;

			// Token: 0x04002483 RID: 9347
			private static readonly IntPtr NativeFieldInfoPtr_EnterExit;
		}
	}
}

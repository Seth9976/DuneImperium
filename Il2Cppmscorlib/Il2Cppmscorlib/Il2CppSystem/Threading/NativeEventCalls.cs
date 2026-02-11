using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BF RID: 447
	public static class NativeEventCalls : Object
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x000ABB1C File Offset: 0x000A9D1C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventCalls()
		{
			Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeEventCalls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr);
			NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668300);
			NativeEventCalls.NativeMethodInfoPtr_CreateEvent_icall_Private_Static_IntPtr_Boolean_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668301);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668302);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668303);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668304);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668305);
			NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100668306);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000ABBD8 File Offset: 0x000A9DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357332, RefRangeEnd = 1357335, XrefRangeStart = 1357329, XrefRangeEnd = 1357332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref manual;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000ABC44 File Offset: 0x000A9E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357335, XrefRangeEnd = 1357336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref manual;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name_length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CreateEvent_icall_Private_Static_IntPtr_Boolean_Boolean_ptr_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000ABCBC File Offset: 0x000A9EBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1357341, RefRangeEnd = 1357343, XrefRangeStart = 1357336, XrefRangeEnd = 1357341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000ABD00 File Offset: 0x000A9F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357343, XrefRangeEnd = 1357344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x000ABD40 File Offset: 0x000A9F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357349, RefRangeEnd = 1357350, XrefRangeStart = 1357344, XrefRangeEnd = 1357349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x000ABD84 File Offset: 0x000A9F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357350, XrefRangeEnd = 1357351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000ABDC4 File Offset: 0x000A9FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357352, RefRangeEnd = 1357353, XrefRangeStart = 1357351, XrefRangeEnd = 1357352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0000951E File Offset: 0x0000771E
		public NativeEventCalls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_icall_Private_Static_IntPtr_Boolean_Boolean_ptr_Char_Int32_byref_Int32_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0;
	}
}

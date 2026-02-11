using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BB RID: 443
	public class WaitHandle : MarshalByRefObject
	{
		// Token: 0x06001CC2 RID: 7362 RVA: 0x000AA3BC File Offset: 0x000A85BC
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandle()
		{
			Il2CppClassPointerStore<WaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr);
			WaitHandle.NativeFieldInfoPtr_WaitTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WaitTimeout");
			WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MAX_WAITHANDLES");
			WaitHandle.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "waitHandle");
			WaitHandle.NativeFieldInfoPtr_safeWaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "safeWaitHandle");
			WaitHandle.NativeFieldInfoPtr_hasThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "hasThreadAffinity");
			WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_OBJECT_0");
			WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_ABANDONED");
			WaitHandle.NativeFieldInfoPtr_WAIT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_FAILED");
			WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_TOO_MANY_POSTS");
			WaitHandle.NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_NOT_OWNED_BY_CALLER");
			WaitHandle.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "InvalidHandle");
			WaitHandle.NativeFieldInfoPtr_MaxWaitHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MaxWaitHandles");
			WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668252);
			WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668253);
			WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668254);
			WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668255);
			WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668256);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668257);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668258);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668259);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668260);
			WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668261);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668262);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668263);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668264);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668265);
			WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668266);
			WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668267);
			WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668268);
			WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668269);
			WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668270);
			WaitHandle.NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668271);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000AA66C File Offset: 0x000A886C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1356930, RefRangeEnd = 1356934, XrefRangeStart = 1356923, XrefRangeEnd = 1356930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000AA6A8 File Offset: 0x000A88A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356934, XrefRangeEnd = 1356940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700054F RID: 1359
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000AA6DC File Offset: 0x000A88DC
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356940, XrefRangeEnd = 1356951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000AA728 File Offset: 0x000A8928
		public unsafe SafeWaitHandle SafeWaitHandle
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1356963, RefRangeEnd = 1356968, XrefRangeStart = 1356951, XrefRangeEnd = 1356963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000AA768 File Offset: 0x000A8968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1356970, RefRangeEnd = 1356973, XrefRangeStart = 1356968, XrefRangeEnd = 1356970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleInternal(SafeWaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000AA7AC File Offset: 0x000A89AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356973, XrefRangeEnd = 1356981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000AA810 File Offset: 0x000A8A10
		[CallerCount(0)]
		public unsafe virtual bool WaitOne()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000AA858 File Offset: 0x000A8A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460545, RefRangeEnd = 460546, XrefRangeStart = 460545, XrefRangeEnd = 460546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000AA8AC File Offset: 0x000A8AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356981, XrefRangeEnd = 1356989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitOne(long timeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000AA904 File Offset: 0x000A8B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356989, XrefRangeEnd = 1356993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000AA970 File Offset: 0x000A8B70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357008, RefRangeEnd = 1357011, XrefRangeStart = 1356993, XrefRangeEnd = 1357008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000AA9D0 File Offset: 0x000A8BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357011, XrefRangeEnd = 1357019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, TimeSpan timeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000AAA30 File Offset: 0x000A8C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357019, XrefRangeEnd = 1357024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000AAA58 File Offset: 0x000A8C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357024, XrefRangeEnd = 1357029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000AAA9C File Offset: 0x000A8C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357029, XrefRangeEnd = 1357033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000AAAD8 File Offset: 0x000A8CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357033, XrefRangeEnd = 1357036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool explicitDisposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref explicitDisposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000AAB24 File Offset: 0x000A8D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1357040, RefRangeEnd = 1357042, XrefRangeStart = 1357036, XrefRangeEnd = 1357040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000AAB58 File Offset: 0x000A8D58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357056, RefRangeEnd = 1357059, XrefRangeStart = 1357042, XrefRangeEnd = 1357056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000AABC4 File Offset: 0x000A8DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357084, RefRangeEnd = 1357085, XrefRangeStart = 1357059, XrefRangeEnd = 1357084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitMultiple(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref WaitAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x000AAC30 File Offset: 0x000A8E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357085, XrefRangeEnd = 1357089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = handles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numHandles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000093C8 File Offset: 0x000075C8
		public WaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000AAC98 File Offset: 0x000A8E98
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000093D1 File Offset: 0x000075D1
		public unsafe static int WaitTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000AACB4 File Offset: 0x000A8EB4
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x000093DF File Offset: 0x000075DF
		public unsafe static int MAX_WAITHANDLES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x000AACD0 File Offset: 0x000A8ED0
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x000093ED File Offset: 0x000075ED
		public unsafe IntPtr waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000AACF8 File Offset: 0x000A8EF8
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00009408 File Offset: 0x00007608
		public unsafe SafeWaitHandle safeWaitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000AAD28 File Offset: 0x000A8F28
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00009427 File Offset: 0x00007627
		public unsafe bool hasThreadAffinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity)) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000AAD50 File Offset: 0x000A8F50
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00009442 File Offset: 0x00007642
		public unsafe static int WAIT_OBJECT_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x000AAD6C File Offset: 0x000A8F6C
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00009450 File Offset: 0x00007650
		public unsafe static int WAIT_ABANDONED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x000AAD88 File Offset: 0x000A8F88
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0000945E File Offset: 0x0000765E
		public unsafe static int WAIT_FAILED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000AADA4 File Offset: 0x000A8FA4
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0000946C File Offset: 0x0000766C
		public unsafe static int ERROR_TOO_MANY_POSTS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x000AADC0 File Offset: 0x000A8FC0
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0000947A File Offset: 0x0000767A
		public unsafe static int ERROR_NOT_OWNED_BY_CALLER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER, (void*)(&value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000AADDC File Offset: 0x000A8FDC
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x00009488 File Offset: 0x00007688
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000AADF8 File Offset: 0x000A8FF8
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x00009496 File Offset: 0x00007696
		public unsafe static int MaxWaitHandles
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&value));
			}
		}

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr_WaitTimeout;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr_MAX_WAITHANDLES;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_safeWaitHandle;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_hasThreadAffinity;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_OBJECT_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_ABANDONED;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_FAILED;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeFieldInfoPtr_MaxWaitHandles;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000245 RID: 581
	public sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x000B1A90 File Offset: 0x000AFC90
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSocketHandle()
		{
			Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SafeSocketHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr);
			SafeSocketHandle.NativeFieldInfoPtr_blocking_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "blocking_threads");
			SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "threads_stacktraces");
			SafeSocketHandle.NativeFieldInfoPtr_in_cleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "in_cleanup");
			SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "THROW_ON_ABORT_RETRIES");
			SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100669085);
			SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100669086);
			SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100669087);
			SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100669088);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000B1B60 File Offset: 0x000AFD60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490407, RefRangeEnd = 490409, XrefRangeStart = 490395, XrefRangeEnd = 490407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000B1BB8 File Offset: 0x000AFDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490409, XrefRangeEnd = 490481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000B1BF4 File Offset: 0x000AFDF4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 490496, RefRangeEnd = 490504, XrefRangeStart = 490481, XrefRangeEnd = 490496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000B1C28 File Offset: 0x000AFE28
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 490524, RefRangeEnd = 490540, XrefRangeStart = 490504, XrefRangeEnd = 490524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterForBlockingSyscall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSocketHandle.NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00010924 File Offset: 0x0000EB24
		public SafeSocketHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000B1C5C File Offset: 0x000AFE5C
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x0001092D File Offset: 0x0000EB2D
		public unsafe List<Thread> blocking_threads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Thread>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_blocking_threads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000B1C8C File Offset: 0x000AFE8C
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x0001094C File Offset: 0x0000EB4C
		public unsafe Dictionary<Thread, StackTrace> threads_stacktraces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Thread, StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_threads_stacktraces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000B1CBC File Offset: 0x000AFEBC
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x0001096B File Offset: 0x0000EB6B
		public unsafe bool in_cleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSocketHandle.NativeFieldInfoPtr_in_cleanup)) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x00010986 File Offset: 0x0000EB86
		public unsafe static bool THROW_ON_ABORT_RETRIES
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSocketHandle.NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&value));
			}
		}

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_blocking_threads;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_threads_stacktraces;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_in_cleanup;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0;
	}
}

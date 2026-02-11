using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000261 RID: 609
	public class AuthenticatedStream : Stream
	{
		// Token: 0x060028C5 RID: 10437 RVA: 0x000B98BC File Offset: 0x000B7ABC
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticatedStream()
		{
			Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "AuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr);
			AuthenticatedStream.NativeFieldInfoPtr__InnerStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_InnerStream");
			AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_LeaveStreamOpen");
			AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100669383);
			AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100669384);
			AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100669385);
			AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100669386);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000B9964 File Offset: 0x000B7B64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 493887, RefRangeEnd = 493895, XrefRangeStart = 493876, XrefRangeEnd = 493887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x000B99C0 File Offset: 0x000B7BC0
		public unsafe Stream InnerStream
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000B9A00 File Offset: 0x000B7C00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 493900, RefRangeEnd = 493904, XrefRangeStart = 493895, XrefRangeEnd = 493900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000B9A4C File Offset: 0x000B7C4C
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000118F7 File Offset: 0x0000FAF7
		public AuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x000B9A94 File Offset: 0x000B7C94
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x00011900 File Offset: 0x0000FB00
		public unsafe Stream _InnerStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x000B9AC4 File Offset: 0x000B7CC4
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x0001191F File Offset: 0x0000FB1F
		public unsafe bool _LeaveStreamOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen)) = value;
			}
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr__InnerStream;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeFieldInfoPtr__LeaveStreamOpen;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}

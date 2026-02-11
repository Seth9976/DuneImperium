using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002F RID: 47
	public class MonoBtlsObject : Object
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00025D3C File Offset: 0x00023F3C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsObject()
		{
			Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr);
			MonoBtlsObject.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, "handle");
			MonoBtlsObject.NativeFieldInfoPtr_lastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, "lastError");
			MonoBtlsObject.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663784);
			MonoBtlsObject.NativeMethodInfoPtr_get_Handle_Internal_get_MonoBtlsHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663785);
			MonoBtlsObject.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663786);
			MonoBtlsObject.NativeMethodInfoPtr_CheckThrow_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663787);
			MonoBtlsObject.NativeMethodInfoPtr_SetException_Protected_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663788);
			MonoBtlsObject.NativeMethodInfoPtr_CheckError_Protected_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663789);
			MonoBtlsObject.NativeMethodInfoPtr_CheckError_Protected_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663790);
			MonoBtlsObject.NativeMethodInfoPtr_CheckLastError_FamOrAssem_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663791);
			MonoBtlsObject.NativeMethodInfoPtr_mono_btls_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663792);
			MonoBtlsObject.NativeMethodInfoPtr_FreeDataPtr_Protected_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663793);
			MonoBtlsObject.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663794);
			MonoBtlsObject.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663795);
			MonoBtlsObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663796);
			MonoBtlsObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, 100663797);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00025EAC File Offset: 0x000240AC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsObject(MonoBtlsObject.MonoBtlsHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00025EF8 File Offset: 0x000240F8
		public unsafe MonoBtlsObject.MonoBtlsHandle Handle
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 430131, RefRangeEnd = 430142, XrefRangeStart = 430130, XrefRangeEnd = 430131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_get_Handle_Internal_get_MonoBtlsHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsObject.MonoBtlsHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00025F38 File Offset: 0x00024138
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00025F74 File Offset: 0x00024174
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 430142, RefRangeEnd = 430176, XrefRangeStart = 430142, XrefRangeEnd = 430142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckThrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_CheckThrow_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00025FA8 File Offset: 0x000241A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430177, RefRangeEnd = 430179, XrefRangeStart = 430176, XrefRangeEnd = 430177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception SetException(Exception ex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_SetException_Protected_Exception_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00025FF8 File Offset: 0x000241F8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 430180, RefRangeEnd = 430205, XrefRangeStart = 430179, XrefRangeEnd = 430180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckError(bool ok, string callerName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_CheckError_Protected_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00026048 File Offset: 0x00024248
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 430206, RefRangeEnd = 430221, XrefRangeStart = 430205, XrefRangeEnd = 430206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckError(int ret, string callerName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ret;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_CheckError_Protected_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00026098 File Offset: 0x00024298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430225, RefRangeEnd = 430226, XrefRangeStart = 430221, XrefRangeEnd = 430225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLastError(string callerName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(callerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_CheckLastError_FamOrAssem_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000260DC File Offset: 0x000242DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430226, XrefRangeEnd = 430228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_free(IntPtr data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_mono_btls_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00026110 File Offset: 0x00024310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430230, RefRangeEnd = 430231, XrefRangeStart = 430228, XrefRangeEnd = 430230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeDataPtr(IntPtr data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_FreeDataPtr_Protected_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00026150 File Offset: 0x00024350
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsObject.NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002618C File Offset: 0x0002438C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430237, RefRangeEnd = 430239, XrefRangeStart = 430231, XrefRangeEnd = 430237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000261CC File Offset: 0x000243CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 430244, RefRangeEnd = 430254, XrefRangeStart = 430239, XrefRangeEnd = 430244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00026200 File Offset: 0x00024400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430254, XrefRangeEnd = 430258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003045 File Offset: 0x00001245
		public MonoBtlsObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002623C File Offset: 0x0002443C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000304E File Offset: 0x0000124E
		public unsafe MonoBtlsObject.MonoBtlsHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsObject.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsObject.MonoBtlsHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsObject.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0002626C File Offset: 0x0002446C
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000306D File Offset: 0x0000126D
		public unsafe Exception lastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsObject.NativeFieldInfoPtr_lastError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsObject.NativeFieldInfoPtr_lastError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_lastError;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsHandle_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_MonoBtlsHandle_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrow_Protected_Void_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Protected_Exception_Exception_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_CheckError_Protected_Void_Boolean_String_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_CheckError_Protected_Void_Int32_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_CheckLastError_FamOrAssem_Void_String_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_free_Private_Static_Void_IntPtr_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_FreeDataPtr_Protected_Void_IntPtr_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_New_Void_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x020002AD RID: 685
		public class MonoBtlsHandle : SafeHandle
		{
			// Token: 0x06002AE4 RID: 10980 RVA: 0x000BF3C4 File Offset: 0x000BD5C4
			// Note: this type is marked as 'beforefieldinit'.
			static MonoBtlsHandle()
			{
				Il2CppClassPointerStore<MonoBtlsObject.MonoBtlsHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsObject>.NativeClassPtr, "MonoBtlsHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsObject.MonoBtlsHandle>.NativeClassPtr);
				MonoBtlsObject.MonoBtlsHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject.MonoBtlsHandle>.NativeClassPtr, 100663798);
				MonoBtlsObject.MonoBtlsHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsObject.MonoBtlsHandle>.NativeClassPtr, 100663799);
			}

			// Token: 0x06002AE5 RID: 10981 RVA: 0x000BF418 File Offset: 0x000BD618
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 430091, RefRangeEnd = 430129, XrefRangeStart = 430090, XrefRangeEnd = 430091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MonoBtlsHandle(IntPtr handle, bool ownsHandle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsObject.MonoBtlsHandle>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsObject.MonoBtlsHandle.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000BF470 File Offset: 0x000BD670
			public unsafe override bool IsInvalid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430129, XrefRangeEnd = 430130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsObject.MonoBtlsHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002AE7 RID: 10983 RVA: 0x00013141 File Offset: 0x00011341
			public MonoBtlsHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021C8 RID: 8648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

			// Token: 0x040021C9 RID: 8649
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;
		}
	}
}

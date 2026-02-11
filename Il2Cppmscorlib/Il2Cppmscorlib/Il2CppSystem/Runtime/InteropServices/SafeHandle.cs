using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000397 RID: 919
	public class SafeHandle : CriticalFinalizerObject
	{
		// Token: 0x060037F5 RID: 14325 RVA: 0x00110D14 File Offset: 0x0010EF14
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandle()
		{
			Il2CppClassPointerStore<SafeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr);
			SafeHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "handle");
			SafeHandle.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_state");
			SafeHandle.NativeFieldInfoPtr__ownsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_ownsHandle");
			SafeHandle.NativeFieldInfoPtr__fullyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "_fullyInitialized");
			SafeHandle.NativeFieldInfoPtr_RefCount_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_Mask");
			SafeHandle.NativeFieldInfoPtr_RefCount_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, "RefCount_One");
			SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671648);
			SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671649);
			SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671650);
			SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671651);
			SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671652);
			SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671653);
			SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671654);
			SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671655);
			SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671656);
			SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671657);
			SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671658);
			SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671659);
			SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671660);
			SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671661);
			SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671662);
			SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671663);
			SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr, 100671664);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00110F10 File Offset: 0x0010F110
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1391372, RefRangeEnd = 1391394, XrefRangeStart = 1391367, XrefRangeEnd = 1391372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invalidHandleValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00110F68 File Offset: 0x0010F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391394, XrefRangeEnd = 1391400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00110FA4 File Offset: 0x0010F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391400, XrefRangeEnd = 1391403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00110FE0 File Offset: 0x0010F1E0
		[CallerCount(0)]
		public unsafe void SetHandle(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00111020 File Offset: 0x0010F220
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr DangerousGetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x0011105C File Offset: 0x0010F25C
		public unsafe bool IsClosed
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1391403, RefRangeEnd = 1391416, XrefRangeStart = 1391403, XrefRangeEnd = 1391403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x00111098 File Offset: 0x0010F298
		public unsafe virtual bool IsInvalid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x001110E0 File Offset: 0x0010F2E0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1171637, RefRangeEnd = 1171657, XrefRangeStart = 1171637, XrefRangeEnd = 1171657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00111114 File Offset: 0x0010F314
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1171637, RefRangeEnd = 1171657, XrefRangeStart = 1171637, XrefRangeEnd = 1171657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00111148 File Offset: 0x0010F348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391417, RefRangeEnd = 1391418, XrefRangeStart = 1391416, XrefRangeEnd = 1391417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00111194 File Offset: 0x0010F394
		[CallerCount(0)]
		public unsafe virtual bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x001111DC File Offset: 0x0010F3DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1391422, RefRangeEnd = 1391426, XrefRangeStart = 1391418, XrefRangeEnd = 1391422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleAsInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00111210 File Offset: 0x0010F410
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1391429, RefRangeEnd = 1391486, XrefRangeStart = 1391426, XrefRangeEnd = 1391429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousAddRef(ref bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00111250 File Offset: 0x0010F450
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 1391487, RefRangeEnd = 1391568, XrefRangeStart = 1391486, XrefRangeEnd = 1391487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00111284 File Offset: 0x0010F484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391568, XrefRangeEnd = 1391578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x001112B8 File Offset: 0x0010F4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391578, XrefRangeEnd = 1391579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_InternalFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x001112EC File Offset: 0x0010F4EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1391582, RefRangeEnd = 1391587, XrefRangeStart = 1391579, XrefRangeEnd = 1391582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousReleaseInternal(bool dispose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dispose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandle.NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000148F4 File Offset: 0x00012AF4
		public SafeHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0011132C File Offset: 0x0010F52C
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x000148FD File Offset: 0x00012AFD
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x00111354 File Offset: 0x0010F554
		// (set) Token: 0x0600380B RID: 14347 RVA: 0x00014918 File Offset: 0x00012B18
		public unsafe int _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x0011137C File Offset: 0x0010F57C
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x00014933 File Offset: 0x00012B33
		public unsafe bool _ownsHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__ownsHandle)) = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x001113A4 File Offset: 0x0010F5A4
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x0001494E File Offset: 0x00012B4E
		public unsafe bool _fullyInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeHandle.NativeFieldInfoPtr__fullyInitialized)) = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x001113CC File Offset: 0x0010F5CC
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x00014969 File Offset: 0x00012B69
		public unsafe static int RefCount_Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_Mask, (void*)(&value));
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x001113E8 File Offset: 0x0010F5E8
		// (set) Token: 0x06003813 RID: 14355 RVA: 0x00014977 File Offset: 0x00012B77
		public unsafe static int RefCount_One
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeHandle.NativeFieldInfoPtr_RefCount_One, (void*)(&value));
			}
		}

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeFieldInfoPtr__ownsHandle;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeFieldInfoPtr__fullyInitialized;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_Mask;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeFieldInfoPtr_RefCount_One;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_Boolean_0;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Protected_Void_IntPtr_0;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeMethodInfoPtr_DangerousGetHandle_Public_IntPtr_0;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClosed_Public_get_Boolean_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleAsInvalid_Public_Void_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr_DangerousAddRef_Public_Void_byref_Boolean_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr_DangerousRelease_Public_Void_0;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeMethodInfoPtr_InternalDispose_Private_Void_0;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_InternalFinalize_Private_Void_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_DangerousReleaseInternal_Private_Void_Boolean_0;
	}
}

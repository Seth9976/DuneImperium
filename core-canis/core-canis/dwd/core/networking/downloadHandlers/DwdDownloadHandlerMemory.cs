using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace dwd.core.networking.downloadHandlers
{
	// Token: 0x02000128 RID: 296
	public class DwdDownloadHandlerMemory : DwdDownloadHandler
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x00055D08 File Offset: 0x00053F08
		// Note: this type is marked as 'beforefieldinit'.
		static DwdDownloadHandlerMemory()
		{
			Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.downloadHandlers", "DwdDownloadHandlerMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr);
			DwdDownloadHandlerMemory.NativeFieldInfoPtr_internalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, "internalStatus");
			DwdDownloadHandlerMemory.NativeFieldInfoPtr__memoryStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, "_memoryStream");
			DwdDownloadHandlerMemory.NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, 100665726);
			DwdDownloadHandlerMemory.NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, 100665727);
			DwdDownloadHandlerMemory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, 100665728);
			DwdDownloadHandlerMemory.NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, 100665729);
			DwdDownloadHandlerMemory.NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr, 100665730);
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00055DC4 File Offset: 0x00053FC4
		public unsafe override ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerMemory.NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00055E08 File Offset: 0x00054008
		public unsafe override bool HasData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerMemory.NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00055E50 File Offset: 0x00054050
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 869932, RefRangeEnd = 869946, XrefRangeStart = 869914, XrefRangeEnd = 869932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdDownloadHandlerMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdDownloadHandlerMemory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandlerMemory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00055E8C File Offset: 0x0005408C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869946, XrefRangeEnd = 869947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> getData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerMemory.NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00055ED8 File Offset: 0x000540D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869947, XrefRangeEnd = 869954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool receiveData(Il2CppStructArray<byte> newData, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandlerMemory.NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00007C4F File Offset: 0x00005E4F
		public DwdDownloadHandlerMemory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00055F40 File Offset: 0x00054140
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00007C58 File Offset: 0x00005E58
		public ErrorInfo internalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerMemory.NativeFieldInfoPtr_internalStatus);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerMemory.NativeFieldInfoPtr_internalStatus), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00055F70 File Offset: 0x00054170
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00007C86 File Offset: 0x00005E86
		public unsafe MemoryStream _memoryStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerMemory.NativeFieldInfoPtr__memoryStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandlerMemory.NativeFieldInfoPtr__memoryStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_internalStatus;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr__memoryStream;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_get_ErrorInfo_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Public_Virtual_get_Boolean_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_getData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_receiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;
	}
}

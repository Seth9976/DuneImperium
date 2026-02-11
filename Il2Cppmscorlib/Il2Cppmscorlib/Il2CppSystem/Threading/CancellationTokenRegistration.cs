using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019A RID: 410
	public sealed class CancellationTokenRegistration : ValueType
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x000A23D0 File Offset: 0x000A05D0
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenRegistration()
		{
			Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenRegistration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr);
			CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_callbackInfo");
			CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, "m_registrationInfo");
			CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667915);
			CancellationTokenRegistration.NativeMethodInfoPtr_Unregister_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667916);
			CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667917);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667918);
			CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667919);
			CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667920);
			CancellationTokenRegistration.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, 100667921);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000A24B4 File Offset: 0x000A06B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352295, RefRangeEnd = 1352296, XrefRangeStart = 1352287, XrefRangeEnd = 1352295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(registrationInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000A251C File Offset: 0x000A071C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352301, RefRangeEnd = 1352302, XrefRangeStart = 1352296, XrefRangeEnd = 1352301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Unregister_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000A2560 File Offset: 0x000A0760
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1352316, RefRangeEnd = 1352352, XrefRangeStart = 1352302, XrefRangeEnd = 1352316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000A2598 File Offset: 0x000A0798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352352, XrefRangeEnd = 1352357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000A25EC File Offset: 0x000A07EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352357, XrefRangeEnd = 1352359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationTokenRegistration other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000A2644 File Offset: 0x000A0844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352359, XrefRangeEnd = 1352362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000A2688 File Offset: 0x000A0888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352362, XrefRangeEnd = 1352371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenRegistration.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000876E File Offset: 0x0000696E
		public CancellationTokenRegistration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00008777 File Offset: 0x00006977
		public CancellationTokenRegistration()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr))
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x000A26C4 File Offset: 0x000A08C4
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00008789 File Offset: 0x00006989
		public unsafe CancellationCallbackInfo m_callbackInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_callbackInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x000A26F4 File Offset: 0x000A08F4
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x000087A8 File Offset: 0x000069A8
		public SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo);
				return new SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenRegistration.NativeFieldInfoPtr_m_registrationInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr_m_callbackInfo;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_m_registrationInfo;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationCallbackInfo_SparselyPopulatedArrayAddInfo_1_CancellationCallbackInfo_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Boolean_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CancellationTokenRegistration_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0;
	}
}

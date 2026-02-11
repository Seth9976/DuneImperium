using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000EC RID: 236
	public sealed class StoreAuthURLResponse_t : ValueType
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x0005BC18 File Offset: 0x00059E18
		// Note: this type is marked as 'beforefieldinit'.
		static StoreAuthURLResponse_t()
		{
			Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "StoreAuthURLResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr);
			StoreAuthURLResponse_t.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "URL");
			StoreAuthURLResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "_datasize");
			StoreAuthURLResponse_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, 100666763);
			StoreAuthURLResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, 100666764);
			StoreAuthURLResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, 100666765);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0005BCAC File Offset: 0x00059EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950166, RefRangeEnd = 950167, XrefRangeStart = 950162, XrefRangeEnd = 950166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string URLUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreAuthURLResponse_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0005BCE8 File Offset: 0x00059EE8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950167, XrefRangeEnd = 950171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreAuthURLResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0005BD2C File Offset: 0x00059F2C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreAuthURLResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00004083 File Offset: 0x00002283
		public StoreAuthURLResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0000408C File Offset: 0x0000228C
		public StoreAuthURLResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0005BD70 File Offset: 0x00059F70
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0000409E File Offset: 0x0000229E
		public unsafe Il2CppStructArray<byte> URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_URL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_URL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0005BDA0 File Offset: 0x00059FA0
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x000040BD File Offset: 0x000022BD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StoreAuthURLResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoreAuthURLResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_URLUTF8_Internal_String_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

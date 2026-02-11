using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E6 RID: 230
	[StructLayout(2)]
	public struct LicensesUpdated_t
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x0005B538 File Offset: 0x00059738
		// Note: this type is marked as 'beforefieldinit'.
		static LicensesUpdated_t()
		{
			Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LicensesUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr);
			LicensesUpdated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, "_datasize");
			LicensesUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, 100666744);
			LicensesUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, 100666745);
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0005B5A4 File Offset: 0x000597A4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950133, XrefRangeEnd = 950137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LicensesUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0005B5D4 File Offset: 0x000597D4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LicensesUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00003F9B File Offset: 0x0000219B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0005B604 File Offset: 0x00059804
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00003FAD File Offset: 0x000021AD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LicensesUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LicensesUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

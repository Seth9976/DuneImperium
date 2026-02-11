using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013C RID: 316
	[StructLayout(2)]
	public struct RemoteStorageLocalFileChange_t
	{
		// Token: 0x06001175 RID: 4469 RVA: 0x00062988 File Offset: 0x00060B88
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageLocalFileChange_t()
		{
			Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageLocalFileChange_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr);
			RemoteStorageLocalFileChange_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr, "_datasize");
			RemoteStorageLocalFileChange_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr, 100667016);
			RemoteStorageLocalFileChange_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr, 100667017);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x000629F4 File Offset: 0x00060BF4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950541, XrefRangeEnd = 950545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageLocalFileChange_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00062A24 File Offset: 0x00060C24
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageLocalFileChange_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000052BB File Offset: 0x000034BB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageLocalFileChange_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00062A54 File Offset: 0x00060C54
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x000052CD File Offset: 0x000034CD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageLocalFileChange_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageLocalFileChange_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

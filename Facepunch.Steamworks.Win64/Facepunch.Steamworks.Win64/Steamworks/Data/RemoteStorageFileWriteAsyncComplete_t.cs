using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013A RID: 314
	[StructLayout(2)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x00062754 File Offset: 0x00060954
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileWriteAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageFileWriteAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "Result");
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "_datasize");
			RemoteStorageFileWriteAsyncComplete_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, 100667010);
			RemoteStorageFileWriteAsyncComplete_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, 100667011);
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000627D4 File Offset: 0x000609D4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950533, XrefRangeEnd = 950537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileWriteAsyncComplete_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00062804 File Offset: 0x00060A04
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileWriteAsyncComplete_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0000527B File Offset: 0x0000347B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00062834 File Offset: 0x00060A34
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0000528D File Offset: 0x0000348D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017A1 RID: 6049
		[FieldOffset(0)]
		public Result Result;
	}
}

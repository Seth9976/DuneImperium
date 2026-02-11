using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000138 RID: 312
	[StructLayout(2)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x00062520 File Offset: 0x00060720
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileProgress_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishFileProgress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr);
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_DPercentFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "DPercentFile");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_Preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "Preview");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishFileProgress_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, 100667004);
			RemoteStoragePublishFileProgress_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, 100667005);
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x000625B4 File Offset: 0x000607B4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950525, XrefRangeEnd = 950529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishFileProgress_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x000625E4 File Offset: 0x000607E4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishFileProgress_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0000523B File Offset: 0x0000343B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00062614 File Offset: 0x00060814
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x0000524D File Offset: 0x0000344D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_DPercentFile;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeFieldInfoPtr_Preview;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001792 RID: 6034
		[FieldOffset(0)]
		public double DPercentFile;

		// Token: 0x04001793 RID: 6035
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool Preview;
	}
}

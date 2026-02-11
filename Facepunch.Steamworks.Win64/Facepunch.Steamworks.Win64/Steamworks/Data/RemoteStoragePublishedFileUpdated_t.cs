using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000139 RID: 313
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x00062630 File Offset: 0x00060830
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUpdated_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishedFileUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr);
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "PublishedFileId");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "AppID");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_Unused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "Unused");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishedFileUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, 100667007);
			RemoteStoragePublishedFileUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, 100667008);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x000626D8 File Offset: 0x000608D8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950529, XrefRangeEnd = 950533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x00062708 File Offset: 0x00060908
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0000525B File Offset: 0x0000345B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00062738 File Offset: 0x00060938
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_Unused;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400179A RID: 6042
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400179B RID: 6043
		[FieldOffset(8)]
		public AppId AppID;

		// Token: 0x0400179C RID: 6044
		[FieldOffset(16)]
		public ulong Unused;
	}
}

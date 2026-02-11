using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000131 RID: 305
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x00061B18 File Offset: 0x0005FD18
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUnsubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishedFileUnsubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "PublishedFileId");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "AppID");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishedFileUnsubscribed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, 100666983);
			RemoteStoragePublishedFileUnsubscribed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, 100666984);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00061BAC File Offset: 0x0005FDAC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950497, XrefRangeEnd = 950501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileUnsubscribed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00061BDC File Offset: 0x0005FDDC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileUnsubscribed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0000502F File Offset: 0x0000322F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00061C0C File Offset: 0x0005FE0C
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x00005041 File Offset: 0x00003241
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400175B RID: 5979
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400175C RID: 5980
		[FieldOffset(8)]
		public AppId AppID;
	}
}

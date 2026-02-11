using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000132 RID: 306
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00061C28 File Offset: 0x0005FE28
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileDeleted_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishedFileDeleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr);
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "PublishedFileId");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "AppID");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishedFileDeleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, 100666986);
			RemoteStoragePublishedFileDeleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, 100666987);
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00061CBC File Offset: 0x0005FEBC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950501, XrefRangeEnd = 950505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileDeleted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00061CEC File Offset: 0x0005FEEC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileDeleted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0000504F File Offset: 0x0000324F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00061D1C File Offset: 0x0005FF1C
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00005061 File Offset: 0x00003261
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001762 RID: 5986
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001763 RID: 5987
		[FieldOffset(8)]
		public AppId AppID;
	}
}

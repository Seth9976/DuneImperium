using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000130 RID: 304
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x06001117 RID: 4375 RVA: 0x00061A08 File Offset: 0x0005FC08
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileSubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishedFileSubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "PublishedFileId");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "AppID");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishedFileSubscribed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, 100666980);
			RemoteStoragePublishedFileSubscribed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, 100666981);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00061A9C File Offset: 0x0005FC9C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950493, XrefRangeEnd = 950497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileSubscribed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00061ACC File Offset: 0x0005FCCC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishedFileSubscribed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0000500F File Offset: 0x0000320F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00061AFC File Offset: 0x0005FCFC
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x00005021 File Offset: 0x00003221
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001754 RID: 5972
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001755 RID: 5973
		[FieldOffset(8)]
		public AppId AppID;
	}
}

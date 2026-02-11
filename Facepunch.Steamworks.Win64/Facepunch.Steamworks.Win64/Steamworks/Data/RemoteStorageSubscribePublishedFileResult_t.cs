using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000128 RID: 296
	[StructLayout(2)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x000605D0 File Offset: 0x0005E7D0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageSubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "Result");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageSubscribePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, 100666950);
			RemoteStorageSubscribePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, 100666951);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00060664 File Offset: 0x0005E864
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950437, XrefRangeEnd = 950441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageSubscribePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00060694 File Offset: 0x0005E894
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageSubscribePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00004AA6 File Offset: 0x00002CA6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000606C4 File Offset: 0x0005E8C4
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016F5 RID: 5877
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016F6 RID: 5878
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}

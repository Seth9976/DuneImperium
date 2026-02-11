using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012A RID: 298
	[StructLayout(2)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x0006092C File Offset: 0x0005EB2C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUnsubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageUnsubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "Result");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, 100666956);
			RemoteStorageUnsubscribePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, 100666957);
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000609C0 File Offset: 0x0005EBC0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950445, XrefRangeEnd = 950449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUnsubscribePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x000609F0 File Offset: 0x0005EBF0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUnsubscribePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00004B7E File Offset: 0x00002D7E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00060A20 File Offset: 0x0005EC20
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00004B90 File Offset: 0x00002D90
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001704 RID: 5892
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001705 RID: 5893
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}

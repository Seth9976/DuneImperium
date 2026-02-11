using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000126 RID: 294
	[StructLayout(2)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x000602B8 File Offset: 0x0005E4B8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDeletePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageDeletePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "Result");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageDeletePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, 100666944);
			RemoteStorageDeletePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, 100666945);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0006034C File Offset: 0x0005E54C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950429, XrefRangeEnd = 950433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDeletePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0006037C File Offset: 0x0005E57C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDeletePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000049ED File Offset: 0x00002BED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000603AC File Offset: 0x0005E5AC
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x000049FF File Offset: 0x00002BFF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016E7 RID: 5863
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016E8 RID: 5864
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}

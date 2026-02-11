using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000136 RID: 310
	[StructLayout(2)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x06001144 RID: 4420 RVA: 0x00062174 File Offset: 0x00060374
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSetUserPublishedFileActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageSetUserPublishedFileActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr);
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "Result");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "Action");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, 100666998);
			RemoteStorageSetUserPublishedFileActionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, 100666999);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0006221C File Offset: 0x0006041C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950517, XrefRangeEnd = 950521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageSetUserPublishedFileActionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0006224C File Offset: 0x0006044C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageSetUserPublishedFileActionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00005148 File Offset: 0x00003348
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0006227C File Offset: 0x0006047C
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x0000515A File Offset: 0x0000335A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001781 RID: 6017
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001782 RID: 6018
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001783 RID: 6019
		[FieldOffset(16)]
		public WorkshopFileAction Action;
	}
}

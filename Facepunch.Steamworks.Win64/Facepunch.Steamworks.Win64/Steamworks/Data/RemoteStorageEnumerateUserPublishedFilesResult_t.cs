using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000127 RID: 295
	public sealed class RemoteStorageEnumerateUserPublishedFilesResult_t : ValueType
	{
		// Token: 0x06001080 RID: 4224 RVA: 0x000603C8 File Offset: 0x0005E5C8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserPublishedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageEnumerateUserPublishedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "Result");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "ResultsReturned");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "TotalResultCount");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "GPublishedFileId");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, 100666947);
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, 100666948);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00060484 File Offset: 0x0005E684
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950433, XrefRangeEnd = 950437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000604C8 File Offset: 0x0005E6C8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00004A0D File Offset: 0x00002C0D
		public RemoteStorageEnumerateUserPublishedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00004A16 File Offset: 0x00002C16
		public RemoteStorageEnumerateUserPublishedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0006050C File Offset: 0x0005E70C
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00004A28 File Offset: 0x00002C28
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00060534 File Offset: 0x0005E734
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00004A43 File Offset: 0x00002C43
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0006055C File Offset: 0x0005E75C
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00004A5E File Offset: 0x00002C5E
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00060584 File Offset: 0x0005E784
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00004A79 File Offset: 0x00002C79
		public unsafe Il2CppStructArray<PublishedFileId> GPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x000605B4 File Offset: 0x0005E7B4
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00004A98 File Offset: 0x00002C98
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr_GPublishedFileId;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

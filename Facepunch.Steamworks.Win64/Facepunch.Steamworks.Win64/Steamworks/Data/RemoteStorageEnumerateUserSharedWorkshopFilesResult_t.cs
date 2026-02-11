using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000135 RID: 309
	public sealed class RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ValueType
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00061F6C File Offset: 0x0006016C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageEnumerateUserSharedWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "Result");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "ResultsReturned");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "TotalResultCount");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "GPublishedFileId");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, 100666995);
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, 100666996);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00062028 File Offset: 0x00060228
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950513, XrefRangeEnd = 950517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0006206C File Offset: 0x0006026C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x000050AF File Offset: 0x000032AF
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000050B8 File Offset: 0x000032B8
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x000620B0 File Offset: 0x000602B0
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x000050CA File Offset: 0x000032CA
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000620D8 File Offset: 0x000602D8
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x000050E5 File Offset: 0x000032E5
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00062100 File Offset: 0x00060300
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x00005100 File Offset: 0x00003300
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00062128 File Offset: 0x00060328
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0000511B File Offset: 0x0000331B
		public unsafe Il2CppStructArray<PublishedFileId> GPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00062158 File Offset: 0x00060358
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0000513A File Offset: 0x0000333A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_GPublishedFileId;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

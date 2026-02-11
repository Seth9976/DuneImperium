using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012E RID: 302
	public sealed class RemoteStorageEnumerateWorkshopFilesResult_t : ValueType
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x000615E4 File Offset: 0x0005F7E4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageEnumerateWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "Result");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "ResultsReturned");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "TotalResultCount");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "GPublishedFileId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "GScore");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "AppId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "StartIndex");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, 100666974);
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, 100666975);
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000616DC File Offset: 0x0005F8DC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950485, XrefRangeEnd = 950489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateWorkshopFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00061720 File Offset: 0x0005F920
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateWorkshopFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00004F01 File Offset: 0x00003101
		public RemoteStorageEnumerateWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00004F0A File Offset: 0x0000310A
		public RemoteStorageEnumerateWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00061764 File Offset: 0x0005F964
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00004F1C File Offset: 0x0000311C
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0006178C File Offset: 0x0005F98C
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00004F37 File Offset: 0x00003137
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000617B4 File Offset: 0x0005F9B4
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00004F52 File Offset: 0x00003152
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000617DC File Offset: 0x0005F9DC
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00004F6D File Offset: 0x0000316D
		public unsafe Il2CppStructArray<PublishedFileId> GPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0006180C File Offset: 0x0005FA0C
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00004F8C File Offset: 0x0000318C
		public unsafe Il2CppStructArray<float> GScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_GScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0006183C File Offset: 0x0005FA3C
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00004FAB File Offset: 0x000031AB
		public unsafe AppId AppId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_AppId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_AppId)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00061864 File Offset: 0x0005FA64
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00004FC6 File Offset: 0x000031C6
		public unsafe uint StartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_StartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_StartIndex)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0006188C File Offset: 0x0005FA8C
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00004FE1 File Offset: 0x000031E1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_GPublishedFileId;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_GScore;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_AppId;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_StartIndex;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

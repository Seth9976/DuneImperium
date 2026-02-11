using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000137 RID: 311
	public sealed class RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ValueType
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x00062298 File Offset: 0x00060498
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageEnumeratePublishedFilesByUserActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr);
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "Result");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "Action");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "ResultsReturned");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "TotalResultCount");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "GPublishedFileId");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GRTimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "GRTimeUpdated");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, 100667001);
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, 100667002);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0006237C File Offset: 0x0006057C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950521, XrefRangeEnd = 950525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x000623C0 File Offset: 0x000605C0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00005168 File Offset: 0x00003368
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00005171 File Offset: 0x00003371
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00062404 File Offset: 0x00060604
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00005183 File Offset: 0x00003383
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0006242C File Offset: 0x0006062C
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000519E File Offset: 0x0000339E
		public unsafe WorkshopFileAction Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_Action)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00062454 File Offset: 0x00060654
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x000051B9 File Offset: 0x000033B9
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0006247C File Offset: 0x0006067C
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x000051D4 File Offset: 0x000033D4
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000624A4 File Offset: 0x000606A4
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x000051EF File Offset: 0x000033EF
		public unsafe Il2CppStructArray<PublishedFileId> GPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x000624D4 File Offset: 0x000606D4
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0000520E File Offset: 0x0000340E
		public unsafe Il2CppStructArray<uint> GRTimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GRTimeUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_GRTimeUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x00062504 File Offset: 0x00060704
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0000522D File Offset: 0x0000342D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_GPublishedFileId;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_GRTimeUpdated;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

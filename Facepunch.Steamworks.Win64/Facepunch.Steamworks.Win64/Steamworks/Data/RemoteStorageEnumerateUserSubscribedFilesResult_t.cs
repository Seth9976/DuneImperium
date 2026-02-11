using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000129 RID: 297
	public sealed class RemoteStorageEnumerateUserSubscribedFilesResult_t : ValueType
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x000606E0 File Offset: 0x0005E8E0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSubscribedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageEnumerateUserSubscribedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "Result");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "ResultsReturned");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "TotalResultCount");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "GPublishedFileId");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GRTimeSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "GRTimeSubscribed");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, 100666953);
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, 100666954);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x000607B0 File Offset: 0x0005E9B0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950441, XrefRangeEnd = 950445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000607F4 File Offset: 0x0005E9F4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public RemoteStorageEnumerateUserSubscribedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00004ACF File Offset: 0x00002CCF
		public RemoteStorageEnumerateUserSubscribedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00060838 File Offset: 0x0005EA38
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00004AE1 File Offset: 0x00002CE1
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00060860 File Offset: 0x0005EA60
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00004AFC File Offset: 0x00002CFC
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00060888 File Offset: 0x0005EA88
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00004B17 File Offset: 0x00002D17
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x000608B0 File Offset: 0x0005EAB0
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00004B32 File Offset: 0x00002D32
		public unsafe Il2CppStructArray<PublishedFileId> GPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000608E0 File Offset: 0x0005EAE0
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00004B51 File Offset: 0x00002D51
		public unsafe Il2CppStructArray<uint> GRTimeSubscribed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GRTimeSubscribed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_GRTimeSubscribed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00060910 File Offset: 0x0005EB10
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00004B70 File Offset: 0x00002D70
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_GPublishedFileId;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_GRTimeSubscribed;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

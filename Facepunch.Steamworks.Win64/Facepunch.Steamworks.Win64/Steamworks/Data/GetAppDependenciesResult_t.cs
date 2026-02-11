using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000178 RID: 376
	public sealed class GetAppDependenciesResult_t : ValueType
	{
		// Token: 0x06001319 RID: 4889 RVA: 0x00066FF4 File Offset: 0x000651F4
		// Note: this type is marked as 'beforefieldinit'.
		static GetAppDependenciesResult_t()
		{
			Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GetAppDependenciesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr);
			GetAppDependenciesResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "Result");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "PublishedFileId");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_GAppIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "GAppIDs");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_NumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "NumAppDependencies");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_TotalNumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "TotalNumAppDependencies");
			GetAppDependenciesResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "_datasize");
			GetAppDependenciesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, 100667200);
			GetAppDependenciesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, 100667201);
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x000670C4 File Offset: 0x000652C4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950803, XrefRangeEnd = 950807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAppDependenciesResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00067108 File Offset: 0x00065308
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAppDependenciesResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00005D3B File Offset: 0x00003F3B
		public GetAppDependenciesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00005D44 File Offset: 0x00003F44
		public GetAppDependenciesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0006714C File Offset: 0x0006534C
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00005D56 File Offset: 0x00003F56
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00067174 File Offset: 0x00065374
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00005D71 File Offset: 0x00003F71
		public unsafe PublishedFileId PublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_PublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_PublishedFileId)) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0006719C File Offset: 0x0006539C
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00005D8C File Offset: 0x00003F8C
		public unsafe Il2CppStructArray<AppId> GAppIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_GAppIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AppId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_GAppIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000671CC File Offset: 0x000653CC
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00005DAB File Offset: 0x00003FAB
		public unsafe uint NumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_NumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_NumAppDependencies)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000671F4 File Offset: 0x000653F4
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00005DC6 File Offset: 0x00003FC6
		public unsafe uint TotalNumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_TotalNumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_TotalNumAppDependencies)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0006721C File Offset: 0x0006541C
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x00005DE1 File Offset: 0x00003FE1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAppDependenciesResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAppDependenciesResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeFieldInfoPtr_GAppIDs;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeFieldInfoPtr_NumAppDependencies;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeFieldInfoPtr_TotalNumAppDependencies;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

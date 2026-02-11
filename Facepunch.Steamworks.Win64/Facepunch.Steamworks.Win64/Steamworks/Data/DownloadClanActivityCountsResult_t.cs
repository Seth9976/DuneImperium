using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FA RID: 250
	[StructLayout(2)]
	public struct DownloadClanActivityCountsResult_t
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x0005CE9C File Offset: 0x0005B09C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadClanActivityCountsResult_t()
		{
			Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DownloadClanActivityCountsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr);
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "Success");
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "_datasize");
			DownloadClanActivityCountsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, 100666809);
			DownloadClanActivityCountsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, 100666810);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0005CF1C File Offset: 0x0005B11C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950238, XrefRangeEnd = 950242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadClanActivityCountsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0005CF4C File Offset: 0x0005B14C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadClanActivityCountsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000042F5 File Offset: 0x000024F5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x0005CF7C File Offset: 0x0005B17C
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00004307 File Offset: 0x00002507
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400158D RID: 5517
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Success;
	}
}

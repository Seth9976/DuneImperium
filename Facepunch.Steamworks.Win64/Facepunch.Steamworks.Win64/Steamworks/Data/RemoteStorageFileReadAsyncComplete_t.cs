using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013B RID: 315
	[StructLayout(2)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x00062850 File Offset: 0x00060A50
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileReadAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageFileReadAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_FileReadAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "FileReadAsync");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "Result");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "Offset");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "Read");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "_datasize");
			RemoteStorageFileReadAsyncComplete_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, 100667013);
			RemoteStorageFileReadAsyncComplete_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, 100667014);
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0006290C File Offset: 0x00060B0C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950537, XrefRangeEnd = 950541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileReadAsyncComplete_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0006293C File Offset: 0x00060B3C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileReadAsyncComplete_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0000529B File Offset: 0x0000349B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0006296C File Offset: 0x00060B6C
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x000052AD File Offset: 0x000034AD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_FileReadAsync;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeFieldInfoPtr_Read;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017A9 RID: 6057
		[FieldOffset(0)]
		public ulong FileReadAsync;

		// Token: 0x040017AA RID: 6058
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x040017AB RID: 6059
		[FieldOffset(12)]
		public uint Offset;

		// Token: 0x040017AC RID: 6060
		[FieldOffset(16)]
		public uint Read;
	}
}

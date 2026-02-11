using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000176 RID: 374
	[StructLayout(2)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x00066DAC File Offset: 0x00064FAC
		// Note: this type is marked as 'beforefieldinit'.
		static AddAppDependencyResult_t()
		{
			Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AddAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr);
			AddAppDependencyResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "Result");
			AddAppDependencyResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "PublishedFileId");
			AddAppDependencyResult_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "AppID");
			AddAppDependencyResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "_datasize");
			AddAppDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, 100667194);
			AddAppDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, 100667195);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00066E54 File Offset: 0x00065054
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950791, XrefRangeEnd = 950795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddAppDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00066E84 File Offset: 0x00065084
		public unsafe CallbackType CallbackType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 950795, RefRangeEnd = 950799, XrefRangeStart = 950795, XrefRangeEnd = 950795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddAppDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00005CFB File Offset: 0x00003EFB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00066EB4 File Offset: 0x000650B4
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x00005D0D File Offset: 0x00003F0D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddAppDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddAppDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400193A RID: 6458
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400193B RID: 6459
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400193C RID: 6460
		[FieldOffset(16)]
		public AppId AppID;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000175 RID: 373
	[StructLayout(2)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x00066C88 File Offset: 0x00064E88
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoveUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr);
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "Result");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "PublishedFileId");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_ChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "ChildPublishedFileId");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "_datasize");
			RemoveUGCDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, 100667191);
			RemoveUGCDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, 100667192);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00066D30 File Offset: 0x00064F30
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950787, XrefRangeEnd = 950791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveUGCDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00066D60 File Offset: 0x00064F60
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveUGCDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00005CDB File Offset: 0x00003EDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00066D90 File Offset: 0x00064F90
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x00005CED File Offset: 0x00003EED
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_ChildPublishedFileId;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001931 RID: 6449
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001932 RID: 6450
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001933 RID: 6451
		[FieldOffset(16)]
		public PublishedFileId ChildPublishedFileId;
	}
}

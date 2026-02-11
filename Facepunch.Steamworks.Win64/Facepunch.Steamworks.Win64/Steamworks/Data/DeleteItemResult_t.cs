using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000179 RID: 377
	[StructLayout(2)]
	public struct DeleteItemResult_t
	{
		// Token: 0x0600132A RID: 4906 RVA: 0x00067238 File Offset: 0x00065438
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteItemResult_t()
		{
			Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DeleteItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr);
			DeleteItemResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "Result");
			DeleteItemResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "PublishedFileId");
			DeleteItemResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "_datasize");
			DeleteItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, 100667203);
			DeleteItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, 100667204);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x000672CC File Offset: 0x000654CC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950807, XrefRangeEnd = 950811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x000672FC File Offset: 0x000654FC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00005DEF File Offset: 0x00003FEF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0006732C File Offset: 0x0006552C
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00005E01 File Offset: 0x00004001
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeleteItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeleteItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001953 RID: 6483
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001954 RID: 6484
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}

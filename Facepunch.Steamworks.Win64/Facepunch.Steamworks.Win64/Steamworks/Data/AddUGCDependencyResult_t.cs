using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000174 RID: 372
	[StructLayout(2)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00066B64 File Offset: 0x00064D64
		// Note: this type is marked as 'beforefieldinit'.
		static AddUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AddUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr);
			AddUGCDependencyResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "Result");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "PublishedFileId");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_ChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "ChildPublishedFileId");
			AddUGCDependencyResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "_datasize");
			AddUGCDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, 100667188);
			AddUGCDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, 100667189);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00066C0C File Offset: 0x00064E0C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950783, XrefRangeEnd = 950787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddUGCDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00066C3C File Offset: 0x00064E3C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddUGCDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00005CBB File Offset: 0x00003EBB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00066C6C File Offset: 0x00064E6C
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x00005CCD File Offset: 0x00003ECD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddUGCDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddUGCDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr_ChildPublishedFileId;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001928 RID: 6440
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001929 RID: 6441
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400192A RID: 6442
		[FieldOffset(16)]
		public PublishedFileId ChildPublishedFileId;
	}
}

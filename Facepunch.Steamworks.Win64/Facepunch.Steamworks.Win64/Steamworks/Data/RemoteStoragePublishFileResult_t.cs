using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000125 RID: 293
	[StructLayout(2)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x06001074 RID: 4212 RVA: 0x00060194 File Offset: 0x0005E394
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStoragePublishFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr);
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "Result");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "UserNeedsToAcceptWorkshopLegalAgreement");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "_datasize");
			RemoteStoragePublishFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, 100666941);
			RemoteStoragePublishFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, 100666942);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0006023C File Offset: 0x0005E43C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950425, XrefRangeEnd = 950429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0006026C File Offset: 0x0005E46C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStoragePublishFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000049CD File Offset: 0x00002BCD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0006029C File Offset: 0x0005E49C
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x000049DF File Offset: 0x00002BDF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016DF RID: 5855
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016E0 RID: 5856
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x040016E1 RID: 5857
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool UserNeedsToAcceptWorkshopLegalAgreement;
	}
}

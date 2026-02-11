using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016B RID: 363
	[StructLayout(2)]
	public struct CreateItemResult_t
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x0006615C File Offset: 0x0006435C
		// Note: this type is marked as 'beforefieldinit'.
		static CreateItemResult_t()
		{
			Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "CreateItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr);
			CreateItemResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "Result");
			CreateItemResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "PublishedFileId");
			CreateItemResult_t.NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "UserNeedsToAcceptWorkshopLegalAgreement");
			CreateItemResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "_datasize");
			CreateItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, 100667161);
			CreateItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, 100667162);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00066204 File Offset: 0x00064404
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950747, XrefRangeEnd = 950751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00066234 File Offset: 0x00064434
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00005B9B File Offset: 0x00003D9B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00066264 File Offset: 0x00064464
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00005BAD File Offset: 0x00003DAD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CreateItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018DD RID: 6365
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040018DE RID: 6366
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x040018DF RID: 6367
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool UserNeedsToAcceptWorkshopLegalAgreement;
	}
}

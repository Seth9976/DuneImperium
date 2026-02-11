using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016C RID: 364
	[StructLayout(2)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x00066280 File Offset: 0x00064480
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitItemUpdateResult_t()
		{
			Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SubmitItemUpdateResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr);
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "Result");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "UserNeedsToAcceptWorkshopLegalAgreement");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "PublishedFileId");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "_datasize");
			SubmitItemUpdateResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, 100667164);
			SubmitItemUpdateResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, 100667165);
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00066328 File Offset: 0x00064528
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950751, XrefRangeEnd = 950755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitItemUpdateResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00066358 File Offset: 0x00064558
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitItemUpdateResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00005BBB File Offset: 0x00003DBB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00066388 File Offset: 0x00064588
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00005BCD File Offset: 0x00003DCD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018E6 RID: 6374
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040018E7 RID: 6375
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool UserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040018E8 RID: 6376
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}

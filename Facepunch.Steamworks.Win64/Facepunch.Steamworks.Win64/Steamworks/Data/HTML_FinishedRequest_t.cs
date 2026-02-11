using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000183 RID: 387
	public sealed class HTML_FinishedRequest_t : ValueType
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x00068250 File Offset: 0x00066450
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FinishedRequest_t()
		{
			Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_FinishedRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr);
			HTML_FinishedRequest_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "PchURL");
			HTML_FinishedRequest_t.NativeFieldInfoPtr_PchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "PchPageTitle");
			HTML_FinishedRequest_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, "_datasize");
			HTML_FinishedRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, 100667233);
			HTML_FinishedRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr, 100667234);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000682F8 File Offset: 0x000664F8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950847, XrefRangeEnd = 950851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_FinishedRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0006833C File Offset: 0x0006653C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_FinishedRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000061D3 File Offset: 0x000043D3
		public HTML_FinishedRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000061DC File Offset: 0x000043DC
		public HTML_FinishedRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FinishedRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00068380 File Offset: 0x00066580
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000061EE File Offset: 0x000043EE
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000683A8 File Offset: 0x000665A8
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00006209 File Offset: 0x00004409
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000683D0 File Offset: 0x000665D0
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00006228 File Offset: 0x00004428
		public unsafe string PchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_PchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FinishedRequest_t.NativeFieldInfoPtr_PchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000683F8 File Offset: 0x000665F8
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00006247 File Offset: 0x00004447
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FinishedRequest_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FinishedRequest_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeFieldInfoPtr_PchPageTitle;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

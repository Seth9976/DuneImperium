using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018E RID: 398
	public sealed class HTML_NewWindow_t : ValueType
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x00069378 File Offset: 0x00067578
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_NewWindow_t()
		{
			Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_NewWindow_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr);
			HTML_NewWindow_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_NewWindow_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "PchURL");
			HTML_NewWindow_t.NativeFieldInfoPtr_UnX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnX");
			HTML_NewWindow_t.NativeFieldInfoPtr_UnY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnY");
			HTML_NewWindow_t.NativeFieldInfoPtr_UnWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnWide");
			HTML_NewWindow_t.NativeFieldInfoPtr_UnTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnTall");
			HTML_NewWindow_t.NativeFieldInfoPtr_UnNewWindow_BrowserHandle_IGNORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "UnNewWindow_BrowserHandle_IGNORE");
			HTML_NewWindow_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, "_datasize");
			HTML_NewWindow_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, 100667266);
			HTML_NewWindow_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr, 100667267);
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00069470 File Offset: 0x00067670
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950891, XrefRangeEnd = 950895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_NewWindow_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000694B4 File Offset: 0x000676B4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_NewWindow_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000065B2 File Offset: 0x000047B2
		public HTML_NewWindow_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000065BB File Offset: 0x000047BB
		public HTML_NewWindow_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_NewWindow_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x000694F8 File Offset: 0x000676F8
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x000065CD File Offset: 0x000047CD
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00069520 File Offset: 0x00067720
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x000065E8 File Offset: 0x000047E8
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00069548 File Offset: 0x00067748
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x00006607 File Offset: 0x00004807
		public unsafe uint UnX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnX)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00069570 File Offset: 0x00067770
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00006622 File Offset: 0x00004822
		public unsafe uint UnY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnY)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00069598 File Offset: 0x00067798
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0000663D File Offset: 0x0000483D
		public unsafe uint UnWide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnWide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnWide)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x000695C0 File Offset: 0x000677C0
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00006658 File Offset: 0x00004858
		public unsafe uint UnTall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnTall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnTall)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x000695E8 File Offset: 0x000677E8
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00006673 File Offset: 0x00004873
		public unsafe uint UnNewWindow_BrowserHandle_IGNORE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnNewWindow_BrowserHandle_IGNORE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_NewWindow_t.NativeFieldInfoPtr_UnNewWindow_BrowserHandle_IGNORE)) = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00069610 File Offset: 0x00067810
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0000668E File Offset: 0x0000488E
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_NewWindow_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_NewWindow_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr_UnX;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr_UnY;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr_UnWide;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_UnTall;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_UnNewWindow_BrowserHandle_IGNORE;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

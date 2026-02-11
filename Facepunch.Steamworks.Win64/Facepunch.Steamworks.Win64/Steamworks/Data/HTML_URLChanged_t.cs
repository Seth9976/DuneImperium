using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000182 RID: 386
	public sealed class HTML_URLChanged_t : ValueType
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x00067FD8 File Offset: 0x000661D8
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_URLChanged_t()
		{
			Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_URLChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr);
			HTML_URLChanged_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_URLChanged_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "PchURL");
			HTML_URLChanged_t.NativeFieldInfoPtr_PchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "PchPostData");
			HTML_URLChanged_t.NativeFieldInfoPtr_BIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "BIsRedirect");
			HTML_URLChanged_t.NativeFieldInfoPtr_PchPageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "PchPageTitle");
			HTML_URLChanged_t.NativeFieldInfoPtr_BNewNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "BNewNavigation");
			HTML_URLChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, "_datasize");
			HTML_URLChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, 100667230);
			HTML_URLChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr, 100667231);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x000680BC File Offset: 0x000662BC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950843, XrefRangeEnd = 950847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_URLChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00068100 File Offset: 0x00066300
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_URLChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000060FC File Offset: 0x000042FC
		public HTML_URLChanged_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00006105 File Offset: 0x00004305
		public HTML_URLChanged_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_URLChanged_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00068144 File Offset: 0x00066344
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00006117 File Offset: 0x00004317
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0006816C File Offset: 0x0006636C
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00006132 File Offset: 0x00004332
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00068194 File Offset: 0x00066394
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00006151 File Offset: 0x00004351
		public unsafe string PchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x000681BC File Offset: 0x000663BC
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00006170 File Offset: 0x00004370
		public unsafe bool BIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_BIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_BIsRedirect)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x000681E4 File Offset: 0x000663E4
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0000618B File Offset: 0x0000438B
		public unsafe string PchPageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchPageTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_PchPageTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0006820C File Offset: 0x0006640C
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x000061AA File Offset: 0x000043AA
		public unsafe bool BNewNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_BNewNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_URLChanged_t.NativeFieldInfoPtr_BNewNavigation)) = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00068234 File Offset: 0x00066434
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x000061C5 File Offset: 0x000043C5
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_URLChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_URLChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeFieldInfoPtr_PchPostData;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeFieldInfoPtr_BIsRedirect;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeFieldInfoPtr_PchPageTitle;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeFieldInfoPtr_BNewNavigation;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000184 RID: 388
	public sealed class HTML_OpenLinkInNewTab_t : ValueType
	{
		// Token: 0x060013A4 RID: 5028 RVA: 0x00068414 File Offset: 0x00066614
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_OpenLinkInNewTab_t()
		{
			Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_OpenLinkInNewTab_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr);
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "PchURL");
			HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, "_datasize");
			HTML_OpenLinkInNewTab_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, 100667236);
			HTML_OpenLinkInNewTab_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr, 100667237);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x000684A8 File Offset: 0x000666A8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950851, XrefRangeEnd = 950855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_OpenLinkInNewTab_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000684EC File Offset: 0x000666EC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_OpenLinkInNewTab_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00006255 File Offset: 0x00004455
		public HTML_OpenLinkInNewTab_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0000625E File Offset: 0x0000445E
		public HTML_OpenLinkInNewTab_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_OpenLinkInNewTab_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00068530 File Offset: 0x00066730
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00006270 File Offset: 0x00004470
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00068558 File Offset: 0x00066758
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x0000628B File Offset: 0x0000448B
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00068580 File Offset: 0x00066780
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x000062AA File Offset: 0x000044AA
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_OpenLinkInNewTab_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

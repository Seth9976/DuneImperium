using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000185 RID: 389
	public sealed class HTML_ChangedTitle_t : ValueType
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x0006859C File Offset: 0x0006679C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ChangedTitle_t()
		{
			Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_ChangedTitle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr);
			HTML_ChangedTitle_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_ChangedTitle_t.NativeFieldInfoPtr_PchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "PchTitle");
			HTML_ChangedTitle_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, "_datasize");
			HTML_ChangedTitle_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, 100667239);
			HTML_ChangedTitle_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr, 100667240);
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00068630 File Offset: 0x00066830
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950855, XrefRangeEnd = 950859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_ChangedTitle_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00068674 File Offset: 0x00066874
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_ChangedTitle_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000062B8 File Offset: 0x000044B8
		public HTML_ChangedTitle_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000062C1 File Offset: 0x000044C1
		public HTML_ChangedTitle_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ChangedTitle_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x000686B8 File Offset: 0x000668B8
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x000062D3 File Offset: 0x000044D3
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000686E0 File Offset: 0x000668E0
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x000062EE File Offset: 0x000044EE
		public unsafe string PchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_PchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ChangedTitle_t.NativeFieldInfoPtr_PchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00068708 File Offset: 0x00066908
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0000630D File Offset: 0x0000450D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ChangedTitle_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ChangedTitle_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_PchTitle;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000188 RID: 392
	[StructLayout(2)]
	public struct HTML_HorizontalScroll_t
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0006896C File Offset: 0x00066B6C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HorizontalScroll_t()
		{
			Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_HorizontalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr);
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_UnScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "UnScrollMax");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_UnScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "UnScrollCurrent");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_FlPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "FlPageScale");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_BVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "BVisible");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr_UnPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "UnPageSize");
			HTML_HorizontalScroll_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, "_datasize");
			HTML_HorizontalScroll_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, 100667248);
			HTML_HorizontalScroll_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, 100667249);
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00068A50 File Offset: 0x00066C50
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950867, XrefRangeEnd = 950871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_HorizontalScroll_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00068A80 File Offset: 0x00066C80
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_HorizontalScroll_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000635B File Offset: 0x0000455B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HorizontalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00068AB0 File Offset: 0x00066CB0
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000636D File Offset: 0x0000456D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HorizontalScroll_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollMax;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollCurrent;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_FlPageScale;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_BVisible;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeFieldInfoPtr_UnPageSize;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040019CC RID: 6604
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x040019CD RID: 6605
		[FieldOffset(4)]
		public uint UnScrollMax;

		// Token: 0x040019CE RID: 6606
		[FieldOffset(8)]
		public uint UnScrollCurrent;

		// Token: 0x040019CF RID: 6607
		[FieldOffset(12)]
		public float FlPageScale;

		// Token: 0x040019D0 RID: 6608
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool BVisible;

		// Token: 0x040019D1 RID: 6609
		[FieldOffset(20)]
		public uint UnPageSize;
	}
}

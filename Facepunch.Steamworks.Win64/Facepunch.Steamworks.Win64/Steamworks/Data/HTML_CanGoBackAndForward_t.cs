using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000187 RID: 391
	[StructLayout(2)]
	public struct HTML_CanGoBackAndForward_t
	{
		// Token: 0x060013C0 RID: 5056 RVA: 0x00068848 File Offset: 0x00066A48
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CanGoBackAndForward_t()
		{
			Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_CanGoBackAndForward_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr);
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_BCanGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "BCanGoBack");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr_BCanGoForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "BCanGoForward");
			HTML_CanGoBackAndForward_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, "_datasize");
			HTML_CanGoBackAndForward_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, 100667245);
			HTML_CanGoBackAndForward_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, 100667246);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x000688F0 File Offset: 0x00066AF0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950863, XrefRangeEnd = 950867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_CanGoBackAndForward_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00068920 File Offset: 0x00066B20
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_CanGoBackAndForward_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0000633B File Offset: 0x0000453B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CanGoBackAndForward_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00068950 File Offset: 0x00066B50
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000634D File Offset: 0x0000454D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CanGoBackAndForward_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr_BCanGoBack;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr_BCanGoForward;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040019C0 RID: 6592
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x040019C1 RID: 6593
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool BCanGoBack;

		// Token: 0x040019C2 RID: 6594
		[FieldOffset(5)]
		[MarshalAs(4)]
		public bool BCanGoForward;
	}
}

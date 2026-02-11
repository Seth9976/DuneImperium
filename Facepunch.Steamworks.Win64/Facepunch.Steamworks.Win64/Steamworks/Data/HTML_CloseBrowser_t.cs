using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000181 RID: 385
	[StructLayout(2)]
	public struct HTML_CloseBrowser_t
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x00067EDC File Offset: 0x000660DC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_CloseBrowser_t()
		{
			Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_CloseBrowser_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr);
			HTML_CloseBrowser_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_CloseBrowser_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, "_datasize");
			HTML_CloseBrowser_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, 100667227);
			HTML_CloseBrowser_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, 100667228);
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00067F5C File Offset: 0x0006615C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950839, XrefRangeEnd = 950843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_CloseBrowser_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00067F8C File Offset: 0x0006618C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_CloseBrowser_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000060DC File Offset: 0x000042DC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_CloseBrowser_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00067FBC File Offset: 0x000661BC
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x000060EE File Offset: 0x000042EE
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_CloseBrowser_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_CloseBrowser_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001997 RID: 6551
		[FieldOffset(0)]
		public uint UnBrowserHandle;
	}
}

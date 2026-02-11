using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017E RID: 382
	[StructLayout(2)]
	public struct HTML_BrowserReady_t
	{
		// Token: 0x06001348 RID: 4936 RVA: 0x000677C4 File Offset: 0x000659C4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserReady_t()
		{
			Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_BrowserReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr);
			HTML_BrowserReady_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_BrowserReady_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, "_datasize");
			HTML_BrowserReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, 100667218);
			HTML_BrowserReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, 100667219);
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00067844 File Offset: 0x00065A44
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950827, XrefRangeEnd = 950831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_BrowserReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00067874 File Offset: 0x00065A74
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_BrowserReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00005E8F File Offset: 0x0000408F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000678A4 File Offset: 0x00065AA4
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00005EA1 File Offset: 0x000040A1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserReady_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserReady_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400197B RID: 6523
		[FieldOffset(0)]
		public uint UnBrowserHandle;
	}
}

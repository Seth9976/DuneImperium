using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000194 RID: 404
	[StructLayout(2)]
	public struct HTML_BrowserRestarted_t
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x00069CD0 File Offset: 0x00067ED0
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_BrowserRestarted_t()
		{
			Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_BrowserRestarted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr);
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr_UnOldBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "UnOldBrowserHandle");
			HTML_BrowserRestarted_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, "_datasize");
			HTML_BrowserRestarted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, 100667284);
			HTML_BrowserRestarted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, 100667285);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x00069D64 File Offset: 0x00067F64
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950915, XrefRangeEnd = 950919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_BrowserRestarted_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00069D94 File Offset: 0x00067F94
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_BrowserRestarted_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00006805 File Offset: 0x00004A05
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_BrowserRestarted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00069DC4 File Offset: 0x00067FC4
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00006817 File Offset: 0x00004A17
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_BrowserRestarted_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_UnOldBrowserHandle;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A24 RID: 6692
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x04001A25 RID: 6693
		[FieldOffset(4)]
		public uint UnOldBrowserHandle;
	}
}

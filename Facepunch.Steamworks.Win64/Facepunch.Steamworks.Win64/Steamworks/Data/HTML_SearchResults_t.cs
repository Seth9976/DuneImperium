using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000186 RID: 390
	[StructLayout(2)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x060013BA RID: 5050 RVA: 0x00068724 File Offset: 0x00066924
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SearchResults_t()
		{
			Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_SearchResults_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr);
			HTML_SearchResults_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_SearchResults_t.NativeFieldInfoPtr_UnResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "UnResults");
			HTML_SearchResults_t.NativeFieldInfoPtr_UnCurrentMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "UnCurrentMatch");
			HTML_SearchResults_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, "_datasize");
			HTML_SearchResults_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, 100667242);
			HTML_SearchResults_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, 100667243);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000687CC File Offset: 0x000669CC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950859, XrefRangeEnd = 950863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_SearchResults_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x000687FC File Offset: 0x000669FC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_SearchResults_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0000631B File Offset: 0x0000451B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SearchResults_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0006882C File Offset: 0x00066A2C
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0000632D File Offset: 0x0000452D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SearchResults_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SearchResults_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeFieldInfoPtr_UnResults;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr_UnCurrentMatch;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040019B7 RID: 6583
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x040019B8 RID: 6584
		[FieldOffset(4)]
		public uint UnResults;

		// Token: 0x040019B9 RID: 6585
		[FieldOffset(8)]
		public uint UnCurrentMatch;
	}
}

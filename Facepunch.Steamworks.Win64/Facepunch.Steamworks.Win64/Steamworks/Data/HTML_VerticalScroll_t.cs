using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000189 RID: 393
	[StructLayout(2)]
	public struct HTML_VerticalScroll_t
	{
		// Token: 0x060013CC RID: 5068 RVA: 0x00068ACC File Offset: 0x00066CCC
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_VerticalScroll_t()
		{
			Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_VerticalScroll_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr);
			HTML_VerticalScroll_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_UnScrollMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "UnScrollMax");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_UnScrollCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "UnScrollCurrent");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_FlPageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "FlPageScale");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_BVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "BVisible");
			HTML_VerticalScroll_t.NativeFieldInfoPtr_UnPageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "UnPageSize");
			HTML_VerticalScroll_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, "_datasize");
			HTML_VerticalScroll_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, 100667251);
			HTML_VerticalScroll_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, 100667252);
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00068BB0 File Offset: 0x00066DB0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950871, XrefRangeEnd = 950875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_VerticalScroll_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00068BE0 File Offset: 0x00066DE0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_VerticalScroll_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000637B File Offset: 0x0000457B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_VerticalScroll_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00068C10 File Offset: 0x00066E10
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0000638D File Offset: 0x0000458D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_VerticalScroll_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_VerticalScroll_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollMax;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_UnScrollCurrent;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_FlPageScale;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_BVisible;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_UnPageSize;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040019DB RID: 6619
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x040019DC RID: 6620
		[FieldOffset(4)]
		public uint UnScrollMax;

		// Token: 0x040019DD RID: 6621
		[FieldOffset(8)]
		public uint UnScrollCurrent;

		// Token: 0x040019DE RID: 6622
		[FieldOffset(12)]
		public float FlPageScale;

		// Token: 0x040019DF RID: 6623
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool BVisible;

		// Token: 0x040019E0 RID: 6624
		[FieldOffset(20)]
		public uint UnPageSize;
	}
}

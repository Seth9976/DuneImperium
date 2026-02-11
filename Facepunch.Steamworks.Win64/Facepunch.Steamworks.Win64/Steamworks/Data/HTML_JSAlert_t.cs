using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018B RID: 395
	public sealed class HTML_JSAlert_t : ValueType
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x00068EA4 File Offset: 0x000670A4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSAlert_t()
		{
			Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_JSAlert_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr);
			HTML_JSAlert_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_JSAlert_t.NativeFieldInfoPtr_PchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "PchMessage");
			HTML_JSAlert_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, "_datasize");
			HTML_JSAlert_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, 100667257);
			HTML_JSAlert_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr, 100667258);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00068F38 File Offset: 0x00067138
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950879, XrefRangeEnd = 950883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_JSAlert_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00068F7C File Offset: 0x0006717C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_JSAlert_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0000646A File Offset: 0x0000466A
		public HTML_JSAlert_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00006473 File Offset: 0x00004673
		public HTML_JSAlert_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSAlert_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00068FC0 File Offset: 0x000671C0
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00068FE8 File Offset: 0x000671E8
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x000064A0 File Offset: 0x000046A0
		public unsafe string PchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_PchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSAlert_t.NativeFieldInfoPtr_PchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00069010 File Offset: 0x00067210
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x000064BF File Offset: 0x000046BF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSAlert_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSAlert_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_PchMessage;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

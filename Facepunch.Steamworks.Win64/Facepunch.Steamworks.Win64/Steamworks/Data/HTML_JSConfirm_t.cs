using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018C RID: 396
	public sealed class HTML_JSConfirm_t : ValueType
	{
		// Token: 0x060013F0 RID: 5104 RVA: 0x0006902C File Offset: 0x0006722C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_JSConfirm_t()
		{
			Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_JSConfirm_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr);
			HTML_JSConfirm_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_JSConfirm_t.NativeFieldInfoPtr_PchMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "PchMessage");
			HTML_JSConfirm_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, "_datasize");
			HTML_JSConfirm_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, 100667260);
			HTML_JSConfirm_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr, 100667261);
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x000690C0 File Offset: 0x000672C0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950883, XrefRangeEnd = 950887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_JSConfirm_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00069104 File Offset: 0x00067304
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_JSConfirm_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000064CD File Offset: 0x000046CD
		public HTML_JSConfirm_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000064D6 File Offset: 0x000046D6
		public HTML_JSConfirm_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_JSConfirm_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00069148 File Offset: 0x00067348
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x000064E8 File Offset: 0x000046E8
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00069170 File Offset: 0x00067370
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00006503 File Offset: 0x00004703
		public unsafe string PchMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_PchMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_JSConfirm_t.NativeFieldInfoPtr_PchMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00069198 File Offset: 0x00067398
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x00006522 File Offset: 0x00004722
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_JSConfirm_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_JSConfirm_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr_PchMessage;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000190 RID: 400
	public sealed class HTML_StatusText_t : ValueType
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x0006973C File Offset: 0x0006793C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StatusText_t()
		{
			Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_StatusText_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr);
			HTML_StatusText_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_StatusText_t.NativeFieldInfoPtr_PchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "PchMsg");
			HTML_StatusText_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, "_datasize");
			HTML_StatusText_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, 100667272);
			HTML_StatusText_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr, 100667273);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000697D0 File Offset: 0x000679D0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950899, XrefRangeEnd = 950903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_StatusText_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x00069814 File Offset: 0x00067A14
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_StatusText_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000066BC File Offset: 0x000048BC
		public HTML_StatusText_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000066C5 File Offset: 0x000048C5
		public HTML_StatusText_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StatusText_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00069858 File Offset: 0x00067A58
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x000066D7 File Offset: 0x000048D7
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00069880 File Offset: 0x00067A80
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x000066F2 File Offset: 0x000048F2
		public unsafe string PchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_PchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StatusText_t.NativeFieldInfoPtr_PchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x000698A8 File Offset: 0x00067AA8
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00006711 File Offset: 0x00004911
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StatusText_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StatusText_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr_PchMsg;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000191 RID: 401
	public sealed class HTML_ShowToolTip_t : ValueType
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x000698C4 File Offset: 0x00067AC4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_ShowToolTip_t()
		{
			Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_ShowToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr);
			HTML_ShowToolTip_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_ShowToolTip_t.NativeFieldInfoPtr_PchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "PchMsg");
			HTML_ShowToolTip_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, "_datasize");
			HTML_ShowToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, 100667275);
			HTML_ShowToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr, 100667276);
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00069958 File Offset: 0x00067B58
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950903, XrefRangeEnd = 950907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_ShowToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0006999C File Offset: 0x00067B9C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_ShowToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0000671F File Offset: 0x0000491F
		public HTML_ShowToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00006728 File Offset: 0x00004928
		public HTML_ShowToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_ShowToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000699E0 File Offset: 0x00067BE0
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0000673A File Offset: 0x0000493A
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00069A08 File Offset: 0x00067C08
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x00006755 File Offset: 0x00004955
		public unsafe string PchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_PchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_ShowToolTip_t.NativeFieldInfoPtr_PchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00069A30 File Offset: 0x00067C30
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00006774 File Offset: 0x00004974
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_ShowToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_ShowToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_PchMsg;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000192 RID: 402
	public sealed class HTML_UpdateToolTip_t : ValueType
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x00069A4C File Offset: 0x00067C4C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_UpdateToolTip_t()
		{
			Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_UpdateToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr);
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr_PchMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "PchMsg");
			HTML_UpdateToolTip_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, "_datasize");
			HTML_UpdateToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, 100667278);
			HTML_UpdateToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr, 100667279);
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00069AE0 File Offset: 0x00067CE0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950907, XrefRangeEnd = 950911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_UpdateToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00069B24 File Offset: 0x00067D24
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_UpdateToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00006782 File Offset: 0x00004982
		public HTML_UpdateToolTip_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000678B File Offset: 0x0000498B
		public HTML_UpdateToolTip_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_UpdateToolTip_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00069B68 File Offset: 0x00067D68
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000679D File Offset: 0x0000499D
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00069B90 File Offset: 0x00067D90
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x000067B8 File Offset: 0x000049B8
		public unsafe string PchMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_PchMsg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_UpdateToolTip_t.NativeFieldInfoPtr_PchMsg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00069BB8 File Offset: 0x00067DB8
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x000067D7 File Offset: 0x000049D7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_UpdateToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr_PchMsg;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

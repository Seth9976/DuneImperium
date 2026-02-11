using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000193 RID: 403
	[StructLayout(2)]
	public struct HTML_HideToolTip_t
	{
		// Token: 0x06001444 RID: 5188 RVA: 0x00069BD4 File Offset: 0x00067DD4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_HideToolTip_t()
		{
			Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_HideToolTip_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr);
			HTML_HideToolTip_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_HideToolTip_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, "_datasize");
			HTML_HideToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, 100667281);
			HTML_HideToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, 100667282);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00069C54 File Offset: 0x00067E54
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950911, XrefRangeEnd = 950915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_HideToolTip_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00069C84 File Offset: 0x00067E84
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_HideToolTip_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000067E5 File Offset: 0x000049E5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_HideToolTip_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00069CB4 File Offset: 0x00067EB4
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x000067F7 File Offset: 0x000049F7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_HideToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_HideToolTip_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A1E RID: 6686
		[FieldOffset(0)]
		public uint UnBrowserHandle;
	}
}

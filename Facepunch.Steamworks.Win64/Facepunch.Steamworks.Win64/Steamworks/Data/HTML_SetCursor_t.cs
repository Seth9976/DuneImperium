using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018F RID: 399
	[StructLayout(2)]
	public struct HTML_SetCursor_t
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x0006962C File Offset: 0x0006782C
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_SetCursor_t()
		{
			Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_SetCursor_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr);
			HTML_SetCursor_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_SetCursor_t.NativeFieldInfoPtr_EMouseCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "EMouseCursor");
			HTML_SetCursor_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, "_datasize");
			HTML_SetCursor_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, 100667269);
			HTML_SetCursor_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, 100667270);
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000696C0 File Offset: 0x000678C0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950895, XrefRangeEnd = 950899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_SetCursor_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000696F0 File Offset: 0x000678F0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_SetCursor_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0000669C File Offset: 0x0000489C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTML_SetCursor_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00069720 File Offset: 0x00067920
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000066AE File Offset: 0x000048AE
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_SetCursor_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_SetCursor_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr_EMouseCursor;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A09 RID: 6665
		[FieldOffset(0)]
		public uint UnBrowserHandle;

		// Token: 0x04001A0A RID: 6666
		[FieldOffset(4)]
		public uint EMouseCursor;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000152 RID: 338
	[StructLayout(2)]
	public struct ScreenshotRequested_t
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00064608 File Offset: 0x00062808
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotRequested_t()
		{
			Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ScreenshotRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr);
			ScreenshotRequested_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, "_datasize");
			ScreenshotRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, 100667085);
			ScreenshotRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, 100667086);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00064674 File Offset: 0x00062874
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950643, XrefRangeEnd = 950647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000646A4 File Offset: 0x000628A4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0000577A File Offset: 0x0000397A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000646D4 File Offset: 0x000628D4
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000578C File Offset: 0x0000398C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotRequested_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotRequested_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

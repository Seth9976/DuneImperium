using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000151 RID: 337
	[StructLayout(2)]
	public struct ScreenshotReady_t
	{
		// Token: 0x0600121C RID: 4636 RVA: 0x000644F8 File Offset: 0x000626F8
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotReady_t()
		{
			Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ScreenshotReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr);
			ScreenshotReady_t.NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "Local");
			ScreenshotReady_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "Result");
			ScreenshotReady_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, "_datasize");
			ScreenshotReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, 100667082);
			ScreenshotReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, 100667083);
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0006458C File Offset: 0x0006278C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950639, XrefRangeEnd = 950643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000645BC File Offset: 0x000627BC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0000575A File Offset: 0x0000395A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x000645EC File Offset: 0x000627EC
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000576C File Offset: 0x0000396C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotReady_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotReady_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeFieldInfoPtr_Local;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400184B RID: 6219
		[FieldOffset(0)]
		public uint Local;

		// Token: 0x0400184C RID: 6220
		[FieldOffset(4)]
		public Result Result;
	}
}

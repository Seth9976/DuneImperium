using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000173 RID: 371
	[StructLayout(2)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x060012FB RID: 4859 RVA: 0x00066A68 File Offset: 0x00064C68
		// Note: this type is marked as 'beforefieldinit'.
		static StopPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "StopPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr);
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "Result");
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "_datasize");
			StopPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, 100667185);
			StopPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, 100667186);
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00066AE8 File Offset: 0x00064CE8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950779, XrefRangeEnd = 950783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00066B18 File Offset: 0x00064D18
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00005C9B File Offset: 0x00003E9B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00066B48 File Offset: 0x00064D48
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00005CAD File Offset: 0x00003EAD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001921 RID: 6433
		[FieldOffset(0)]
		public Result Result;
	}
}

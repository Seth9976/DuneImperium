using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000172 RID: 370
	[StructLayout(2)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x060012F5 RID: 4853 RVA: 0x0006696C File Offset: 0x00064B6C
		// Note: this type is marked as 'beforefieldinit'.
		static StartPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "StartPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr);
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "Result");
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "_datasize");
			StartPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, 100667182);
			StartPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, 100667183);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x000669EC File Offset: 0x00064BEC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950775, XrefRangeEnd = 950779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00066A1C File Offset: 0x00064C1C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartPlaytimeTrackingResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00005C7B File Offset: 0x00003E7B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00066A4C File Offset: 0x00064C4C
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00005C8D File Offset: 0x00003E8D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400191C RID: 6428
		[FieldOffset(0)]
		public Result Result;
	}
}

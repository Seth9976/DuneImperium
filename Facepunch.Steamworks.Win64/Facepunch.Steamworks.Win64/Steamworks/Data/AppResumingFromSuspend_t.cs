using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000109 RID: 265
	[StructLayout(2)]
	public struct AppResumingFromSuspend_t
	{
		// Token: 0x06000FBA RID: 4026 RVA: 0x0005DFB4 File Offset: 0x0005C1B4
		// Note: this type is marked as 'beforefieldinit'.
		static AppResumingFromSuspend_t()
		{
			Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AppResumingFromSuspend_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr);
			AppResumingFromSuspend_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr, "_datasize");
			AppResumingFromSuspend_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr, 100666855);
			AppResumingFromSuspend_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr, 100666856);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0005E020 File Offset: 0x0005C220
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950303, XrefRangeEnd = 950307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppResumingFromSuspend_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0005E050 File Offset: 0x0005C250
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppResumingFromSuspend_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00004576 File Offset: 0x00002776
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AppResumingFromSuspend_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0005E080 File Offset: 0x0005C280
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00004588 File Offset: 0x00002788
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AppResumingFromSuspend_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppResumingFromSuspend_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000123 RID: 291
	[StructLayout(2)]
	public struct ActiveBeaconsUpdated_t
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x0005FE90 File Offset: 0x0005E090
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveBeaconsUpdated_t()
		{
			Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ActiveBeaconsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr);
			ActiveBeaconsUpdated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, "_datasize");
			ActiveBeaconsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, 100666934);
			ActiveBeaconsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, 100666935);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0005FEFC File Offset: 0x0005E0FC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950412, XrefRangeEnd = 950416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveBeaconsUpdated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0005FF2C File Offset: 0x0005E12C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 950416, RefRangeEnd = 950417, XrefRangeStart = 950416, XrefRangeEnd = 950416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveBeaconsUpdated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0000492F File Offset: 0x00002B2F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0005FF5C File Offset: 0x0005E15C
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00004941 File Offset: 0x00002B41
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveBeaconsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveBeaconsUpdated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

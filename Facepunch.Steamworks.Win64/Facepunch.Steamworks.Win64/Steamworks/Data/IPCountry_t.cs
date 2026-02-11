using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000103 RID: 259
	[StructLayout(2)]
	public struct IPCountry_t
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x0005D9B8 File Offset: 0x0005BBB8
		// Note: this type is marked as 'beforefieldinit'.
		static IPCountry_t()
		{
			Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "IPCountry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr);
			IPCountry_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, "_datasize");
			IPCountry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, 100666837);
			IPCountry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, 100666838);
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0005DA24 File Offset: 0x0005BC24
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950279, XrefRangeEnd = 950283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPCountry_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0005DA54 File Offset: 0x0005BC54
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPCountry_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000044B6 File Offset: 0x000026B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0005DA84 File Offset: 0x0005BC84
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x000044C8 File Offset: 0x000026C8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCountry_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCountry_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

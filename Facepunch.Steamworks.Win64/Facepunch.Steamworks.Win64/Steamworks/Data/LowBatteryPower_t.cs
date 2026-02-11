using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000104 RID: 260
	[StructLayout(2)]
	public struct LowBatteryPower_t
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x0005DAA0 File Offset: 0x0005BCA0
		// Note: this type is marked as 'beforefieldinit'.
		static LowBatteryPower_t()
		{
			Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LowBatteryPower_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr);
			LowBatteryPower_t.NativeFieldInfoPtr_MinutesBatteryLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "MinutesBatteryLeft");
			LowBatteryPower_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "_datasize");
			LowBatteryPower_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, 100666840);
			LowBatteryPower_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, 100666841);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0005DB20 File Offset: 0x0005BD20
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950283, XrefRangeEnd = 950287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowBatteryPower_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0005DB50 File Offset: 0x0005BD50
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowBatteryPower_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000044D6 File Offset: 0x000026D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0005DB80 File Offset: 0x0005BD80
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000044E8 File Offset: 0x000026E8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LowBatteryPower_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowBatteryPower_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_MinutesBatteryLeft;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015CD RID: 5581
		[FieldOffset(0)]
		public byte MinutesBatteryLeft;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000120 RID: 288
	[StructLayout(2)]
	public struct ReservationNotificationCallback_t
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x0005FB9C File Offset: 0x0005DD9C
		// Note: this type is marked as 'beforefieldinit'.
		static ReservationNotificationCallback_t()
		{
			Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ReservationNotificationCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr);
			ReservationNotificationCallback_t.NativeFieldInfoPtr_BeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "BeaconID");
			ReservationNotificationCallback_t.NativeFieldInfoPtr_SteamIDJoiner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "SteamIDJoiner");
			ReservationNotificationCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "_datasize");
			ReservationNotificationCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, 100666925);
			ReservationNotificationCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, 100666926);
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0005FC30 File Offset: 0x0005DE30
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950400, XrefRangeEnd = 950404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReservationNotificationCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0005FC60 File Offset: 0x0005DE60
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReservationNotificationCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000048CF File Offset: 0x00002ACF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0005FC90 File Offset: 0x0005DE90
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000048E1 File Offset: 0x00002AE1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReservationNotificationCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReservationNotificationCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_BeaconID;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDJoiner;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016C5 RID: 5829
		[FieldOffset(0)]
		public ulong BeaconID;

		// Token: 0x040016C6 RID: 5830
		[FieldOffset(8)]
		public ulong SteamIDJoiner;
	}
}

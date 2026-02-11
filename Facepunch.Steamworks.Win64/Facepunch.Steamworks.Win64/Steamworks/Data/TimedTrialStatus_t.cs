using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct TimedTrialStatus_t
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x000641B4 File Offset: 0x000623B4
		// Note: this type is marked as 'beforefieldinit'.
		static TimedTrialStatus_t()
		{
			Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "TimedTrialStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr);
			TimedTrialStatus_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "AppID");
			TimedTrialStatus_t.NativeFieldInfoPtr_IsOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "IsOffline");
			TimedTrialStatus_t.NativeFieldInfoPtr_SecondsAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "SecondsAllowed");
			TimedTrialStatus_t.NativeFieldInfoPtr_SecondsPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "SecondsPlayed");
			TimedTrialStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "_datasize");
			TimedTrialStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, 100667073);
			TimedTrialStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, 100667074);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00064270 File Offset: 0x00062470
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950627, XrefRangeEnd = 950631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedTrialStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000642A0 File Offset: 0x000624A0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedTrialStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000056FA File Offset: 0x000038FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000642D0 File Offset: 0x000624D0
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000570C File Offset: 0x0000390C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimedTrialStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimedTrialStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr_IsOffline;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr_SecondsAllowed;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr_SecondsPlayed;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001836 RID: 6198
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x04001837 RID: 6199
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool IsOffline;

		// Token: 0x04001838 RID: 6200
		[FieldOffset(8)]
		public uint SecondsAllowed;

		// Token: 0x04001839 RID: 6201
		[FieldOffset(12)]
		public uint SecondsPlayed;
	}
}

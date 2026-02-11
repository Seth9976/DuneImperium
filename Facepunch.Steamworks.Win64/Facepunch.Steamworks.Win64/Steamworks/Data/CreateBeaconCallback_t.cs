using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011F RID: 287
	[StructLayout(2)]
	public struct CreateBeaconCallback_t
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x0005FA8C File Offset: 0x0005DC8C
		// Note: this type is marked as 'beforefieldinit'.
		static CreateBeaconCallback_t()
		{
			Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "CreateBeaconCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr);
			CreateBeaconCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "Result");
			CreateBeaconCallback_t.NativeFieldInfoPtr_BeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "BeaconID");
			CreateBeaconCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "_datasize");
			CreateBeaconCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, 100666922);
			CreateBeaconCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, 100666923);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0005FB20 File Offset: 0x0005DD20
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950396, XrefRangeEnd = 950400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateBeaconCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0005FB50 File Offset: 0x0005DD50
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateBeaconCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x000048AF File Offset: 0x00002AAF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0005FB80 File Offset: 0x0005DD80
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x000048C1 File Offset: 0x00002AC1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CreateBeaconCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateBeaconCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_BeaconID;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040016BE RID: 5822
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040016BF RID: 5823
		[FieldOffset(8)]
		public ulong BeaconID;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000115 RID: 277
	[StructLayout(2)]
	public struct PSNGameBootInviteResult_t
	{
		// Token: 0x06001002 RID: 4098 RVA: 0x0005ED50 File Offset: 0x0005CF50
		// Note: this type is marked as 'beforefieldinit'.
		static PSNGameBootInviteResult_t()
		{
			Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PSNGameBootInviteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr);
			PSNGameBootInviteResult_t.NativeFieldInfoPtr_GameBootInviteExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, "GameBootInviteExists");
			PSNGameBootInviteResult_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, "SteamIDLobby");
			PSNGameBootInviteResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, "_datasize");
			PSNGameBootInviteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, 100666891);
			PSNGameBootInviteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, 100666892);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950351, XrefRangeEnd = 950355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PSNGameBootInviteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0005EE14 File Offset: 0x0005D014
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PSNGameBootInviteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000046F6 File Offset: 0x000028F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PSNGameBootInviteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0005EE44 File Offset: 0x0005D044
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00004708 File Offset: 0x00002908
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PSNGameBootInviteResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PSNGameBootInviteResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_GameBootInviteExists;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001655 RID: 5717
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool GameBootInviteExists;

		// Token: 0x04001656 RID: 5718
		[FieldOffset(4)]
		public ulong SteamIDLobby;
	}
}

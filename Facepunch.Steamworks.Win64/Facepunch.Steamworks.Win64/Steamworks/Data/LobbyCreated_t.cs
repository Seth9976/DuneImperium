using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000114 RID: 276
	[StructLayout(2)]
	public struct LobbyCreated_t
	{
		// Token: 0x06000FFC RID: 4092 RVA: 0x0005EC40 File Offset: 0x0005CE40
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyCreated_t()
		{
			Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr);
			LobbyCreated_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "Result");
			LobbyCreated_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "SteamIDLobby");
			LobbyCreated_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "_datasize");
			LobbyCreated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, 100666888);
			LobbyCreated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, 100666889);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0005ECD4 File Offset: 0x0005CED4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950347, XrefRangeEnd = 950351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyCreated_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0005ED04 File Offset: 0x0005CF04
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyCreated_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000046D6 File Offset: 0x000028D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0005ED34 File Offset: 0x0005CF34
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000046E8 File Offset: 0x000028E8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyCreated_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyCreated_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400164E RID: 5710
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400164F RID: 5711
		[FieldOffset(8)]
		public ulong SteamIDLobby;
	}
}

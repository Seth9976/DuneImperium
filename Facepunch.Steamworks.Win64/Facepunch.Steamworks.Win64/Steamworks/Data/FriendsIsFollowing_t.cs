using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FE RID: 254
	[StructLayout(2)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x06000F6B RID: 3947 RVA: 0x0005D2DC File Offset: 0x0005B4DC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsIsFollowing_t()
		{
			Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendsIsFollowing_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr);
			FriendsIsFollowing_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "Result");
			FriendsIsFollowing_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "SteamID");
			FriendsIsFollowing_t.NativeFieldInfoPtr_IsFollowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "IsFollowing");
			FriendsIsFollowing_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "_datasize");
			FriendsIsFollowing_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, 100666821);
			FriendsIsFollowing_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, 100666822);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0005D384 File Offset: 0x0005B584
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950254, XrefRangeEnd = 950258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsIsFollowing_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0005D3B4 File Offset: 0x0005B5B4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsIsFollowing_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00004375 File Offset: 0x00002575
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0005D3E4 File Offset: 0x0005B5E4
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00004387 File Offset: 0x00002587
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsIsFollowing_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsIsFollowing_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_IsFollowing;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015AB RID: 5547
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040015AC RID: 5548
		[FieldOffset(4)]
		public ulong SteamID;

		// Token: 0x040015AD RID: 5549
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool IsFollowing;
	}
}

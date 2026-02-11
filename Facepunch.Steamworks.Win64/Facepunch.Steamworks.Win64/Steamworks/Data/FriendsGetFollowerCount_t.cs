using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FD RID: 253
	[StructLayout(2)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x0005D1B8 File Offset: 0x0005B3B8
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGetFollowerCount_t()
		{
			Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendsGetFollowerCount_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr);
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "Result");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "SteamID");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "Count");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "_datasize");
			FriendsGetFollowerCount_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, 100666818);
			FriendsGetFollowerCount_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, 100666819);
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0005D260 File Offset: 0x0005B460
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950250, XrefRangeEnd = 950254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGetFollowerCount_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0005D290 File Offset: 0x0005B490
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGetFollowerCount_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00004355 File Offset: 0x00002555
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0005D2C0 File Offset: 0x0005B4C0
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00004367 File Offset: 0x00002567
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015A2 RID: 5538
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040015A3 RID: 5539
		[FieldOffset(4)]
		public ulong SteamID;

		// Token: 0x040015A4 RID: 5540
		[FieldOffset(12)]
		public int Count;
	}
}

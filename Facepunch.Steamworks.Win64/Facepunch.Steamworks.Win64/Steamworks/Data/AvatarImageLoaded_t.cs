using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F3 RID: 243
	[StructLayout(2)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImageLoaded_t()
		{
			Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AvatarImageLoaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr);
			AvatarImageLoaded_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "SteamID");
			AvatarImageLoaded_t.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "Image");
			AvatarImageLoaded_t.NativeFieldInfoPtr_Wide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "Wide");
			AvatarImageLoaded_t.NativeFieldInfoPtr_Tall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "Tall");
			AvatarImageLoaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "_datasize");
			AvatarImageLoaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, 100666787);
			AvatarImageLoaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, 100666788);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950205, XrefRangeEnd = 950209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImageLoaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarImageLoaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000041D2 File Offset: 0x000023D2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0005C700 File Offset: 0x0005A900
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x000041E4 File Offset: 0x000023E4
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AvatarImageLoaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarImageLoaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_Wide;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_Tall;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001554 RID: 5460
		[FieldOffset(0)]
		public ulong SteamID;

		// Token: 0x04001555 RID: 5461
		[FieldOffset(8)]
		public int Image;

		// Token: 0x04001556 RID: 5462
		[FieldOffset(12)]
		public int Wide;

		// Token: 0x04001557 RID: 5463
		[FieldOffset(16)]
		public int Tall;
	}
}

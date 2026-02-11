using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010B RID: 267
	[StructLayout(2)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x0005E184 File Offset: 0x0005C384
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListChanged_t()
		{
			Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FavoritesListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr);
			FavoritesListChanged_t.NativeFieldInfoPtr_IP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "IP");
			FavoritesListChanged_t.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "QueryPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_ConnPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "ConnPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "AppID");
			FavoritesListChanged_t.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "Flags");
			FavoritesListChanged_t.NativeFieldInfoPtr_Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "Add");
			FavoritesListChanged_t.NativeFieldInfoPtr_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "AccountId");
			FavoritesListChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "_datasize");
			FavoritesListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, 100666861);
			FavoritesListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, 100666862);
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0005E27C File Offset: 0x0005C47C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950311, XrefRangeEnd = 950315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FavoritesListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0005E2AC File Offset: 0x0005C4AC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FavoritesListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000045B6 File Offset: 0x000027B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0005E2DC File Offset: 0x0005C4DC
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_IP;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeFieldInfoPtr_QueryPort;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_ConnPort;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeFieldInfoPtr_Add;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeFieldInfoPtr_AccountId;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015F6 RID: 5622
		[FieldOffset(0)]
		public uint IP;

		// Token: 0x040015F7 RID: 5623
		[FieldOffset(4)]
		public uint QueryPort;

		// Token: 0x040015F8 RID: 5624
		[FieldOffset(8)]
		public uint ConnPort;

		// Token: 0x040015F9 RID: 5625
		[FieldOffset(12)]
		public uint AppID;

		// Token: 0x040015FA RID: 5626
		[FieldOffset(16)]
		public uint Flags;

		// Token: 0x040015FB RID: 5627
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool Add;

		// Token: 0x040015FC RID: 5628
		[FieldOffset(24)]
		public uint AccountId;
	}
}

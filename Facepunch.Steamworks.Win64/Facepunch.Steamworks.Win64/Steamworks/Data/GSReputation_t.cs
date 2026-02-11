using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AC RID: 428
	[StructLayout(2)]
	public struct GSReputation_t
	{
		// Token: 0x06001514 RID: 5396 RVA: 0x0006BD70 File Offset: 0x00069F70
		// Note: this type is marked as 'beforefieldinit'.
		static GSReputation_t()
		{
			Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSReputation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr);
			GSReputation_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "Result");
			GSReputation_t.NativeFieldInfoPtr_ReputationScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "ReputationScore");
			GSReputation_t.NativeFieldInfoPtr_Banned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "Banned");
			GSReputation_t.NativeFieldInfoPtr_BannedIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "BannedIP");
			GSReputation_t.NativeFieldInfoPtr_BannedPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "BannedPort");
			GSReputation_t.NativeFieldInfoPtr_BannedGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "BannedGameID");
			GSReputation_t.NativeFieldInfoPtr_BanExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "BanExpires");
			GSReputation_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "_datasize");
			GSReputation_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, 100667362);
			GSReputation_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, 100667363);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0006BE68 File Offset: 0x0006A068
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951036, XrefRangeEnd = 951040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSReputation_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0006BE98 File Offset: 0x0006A098
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSReputation_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00006DDD File Offset: 0x00004FDD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0006BEC8 File Offset: 0x0006A0C8
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x00006DEF File Offset: 0x00004FEF
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSReputation_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSReputation_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeFieldInfoPtr_ReputationScore;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeFieldInfoPtr_Banned;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeFieldInfoPtr_BannedIP;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeFieldInfoPtr_BannedPort;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_BannedGameID;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr_BanExpires;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AC9 RID: 6857
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001ACA RID: 6858
		[FieldOffset(4)]
		public uint ReputationScore;

		// Token: 0x04001ACB RID: 6859
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool Banned;

		// Token: 0x04001ACC RID: 6860
		[FieldOffset(12)]
		public uint BannedIP;

		// Token: 0x04001ACD RID: 6861
		[FieldOffset(16)]
		public ushort BannedPort;

		// Token: 0x04001ACE RID: 6862
		[FieldOffset(24)]
		public ulong BannedGameID;

		// Token: 0x04001ACF RID: 6863
		[FieldOffset(32)]
		public uint BanExpires;
	}
}

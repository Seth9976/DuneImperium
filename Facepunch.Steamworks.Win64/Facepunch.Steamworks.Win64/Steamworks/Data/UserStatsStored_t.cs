using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013E RID: 318
	[StructLayout(2)]
	public struct UserStatsStored_t
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x00062B94 File Offset: 0x00060D94
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsStored_t()
		{
			Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr);
			UserStatsStored_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "GameID");
			UserStatsStored_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "Result");
			UserStatsStored_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "_datasize");
			UserStatsStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, 100667022);
			UserStatsStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, 100667023);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x00062C28 File Offset: 0x00060E28
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950549, XrefRangeEnd = 950553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00062C58 File Offset: 0x00060E58
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000052FB File Offset: 0x000034FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00062C88 File Offset: 0x00060E88
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000530D File Offset: 0x0000350D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsStored_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsStored_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017BE RID: 6078
		[FieldOffset(0)]
		public ulong GameID;

		// Token: 0x040017BF RID: 6079
		[FieldOffset(8)]
		public Result Result;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E7 RID: 231
	[StructLayout(2)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x0005B620 File Offset: 0x00059820
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateAuthTicketResponse_t()
		{
			Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ValidateAuthTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr);
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "SteamID");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_AuthSessionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "AuthSessionResponse");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "OwnerSteamID");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "_datasize");
			ValidateAuthTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, 100666747);
			ValidateAuthTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, 100666748);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0005B6C8 File Offset: 0x000598C8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950137, XrefRangeEnd = 950141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateAuthTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0005B6F8 File Offset: 0x000598F8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateAuthTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00003FBB File Offset: 0x000021BB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0005B728 File Offset: 0x00059928
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00003FCD File Offset: 0x000021CD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_AuthSessionResponse;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_OwnerSteamID;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014F1 RID: 5361
		[FieldOffset(0)]
		public ulong SteamID;

		// Token: 0x040014F2 RID: 5362
		[FieldOffset(8)]
		public AuthResponse AuthSessionResponse;

		// Token: 0x040014F3 RID: 5363
		[FieldOffset(12)]
		public ulong OwnerSteamID;
	}
}

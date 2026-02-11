using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000EA RID: 234
	[StructLayout(2)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x0005B964 File Offset: 0x00059B64
		// Note: this type is marked as 'beforefieldinit'.
		static GetAuthSessionTicketResponse_t()
		{
			Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GetAuthSessionTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr);
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_AuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "AuthTicket");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "Result");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "_datasize");
			GetAuthSessionTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, 100666756);
			GetAuthSessionTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, 100666757);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950149, XrefRangeEnd = 950153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAuthSessionTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0005BA28 File Offset: 0x00059C28
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAuthSessionTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0000401B File Offset: 0x0000221B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0005BA58 File Offset: 0x00059C58
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0000402D File Offset: 0x0000222D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_AuthTicket;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001507 RID: 5383
		[FieldOffset(0)]
		public uint AuthTicket;

		// Token: 0x04001508 RID: 5384
		[FieldOffset(4)]
		public Result Result;
	}
}

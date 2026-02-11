using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E8 RID: 232
	[StructLayout(2)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x06000ED2 RID: 3794 RVA: 0x0005B744 File Offset: 0x00059944
		// Note: this type is marked as 'beforefieldinit'.
		static MicroTxnAuthorizationResponse_t()
		{
			Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MicroTxnAuthorizationResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr);
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "AppID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_OrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "OrderID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_Authorized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "Authorized");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "_datasize");
			MicroTxnAuthorizationResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, 100666750);
			MicroTxnAuthorizationResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, 100666751);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0005B7EC File Offset: 0x000599EC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950141, XrefRangeEnd = 950145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MicroTxnAuthorizationResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0005B81C File Offset: 0x00059A1C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MicroTxnAuthorizationResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00003FDB File Offset: 0x000021DB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0005B84C File Offset: 0x00059A4C
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00003FED File Offset: 0x000021ED
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_OrderID;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_Authorized;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014FA RID: 5370
		[FieldOffset(0)]
		public uint AppID;

		// Token: 0x040014FB RID: 5371
		[FieldOffset(8)]
		public ulong OrderID;

		// Token: 0x040014FC RID: 5372
		[FieldOffset(16)]
		public byte Authorized;
	}
}

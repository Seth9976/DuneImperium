using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E9 RID: 233
	[StructLayout(2)]
	public struct EncryptedAppTicketResponse_t
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x0005B868 File Offset: 0x00059A68
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptedAppTicketResponse_t()
		{
			Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "EncryptedAppTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr);
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "Result");
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "_datasize");
			EncryptedAppTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, 100666753);
			EncryptedAppTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, 100666754);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0005B8E8 File Offset: 0x00059AE8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950145, XrefRangeEnd = 950149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedAppTicketResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0005B918 File Offset: 0x00059B18
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedAppTicketResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00003FFB File Offset: 0x000021FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0005B948 File Offset: 0x00059B48
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0000400D File Offset: 0x0000220D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001501 RID: 5377
		[FieldOffset(0)]
		public Result Result;
	}
}

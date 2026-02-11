using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A9 RID: 425
	[StructLayout(2)]
	public struct GSPolicyResponse_t
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x0006BA04 File Offset: 0x00069C04
		// Note: this type is marked as 'beforefieldinit'.
		static GSPolicyResponse_t()
		{
			Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSPolicyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr);
			GSPolicyResponse_t.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "Secure");
			GSPolicyResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "_datasize");
			GSPolicyResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, 100667353);
			GSPolicyResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, 100667354);
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0006BA84 File Offset: 0x00069C84
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951024, XrefRangeEnd = 951028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSPolicyResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0006BAB4 File Offset: 0x00069CB4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSPolicyResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00006D7D File Offset: 0x00004F7D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0006BAE4 File Offset: 0x00069CE4
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00006D8F File Offset: 0x00004F8F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSPolicyResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSPolicyResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeFieldInfoPtr_Secure;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AA8 RID: 6824
		[FieldOffset(0)]
		public byte Secure;
	}
}

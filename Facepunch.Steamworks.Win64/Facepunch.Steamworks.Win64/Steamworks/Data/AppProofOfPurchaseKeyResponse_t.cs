using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200014C RID: 332
	public sealed class AppProofOfPurchaseKeyResponse_t : ValueType
	{
		// Token: 0x060011EB RID: 4587 RVA: 0x00063D54 File Offset: 0x00061F54
		// Note: this type is marked as 'beforefieldinit'.
		static AppProofOfPurchaseKeyResponse_t()
		{
			Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AppProofOfPurchaseKeyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr);
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "Result");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "AppID");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_CchKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "CchKeyLength");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "Key");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "_datasize");
			AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_KeyUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, 100667066);
			AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, 100667067);
			AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, 100667068);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00063E24 File Offset: 0x00062024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950615, XrefRangeEnd = 950619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string KeyUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_KeyUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00063E60 File Offset: 0x00062060
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950619, XrefRangeEnd = 950623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00063EA4 File Offset: 0x000620A4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppProofOfPurchaseKeyResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000055C8 File Offset: 0x000037C8
		public AppProofOfPurchaseKeyResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000055D1 File Offset: 0x000037D1
		public AppProofOfPurchaseKeyResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00063EE8 File Offset: 0x000620E8
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x000055E3 File Offset: 0x000037E3
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00063F10 File Offset: 0x00062110
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x000055FE File Offset: 0x000037FE
		public unsafe uint AppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_AppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_AppID)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00063F38 File Offset: 0x00062138
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00005619 File Offset: 0x00003819
		public unsafe uint CchKeyLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_CchKeyLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_CchKeyLength)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00063F60 File Offset: 0x00062160
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00005634 File Offset: 0x00003834
		public unsafe Il2CppStructArray<byte> Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00063F90 File Offset: 0x00062190
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00005653 File Offset: 0x00003853
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeFieldInfoPtr_CchKeyLength;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_KeyUTF8_Internal_String_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}

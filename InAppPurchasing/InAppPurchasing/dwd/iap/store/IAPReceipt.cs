using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.iap.store
{
	// Token: 0x02000013 RID: 19
	public class IAPReceipt : Object
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00006DF0 File Offset: 0x00004FF0
		// Note: this type is marked as 'beforefieldinit'.
		static IAPReceipt()
		{
			Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr);
			IAPReceipt.NativeFieldInfoPtr_receiptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, "receiptData");
			IAPReceipt.NativeFieldInfoPtr_transactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, "transactionID");
			IAPReceipt.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, "signature");
			IAPReceipt.NativeMethodInfoPtr_get_ReceiptData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663477);
			IAPReceipt.NativeMethodInfoPtr_get_TransactionID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663478);
			IAPReceipt.NativeMethodInfoPtr_get_Signature_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663479);
			IAPReceipt.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663480);
			IAPReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663481);
			IAPReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr, 100663482);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00006ED4 File Offset: 0x000050D4
		public unsafe string ReceiptData
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr_get_ReceiptData_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00006F0C File Offset: 0x0000510C
		public unsafe string TransactionID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr_get_TransactionID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00006F44 File Offset: 0x00005144
		public unsafe string Signature
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr_get_Signature_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006F7C File Offset: 0x0000517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200717, XrefRangeEnd = 1200723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPReceipt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006FB8 File Offset: 0x000051B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1200731, RefRangeEnd = 1200732, XrefRangeStart = 1200723, XrefRangeEnd = 1200731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPReceipt(string transactionID, string data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007018 File Offset: 0x00005218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200732, XrefRangeEnd = 1200741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPReceipt(string transactionID, string data, string signature)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPReceipt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000025E5 File Offset: 0x000007E5
		public IAPReceipt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00007088 File Offset: 0x00005288
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000025EE File Offset: 0x000007EE
		public unsafe string receiptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_receiptData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_receiptData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000070B0 File Offset: 0x000052B0
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000260D File Offset: 0x0000080D
		public unsafe string transactionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_transactionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_transactionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000070D8 File Offset: 0x000052D8
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000262C File Offset: 0x0000082C
		public unsafe string signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPReceipt.NativeFieldInfoPtr_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_receiptData;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_transactionID;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiptData_Public_get_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_TransactionID_Public_get_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_Signature_Public_get_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}

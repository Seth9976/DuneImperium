using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200027A RID: 634
	public class TripleDESTransform : SymmetricTransform
	{
		// Token: 0x060028E0 RID: 10464 RVA: 0x000DB764 File Offset: 0x000D9964
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDESTransform()
		{
			Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr);
			TripleDESTransform.NativeFieldInfoPtr_E1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E1");
			TripleDESTransform.NativeFieldInfoPtr_D2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D2");
			TripleDESTransform.NativeFieldInfoPtr_E3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E3");
			TripleDESTransform.NativeFieldInfoPtr_D1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D1");
			TripleDESTransform.NativeFieldInfoPtr_E2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E2");
			TripleDESTransform.NativeFieldInfoPtr_D3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D3");
			TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100669986);
			TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100669987);
			TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100669988);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000DB848 File Offset: 0x000D9A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1375102, RefRangeEnd = 1375104, XrefRangeStart = 1375041, XrefRangeEnd = 1375102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDESTransform(TripleDES algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000DB8C8 File Offset: 0x000D9AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375104, XrefRangeEnd = 1375119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000DB928 File Offset: 0x000D9B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375119, XrefRangeEnd = 1375128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0000D7EA File Offset: 0x0000B9EA
		public TripleDESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000DB95C File Offset: 0x000D9B5C
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
		public unsafe DESTransform E1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000DB98C File Offset: 0x000D9B8C
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0000D812 File Offset: 0x0000BA12
		public unsafe DESTransform D2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x000DB9BC File Offset: 0x000D9BBC
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0000D831 File Offset: 0x0000BA31
		public unsafe DESTransform E3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x000DB9EC File Offset: 0x000D9BEC
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x0000D850 File Offset: 0x0000BA50
		public unsafe DESTransform D1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x000DBA1C File Offset: 0x000D9C1C
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x0000D86F File Offset: 0x0000BA6F
		public unsafe DESTransform E2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x000DBA4C File Offset: 0x000D9C4C
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x0000D88E File Offset: 0x0000BA8E
		public unsafe DESTransform D3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_E1;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_D2;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_E3;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_D1;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_E2;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeFieldInfoPtr_D3;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}

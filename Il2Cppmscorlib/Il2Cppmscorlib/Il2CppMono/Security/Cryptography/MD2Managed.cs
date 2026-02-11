using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002F RID: 47
	public class MD2Managed : MD2
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0002E990 File Offset: 0x0002CB90
		// Note: this type is marked as 'beforefieldinit'.
		static MD2Managed()
		{
			Il2CppClassPointerStore<MD2Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD2Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr);
			MD2Managed.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "state");
			MD2Managed.NativeFieldInfoPtr_checksum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "checksum");
			MD2Managed.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "buffer");
			MD2Managed.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "count");
			MD2Managed.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "x");
			MD2Managed.NativeFieldInfoPtr_PI_SUBST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, "PI_SUBST");
			MD2Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663647);
			MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663648);
			MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663649);
			MD2Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663650);
			MD2Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663651);
			MD2Managed.NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr, 100663652);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0002EAB0 File Offset: 0x0002CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278246, XrefRangeEnd = 1278247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Padding(int nLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278247, XrefRangeEnd = 1278261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002EB38 File Offset: 0x0002CD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002EB74 File Offset: 0x0002CD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278261, XrefRangeEnd = 1278266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> array, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278266, XrefRangeEnd = 1278274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MD2Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002EC2C File Offset: 0x0002CE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278284, RefRangeEnd = 1278286, XrefRangeStart = 1278274, XrefRangeEnd = 1278284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MD2Transform(Il2CppStructArray<byte> state, Il2CppStructArray<byte> checksum, Il2CppStructArray<byte> block, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checksum);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(block);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2Managed.NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002EDB File Offset: 0x000010DB
		public MD2Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002EE4 File Offset: 0x000010E4
		public unsafe Il2CppStructArray<byte> state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0002ECD0 File Offset: 0x0002CED0
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002F03 File Offset: 0x00001103
		public unsafe Il2CppStructArray<byte> checksum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_checksum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_checksum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0002ED00 File Offset: 0x0002CF00
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002F22 File Offset: 0x00001122
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002ED30 File Offset: 0x0002CF30
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002F41 File Offset: 0x00001141
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0002ED58 File Offset: 0x0002CF58
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002F5C File Offset: 0x0000115C
		public unsafe Il2CppStructArray<byte> x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD2Managed.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0002ED88 File Offset: 0x0002CF88
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002F7B File Offset: 0x0000117B
		public unsafe static Il2CppStructArray<byte> PI_SUBST
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MD2Managed.NativeFieldInfoPtr_PI_SUBST, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MD2Managed.NativeFieldInfoPtr_PI_SUBST, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_checksum;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_PI_SUBST;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_Padding_Private_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_MD2Transform_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;
	}
}

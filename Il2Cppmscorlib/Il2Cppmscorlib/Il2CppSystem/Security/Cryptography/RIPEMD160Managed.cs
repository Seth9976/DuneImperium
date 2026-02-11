using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000259 RID: 601
	public class RIPEMD160Managed : RIPEMD160
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x000D447C File Offset: 0x000D267C
		// Note: this type is marked as 'beforefieldinit'.
		static RIPEMD160Managed()
		{
			Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr);
			RIPEMD160Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_buffer");
			RIPEMD160Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_count");
			RIPEMD160Managed.NativeFieldInfoPtr__stateMD160 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_stateMD160");
			RIPEMD160Managed.NativeFieldInfoPtr__blockDWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, "_blockDWords");
			RIPEMD160Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669740);
			RIPEMD160Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669741);
			RIPEMD160Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669742);
			RIPEMD160Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669743);
			RIPEMD160Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669744);
			RIPEMD160Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669745);
			RIPEMD160Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669746);
			RIPEMD160Managed.NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669747);
			RIPEMD160Managed.NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669748);
			RIPEMD160Managed.NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669749);
			RIPEMD160Managed.NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669750);
			RIPEMD160Managed.NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669751);
			RIPEMD160Managed.NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr, 100669752);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000D4600 File Offset: 0x000D2800
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1372874, RefRangeEnd = 1372879, XrefRangeStart = 1372850, XrefRangeEnd = 1372874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RIPEMD160Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000D463C File Offset: 0x000D283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372879, XrefRangeEnd = 1372883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000D4678 File Offset: 0x000D2878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372883, XrefRangeEnd = 1372884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000D46E4 File Offset: 0x000D28E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372884, XrefRangeEnd = 1372885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RIPEMD160Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000D4730 File Offset: 0x000D2930
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1372885, RefRangeEnd = 1372889, XrefRangeStart = 1372885, XrefRangeEnd = 1372885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000D4764 File Offset: 0x000D2964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1372897, RefRangeEnd = 1372899, XrefRangeStart = 1372889, XrefRangeEnd = 1372897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HashData(Il2CppStructArray<byte> partIn, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partIn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000D47C4 File Offset: 0x000D29C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372907, RefRangeEnd = 1372908, XrefRangeStart = 1372899, XrefRangeEnd = 1372907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000D4804 File Offset: 0x000D2A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1372909, RefRangeEnd = 1372911, XrefRangeStart = 1372908, XrefRangeEnd = 1372909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = blockDWords;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000D4850 File Offset: 0x000D2A50
		[CallerCount(0)]
		public unsafe static uint F(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000D48AC File Offset: 0x000D2AAC
		[CallerCount(0)]
		public unsafe static uint G(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000D4908 File Offset: 0x000D2B08
		[CallerCount(0)]
		public unsafe static uint H(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000D4964 File Offset: 0x000D2B64
		[CallerCount(0)]
		public unsafe static uint I(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000D49C0 File Offset: 0x000D2BC0
		[CallerCount(0)]
		public unsafe static uint J(uint x, uint y, uint z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160Managed.NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0000CAE2 File Offset: 0x0000ACE2
		public RIPEMD160Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000D4A1C File Offset: 0x000D2C1C
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0000CAEB File Offset: 0x0000ACEB
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000D4A4C File Offset: 0x000D2C4C
		// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0000CB0A File Offset: 0x0000AD0A
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000D4A74 File Offset: 0x000D2C74
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x0000CB25 File Offset: 0x0000AD25
		public unsafe Il2CppStructArray<uint> _stateMD160
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__stateMD160);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__stateMD160), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000D4AA4 File Offset: 0x000D2CA4
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0000CB44 File Offset: 0x0000AD44
		public unsafe Il2CppStructArray<uint> _blockDWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__blockDWords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RIPEMD160Managed.NativeFieldInfoPtr__blockDWords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeFieldInfoPtr__stateMD160;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeFieldInfoPtr__blockDWords;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_MDTransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_F_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_G_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_H_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_I_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_J_Private_Static_UInt32_UInt32_UInt32_UInt32_0;
	}
}

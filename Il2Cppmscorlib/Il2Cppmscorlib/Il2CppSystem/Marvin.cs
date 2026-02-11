using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000BF RID: 191
	public static class Marvin : Object
	{
		// Token: 0x06000C6D RID: 3181 RVA: 0x0005F34C File Offset: 0x0005D54C
		// Note: this type is marked as 'beforefieldinit'.
		static Marvin()
		{
			Il2CppClassPointerStore<Marvin>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Marvin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marvin>.NativeClassPtr);
			Marvin.NativeFieldInfoPtr__DefaultSeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marvin>.NativeClassPtr, "<DefaultSeed>k__BackingField");
			Marvin.NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665460);
			Marvin.NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665461);
			Marvin.NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665462);
			Marvin.NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665463);
			Marvin.NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665464);
			Marvin.NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665465);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0005F408 File Offset: 0x0005D608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310169, XrefRangeEnd = 1310177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0005F45C File Offset: 0x0005D65C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1310217, RefRangeEnd = 1310220, XrefRangeStart = 1310177, XrefRangeEnd = 1310217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ComputeHash32(ref byte data, int count, ulong seed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0005F4B8 File Offset: 0x0005D6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310220, XrefRangeEnd = 1310223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Block(ref uint rp0, ref uint rp1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rp0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rp1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		[CallerCount(0)]
		public unsafe static uint _rotl(uint value, int shift)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0005F544 File Offset: 0x0005D744
		public unsafe static ulong DefaultSeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1310223, XrefRangeEnd = 1310227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0005F574 File Offset: 0x0005D774
		[CallerCount(0)]
		public unsafe static ulong GenerateSeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marvin.NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00005195 File Offset: 0x00003395
		public Marvin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0005F5A4 File Offset: 0x0005D7A4
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0000519E File Offset: 0x0000339E
		public unsafe static ulong _DefaultSeed_k__BackingField
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(Marvin.NativeFieldInfoPtr__DefaultSeed_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Marvin.NativeFieldInfoPtr__DefaultSeed_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr__DefaultSeed_k__BackingField;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0;
	}
}

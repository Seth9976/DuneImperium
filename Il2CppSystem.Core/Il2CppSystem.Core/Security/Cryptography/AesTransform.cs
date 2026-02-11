using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000015 RID: 21
	public class AesTransform : SymmetricTransform
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00011968 File Offset: 0x0000FB68
		// Note: this type is marked as 'beforefieldinit'.
		static AesTransform()
		{
			Il2CppClassPointerStore<AesTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography", "AesTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AesTransform>.NativeClassPtr);
			AesTransform.NativeFieldInfoPtr_expandedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "expandedKey");
			AesTransform.NativeFieldInfoPtr_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nk");
			AesTransform.NativeFieldInfoPtr_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Nr");
			AesTransform.NativeFieldInfoPtr_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "Rcon");
			AesTransform.NativeFieldInfoPtr_SBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "SBox");
			AesTransform.NativeFieldInfoPtr_iSBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iSBox");
			AesTransform.NativeFieldInfoPtr_T0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T0");
			AesTransform.NativeFieldInfoPtr_T1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T1");
			AesTransform.NativeFieldInfoPtr_T2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T2");
			AesTransform.NativeFieldInfoPtr_T3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "T3");
			AesTransform.NativeFieldInfoPtr_iT0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT0");
			AesTransform.NativeFieldInfoPtr_iT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT1");
			AesTransform.NativeFieldInfoPtr_iT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT2");
			AesTransform.NativeFieldInfoPtr_iT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, "iT3");
			AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663372);
			AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663373);
			AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663374);
			AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663375);
			AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AesTransform>.NativeClassPtr, 100663376);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00011B14 File Offset: 0x0000FD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1002422, RefRangeEnd = 1002424, XrefRangeStart = 1002346, XrefRangeEnd = 1002422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AesTransform(Aes algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AesTransform>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00011B94 File Offset: 0x0000FD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002424, XrefRangeEnd = 1002425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AesTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1002429, RefRangeEnd = 1002431, XrefRangeStart = 1002425, XrefRangeEnd = 1002429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint SubByte(uint a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00011C40 File Offset: 0x0000FE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002431, XrefRangeEnd = 1002457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1002482, RefRangeEnd = 1002483, XrefRangeStart = 1002457, XrefRangeEnd = 1002482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt128(Il2CppStructArray<byte> indata, Il2CppStructArray<byte> outdata, Il2CppStructArray<uint> ekey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indata);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ekey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AesTransform.NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002128 File Offset: 0x00000328
		public AesTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00011D10 File Offset: 0x0000FF10
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002131 File Offset: 0x00000331
		public unsafe Il2CppStructArray<uint> expandedKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_expandedKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00011D40 File Offset: 0x0000FF40
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002150 File Offset: 0x00000350
		public unsafe int Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nk)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00011D68 File Offset: 0x0000FF68
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000216B File Offset: 0x0000036B
		public unsafe int Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AesTransform.NativeFieldInfoPtr_Nr)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00011D90 File Offset: 0x0000FF90
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002186 File Offset: 0x00000386
		public unsafe static Il2CppStructArray<uint> Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe static Il2CppStructArray<byte> SBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_SBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_SBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000021AA File Offset: 0x000003AA
		public unsafe static Il2CppStructArray<byte> iSBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iSBox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iSBox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00011E08 File Offset: 0x00010008
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000021BC File Offset: 0x000003BC
		public unsafe static Il2CppStructArray<uint> T0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00011E30 File Offset: 0x00010030
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000021CE File Offset: 0x000003CE
		public unsafe static Il2CppStructArray<uint> T1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00011E58 File Offset: 0x00010058
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000021E0 File Offset: 0x000003E0
		public unsafe static Il2CppStructArray<uint> T2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00011E80 File Offset: 0x00010080
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000021F2 File Offset: 0x000003F2
		public unsafe static Il2CppStructArray<uint> T3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_T3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_T3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00011EA8 File Offset: 0x000100A8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002204 File Offset: 0x00000404
		public unsafe static Il2CppStructArray<uint> iT0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00011ED0 File Offset: 0x000100D0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002216 File Offset: 0x00000416
		public unsafe static Il2CppStructArray<uint> iT1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00011EF8 File Offset: 0x000100F8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002228 File Offset: 0x00000428
		public unsafe static Il2CppStructArray<uint> iT2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00011F20 File Offset: 0x00010120
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000223A File Offset: 0x0000043A
		public unsafe static Il2CppStructArray<uint> iT3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AesTransform.NativeFieldInfoPtr_iT3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AesTransform.NativeFieldInfoPtr_iT3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_expandedKey;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_Nk;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_Nr;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_Rcon;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_SBox;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_iSBox;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_T0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_T1;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_T2;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_T3;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_iT0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_iT1;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_iT2;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_iT3;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Aes_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_SubByte_Private_UInt32_UInt32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt128_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Authenticode
{
	// Token: 0x0200003B RID: 59
	public class AuthenticodeBase : Object
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00010A58 File Offset: 0x0000EC58
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticodeBase()
		{
			Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Authenticode", "AuthenticodeBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr);
			AuthenticodeBase.NativeFieldInfoPtr_fileblock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "fileblock");
			AuthenticodeBase.NativeFieldInfoPtr_fs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "fs");
			AuthenticodeBase.NativeFieldInfoPtr_blockNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "blockNo");
			AuthenticodeBase.NativeFieldInfoPtr_blockLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "blockLength");
			AuthenticodeBase.NativeFieldInfoPtr_peOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "peOffset");
			AuthenticodeBase.NativeFieldInfoPtr_dirSecurityOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "dirSecurityOffset");
			AuthenticodeBase.NativeFieldInfoPtr_dirSecuritySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "dirSecuritySize");
			AuthenticodeBase.NativeFieldInfoPtr_coffSymbolTableOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "coffSymbolTableOffset");
			AuthenticodeBase.NativeFieldInfoPtr_pe64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, "pe64");
			AuthenticodeBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663789);
			AuthenticodeBase.NativeMethodInfoPtr_get_PEOffset_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663790);
			AuthenticodeBase.NativeMethodInfoPtr_Open_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663791);
			AuthenticodeBase.NativeMethodInfoPtr_Open_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663792);
			AuthenticodeBase.NativeMethodInfoPtr_Close_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663793);
			AuthenticodeBase.NativeMethodInfoPtr_ReadFirstBlock_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663794);
			AuthenticodeBase.NativeMethodInfoPtr_ProcessFirstBlock_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663795);
			AuthenticodeBase.NativeMethodInfoPtr_GetSecurityEntry_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663796);
			AuthenticodeBase.NativeMethodInfoPtr_GetHash_Internal_Il2CppStructArray_1_Byte_HashAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr, 100663797);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150757, XrefRangeEnd = 1150762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticodeBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticodeBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public unsafe int PEOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150762, XrefRangeEnd = 1150763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_get_PEOffset_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00010C68 File Offset: 0x0000EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150763, XrefRangeEnd = 1150769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_Open_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00010CAC File Offset: 0x0000EEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150769, XrefRangeEnd = 1150775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Il2CppStructArray<byte> rawdata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawdata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_Open_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150775, XrefRangeEnd = 1150776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_Close_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00010D24 File Offset: 0x0000EF24
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1150777, RefRangeEnd = 1150834, XrefRangeStart = 1150776, XrefRangeEnd = 1150777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadFirstBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_ReadFirstBlock_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00010D58 File Offset: 0x0000EF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1150843, RefRangeEnd = 1150844, XrefRangeStart = 1150834, XrefRangeEnd = 1150843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ProcessFirstBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_ProcessFirstBlock_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00010D94 File Offset: 0x0000EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150844, XrefRangeEnd = 1150846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetSecurityEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_GetSecurityEntry_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150846, XrefRangeEnd = 1150864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetHash(HashAlgorithm hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hash);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeBase.NativeMethodInfoPtr_GetHash_Internal_Il2CppStructArray_1_Byte_HashAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000036AE File Offset: 0x000018AE
		public AuthenticodeBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00010E24 File Offset: 0x0000F024
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000036B7 File Offset: 0x000018B7
		public unsafe Il2CppStructArray<byte> fileblock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_fileblock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_fileblock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00010E54 File Offset: 0x0000F054
		// (set) Token: 0x0600035F RID: 863 RVA: 0x000036D6 File Offset: 0x000018D6
		public unsafe Stream fs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_fs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_fs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00010E84 File Offset: 0x0000F084
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000036F5 File Offset: 0x000018F5
		public unsafe int blockNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_blockNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_blockNo)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00010EAC File Offset: 0x0000F0AC
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003710 File Offset: 0x00001910
		public unsafe int blockLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_blockLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_blockLength)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00010ED4 File Offset: 0x0000F0D4
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0000372B File Offset: 0x0000192B
		public unsafe int peOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_peOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_peOffset)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00010EFC File Offset: 0x0000F0FC
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003746 File Offset: 0x00001946
		public unsafe int dirSecurityOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_dirSecurityOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_dirSecurityOffset)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00010F24 File Offset: 0x0000F124
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003761 File Offset: 0x00001961
		public unsafe int dirSecuritySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_dirSecuritySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_dirSecuritySize)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00010F4C File Offset: 0x0000F14C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000377C File Offset: 0x0000197C
		public unsafe int coffSymbolTableOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_coffSymbolTableOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_coffSymbolTableOffset)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00010F74 File Offset: 0x0000F174
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003797 File Offset: 0x00001997
		public unsafe bool pe64
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_pe64);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeBase.NativeFieldInfoPtr_pe64)) = value;
			}
		}

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_fileblock;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_fs;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_blockNo;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_blockLength;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_peOffset;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_dirSecurityOffset;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_dirSecuritySize;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_coffSymbolTableOffset;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_pe64;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_get_PEOffset_Internal_get_Int32_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_Open_Internal_Void_String_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Open_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_ReadFirstBlock_Internal_Void_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFirstBlock_Internal_Int32_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_GetSecurityEntry_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Internal_Il2CppStructArray_1_Byte_HashAlgorithm_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000065 RID: 101
	public class CopyEncoder : Object
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x0003045C File Offset: 0x0002E65C
		// Note: this type is marked as 'beforefieldinit'.
		static CopyEncoder()
		{
			Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "CopyEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr);
			CopyEncoder.NativeFieldInfoPtr_PaddingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr, "PaddingSize");
			CopyEncoder.NativeFieldInfoPtr_MaxUncompressedBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr, "MaxUncompressedBlockSize");
			CopyEncoder.NativeMethodInfoPtr_GetBlock_Public_Void_DeflateInput_OutputBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr, 100664383);
			CopyEncoder.NativeMethodInfoPtr_WriteLenNLen_Private_Void_UInt16_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr, 100664384);
			CopyEncoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr, 100664385);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000304F0 File Offset: 0x0002E6F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 860684, RefRangeEnd = 860688, XrefRangeStart = 860675, XrefRangeEnd = 860684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlock(DeflateInput input, OutputBuffer output, bool isFinal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFinal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyEncoder.NativeMethodInfoPtr_GetBlock_Public_Void_DeflateInput_OutputBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00030554 File Offset: 0x0002E754
		[CallerCount(0)]
		public unsafe void WriteLenNLen(ushort len, OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref len;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyEncoder.NativeMethodInfoPtr_WriteLenNLen_Private_Void_UInt16_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000305A4 File Offset: 0x0002E7A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyEncoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyEncoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyEncoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000444E File Offset: 0x0000264E
		public CopyEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000305E0 File Offset: 0x0002E7E0
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00004457 File Offset: 0x00002657
		public unsafe static int PaddingSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CopyEncoder.NativeFieldInfoPtr_PaddingSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CopyEncoder.NativeFieldInfoPtr_PaddingSize, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x000305FC File Offset: 0x0002E7FC
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004465 File Offset: 0x00002665
		public unsafe static int MaxUncompressedBlockSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CopyEncoder.NativeFieldInfoPtr_MaxUncompressedBlockSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CopyEncoder.NativeFieldInfoPtr_MaxUncompressedBlockSize, (void*)(&value));
			}
		}

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_PaddingSize;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_MaxUncompressedBlockSize;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_GetBlock_Public_Void_DeflateInput_OutputBuffer_Boolean_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_WriteLenNLen_Private_Void_UInt16_OutputBuffer_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

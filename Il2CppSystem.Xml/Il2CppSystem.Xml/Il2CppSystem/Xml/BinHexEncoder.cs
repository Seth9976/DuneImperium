using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000C RID: 12
	public static class BinHexEncoder : Object
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00016F20 File Offset: 0x00015120
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexEncoder()
		{
			Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663315);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663316);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00016F8C File Offset: 0x0001518C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362233, RefRangeEnd = 362235, XrefRangeStart = 362228, XrefRangeEnd = 362233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Encode(Il2CppStructArray<byte> buffer, int index, int count, XmlWriter writer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00016FF0 File Offset: 0x000151F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362240, RefRangeEnd = 362242, XrefRangeStart = 362235, XrefRangeEnd = 362240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00017048 File Offset: 0x00015248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362247, RefRangeEnd = 362249, XrefRangeStart = 362242, XrefRangeEnd = 362247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count, Il2CppStructArray<char> outArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022F8 File Offset: 0x000004F8
		public BinHexEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0;
	}
}

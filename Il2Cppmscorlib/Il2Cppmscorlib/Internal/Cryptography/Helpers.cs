using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Internal.Cryptography
{
	// Token: 0x02000055 RID: 85
	public static class Helpers : Object
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0003654C File Offset: 0x0003474C
		// Note: this type is marked as 'beforefieldinit'.
		static Helpers()
		{
			Il2CppClassPointerStore<Helpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Cryptography", "Helpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helpers>.NativeClassPtr);
			Helpers.NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663932);
			Helpers.NativeMethodInfoPtr_WriteInt_Public_Static_Void_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663933);
			Helpers.NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663934);
			Helpers.NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663935);
			Helpers.NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663936);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000365E0 File Offset: 0x000347E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1281201, RefRangeEnd = 1281209, XrefRangeStart = 1281198, XrefRangeEnd = 1281201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> CloneByteArray(this Il2CppStructArray<byte> src)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00036624 File Offset: 0x00034824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281209, RefRangeEnd = 1281210, XrefRangeStart = 1281209, XrefRangeEnd = 1281209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteInt(uint i, Il2CppStructArray<byte> arr, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_WriteInt_Public_Static_Void_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00036678 File Offset: 0x00034878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1281214, RefRangeEnd = 1281216, XrefRangeStart = 1281210, XrefRangeEnd = 1281214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> ToHexArrayUpper(this Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000366BC File Offset: 0x000348BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1281223, RefRangeEnd = 1281228, XrefRangeStart = 1281216, XrefRangeEnd = 1281223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHexStringUpper(this Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000366F8 File Offset: 0x000348F8
		[CallerCount(0)]
		public unsafe static char NibbleToHex(byte b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Helpers.NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003849 File Offset: 0x00001A49
		public Helpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt_Public_Static_Void_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0;
	}
}

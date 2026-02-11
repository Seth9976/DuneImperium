using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200003C RID: 60
	public static class TextUtilities : Object
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x0001B374 File Offset: 0x00019574
		// Note: this type is marked as 'beforefieldinit'.
		static TextUtilities()
		{
			Il2CppClassPointerStore<TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr);
			TextUtilities.NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100663757);
			TextUtilities.NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100663758);
			TextUtilities.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100663759);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001B3E0 File Offset: 0x000195E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106257, XrefRangeEnd = 1106260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001B420 File Offset: 0x00019620
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1106265, RefRangeEnd = 1106284, XrefRangeStart = 1106260, XrefRangeEnd = 1106265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeCaseInSensitive(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001B464 File Offset: 0x00019664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1106295, RefRangeEnd = 1106296, XrefRangeStart = 1106284, XrefRangeEnd = 1106295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UintToString(this List<uint> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextUtilities.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00006114 File Offset: 0x00004314
		public TextUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001B4A0 File Offset: 0x000196A0
		public static void ResizeArray<T>(ref Il2CppArrayBase<T> array)
		{
			int num = TextUtilities.NextPowerOfTwo(array.Length);
			Array.Resize<T>(ref array, num);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000611D File Offset: 0x0000431D
		public static void ResizeArray<T>(ref Il2CppArrayBase<T> array, int size)
		{
			size = TextUtilities.NextPowerOfTwo(size);
			Array.Resize<T>(ref array, size);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001B4C4 File Offset: 0x000196C4
		public static int NextPowerOfTwo(int v)
		{
			v |= v >> 16;
			v |= v >> 8;
			v |= v >> 4;
			v |= v >> 2;
			v |= v >> 1;
			return v + 1;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001B500 File Offset: 0x00019700
		public static char ToLowerFast(char c)
		{
			bool flag = (int)c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1;
			char c2;
			if (flag)
			{
				c2 = c;
			}
			else
			{
				c2 = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".get_Chars((int)c);
			}
			return c2;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001B534 File Offset: 0x00019734
		public static uint ToUpperASCIIFast(uint c)
		{
			bool flag = (ulong)c > (ulong)((long)("-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".Length - 1));
			uint num;
			if (flag)
			{
				num = c;
			}
			else
			{
				num = (uint)"-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".get_Chars((int)c);
			}
			return num;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001B56C File Offset: 0x0001976C
		public static uint ToLowerASCIIFast(uint c)
		{
			bool flag = (ulong)c > (ulong)((long)("-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1));
			uint num;
			if (flag)
			{
				num = c;
			}
			else
			{
				num = (uint)"-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".get_Chars((int)c);
			}
			return num;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001B5A4 File Offset: 0x000197A4
		public static int GetHashCodeCaseSensitive(string s)
		{
			int num = 0;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((num << 5) + num) ^ (int)s.get_Chars(i);
			}
			return num;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001B5DC File Offset: 0x000197DC
		public static uint GetSimpleHashCodeLowercase(string s)
		{
			uint num = 0U;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((num << 5) + num) ^ (uint)TextUtilities.ToLowerFast(s.get_Chars(i));
			}
			return num;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001B61C File Offset: 0x0001981C
		public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			return (highSurrogate - 55296U) * 1024U + (lowSurrogate - 56320U + 65536U);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00006130 File Offset: 0x00004330
		public static uint ReadUTF16(Il2CppStructArray<uint> text, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000613D File Offset: 0x0000433D
		public static uint ReadUTF32(Il2CppStructArray<uint> text, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001B64C File Offset: 0x0001984C
		public static uint HexToInt(char hex)
		{
			switch (hex)
			{
			case '0':
				return 0U;
			case '1':
				return 1U;
			case '2':
				return 2U;
			case '3':
				return 3U;
			case '4':
				return 4U;
			case '5':
				return 5U;
			case '6':
				return 6U;
			case '7':
				return 7U;
			case '8':
				return 8U;
			case '9':
				return 9U;
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				break;
			case 'A':
				return 10U;
			case 'B':
				return 11U;
			case 'C':
				return 12U;
			case 'D':
				return 13U;
			case 'E':
				return 14U;
			case 'F':
				return 15U;
			default:
				switch (hex)
				{
				case 'a':
					return 10U;
				case 'b':
					return 11U;
				case 'c':
					return 12U;
				case 'd':
					return 13U;
				case 'e':
					return 14U;
				case 'f':
					return 15U;
				}
				break;
			}
			return 15U;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001B754 File Offset: 0x00019954
		public static uint StringHexToInt(string s)
		{
			uint num = 0U;
			int length = s.Length;
			for (int i = 0; i < length; i++)
			{
				num += TextUtilities.HexToInt(s.get_Chars(i)) * (uint)Mathf.Pow(16f, (float)(length - 1 - i));
			}
			return num;
		}

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0;

		// Token: 0x040005A1 RID: 1441
		public const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		// Token: 0x040005A2 RID: 1442
		public const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
	}
}

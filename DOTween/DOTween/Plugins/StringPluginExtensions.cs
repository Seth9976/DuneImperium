using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace DG.Tweening.Plugins
{
	// Token: 0x0200002B RID: 43
	public static class StringPluginExtensions : Object
	{
		// Token: 0x06000312 RID: 786 RVA: 0x00015B90 File Offset: 0x00013D90
		// Note: this type is marked as 'beforefieldinit'.
		static StringPluginExtensions()
		{
			Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "StringPluginExtensions");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsAll");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsUppercase");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsLowercase");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsNumerals");
			StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "_lastRndSeed");
			StringPluginExtensions.NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, 100664065);
			StringPluginExtensions.NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, 100664066);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00015C44 File Offset: 0x00013E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132423, RefRangeEnd = 1132424, XrefRangeStart = 1132422, XrefRangeEnd = 1132423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScrambleChars(this Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPluginExtensions.NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00015C7C File Offset: 0x00013E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132437, RefRangeEnd = 1132438, XrefRangeStart = 1132424, XrefRangeEnd = 1132437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, Il2CppStructArray<char> chars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPluginExtensions.NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002C87 File Offset: 0x00000E87
		public StringPluginExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00015CE0 File Offset: 0x00013EE0
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00002C90 File Offset: 0x00000E90
		public unsafe static Il2CppStructArray<char> ScrambledCharsAll
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00015D08 File Offset: 0x00013F08
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002CA2 File Offset: 0x00000EA2
		public unsafe static Il2CppStructArray<char> ScrambledCharsUppercase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00015D30 File Offset: 0x00013F30
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public unsafe static Il2CppStructArray<char> ScrambledCharsLowercase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00015D58 File Offset: 0x00013F58
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public unsafe static Il2CppStructArray<char> ScrambledCharsNumerals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00015D80 File Offset: 0x00013F80
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public unsafe static int _lastRndSeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed, (void*)(&value));
			}
		}

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsAll;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsUppercase;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsLowercase;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsNumerals;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr__lastRndSeed;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0;
	}
}

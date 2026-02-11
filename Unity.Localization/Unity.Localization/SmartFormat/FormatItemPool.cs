using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.Core.Settings;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000036 RID: 54
	public static class FormatItemPool : Object
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00016DE8 File Offset: 0x00014FE8
		// Note: this type is marked as 'beforefieldinit'.
		static FormatItemPool()
		{
			Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "FormatItemPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr);
			FormatItemPool.NativeFieldInfoPtr_s_LiteralTextPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, "s_LiteralTextPool");
			FormatItemPool.NativeFieldInfoPtr_s_FormatPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, "s_FormatPool");
			FormatItemPool.NativeFieldInfoPtr_s_PlaceholderPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, "s_PlaceholderPool");
			FormatItemPool.NativeFieldInfoPtr_s_SelectorPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, "s_SelectorPool");
			FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663913);
			FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663914);
			FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663915);
			FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663916);
			FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663917);
			FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663918);
			FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_Placeholder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663919);
			FormatItemPool.NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663920);
			FormatItemPool.NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_Format_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663921);
			FormatItemPool.NativeMethodInfoPtr_GetSelector_Public_Static_Selector_SmartSettings_FormatItem_String_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663922);
			FormatItemPool.NativeMethodInfoPtr_ReleaseLiteralText_Public_Static_Void_LiteralText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663923);
			FormatItemPool.NativeMethodInfoPtr_ReleaseFormat_Public_Static_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663924);
			FormatItemPool.NativeMethodInfoPtr_ReleasePlaceholder_Public_Static_Void_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663925);
			FormatItemPool.NativeMethodInfoPtr_ReleaseSelector_Public_Static_Void_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663926);
			FormatItemPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, 100663927);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00016F94 File Offset: 0x00015194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069104, XrefRangeEnd = 1069112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LiteralText>(intPtr3) : null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00016FF8 File Offset: 0x000151F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1069120, RefRangeEnd = 1069128, XrefRangeStart = 1069112, XrefRangeEnd = 1069120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LiteralText>(intPtr3) : null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001706C File Offset: 0x0001526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069128, XrefRangeEnd = 1069136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LiteralText>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000170F0 File Offset: 0x000152F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1069144, RefRangeEnd = 1069146, XrefRangeStart = 1069136, XrefRangeEnd = 1069144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format GetFormat(SmartSettings smartSettings, string baseString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00017148 File Offset: 0x00015348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069146, XrefRangeEnd = 1069154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000171BC File Offset: 0x000153BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1069162, RefRangeEnd = 1069164, XrefRangeStart = 1069154, XrefRangeEnd = 1069162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex, bool nested)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001723C File Offset: 0x0001543C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069173, RefRangeEnd = 1069174, XrefRangeStart = 1069164, XrefRangeEnd = 1069173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Format GetFormat(SmartSettings smartSettings, Placeholder parent, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_Placeholder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000172A0 File Offset: 0x000154A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069187, RefRangeEnd = 1069188, XrefRangeStart = 1069174, XrefRangeEnd = 1069187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestedDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00017314 File Offset: 0x00015514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1069202, RefRangeEnd = 1069204, XrefRangeStart = 1069188, XrefRangeEnd = 1069202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth, Format itemFormat, int endIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestedDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemFormat);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_Format_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000173A8 File Offset: 0x000155A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1069212, RefRangeEnd = 1069215, XrefRangeStart = 1069204, XrefRangeEnd = 1069212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Selector GetSelector(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex, int operatorStart, int selectorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operatorStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_GetSelector_Public_Static_Selector_SmartSettings_FormatItem_String_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selector>(intPtr3) : null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00017448 File Offset: 0x00015648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069215, XrefRangeEnd = 1069223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseLiteralText(LiteralText literal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(literal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_ReleaseLiteralText_Public_Static_Void_LiteralText_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00017480 File Offset: 0x00015680
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1069231, RefRangeEnd = 1069237, XrefRangeStart = 1069223, XrefRangeEnd = 1069231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseFormat(Format format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_ReleaseFormat_Public_Static_Void_Format_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000174B8 File Offset: 0x000156B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069237, XrefRangeEnd = 1069245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePlaceholder(Placeholder placeholder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_ReleasePlaceholder_Public_Static_Void_Placeholder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000174F0 File Offset: 0x000156F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069253, RefRangeEnd = 1069254, XrefRangeStart = 1069245, XrefRangeEnd = 1069253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseSelector(Selector selector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_ReleaseSelector_Public_Static_Void_Selector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00017528 File Offset: 0x00015728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1069402, RefRangeEnd = 1069403, XrefRangeStart = 1069254, XrefRangeEnd = 1069402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(FormatItem format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.NativeMethodInfoPtr_Release_Public_Static_Void_FormatItem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000334C File Offset: 0x0000154C
		public FormatItemPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00017560 File Offset: 0x00015760
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003355 File Offset: 0x00001555
		public unsafe static ObjectPool<LiteralText> s_LiteralTextPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatItemPool.NativeFieldInfoPtr_s_LiteralTextPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LiteralText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatItemPool.NativeFieldInfoPtr_s_LiteralTextPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00017588 File Offset: 0x00015788
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003367 File Offset: 0x00001567
		public unsafe static ObjectPool<Format> s_FormatPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatItemPool.NativeFieldInfoPtr_s_FormatPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Format>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatItemPool.NativeFieldInfoPtr_s_FormatPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000175B0 File Offset: 0x000157B0
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003379 File Offset: 0x00001579
		public unsafe static ObjectPool<Placeholder> s_PlaceholderPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatItemPool.NativeFieldInfoPtr_s_PlaceholderPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Placeholder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatItemPool.NativeFieldInfoPtr_s_PlaceholderPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000175D8 File Offset: 0x000157D8
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000338B File Offset: 0x0000158B
		public unsafe static ObjectPool<Selector> s_SelectorPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatItemPool.NativeFieldInfoPtr_s_SelectorPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Selector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatItemPool.NativeFieldInfoPtr_s_SelectorPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_s_LiteralTextPool;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_s_FormatPool;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_s_PlaceholderPool;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectorPool;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_Int32_Int32_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_GetLiteralText_Public_Static_LiteralText_SmartSettings_FormatItem_String_Int32_Int32_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_String_Int32_Int32_Boolean_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Static_Format_SmartSettings_Placeholder_Int32_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaceholder_Public_Static_Placeholder_SmartSettings_Format_Int32_Int32_Format_Int32_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_GetSelector_Public_Static_Selector_SmartSettings_FormatItem_String_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLiteralText_Public_Static_Void_LiteralText_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFormat_Public_Static_Void_Format_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePlaceholder_Public_Static_Void_Placeholder_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSelector_Public_Static_Void_Selector_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_FormatItem_0;

		// Token: 0x02000130 RID: 304
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.FormatItemPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D53 RID: 3411 RVA: 0x0003B2C4 File Offset: 0x000394C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatItemPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr);
				FormatItemPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, "<>9");
				FormatItemPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663930);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_0_Internal_LiteralText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663931);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_1_Internal_Void_LiteralText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663932);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_2_Internal_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663933);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_3_Internal_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663934);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_4_Internal_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663935);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_5_Internal_Void_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663936);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_6_Internal_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663937);
				FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_7_Internal_Void_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr, 100663938);
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x0003B3B8 File Offset: 0x000395B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatItemPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x0003B3F4 File Offset: 0x000395F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069083, XrefRangeEnd = 1069087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LiteralText __cctor_b__19_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_0_Internal_LiteralText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LiteralText>(intPtr3) : null;
			}

			// Token: 0x06000D56 RID: 3414 RVA: 0x0003B434 File Offset: 0x00039634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069087, XrefRangeEnd = 1069088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__19_1(LiteralText lt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_1_Internal_Void_LiteralText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x0003B478 File Offset: 0x00039678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069088, XrefRangeEnd = 1069092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Format __cctor_b__19_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_2_Internal_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x0003B4B8 File Offset: 0x000396B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069092, XrefRangeEnd = 1069094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__19_3(Format f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_3_Internal_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x0003B4FC File Offset: 0x000396FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069094, XrefRangeEnd = 1069098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Placeholder __cctor_b__19_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_4_Internal_Placeholder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x0003B53C File Offset: 0x0003973C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069098, XrefRangeEnd = 1069100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__19_5(Placeholder p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_5_Internal_Void_Placeholder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x0003B580 File Offset: 0x00039780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069100, XrefRangeEnd = 1069104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Selector __cctor_b__19_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_6_Internal_Selector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selector>(intPtr3) : null;
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x0003B5C0 File Offset: 0x000397C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__19_7(Selector s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItemPool.__c.NativeMethodInfoPtr___cctor_b__19_7_Internal_Void_Selector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x00007954 File Offset: 0x00005B54
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0003B604 File Offset: 0x00039804
			// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0000795D File Offset: 0x00005B5D
			public unsafe static FormatItemPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FormatItemPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatItemPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FormatItemPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000943 RID: 2371
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000944 RID: 2372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000945 RID: 2373
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_0_Internal_LiteralText_0;

			// Token: 0x04000946 RID: 2374
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_1_Internal_Void_LiteralText_0;

			// Token: 0x04000947 RID: 2375
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_2_Internal_Format_0;

			// Token: 0x04000948 RID: 2376
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_3_Internal_Void_Format_0;

			// Token: 0x04000949 RID: 2377
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_4_Internal_Placeholder_0;

			// Token: 0x0400094A RID: 2378
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_5_Internal_Void_Placeholder_0;

			// Token: 0x0400094B RID: 2379
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_6_Internal_Selector_0;

			// Token: 0x0400094C RID: 2380
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_7_Internal_Void_Selector_0;
		}
	}
}

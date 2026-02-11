using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000031 RID: 49
	public static class SmartExtensions : Object
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00015670 File Offset: 0x00013870
		// Note: this type is marked as 'beforefieldinit'.
		static SmartExtensions()
		{
			Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "SmartExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr);
			SmartExtensions.NativeMethodInfoPtr_AppendSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663855);
			SmartExtensions.NativeMethodInfoPtr_AppendLineSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663856);
			SmartExtensions.NativeMethodInfoPtr_WriteSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663857);
			SmartExtensions.NativeMethodInfoPtr_WriteLineSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663858);
			SmartExtensions.NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663859);
			SmartExtensions.NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_byref_FormatCache_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartExtensions>.NativeClassPtr, 100663860);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00015718 File Offset: 0x00013918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068441, XrefRangeEnd = 1068453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendSmart(this StringBuilder sb, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_AppendSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00015780 File Offset: 0x00013980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068453, XrefRangeEnd = 1068467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendLineSmart(this StringBuilder sb, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_AppendLineSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000157E8 File Offset: 0x000139E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068467, XrefRangeEnd = 1068479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteSmart(this TextWriter writer, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_WriteSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00015850 File Offset: 0x00013A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068479, XrefRangeEnd = 1068492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteLineSmart(this TextWriter writer, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_WriteLineSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000158B8 File Offset: 0x00013AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068492, XrefRangeEnd = 1068496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSmart(this string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00015914 File Offset: 0x00013B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068496, XrefRangeEnd = 1068504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSmart(this string format, ref FormatCache cache, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartExtensions.NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_byref_FormatCache_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new FormatCache(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000315A File Offset: 0x0000135A
		public static void AppendSmart(StringBuilder sb, string format, params Object[] args)
		{
			sb.AppendSmart(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003169 File Offset: 0x00001369
		public static void AppendLineSmart(StringBuilder sb, string format, params Object[] args)
		{
			sb.AppendLineSmart(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003178 File Offset: 0x00001378
		public static void WriteSmart(TextWriter writer, string format, params Object[] args)
		{
			writer.WriteSmart(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003187 File Offset: 0x00001387
		public static void WriteLineSmart(TextWriter writer, string format, params Object[] args)
		{
			writer.WriteLineSmart(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003196 File Offset: 0x00001396
		public static string FormatSmart(string format, params Object[] args)
		{
			return format.FormatSmart(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000031A4 File Offset: 0x000013A4
		public static string FormatSmart(string format, ref FormatCache cache, params Object[] args)
		{
			return format.FormatSmart(ref cache, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000031B3 File Offset: 0x000013B3
		public SmartExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_AppendSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_AppendLineSmart_Public_Static_Void_StringBuilder_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_WriteSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_WriteLineSmart_Public_Static_Void_TextWriter_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_FormatSmart_Public_Static_String_String_byref_FormatCache_Il2CppReferenceArray_1_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000063 RID: 99
	public static class MiscellaneousUtils : Object
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x0003AA60 File Offset: 0x00038C60
		// Note: this type is marked as 'beforefieldinit'.
		static MiscellaneousUtils()
		{
			Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "MiscellaneousUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr);
			MiscellaneousUtils.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664967);
			MiscellaneousUtils.NativeMethodInfoPtr_ValueEquals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664968);
			MiscellaneousUtils.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Public_Static_ArgumentOutOfRangeException_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664969);
			MiscellaneousUtils.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664970);
			MiscellaneousUtils.NativeMethodInfoPtr_ByteArrayCompare_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664971);
			MiscellaneousUtils.NativeMethodInfoPtr_GetPrefix_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664972);
			MiscellaneousUtils.NativeMethodInfoPtr_GetLocalName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664973);
			MiscellaneousUtils.NativeMethodInfoPtr_GetQualifiedNameParts_Public_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664974);
			MiscellaneousUtils.NativeMethodInfoPtr_GetRegexOptions_Internal_Static_RegexOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscellaneousUtils>.NativeClassPtr, 100664975);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0003AB44 File Offset: 0x00038D44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition, string message = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0003AB88 File Offset: 0x00038D88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 744699, RefRangeEnd = 744705, XrefRangeStart = 744687, XrefRangeEnd = 744699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValueEquals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_ValueEquals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0003ABDC File Offset: 0x00038DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744705, XrefRangeEnd = 744718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, Object actualValue, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actualValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Public_Static_ArgumentOutOfRangeException_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003AC44 File Offset: 0x00038E44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 744725, RefRangeEnd = 744731, XrefRangeStart = 744718, XrefRangeEnd = 744725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0003AC80 File Offset: 0x00038E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744731, XrefRangeEnd = 744734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ByteArrayCompare(Il2CppStructArray<byte> a1, Il2CppStructArray<byte> a2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_ByteArrayCompare_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744741, RefRangeEnd = 744743, XrefRangeStart = 744734, XrefRangeEnd = 744741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPrefix(string qualifiedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_GetPrefix_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003AD10 File Offset: 0x00038F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744750, RefRangeEnd = 744752, XrefRangeStart = 744743, XrefRangeEnd = 744750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalName(string qualifiedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_GetLocalName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0003AD4C File Offset: 0x00038F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744760, RefRangeEnd = 744761, XrefRangeStart = 744752, XrefRangeEnd = 744760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_GetQualifiedNameParts_Public_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			localName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0003ADB8 File Offset: 0x00038FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744766, RefRangeEnd = 744769, XrefRangeStart = 744761, XrefRangeEnd = 744766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexOptions GetRegexOptions(string optionsText)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionsText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscellaneousUtils.NativeMethodInfoPtr_GetRegexOptions_Internal_Static_RegexOptions_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00004C20 File Offset: 0x00002E20
		public MiscellaneousUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_ValueEquals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Public_Static_ArgumentOutOfRangeException_String_Object_String_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_ByteArrayCompare_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefix_Public_Static_String_String_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalName_Public_Static_String_String_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_GetQualifiedNameParts_Public_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_GetRegexOptions_Internal_Static_RegexOptions_String_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Text
{
	// Token: 0x02000218 RID: 536
	public static class EncodingHelper : Object
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x000C8AA8 File Offset: 0x000C6CA8
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingHelper()
		{
			Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr);
			EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "utf8EncodingWithoutMarkers");
			EncodingHelper.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "lockobj");
			EncodingHelper.NativeFieldInfoPtr_i18nAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nAssembly");
			EncodingHelper.NativeFieldInfoPtr_i18nDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nDisabled");
			EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669340);
			EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669341);
			EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669342);
			EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669343);
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x000C8B78 File Offset: 0x000C6D78
		public unsafe static Encoding UTF8Unmarked
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1369423, RefRangeEnd = 1369429, XrefRangeStart = 1369391, XrefRangeEnd = 1369423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000C8BAC File Offset: 0x000C6DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369430, RefRangeEnd = 1369431, XrefRangeStart = 1369429, XrefRangeEnd = 1369430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalCodePage(ref int code_page)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &code_page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000C8BE4 File Offset: 0x000C6DE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369447, RefRangeEnd = 1369450, XrefRangeStart = 1369431, XrefRangeEnd = 1369447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000C8C18 File Offset: 0x000C6E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369522, RefRangeEnd = 1369523, XrefRangeStart = 1369450, XrefRangeEnd = 1369522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeI18N(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0000B68C File Offset: 0x0000988C
		public static Object InvokeI18N(string name, params Object[] args)
		{
			return EncodingHelper.InvokeI18N(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0000B69A File Offset: 0x0000989A
		public EncodingHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000C8C7C File Offset: 0x000C6E7C
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0000B6A3 File Offset: 0x000098A3
		public unsafe static Encoding utf8EncodingWithoutMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000C8CA4 File Offset: 0x000C6EA4
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x0000B6B5 File Offset: 0x000098B5
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000C8CCC File Offset: 0x000C6ECC
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0000B6C7 File Offset: 0x000098C7
		public unsafe static Assembly i18nAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000C8CF4 File Offset: 0x000C6EF4
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x0000B6D9 File Offset: 0x000098D9
		public unsafe static bool i18nDisabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&value));
			}
		}

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_utf8EncodingWithoutMarkers;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeFieldInfoPtr_i18nAssembly;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeFieldInfoPtr_i18nDisabled;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.utils.localization
{
	// Token: 0x02000013 RID: 19
	public class TextVariables : Object
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00007B58 File Offset: 0x00005D58
		// Note: this type is marked as 'beforefieldinit'.
		static TextVariables()
		{
			Il2CppClassPointerStore<TextVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "TextVariables");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextVariables>.NativeClassPtr);
			TextVariables.NativeFieldInfoPtr_CustomAttributeVarPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "CustomAttributeVarPrefix");
			TextVariables.NativeFieldInfoPtr_numberMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "numberMap");
			TextVariables.NativeFieldInfoPtr_stringMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "stringMap");
			TextVariables.NativeFieldInfoPtr_varMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "varMap");
			TextVariables.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663423);
			TextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663424);
			TextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663425);
			TextVariables.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Int32_Dictionary_2_String_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663426);
			TextVariables.NativeMethodInfoPtr__ctor_Public_Void_TextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663427);
			TextVariables.NativeMethodInfoPtr_Clone_Public_TextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663428);
			TextVariables.NativeMethodInfoPtr_WithNumber_Public_TextVariables_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663429);
			TextVariables.NativeMethodInfoPtr_WithVar_Public_TextVariables_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663430);
			TextVariables.NativeMethodInfoPtr_WithObject_Public_TextVariables_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663431);
			TextVariables.NativeMethodInfoPtr_Apply_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663432);
			TextVariables.NativeMethodInfoPtr_SanitizeStringMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663433);
			TextVariables.NativeMethodInfoPtr_substNumbers_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663434);
			TextVariables.NativeMethodInfoPtr_substStrings_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663435);
			TextVariables.NativeMethodInfoPtr_substVars_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, 100663436);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007CF0 File Offset: 0x00005EF0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007D2C File Offset: 0x00005F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178272, XrefRangeEnd = 1178284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables(string k1, int v1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(k1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007D88 File Offset: 0x00005F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178284, XrefRangeEnd = 1178296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables(string k1, string v1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(k1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(v1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables(Dictionary<string, int> numberMap, Dictionary<string, string> stringMap, Dictionary<string, Object> varMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(numberMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(varMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Int32_Dictionary_2_String_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007E58 File Offset: 0x00006058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178318, RefRangeEnd = 1178319, XrefRangeStart = 1178296, XrefRangeEnd = 1178318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables(TextVariables original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr__ctor_Public_Void_TextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007EA4 File Offset: 0x000060A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178344, RefRangeEnd = 1178345, XrefRangeStart = 1178319, XrefRangeEnd = 1178344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_Clone_Public_TextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr3) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007EE4 File Offset: 0x000060E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178345, XrefRangeEnd = 1178355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables WithNumber(string key, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_WithNumber_Public_TextVariables_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007F44 File Offset: 0x00006144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1178365, RefRangeEnd = 1178367, XrefRangeStart = 1178355, XrefRangeEnd = 1178365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables WithVar(string key, string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_WithVar_Public_TextVariables_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr3) : null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007FA8 File Offset: 0x000061A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178367, XrefRangeEnd = 1178377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextVariables WithObject(string key, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_WithObject_Public_TextVariables_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr3) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000800C File Offset: 0x0000620C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178495, RefRangeEnd = 1178496, XrefRangeStart = 1178377, XrefRangeEnd = 1178495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Apply(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_Apply_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008054 File Offset: 0x00006254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178496, XrefRangeEnd = 1178533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SanitizeStringMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_SanitizeStringMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00008088 File Offset: 0x00006288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178558, RefRangeEnd = 1178559, XrefRangeStart = 1178533, XrefRangeEnd = 1178558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string substNumbers(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_substNumbers_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000080D0 File Offset: 0x000062D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178584, RefRangeEnd = 1178585, XrefRangeStart = 1178559, XrefRangeEnd = 1178584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string substStrings(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_substStrings_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00008118 File Offset: 0x00006318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178668, RefRangeEnd = 1178669, XrefRangeStart = 1178585, XrefRangeEnd = 1178668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string substVars(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.NativeMethodInfoPtr_substVars_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000242A File Offset: 0x0000062A
		public TextVariables(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008160 File Offset: 0x00006360
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002433 File Offset: 0x00000633
		public unsafe static string CustomAttributeVarPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextVariables.NativeFieldInfoPtr_CustomAttributeVarPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextVariables.NativeFieldInfoPtr_CustomAttributeVarPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008180 File Offset: 0x00006380
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002445 File Offset: 0x00000645
		public unsafe Dictionary<string, int> numberMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_numberMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_numberMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000081B0 File Offset: 0x000063B0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002464 File Offset: 0x00000664
		public unsafe Dictionary<string, string> stringMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_stringMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_stringMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000081E0 File Offset: 0x000063E0
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002483 File Offset: 0x00000683
		public unsafe Dictionary<string, Object> varMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_varMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextVariables.NativeFieldInfoPtr_varMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_CustomAttributeVarPrefix;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_numberMap;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_stringMap;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_varMap;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Int32_Dictionary_2_String_String_Dictionary_2_String_Object_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextVariables_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_TextVariables_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_WithNumber_Public_TextVariables_String_Int32_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_WithVar_Public_TextVariables_String_String_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_WithObject_Public_TextVariables_String_Object_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_String_String_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeStringMap_Public_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_substNumbers_Private_String_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_substStrings_Private_String_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_substVars_Private_String_String_0;

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("Canis.utils.localization.TextVariables+<>O")]
		public static class __O : Object
		{
			// Token: 0x060002BB RID: 699 RVA: 0x00002DD9 File Offset: 0x00000FD9
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<TextVariables.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextVariables.__O>.NativeClassPtr);
				TextVariables.__O.NativeFieldInfoPtr__0___LT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__O>.NativeClassPtr, "<0>__LT");
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00002E0D File Offset: 0x0000100D
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060002BD RID: 701 RVA: 0x0000F88C File Offset: 0x0000DA8C
			// (set) Token: 0x060002BE RID: 702 RVA: 0x00002E16 File Offset: 0x00001016
			public unsafe static Func<string, string> _0___LT
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__O.NativeFieldInfoPtr__0___LT, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__O.NativeFieldInfoPtr__0___LT, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr__0___LT;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("Canis.utils.localization.TextVariables+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002BF RID: 703 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextVariables>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr);
				TextVariables.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, "<>9");
				TextVariables.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, "<>9__13_0");
				TextVariables.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, "<>9__13_1");
				TextVariables.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, "<>9__13_2");
				TextVariables.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, "<>9__17_0");
				TextVariables.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, 100663438);
				TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, 100663439);
				TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_1_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, 100663440);
				TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_2_Internal_String_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, 100663441);
				TextVariables.__c.NativeMethodInfoPtr__substVars_b__17_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr, 100663442);
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextVariables.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0000F9E4 File Offset: 0x0000DBE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178235, XrefRangeEnd = 1178240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Apply_b__13_0(KeyValuePair<string, string> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0000FA34 File Offset: 0x0000DC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178240, XrefRangeEnd = 1178245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Apply_b__13_1(KeyValuePair<string, Object> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_1_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0000FA84 File Offset: 0x0000DC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178245, XrefRangeEnd = 1178253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Apply_b__13_2(KeyValuePair<string, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.__c.NativeMethodInfoPtr__Apply_b__13_2_Internal_String_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178253, XrefRangeEnd = 1178272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _substVars_b__17_0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextVariables.__c.NativeMethodInfoPtr__substVars_b__17_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x00002E28 File Offset: 0x00001028
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000FB1C File Offset: 0x0000DD1C
			// (set) Token: 0x060002C7 RID: 711 RVA: 0x00002E31 File Offset: 0x00001031
			public unsafe static TextVariables.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextVariables.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000FB44 File Offset: 0x0000DD44
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x00002E43 File Offset: 0x00001043
			public unsafe static Func<KeyValuePair<string, string>, string> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000FB6C File Offset: 0x0000DD6C
			// (set) Token: 0x060002CB RID: 715 RVA: 0x00002E55 File Offset: 0x00001055
			public unsafe static Func<KeyValuePair<string, Object>, string> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000FB94 File Offset: 0x0000DD94
			// (set) Token: 0x060002CD RID: 717 RVA: 0x00002E67 File Offset: 0x00001067
			public unsafe static Func<KeyValuePair<string, int>, string> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000FBBC File Offset: 0x0000DDBC
			// (set) Token: 0x060002CF RID: 719 RVA: 0x00002E79 File Offset: 0x00001079
			public unsafe static Func<Object, string> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextVariables.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextVariables.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__13_0_Internal_String_KeyValuePair_2_String_String_0;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__13_1_Internal_String_KeyValuePair_2_String_Object_0;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeMethodInfoPtr__Apply_b__13_2_Internal_String_KeyValuePair_2_String_Int32_0;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr__substVars_b__17_0_Internal_String_Object_0;
		}
	}
}

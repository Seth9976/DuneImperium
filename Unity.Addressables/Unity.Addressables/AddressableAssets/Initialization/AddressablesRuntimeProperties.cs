using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.AddressableAssets.Initialization
{
	// Token: 0x02000025 RID: 37
	public static class AddressablesRuntimeProperties : Object
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0001182C File Offset: 0x0000FA2C
		// Note: this type is marked as 'beforefieldinit'.
		static AddressablesRuntimeProperties()
		{
			Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Initialization", "AddressablesRuntimeProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr);
			AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, "s_TokenStack");
			AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStartStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, "s_TokenStartStack");
			AddressablesRuntimeProperties.NativeFieldInfoPtr_s_StaticStacksAreInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, "s_StaticStacksAreInUse");
			AddressablesRuntimeProperties.NativeFieldInfoPtr_s_CachedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, "s_CachedValues");
			AddressablesRuntimeProperties.NativeMethodInfoPtr_GetAssemblies_Private_Static_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663879);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_GetCachedValueCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663880);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_SetPropertyValue_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663881);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_ClearCachedPropertyValues_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663882);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateProperty_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663883);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663884);
			AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_Char_Char_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, 100663885);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00011938 File Offset: 0x0000FB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164473, XrefRangeEnd = 1164476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Assembly> GetAssemblies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_GetAssemblies_Private_Static_Il2CppReferenceArray_1_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001196C File Offset: 0x0000FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164476, XrefRangeEnd = 1164484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCachedValueCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_GetCachedValueCount_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001199C File Offset: 0x0000FB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164484, XrefRangeEnd = 1164521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropertyValue(string name, string val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_SetPropertyValue_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000119E4 File Offset: 0x0000FBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164521, XrefRangeEnd = 1164529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedPropertyValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_ClearCachedPropertyValues_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00011A0C File Offset: 0x0000FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164529, XrefRangeEnd = 1164564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateProperty(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateProperty_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00011A48 File Offset: 0x0000FC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164564, XrefRangeEnd = 1164579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateString(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00011A84 File Offset: 0x0000FC84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1164656, RefRangeEnd = 1164658, XrefRangeStart = 1164579, XrefRangeEnd = 1164656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelimiter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endDelimiter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(varFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressablesRuntimeProperties.NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_Char_Char_Func_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002F85 File Offset: 0x00001185
		public AddressablesRuntimeProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002F8E File Offset: 0x0000118E
		public unsafe static Stack<string> s_TokenStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00011B18 File Offset: 0x0000FD18
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00002FA0 File Offset: 0x000011A0
		public unsafe static Stack<int> s_TokenStartStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStartStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_TokenStartStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00011B40 File Offset: 0x0000FD40
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00002FB2 File Offset: 0x000011B2
		public unsafe static bool s_StaticStacksAreInUse
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_StaticStacksAreInUse, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_StaticStacksAreInUse, (void*)(&value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00011B5C File Offset: 0x0000FD5C
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00002FC0 File Offset: 0x000011C0
		public unsafe static Dictionary<string, string> s_CachedValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_CachedValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressablesRuntimeProperties.NativeFieldInfoPtr_s_CachedValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_s_TokenStack;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_s_TokenStartStack;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_s_StaticStacksAreInUse;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_s_CachedValues;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Private_Static_Il2CppReferenceArray_1_Assembly_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValueCount_Internal_Static_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyValue_Public_Static_Void_String_String_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedPropertyValues_Public_Static_Void_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateProperty_Public_Static_String_String_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateString_Public_Static_String_String_Char_Char_Func_2_String_String_0;

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("UnityEngine.AddressableAssets.Initialization.AddressablesRuntimeProperties+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000562 RID: 1378 RVA: 0x0000443E File Offset: 0x0000263E
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<AddressablesRuntimeProperties.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressablesRuntimeProperties>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressablesRuntimeProperties.__O>.NativeClassPtr);
				AddressablesRuntimeProperties.__O.NativeFieldInfoPtr__0___EvaluateProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressablesRuntimeProperties.__O>.NativeClassPtr, "<0>__EvaluateProperty");
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x00004472 File Offset: 0x00002672
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x00019240 File Offset: 0x00017440
			// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000447B File Offset: 0x0000267B
			public unsafe static Func<string, string> _0___EvaluateProperty
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddressablesRuntimeProperties.__O.NativeFieldInfoPtr__0___EvaluateProperty, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddressablesRuntimeProperties.__O.NativeFieldInfoPtr__0___EvaluateProperty, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003C2 RID: 962
			private static readonly IntPtr NativeFieldInfoPtr__0___EvaluateProperty;
		}
	}
}

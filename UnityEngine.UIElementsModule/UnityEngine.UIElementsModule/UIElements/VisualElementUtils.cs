using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000233 RID: 563
	public static class VisualElementUtils : Object
	{
		// Token: 0x060029A4 RID: 10660 RVA: 0x000B60AC File Offset: 0x000B42AC
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementUtils()
		{
			Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr);
			VisualElementUtils.NativeFieldInfoPtr_s_usedNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, "s_usedNames");
			VisualElementUtils.NativeFieldInfoPtr_s_FoldoutType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, "s_FoldoutType");
			VisualElementUtils.NativeFieldInfoPtr_s_InspectorElementUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, "s_InspectorElementUssClassName");
			VisualElementUtils.NativeMethodInfoPtr_GetUniqueName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, 100669548);
			VisualElementUtils.NativeMethodInfoPtr_GetFoldoutDepth_Internal_Static_Int32_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, 100669549);
			VisualElementUtils.NativeMethodInfoPtr_AssignInspectorStyleIfNecessary_Internal_Static_Void_VisualElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, 100669550);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000B6154 File Offset: 0x000B4354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346764, RefRangeEnd = 346765, XrefRangeStart = 346748, XrefRangeEnd = 346764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetUniqueName(string nameBase)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(nameBase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementUtils.NativeMethodInfoPtr_GetUniqueName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000B6190 File Offset: 0x000B4390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346773, RefRangeEnd = 346776, XrefRangeStart = 346765, XrefRangeEnd = 346773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFoldoutDepth(this VisualElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementUtils.NativeMethodInfoPtr_GetFoldoutDepth_Internal_Static_Int32_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000B61D4 File Offset: 0x000B43D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346794, RefRangeEnd = 346795, XrefRangeStart = 346776, XrefRangeEnd = 346794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignInspectorStyleIfNecessary(this VisualElement element, string classNameToEnable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(classNameToEnable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementUtils.NativeMethodInfoPtr_AssignInspectorStyleIfNecessary_Internal_Static_Void_VisualElement_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00010C00 File Offset: 0x0000EE00
		public VisualElementUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x000B621C File Offset: 0x000B441C
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x00010C09 File Offset: 0x0000EE09
		public unsafe static HashSet<string> s_usedNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementUtils.NativeFieldInfoPtr_s_usedNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementUtils.NativeFieldInfoPtr_s_usedNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000B6244 File Offset: 0x000B4444
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x00010C1B File Offset: 0x0000EE1B
		public unsafe static Type s_FoldoutType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementUtils.NativeFieldInfoPtr_s_FoldoutType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementUtils.NativeFieldInfoPtr_s_FoldoutType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x000B626C File Offset: 0x000B446C
		// (set) Token: 0x060029AE RID: 10670 RVA: 0x00010C2D File Offset: 0x0000EE2D
		public unsafe static string s_InspectorElementUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementUtils.NativeFieldInfoPtr_s_InspectorElementUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementUtils.NativeFieldInfoPtr_s_InspectorElementUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeFieldInfoPtr_s_usedNames;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeFieldInfoPtr_s_FoldoutType;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeFieldInfoPtr_s_InspectorElementUssClassName;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_GetUniqueName_Public_Static_String_String_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_GetFoldoutDepth_Internal_Static_Int32_VisualElement_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_AssignInspectorStyleIfNecessary_Internal_Static_Void_VisualElement_String_0;

		// Token: 0x02000532 RID: 1330
		[ObfuscatedName("UnityEngine.UIElements.VisualElementUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060040A1 RID: 16545 RVA: 0x00100344 File Offset: 0x000FE544
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElementUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr);
				VisualElementUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr, "<>9");
				VisualElementUtils.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr, "<>9__5_0");
				VisualElementUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr, 100669553);
				VisualElementUtils.__c.NativeMethodInfoPtr__AssignInspectorStyleIfNecessary_b__5_0_Internal_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr, 100669554);
			}

			// Token: 0x060040A2 RID: 16546 RVA: 0x001003C0 File Offset: 0x000FE5C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040A3 RID: 16547 RVA: 0x001003FC File Offset: 0x000FE5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346742, XrefRangeEnd = 346748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AssignInspectorStyleIfNecessary_b__5_0(VisualElement i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementUtils.__c.NativeMethodInfoPtr__AssignInspectorStyleIfNecessary_b__5_0_Internal_Boolean_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060040A4 RID: 16548 RVA: 0x0001B387 File Offset: 0x00019587
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001359 RID: 4953
			// (get) Token: 0x060040A5 RID: 16549 RVA: 0x0010044C File Offset: 0x000FE64C
			// (set) Token: 0x060040A6 RID: 16550 RVA: 0x0001B390 File Offset: 0x00019590
			public unsafe static VisualElementUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualElementUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualElementUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700135A RID: 4954
			// (get) Token: 0x060040A7 RID: 16551 RVA: 0x00100474 File Offset: 0x000FE674
			// (set) Token: 0x060040A8 RID: 16552 RVA: 0x0001B3A2 File Offset: 0x000195A2
			public unsafe static Predicate<VisualElement> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualElementUtils.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<VisualElement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualElementUtils.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D7E RID: 11646
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D7F RID: 11647
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04002D80 RID: 11648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D81 RID: 11649
			private static readonly IntPtr NativeMethodInfoPtr__AssignInspectorStyleIfNecessary_b__5_0_Internal_Boolean_VisualElement_0;
		}

		// Token: 0x02000533 RID: 1331
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

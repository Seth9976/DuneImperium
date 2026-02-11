using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E7 RID: 487
	public static class UQuery : Object
	{
		// Token: 0x06002691 RID: 9873 RVA: 0x0000FA30 File Offset: 0x0000DC30
		// Note: this type is marked as 'beforefieldinit'.
		static UQuery()
		{
			Il2CppClassPointerStore<UQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery>.NativeClassPtr);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0000FA55 File Offset: 0x0000DC55
		public UQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020004EF RID: 1263
		public class IVisualPredicateWrapper : Il2CppObjectBase
		{
			// Token: 0x06003F5B RID: 16219 RVA: 0x0001A961 File Offset: 0x00018B61
			// Note: this type is marked as 'beforefieldinit'.
			static IVisualPredicateWrapper()
			{
				Il2CppClassPointerStore<UQuery.IVisualPredicateWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery>.NativeClassPtr, "IVisualPredicateWrapper");
				UQuery.IVisualPredicateWrapper.NativeMethodInfoPtr_Predicate_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.IVisualPredicateWrapper>.NativeClassPtr, 100669139);
			}

			// Token: 0x06003F5C RID: 16220 RVA: 0x000FC680 File Offset: 0x000FA880
			[CallerCount(0)]
			public unsafe virtual bool Predicate(Object e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.IVisualPredicateWrapper.NativeMethodInfoPtr_Predicate_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003F5D RID: 16221 RVA: 0x0001A98B File Offset: 0x00018B8B
			public IVisualPredicateWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002CC4 RID: 11460
			private static readonly IntPtr NativeMethodInfoPtr_Predicate_Public_Abstract_Virtual_New_Boolean_Object_0;
		}

		// Token: 0x020004F0 RID: 1264
		public class IsOfType<T> : Object where T : VisualElement
		{
			// Token: 0x06003F5E RID: 16222 RVA: 0x000FC6D8 File Offset: 0x000FA8D8
			// Note: this type is marked as 'beforefieldinit'.
			static IsOfType()
			{
				Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery>.NativeClassPtr, "IsOfType`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr);
				UQuery.IsOfType<T>.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr, "s_Instance");
				UQuery.IsOfType<T>.NativeMethodInfoPtr_Predicate_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr, 100669140);
				UQuery.IsOfType<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr, 100669141);
			}

			// Token: 0x06003F5F RID: 16223 RVA: 0x000FC77C File Offset: 0x000FA97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342262, XrefRangeEnd = 342264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Predicate(Object e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.IsOfType<T>.NativeMethodInfoPtr_Predicate_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003F60 RID: 16224 RVA: 0x000FC7CC File Offset: 0x000FA9CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IsOfType()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQuery.IsOfType<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.IsOfType<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F61 RID: 16225 RVA: 0x0001A994 File Offset: 0x00018B94
			public IsOfType(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001302 RID: 4866
			// (get) Token: 0x06003F62 RID: 16226 RVA: 0x000FC808 File Offset: 0x000FAA08
			// (set) Token: 0x06003F63 RID: 16227 RVA: 0x0001A99D File Offset: 0x00018B9D
			public unsafe static UQuery.IsOfType<T> s_Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UQuery.IsOfType<T>.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQuery.IsOfType<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UQuery.IsOfType<T>.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CC5 RID: 11461
			private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

			// Token: 0x04002CC6 RID: 11462
			private static readonly IntPtr NativeMethodInfoPtr_Predicate_Public_Virtual_Final_New_Boolean_Object_0;

			// Token: 0x04002CC7 RID: 11463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004F1 RID: 1265
		public class UQueryMatcher : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
		{
			// Token: 0x06003F64 RID: 16228 RVA: 0x000FC830 File Offset: 0x000FAA30
			// Note: this type is marked as 'beforefieldinit'.
			static UQueryMatcher()
			{
				Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery>.NativeClassPtr, "UQueryMatcher");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr);
				UQuery.UQueryMatcher.NativeFieldInfoPtr_m_Matchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, "m_Matchers");
				UQuery.UQueryMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669143);
				UQuery.UQueryMatcher.NativeMethodInfoPtr_Traverse_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669144);
				UQuery.UQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_New_Boolean_RuleMatcher_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669145);
				UQuery.UQueryMatcher.NativeMethodInfoPtr_NoProcessResult_Private_Static_Void_VisualElement_MatchResultInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669146);
				UQuery.UQueryMatcher.NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669147);
				UQuery.UQueryMatcher.NativeMethodInfoPtr_Run_Public_Virtual_New_Void_VisualElement_List_1_RuleMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, 100669148);
			}

			// Token: 0x06003F65 RID: 16229 RVA: 0x000FC8E8 File Offset: 0x000FAAE8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UQueryMatcher()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.UQueryMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F66 RID: 16230 RVA: 0x000FC924 File Offset: 0x000FAB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342264, XrefRangeEnd = 342265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Traverse(VisualElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.UQueryMatcher.NativeMethodInfoPtr_Traverse_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003F67 RID: 16231 RVA: 0x000FC974 File Offset: 0x000FAB74
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(matcher));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.UQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_New_Boolean_RuleMatcher_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F68 RID: 16232 RVA: 0x000FC9E4 File Offset: 0x000FABE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void NoProcessResult(VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.UQueryMatcher.NativeMethodInfoPtr_NoProcessResult_Private_Static_Void_VisualElement_MatchResultInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F69 RID: 16233 RVA: 0x000FCA28 File Offset: 0x000FAC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342265, XrefRangeEnd = 342289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void TraverseRecursive(VisualElement element, int depth)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.UQueryMatcher.NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F6A RID: 16234 RVA: 0x000FCA84 File Offset: 0x000FAC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342289, XrefRangeEnd = 342290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Run(VisualElement root, List<RuleMatcher> matchers)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.UQueryMatcher.NativeMethodInfoPtr_Run_Public_Virtual_New_Void_VisualElement_List_1_RuleMatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F6B RID: 16235 RVA: 0x0001A9AF File Offset: 0x00018BAF
			public UQueryMatcher(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001303 RID: 4867
			// (get) Token: 0x06003F6C RID: 16236 RVA: 0x000FCAE4 File Offset: 0x000FACE4
			// (set) Token: 0x06003F6D RID: 16237 RVA: 0x0001A9B8 File Offset: 0x00018BB8
			public unsafe List<RuleMatcher> m_Matchers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQuery.UQueryMatcher.NativeFieldInfoPtr_m_Matchers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuleMatcher>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQuery.UQueryMatcher.NativeFieldInfoPtr_m_Matchers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CC8 RID: 11464
			private static readonly IntPtr NativeFieldInfoPtr_m_Matchers;

			// Token: 0x04002CC9 RID: 11465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x04002CCA RID: 11466
			private static readonly IntPtr NativeMethodInfoPtr_Traverse_Public_Virtual_Void_VisualElement_0;

			// Token: 0x04002CCB RID: 11467
			private static readonly IntPtr NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_New_Boolean_RuleMatcher_VisualElement_0;

			// Token: 0x04002CCC RID: 11468
			private static readonly IntPtr NativeMethodInfoPtr_NoProcessResult_Private_Static_Void_VisualElement_MatchResultInfo_0;

			// Token: 0x04002CCD RID: 11469
			private static readonly IntPtr NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0;

			// Token: 0x04002CCE RID: 11470
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_Void_VisualElement_List_1_RuleMatcher_0;

			// Token: 0x0200059D RID: 1437
			[ObfuscatedName("UnityEngine.UIElements.UQuery+UQueryMatcher+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060042FB RID: 17147 RVA: 0x001065E0 File Offset: 0x001047E0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery.UQueryMatcher>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr);
					UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr, "<>9");
					UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr, "<>9__5_0");
					UQuery.UQueryMatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr, 100669150);
					UQuery.UQueryMatcher.__c.NativeMethodInfoPtr__TraverseRecursive_b__5_0_Internal_Void_VisualElement_MatchResultInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr, 100669151);
				}

				// Token: 0x060042FC RID: 17148 RVA: 0x0010665C File Offset: 0x0010485C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQuery.UQueryMatcher.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.UQueryMatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042FD RID: 17149 RVA: 0x00106698 File Offset: 0x00104898
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _TraverseRecursive_b__5_0(VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.UQueryMatcher.__c.NativeMethodInfoPtr__TraverseRecursive_b__5_0_Internal_Void_VisualElement_MatchResultInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042FE RID: 17150 RVA: 0x0001C9D3 File Offset: 0x0001ABD3
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001408 RID: 5128
				// (get) Token: 0x060042FF RID: 17151 RVA: 0x001066E8 File Offset: 0x001048E8
				// (set) Token: 0x06004300 RID: 17152 RVA: 0x0001C9DC File Offset: 0x0001ABDC
				public unsafe static UQuery.UQueryMatcher.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQuery.UQueryMatcher.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001409 RID: 5129
				// (get) Token: 0x06004301 RID: 17153 RVA: 0x00106710 File Offset: 0x00104910
				// (set) Token: 0x06004302 RID: 17154 RVA: 0x0001C9EE File Offset: 0x0001ABEE
				public unsafe static Action<VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo> __9__5_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UQuery.UQueryMatcher.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002ED8 RID: 11992
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04002ED9 RID: 11993
				private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

				// Token: 0x04002EDA RID: 11994
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002EDB RID: 11995
				private static readonly IntPtr NativeMethodInfoPtr__TraverseRecursive_b__5_0_Internal_Void_VisualElement_MatchResultInfo_0;
			}

			// Token: 0x0200059E RID: 1438
			[Serializable]
			public sealed class <>c
			{
			}
		}

		// Token: 0x020004F2 RID: 1266
		public class SingleQueryMatcher : UQuery.UQueryMatcher
		{
			// Token: 0x06003F6E RID: 16238 RVA: 0x000FCB14 File Offset: 0x000FAD14
			// Note: this type is marked as 'beforefieldinit'.
			static SingleQueryMatcher()
			{
				Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery>.NativeClassPtr, "SingleQueryMatcher");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr);
				UQuery.SingleQueryMatcher.NativeFieldInfoPtr__match_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, "<match>k__BackingField");
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr_get_match_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669152);
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr_set_match_Public_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669153);
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr_Run_Public_Virtual_Void_VisualElement_List_1_RuleMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669154);
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr_IsInUse_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669155);
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr_CreateNew_Public_Abstract_Virtual_New_SingleQueryMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669156);
				UQuery.SingleQueryMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr, 100669157);
			}

			// Token: 0x17001305 RID: 4869
			// (get) Token: 0x06003F6F RID: 16239 RVA: 0x000FCBCC File Offset: 0x000FADCC
			// (set) Token: 0x06003F70 RID: 16240 RVA: 0x000FCC0C File Offset: 0x000FAE0C
			public unsafe VisualElement match
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.SingleQueryMatcher.NativeMethodInfoPtr_get_match_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.SingleQueryMatcher.NativeMethodInfoPtr_set_match_Public_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003F71 RID: 16241 RVA: 0x000FCC50 File Offset: 0x000FAE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342290, XrefRangeEnd = 342293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Run(VisualElement root, List<RuleMatcher> matchers)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.SingleQueryMatcher.NativeMethodInfoPtr_Run_Public_Virtual_Void_VisualElement_List_1_RuleMatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F72 RID: 16242 RVA: 0x000FCCB0 File Offset: 0x000FAEB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 342293, RefRangeEnd = 342294, XrefRangeStart = 342293, XrefRangeEnd = 342293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsInUse()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.SingleQueryMatcher.NativeMethodInfoPtr_IsInUse_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F73 RID: 16243 RVA: 0x000FCCEC File Offset: 0x000FAEEC
			[CallerCount(0)]
			public unsafe virtual UQuery.SingleQueryMatcher CreateNew()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.SingleQueryMatcher.NativeMethodInfoPtr_CreateNew_Public_Abstract_Virtual_New_SingleQueryMatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UQuery.SingleQueryMatcher>(intPtr3) : null;
			}

			// Token: 0x06003F74 RID: 16244 RVA: 0x000FCD38 File Offset: 0x000FAF38
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleQueryMatcher()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQuery.SingleQueryMatcher>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.SingleQueryMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F75 RID: 16245 RVA: 0x0001A9D7 File Offset: 0x00018BD7
			public SingleQueryMatcher(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001304 RID: 4868
			// (get) Token: 0x06003F76 RID: 16246 RVA: 0x000FCD74 File Offset: 0x000FAF74
			// (set) Token: 0x06003F77 RID: 16247 RVA: 0x0001A9E0 File Offset: 0x00018BE0
			public unsafe VisualElement _match_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQuery.SingleQueryMatcher.NativeFieldInfoPtr__match_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQuery.SingleQueryMatcher.NativeFieldInfoPtr__match_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CCF RID: 11471
			private static readonly IntPtr NativeFieldInfoPtr__match_k__BackingField;

			// Token: 0x04002CD0 RID: 11472
			private static readonly IntPtr NativeMethodInfoPtr_get_match_Public_get_VisualElement_0;

			// Token: 0x04002CD1 RID: 11473
			private static readonly IntPtr NativeMethodInfoPtr_set_match_Public_set_Void_VisualElement_0;

			// Token: 0x04002CD2 RID: 11474
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_VisualElement_List_1_RuleMatcher_0;

			// Token: 0x04002CD3 RID: 11475
			private static readonly IntPtr NativeMethodInfoPtr_IsInUse_Public_Boolean_0;

			// Token: 0x04002CD4 RID: 11476
			private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Abstract_Virtual_New_SingleQueryMatcher_0;

			// Token: 0x04002CD5 RID: 11477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020004F3 RID: 1267
		public class FirstQueryMatcher : UQuery.SingleQueryMatcher
		{
			// Token: 0x06003F78 RID: 16248 RVA: 0x000FCDA4 File Offset: 0x000FAFA4
			// Note: this type is marked as 'beforefieldinit'.
			static FirstQueryMatcher()
			{
				Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQuery>.NativeClassPtr, "FirstQueryMatcher");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr);
				UQuery.FirstQueryMatcher.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr, "Instance");
				UQuery.FirstQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr, 100669158);
				UQuery.FirstQueryMatcher.NativeMethodInfoPtr_CreateNew_Public_Virtual_SingleQueryMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr, 100669159);
				UQuery.FirstQueryMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr, 100669160);
			}

			// Token: 0x06003F79 RID: 16249 RVA: 0x000FCE20 File Offset: 0x000FB020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342294, XrefRangeEnd = 342295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(matcher));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.FirstQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F7A RID: 16250 RVA: 0x000FCE90 File Offset: 0x000FB090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342295, XrefRangeEnd = 342299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override UQuery.SingleQueryMatcher CreateNew()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQuery.FirstQueryMatcher.NativeMethodInfoPtr_CreateNew_Public_Virtual_SingleQueryMatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UQuery.SingleQueryMatcher>(intPtr3) : null;
			}

			// Token: 0x06003F7B RID: 16251 RVA: 0x000FCEDC File Offset: 0x000FB0DC
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FirstQueryMatcher()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQuery.FirstQueryMatcher>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQuery.FirstQueryMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F7C RID: 16252 RVA: 0x0001A9FF File Offset: 0x00018BFF
			public FirstQueryMatcher(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001306 RID: 4870
			// (get) Token: 0x06003F7D RID: 16253 RVA: 0x000FCF18 File Offset: 0x000FB118
			// (set) Token: 0x06003F7E RID: 16254 RVA: 0x0001AA08 File Offset: 0x00018C08
			public unsafe static UQuery.FirstQueryMatcher Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UQuery.FirstQueryMatcher.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQuery.FirstQueryMatcher>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UQuery.FirstQueryMatcher.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CD6 RID: 11478
			private static readonly IntPtr NativeFieldInfoPtr_Instance;

			// Token: 0x04002CD7 RID: 11479
			private static readonly IntPtr NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0;

			// Token: 0x04002CD8 RID: 11480
			private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Virtual_SingleQueryMatcher_0;

			// Token: 0x04002CD9 RID: 11481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004F4 RID: 1268
		public class LastQueryMatcher : UQuery.SingleQueryMatcher
		{
		}

		// Token: 0x020004F5 RID: 1269
		public class IndexQueryMatcher : UQuery.SingleQueryMatcher
		{
		}
	}
}

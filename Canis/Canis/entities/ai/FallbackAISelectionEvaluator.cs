using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000104 RID: 260
	public class FallbackAISelectionEvaluator : AISelectionEvaluator
	{
		// Token: 0x06000B95 RID: 2965 RVA: 0x0004AAD4 File Offset: 0x00048CD4
		// Note: this type is marked as 'beforefieldinit'.
		static FallbackAISelectionEvaluator()
		{
			Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "FallbackAISelectionEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr);
			FallbackAISelectionEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr, 100665793);
			FallbackAISelectionEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr, 100665794);
			FallbackAISelectionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr, 100665795);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0004AB40 File Offset: 0x00048D40
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackAISelectionEvaluator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackAISelectionEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0004AB7C File Offset: 0x00048D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570033, XrefRangeEnd = 570075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackAISelectionEvaluator(Dictionary<string, Object> parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackAISelectionEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIChoice Evaluate(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FallbackAISelectionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00006390 File Offset: 0x00004590
		public FallbackAISelectionEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_AIChoice_AIChoiceContext_0;

		// Token: 0x02000347 RID: 839
		[ObfuscatedName("Canis.entities.ai.FallbackAISelectionEvaluator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002320 RID: 8992 RVA: 0x0009D4BC File Offset: 0x0009B6BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackAISelectionEvaluator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr);
				FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr, "<>9");
				FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr, "<>9__1_0");
				FallbackAISelectionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr, 100665797);
				FallbackAISelectionEvaluator.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr, 100665798);
			}

			// Token: 0x06002321 RID: 8993 RVA: 0x0009D538 File Offset: 0x0009B738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackAISelectionEvaluator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackAISelectionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002322 RID: 8994 RVA: 0x0009D574 File Offset: 0x0009B774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570028, XrefRangeEnd = 570033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__1_0(KeyValuePair<string, Object> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackAISelectionEvaluator.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002323 RID: 8995 RVA: 0x00010DD2 File Offset: 0x0000EFD2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06002324 RID: 8996 RVA: 0x0009D5C4 File Offset: 0x0009B7C4
			// (set) Token: 0x06002325 RID: 8997 RVA: 0x00010DDB File Offset: 0x0000EFDB
			public unsafe static FallbackAISelectionEvaluator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FallbackAISelectionEvaluator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06002326 RID: 8998 RVA: 0x0009D5EC File Offset: 0x0009B7EC
			// (set) Token: 0x06002327 RID: 8999 RVA: 0x00010DED File Offset: 0x0000EFED
			public unsafe static Func<KeyValuePair<string, Object>, string> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FallbackAISelectionEvaluator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Internal_String_KeyValuePair_2_String_Object_0;
		}
	}
}

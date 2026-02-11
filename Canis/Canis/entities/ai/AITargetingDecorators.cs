using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.entities.ai
{
	// Token: 0x02000105 RID: 261
	public static class AITargetingDecorators : Object
	{
		// Token: 0x06000B9A RID: 2970 RVA: 0x0004AC24 File Offset: 0x00048E24
		// Note: this type is marked as 'beforefieldinit'.
		static AITargetingDecorators()
		{
			Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AITargetingDecorators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr);
			AITargetingDecorators.NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TTargetType_TargetPicker_1_TTargetType_TSelectionEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr, 100665799);
			AITargetingDecorators.NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TargetType_TargetPicker_1_TargetType_AIEvaluateSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr, 100665800);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0004AC7C File Offset: 0x00048E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 570087, RefRangeEnd = 570088, XrefRangeStart = 570075, XrefRangeEnd = 570087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker<TTargetType> WithEvaluator<TTargetType, TSelectionEvaluator>(this TargetPicker<TTargetType> targetPicker, TSelectionEvaluator evaluator) where TSelectionEvaluator : AISelectionEvaluator
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPicker);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSelectionEvaluator).IsValueType)
			{
				TSelectionEvaluator tselectionEvaluator = evaluator;
				intPtr = ((tselectionEvaluator is string) ? IL2CPP.ManagedStringToIl2Cpp(tselectionEvaluator as string) : IL2CPP.Il2CppObjectBaseToPtr(tselectionEvaluator as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref evaluator;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AITargetingDecorators.MethodInfoStoreGeneric_WithEvaluator_Public_Static_TargetPicker_1_TTargetType_TargetPicker_1_TTargetType_TSelectionEvaluator_0<TTargetType, TSelectionEvaluator>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<TargetPicker<TTargetType>>(intPtr4) : null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0004AD08 File Offset: 0x00048F08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 570105, RefRangeEnd = 570107, XrefRangeStart = 570088, XrefRangeEnd = 570105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetPicker<TargetType> WithEvaluator<TargetType>(this TargetPicker<TargetType> targetPicker, AIEvaluateSelection evaluator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPicker);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AITargetingDecorators.MethodInfoStoreGeneric_WithEvaluator_Public_Static_TargetPicker_1_TargetType_TargetPicker_1_TargetType_AIEvaluateSelection_0<TargetType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<TargetType>>(intPtr3) : null;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00006399 File Offset: 0x00004599
		public AITargetingDecorators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TTargetType_TargetPicker_1_TTargetType_TSelectionEvaluator_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TargetType_TargetPicker_1_TargetType_AIEvaluateSelection_0;

		// Token: 0x02000348 RID: 840
		private sealed class MethodInfoStoreGeneric_WithEvaluator_Public_Static_TargetPicker_1_TTargetType_TargetPicker_1_TTargetType_TSelectionEvaluator_0<TTargetType, TSelectionEvaluator>
		{
			// Token: 0x04001614 RID: 5652
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AITargetingDecorators.NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TTargetType_TargetPicker_1_TTargetType_TSelectionEvaluator_0, Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSelectionEvaluator>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000349 RID: 841
		private sealed class MethodInfoStoreGeneric_WithEvaluator_Public_Static_TargetPicker_1_TargetType_TargetPicker_1_TargetType_AIEvaluateSelection_0<TargetType>
		{
			// Token: 0x04001615 RID: 5653
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AITargetingDecorators.NativeMethodInfoPtr_WithEvaluator_Public_Static_TargetPicker_1_TargetType_TargetPicker_1_TargetType_AIEvaluateSelection_0, Il2CppClassPointerStore<AITargetingDecorators>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetType>.NativeClassPtr)) }))));
		}
	}
}

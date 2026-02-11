using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200002B RID: 43
	public sealed class StackGuard : Object
	{
		// Token: 0x060001DE RID: 478 RVA: 0x0000AD34 File Offset: 0x00008F34
		// Note: this type is marked as 'beforefieldinit'.
		static StackGuard()
		{
			Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "StackGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
			StackGuard.NativeFieldInfoPtr__executionStackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "_executionStackCount");
			StackGuard.NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100663600);
			StackGuard.NativeMethodInfoPtr_RunOnEmptyStack_Public_TR_Func_3_T1_T2_TR_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100663601);
			StackGuard.NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100663602);
			StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100663603);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205194, RefRangeEnd = 1205195, XrefRangeStart = 1205193, XrefRangeEnd = 1205194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterOnCurrentStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000AE04 File Offset: 0x00009004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205195, XrefRangeEnd = 1205211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TR RunOnEmptyStack<T1, T2, TR>(Func<T1, T2, TR> action, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackGuard.MethodInfoStoreGeneric_RunOnEmptyStack_Public_TR_Func_3_T1_T2_TR_T1_T2_0<T1, T2, TR>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TR>(intPtr3, false, true);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000AEE0 File Offset: 0x000090E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205238, RefRangeEnd = 1205240, XrefRangeStart = 1205211, XrefRangeEnd = 1205238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe R RunOnEmptyStackCore<R>(Func<Object, R> action, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.MethodInfoStoreGeneric_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0<R>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<R>(intPtr, false, true);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000AF3C File Offset: 0x0000913C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackGuard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public StackGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000AF78 File Offset: 0x00009178
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002AAD File Offset: 0x00000CAD
		public unsafe int _executionStackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr__executionStackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr__executionStackCount)) = value;
			}
		}

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__executionStackCount;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_RunOnEmptyStack_Public_TR_Func_3_T1_T2_TR_T1_T2_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.StackGuard+<>c__3`3")]
		[Serializable]
		public sealed class __c__3<T1, T2, TR> : Object
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "<>c__3`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TR>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr);
				StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr, "<>9");
				StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr, "<>9__3_0");
				StackGuard.__c__3<T1, T2, TR>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr, 100663605);
				StackGuard.__c__3<T1, T2, TR>.NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_TR_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr, 100663606);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000DF8C File Offset: 0x0000C18C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2, TR>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.__c__3<T1, T2, TR>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205187, XrefRangeEnd = 1205193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TR _RunOnEmptyStack_b__3_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.__c__3<T1, T2, TR>.NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_TR_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TR>(intPtr, false, true);
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00003277 File Offset: 0x00001477
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0000E014 File Offset: 0x0000C214
			// (set) Token: 0x060002DC RID: 732 RVA: 0x00003280 File Offset: 0x00001480
			public unsafe static StackGuard.__c__3<T1, T2, TR> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard.__c__3<T1, T2, TR>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002DD RID: 733 RVA: 0x0000E03C File Offset: 0x0000C23C
			// (set) Token: 0x060002DE RID: 734 RVA: 0x00003292 File Offset: 0x00001492
			public unsafe static Func<Object, TR> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, TR>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackGuard.__c__3<T1, T2, TR>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_TR_Object_0;
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_RunOnEmptyStack_Public_TR_Func_3_T1_T2_TR_T1_T2_0<T1, T2, TR>
		{
			// Token: 0x040001F2 RID: 498
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StackGuard.NativeMethodInfoPtr_RunOnEmptyStack_Public_TR_Func_3_T1_T2_TR_T1_T2_0, Il2CppClassPointerStore<StackGuard>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TR>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0<R>
		{
			// Token: 0x040001F3 RID: 499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StackGuard.NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0, Il2CppClassPointerStore<StackGuard>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) }))));
		}
	}
}

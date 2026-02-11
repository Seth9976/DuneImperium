using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000083 RID: 131
	public sealed class StackGuard : Object
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0002F010 File Offset: 0x0002D210
		// Note: this type is marked as 'beforefieldinit'.
		static StackGuard()
		{
			Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "StackGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
			StackGuard.NativeFieldInfoPtr__executionStackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "_executionStackCount");
			StackGuard.NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100664614);
			StackGuard.NativeMethodInfoPtr_RunOnEmptyStack_Public_Void_Action_2_T1_T2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100664615);
			StackGuard.NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100664616);
			StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100664617);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014736, RefRangeEnd = 1014737, XrefRangeStart = 1014735, XrefRangeEnd = 1014736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterOnCurrentStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002F0E0 File Offset: 0x0002D2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014737, XrefRangeEnd = 1014775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackGuard.MethodInfoStoreGeneric_RunOnEmptyStack_Public_Void_Action_2_T1_T2_T1_T2_0<T1, T2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002F1B4 File Offset: 0x0002D3B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014802, RefRangeEnd = 1014803, XrefRangeStart = 1014775, XrefRangeEnd = 1014802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000694 RID: 1684 RVA: 0x0002F210 File Offset: 0x0002D410
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

		// Token: 0x06000695 RID: 1685 RVA: 0x00003AFC File Offset: 0x00001CFC
		public StackGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0002F24C File Offset: 0x0002D44C
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00003B05 File Offset: 0x00001D05
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

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr__executionStackCount;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterOnCurrentStack_Public_Boolean_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_RunOnEmptyStack_Public_Void_Action_2_T1_T2_T1_T2_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001E4 RID: 484
		[ObfuscatedName("System.Linq.Expressions.StackGuard+<>c__3`2")]
		[Serializable]
		public sealed class __c__3<T1, T2> : Object
		{
			// Token: 0x06001662 RID: 5730 RVA: 0x0006DC70 File Offset: 0x0006BE70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "<>c__3`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr);
				StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr, "<>9");
				StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr, "<>9__3_0");
				StackGuard.__c__3<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr, 100664619);
				StackGuard.__c__3<T1, T2>.NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr, 100664620);
			}

			// Token: 0x06001663 RID: 5731 RVA: 0x0006DD38 File Offset: 0x0006BF38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard.__c__3<T1, T2>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.__c__3<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x0006DD74 File Offset: 0x0006BF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014734, XrefRangeEnd = 1014735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _RunOnEmptyStack_b__3_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.__c__3<T1, T2>.NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001665 RID: 5733 RVA: 0x00009832 File Offset: 0x00007A32
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001666 RID: 5734 RVA: 0x0006DDC4 File Offset: 0x0006BFC4
			// (set) Token: 0x06001667 RID: 5735 RVA: 0x0000983B File Offset: 0x00007A3B
			public unsafe static StackGuard.__c__3<T1, T2> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard.__c__3<T1, T2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001668 RID: 5736 RVA: 0x0006DDEC File Offset: 0x0006BFEC
			// (set) Token: 0x06001669 RID: 5737 RVA: 0x0000984D File Offset: 0x00007A4D
			public unsafe static Func<Object, Object> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackGuard.__c__3<T1, T2>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FC1 RID: 4033
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FC2 RID: 4034
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000FC3 RID: 4035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FC4 RID: 4036
			private static readonly IntPtr NativeMethodInfoPtr__RunOnEmptyStack_b__3_0_Internal_Object_Object_0;
		}

		// Token: 0x020001E5 RID: 485
		private sealed class MethodInfoStoreGeneric_RunOnEmptyStack_Public_Void_Action_2_T1_T2_T1_T2_0<T1, T2>
		{
			// Token: 0x04000FC5 RID: 4037
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StackGuard.NativeMethodInfoPtr_RunOnEmptyStack_Public_Void_Action_2_T1_T2_T1_T2_0, Il2CppClassPointerStore<StackGuard>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001E6 RID: 486
		private sealed class MethodInfoStoreGeneric_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0<R>
		{
			// Token: 0x04000FC6 RID: 4038
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StackGuard.NativeMethodInfoPtr_RunOnEmptyStackCore_Private_R_Func_2_Object_R_Object_0, Il2CppClassPointerStore<StackGuard>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) }))));
		}
	}
}

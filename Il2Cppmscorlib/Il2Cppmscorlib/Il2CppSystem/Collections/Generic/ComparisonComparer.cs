using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000505 RID: 1285
	[Serializable]
	public class ComparisonComparer<T> : Comparer<T>
	{
		// Token: 0x06004F14 RID: 20244 RVA: 0x0016F8BC File Offset: 0x0016DABC
		// Note: this type is marked as 'beforefieldinit'.
		static ComparisonComparer()
		{
			Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ComparisonComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr);
			ComparisonComparer<T>.NativeFieldInfoPtr__comparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr, "_comparison");
			ComparisonComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr, 100675218);
			ComparisonComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr, 100675219);
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x0016F964 File Offset: 0x0016DB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426248, RefRangeEnd = 1426249, XrefRangeStart = 1426246, XrefRangeEnd = 1426248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComparisonComparer(Comparison<T> comparison)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComparisonComparer<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparison);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_Comparison_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x0016F9B0 File Offset: 0x0016DBB0
		[CallerCount(0)]
		public unsafe override int Compare(T x, T y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = y;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref y;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComparisonComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x0001C777 File Offset: 0x0001A977
		public ComparisonComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x0016FA88 File Offset: 0x0016DC88
		// (set) Token: 0x06004F19 RID: 20249 RVA: 0x0001C780 File Offset: 0x0001A980
		public unsafe Comparison<T> _comparison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonComparer<T>.NativeFieldInfoPtr__comparison);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonComparer<T>.NativeFieldInfoPtr__comparison), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004088 RID: 16520
		private static readonly IntPtr NativeFieldInfoPtr__comparison;

		// Token: 0x04004089 RID: 16521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Comparison_1_T_0;

		// Token: 0x0400408A RID: 16522
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_T_T_0;
	}
}

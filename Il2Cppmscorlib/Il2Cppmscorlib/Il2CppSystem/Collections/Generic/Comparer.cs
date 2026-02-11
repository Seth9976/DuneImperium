using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000501 RID: 1281
	[Serializable]
	public class Comparer<T> : Object
	{
		// Token: 0x06004EF8 RID: 20216 RVA: 0x0016EE90 File Offset: 0x0016D090
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Comparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr);
			Comparer<T>.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, "defaultComparer");
			Comparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675200);
			Comparer<T>.NativeMethodInfoPtr_Create_Public_Static_Comparer_1_T_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675201);
			Comparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675202);
			Comparer<T>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675203);
			Comparer<T>.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675204);
			Comparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100675205);
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x0016EF88 File Offset: 0x0016D188
		public unsafe static Comparer<T> Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1426153, RefRangeEnd = 1426155, XrefRangeStart = 1426142, XrefRangeEnd = 1426153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x0016EFBC File Offset: 0x0016D1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426155, XrefRangeEnd = 1426160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Comparer<T> Create(Comparison<T> comparison)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparison);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_Create_Public_Static_Comparer_1_T_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0016F000 File Offset: 0x0016D200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426205, RefRangeEnd = 1426206, XrefRangeStart = 1426160, XrefRangeEnd = 1426205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Comparer<T> CreateComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr3) : null;
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x0016F034 File Offset: 0x0016D234
		[CallerCount(0)]
		public unsafe virtual int Compare(T x, T y)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Comparer<T>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0016F10C File Offset: 0x0016D30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426206, XrefRangeEnd = 1426218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IComparer_Compare(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x0016F16C File Offset: 0x0016D36C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x0001C741 File Offset: 0x0001A941
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x0016F1A8 File Offset: 0x0016D3A8
		// (set) Token: 0x06004F01 RID: 20225 RVA: 0x0001C74A File Offset: 0x0001A94A
		public unsafe static Comparer<T> defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer<T>.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer<T>.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004075 RID: 16501
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x04004076 RID: 16502
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0;

		// Token: 0x04004077 RID: 16503
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Comparer_1_T_Comparison_1_T_0;

		// Token: 0x04004078 RID: 16504
		private static readonly IntPtr NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0;

		// Token: 0x04004079 RID: 16505
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0;

		// Token: 0x0400407A RID: 16506
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x0400407B RID: 16507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

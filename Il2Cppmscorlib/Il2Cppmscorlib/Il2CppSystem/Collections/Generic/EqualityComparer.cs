using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000506 RID: 1286
	[Serializable]
	public class EqualityComparer<T> : Object
	{
		// Token: 0x06004F1A RID: 20250 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
		// Note: this type is marked as 'beforefieldinit'.
		static EqualityComparer()
		{
			Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "EqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr);
			EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, "defaultComparer");
			EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675220);
			EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675221);
			EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675222);
			EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675223);
			EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675224);
			EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675225);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675226);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675227);
			EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100675228);
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0016FBEC File Offset: 0x0016DDEC
		public unsafe static EqualityComparer<T> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426249, XrefRangeEnd = 1426260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x0016FC20 File Offset: 0x0016DE20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1426370, RefRangeEnd = 1426373, XrefRangeStart = 1426260, XrefRangeEnd = 1426370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EqualityComparer<T> CreateComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x0016FC54 File Offset: 0x0016DE54
		[CallerCount(0)]
		public unsafe virtual bool Equals(T x, T y)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x0016FD2C File Offset: 0x0016DF2C
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x0016FDBC File Offset: 0x0016DFBC
		[CallerCount(0)]
		public unsafe virtual int IndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x0016FE78 File Offset: 0x0016E078
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0016FF34 File Offset: 0x0016E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426373, XrefRangeEnd = 1426376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x0016FF84 File Offset: 0x0016E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426376, XrefRangeEnd = 1426387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x0016FFE4 File Offset: 0x0016E1E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x0001C79F File Offset: 0x0001A99F
		public EqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x00170020 File Offset: 0x0016E220
		// (set) Token: 0x06004F26 RID: 20262 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		public unsafe static EqualityComparer<T> defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400408B RID: 16523
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x0400408C RID: 16524
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0;

		// Token: 0x0400408D RID: 16525
		private static readonly IntPtr NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0;

		// Token: 0x0400408E RID: 16526
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0;

		// Token: 0x0400408F RID: 16527
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0;

		// Token: 0x04004090 RID: 16528
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04004091 RID: 16529
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04004092 RID: 16530
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04004093 RID: 16531
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04004094 RID: 16532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

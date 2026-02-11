using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000466 RID: 1126
	public sealed class Vector<T> : ValueType where T : new()
	{
		// Token: 0x0600434E RID: 17230 RVA: 0x0013D36C File Offset: 0x0013B56C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector()
		{
			Il2CppClassPointerStore<Vector<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics", "Vector`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr);
			Vector<T>.NativeFieldInfoPtr_register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "register");
			Vector<T>.NativeFieldInfoPtr_s_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "s_count");
			Vector<T>.NativeFieldInfoPtr_s_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "s_zero");
			Vector<T>.NativeFieldInfoPtr_s_one = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "s_one");
			Vector<T>.NativeFieldInfoPtr_s_allOnes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "s_allOnes");
			Vector<T>.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673235);
			Vector<T>.NativeMethodInfoPtr_get_Zero_Public_Static_get_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673236);
			Vector<T>.NativeMethodInfoPtr_InitializeCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673237);
			Vector<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673238);
			Vector<T>.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673239);
			Vector<T>.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673240);
			Vector<T>.NativeMethodInfoPtr__ctor_Private_Void_byref_Register_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673241);
			Vector<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673242);
			Vector<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673243);
			Vector<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673244);
			Vector<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673245);
			Vector<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673246);
			Vector<T>.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673247);
			Vector<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673248);
			Vector<T>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673249);
			Vector<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_Vector_1_UInt64_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673250);
			Vector<T>.NativeMethodInfoPtr_Equals_Internal_Static_Vector_1_T_Vector_1_T_Vector_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673251);
			Vector<T>.NativeMethodInfoPtr_ScalarEquals_Private_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673252);
			Vector<T>.NativeMethodInfoPtr_GetOneValue_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673253);
			Vector<T>.NativeMethodInfoPtr_GetAllBitsSetValue_Private_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, 100673254);
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x0013D5CC File Offset: 0x0013B7CC
		public unsafe static int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403872, XrefRangeEnd = 1403876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0013D5FC File Offset: 0x0013B7FC
		public unsafe static Vector<T> Zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403876, XrefRangeEnd = 1403881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_get_Zero_Public_Static_get_Vector_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Vector<T>(intPtr);
			}
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x0013D628 File Offset: 0x0013B828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403881, XrefRangeEnd = 1403965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitializeCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_InitializeCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0013D658 File Offset: 0x0013B858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1404503, RefRangeEnd = 1404505, XrefRangeStart = 1403965, XrefRangeEnd = 1404503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x0013D6E0 File Offset: 0x0013B8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404505, XrefRangeEnd = 1404510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector(void* dataPointer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0013D72C File Offset: 0x0013B92C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1404663, RefRangeEnd = 1404665, XrefRangeStart = 1404510, XrefRangeEnd = 1404663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector(void* dataPointer, int offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x0013D788 File Offset: 0x0013B988
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 557179, RefRangeEnd = 557192, XrefRangeStart = 557179, XrefRangeEnd = 557192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector(ref Register existingRegister)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &existingRegister;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr__ctor_Private_Void_byref_Register_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001084 RID: 4228
		public unsafe T this[int index]
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 1404811, RefRangeEnd = 1404843, XrefRangeStart = 1404665, XrefRangeEnd = 1404811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x0013D820 File Offset: 0x0013BA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404843, XrefRangeEnd = 1404853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0013D874 File Offset: 0x0013BA74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1404935, RefRangeEnd = 1404941, XrefRangeStart = 1404853, XrefRangeEnd = 1404935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Vector<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0013D8CC File Offset: 0x0013BACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1404941, XrefRangeEnd = 1405461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0013D910 File Offset: 0x0013BB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405461, XrefRangeEnd = 1405526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0013D94C File Offset: 0x0013BB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1405569, RefRangeEnd = 1405570, XrefRangeStart = 1405526, XrefRangeEnd = 1405569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0013D9AC File Offset: 0x0013BBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405570, XrefRangeEnd = 1405575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Vector<T> left, Vector<T> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0013DA0C File Offset: 0x0013BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405575, XrefRangeEnd = 1405584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Vector<T> left, Vector<T> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x0013DA6C File Offset: 0x0013BC6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1405585, RefRangeEnd = 1405588, XrefRangeStart = 1405584, XrefRangeEnd = 1405585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Vector<ulong>(Vector<T> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_Vector_1_UInt64_Vector_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Vector<ulong>(intPtr);
			}
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x0013DAB0 File Offset: 0x0013BCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1405588, XrefRangeEnd = 1406004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector<T> Equals(Vector<T> left, Vector<T> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_Equals_Internal_Static_Vector_1_T_Vector_1_T_Vector_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Vector<T>(intPtr);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0013DB08 File Offset: 0x0013BD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406004, XrefRangeEnd = 1406130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScalarEquals(T left, T right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = left;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref left;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = right;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref right;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_ScalarEquals_Private_Static_Boolean_T_T_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x0013DBC8 File Offset: 0x0013BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406130, XrefRangeEnd = 1406271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOneValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_GetOneValue_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x0013DBF8 File Offset: 0x0013BDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406271, XrefRangeEnd = 1406412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAllBitsSetValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector<T>.NativeMethodInfoPtr_GetAllBitsSetValue_Private_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x00018688 File Offset: 0x00016888
		public Vector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00018691 File Offset: 0x00016891
		public Vector()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x0013DC28 File Offset: 0x0013BE28
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x000186A3 File Offset: 0x000168A3
		public unsafe Register register
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.NativeFieldInfoPtr_register);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.NativeFieldInfoPtr_register)) = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x0013DC50 File Offset: 0x0013BE50
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x000186BE File Offset: 0x000168BE
		public unsafe static int s_count
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Vector<T>.NativeFieldInfoPtr_s_count, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector<T>.NativeFieldInfoPtr_s_count, (void*)(&value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0013DC6C File Offset: 0x0013BE6C
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x000186CC File Offset: 0x000168CC
		public unsafe static Vector<T> s_zero
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Vector<T>.NativeFieldInfoPtr_s_zero, intPtr);
				return new Vector<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector<T>.NativeFieldInfoPtr_s_zero, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x0013DCA8 File Offset: 0x0013BEA8
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x000186E3 File Offset: 0x000168E3
		public unsafe static Vector<T> s_one
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Vector<T>.NativeFieldInfoPtr_s_one, intPtr);
				return new Vector<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector<T>.NativeFieldInfoPtr_s_one, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x0013DCE4 File Offset: 0x0013BEE4
		// (set) Token: 0x0600436E RID: 17262 RVA: 0x000186FA File Offset: 0x000168FA
		public unsafe static Vector<T> s_allOnes
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Vector<T>.NativeFieldInfoPtr_s_allOnes, intPtr);
				return new Vector<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector<T>.NativeFieldInfoPtr_s_allOnes, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr_register;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr_s_count;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr_s_zero;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_s_one;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr_s_allOnes;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Static_get_Int32_0;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeMethodInfoPtr_get_Zero_Public_Static_get_Vector_1_T_0;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCount_Private_Static_Int32_0;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_0;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Void_Int32_0;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_byref_Register_0;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector_1_T_0;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector_1_T_Vector_1_T_0;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Vector_1_UInt64_Vector_1_T_0;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Static_Vector_1_T_Vector_1_T_Vector_1_T_0;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeMethodInfoPtr_ScalarEquals_Private_Static_Boolean_T_T_0;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeMethodInfoPtr_GetOneValue_Private_Static_T_0;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBitsSetValue_Private_Static_T_0;

		// Token: 0x020006C7 RID: 1735
		public sealed class VectorSizeHelper : ValueType
		{
			// Token: 0x06005CCA RID: 23754 RVA: 0x001A493C File Offset: 0x001A2B3C
			// Note: this type is marked as 'beforefieldinit'.
			static VectorSizeHelper()
			{
				Il2CppClassPointerStore<Vector<T>.VectorSizeHelper>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, "VectorSizeHelper"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector<T>.VectorSizeHelper>.NativeClassPtr);
				Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>.VectorSizeHelper>.NativeClassPtr, "_placeholder");
				Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector<T>.VectorSizeHelper>.NativeClassPtr, "_byte");
			}

			// Token: 0x06005CCB RID: 23755 RVA: 0x00021B2A File Offset: 0x0001FD2A
			public VectorSizeHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CCC RID: 23756 RVA: 0x00021B33 File Offset: 0x0001FD33
			public VectorSizeHelper()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector<T>.VectorSizeHelper>.NativeClassPtr))
			{
			}

			// Token: 0x170017BA RID: 6074
			// (get) Token: 0x06005CCD RID: 23757 RVA: 0x001A49CC File Offset: 0x001A2BCC
			// (set) Token: 0x06005CCE RID: 23758 RVA: 0x00021B45 File Offset: 0x0001FD45
			public Vector<T> _placeholder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__placeholder);
					return new Vector<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__placeholder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Vector<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170017BB RID: 6075
			// (get) Token: 0x06005CCF RID: 23759 RVA: 0x001A49FC File Offset: 0x001A2BFC
			// (set) Token: 0x06005CD0 RID: 23760 RVA: 0x00021B73 File Offset: 0x0001FD73
			public unsafe byte _byte
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__byte);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector<T>.VectorSizeHelper.NativeFieldInfoPtr__byte)) = value;
				}
			}

			// Token: 0x04004B50 RID: 19280
			private static readonly IntPtr NativeFieldInfoPtr__placeholder;

			// Token: 0x04004B51 RID: 19281
			private static readonly IntPtr NativeFieldInfoPtr__byte;
		}
	}
}

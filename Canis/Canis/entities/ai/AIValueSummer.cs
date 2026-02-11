using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000108 RID: 264
	public class AIValueSummer<T> : Object where T : new()
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004C7D0 File Offset: 0x0004A9D0
		// Note: this type is marked as 'beforefieldinit'.
		static AIValueSummer()
		{
			Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIValueSummer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr);
			AIValueSummer<T>.NativeFieldInfoPtr_addOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, "addOp");
			AIValueSummer<T>.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, "values");
			AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665879);
			AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_AIValueSummer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665880);
			AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665881);
			AIValueSummer<T>.NativeMethodInfoPtr_get_Sum_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665882);
			AIValueSummer<T>.NativeMethodInfoPtr_Add_Public_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665883);
			AIValueSummer<T>.NativeMethodInfoPtr_Merge_Public_Void_AIValueSummer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665884);
			AIValueSummer<T>.NativeMethodInfoPtr_MergePrependReason_Public_Void_AIValueSummer_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665885);
			AIValueSummer<T>.NativeMethodInfoPtr_Concatenate_Public_Static_AIValueSummer_1_T_IEnumerable_1_AIValueSummer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665886);
			AIValueSummer<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueSummer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665887);
			AIValueSummer<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665888);
			AIValueSummer<T>.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665889);
			AIValueSummer<T>.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665890);
			AIValueSummer<T>.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665891);
			AIValueSummer<T>.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665892);
			AIValueSummer<T>.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665893);
			AIValueSummer<T>.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665894);
			AIValueSummer<T>.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665895);
			AIValueSummer<T>.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665896);
			AIValueSummer<T>.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665897);
			AIValueSummer<T>.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665898);
			AIValueSummer<T>.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665899);
			AIValueSummer<T>.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665900);
			AIValueSummer<T>.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665901);
			AIValueSummer<T>.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665902);
			AIValueSummer<T>.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665903);
			AIValueSummer<T>.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665904);
			AIValueSummer<T>.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, 100665905);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0004CA80 File Offset: 0x0004AC80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 570805, RefRangeEnd = 570807, XrefRangeStart = 570786, XrefRangeEnd = 570805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer(Func<T, T, T> addOp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addOp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0004CACC File Offset: 0x0004ACCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570807, XrefRangeEnd = 570820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer(AIValueSummer<T> orig)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_AIValueSummer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 570820, XrefRangeEnd = 570834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer(Func<T, T, T> addOp, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addOp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0004CB74 File Offset: 0x0004AD74
		public unsafe T Sum
		{
			[CallerCount(255)]
			[CachedScanResults(RefRangeStart = 570841, RefRangeEnd = 571096, XrefRangeStart = 570834, XrefRangeEnd = 570841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_get_Sum_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		[CallerCount(512)]
		[CachedScanResults(RefRangeStart = 571098, RefRangeEnd = 571610, XrefRangeStart = 571096, XrefRangeEnd = 571098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T value, string reason)
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
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_Add_Public_Void_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0004CC3C File Offset: 0x0004AE3C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 571611, RefRangeEnd = 571645, XrefRangeStart = 571610, XrefRangeEnd = 571611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(AIValueSummer<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_Merge_Public_Void_AIValueSummer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0004CC80 File Offset: 0x0004AE80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 571656, RefRangeEnd = 571658, XrefRangeStart = 571645, XrefRangeEnd = 571656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergePrependReason(AIValueSummer<T> other, string prependReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prependReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_MergePrependReason_Public_Void_AIValueSummer_1_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004CCD4 File Offset: 0x0004AED4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 571683, RefRangeEnd = 571689, XrefRangeStart = 571658, XrefRangeEnd = 571683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AIValueSummer<T> Concatenate(IEnumerable<AIValueSummer<T>> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_Concatenate_Public_Static_AIValueSummer_1_T_IEnumerable_1_AIValueSummer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0004CD18 File Offset: 0x0004AF18
		[CallerCount(0)]
		public unsafe virtual int CompareTo(AIValueSummer<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueSummer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004CD68 File Offset: 0x0004AF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571689, XrefRangeEnd = 571730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIValueSummer<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571730, XrefRangeEnd = 571736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0004CE38 File Offset: 0x0004B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571736, XrefRangeEnd = 571742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0004CE88 File Offset: 0x0004B088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571742, XrefRangeEnd = 571748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0004CED8 File Offset: 0x0004B0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571748, XrefRangeEnd = 571754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0004CF28 File Offset: 0x0004B128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571754, XrefRangeEnd = 571760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0004CF78 File Offset: 0x0004B178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571760, XrefRangeEnd = 571766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0004CFC8 File Offset: 0x0004B1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571766, XrefRangeEnd = 571772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0004D018 File Offset: 0x0004B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571772, XrefRangeEnd = 571778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0004D068 File Offset: 0x0004B268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571778, XrefRangeEnd = 571784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571784, XrefRangeEnd = 571790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0004D108 File Offset: 0x0004B308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571790, XrefRangeEnd = 571796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0004D158 File Offset: 0x0004B358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571796, XrefRangeEnd = 571804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0004D1A0 File Offset: 0x0004B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571804, XrefRangeEnd = 571810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ToType(Type conversionType, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0004D204 File Offset: 0x0004B404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571810, XrefRangeEnd = 571816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0004D254 File Offset: 0x0004B454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571816, XrefRangeEnd = 571822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0004D2A4 File Offset: 0x0004B4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571822, XrefRangeEnd = 571828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000063F2 File Offset: 0x000045F2
		public AIValueSummer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0004D2F4 File Offset: 0x0004B4F4
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x000063FB File Offset: 0x000045FB
		public unsafe Func<T, T, T> addOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.NativeFieldInfoPtr_addOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.NativeFieldInfoPtr_addOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0004D324 File Offset: 0x0004B524
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0000641A File Offset: 0x0000461A
		public unsafe List<AIValueSummer<T>.ValueReason> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AIValueSummer<T>.ValueReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_addOp;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIValueSummer_1_T_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_T_Int32_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_get_Sum_Public_get_T_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_String_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_AIValueSummer_1_T_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_MergePrependReason_Public_Void_AIValueSummer_1_T_String_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_Concatenate_Public_Static_AIValueSummer_1_T_IEnumerable_1_AIValueSummer_1_T_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AIValueSummer_1_T_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Public_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0200034E RID: 846
		public sealed class ValueReason : ValueType
		{
			// Token: 0x06002356 RID: 9046 RVA: 0x0009DF94 File Offset: 0x0009C194
			// Note: this type is marked as 'beforefieldinit'.
			static ValueReason()
			{
				Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIValueSummer<T>>.NativeClassPtr, "ValueReason"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr);
				AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr, "Value");
				AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr, "Reason");
				AIValueSummer<T>.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr, 100665906);
				AIValueSummer<T>.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_T_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr, 100665907);
			}

			// Token: 0x06002357 RID: 9047 RVA: 0x0009E04C File Offset: 0x0009C24C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 570769, RefRangeEnd = 570771, XrefRangeStart = 570759, XrefRangeEnd = 570769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueReason(T value, string reason)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.ValueReason.NativeMethodInfoPtr__ctor_Public_Void_T_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06002358 RID: 9048 RVA: 0x0009E0E4 File Offset: 0x0009C2E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 570784, RefRangeEnd = 570786, XrefRangeStart = 570771, XrefRangeEnd = 570784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out T value, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr2;
					if (!typeof(T).IsValueType)
					{
						intPtr = 0;
						intPtr2 = &intPtr;
					}
					else
					{
						intPtr2 = ref value;
					}
					ptr2 = intPtr2;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3 = 0;
				ptr3 = &intPtr3;
				IntPtr intPtr5;
				IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(AIValueSummer<T>.ValueReason.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_T_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr5);
				Il2CppException.RaiseExceptionIfNecessary(intPtr5);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr6 = intPtr;
					value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
				}
				reason = IL2CPP.Il2CppStringToManaged(intPtr3);
			}

			// Token: 0x06002359 RID: 9049 RVA: 0x00010F85 File Offset: 0x0000F185
			public ValueReason(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x00010F8E File Offset: 0x0000F18E
			public ValueReason()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIValueSummer<T>.ValueReason>.NativeClassPtr))
			{
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x0600235B RID: 9051 RVA: 0x0009E184 File Offset: 0x0009C384
			// (set) Token: 0x0600235C RID: 9052 RVA: 0x0009E1AC File Offset: 0x0009C3AC
			public unsafe T Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x0600235D RID: 9053 RVA: 0x0009E254 File Offset: 0x0009C454
			// (set) Token: 0x0600235E RID: 9054 RVA: 0x00010FA0 File Offset: 0x0000F1A0
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIValueSummer<T>.ValueReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_String_0;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_T_byref_String_0;
		}
	}
}

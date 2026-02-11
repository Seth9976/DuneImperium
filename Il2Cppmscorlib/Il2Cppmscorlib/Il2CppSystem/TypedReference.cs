using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200013C RID: 316
	[StructLayout(2)]
	public struct TypedReference
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x0008F244 File Offset: 0x0008D444
		// Note: this type is marked as 'beforefieldinit'.
		static TypedReference()
		{
			Il2CppClassPointerStore<TypedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedReference>.NativeClassPtr);
			TypedReference.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "type");
			TypedReference.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Value");
			TypedReference.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Type");
			TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667168);
			TypedReference.NativeMethodInfoPtr_InternalMakeTypedReference_Private_Static_Void_ptr_Void_Object_Il2CppStructArray_1_IntPtr_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667169);
			TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667170);
			TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667171);
			TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667172);
			TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100667173);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0008F328 File Offset: 0x0008D528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343548, RefRangeEnd = 1343549, XrefRangeStart = 1343526, XrefRangeEnd = 1343548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedReference MakeTypedReference(Object target, Il2CppReferenceArray<FieldInfo> flds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0008F37C File Offset: 0x0008D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343549, XrefRangeEnd = 1343550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalMakeTypedReference(void* result, Object target, Il2CppStructArray<IntPtr> flds, RuntimeType lastFieldType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flds);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastFieldType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_InternalMakeTypedReference_Private_Static_Void_ptr_Void_Object_Il2CppStructArray_1_IntPtr_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0008F3E4 File Offset: 0x0008D5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343550, XrefRangeEnd = 1343554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0008F414 File Offset: 0x0008D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343554, XrefRangeEnd = 1343561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0008F458 File Offset: 0x0008D658
		public unsafe bool IsNull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1343561, RefRangeEnd = 1343562, XrefRangeStart = 1343561, XrefRangeEnd = 1343561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0008F488 File Offset: 0x0008D688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343568, RefRangeEnd = 1343569, XrefRangeStart = 1343562, XrefRangeEnd = 1343568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTypedReference(TypedReference target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00006AE9 File Offset: 0x00004CE9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, ref this));
		}

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_InternalMakeTypedReference_Private_Static_Void_ptr_Void_Object_Il2CppStructArray_1_IntPtr_RuntimeType_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0;

		// Token: 0x040012DE RID: 4830
		[FieldOffset(0)]
		public RuntimeTypeHandle type;

		// Token: 0x040012DF RID: 4831
		[FieldOffset(8)]
		public IntPtr Value;

		// Token: 0x040012E0 RID: 4832
		[FieldOffset(16)]
		public IntPtr Type;
	}
}

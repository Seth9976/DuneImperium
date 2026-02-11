using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000174 RID: 372
	[Serializable]
	public class ValueType : Object
	{
		// Token: 0x06001913 RID: 6419 RVA: 0x0009BD70 File Offset: 0x00099F70
		// Note: this type is marked as 'beforefieldinit'.
		static ValueType()
		{
			Il2CppClassPointerStore<ValueType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueType>.NativeClassPtr);
			ValueType.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667629);
			ValueType.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667630);
			ValueType.NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667631);
			ValueType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667632);
			ValueType.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667633);
			ValueType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667634);
			ValueType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueType>.NativeClassPtr, 100667635);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0009BE2C File Offset: 0x0009A02C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0009BE68 File Offset: 0x0009A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349900, XrefRangeEnd = 1349901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalEquals(Object o1, Object o2, out Il2CppReferenceArray<Object> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fields = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349902, RefRangeEnd = 1349904, XrefRangeStart = 1349901, XrefRangeEnd = 1349902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DefaultEquals(Object o1, Object o2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0009BF34 File Offset: 0x0009A134
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1340104, RefRangeEnd = 1340134, XrefRangeStart = 1340104, XrefRangeEnd = 1340134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0009BF8C File Offset: 0x0009A18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349904, XrefRangeEnd = 1349905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalGetHashCode(Object o, out Il2CppReferenceArray<Object> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueType.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fields = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0009BFF0 File Offset: 0x0009A1F0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1349907, RefRangeEnd = 1349934, XrefRangeStart = 1349905, XrefRangeEnd = 1349907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0009C038 File Offset: 0x0009A238
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1349936, RefRangeEnd = 1349943, XrefRangeStart = 1349934, XrefRangeEnd = 1349936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00008130 File Offset: 0x00006330
		public ValueType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_InternalEquals_Private_Static_Boolean_Object_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_DefaultEquals_Internal_Static_Boolean_Object_Object_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

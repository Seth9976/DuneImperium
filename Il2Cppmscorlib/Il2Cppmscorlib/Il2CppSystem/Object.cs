using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200015F RID: 351
	[Serializable]
	public class Object : Il2CppObjectBase
	{
		// Token: 0x060017BC RID: 6076 RVA: 0x00096CF8 File Offset: 0x00094EF8
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667440);
			Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667441);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667442);
			Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667443);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667444);
			Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667445);
			Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667446);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667447);
			Object.NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667448);
			Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667449);
			Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667450);
			Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100667451);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00096E18 File Offset: 0x00095018
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00096E70 File Offset: 0x00095070
		[CallerCount(239)]
		[CachedScanResults(RefRangeStart = 1347122, RefRangeEnd = 1347361, XrefRangeStart = 1347122, XrefRangeEnd = 1347122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00096EC4 File Offset: 0x000950C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00096F00 File Offset: 0x00095100
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00096F3C File Offset: 0x0009513C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1347362, RefRangeEnd = 1347381, XrefRangeStart = 1347361, XrefRangeEnd = 1347362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00096F84 File Offset: 0x00095184
		[CallerCount(757)]
		[CachedScanResults(RefRangeStart = 1347382, RefRangeEnd = 1348139, XrefRangeStart = 1347381, XrefRangeEnd = 1347382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00096FC4 File Offset: 0x000951C4
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1345473, RefRangeEnd = 1345530, XrefRangeStart = 1345473, XrefRangeEnd = 1345530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MemberwiseClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00097004 File Offset: 0x00095204
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1348141, RefRangeEnd = 1348152, XrefRangeStart = 1348139, XrefRangeEnd = 1348141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00097048 File Offset: 0x00095248
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReferenceEquals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0009709C File Offset: 0x0009529C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1347362, RefRangeEnd = 1347381, XrefRangeStart = 1347362, XrefRangeEnd = 1347381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalGetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000970E0 File Offset: 0x000952E0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldGetter(string typeName, string fieldName, ref Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0009715C File Offset: 0x0009535C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldSetter(string typeName, string fieldName, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00007859 File Offset: 0x00005A59
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00007862 File Offset: 0x00005A62
		public static implicit operator Object(string A_0)
		{
			return A_0;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x000971C4 File Offset: 0x000953C4
		public static implicit operator Object(sbyte value)
		{
			SByte @sbyte = default(SByte);
			@sbyte.m_value = value;
			return @sbyte.BoxIl2CppObject();
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000971E8 File Offset: 0x000953E8
		public static implicit operator Object(byte value)
		{
			Byte @byte = default(Byte);
			@byte.m_value = value;
			return @byte.BoxIl2CppObject();
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0009720C File Offset: 0x0009540C
		public static implicit operator Object(short value)
		{
			Int16 @int = default(Int16);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00097230 File Offset: 0x00095430
		public static implicit operator Object(ushort value)
		{
			UInt16 @uint = default(UInt16);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00097254 File Offset: 0x00095454
		public static implicit operator Object(int value)
		{
			Int32 @int = default(Int32);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00097278 File Offset: 0x00095478
		public static implicit operator Object(uint value)
		{
			UInt32 @uint = default(UInt32);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0009729C File Offset: 0x0009549C
		public static implicit operator Object(long value)
		{
			Int64 @int = default(Int64);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000972C0 File Offset: 0x000954C0
		public static implicit operator Object(ulong value)
		{
			UInt64 @uint = default(UInt64);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000972E4 File Offset: 0x000954E4
		public static implicit operator Object(float value)
		{
			Single single = default(Single);
			single.m_value = value;
			return single.BoxIl2CppObject();
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00097308 File Offset: 0x00095508
		public static implicit operator Object(double value)
		{
			Double @double = default(Double);
			@double.m_value = value;
			return @double.BoxIl2CppObject();
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0009732C File Offset: 0x0009552C
		public static implicit operator Object(char value)
		{
			Char @char = default(Char);
			@char.m_value = value;
			return @char.BoxIl2CppObject();
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00097350 File Offset: 0x00095550
		public static implicit operator Object(bool value)
		{
			Boolean boolean = default(Boolean);
			boolean.m_value = value;
			return boolean.BoxIl2CppObject();
		}

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Type_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceEquals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0;
	}
}

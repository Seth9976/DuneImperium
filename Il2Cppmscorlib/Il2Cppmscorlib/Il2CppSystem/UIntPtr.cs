using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	[StructLayout(2)]
	public struct UIntPtr
	{
		// Token: 0x06001902 RID: 6402 RVA: 0x0009B8E4 File Offset: 0x00099AE4
		// Note: this type is marked as 'beforefieldinit'.
		static UIntPtr()
		{
			Il2CppClassPointerStore<UIntPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UIntPtr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr);
			UIntPtr.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, "Zero");
			UIntPtr.NativeFieldInfoPtr__pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, "_pointer");
			UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667615);
			UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667616);
			UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667617);
			UIntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667618);
			UIntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667619);
			UIntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667620);
			UIntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667621);
			UIntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667622);
			UIntPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UIntPtr_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667623);
			UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667624);
			UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667625);
			UIntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667626);
			UIntPtr.NativeMethodInfoPtr_System_IEquatable_System_UIntPtr__Equals_Private_Virtual_Final_New_Boolean_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667627);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0009BA40 File Offset: 0x00099C40
		[CallerCount(0)]
		public unsafe UIntPtr(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0009BA74 File Offset: 0x00099C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349885, RefRangeEnd = 1349887, XrefRangeStart = 1349885, XrefRangeEnd = 1349885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntPtr(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0009BAA8 File Offset: 0x00099CA8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntPtr(void* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0009BADC File Offset: 0x00099CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349887, XrefRangeEnd = 1349890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0009BB20 File Offset: 0x00099D20
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0009BB50 File Offset: 0x00099D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349890, XrefRangeEnd = 1349891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0009BB7C File Offset: 0x00099D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349891, XrefRangeEnd = 1349900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0009BBCC File Offset: 0x00099DCC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0009BC18 File Offset: 0x00099E18
		[CallerCount(736)]
		[CachedScanResults(RefRangeStart = 974210, RefRangeEnd = 974946, XrefRangeStart = 974210, XrefRangeEnd = 974946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UIntPtr_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0009BC64 File Offset: 0x00099E64
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 330146, RefRangeEnd = 330194, XrefRangeStart = 330146, XrefRangeEnd = 330194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UIntPtr(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UIntPtr(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0009BCE4 File Offset: 0x00099EE4
		public unsafe static int Size
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 72449, RefRangeEnd = 72472, XrefRangeStart = 72449, XrefRangeEnd = 72472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0009BD14 File Offset: 0x00099F14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1309270, RefRangeEnd = 1309279, XrefRangeStart = 1309270, XrefRangeEnd = 1309279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IEquatable_System_UIntPtr__Equals(UIntPtr other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_System_IEquatable_System_UIntPtr__Equals_Private_Virtual_Final_New_Boolean_UIntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00008110 File Offset: 0x00006310
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, ref this));
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0009BD54 File Offset: 0x00099F54
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00008122 File Offset: 0x00006322
		public unsafe static UIntPtr Zero
		{
			get
			{
				UIntPtr uintPtr;
				IL2CPP.il2cpp_field_static_get_value(UIntPtr.NativeFieldInfoPtr_Zero, (void*)(&uintPtr));
				return uintPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIntPtr.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr__pointer;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UIntPtr_UIntPtr_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt64_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_UInt32_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_System_IEquatable_System_UIntPtr__Equals_Private_Virtual_Final_New_Boolean_UIntPtr_0;

		// Token: 0x040016FE RID: 5886
		[FieldOffset(0)]
		public readonly IntPtr _pointer;
	}
}

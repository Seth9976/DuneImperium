using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000194 RID: 404
	[StructLayout(2)]
	public struct Scale
	{
		// Token: 0x06002174 RID: 8564 RVA: 0x00097020 File Offset: 0x00095220
		// Note: this type is marked as 'beforefieldinit'.
		static Scale()
		{
			Il2CppClassPointerStore<Scale>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Scale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scale>.NativeClassPtr);
			Scale.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scale>.NativeClassPtr, "m_Scale");
			Scale.NativeFieldInfoPtr_m_IsNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scale>.NativeClassPtr, "m_IsNone");
			Scale.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668229);
			Scale.NativeMethodInfoPtr_Initial_Internal_Static_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668230);
			Scale.NativeMethodInfoPtr_None_Public_Static_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668231);
			Scale.NativeMethodInfoPtr_get_value_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668232);
			Scale.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scale_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668233);
			Scale.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scale_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668234);
			Scale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668235);
			Scale.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668236);
			Scale.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668237);
			Scale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scale>.NativeClassPtr, 100668238);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00097140 File Offset: 0x00095340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334541, RefRangeEnd = 334542, XrefRangeStart = 334534, XrefRangeEnd = 334541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scale(Vector3 scale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00097174 File Offset: 0x00095374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334551, RefRangeEnd = 334554, XrefRangeStart = 334542, XrefRangeEnd = 334551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scale Initial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_Initial_Internal_Static_Scale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000971A4 File Offset: 0x000953A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334555, RefRangeEnd = 334556, XrefRangeStart = 334554, XrefRangeEnd = 334555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scale None()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_None_Public_Static_Scale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x000971D4 File Offset: 0x000953D4
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x0000E0A9 File Offset: 0x0000C2A9
		public unsafe Vector3 value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_get_value_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Scale = value;
			}
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00097204 File Offset: 0x00095404
		[CallerCount(0)]
		public unsafe static bool operator ==(Scale lhs, Scale rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scale_Scale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00097250 File Offset: 0x00095450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334556, RefRangeEnd = 334558, XrefRangeStart = 334556, XrefRangeEnd = 334556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Scale lhs, Scale rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scale_Scale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0009729C File Offset: 0x0009549C
		[CallerCount(0)]
		public unsafe bool Equals(Scale other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Scale_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000972DC File Offset: 0x000954DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334558, XrefRangeEnd = 334561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00097320 File Offset: 0x00095520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334561, XrefRangeEnd = 334564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00097350 File Offset: 0x00095550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334564, XrefRangeEnd = 334565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0000E097 File Offset: 0x0000C297
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scale>.NativeClassPtr, ref this));
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0000E0B2 File Offset: 0x0000C2B2
		public bool IsNone()
		{
			return this.m_IsNone;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x0009737C File Offset: 0x0009557C
		public static implicit operator Scale(Vector2 scale)
		{
			return new Scale(scale);
		}

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_m_IsNone;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_Initial_Internal_Static_Scale_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_None_Public_Static_Scale_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Vector3_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scale_Scale_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scale_Scale_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Scale_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001786 RID: 6022
		[FieldOffset(0)]
		public Vector3 m_Scale;

		// Token: 0x04001787 RID: 6023
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_IsNone;
	}
}

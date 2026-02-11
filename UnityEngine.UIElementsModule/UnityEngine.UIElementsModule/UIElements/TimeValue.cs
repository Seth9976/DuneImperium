using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A8 RID: 424
	[StructLayout(2)]
	public struct TimeValue
	{
		// Token: 0x060022A0 RID: 8864 RVA: 0x0009B79C File Offset: 0x0009999C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeValue()
		{
			Il2CppClassPointerStore<TimeValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimeValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeValue>.NativeClassPtr);
			TimeValue.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, "m_Value");
			TimeValue.NativeFieldInfoPtr_m_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, "m_Unit");
			TimeValue.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668415);
			TimeValue.NativeMethodInfoPtr_get_unit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668416);
			TimeValue.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668417);
			TimeValue.NativeMethodInfoPtr__ctor_Public_Void_Single_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668418);
			TimeValue.NativeMethodInfoPtr_op_Implicit_Public_Static_TimeValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668419);
			TimeValue.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeValue_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668420);
			TimeValue.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeValue_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668421);
			TimeValue.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668422);
			TimeValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668423);
			TimeValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668424);
			TimeValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, 100668425);
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0009B8D0 File Offset: 0x00099AD0
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0000E4A6 File Offset: 0x0000C6A6
		public unsafe float value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0009B900 File Offset: 0x00099B00
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000E4AF File Offset: 0x0000C6AF
		public unsafe TimeUnit unit
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_get_unit_Public_get_TimeUnit_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Unit = value;
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0009B930 File Offset: 0x00099B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335490, RefRangeEnd = 335492, XrefRangeStart = 335490, XrefRangeEnd = 335492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0009B964 File Offset: 0x00099B64
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 286583, RefRangeEnd = 286597, XrefRangeStart = 286583, XrefRangeEnd = 286597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeValue(float value, TimeUnit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr__ctor_Public_Void_Single_TimeUnit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0009B9A4 File Offset: 0x00099BA4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 323518, RefRangeEnd = 323546, XrefRangeStart = 323518, XrefRangeEnd = 323546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator TimeValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_op_Implicit_Public_Static_TimeValue_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0009B9E4 File Offset: 0x00099BE4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 323546, RefRangeEnd = 323585, XrefRangeStart = 323546, XrefRangeEnd = 323585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TimeValue lhs, TimeValue rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeValue_TimeValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0009BA30 File Offset: 0x00099C30
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 334408, RefRangeEnd = 334463, XrefRangeStart = 334408, XrefRangeEnd = 334463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TimeValue lhs, TimeValue rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeValue_TimeValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0009BA7C File Offset: 0x00099C7C
		[CallerCount(0)]
		public unsafe bool Equals(TimeValue other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0009BABC File Offset: 0x00099CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335966, XrefRangeEnd = 335969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0009BB00 File Offset: 0x00099D00
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 323589, RefRangeEnd = 323599, XrefRangeStart = 323589, XrefRangeEnd = 323599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x0009BB30 File Offset: 0x00099D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335969, XrefRangeEnd = 335980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0000E494 File Offset: 0x0000C694
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeValue>.NativeClassPtr, ref this));
		}

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr_m_Unit;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_get_unit_Public_get_TimeUnit_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_TimeUnit_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TimeValue_Single_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeValue_TimeValue_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeValue_TimeValue_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeValue_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001879 RID: 6265
		[FieldOffset(0)]
		public float m_Value;

		// Token: 0x0400187A RID: 6266
		[FieldOffset(4)]
		public TimeUnit m_Unit;
	}
}

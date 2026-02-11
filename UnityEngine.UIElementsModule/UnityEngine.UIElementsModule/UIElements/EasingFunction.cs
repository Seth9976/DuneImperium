using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000183 RID: 387
	[StructLayout(2)]
	public struct EasingFunction
	{
		// Token: 0x06001D08 RID: 7432 RVA: 0x0008495C File Offset: 0x00082B5C
		// Note: this type is marked as 'beforefieldinit'.
		static EasingFunction()
		{
			Il2CppClassPointerStore<EasingFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EasingFunction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr);
			EasingFunction.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, "m_Mode");
			EasingFunction.NativeMethodInfoPtr_get_mode_Public_get_EasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667568);
			EasingFunction.NativeMethodInfoPtr__ctor_Public_Void_EasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667569);
			EasingFunction.NativeMethodInfoPtr_op_Implicit_Public_Static_EasingFunction_EasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667570);
			EasingFunction.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EasingFunction_EasingFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667571);
			EasingFunction.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EasingFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667572);
			EasingFunction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667573);
			EasingFunction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667574);
			EasingFunction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, 100667575);
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00084A40 File Offset: 0x00082C40
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000CE02 File Offset: 0x0000B002
		public unsafe EasingMode mode
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_get_mode_Public_get_EasingMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00084A70 File Offset: 0x00082C70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EasingFunction(EasingMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr__ctor_Public_Void_EasingMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00084AA4 File Offset: 0x00082CA4
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 328435, RefRangeEnd = 328482, XrefRangeStart = 328435, XrefRangeEnd = 328435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator EasingFunction(EasingMode easingMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref easingMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_op_Implicit_Public_Static_EasingFunction_EasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00084AE4 File Offset: 0x00082CE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 323148, RefRangeEnd = 323154, XrefRangeStart = 323148, XrefRangeEnd = 323154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(EasingFunction lhs, EasingFunction rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EasingFunction_EasingFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00084B30 File Offset: 0x00082D30
		[CallerCount(0)]
		public unsafe bool Equals(EasingFunction other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EasingFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00084B70 File Offset: 0x00082D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328482, XrefRangeEnd = 328485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00084BB4 File Offset: 0x00082DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328485, XrefRangeEnd = 328488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00084BE0 File Offset: 0x00082DE0
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EasingFunction.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EasingFunction>.NativeClassPtr, ref this));
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00084C10 File Offset: 0x00082E10
		public static bool operator !=(EasingFunction lhs, EasingFunction rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_EasingMode_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EasingMode_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EasingFunction_EasingMode_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EasingFunction_EasingFunction_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EasingFunction_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001450 RID: 5200
		[FieldOffset(0)]
		public EasingMode m_Mode;
	}
}

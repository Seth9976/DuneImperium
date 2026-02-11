using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018E RID: 398
	public sealed class TransitionData : ValueType
	{
		// Token: 0x06002100 RID: 8448 RVA: 0x000956D0 File Offset: 0x000938D0
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionData()
		{
			Il2CppClassPointerStore<TransitionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionData>.NativeClassPtr);
			TransitionData.NativeFieldInfoPtr_transitionDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, "transitionDelay");
			TransitionData.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, "transitionDuration");
			TransitionData.NativeFieldInfoPtr_transitionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, "transitionProperty");
			TransitionData.NativeFieldInfoPtr_transitionTimingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, "transitionTimingFunction");
			TransitionData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransitionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668180);
			TransitionData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransitionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668181);
			TransitionData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransitionData_TransitionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668182);
			TransitionData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668183);
			TransitionData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668184);
			TransitionData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionData>.NativeClassPtr, 100668185);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000957C8 File Offset: 0x000939C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334150, RefRangeEnd = 334156, XrefRangeStart = 334124, XrefRangeEnd = 334150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionData Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransitionData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TransitionData(intPtr);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00095804 File Offset: 0x00093A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334156, XrefRangeEnd = 334171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ref TransitionData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransitionData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0009584C File Offset: 0x00093A4C
		[CallerCount(0)]
		public unsafe static bool operator ==(TransitionData lhs, TransitionData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransitionData_TransitionData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000958AC File Offset: 0x00093AAC
		[CallerCount(0)]
		public unsafe bool Equals(TransitionData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00095904 File Offset: 0x00093B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334171, XrefRangeEnd = 334174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00095958 File Offset: 0x00093B58
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0000DDAE File Offset: 0x0000BFAE
		public TransitionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0000DDB7 File Offset: 0x0000BFB7
		public TransitionData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionData>.NativeClassPtr))
		{
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0009599C File Offset: 0x00093B9C
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		public unsafe List<TimeValue> transitionDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionDelay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionDelay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000959CC File Offset: 0x00093BCC
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public unsafe List<TimeValue> transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionDuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimeValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionDuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x000959FC File Offset: 0x00093BFC
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x0000DE07 File Offset: 0x0000C007
		public unsafe List<StylePropertyName> transitionProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x00095A2C File Offset: 0x00093C2C
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x0000DE26 File Offset: 0x0000C026
		public unsafe List<EasingFunction> transitionTimingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionTimingFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EasingFunction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionData.NativeFieldInfoPtr_transitionTimingFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00095A5C File Offset: 0x00093C5C
		public static bool operator !=(TransitionData lhs, TransitionData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_transitionDelay;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_transitionProperty;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr_transitionTimingFunction;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransitionData_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransitionData_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransitionData_TransitionData_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransitionData_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

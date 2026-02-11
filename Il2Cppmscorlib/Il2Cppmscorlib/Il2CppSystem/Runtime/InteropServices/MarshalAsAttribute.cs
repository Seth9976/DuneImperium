using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200039A RID: 922
	public sealed class MarshalAsAttribute : Attribute
	{
		// Token: 0x06003874 RID: 14452 RVA: 0x00113428 File Offset: 0x00111628
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalAsAttribute()
		{
			Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MarshalAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr);
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalCookie");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalType");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalTypeRef");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArrayUserDefinedSubType");
			MarshalAsAttribute.NativeFieldInfoPtr_utype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "utype");
			MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "ArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeConst");
			MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "IidParameterIndex");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeParamIndex");
			MarshalAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671759);
			MarshalAsAttribute.NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671760);
			MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100671761);
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0011355C File Offset: 0x0011175C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392514, XrefRangeEnd = 1392515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute(UnmanagedType unmanagedType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unmanagedType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x001135A4 File Offset: 0x001117A4
		public unsafe UnmanagedType Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalAsAttribute.NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x001135E0 File Offset: 0x001117E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392518, RefRangeEnd = 1392519, XrefRangeStart = 1392515, XrefRangeEnd = 1392518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x000149E0 File Offset: 0x00012BE0
		public MarshalAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x00113620 File Offset: 0x00111820
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x000149E9 File Offset: 0x00012BE9
		public unsafe string MarshalCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x00113648 File Offset: 0x00111848
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x00014A08 File Offset: 0x00012C08
		public unsafe string MarshalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x00113670 File Offset: 0x00111870
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x00014A27 File Offset: 0x00012C27
		public unsafe Type MarshalTypeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x001136A0 File Offset: 0x001118A0
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x00014A46 File Offset: 0x00012C46
		public unsafe Type SafeArrayUserDefinedSubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x001136D0 File Offset: 0x001118D0
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x00014A65 File Offset: 0x00012C65
		public unsafe UnmanagedType utype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype)) = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x001136F8 File Offset: 0x001118F8
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x00014A80 File Offset: 0x00012C80
		public unsafe UnmanagedType ArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType)) = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x00113720 File Offset: 0x00111920
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x00014A9B File Offset: 0x00012C9B
		public unsafe VarEnum SafeArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType)) = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x00113748 File Offset: 0x00111948
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x00014AB6 File Offset: 0x00012CB6
		public unsafe int SizeConst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst)) = value;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x00113770 File Offset: 0x00111970
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x00014AD1 File Offset: 0x00012CD1
		public unsafe int IidParameterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex)) = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x00113798 File Offset: 0x00111998
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x00014AEC File Offset: 0x00012CEC
		public unsafe short SizeParamIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex)) = value;
			}
		}

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeFieldInfoPtr_MarshalCookie;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeFieldInfoPtr_MarshalType;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeFieldInfoPtr_MarshalTypeRef;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeFieldInfoPtr_SafeArrayUserDefinedSubType;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeFieldInfoPtr_utype;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeFieldInfoPtr_ArraySubType;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_SafeArraySubType;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_SizeConst;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_IidParameterIndex;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_SizeParamIndex;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnmanagedType_0;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_UnmanagedType_0;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0;
	}
}

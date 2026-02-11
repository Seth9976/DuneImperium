using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B5 RID: 949
	public sealed class FixedBufferAttribute : Attribute
	{
		// Token: 0x0600390A RID: 14602 RVA: 0x00114D44 File Offset: 0x00112F44
		// Note: this type is marked as 'beforefieldinit'.
		static FixedBufferAttribute()
		{
			Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FixedBufferAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr);
			FixedBufferAttribute.NativeFieldInfoPtr__ElementType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "<ElementType>k__BackingField");
			FixedBufferAttribute.NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "<Length>k__BackingField");
			FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100671813);
			FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100671814);
			FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100671815);
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00114DD8 File Offset: 0x00112FD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedBufferAttribute(Type elementType, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00114E34 File Offset: 0x00113034
		public unsafe Type ElementType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00114E74 File Offset: 0x00113074
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0001504F File Offset: 0x0001324F
		public FixedBufferAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x00114EB0 File Offset: 0x001130B0
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x00015058 File Offset: 0x00013258
		public unsafe Type _ElementType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr__ElementType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr__ElementType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x00114EE0 File Offset: 0x001130E0
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x00015077 File Offset: 0x00013277
		public unsafe int _Length_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr__Length_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr__Length_k__BackingField)) = value;
			}
		}

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr__ElementType_k__BackingField;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr__Length_k__BackingField;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Public_get_Type_0;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
	}
}

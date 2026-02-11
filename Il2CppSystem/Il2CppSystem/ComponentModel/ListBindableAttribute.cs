using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000119 RID: 281
	public sealed class ListBindableAttribute : Attribute
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x0005DF64 File Offset: 0x0005C164
		// Note: this type is marked as 'beforefieldinit'.
		static ListBindableAttribute()
		{
			Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ListBindableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr);
			ListBindableAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, "Yes");
			ListBindableAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, "No");
			ListBindableAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, "Default");
			ListBindableAttribute.NativeFieldInfoPtr__isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, "_isDefault");
			ListBindableAttribute.NativeFieldInfoPtr__ListBindable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, "<ListBindable>k__BackingField");
			ListBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, 100665809);
			ListBindableAttribute.NativeMethodInfoPtr_get_ListBindable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, 100665810);
			ListBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, 100665811);
			ListBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, 100665812);
			ListBindableAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr, 100665813);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0005E05C File Offset: 0x0005C25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459418, RefRangeEnd = 459419, XrefRangeStart = 459417, XrefRangeEnd = 459418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListBindableAttribute(bool listBindable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListBindableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listBindable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
		public unsafe bool ListBindable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBindableAttribute.NativeMethodInfoPtr_get_ListBindable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0005E0E0 File Offset: 0x0005C2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459419, XrefRangeEnd = 459421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0005E130 File Offset: 0x0005C330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0005E16C File Offset: 0x0005C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459421, XrefRangeEnd = 459425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBindableAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00008153 File Offset: 0x00006353
		public ListBindableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0000815C File Offset: 0x0000635C
		public unsafe static ListBindableAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListBindableAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListBindableAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0000816E File Offset: 0x0000636E
		public unsafe static ListBindableAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListBindableAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListBindableAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0005E1F8 File Offset: 0x0005C3F8
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x00008180 File Offset: 0x00006380
		public unsafe static ListBindableAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListBindableAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListBindableAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0005E220 File Offset: 0x0005C420
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00008192 File Offset: 0x00006392
		public unsafe bool _isDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBindableAttribute.NativeFieldInfoPtr__isDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBindableAttribute.NativeFieldInfoPtr__isDefault)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0005E248 File Offset: 0x0005C448
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000081AD File Offset: 0x000063AD
		public unsafe bool _ListBindable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBindableAttribute.NativeFieldInfoPtr__ListBindable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBindableAttribute.NativeFieldInfoPtr__ListBindable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr__isDefault;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeFieldInfoPtr__ListBindable_k__BackingField;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_get_ListBindable_Public_get_Boolean_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

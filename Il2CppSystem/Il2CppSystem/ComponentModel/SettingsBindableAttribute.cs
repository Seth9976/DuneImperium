using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000129 RID: 297
	public sealed class SettingsBindableAttribute : Attribute
	{
		// Token: 0x06001238 RID: 4664 RVA: 0x00062008 File Offset: 0x00060208
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsBindableAttribute()
		{
			Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SettingsBindableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr);
			SettingsBindableAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "Yes");
			SettingsBindableAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "No");
			SettingsBindableAttribute.NativeFieldInfoPtr__Bindable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "<Bindable>k__BackingField");
			SettingsBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100665952);
			SettingsBindableAttribute.NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100665953);
			SettingsBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100665954);
			SettingsBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100665955);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000620C4 File Offset: 0x000602C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsBindableAttribute(bool bindable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0006210C File Offset: 0x0006030C
		public unsafe bool Bindable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00062148 File Offset: 0x00060348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460399, XrefRangeEnd = 460401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00062198 File Offset: 0x00060398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460401, XrefRangeEnd = 460405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000086B7 File Offset: 0x000068B7
		public SettingsBindableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000621D4 File Offset: 0x000603D4
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x000086C0 File Offset: 0x000068C0
		public unsafe static SettingsBindableAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsBindableAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsBindableAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000621FC File Offset: 0x000603FC
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x000086D2 File Offset: 0x000068D2
		public unsafe static SettingsBindableAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsBindableAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsBindableAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00062224 File Offset: 0x00060424
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x000086E4 File Offset: 0x000068E4
		public unsafe bool _Bindable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsBindableAttribute.NativeFieldInfoPtr__Bindable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsBindableAttribute.NativeFieldInfoPtr__Bindable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr__Bindable_k__BackingField;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

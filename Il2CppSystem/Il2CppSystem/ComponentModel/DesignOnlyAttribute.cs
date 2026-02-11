using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000E7 RID: 231
	public sealed class DesignOnlyAttribute : Attribute
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x000558A8 File Offset: 0x00053AA8
		// Note: this type is marked as 'beforefieldinit'.
		static DesignOnlyAttribute()
		{
			Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr);
			DesignOnlyAttribute.NativeFieldInfoPtr__IsDesignOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, "<IsDesignOnly>k__BackingField");
			DesignOnlyAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, "Yes");
			DesignOnlyAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, "No");
			DesignOnlyAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, "Default");
			DesignOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, 100665504);
			DesignOnlyAttribute.NativeMethodInfoPtr_get_IsDesignOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, 100665505);
			DesignOnlyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, 100665506);
			DesignOnlyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, 100665507);
			DesignOnlyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr, 100665508);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0005598C File Offset: 0x00053B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignOnlyAttribute(bool isDesignOnly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignOnlyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isDesignOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000559D4 File Offset: 0x00053BD4
		public unsafe bool IsDesignOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignOnlyAttribute.NativeMethodInfoPtr_get_IsDesignOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00055A10 File Offset: 0x00053C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456236, XrefRangeEnd = 456243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignOnlyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00055A60 File Offset: 0x00053C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456243, XrefRangeEnd = 456247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignOnlyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00055A9C File Offset: 0x00053C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456247, XrefRangeEnd = 456251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignOnlyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00007817 File Offset: 0x00005A17
		public DesignOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00055AD8 File Offset: 0x00053CD8
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00007820 File Offset: 0x00005A20
		public unsafe bool _IsDesignOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignOnlyAttribute.NativeFieldInfoPtr__IsDesignOnly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignOnlyAttribute.NativeFieldInfoPtr__IsDesignOnly_k__BackingField)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00055B00 File Offset: 0x00053D00
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x0000783B File Offset: 0x00005A3B
		public unsafe static DesignOnlyAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignOnlyAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignOnlyAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00055B28 File Offset: 0x00053D28
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x0000784D File Offset: 0x00005A4D
		public unsafe static DesignOnlyAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignOnlyAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignOnlyAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00055B50 File Offset: 0x00053D50
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x0000785F File Offset: 0x00005A5F
		public unsafe static DesignOnlyAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignOnlyAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignOnlyAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr__IsDesignOnly_k__BackingField;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDesignOnly_Public_get_Boolean_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

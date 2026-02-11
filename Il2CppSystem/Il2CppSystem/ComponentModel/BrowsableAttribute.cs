using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000E4 RID: 228
	public sealed class BrowsableAttribute : Attribute
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x00055204 File Offset: 0x00053404
		// Note: this type is marked as 'beforefieldinit'.
		static BrowsableAttribute()
		{
			Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr);
			BrowsableAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "Yes");
			BrowsableAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "No");
			BrowsableAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "Default");
			BrowsableAttribute.NativeFieldInfoPtr__Browsable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "<Browsable>k__BackingField");
			BrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100665488);
			BrowsableAttribute.NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100665489);
			BrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100665490);
			BrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100665491);
			BrowsableAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100665492);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000552E8 File Offset: 0x000534E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrowsableAttribute(bool browsable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref browsable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00055330 File Offset: 0x00053530
		public unsafe bool Browsable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0005536C File Offset: 0x0005356C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456156, XrefRangeEnd = 456163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000553BC File Offset: 0x000535BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456163, XrefRangeEnd = 456167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000553F8 File Offset: 0x000535F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456167, XrefRangeEnd = 456187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00007741 File Offset: 0x00005941
		public BrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00055434 File Offset: 0x00053634
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0000774A File Offset: 0x0000594A
		public unsafe static BrowsableAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0005545C File Offset: 0x0005365C
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x0000775C File Offset: 0x0000595C
		public unsafe static BrowsableAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00055484 File Offset: 0x00053684
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0000776E File Offset: 0x0000596E
		public unsafe static BrowsableAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000554AC File Offset: 0x000536AC
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00007780 File Offset: 0x00005980
		public unsafe bool _Browsable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrowsableAttribute.NativeFieldInfoPtr__Browsable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrowsableAttribute.NativeFieldInfoPtr__Browsable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr__Browsable_k__BackingField;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

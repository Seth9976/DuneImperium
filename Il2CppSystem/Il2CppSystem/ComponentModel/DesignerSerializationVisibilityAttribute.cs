using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000EA RID: 234
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x00055F28 File Offset: 0x00054128
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerSerializationVisibilityAttribute()
		{
			Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignerSerializationVisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr);
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Content");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Hidden");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Visible");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Default");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr__Visibility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "<Visibility>k__BackingField");
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100665518);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100665519);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100665520);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100665521);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100665522);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00056020 File Offset: 0x00054220
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibility;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00056068 File Offset: 0x00054268
		public unsafe DesignerSerializationVisibility Visibility
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000560A4 File Offset: 0x000542A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456304, XrefRangeEnd = 456311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000560F4 File Offset: 0x000542F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00056130 File Offset: 0x00054330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456311, XrefRangeEnd = 456337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000078E1 File Offset: 0x00005AE1
		public DesignerSerializationVisibilityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0005616C File Offset: 0x0005436C
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000078EA File Offset: 0x00005AEA
		public unsafe static DesignerSerializationVisibilityAttribute Content
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00056194 File Offset: 0x00054394
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000078FC File Offset: 0x00005AFC
		public unsafe static DesignerSerializationVisibilityAttribute Hidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000561BC File Offset: 0x000543BC
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0000790E File Offset: 0x00005B0E
		public unsafe static DesignerSerializationVisibilityAttribute Visible
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000561E4 File Offset: 0x000543E4
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00007920 File Offset: 0x00005B20
		public unsafe static DesignerSerializationVisibilityAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0005620C File Offset: 0x0005440C
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00007932 File Offset: 0x00005B32
		public unsafe DesignerSerializationVisibility _Visibility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr__Visibility_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr__Visibility_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_Visible;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr__Visibility_k__BackingField;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

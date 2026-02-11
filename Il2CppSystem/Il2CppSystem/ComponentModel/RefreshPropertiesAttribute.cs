using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200014A RID: 330
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x0006B014 File Offset: 0x00069214
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshPropertiesAttribute()
		{
			Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "RefreshPropertiesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr);
			RefreshPropertiesAttribute.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, "All");
			RefreshPropertiesAttribute.NativeFieldInfoPtr_Repaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, "Repaint");
			RefreshPropertiesAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, "Default");
			RefreshPropertiesAttribute.NativeFieldInfoPtr_refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, "refresh");
			RefreshPropertiesAttribute.NativeMethodInfoPtr__ctor_Public_Void_RefreshProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, 100666330);
			RefreshPropertiesAttribute.NativeMethodInfoPtr_get_RefreshProperties_Public_get_RefreshProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, 100666331);
			RefreshPropertiesAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, 100666332);
			RefreshPropertiesAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, 100666333);
			RefreshPropertiesAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr, 100666334);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0006B0F8 File Offset: 0x000692F8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefreshPropertiesAttribute(RefreshProperties refresh)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefreshPropertiesAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshPropertiesAttribute.NativeMethodInfoPtr__ctor_Public_Void_RefreshProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0006B140 File Offset: 0x00069340
		public unsafe RefreshProperties RefreshProperties
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshPropertiesAttribute.NativeMethodInfoPtr_get_RefreshProperties_Public_get_RefreshProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0006B17C File Offset: 0x0006937C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465957, XrefRangeEnd = 465959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshPropertiesAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0006B1CC File Offset: 0x000693CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshPropertiesAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006B208 File Offset: 0x00069408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465959, XrefRangeEnd = 465982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshPropertiesAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000090C7 File Offset: 0x000072C7
		public RefreshPropertiesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0006B244 File Offset: 0x00069444
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x000090D0 File Offset: 0x000072D0
		public unsafe static RefreshPropertiesAttribute All
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_All, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RefreshPropertiesAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_All, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0006B26C File Offset: 0x0006946C
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x000090E2 File Offset: 0x000072E2
		public unsafe static RefreshPropertiesAttribute Repaint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_Repaint, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RefreshPropertiesAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_Repaint, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0006B294 File Offset: 0x00069494
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x000090F4 File Offset: 0x000072F4
		public unsafe static RefreshPropertiesAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RefreshPropertiesAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RefreshPropertiesAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0006B2BC File Offset: 0x000694BC
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x00009106 File Offset: 0x00007306
		public unsafe RefreshProperties refresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshPropertiesAttribute.NativeFieldInfoPtr_refresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshPropertiesAttribute.NativeFieldInfoPtr_refresh)) = value;
			}
		}

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeFieldInfoPtr_Repaint;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeFieldInfoPtr_refresh;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RefreshProperties_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_get_RefreshProperties_Public_get_RefreshProperties_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

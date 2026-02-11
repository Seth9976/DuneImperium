using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000107 RID: 263
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x0005A694 File Offset: 0x00058894
		// Note: this type is marked as 'beforefieldinit'.
		static DesignTimeVisibleAttribute()
		{
			Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignTimeVisibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr);
			DesignTimeVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, "<Visible>k__BackingField");
			DesignTimeVisibleAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, "Yes");
			DesignTimeVisibleAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, "No");
			DesignTimeVisibleAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, "Default");
			DesignTimeVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, 100665674);
			DesignTimeVisibleAttribute.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, 100665675);
			DesignTimeVisibleAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, 100665676);
			DesignTimeVisibleAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, 100665677);
			DesignTimeVisibleAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr, 100665678);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005A778 File Offset: 0x00058978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignTimeVisibleAttribute(bool visible)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignTimeVisibleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignTimeVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0005A7C0 File Offset: 0x000589C0
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignTimeVisibleAttribute.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005A7FC File Offset: 0x000589FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458927, XrefRangeEnd = 458929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignTimeVisibleAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0005A84C File Offset: 0x00058A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458929, XrefRangeEnd = 458935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignTimeVisibleAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0005A888 File Offset: 0x00058A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458935, XrefRangeEnd = 458939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignTimeVisibleAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00007DC7 File Offset: 0x00005FC7
		public DesignTimeVisibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0005A8C4 File Offset: 0x00058AC4
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x00007DD0 File Offset: 0x00005FD0
		public unsafe bool _Visible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignTimeVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignTimeVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField)) = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0005A8EC File Offset: 0x00058AEC
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x00007DEB File Offset: 0x00005FEB
		public unsafe static DesignTimeVisibleAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignTimeVisibleAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0005A914 File Offset: 0x00058B14
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00007DFD File Offset: 0x00005FFD
		public unsafe static DesignTimeVisibleAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignTimeVisibleAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0005A93C File Offset: 0x00058B3C
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x00007E0F File Offset: 0x0000600F
		public unsafe static DesignTimeVisibleAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignTimeVisibleAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignTimeVisibleAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr__Visible_k__BackingField;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

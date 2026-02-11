using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00043D78 File Offset: 0x00041F78
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeUsageAttribute()
		{
			Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AttributeUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr);
			AttributeUsageAttribute.NativeFieldInfoPtr__attributeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_attributeTarget");
			AttributeUsageAttribute.NativeFieldInfoPtr__allowMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_allowMultiple");
			AttributeUsageAttribute.NativeFieldInfoPtr__inherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "_inherited");
			AttributeUsageAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "Default");
			AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664405);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664406);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664407);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664408);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664409);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00043E5C File Offset: 0x0004205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1298910, XrefRangeEnd = 1298911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeUsageAttribute(AttributeTargets validOn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00043EA4 File Offset: 0x000420A4
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00043EE0 File Offset: 0x000420E0
		public unsafe bool AllowMultiple
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00043F20 File Offset: 0x00042120
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00043F5C File Offset: 0x0004215C
		public unsafe bool Inherited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000040A3 File Offset: 0x000022A3
		public AttributeUsageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00043F9C File Offset: 0x0004219C
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000040AC File Offset: 0x000022AC
		public unsafe AttributeTargets _attributeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__attributeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__attributeTarget)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00043FC4 File Offset: 0x000421C4
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000040C7 File Offset: 0x000022C7
		public unsafe bool _allowMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__allowMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__allowMultiple)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00043FEC File Offset: 0x000421EC
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000040E2 File Offset: 0x000022E2
		public unsafe bool _inherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__inherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr__inherited)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00044014 File Offset: 0x00042214
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000040FD File Offset: 0x000022FD
		public unsafe static AttributeUsageAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr__attributeTarget;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr__allowMultiple;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr__inherited;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000148 RID: 328
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x0006AD44 File Offset: 0x00068F44
		// Note: this type is marked as 'beforefieldinit'.
		static NotifyParentPropertyAttribute()
		{
			Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "NotifyParentPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr);
			NotifyParentPropertyAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, "Yes");
			NotifyParentPropertyAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, "No");
			NotifyParentPropertyAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, "Default");
			NotifyParentPropertyAttribute.NativeFieldInfoPtr_notifyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, "notifyParent");
			NotifyParentPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, 100666324);
			NotifyParentPropertyAttribute.NativeMethodInfoPtr_get_NotifyParent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, 100666325);
			NotifyParentPropertyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, 100666326);
			NotifyParentPropertyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, 100666327);
			NotifyParentPropertyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr, 100666328);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006AE28 File Offset: 0x00069028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyParentPropertyAttribute(bool notifyParent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyParentPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref notifyParent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyParentPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0006AE70 File Offset: 0x00069070
		public unsafe bool NotifyParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyParentPropertyAttribute.NativeMethodInfoPtr_get_NotifyParent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0006AEAC File Offset: 0x000690AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465935, XrefRangeEnd = 465937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyParentPropertyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0006AEFC File Offset: 0x000690FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyParentPropertyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0006AF38 File Offset: 0x00069138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465937, XrefRangeEnd = 465957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyParentPropertyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0000906D File Offset: 0x0000726D
		public NotifyParentPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0006AF74 File Offset: 0x00069174
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00009076 File Offset: 0x00007276
		public unsafe static NotifyParentPropertyAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotifyParentPropertyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0006AF9C File Offset: 0x0006919C
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00009088 File Offset: 0x00007288
		public unsafe static NotifyParentPropertyAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotifyParentPropertyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0006AFC4 File Offset: 0x000691C4
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0000909A File Offset: 0x0000729A
		public unsafe static NotifyParentPropertyAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotifyParentPropertyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotifyParentPropertyAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0006AFEC File Offset: 0x000691EC
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x000090AC File Offset: 0x000072AC
		public unsafe bool notifyParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyParentPropertyAttribute.NativeFieldInfoPtr_notifyParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyParentPropertyAttribute.NativeFieldInfoPtr_notifyParent)) = value;
			}
		}

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr_notifyParent;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_get_NotifyParent_Public_get_Boolean_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}

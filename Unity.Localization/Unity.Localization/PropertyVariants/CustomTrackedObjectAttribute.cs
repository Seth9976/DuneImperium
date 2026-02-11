using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.PropertyVariants
{
	// Token: 0x020000DF RID: 223
	public class CustomTrackedObjectAttribute : Attribute
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x00033B98 File Offset: 0x00031D98
		// Note: this type is marked as 'beforefieldinit'.
		static CustomTrackedObjectAttribute()
		{
			Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants", "CustomTrackedObjectAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr);
			CustomTrackedObjectAttribute.NativeFieldInfoPtr__ObjectType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr, "<ObjectType>k__BackingField");
			CustomTrackedObjectAttribute.NativeFieldInfoPtr__SupportsInheritedTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr, "<SupportsInheritedTypes>k__BackingField");
			CustomTrackedObjectAttribute.NativeMethodInfoPtr_get_ObjectType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr, 100665167);
			CustomTrackedObjectAttribute.NativeMethodInfoPtr_get_SupportsInheritedTypes_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr, 100665168);
			CustomTrackedObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr, 100665169);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00033C2C File Offset: 0x00031E2C
		public unsafe Type ObjectType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomTrackedObjectAttribute.NativeMethodInfoPtr_get_ObjectType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00033C6C File Offset: 0x00031E6C
		public unsafe bool SupportsInheritedTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomTrackedObjectAttribute.NativeMethodInfoPtr_get_SupportsInheritedTypes_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00033CA8 File Offset: 0x00031EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomTrackedObjectAttribute(Type type, bool supportsInheritedTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomTrackedObjectAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportsInheritedTypes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomTrackedObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00006B05 File Offset: 0x00004D05
		public CustomTrackedObjectAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00033D04 File Offset: 0x00031F04
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00006B0E File Offset: 0x00004D0E
		public unsafe Type _ObjectType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTrackedObjectAttribute.NativeFieldInfoPtr__ObjectType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTrackedObjectAttribute.NativeFieldInfoPtr__ObjectType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00033D34 File Offset: 0x00031F34
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00006B2D File Offset: 0x00004D2D
		public unsafe bool _SupportsInheritedTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTrackedObjectAttribute.NativeFieldInfoPtr__SupportsInheritedTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomTrackedObjectAttribute.NativeFieldInfoPtr__SupportsInheritedTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr__ObjectType_k__BackingField;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr__SupportsInheritedTypes_k__BackingField;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Internal_get_Type_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsInheritedTypes_Internal_get_Boolean_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0;
	}
}

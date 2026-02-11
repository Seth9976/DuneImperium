using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000006 RID: 6
	public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue>
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000038D4 File Offset: 0x00001AD4
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateProperty()
		{
			Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "DelegateProperty`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr);
			DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr, "m_Getter");
			DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr, "m_Setter");
			DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr, "<Name>k__BackingField");
			DelegateProperty<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr, 100663301);
			DelegateProperty<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_PropertyGetter_2_TContainer_TValue_PropertySetter_2_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr, 100663302);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000039B8 File Offset: 0x00001BB8
		public unsafe override string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DelegateProperty<TContainer, TValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000039FC File Offset: 0x00001BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230385, XrefRangeEnd = 1230397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateProperty(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateProperty<TContainer, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateProperty<TContainer, TValue>.NativeMethodInfoPtr__ctor_Public_Void_String_PropertyGetter_2_TContainer_TValue_PropertySetter_2_TContainer_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020BE File Offset: 0x000002BE
		public DelegateProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020C7 File Offset: 0x000002C7
		public unsafe PropertyGetter<TContainer, TValue> m_Getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyGetter<TContainer, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003A9C File Offset: 0x00001C9C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020E6 File Offset: 0x000002E6
		public unsafe PropertySetter<TContainer, TValue> m_Setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySetter<TContainer, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr_m_Setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003ACC File Offset: 0x00001CCC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002105 File Offset: 0x00000305
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateProperty<TContainer, TValue>.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002124 File Offset: 0x00000324
		public override bool IsReadOnly
		{
			get
			{
				return this.m_Setter == null;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public override TValue GetValue(ref TContainer container)
		{
			return this.m_Getter.Invoke(ref container);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003B14 File Offset: 0x00001D14
		public override void SetValue(ref TContainer container, TValue value)
		{
			bool isReadOnly = this.IsReadOnly;
			if (isReadOnly)
			{
				throw new InvalidOperationException("Property is ReadOnly.");
			}
			this.m_Setter.Invoke(ref container, value);
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_Getter;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_Setter;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PropertyGetter_2_TContainer_TValue_PropertySetter_2_TContainer_TValue_0;
	}
}

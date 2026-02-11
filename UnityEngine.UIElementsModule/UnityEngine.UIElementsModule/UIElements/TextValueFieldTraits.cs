using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008D RID: 141
	public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Token: 0x06000E4F RID: 3663 RVA: 0x0004F7A8 File Offset: 0x0004D9A8
		// Note: this type is marked as 'beforefieldinit'.
		static TextValueFieldTraits()
		{
			Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextValueFieldTraits`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueUxmlAttributeType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr);
			TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, "m_IsReadOnly");
			TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsDelayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, "m_IsDelayed");
			TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, 100665347);
			TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, 100665348);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0004F878 File Offset: 0x0004DA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305952, XrefRangeEnd = 305956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0004F8F0 File Offset: 0x0004DAF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305989, RefRangeEnd = 305990, XrefRangeStart = 305956, XrefRangeEnd = 305989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextValueFieldTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextValueFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000757E File Offset: 0x0000577E
		public TextValueFieldTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0004F92C File Offset: 0x0004DB2C
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00007587 File Offset: 0x00005787
		public unsafe UxmlBoolAttributeDescription m_IsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0004F95C File Offset: 0x0004DB5C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x000075A6 File Offset: 0x000057A6
		public unsafe UxmlBoolAttributeDescription m_IsDelayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsDelayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_IsDelayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDelayed;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

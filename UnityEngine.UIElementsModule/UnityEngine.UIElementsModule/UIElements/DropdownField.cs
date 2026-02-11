using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000057 RID: 87
	public class DropdownField : PopupField<string>
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x000396FC File Offset: 0x000378FC
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownField()
		{
			Il2CppClassPointerStore<DropdownField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownField>.NativeClassPtr);
			DropdownField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownField>.NativeClassPtr, 100664452);
			DropdownField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownField>.NativeClassPtr, 100664453);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00039754 File Offset: 0x00037954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293749, XrefRangeEnd = 293755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00039790 File Offset: 0x00037990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293755, XrefRangeEnd = 293761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00004BFE File Offset: 0x00002DFE
		public DropdownField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200036A RID: 874
		public new class UxmlFactory : UxmlFactory<DropdownField, DropdownField.UxmlTraits>
		{
			// Token: 0x06003773 RID: 14195 RVA: 0x00016E1E File Offset: 0x0001501E
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<DropdownField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropdownField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownField.UxmlFactory>.NativeClassPtr);
				DropdownField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownField.UxmlFactory>.NativeClassPtr, 100664454);
			}

			// Token: 0x06003774 RID: 14196 RVA: 0x000E37A0 File Offset: 0x000E19A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293714, RefRangeEnd = 293715, XrefRangeStart = 293711, XrefRangeEnd = 293714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003775 RID: 14197 RVA: 0x00016E52 File Offset: 0x00015052
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400278C RID: 10124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200036B RID: 875
		public new class UxmlTraits : BaseField<string>.UxmlTraits
		{
			// Token: 0x06003776 RID: 14198 RVA: 0x000E37DC File Offset: 0x000E19DC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropdownField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr);
				DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr, "m_Index");
				DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr, "m_Choices");
				DropdownField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr, 100664455);
				DropdownField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr, 100664456);
			}

			// Token: 0x06003777 RID: 14199 RVA: 0x000E3858 File Offset: 0x000E1A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293715, XrefRangeEnd = 293728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DropdownField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003778 RID: 14200 RVA: 0x000E38D0 File Offset: 0x000E1AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293728, XrefRangeEnd = 293749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003779 RID: 14201 RVA: 0x00016E5B File Offset: 0x0001505B
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x0600377A RID: 14202 RVA: 0x000E390C File Offset: 0x000E1B0C
			// (set) Token: 0x0600377B RID: 14203 RVA: 0x00016E64 File Offset: 0x00015064
			public unsafe UxmlIntAttributeDescription m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Index);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Index), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001128 RID: 4392
			// (get) Token: 0x0600377C RID: 14204 RVA: 0x000E393C File Offset: 0x000E1B3C
			// (set) Token: 0x0600377D RID: 14205 RVA: 0x00016E83 File Offset: 0x00015083
			public unsafe UxmlStringAttributeDescription m_Choices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Choices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownField.UxmlTraits.NativeFieldInfoPtr_m_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400278D RID: 10125
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x0400278E RID: 10126
			private static readonly IntPtr NativeFieldInfoPtr_m_Choices;

			// Token: 0x0400278F RID: 10127
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002790 RID: 10128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

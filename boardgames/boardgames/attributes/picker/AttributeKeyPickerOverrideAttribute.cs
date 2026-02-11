using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.attributes.picker
{
	// Token: 0x02000175 RID: 373
	public class AttributeKeyPickerOverrideAttribute : Attribute
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x0004B0F8 File Offset: 0x000492F8
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeKeyPickerOverrideAttribute()
		{
			Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "AttributeKeyPickerOverrideAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr);
			AttributeKeyPickerOverrideAttribute.NativeFieldInfoPtr_matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr, "matcher");
			AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr, 100666059);
			AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr, 100666060);
			AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr, 100666061);
			AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr, 100666062);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0004B18C File Offset: 0x0004938C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001275, XrefRangeEnd = 1001281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyPickerOverrideAttribute([Optional] Il2CppReferenceArray<Type> valueTypes)
		{
			if (valueTypes == null)
			{
				valueTypes = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0004B1E4 File Offset: 0x000493E4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyPickerOverrideAttribute(AttributeKeyMatcher matcher)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyPickerOverrideAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x0004B230 File Offset: 0x00049430
		public unsafe virtual bool HasMatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0004B26C File Offset: 0x0004946C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Matches(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0000ABFD File Offset: 0x00008DFD
		public AttributeKeyPickerOverrideAttribute(params Type[] valueTypes)
			: this(new Il2CppReferenceArray<Type>(valueTypes))
		{
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public AttributeKeyPickerOverrideAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x0004B2BC File Offset: 0x000494BC
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x0000AC14 File Offset: 0x00008E14
		public unsafe AttributeKeyMatcher matcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyPickerOverrideAttribute.NativeFieldInfoPtr_matcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeKeyMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyPickerOverrideAttribute.NativeFieldInfoPtr_matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeFieldInfoPtr_matcher;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.attributes.picker
{
	// Token: 0x02000174 RID: 372
	public class AttributeKeyPickerAttribute : PropertyAttribute
	{
		// Token: 0x060012C6 RID: 4806 RVA: 0x0004AF04 File Offset: 0x00049104
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeKeyPickerAttribute()
		{
			Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "AttributeKeyPickerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr);
			AttributeKeyPickerAttribute.NativeFieldInfoPtr_matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr, "matcher");
			AttributeKeyPickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr, 100666055);
			AttributeKeyPickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr, 100666056);
			AttributeKeyPickerAttribute.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr, 100666057);
			AttributeKeyPickerAttribute.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr, 100666058);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0004AF98 File Offset: 0x00049198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001268, XrefRangeEnd = 1001274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyPickerAttribute([Optional] Il2CppReferenceArray<Type> valueTypes)
		{
			if (valueTypes == null)
			{
				valueTypes = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0004AFF0 File Offset: 0x000491F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyPickerAttribute(AttributeKeyMatcher matcher)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyPickerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0004B03C File Offset: 0x0004923C
		public unsafe virtual bool HasMatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerAttribute.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0004B078 File Offset: 0x00049278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001274, XrefRangeEnd = 1001275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Matches(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyPickerAttribute.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0000ABC7 File Offset: 0x00008DC7
		public AttributeKeyPickerAttribute(params Type[] valueTypes)
			: this(new Il2CppReferenceArray<Type>(valueTypes))
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000ABD5 File Offset: 0x00008DD5
		public AttributeKeyPickerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0004B0C8 File Offset: 0x000492C8
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0000ABDE File Offset: 0x00008DDE
		public unsafe AttributeKeyMatcher matcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyPickerAttribute.NativeFieldInfoPtr_matcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeKeyMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyPickerAttribute.NativeFieldInfoPtr_matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_matcher;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeKeyMatcher_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0;
	}
}

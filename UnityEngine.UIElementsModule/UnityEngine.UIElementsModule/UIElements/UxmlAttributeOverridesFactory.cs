using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F2 RID: 498
	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x000AD878 File Offset: 0x000ABA78
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlAttributeOverridesFactory()
		{
			Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlAttributeOverridesFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr);
			UxmlAttributeOverridesFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr, 100669222);
			UxmlAttributeOverridesFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr, 100669223);
			UxmlAttributeOverridesFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr, 100669224);
			UxmlAttributeOverridesFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr, 100669225);
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000AD8F8 File Offset: 0x000ABAF8
		public unsafe override string uxmlName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343141, XrefRangeEnd = 343143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlAttributeOverridesFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000AD93C File Offset: 0x000ABB3C
		public unsafe override string uxmlQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343143, XrefRangeEnd = 343146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlAttributeOverridesFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000AD980 File Offset: 0x000ABB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlAttributeOverridesFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000AD9F4 File Offset: 0x000ABBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343146, XrefRangeEnd = 343149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlAttributeOverridesFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlAttributeOverridesFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeOverridesFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0000FFB3 File Offset: 0x0000E1B3
		public UxmlAttributeOverridesFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0000FFCD File Offset: 0x0000E1CD
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0000FFE7 File Offset: 0x0000E1E7
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C0F RID: 7183
		public const string k_ElementName = "AttributeOverrides";
	}
}

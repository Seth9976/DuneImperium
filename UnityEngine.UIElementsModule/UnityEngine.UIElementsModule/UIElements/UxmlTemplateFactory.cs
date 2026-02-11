using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F0 RID: 496
	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
	{
		// Token: 0x06002745 RID: 10053 RVA: 0x000AD574 File Offset: 0x000AB774
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlTemplateFactory()
		{
			Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlTemplateFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr);
			UxmlTemplateFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr, 100669217);
			UxmlTemplateFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr, 100669218);
			UxmlTemplateFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr, 100669219);
			UxmlTemplateFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr, 100669220);
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000AD5F4 File Offset: 0x000AB7F4
		public unsafe override string uxmlName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343110, XrefRangeEnd = 343112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTemplateFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x000AD638 File Offset: 0x000AB838
		public unsafe override string uxmlQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343112, XrefRangeEnd = 343115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTemplateFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000AD67C File Offset: 0x000AB87C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTemplateFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000AD6F0 File Offset: 0x000AB8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343115, XrefRangeEnd = 343118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlTemplateFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlTemplateFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTemplateFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0000FEFB File Offset: 0x0000E0FB
		public UxmlTemplateFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x0000FF04 File Offset: 0x0000E104
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x0000FF15 File Offset: 0x0000E115
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x0000FF2F File Offset: 0x0000E12F
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C06 RID: 7174
		public const string k_ElementName = "Template";
	}
}

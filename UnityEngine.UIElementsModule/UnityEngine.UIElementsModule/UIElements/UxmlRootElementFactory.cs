using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EC RID: 492
	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x000ACFB0 File Offset: 0x000AB1B0
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlRootElementFactory()
		{
			Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlRootElementFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr);
			UxmlRootElementFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr, 100669207);
			UxmlRootElementFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr, 100669208);
			UxmlRootElementFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr, 100669209);
			UxmlRootElementFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr, 100669210);
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000AD030 File Offset: 0x000AB230
		public unsafe override string uxmlName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343055, XrefRangeEnd = 343057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlRootElementFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000AD074 File Offset: 0x000AB274
		public unsafe override string uxmlQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343057, XrefRangeEnd = 343060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlRootElementFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000AD0B8 File Offset: 0x000AB2B8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlRootElementFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000AD12C File Offset: 0x000AB32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343060, XrefRangeEnd = 343063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlRootElementFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlRootElementFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlRootElementFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x0000FDD1 File Offset: 0x0000DFD1
		public UxmlRootElementFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x0000FDDA File Offset: 0x0000DFDA
		public override string substituteForTypeName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x0000FDE1 File Offset: 0x0000DFE1
		public override string substituteForTypeNamespace
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BF5 RID: 7157
		public const string k_ElementName = "UXML";
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EE RID: 494
	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x000AD270 File Offset: 0x000AB470
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlStyleFactory()
		{
			Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlStyleFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr);
			UxmlStyleFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr, 100669212);
			UxmlStyleFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr, 100669213);
			UxmlStyleFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr, 100669214);
			UxmlStyleFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr, 100669215);
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x000AD2F0 File Offset: 0x000AB4F0
		public unsafe override string uxmlName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343079, XrefRangeEnd = 343081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlStyleFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000AD334 File Offset: 0x000AB534
		public unsafe override string uxmlQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343081, XrefRangeEnd = 343084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlStyleFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000AD378 File Offset: 0x000AB578
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlStyleFactory.NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343084, XrefRangeEnd = 343087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlStyleFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlStyleFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStyleFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0000FE43 File Offset: 0x0000E043
		public UxmlStyleFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x0000FE5D File Offset: 0x0000E05D
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x0000FE77 File Offset: 0x0000E077
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BFD RID: 7165
		public const string k_ElementName = "Style";
	}
}

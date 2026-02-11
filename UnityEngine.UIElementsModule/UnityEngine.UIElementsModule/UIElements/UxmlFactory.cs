using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020C RID: 524
	public class UxmlFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits> where TCreatedType : VisualElement, new() where TTraits : UxmlTraits, new()
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x000B0A28 File Offset: 0x000AEC28
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlFactory()
		{
			Il2CppClassPointerStore<UxmlFactory<TCreatedType, TTraits>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCreatedType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTraits>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlFactory<TCreatedType, TTraits>>.NativeClassPtr);
			UxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_Create_Public_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669336);
			UxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669337);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000B0AD0 File Offset: 0x000AECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344087, XrefRangeEnd = 344088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_Create_Public_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000B0B44 File Offset: 0x000AED44
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 344115, RefRangeEnd = 344171, XrefRangeStart = 344088, XrefRangeEnd = 344115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlFactory<TCreatedType, TTraits>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00010358 File Offset: 0x0000E558
		public UxmlFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

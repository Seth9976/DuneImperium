using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020D RID: 525
	public class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits> where TCreatedType : new() where TTraits : UxmlObjectTraits<TCreatedType>, new()
	{
		// Token: 0x0600282B RID: 10283 RVA: 0x000B0B80 File Offset: 0x000AED80
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlObjectFactory()
		{
			Il2CppClassPointerStore<UxmlObjectFactory<TCreatedType, TTraits>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlObjectFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCreatedType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTraits>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlObjectFactory<TCreatedType, TTraits>>.NativeClassPtr);
			UxmlObjectFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_CreateObject_Public_Virtual_New_TCreatedType_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669338);
			UxmlObjectFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669339);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000B0C28 File Offset: 0x000AEE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344171, XrefRangeEnd = 344172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlObjectFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_CreateObject_Public_Virtual_New_TCreatedType_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCreatedType>(intPtr, false, true);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x000B0C94 File Offset: 0x000AEE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344172, XrefRangeEnd = 344194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlObjectFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlObjectFactory<TCreatedType, TTraits>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00010361 File Offset: 0x0000E561
		public UxmlObjectFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Public_Virtual_New_TCreatedType_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

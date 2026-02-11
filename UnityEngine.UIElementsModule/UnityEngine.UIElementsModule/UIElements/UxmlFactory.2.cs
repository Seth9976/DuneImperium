using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020E RID: 526
	public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> where TCreatedType : VisualElement, new()
	{
		// Token: 0x0600282F RID: 10287 RVA: 0x000B0CD0 File Offset: 0x000AEED0
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlFactory()
		{
			Il2CppClassPointerStore<UxmlFactory<TCreatedType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCreatedType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlFactory<TCreatedType>>.NativeClassPtr);
			UxmlFactory<TCreatedType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFactory<TCreatedType>>.NativeClassPtr, 100669340);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000B0D50 File Offset: 0x000AEF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344195, RefRangeEnd = 344196, XrefRangeStart = 344194, XrefRangeEnd = 344195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlFactory<TCreatedType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFactory<TCreatedType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0001036A File Offset: 0x0000E56A
		public UxmlFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

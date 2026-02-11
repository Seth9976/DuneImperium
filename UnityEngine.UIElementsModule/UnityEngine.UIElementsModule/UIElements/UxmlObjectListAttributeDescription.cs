using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000203 RID: 515
	public class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> where T : new()
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x000AFDC0 File Offset: 0x000ADFC0
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlObjectListAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlObjectListAttributeDescription<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlObjectListAttributeDescription`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlObjectListAttributeDescription<T>>.NativeClassPtr);
			UxmlObjectListAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_List_1_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectListAttributeDescription<T>>.NativeClassPtr, 100669317);
			UxmlObjectListAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectListAttributeDescription<T>>.NativeClassPtr, 100669318);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000AFE54 File Offset: 0x000AE054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344013, XrefRangeEnd = 344028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlObjectListAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_List_1_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000AFEC8 File Offset: 0x000AE0C8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlObjectListAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlObjectListAttributeDescription<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectListAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00010273 File Offset: 0x0000E473
		public UxmlObjectListAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_List_1_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

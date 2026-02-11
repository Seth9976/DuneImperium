using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000206 RID: 518
	public class UxmlObjectTraits<T> : BaseUxmlTraits
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x000B0120 File Offset: 0x000AE320
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlObjectTraits()
		{
			Il2CppClassPointerStore<UxmlObjectTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlObjectTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlObjectTraits<T>>.NativeClassPtr);
			UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_byref_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectTraits<T>>.NativeClassPtr, 100669323);
			UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectTraits<T>>.NativeClassPtr, 100669324);
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000B01B4 File Offset: 0x000AE3B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_byref_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000B0244 File Offset: 0x000AE444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344037, XrefRangeEnd = 344038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlObjectTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlObjectTraits<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000102D8 File Offset: 0x0000E4D8
		public UxmlObjectTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_byref_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

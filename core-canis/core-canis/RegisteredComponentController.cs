using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

// Token: 0x02000015 RID: 21
public static class RegisteredComponentController : Object
{
	// Token: 0x06000296 RID: 662 RVA: 0x0001CBEC File Offset: 0x0001ADEC
	// Note: this type is marked as 'beforefieldinit'.
	static RegisteredComponentController()
	{
		Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "RegisteredComponentController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr);
		RegisteredComponentController.NativeFieldInfoPtr__instanceContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, "_instanceContainers");
		RegisteredComponentController.NativeMethodInfoPtr_GetAllOfType_Public_Static_Void_ICollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663646);
		RegisteredComponentController.NativeMethodInfoPtr_GetAllOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663647);
		RegisteredComponentController.NativeMethodInfoPtr_InstanceCountOfType_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663648);
		RegisteredComponentController.NativeMethodInfoPtr__GetInstanceContainer_Private_Static_InstanceContainer_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663649);
		RegisteredComponentController.NativeMethodInfoPtr__RegisterType_Private_Static_Void_IRegisteredComponent_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663650);
		RegisteredComponentController.NativeMethodInfoPtr__Register_Internal_Static_Void_IRegisteredComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663651);
		RegisteredComponentController.NativeMethodInfoPtr__UnregisterType_Internal_Static_Void_IRegisteredComponent_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663652);
		RegisteredComponentController.NativeMethodInfoPtr__Unregister_Internal_Static_Void_IRegisteredComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, 100663653);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0001CCD0 File Offset: 0x0001AED0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853444, RefRangeEnd = 853445, XrefRangeStart = 853412, XrefRangeEnd = 853444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAllOfType<T>(ICollection<T> objs)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.MethodInfoStoreGeneric_GetAllOfType_Public_Static_Void_ICollection_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0001CD08 File Offset: 0x0001AF08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853445, XrefRangeEnd = 853472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetAllOfType(Type type)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr_GetAllOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0001CD4C File Offset: 0x0001AF4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853472, XrefRangeEnd = 853485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InstanceCountOfType<T>()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.MethodInfoStoreGeneric_InstanceCountOfType_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0001CD7C File Offset: 0x0001AF7C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 853504, RefRangeEnd = 853508, XrefRangeStart = 853485, XrefRangeEnd = 853504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegisteredComponentController.InstanceContainer _GetInstanceContainer(Type type)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr__GetInstanceContainer_Private_Static_InstanceContainer_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredComponentController.InstanceContainer>(intPtr3) : null;
		}
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853508, XrefRangeEnd = 853521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _RegisterType(IRegisteredComponent component, Type type)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr__RegisterType_Private_Static_Void_IRegisteredComponent_Type_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0001CE08 File Offset: 0x0001B008
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 853545, RefRangeEnd = 853547, XrefRangeStart = 853521, XrefRangeEnd = 853545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _Register(IRegisteredComponent component)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr__Register_Internal_Static_Void_IRegisteredComponent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0001CE40 File Offset: 0x0001B040
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853547, XrefRangeEnd = 853560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _UnregisterType(IRegisteredComponent component, Type type)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr__UnregisterType_Internal_Static_Void_IRegisteredComponent_Type_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0001CE88 File Offset: 0x0001B088
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853584, RefRangeEnd = 853585, XrefRangeStart = 853560, XrefRangeEnd = 853584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _Unregister(IRegisteredComponent component)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.NativeMethodInfoPtr__Unregister_Internal_Static_Void_IRegisteredComponent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000031B9 File Offset: 0x000013B9
	public RegisteredComponentController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060002A0 RID: 672 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
	// (set) Token: 0x060002A1 RID: 673 RVA: 0x000031C2 File Offset: 0x000013C2
	public unsafe static Dictionary<Type, RegisteredComponentController.InstanceContainer> _instanceContainers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RegisteredComponentController.NativeFieldInfoPtr__instanceContainers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, RegisteredComponentController.InstanceContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RegisteredComponentController.NativeFieldInfoPtr__instanceContainers, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040001E6 RID: 486
	private static readonly IntPtr NativeFieldInfoPtr__instanceContainers;

	// Token: 0x040001E7 RID: 487
	private static readonly IntPtr NativeMethodInfoPtr_GetAllOfType_Public_Static_Void_ICollection_1_T_0;

	// Token: 0x040001E8 RID: 488
	private static readonly IntPtr NativeMethodInfoPtr_GetAllOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

	// Token: 0x040001E9 RID: 489
	private static readonly IntPtr NativeMethodInfoPtr_InstanceCountOfType_Public_Static_Int32_0;

	// Token: 0x040001EA RID: 490
	private static readonly IntPtr NativeMethodInfoPtr__GetInstanceContainer_Private_Static_InstanceContainer_Type_0;

	// Token: 0x040001EB RID: 491
	private static readonly IntPtr NativeMethodInfoPtr__RegisterType_Private_Static_Void_IRegisteredComponent_Type_0;

	// Token: 0x040001EC RID: 492
	private static readonly IntPtr NativeMethodInfoPtr__Register_Internal_Static_Void_IRegisteredComponent_0;

	// Token: 0x040001ED RID: 493
	private static readonly IntPtr NativeMethodInfoPtr__UnregisterType_Internal_Static_Void_IRegisteredComponent_Type_0;

	// Token: 0x040001EE RID: 494
	private static readonly IntPtr NativeMethodInfoPtr__Unregister_Internal_Static_Void_IRegisteredComponent_0;

	// Token: 0x02000235 RID: 565
	public class InstanceContainer : HashSet_Flash<IRegisteredComponent>
	{
		// Token: 0x06001E7C RID: 7804 RVA: 0x0000D0DA File Offset: 0x0000B2DA
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceContainer()
		{
			Il2CppClassPointerStore<RegisteredComponentController.InstanceContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr, "InstanceContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredComponentController.InstanceContainer>.NativeClassPtr);
			RegisteredComponentController.InstanceContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredComponentController.InstanceContainer>.NativeClassPtr, 100663655);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0008B630 File Offset: 0x00089830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853409, XrefRangeEnd = 853412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredComponentController.InstanceContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisteredComponentController.InstanceContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0000D10E File Offset: 0x0000B30E
		public InstanceContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x02000236 RID: 566
	private sealed class MethodInfoStoreGeneric_GetAllOfType_Public_Static_Void_ICollection_1_T_0<T>
	{
		// Token: 0x04001540 RID: 5440
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RegisteredComponentController.NativeMethodInfoPtr_GetAllOfType_Public_Static_Void_ICollection_1_T_0, Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000237 RID: 567
	private sealed class MethodInfoStoreGeneric_InstanceCountOfType_Public_Static_Int32_0<T>
	{
		// Token: 0x04001541 RID: 5441
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RegisteredComponentController.NativeMethodInfoPtr_InstanceCountOfType_Public_Static_Int32_0, Il2CppClassPointerStore<RegisteredComponentController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}

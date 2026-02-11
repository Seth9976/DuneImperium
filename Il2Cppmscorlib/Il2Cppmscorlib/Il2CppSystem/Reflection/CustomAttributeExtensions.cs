using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000439 RID: 1081
	public static class CustomAttributeExtensions : Object
	{
		// Token: 0x06003E23 RID: 15907 RVA: 0x0012A0E4 File Offset: 0x001282E4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeExtensions()
		{
			Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672642);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672643);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672644);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672645);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672646);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672647);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672648);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672649);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672650);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672651);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672652);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672653);
			CustomAttributeExtensions.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100672654);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x0012A218 File Offset: 0x00128418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400053, RefRangeEnd = 1400054, XrefRangeStart = 1400052, XrefRangeEnd = 1400053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x0012A270 File Offset: 0x00128470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400055, RefRangeEnd = 1400058, XrefRangeStart = 1400054, XrefRangeEnd = 1400055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x0012A2C8 File Offset: 0x001284C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1400065, RefRangeEnd = 1400070, XrefRangeStart = 1400058, XrefRangeEnd = 1400065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x0012A308 File Offset: 0x00128508
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1400077, RefRangeEnd = 1400087, XrefRangeStart = 1400070, XrefRangeEnd = 1400077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x0012A348 File Offset: 0x00128548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400088, RefRangeEnd = 1400090, XrefRangeStart = 1400087, XrefRangeEnd = 1400088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x0012A3AC File Offset: 0x001285AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400097, RefRangeEnd = 1400099, XrefRangeStart = 1400090, XrefRangeEnd = 1400097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0012A3F8 File Offset: 0x001285F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400100, RefRangeEnd = 1400101, XrefRangeStart = 1400099, XrefRangeEnd = 1400100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Attribute> GetCustomAttributes(this Assembly element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0012A43C File Offset: 0x0012863C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1400102, RefRangeEnd = 1400106, XrefRangeStart = 1400101, XrefRangeEnd = 1400102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0012A480 File Offset: 0x00128680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400107, RefRangeEnd = 1400108, XrefRangeStart = 1400106, XrefRangeEnd = 1400107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0012A4D8 File Offset: 0x001286D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400109, RefRangeEnd = 1400111, XrefRangeStart = 1400108, XrefRangeEnd = 1400109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0012A530 File Offset: 0x00128730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400118, RefRangeEnd = 1400120, XrefRangeStart = 1400111, XrefRangeEnd = 1400118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> GetCustomAttributes<T>(this Assembly element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttributes_Public_Static_IEnumerable_1_T_Assembly_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0012A574 File Offset: 0x00128774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400127, RefRangeEnd = 1400129, XrefRangeStart = 1400120, XrefRangeEnd = 1400127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttributes_Public_Static_IEnumerable_1_T_MemberInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0012A5B8 File Offset: 0x001287B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1400130, RefRangeEnd = 1400135, XrefRangeStart = 1400129, XrefRangeEnd = 1400130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(this MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00016BA0 File Offset: 0x00014DA0
		public CustomAttributeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_Boolean_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_Assembly_Type_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_Attribute_MemberInfo_Type_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_Assembly_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_MemberInfo_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0;

		// Token: 0x020006B9 RID: 1721
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>
		{
			// Token: 0x04004B3A RID: 19258
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006BA RID: 1722
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_0<T>
		{
			// Token: 0x04004B3B RID: 19259
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006BB RID: 1723
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_MemberInfo_Boolean_0<T>
		{
			// Token: 0x04004B3C RID: 19260
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_MemberInfo_Boolean_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006BC RID: 1724
		private sealed class MethodInfoStoreGeneric_GetCustomAttributes_Public_Static_IEnumerable_1_T_Assembly_0<T>
		{
			// Token: 0x04004B3D RID: 19261
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_Assembly_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020006BD RID: 1725
		private sealed class MethodInfoStoreGeneric_GetCustomAttributes_Public_Static_IEnumerable_1_T_MemberInfo_0<T>
		{
			// Token: 0x04004B3E RID: 19262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IEnumerable_1_T_MemberInfo_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012B RID: 299
	public sealed class Activator : Object
	{
		// Token: 0x060013DD RID: 5085 RVA: 0x000859B8 File Offset: 0x00083BB8
		// Note: this type is marked as 'beforefieldinit'.
		static Activator()
		{
			Il2CppClassPointerStore<Activator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Activator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Activator>.NativeClassPtr);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666806);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666807);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666808);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666809);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666810);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666811);
			Activator.NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666812);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100666813);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00085A88 File Offset: 0x00083C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338245, RefRangeEnd = 1338247, XrefRangeStart = 1338244, XrefRangeEnd = 1338245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00085B14 File Offset: 0x00083D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338253, RefRangeEnd = 1338256, XrefRangeStart = 1338247, XrefRangeEnd = 1338253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00085BB0 File Offset: 0x00083DB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1338257, RefRangeEnd = 1338262, XrefRangeStart = 1338256, XrefRangeEnd = 1338257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00085C14 File Offset: 0x00083E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338263, RefRangeEnd = 1338264, XrefRangeStart = 1338262, XrefRangeEnd = 1338263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00085C7C File Offset: 0x00083E7C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1338265, RefRangeEnd = 1338292, XrefRangeStart = 1338264, XrefRangeEnd = 1338265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00085CC0 File Offset: 0x00083EC0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1338293, RefRangeEnd = 1338307, XrefRangeStart = 1338292, XrefRangeEnd = 1338293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00085D14 File Offset: 0x00083F14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338313, RefRangeEnd = 1338316, XrefRangeStart = 1338307, XrefRangeEnd = 1338313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00085D74 File Offset: 0x00083F74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338328, RefRangeEnd = 1338331, XrefRangeStart = 1338316, XrefRangeEnd = 1338328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000065D5 File Offset: 0x000047D5
		public static Object CreateInstance(Type type, params Object[] args)
		{
			return Activator.CreateInstance(type, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000065E3 File Offset: 0x000047E3
		public Activator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Internal_Static_Object_Type_Boolean_Boolean_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x020005E4 RID: 1508
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x040047A2 RID: 18338
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<Activator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

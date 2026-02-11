using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Internal
{
	// Token: 0x0200002F RID: 47
	public static class ParameterDefaultValue : Object
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000BD68 File Offset: 0x00009F68
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterDefaultValue()
		{
			Il2CppClassPointerStore<ParameterDefaultValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.Internal", "ParameterDefaultValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterDefaultValue>.NativeClassPtr);
			ParameterDefaultValue.NativeMethodInfoPtr_CheckHasDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDefaultValue>.NativeClassPtr, 100663634);
			ParameterDefaultValue.NativeMethodInfoPtr_TryGetDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDefaultValue>.NativeClassPtr, 100663635);
			ParameterDefaultValue.NativeMethodInfoPtr_Method_Internal_Static_Object_Type_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDefaultValue>.NativeClassPtr, 100663636);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205638, RefRangeEnd = 1205639, XrefRangeStart = 1205630, XrefRangeEnd = 1205638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckHasDefaultValue(ParameterInfo parameter, out bool tryToGetDefaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tryToGetDefaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDefaultValue.NativeMethodInfoPtr_CheckHasDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000BE24 File Offset: 0x0000A024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205662, RefRangeEnd = 1205663, XrefRangeStart = 1205639, XrefRangeEnd = 1205662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetDefaultValue(ParameterInfo parameter, out Object defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParameterDefaultValue.NativeMethodInfoPtr_TryGetDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			defaultValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000BE88 File Offset: 0x0000A088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205663, XrefRangeEnd = 1205664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Method_Internal_Static_Object_Type_PDM_0(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDefaultValue.NativeMethodInfoPtr_Method_Internal_Static_Object_Type_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002C78 File Offset: 0x00000E78
		public ParameterDefaultValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_CheckHasDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Boolean_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_TryGetDefaultValue_Public_Static_Boolean_ParameterInfo_byref_Object_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Object_Type_PDM_0;
	}
}

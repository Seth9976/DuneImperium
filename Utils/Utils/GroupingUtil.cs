using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;

namespace Utils
{
	// Token: 0x02000030 RID: 48
	public static class GroupingUtil : Object
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x000028F2 File Offset: 0x00000AF2
		// Note: this type is marked as 'beforefieldinit'.
		static GroupingUtil()
		{
			Il2CppClassPointerStore<GroupingUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "GroupingUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupingUtil>.NativeClassPtr);
			GroupingUtil.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_IGrouping_2_S_T_byref_S_byref_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupingUtil>.NativeClassPtr, 100663579);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000BDCC File Offset: 0x00009FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181608, XrefRangeEnd = 1181613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deconstruct<S, T>(this IGrouping<S, T> grouping, out S fst, out IEnumerable<T> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(grouping);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(S).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref fst;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr3 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(GroupingUtil.MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_IGrouping_2_S_T_byref_S_byref_IEnumerable_1_T_0<S, T>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(S).IsValueType)
			{
				IntPtr intPtr6 = intPtr;
				fst = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<S>(intPtr6, false, false));
			}
			IntPtr intPtr7 = intPtr3;
			snd = ((intPtr7 == 0) ? null : new IEnumerable<T>(intPtr7));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000292B File Offset: 0x00000B2B
		public GroupingUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Static_Void_IGrouping_2_S_T_byref_S_byref_IEnumerable_1_T_0;

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_IGrouping_2_S_T_byref_S_byref_IEnumerable_1_T_0<S, T>
		{
			// Token: 0x040001EF RID: 495
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GroupingUtil.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_IGrouping_2_S_T_byref_S_byref_IEnumerable_1_T_0, Il2CppClassPointerStore<GroupingUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}

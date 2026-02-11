using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000061 RID: 97
	public sealed class Action<T1, T2, T3, T4, T5, T6, T7> : MulticastDelegate
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr))
			})).TypeHandle.value);
			Action<T1, T2, T3, T4, T5, T6, T7>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7>>.NativeClassPtr, 100664293);
			Action<T1, T2, T3, T4, T5, T6, T7>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7>>.NativeClassPtr, 100664294);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0003F7B8 File Offset: 0x0003D9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296766, XrefRangeEnd = 1296775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3, T4, T5, T6, T7>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2, T3, T4, T5, T6, T7>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0003F814 File Offset: 0x0003DA14
		[CallerCount(0)]
		public unsafe void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = arg1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = arg4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = arg5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg5;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T6).IsValueType)
			{
				T6 t6 = arg6;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg6;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T7).IsValueType)
			{
				T7 t7 = arg7;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg7;
			}
			ptr8 = intPtr7;
			IntPtr intPtr9;
			IntPtr intPtr8 = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2, T3, T4, T5, T6, T7>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr9);
			Il2CppException.RaiseExceptionIfNecessary(intPtr9);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00003C3B File Offset: 0x00001E3B
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00003C44 File Offset: 0x00001E44
		public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> A_0)
		{
			return DelegateSupport.ConvertDelegate<Action<T1, T2, T3, T4, T5, T6, T7>>(A_0);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00003C4C File Offset: 0x00001E4C
		public static Action<T1, T2, T3, T4, T5, T6, T7>operator +(Action<T1, T2, T3, T4, T5, T6, T7> A_0, Action<T1, T2, T3, T4, T5, T6, T7> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action<T1, T2, T3, T4, T5, T6, T7>>();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00003C5A File Offset: 0x00001E5A
		public static Action<T1, T2, T3, T4, T5, T6, T7>operator -(Action<T1, T2, T3, T4, T5, T6, T7> A_0, Action<T1, T2, T3, T4, T5, T6, T7> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action<T1, T2, T3, T4, T5, T6, T7>>();
			}
			return delegate2;
		}

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_T5_T6_T7_0;
	}
}

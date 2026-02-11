using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200005B RID: 91
	public sealed class Action<T> : MulticastDelegate
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x0003E934 File Offset: 0x0003CB34
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			Action<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664281);
			Action<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664282);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		[CallerCount(0)]
		public unsafe void Invoke(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Action<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003B1B File Offset: 0x00001D1B
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003B24 File Offset: 0x00001D24
		public static implicit operator Action<T>(Action<T> A_0)
		{
			return DelegateSupport.ConvertDelegate<Action<T>>(A_0);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003B2C File Offset: 0x00001D2C
		public static Action<T>operator +(Action<T> A_0, Action<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action<T>>();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00003B3A File Offset: 0x00001D3A
		public static Action<T>operator -(Action<T> A_0, Action<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action<T>>();
			}
			return delegate2;
		}

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;
	}
}

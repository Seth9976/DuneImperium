using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001B1 RID: 433
	public sealed class UnityAction<T0> : MulticastDelegate
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x0008DF20 File Offset: 0x0008C120
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) })).TypeHandle.value);
			UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100667645);
			UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100667646);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0008DFAC File Offset: 0x0008C1AC
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 679310, RefRangeEnd = 679355, XrefRangeStart = 679307, XrefRangeEnd = 679310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0008E008 File Offset: 0x0008C208
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0000C10E File Offset: 0x0000A30E
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0000C117 File Offset: 0x0000A317
		public static implicit operator UnityAction<T0>(Action<T0> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0>>(A_0);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0000C11F File Offset: 0x0000A31F
		public static UnityAction<T0>operator +(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0>>();
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0000C12D File Offset: 0x0000A32D
		public static UnityAction<T0>operator -(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction<T0>>();
			}
			return delegate2;
		}

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0;
	}
}

using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000CA RID: 202
	public sealed class Transition<TActiveAbility> : MulticastDelegate where TActiveAbility : ActiveAbility
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		// Note: this type is marked as 'beforefieldinit'.
		static Transition()
		{
			Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "Transition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)) })).TypeHandle.value);
			Transition<TActiveAbility>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr, 100665199);
			Transition<TActiveAbility>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr, 100665200);
			Transition<TActiveAbility>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_Action_Context_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr, 100665201);
			Transition<TActiveAbility>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr, 100665202);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 562059, RefRangeEnd = 562064, XrefRangeStart = 562050, XrefRangeEnd = 562059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transition(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transition<TActiveAbility>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transition<TActiveAbility>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003F800 File Offset: 0x0003DA00
		[CallerCount(0)]
		public unsafe int Invoke(TActiveAbility activeAbility, Canis.actions.Action lastAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Transition<TActiveAbility>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_TActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0003F8A8 File Offset: 0x0003DAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(TActiveAbility activeAbility, Canis.actions.Action lastAction, Context context, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Transition<TActiveAbility>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_Action_Context_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0003F978 File Offset: 0x0003DB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transition<TActiveAbility>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00005856 File Offset: 0x00003A56
		public Transition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000585F File Offset: 0x00003A5F
		public static implicit operator Transition<TActiveAbility>(Func<TActiveAbility, Canis.actions.Action, Context, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<Transition<TActiveAbility>>(A_0);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00005867 File Offset: 0x00003A67
		public static Transition<TActiveAbility>operator +(Transition<TActiveAbility> A_0, Transition<TActiveAbility> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Transition<TActiveAbility>>();
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00005875 File Offset: 0x00003A75
		public static Transition<TActiveAbility>operator -(Transition<TActiveAbility> A_0, Transition<TActiveAbility> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Transition<TActiveAbility>>();
			}
			return delegate2;
		}

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_TActiveAbility_Action_Context_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_Action_Context_AsyncCallback_Object_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
	}
}

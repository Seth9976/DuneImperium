using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CF RID: 207
	public sealed class EventCallback<TEventType> : MulticastDelegate
	{
		// Token: 0x06001275 RID: 4725 RVA: 0x0005DD3C File Offset: 0x0005BF3C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallback()
		{
			Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallback`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) })).TypeHandle.value);
			EventCallback<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr, 100665928);
			EventCallback<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr, 100665929);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0005DDC8 File Offset: 0x0005BFC8
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312867, XrefRangeEnd = 312876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0005DE24 File Offset: 0x0005C024
		[CallerCount(0)]
		public unsafe void Invoke(TEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TEventType).IsValueType)
				{
					TEventType teventType = evt;
					intPtr = ((teventType is string) ? IL2CPP.ManagedStringToIl2Cpp(teventType as string) : IL2CPP.Il2CppObjectBaseToPtr(teventType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref evt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00009210 File Offset: 0x00007410
		public EventCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00009219 File Offset: 0x00007419
		public static implicit operator EventCallback<TEventType>(Action<TEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventCallback<TEventType>>(A_0);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00009221 File Offset: 0x00007421
		public static EventCallback<TEventType>operator +(EventCallback<TEventType> A_0, EventCallback<TEventType> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventCallback<TEventType>>();
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000922F File Offset: 0x0000742F
		public static EventCallback<TEventType>operator -(EventCallback<TEventType> A_0, EventCallback<TEventType> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventCallback<TEventType>>();
			}
			return delegate2;
		}

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0;
	}
}

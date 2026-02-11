using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D0 RID: 208
	public sealed class EventCallback<TEventType, TCallbackArgs> : MulticastDelegate
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x0005DE9C File Offset: 0x0005C09C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallback()
		{
			Il2CppClassPointerStore<EventCallback<TEventType, TCallbackArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallback`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackArgs>.NativeClassPtr))
			})).TypeHandle.value);
			EventCallback<TEventType, TCallbackArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType, TCallbackArgs>>.NativeClassPtr, 100665930);
			EventCallback<TEventType, TCallbackArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_TCallbackArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType, TCallbackArgs>>.NativeClassPtr, 100665931);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0005DF38 File Offset: 0x0005C138
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 313218, RefRangeEnd = 313223, XrefRangeStart = 313209, XrefRangeEnd = 313218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallback<TEventType, TCallbackArgs>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType, TCallbackArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0005DF94 File Offset: 0x0005C194
		[CallerCount(0)]
		public unsafe void Invoke(TEventType evt, TCallbackArgs userArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TCallbackArgs).IsValueType)
			{
				TCallbackArgs tcallbackArgs = userArgs;
				intPtr2 = ((tcallbackArgs is string) ? IL2CPP.ManagedStringToIl2Cpp(tcallbackArgs as string) : IL2CPP.Il2CppObjectBaseToPtr(tcallbackArgs as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref userArgs;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType, TCallbackArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_TCallbackArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00009240 File Offset: 0x00007440
		public EventCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00009249 File Offset: 0x00007449
		public static implicit operator EventCallback<TEventType, TCallbackArgs>(Action<TEventType, TCallbackArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventCallback<TEventType, TCallbackArgs>>(A_0);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00009251 File Offset: 0x00007451
		public static EventCallback<TEventType, TCallbackArgs>operator +(EventCallback<TEventType, TCallbackArgs> A_0, EventCallback<TEventType, TCallbackArgs> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventCallback<TEventType, TCallbackArgs>>();
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0000925F File Offset: 0x0000745F
		public static EventCallback<TEventType, TCallbackArgs>operator -(EventCallback<TEventType, TCallbackArgs> A_0, EventCallback<TEventType, TCallbackArgs> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventCallback<TEventType, TCallbackArgs>>();
			}
			return delegate2;
		}

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_TCallbackArgs_0;
	}
}

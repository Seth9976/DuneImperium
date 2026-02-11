using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000090 RID: 144
	public sealed class EventHandler<TEventArgs> : MulticastDelegate
	{
		// Token: 0x06000A02 RID: 2562 RVA: 0x000531B4 File Offset: 0x000513B4
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandler()
		{
			Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventArgs>.NativeClassPtr)) })).TypeHandle.value);
			EventHandler<TEventArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100665048);
			EventHandler<TEventArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100665049);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00053240 File Offset: 0x00051440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1304605, RefRangeEnd = 1304608, XrefRangeStart = 1304596, XrefRangeEnd = 1304605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler<TEventArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0005329C File Offset: 0x0005149C
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, TEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TEventArgs).IsValueType)
			{
				TEventArgs teventArgs = e;
				intPtr = ((teventArgs is string) ? IL2CPP.ManagedStringToIl2Cpp(teventArgs as string) : IL2CPP.Il2CppObjectBaseToPtr(teventArgs as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref e;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventHandler<TEventArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00004753 File Offset: 0x00002953
		public EventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0000475C File Offset: 0x0000295C
		public static implicit operator EventHandler<TEventArgs>(Action<Object, TEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventHandler<TEventArgs>>(A_0);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00004764 File Offset: 0x00002964
		public static EventHandler<TEventArgs>operator +(EventHandler<TEventArgs> A_0, EventHandler<TEventArgs> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventHandler<TEventArgs>>();
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00004772 File Offset: 0x00002972
		public static EventHandler<TEventArgs>operator -(EventHandler<TEventArgs> A_0, EventHandler<TEventArgs> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventHandler<TEventArgs>>();
			}
			return delegate2;
		}

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0;
	}
}

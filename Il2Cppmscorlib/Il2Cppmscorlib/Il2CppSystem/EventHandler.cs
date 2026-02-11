using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008F RID: 143
	public sealed class EventHandler : MulticastDelegate
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x000530B4 File Offset: 0x000512B4
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandler()
		{
			Il2CppClassPointerStore<EventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler");
			EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100665046);
			EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100665047);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00053104 File Offset: 0x00051304
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00053160 File Offset: 0x00051360
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00004723 File Offset: 0x00002923
		public EventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000472C File Offset: 0x0000292C
		public static implicit operator EventHandler(Action<Object, EventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventHandler>(A_0);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00004734 File Offset: 0x00002934
		public static EventHandler operator +(EventHandler A_0, EventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventHandler>();
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00004742 File Offset: 0x00002942
		public static EventHandler operator -(EventHandler A_0, EventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
	}
}

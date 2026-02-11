using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005A RID: 90
	public sealed class Action : MulticastDelegate
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x0003E854 File Offset: 0x0003CA54
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action");
			Action.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664279);
			Action.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664280);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0003E900 File Offset: 0x0003CB00
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00003AEB File Offset: 0x00001CEB
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public static implicit operator Action(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<Action>(A_0);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003AFC File Offset: 0x00001CFC
		public static Action operator +(Action A_0, Action A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action>();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003B0A File Offset: 0x00001D0A
		public static Action operator -(Action A_0, Action A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action>();
			}
			return delegate2;
		}

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}

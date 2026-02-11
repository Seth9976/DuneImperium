using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001AF RID: 431
	public sealed class UnityAction : MulticastDelegate
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x0008DB24 File Offset: 0x0008BD24
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction");
			UnityAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction>.NativeClassPtr, 100667636);
			UnityAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction>.NativeClassPtr, 100667637);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0008DB74 File Offset: 0x0008BD74
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0008DBD0 File Offset: 0x0008BDD0
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0000C0B6 File Offset: 0x0000A2B6
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0000C0BF File Offset: 0x0000A2BF
		public static implicit operator UnityAction(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction>(A_0);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
		public static UnityAction operator +(UnityAction A_0, UnityAction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction>();
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0000C0D5 File Offset: 0x0000A2D5
		public static UnityAction operator -(UnityAction A_0, UnityAction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction>();
			}
			return delegate2;
		}

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}

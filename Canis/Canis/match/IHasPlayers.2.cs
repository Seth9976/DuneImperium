using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.match
{
	// Token: 0x02000093 RID: 147
	public class IHasPlayers<TPlayer> : Il2CppObjectBase where TPlayer : PlayerEntity
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x00037F04 File Offset: 0x00036104
		// Note: this type is marked as 'beforefieldinit'.
		static IHasPlayers()
		{
			Il2CppClassPointerStore<IHasPlayers<TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IHasPlayers`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr)) })).TypeHandle.value);
			IHasPlayers<TPlayer>.NativeMethodInfoPtr_get_PlayersEnumerable_Public_Abstract_Virtual_New_get_IEnumerable_1_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasPlayers<TPlayer>>.NativeClassPtr, 100664843);
			IHasPlayers<TPlayer>.NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Abstract_Virtual_New_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasPlayers<TPlayer>>.NativeClassPtr, 100664844);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00037F90 File Offset: 0x00036190
		public unsafe virtual IEnumerable<TPlayer> PlayersEnumerable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasPlayers<TPlayer>.NativeMethodInfoPtr_get_PlayersEnumerable_Public_Abstract_Virtual_New_get_IEnumerable_1_TPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00037FDC File Offset: 0x000361DC
		[CallerCount(0)]
		public unsafe virtual bool ShouldNotifyPlayer(AccountID playerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasPlayers<TPlayer>.NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Abstract_Virtual_New_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00004DFC File Offset: 0x00002FFC
		public IHasPlayers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersEnumerable_Public_Abstract_Virtual_New_get_IEnumerable_1_TPlayer_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Abstract_Virtual_New_Boolean_AccountID_0;
	}
}

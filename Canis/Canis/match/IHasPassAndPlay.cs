using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.match
{
	// Token: 0x02000091 RID: 145
	public class IHasPassAndPlay<TPlayer> : Il2CppObjectBase where TPlayer : PlayerEntity
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x00037DF8 File Offset: 0x00035FF8
		// Note: this type is marked as 'beforefieldinit'.
		static IHasPassAndPlay()
		{
			Il2CppClassPointerStore<IHasPassAndPlay<TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IHasPassAndPlay`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr)) })).TypeHandle.value);
			IHasPassAndPlay<TPlayer>.NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasPassAndPlay<TPlayer>>.NativeClassPtr, 100664842);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00037E70 File Offset: 0x00036070
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action passToPlayerAction(TPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPlayer).IsValueType)
				{
					TPlayer tplayer = player;
					intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref player;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasPassAndPlay<TPlayer>.NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_TPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr4) : null;
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00004DCF File Offset: 0x00002FCF
		public IHasPassAndPlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_TPlayer_0;
	}
}

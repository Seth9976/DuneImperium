using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace Canis.match
{
	// Token: 0x0200008E RID: 142
	public class ICanSetCleanupGame<TGameResults, TGameResultsEntry> : Il2CppObjectBase
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x00037C20 File Offset: 0x00035E20
		// Note: this type is marked as 'beforefieldinit'.
		static ICanSetCleanupGame()
		{
			Il2CppClassPointerStore<ICanSetCleanupGame<TGameResults, TGameResultsEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "ICanSetCleanupGame`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResults>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResultsEntry>.NativeClassPtr))
			})).TypeHandle.value);
			ICanSetCleanupGame<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr_SetCleanupGame_Public_Abstract_Virtual_New_Void_Func_3_List_1_AccountID_TGameResults_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanSetCleanupGame<TGameResults, TGameResultsEntry>>.NativeClassPtr, 100664839);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00037CA8 File Offset: 0x00035EA8
		[CallerCount(0)]
		public unsafe virtual void SetCleanupGame(Func<List<AccountID>, TGameResults, Task> cleanup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleanup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanSetCleanupGame<TGameResults, TGameResultsEntry>.NativeMethodInfoPtr_SetCleanupGame_Public_Abstract_Virtual_New_Void_Func_3_List_1_AccountID_TGameResults_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00004D85 File Offset: 0x00002F85
		public ICanSetCleanupGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_SetCleanupGame_Public_Abstract_Virtual_New_Void_Func_3_List_1_AccountID_TGameResults_Task_0;
	}
}

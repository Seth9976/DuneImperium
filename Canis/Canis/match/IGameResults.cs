using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.match
{
	// Token: 0x0200008F RID: 143
	public class IGameResults<TGameResultsEntry> : Il2CppObjectBase
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00037CF8 File Offset: 0x00035EF8
		// Note: this type is marked as 'beforefieldinit'.
		static IGameResults()
		{
			Il2CppClassPointerStore<IGameResults<TGameResultsEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IGameResults`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResultsEntry>.NativeClassPtr)) })).TypeHandle.value);
			IGameResults<TGameResultsEntry>.NativeMethodInfoPtr_get_entries_Public_Abstract_Virtual_New_get_Il2CppArrayBase_1_TGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameResults<TGameResultsEntry>>.NativeClassPtr, 100664840);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00037D70 File Offset: 0x00035F70
		public unsafe virtual Il2CppArrayBase<TGameResultsEntry> entries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGameResults<TGameResultsEntry>.NativeMethodInfoPtr_get_entries_Public_Abstract_Virtual_New_get_Il2CppArrayBase_1_TGameResultsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TGameResultsEntry>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004D8E File Offset: 0x00002F8E
		public IGameResults(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_entries_Public_Abstract_Virtual_New_get_Il2CppArrayBase_1_TGameResultsEntry_0;
	}
}

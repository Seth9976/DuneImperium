using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.match
{
	// Token: 0x02000090 RID: 144
	public class IGameResultsEntry : Il2CppObjectBase
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00004D97 File Offset: 0x00002F97
		// Note: this type is marked as 'beforefieldinit'.
		static IGameResultsEntry()
		{
			Il2CppClassPointerStore<IGameResultsEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IGameResultsEntry");
			IGameResultsEntry.NativeMethodInfoPtr_get_key_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameResultsEntry>.NativeClassPtr, 100664841);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00037DB4 File Offset: 0x00035FB4
		public unsafe virtual string key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGameResultsEntry.NativeMethodInfoPtr_get_key_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00004DC6 File Offset: 0x00002FC6
		public IGameResultsEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_get_key_Public_Abstract_Virtual_New_get_String_0;
	}
}

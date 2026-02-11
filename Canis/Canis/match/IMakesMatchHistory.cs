using System;
using canis.Networking.game.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.match
{
	// Token: 0x02000095 RID: 149
	public class IMakesMatchHistory : Il2CppObjectBase
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x00004E3D File Offset: 0x0000303D
		// Note: this type is marked as 'beforefieldinit'.
		static IMakesMatchHistory()
		{
			Il2CppClassPointerStore<IMakesMatchHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IMakesMatchHistory");
			IMakesMatchHistory.NativeMethodInfoPtr_MakeMatchHistory_Public_Abstract_Virtual_New_MatchHistoryEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMakesMatchHistory>.NativeClassPtr, 100664846);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00038090 File Offset: 0x00036290
		[CallerCount(0)]
		public unsafe virtual MatchHistoryEntry MakeMatchHistory(string client)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMakesMatchHistory.NativeMethodInfoPtr_MakeMatchHistory_Public_Abstract_Virtual_New_MatchHistoryEntry_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchHistoryEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00004E6C File Offset: 0x0000306C
		public IMakesMatchHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_MakeMatchHistory_Public_Abstract_Virtual_New_MatchHistoryEntry_String_0;
	}
}

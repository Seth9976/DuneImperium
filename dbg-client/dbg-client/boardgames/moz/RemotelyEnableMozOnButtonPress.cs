using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000120 RID: 288
	public class RemotelyEnableMozOnButtonPress : MonoBehaviour
	{
		// Token: 0x06000CE9 RID: 3305 RVA: 0x00046438 File Offset: 0x00044638
		// Note: this type is marked as 'beforefieldinit'.
		static RemotelyEnableMozOnButtonPress()
		{
			Il2CppClassPointerStore<RemotelyEnableMozOnButtonPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "RemotelyEnableMozOnButtonPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotelyEnableMozOnButtonPress>.NativeClassPtr);
			RemotelyEnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotelyEnableMozOnButtonPress>.NativeClassPtr, 100665169);
			RemotelyEnableMozOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotelyEnableMozOnButtonPress>.NativeClassPtr, 100665170);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00046490 File Offset: 0x00044690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510278, XrefRangeEnd = 510282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMozSelectedObjectOnButtonPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotelyEnableMozOnButtonPress.NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000464C4 File Offset: 0x000446C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotelyEnableMozOnButtonPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotelyEnableMozOnButtonPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotelyEnableMozOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0000845F File Offset: 0x0000665F
		public RemotelyEnableMozOnButtonPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMozSelectedObjectOnButtonPress_Public_Void_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

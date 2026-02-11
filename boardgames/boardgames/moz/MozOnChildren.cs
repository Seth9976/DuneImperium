using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000117 RID: 279
	public class MozOnChildren : MonoBehaviour
	{
		// Token: 0x06000EA2 RID: 3746 RVA: 0x00008D8F File Offset: 0x00006F8F
		// Note: this type is marked as 'beforefieldinit'.
		static MozOnChildren()
		{
			Il2CppClassPointerStore<MozOnChildren>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.moz", "MozOnChildren");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozOnChildren>.NativeClassPtr);
			MozOnChildren.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozOnChildren>.NativeClassPtr, 100665384);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003D7B0 File Offset: 0x0003B9B0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozOnChildren()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozOnChildren>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozOnChildren.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public MozOnChildren(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

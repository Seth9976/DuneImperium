using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006D RID: 109
	public class NextGameProvider : MonoBehaviour
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00023044 File Offset: 0x00021244
		// Note: this type is marked as 'beforefieldinit'.
		static NextGameProvider()
		{
			Il2CppClassPointerStore<NextGameProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "NextGameProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextGameProvider>.NativeClassPtr);
			NextGameProvider.NativeFieldInfoPtr_previouslyVisitedGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameProvider>.NativeClassPtr, "previouslyVisitedGames");
			NextGameProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameProvider>.NativeClassPtr, 100664229);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0002309C File Offset: 0x0002129C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988180, XrefRangeEnd = 988188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NextGameProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextGameProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004ABE File Offset: 0x00002CBE
		public NextGameProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000230D8 File Offset: 0x000212D8
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00004AC7 File Offset: 0x00002CC7
		public unsafe List<GameID> previouslyVisitedGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameProvider.NativeFieldInfoPtr_previouslyVisitedGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameProvider.NativeFieldInfoPtr_previouslyVisitedGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_previouslyVisitedGames;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

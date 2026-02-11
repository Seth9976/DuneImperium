using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x02000113 RID: 275
	public class FindMozObject : MonoBehaviour
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x00044EBC File Offset: 0x000430BC
		// Note: this type is marked as 'beforefieldinit'.
		static FindMozObject()
		{
			Il2CppClassPointerStore<FindMozObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "FindMozObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindMozObject>.NativeClassPtr);
			FindMozObject.NativeMethodInfoPtr_get_Moz_Public_Abstract_Virtual_New_get_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindMozObject>.NativeClassPtr, 100665117);
			FindMozObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindMozObject>.NativeClassPtr, 100665118);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00044F14 File Offset: 0x00043114
		public unsafe virtual BaseMoz Moz
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FindMozObject.NativeMethodInfoPtr_get_Moz_Public_Abstract_Virtual_New_get_BaseMoz_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr3) : null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00044F60 File Offset: 0x00043160
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FindMozObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindMozObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FindMozObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0000809A File Offset: 0x0000629A
		public FindMozObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_Moz_Public_Abstract_Virtual_New_get_BaseMoz_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

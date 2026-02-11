using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.staged
{
	// Token: 0x0200020E RID: 526
	public class Staging : Object
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00072AF8 File Offset: 0x00070CF8
		// Note: this type is marked as 'beforefieldinit'.
		static Staging()
		{
			Il2CppClassPointerStore<Staging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "Staging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Staging>.NativeClassPtr);
			Staging.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Staging>.NativeClassPtr, 100668370);
			Staging.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Staging>.NativeClassPtr, 100668371);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00072B50 File Offset: 0x00070D50
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Apply(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Staging.NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00072BAC File Offset: 0x00070DAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Staging()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Staging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Staging.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000AB62 File Offset: 0x00008D62
		public Staging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

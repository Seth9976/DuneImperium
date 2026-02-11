using System;
using dwd.core.match.sequence;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.delorean
{
	// Token: 0x020000A1 RID: 161
	public class ISequenceBlockage : Il2CppObjectBase
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00005781 File Offset: 0x00003981
		// Note: this type is marked as 'beforefieldinit'.
		static ISequenceBlockage()
		{
			Il2CppClassPointerStore<ISequenceBlockage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.delorean", "ISequenceBlockage");
			ISequenceBlockage.NativeMethodInfoPtr_IsBlocker_Public_Abstract_Virtual_New_Boolean_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceBlockage>.NativeClassPtr, 100664526);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002958C File Offset: 0x0002778C
		[CallerCount(0)]
		public unsafe virtual bool IsBlocker(SequenceElement sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISequenceBlockage.NativeMethodInfoPtr_IsBlocker_Public_Abstract_Virtual_New_Boolean_SequenceElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000057B0 File Offset: 0x000039B0
		public ISequenceBlockage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_IsBlocker_Public_Abstract_Virtual_New_Boolean_SequenceElement_0;
	}
}

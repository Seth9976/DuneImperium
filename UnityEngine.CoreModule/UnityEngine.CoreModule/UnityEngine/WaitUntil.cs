using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200015E RID: 350
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x060019F5 RID: 6645 RVA: 0x0007A278 File Offset: 0x00078478
		// Note: this type is marked as 'beforefieldinit'.
		static WaitUntil()
		{
			Il2CppClassPointerStore<WaitUntil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitUntil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr);
			WaitUntil.NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_Predicate");
			WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666913);
			WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666914);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0007A2E4 File Offset: 0x000784E4
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0007A320 File Offset: 0x00078520
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitUntil(Func<bool> predicate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0000A004 File Offset: 0x00008204
		public WaitUntil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0007A36C File Offset: 0x0007856C
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0000A00D File Offset: 0x0000820D
		public unsafe Func<bool> m_Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_m_Predicate;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200015F RID: 351
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x0007A39C File Offset: 0x0007859C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitWhile()
		{
			Il2CppClassPointerStore<WaitWhile>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitWhile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitWhile>.NativeClassPtr);
			WaitWhile.NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitWhile>.NativeClassPtr, "m_Predicate");
			WaitWhile.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitWhile>.NativeClassPtr, 100666915);
			WaitWhile.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitWhile>.NativeClassPtr, 100666916);
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0007A408 File Offset: 0x00078608
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673080, XrefRangeEnd = 673081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitWhile.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0007A444 File Offset: 0x00078644
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitWhile(Func<bool> predicate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitWhile>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitWhile.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0000A02C File Offset: 0x0000822C
		public WaitWhile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0007A490 File Offset: 0x00078690
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0000A035 File Offset: 0x00008235
		public unsafe Func<bool> m_Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitWhile.NativeFieldInfoPtr_m_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitWhile.NativeFieldInfoPtr_m_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_m_Predicate;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;
	}
}

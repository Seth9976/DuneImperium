using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000136 RID: 310
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x000718B0 File Offset: 0x0006FAB0
		// Note: this type is marked as 'beforefieldinit'.
		static Coroutine()
		{
			Il2CppClassPointerStore<Coroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Coroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine>.NativeClassPtr);
			Coroutine.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "m_Ptr");
			Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100666578);
			Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100666579);
			Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100666580);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00071930 File Offset: 0x0006FB30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0007196C File Offset: 0x0006FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664290, XrefRangeEnd = 664295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000719A0 File Offset: 0x0006FBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664295, XrefRangeEnd = 664354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCoroutine(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000098A5 File Offset: 0x00007AA5
		public Coroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000719D4 File Offset: 0x0006FBD4
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x000098AE File Offset: 0x00007AAE
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0;
	}
}

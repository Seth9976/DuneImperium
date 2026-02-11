using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace boardgames.dataRenderers
{
	// Token: 0x02000142 RID: 322
	public class ChallengeProgressionStatusRenderer : ProgressionStatusRenderer
	{
		// Token: 0x06000EC7 RID: 3783 RVA: 0x0004CB78 File Offset: 0x0004AD78
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeProgressionStatusRenderer()
		{
			Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "ChallengeProgressionStatusRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr);
			ChallengeProgressionStatusRenderer.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr, "button");
			ChallengeProgressionStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr, 100665452);
			ChallengeProgressionStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr, 100665453);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0004CBE4 File Offset: 0x0004ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512676, XrefRangeEnd = 512681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeProgressionStatusRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0004CC20 File Offset: 0x0004AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512681, XrefRangeEnd = 512684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeProgressionStatusRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressionStatusRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeProgressionStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000091F4 File Offset: 0x000073F4
		public ChallengeProgressionStatusRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0004CC5C File Offset: 0x0004AE5C
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x000091FD File Offset: 0x000073FD
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeProgressionStatusRenderer.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeProgressionStatusRenderer.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

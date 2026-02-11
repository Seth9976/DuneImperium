using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000080 RID: 128
	public class ProgressBar : AbstractProgressBar
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x00006C06 File Offset: 0x00004E06
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressBar()
		{
			Il2CppClassPointerStore<ProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ProgressBar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressBar>.NativeClassPtr);
			ProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressBar>.NativeClassPtr, 100665136);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0004A2C4 File Offset: 0x000484C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303043, XrefRangeEnd = 303047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressBar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressBar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00006C3F File Offset: 0x00004E3F
		public ProgressBar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B3 RID: 947
		public new class UxmlFactory : UxmlFactory<ProgressBar, AbstractProgressBar.UxmlTraits>
		{
			// Token: 0x0600392C RID: 14636 RVA: 0x00017F3F File Offset: 0x0001613F
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<ProgressBar.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProgressBar>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressBar.UxmlFactory>.NativeClassPtr);
				ProgressBar.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressBar.UxmlFactory>.NativeClassPtr, 100665137);
			}

			// Token: 0x0600392D RID: 14637 RVA: 0x000E89A0 File Offset: 0x000E6BA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303042, RefRangeEnd = 303043, XrefRangeStart = 303039, XrefRangeEnd = 303042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressBar.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressBar.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600392E RID: 14638 RVA: 0x00017F73 File Offset: 0x00016173
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400287E RID: 10366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

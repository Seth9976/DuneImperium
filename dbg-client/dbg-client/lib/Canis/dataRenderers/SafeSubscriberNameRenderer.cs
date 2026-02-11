using System;
using boardgames.datarenderers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lib.canis.dataRenderers
{
	// Token: 0x02000031 RID: 49
	public class SafeSubscriberNameRenderer : SubscriberNameRenderer
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x000235D4 File Offset: 0x000217D4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSubscriberNameRenderer()
		{
			Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dataRenderers", "SafeSubscriberNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr);
			SafeSubscriberNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr, 100663598);
			SafeSubscriberNameRenderer.NativeMethodInfoPtr_safeName_Protected_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr, 100663599);
			SafeSubscriberNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr, 100663600);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00023640 File Offset: 0x00021840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497909, XrefRangeEnd = 497913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeSubscriberNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0002367C File Offset: 0x0002187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497913, XrefRangeEnd = 497914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string safeName(string unsafeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unsafeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberNameRenderer.NativeMethodInfoPtr_safeName_Protected_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000236C4 File Offset: 0x000218C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497914, XrefRangeEnd = 497915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSubscriberNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSubscriberNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSubscriberNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002C52 File Offset: 0x00000E52
		public SafeSubscriberNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_safeName_Protected_String_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

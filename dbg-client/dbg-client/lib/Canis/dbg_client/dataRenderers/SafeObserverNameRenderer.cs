using System;
using dbgclient.dataRenderers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lib.canis.dbg_client.dataRenderers
{
	// Token: 0x0200003A RID: 58
	public class SafeObserverNameRenderer : ObserverNameRenderer
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00024F18 File Offset: 0x00023118
		// Note: this type is marked as 'beforefieldinit'.
		static SafeObserverNameRenderer()
		{
			Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.dataRenderers", "SafeObserverNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr);
			SafeObserverNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr, 100663671);
			SafeObserverNameRenderer.NativeMethodInfoPtr_safeName_Protected_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr, 100663672);
			SafeObserverNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr, 100663673);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00024F84 File Offset: 0x00023184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498326, XrefRangeEnd = 498329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeObserverNameRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00024FC0 File Offset: 0x000231C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string safeName(string unsafeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unsafeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeObserverNameRenderer.NativeMethodInfoPtr_safeName_Protected_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00025008 File Offset: 0x00023208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498329, XrefRangeEnd = 498330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeObserverNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeObserverNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeObserverNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00003019 File Offset: 0x00001219
		public SafeObserverNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_safeName_Protected_String_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.events
{
	// Token: 0x020000AD RID: 173
	public static class ContextEventUtils : Object
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x0003A188 File Offset: 0x00038388
		// Note: this type is marked as 'beforefieldinit'.
		static ContextEventUtils()
		{
			Il2CppClassPointerStore<ContextEventUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "ContextEventUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextEventUtils>.NativeClassPtr);
			ContextEventUtils.NativeMethodInfoPtr_EventSource_Public_Static_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextEventUtils>.NativeClassPtr, 100664968);
			ContextEventUtils.NativeMethodInfoPtr_EventTarget_Public_Static_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextEventUtils>.NativeClassPtr, 100664969);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0003A1E0 File Offset: 0x000383E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559236, XrefRangeEnd = 559244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Entity EventSource(this Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextEventUtils.NativeMethodInfoPtr_EventSource_Public_Static_Entity_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0003A224 File Offset: 0x00038424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559244, XrefRangeEnd = 559252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Entity EventTarget(this Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextEventUtils.NativeMethodInfoPtr_EventTarget_Public_Static_Entity_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005363 File Offset: 0x00003563
		public ContextEventUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_EventSource_Public_Static_Entity_Context_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_EventTarget_Public_Static_Entity_Context_0;
	}
}
